using FastConsig.Common.Helpers;
using FastConsig.Common.Loggin;
using FastConsig.Common.Services;
using FastConsig.Consignado.Business;
using FastConsig.Consignado.Entity;
using FastConsig.Consignado.Model;
using FastConsig.Core.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace FastConsig.Consignado.Services
{
   public class ConsignadoService
   {
      //
      /// <summary>
      /// Job aguardando execução
      /// </summary>
      private const string job_fila_integracao_status_aguardando = "NOK";

      /// <summary>
      /// Job processado
      /// </summary>
      private const string job_fila_integracao_status_processado = "OK";

      /// <summary>
      /// Job com erro no processamento
      /// </summary>
      private const string job_fila_integracao_status_error = "Error";

      /// <summary>
      /// Job com erro encerrado execução
      /// </summary>
      private const string job_fila_integracao_status_encerrado = "Closed";

      #region *------- Implementação do Singleton -------*

      /// <summary>Instância do serviço de evento.</summary>
      private static ConsignadoService _instance;

      private ConsignadoService() { }

      /// <summary>
      /// Obtém a instancia do serviço de Fila Integração Legado
      /// </summary>
      /// <returns></returns>
      public static ConsignadoService GetInstance() => _instance ?? (_instance = new ConsignadoService());

      #endregion

      #region *------------- Status --------------*

      #endregion

      /// <summary>
      /// Obter mensagens que ainda não foram processadas, ou seja mensagens com os status
      /// "Em Fila de Processamento" e "Em Processamento"
      /// e que o job informado não tenha excedido o limite de execução.
      /// </summary>
      /// <returns></returns>
      public List<FilaModel> ObterMensagensNaoProcessadas(int? idJob)
      {
         // lista conténdo mensagens não processadas...
         var ListaMensagensNaoProcessadas = new List<FilaModel>();

         // recuperando mensagens que ainda não foram processadas, ou seja mensagens com o status "Em Fila de Processamento" e "Em Processamento"...
         var mensagensNaoProcessadas = ObterMensagensNaoProcessadas();

         // thread safety
         lock (mensagensNaoProcessadas)
         {
            // para cada mensagem necessário veriicar se já existe um job rodando, caso não 
            foreach (var mensagem in mensagensNaoProcessadas)
            {
               // buscando a lista de jobs que serão processados
               var job = new JobFilaJobBusiness().ObterJob(idJob, mensagem.Id);

               // caso não tenha Jobs proxima mensagem
               if (job == null)
                  continue;

               // job com status de processado não entra na fila de processamento novamente
               if (job?.Status == job_fila_integracao_status_processado)
                  continue;

               // job com status de encerrado não entra na fial de processamento
               if (job?.Status == job_fila_integracao_status_encerrado)
                  continue;

               // colocar aqui o predecessor
               if (job.Predecessor.HasValue)
               {
                  var jobPredecessor = new JobFilaJobBusiness().ObterJob(job.Predecessor, mensagem.Id);

                  if (jobPredecessor.Status == job_fila_integracao_status_aguardando || jobPredecessor.Status == job_fila_integracao_status_error)
                     continue;
               }

               // verificando se o Job não excedeu o limite de tentativa
               if (!LimiteExcedidoJob(idJob, mensagem.Id))
                  ListaMensagensNaoProcessadas.Add(new FilaModel() { Id = mensagem.Id, IdStatus = mensagem.IdStatus, Mensagem = mensagem.Mensagem });
            }
         }

         return ListaMensagensNaoProcessadas;
      }

      /// <summary>
      /// Obter mensagens que ainda não foram processadas, ou seja mensagens com os status
      /// "Em Fila de Processamento" e "Em Processamento"
      /// e que o job informado não tenha excedido o limite de execução.
      /// </summary>
      /// <returns></returns>
      protected List<JobFila> ObterMensagensNaoProcessadas() => new JobFilaBusiness().ObterMensagensNaoProcessadas();

      /// <summary>
      /// Resposanvél por obter Tentativas
      /// </summary>
      /// <returns></returns>
      protected List<JobFilaJob> ObterJobs(long? idFilaIntegracaoLegado) => new JobFilaJobBusiness().ObterJobs(idFilaIntegracaoLegado);

      /// <summary>
      /// Resposanvél por obter a quantidade de tentativas já executada.
      /// </summary>
      /// <param name="idJob"></param>
      /// <param name="IdFilaIntegracaoLegado"></param>
      /// <returns></returns>
      protected bool LimiteExcedidoJob(int? idJob, long? IdFilaIntegracaoLegado)
      {
         var idFila = new JobFilaJobBusiness().ObterJob(idJob, IdFilaIntegracaoLegado)?.Id;

         return new JobFilaJobTentativaBusiness().Obter(idFila).Count >= ObterConfiguracaoJob(idJob).TentativasExecucao;
      }

      /// <summary>
      /// Resposavél por adicionar uma nvoa mensagem da Fila.
      /// </summary>
      /// <param name="model">Modelo</param>
      /// <returns>Id da Fila</returns>
      public long? AdicionarFila(object model, int idjob, bool IncludeIgnored = false)
      {
         JobFila filaObj = null;

         if (IncludeIgnored)
            filaObj = new JobFila() { Mensagem = JsonConvert.SerializeObject(model, Newtonsoft.Json.Formatting.Indented, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore, ContractResolver = new IncludeIgnored(true) }), IdStatus = (int)FilaStatusEnum.EmFilaProcessamento };
         else
            filaObj = new JobFila() { Mensagem = JsonConvert.SerializeObject(model, Newtonsoft.Json.Formatting.Indented), IdStatus = (int)FilaStatusEnum.EmFilaProcessamento };

         TransactionHelper.Run(TransactionScopeOption.Required, () =>
         {

            var filaJob = new JobFilaJobBusiness();

            /// incluindo na fila de processamento...
            new JobFilaBusiness().Incluir(filaObj);

            // certificando operação e validando se já não existe o mesmo Job com o Id Fila para processamento
            if (filaJob.ObterJob(idjob, filaObj.Id) == null)
               filaJob.Incluir(new JobFilaJob() { IdFila = filaObj.Id, IdJob = idjob, Status = job_fila_integracao_status_aguardando });
         });

         return filaObj.Id;
      }

      /// <summary>
      /// Resposavél por adicionar uma nvoa mensagem da Fila.
      /// </summary>
      /// <param name="model">Modelo.</param>
      /// <param name="Jobs">Lista de jobs que serao executados em conjunto.</param>
      /// <returns>Id da Fila</returns>
      public long? AdicionarFila(object model, Dictionary<int, int?> Jobs)
      {
         /// serializando o objeto pessoa model
         var filaObj = new JobFila() { Mensagem = JsonConvert.SerializeObject(model, Newtonsoft.Json.Formatting.Indented), IdStatus = (int)FilaStatusEnum.EmFilaProcessamento };

         TransactionHelper.Run(TransactionScopeOption.Required, () =>
         {

            var filaJob = new JobFilaJobBusiness();

            /// incluindo na fila de processamento...
            new JobFilaBusiness().Incluir(filaObj);

            // percorrendo a lista de jobs
            // para inserir na mesma fila os jobs
            // que serao processados em conjunto
            // informar o predecessor
            foreach (var job in Jobs)
            {
               // certificando operação e validando se já não existe o mesmo Job com o Id Fila para processamento
               if (filaJob.ObterJob(job.Key, filaObj.Id) == null)
                  filaJob.Incluir(new JobFilaJob() { IdFila = filaObj.Id, IdJob = job.Key, Status = job_fila_integracao_status_aguardando, Predecessor = job.Value });
            }
         });

         return filaObj.Id;
      }

      /// <summary>
      /// Resposanvél por obter a configuração do Job para a Fila de Integração Legado.
      /// </summary>
      /// <returns></returns>
      public ConfiguracaoJob ObterConfiguracaoJob(int? idJob) => new ConfiguracaoJobBusiness().ObterConfigJob(idJob);

      /// <summary>
      /// Resposanvél por atualizar informações do Job e persistir uma tentantiva de execução.
      /// </summary>
      /// <param name="job">Identificador do Job</param>
      /// <param name="IdFila">Id da Fila</param>
      /// <param name="Content">Contéudo de execução do Job</param>
      public void AtualizarJobFilaLegado(Job job, long? IdFila, string Content)
      {
         TransactionHelper.Run(TransactionScopeOption.Required, () =>
         {
            var jobFilaIntegracao = new JobFilaJobBusiness().ObterJob(job.Id, IdFila);

            // atualizando o body (resultado da chamado do barramento)
            jobFilaIntegracao.Content = Content;

            // referênciando o Job Tentativa
            jobFilaIntegracao.IdJobTentativa = job.idJobTentativa;

            if (job.IdJobStatus == JobStatus.PROCESSADO)
               jobFilaIntegracao.Status = job_fila_integracao_status_processado;
            else if (job.IdJobStatus == JobStatus.ERRO)
               jobFilaIntegracao.Status = job_fila_integracao_status_error;
            else if (job.IdJobStatus == JobStatus.ENCERRADO)
               jobFilaIntegracao.Status = job_fila_integracao_status_encerrado;

            // persistindo alterações na Fila Integração Job
            new JobFilaJobBusiness().Alterar(jobFilaIntegracao);

            // registrando as ocorrências de execução do Job
            new JobFilaJobTentativaBusiness().Incluir(new JobFilaJobTentativa() { IdFilaJob = jobFilaIntegracao.Id, IdJobTentativa = job?.idJobTentativa });
         });
      }

      /// <summary>
      /// Resposanvél por reorganizar a fila de processamento de acordo status de cada job executado.
      /// </summary>
      public void ReoganizarFila()
      {
         // obténdo lista de mensagens com o status abaixo
         // Em Fila de Processamento
         // Em Processamento
         // Não Processada - Reprocessamento caso o Job não tenha excedido o limite de tentantiva
         var mensagensNaoProcessadas = ObterMensagensNaoProcessadas();

         foreach (var fila in mensagensNaoProcessadas)
         {
            // obténdo a lista de jobs de cada mensagem
            var filaJobs = ObterJobs(fila.Id);

            // verificando se cada job da fila já teve seu limite de processamento ultrapassado
            // caso não tenha feito pego o proximo item na lista de iteração
            // caso já tenha feito atualizo o status da Fila.
            if (filaJobs.All(c => c.Status == job_fila_integracao_status_error) && filaJobs.FindAll(c => LimiteExcedidoJob(c.IdJob, c.IdFila) == true).Count == 0)
               continue;

            // procurando Job com status de processado
            var jobHasFinally = filaJobs.All(c => c.Status == job_fila_integracao_status_processado);

            // procurando Job com status de error
            var jobHasError = filaJobs.Any(c => c.Status == job_fila_integracao_status_error);

            // procurando Job com status de encerrado
            var jobClosed = filaJobs.Any(c => c.Status == job_fila_integracao_status_encerrado);

            if (jobHasFinally)
            {
               // validando se teve mudanças no status da fila atual, necessario para não impactar o banco
               if (fila.IdStatus == (int)FilaStatusEnum.Processada)
                  continue;

               fila.IdStatus = (int)FilaStatusEnum.Processada;
            }
            else if (jobHasError)
            {
               // validando se teve mudanças no status da fila atual, necessario para não impactar o banco
               if (fila.IdStatus == (int)FilaStatusEnum.NaoProcessada)
                  continue;

               fila.IdStatus = (int)FilaStatusEnum.NaoProcessada;
            }
            else if (jobClosed)
            {
               // validando se teve mudanças no status da fila atual, necessario para não impactar o banco
               if (fila.IdStatus == (int)FilaStatusEnum.NaoProcessada)
                  continue;

               fila.IdStatus = (int)FilaStatusEnum.NaoProcessada;
            }
            else
            {
               // validando se teve mudanças no status da fila atual, necessario para não impactar o banco
               if (fila.IdStatus == (int)FilaStatusEnum.EmProcessamento)
                  continue;

               fila.IdStatus = (int)FilaStatusEnum.EmProcessamento;
            }

            // persisitindo alteração de status da Fila
            new JobFilaBusiness().Alterar(fila);
         }
      }


      #region *------- Atualiza os dados/status dos Jobs -------*        

      public Job AtualizarJob(Job job, Exception ex = null)
      {
         TransactionHelper.Run(TransactionScopeOption.Required, () =>
         {
            JobTentativa tentativa = null;

            if (job.idJobTentativa.HasValue)
            {
               tentativa = new JobTentativaBusiness().Obtem(job.idJobTentativa);

               if (ex?.InnerException?.Message == "Job Encerrado")
               {
                  job.IdJobStatus = JobStatus.ENCERRADO;
                  tentativa.IdJobStatus = JobStatus.ENCERRADO;
               }
               else if (ex != null)
                  tentativa.IdJobStatus = JobStatus.ERRO;

               tentativa.Retorno = ex != null ? string.Format("[Exceção - {0}] - [StackTrace - {1}]", ex?.ToString(), ex?.StackTrace) : job.Result;

               new JobTentativaBusiness().Alterar(tentativa);
            }
            else
            {
               //*------- Grava uma nova tentativa de processamento...
               tentativa = new JobTentativa
               {
                  IdJob = job.Id,
                  IdJobStatus = job.IdJobStatus,
                  DtProcessamento = DateTime.Now,
                  Retorno = ex != null ? string.Format("[Exceção - {0}] - [StackTrace - {1}]", ex?.ToString(), ex?.StackTrace) : job.Result
               };

               new JobTentativaBusiness().Incluir(tentativa);

               // referenciando o Job Tentativa...
               job.idJobTentativa = tentativa.Id;
            }

            if (job.IdJobStatus == JobStatus.PROCESSANDO && ex != null)
               job.IdJobStatus = JobStatus.ERRO;

            new JobBusiness().Alterar(job);
         });

         //Retorna o Job já com o ID do banco...
         return job;
      }

      public void FinalizaJob(Job job)
      {
         TransactionHelper.Run(TransactionScopeOption.Required, () =>
         {
            var tentativa = new JobTentativaBusiness().Obtem(job.idJobTentativa);

            tentativa.IdJobStatus = JobStatus.PROCESSADO;

            tentativa.Retorno = job.Result;

            new JobTentativaBusiness().Alterar(tentativa);

            //Atualiza os principais dados do job...
            job.IdJobStatus = JobStatus.PROCESSADO;

            new JobBusiness().Alterar(job);
         });
      }

      #endregion

      #region *------- Envio de e-mail -------*        

      /// <summary>
      /// Envia o e-mail destinatários, informando que o processamento deste job foi concluido com ERRO.
      /// </summary>
      /// <param name="contexto">Contexto de execução do job.</param>
      /// <param name="job">Informações do job em processamento.</param>
      /// <param name="exception">Exception</param>
      public void NotificarErroJob(ConfiguracaoJobModel contexto, Exception exception = null)
      {
         try
         {
            if (contexto.Environment == null)
               contexto.Environment = ConfigurationManager.AppSettings["Environment"] ?? string.Empty;

            if (string.IsNullOrEmpty(contexto.Environment))
               throw new Exception("Environment não localizado!");

            //Obtém a configuração atual para envio de e-mail...
            var config = ObterMailConfig();

            //Parâmetros para substituição no template do e-mail...
            var parametros = new Dictionary<string, object>
                        {
                    { "{{email.to}}", config.EmailFrom },
                    { "{{email.bcc}}", contexto.EmailAvisoErro },
                    { "{{job.Name}}", contexto.NomeJob },
                    { "{{job.DataProcessamento}}", contexto.DataProcessamento?.ToString("dd/MM/yyyy HH:mm:ss") },
                    { "{{job.Exception}}", Extensions.ExceptionToJson(exception) },
                    { "{{job.idFila}}", contexto.idFila },
                    { "{{job.Environment}}", contexto.Environment }
                };

            // Obtém o template para este email...
            //TODO: Implementar
            var emailtemplate = TemplateService.GetInstance().TemplateEmail(104);

            var template = TemplateHelper.CarregarTemplate(emailtemplate.Template);

            //Faz as substituições do template...
            template.BodyContent = template.BodyContent
                                            .Replace("{{job.Name}}", parametros["{{job.Name}}"]?.ToString())
                                            .Replace("{{job.DataProcessamento}}", parametros["{{job.DataProcessamento}}"]?.ToString())
                                            .Replace("{{job.Exception}}", parametros["{{job.Exception}}"]?.ToString())
                                            .Replace("{{job.Environment}}", parametros["{{job.Environment}}"]?.ToString())
                                            .Replace("{{job.idFila}}", parametros["{{job.idFila}}"]?.ToString())
                                            .MinifyHTML();

            //Envia o email para o(s) usuário(s)...            
            var assunto = string.Format("Notificação de processamento COM ERRO - {0}", parametros["{{job.Name}}"]?.ToString());
            var destinatario = string.Empty;

            if (parametros.ContainsKey("{{email.to}}"))
               destinatario = parametros["{{email.to}}"]?.ToString();
            destinatario = destinatario.IsValidEmail() ? destinatario : null;

            string copiaPara = null;
            if (parametros.ContainsKey("{{email.bcc}}"))
               copiaPara = parametros["{{email.bcc}}"]?.ToString();

            //Envia o e-mail como "Background Thread"...
            //Task.Run(() => MailHelper.SendMail(config, destinatario, copiaPara, assunto, template));
#if DEBUG
            MailHelper.SendMail(config, destinatario, copiaPara, assunto, template);
#endif

#if !DEBUG
            System.Threading.Tasks.Task.Run(() => MailHelper.SendMail(config, destinatario, copiaPara, assunto, template));
#endif
         }
         catch (Exception ex)
         {
            LogService.GetInstance().GravarLogErro(ex, ex.Message);
         }
      }

      #endregion

      #region *------- Métodos Privados -------*

      /// <summary>
      /// Obtém as configurações para envio de e-mail.
      /// </summary>
      /// <returns></returns>
      private MailConfig ObterMailConfig()
      {
         return new MailConfig
         {
            SmtpServer = ConfiguracaoService.GetInstance().Config<string>("fastconsig.email.smtp.server"),
            SmtpPort = ConfiguracaoService.GetInstance().Config<int>("fastconsig.email.smtp.port"),
            UseSSL = ConfiguracaoService.GetInstance().Config<bool>("fastconsig.email.smtp.enablessl"),
            EmailFrom = ConfiguracaoService.GetInstance().Config<string>("fastconsig.email.smtp.userfrom"),
            Login = ConfiguracaoService.GetInstance().Config<string>("fastconsig.email.smtp.user"),
            Password = ConfiguracaoService.GetInstance().Config<string>("fastconsig.email.smtp.password")
         };
      }

      #endregion
   }
}
