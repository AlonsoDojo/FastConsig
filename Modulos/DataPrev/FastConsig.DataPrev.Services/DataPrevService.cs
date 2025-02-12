using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using static System.Net.Mime.MediaTypeNames;
using Newtonsoft.Json;
using FastConsig.Common.Services;
using FastConsig.Core.Services;
using FastConsig.Common.Loggin;
using FastConsig.Core.Entity;
using FastConsig.Consignado.Model.DataPrev;
using FastConsig.Common.Model;
using FastConsig.Common.Integracao;
using RestSharp;
using FastConsig.Consignado.Model;
using FastConsig.Core.Model;
using FastConsig.Seguranca.Entity;
using FastConsig.DataPrev.Services.Exceptions;
using FastConsig.Consignado.Entity;
using FastConsig.Consignado.Business;
using FastConsig.DataPrev.Services.Validators;
using FluentValidation;
using FastConsig.Common.Helpers;
using FastConsig.Consignado.Services;

namespace FastConsig.DataPrev.Services
{
   public class DataPrevService
   {
      #region *------------------------------- Construtor -------------------------*

      public DataPrevService()
      {
         pathBase = ConfiguracaoService.GetInstance().Config<string>("consignado.dataprev.url");
      }

      #endregion

      #region *----------------------------- Propriedades -------------------------*

      /// <summary>
      /// Endereço base
      /// </summary>
      string pathBase;

      const bool enableLogTracking = true;

      readonly string urlCertificado = string.Concat(AppDomain.CurrentDomain.BaseDirectory.Trim(), ConfiguracaoService.GetInstance().Config<string>("consignado.dataprev.certificado.url"));

      readonly string passwordCertificado = ConfiguracaoService.GetInstance().Config<string>("consignado.dataprev.certificado.password");

      /// <summary> Job de averbação </summary>
      readonly int jobAverbacao = ConfiguracaoService.GetInstance().Config<int>("consignado.dataprev.job.dataprevservice");

      /// <summary> Job de averbação </summary>
      readonly int jobExclusaoAverbacao = ConfiguracaoService.GetInstance().Config<int>("consignado.dataprev.job.exclusao.dataprevservice");

      /// <summary> Job de informacaoComplementarContrato </summary>
      readonly int jobRefinanciamento = ConfiguracaoService.GetInstance().Config<int>("consignado.dataprev.job.refinanciamento.dataprevservice");

      /// <summary> Job de Informação Complementar Contrato </summary>
      readonly int jobInformacaoComplementarContrato = ConfiguracaoService.GetInstance().Config<int>("consignado.dataprev.job.informacaocomplementar.dataprevservice");

      /// <summary> Código do banco </summary>
      readonly int codigoSolicitante = ConfiguracaoService.GetInstance().Config<int>("consignado.dataprev.certificado.codigosolicitante");

      /// <summary> </summary>
      readonly int ocorrenciaRestritiva = ConfiguracaoService.GetInstance().Config<int>("consignado.dataprev.proposta.ocorrencia");

      /// <summary> Validar Autorização no momento de enviar uma solicitação de Averbação? </summary>
      readonly bool validarAutorizacaoAverbacao = ConfiguracaoService.GetInstance().Config<bool>("consignado.dataprev.averbacao.validarautorizacao");

      /// <summary> Validar Autorização no momento de enviar uma solicitação de Refinanciamento? </summary>
      readonly bool validarAutorizacaoRefinanciamento = ConfiguracaoService.GetInstance().Config<bool>("consignado.dataprev.refinanciamento.validarautorizacao");

      /// <summary> Tipo de documento contrato CCB </summary>
      readonly int tipoDocumentoContrato = ConfiguracaoService.GetInstance().Config<int>("consignado.dataprev.job.informacaocomplementar.tipodocumento.contrato");

      /// <summary> Path do job de Informação Complementar </summary>
      readonly string jobInformacaoComplementarPath = ConfiguracaoService.GetInstance().Config<string>("consignado.dataprev.job.informacaocomplementar.path");

      /// <summary> Path do API </summary>
      readonly string rootAPIPath = String.Concat(ConfiguracaoService.GetInstance().Config<string>("consignado.dataprev.api.rootpath"), ConfiguracaoService.GetInstance().Config<string>("consignado.dataprev.api.version"));

      /// <summary> </summary>
      readonly string component = typeof(DataPrevService).Assembly.GetName().Name;

      /// <summary>
      /// 
      /// </summary>
      public List<JobConsignadoOcorrencia> consignadoOcorrencia { get; set; }

      #endregion

      #region *------------------------------ Singleton ---------------------------*

      private static DataPrevService _instance;

      /// <summary>
      /// Obtém a instância do serviço de DataPrev.
      /// </summary>
      /// <returns></returns>
      public static DataPrevService GetInstance() => _instance ?? (_instance = new DataPrevService());

      #endregion

      #region *--------------------------- Métodos Privados -----------------------*

      /// <summary>
      /// Obtém um novo token de acesso
      /// </summary>
      /// <returns></returns>
      private AcessTokenResponseModel GerarAcessToken()
      {
         if (System.Net.ServicePointManager.SecurityProtocol == (SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls))
            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;

         //create obj request
         var execute = new ExecuteRequest(ConfiguracaoService.GetInstance().Config<string>("consignado.dataprev.auth.url"), "token");

         //execute request cep
         var response = execute.RequestAuthorizationAuthO2(string.Empty, Method.POST, ConfiguracaoService.GetInstance().Config<string>("consignado.dataprev.auth.consumerkey"), ConfiguracaoService.GetInstance().Config<string>("consignado.dataprev.auth.consumersecret"), urlCertificado, passwordCertificado);

         //status: 200 - Execução com sucesso
         if (response.StatusCode == HttpStatusCode.OK)
            return JsonConvert.DeserializeObject<AcessTokenResponseModel>(response.Content);

         //Status: 403 - Token inválido...
         if (response.StatusCode == HttpStatusCode.Forbidden)
            throw new Exception(string.Format("Token inválido ({0} - {1})", response.StatusCode, response.StatusDescription));

         if (response.ErrorException != null) //Erro generico
            throw response.ErrorException;

         throw new Exception(string.Format("{0} - {1}", response.StatusCode, response.StatusDescription));
      }

      /// <summary>
      /// Obtém o acess token atual ou um novo de acordo com a data de validade
      /// </summary>
      /// <returns></returns>
      //TODO: Reescrever o LogTracer
      //[LogTracer(enableInfo = enableLogTracking, responseSave = true, provider = LogTracerProvider.file)]
      private string ObterAcessToken(bool forcar = false)
      {
         AcessTokenResponseModel tokenAtual = null;

         // recuperando o acess token
         var acess_tokens = ConfiguracaoService.GetInstance().Config<string>("consignado.dataprev.acess_token");

         if (forcar)
            return ObterNovoAcessToken();

         // token ainda não foi criado?
         if (acess_tokens == null)
            return ObterNovoAcessToken();
         else
            tokenAtual = JsonConvert.DeserializeObject<AcessTokenResponseModel>(acess_tokens);

         // token atual ainda é valido?
         if (DateTime.Now > tokenAtual.Date)
            return ObterNovoAcessToken();

         return tokenAtual.AccessToken.ToString();
      }

      /// <summary>
      /// Obtém um novo acess token
      /// </summary>
      /// <returns></returns>
      private string ObterNovoAcessToken()
      {
         // gerando um novo acess token 
         var acess_token = GerarAcessToken();

         // adicionando tempo de validade para 59 minutos conforme documentação
         acess_token.Date = DateTime.Now.AddSeconds(acess_token.ExpiresIn.Value);

         // persistindo alteração
         ConfiguracaoService.GetInstance().Salvar(new Configuracao { Chave = "consignado.dataprev.acess_token", Conteudo = Newtonsoft.Json.JsonConvert.SerializeObject(acess_token) });

         return acess_token.AccessToken.ToString();
      }

      /// <summary>
      /// Inserir ocorrência na proposta.
      /// </summary>
      /// <param name="contexto">Contexto</param>
      /// <param name="consignado">Autorização Consignado</param>
      /// <param name="erros">Erros</param>
      protected void InserirOcorrenciaProposta<T>(ConfiguracaoJobModel contexto, T consignado, string erros) where T : PropostaBaseModel
      {
         try
         {
            PropostaService.GetInstance().InsereOcorrencia(consignado.Proposta, ocorrenciaRestritiva, erros, "S", "System");
         }
         catch (Exception ex)
         {
            LogService.GetInstance().Error(LogTracerProvider.file, consignado?.CpfCnpj.ToString(), component: component, exception: ex);

            //Notifica o erro ocorrido...
            try { ConsignadoService.GetInstance().NotificarErroJob(contexto, ex); } catch { }
         }
      }

      /// <summary>
      /// Submete a proposta para a proxima fase
      /// </summary>
      /// <param name="idProposta"></param>
      /// <exception cref="Exception"></exception>
      protected void SubmeterProposta(long? idProposta)
      {
         if (System.Net.ServicePointManager.SecurityProtocol == (SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls))
            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;

         //Create obj request
         var execute = new ExecuteRequest(ConfiguracaoService.GetInstance().Obter("fastconsig.api").Conteudo, string.Empty, "/Proposta/SubmeterProposta");

         //create parameters
         var parameters = new Dictionary<string, string> {
                { "Proposta", idProposta.ToString() }
            };

         //execute request produtos
         var response = execute.Request(string.Empty, parameters);

         //Status: 200 - Execução com sucesso.
         if (response.StatusCode == HttpStatusCode.OK)
         {
            if (string.IsNullOrEmpty(response.Content))
               return;
            else
               throw new Exception(response.Content);
         }

         if (response.StatusCode == HttpStatusCode.Forbidden) //Status: 403 - Token inválido.
            throw new Exception(string.Format("Token inválido ({0} - {1})", response.StatusCode, response.StatusDescription));
         else if (response.ErrorException != null) //Erro generico
            throw response.ErrorException;
         else
            throw new Exception(string.Format("{0} - {1}", response.StatusCode, response.StatusDescription));
      }

//      //TODO: Rever
//      /// <summary>
//      /// 
//      /// </summary>
//      /// <param name="proposta"></param>
//      protected void ObterInformacaoComplementar(PropostaModel proposta, Func<long?, ClickSignEnvelope> obterEnvelope, Func<ConsultaModel, CacheConsultaModel> obterConsulta)
//      {
//         try
//         {
//            if (!(proposta.Fase == "INTEGRAÇÃO" && proposta.Status == "CONCLUIDO") &&
//                !(proposta.Fase == "AVERBAÇÃO" && proposta.Status == "REJEITADA") &&
//                !(proposta.Fase == "INTEGRAÇÃO" && proposta.Status == "REJEITADA"))
//               throw new Exception("Não é possível criar solicitação de envio de informações complementares, proposta não está na fase correta!s");

//            PropostaService.GetInstance().InsereOcorrencia(proposta.Id, 62, "Enviado informações complementares do contrato para DataPrev", "N", "System");

//            var consignado = new ConsignadoAutorizacaoModel();

//            var autorizacao = DataPrevService.GetInstance().ConsultarAutorizacao(proposta.Operacoes[0].Autorizacao);

//            if (autorizacao == null)
//               throw new Exception("Não é possível criar solicitação de envio de informações complementares sem autorização!");

//            autorizacao.Proposta = proposta.Id;
//            autorizacao.UsuarioExecucao = "System";
//            autorizacao.CpfCnpj = long.Parse(proposta.Proponente.CpfCnpj);
//            autorizacao.Fase = proposta?.Fase ?? null;

//            if (!proposta.Id.HasValue)
//               throw new Exception("Não é possível criar solicitação de envio de informações complementares sem o número da proposta!");

//            // buscando informações do produto
//            var produto = PropostaService.GetInstance().ObtemProduto(proposta.Operacoes.Produto);

//            // parametrização do produto
//            dynamic parametros = JsonConvert.DeserializeObject(produto.Parametros);

//            MemoryStream CCB = new MemoryStream();

//            byte[] CCBPDFA = null;

//            try
//            {
//               CCBPDFA = PropostaService.GetInstance().ObterDocumento(proposta.Id.Value, tipoDocumentoContrato);

//#if DEBUG
//               System.IO.File.WriteAllBytes(proposta.Id.ToString() + ".pdf", CCBPDFA);
//#endif
//            }
//            catch (Exception ex)
//            {
//               throw new Exception("Falha ao tentar obter a CCB", ex);
//            }

//            // recuperando resposta do CAF
//            var combateFraude = CombateaFraudeService.GetInstance().Obter(proposta.Id);

//            if (combateFraude == null)
//               throw new Exception("Combate a Fraude não localizado.");

//            if (combateFraude.Detalhe == null)
//               combateFraude.Detalhe = CombateaFraudeService.GetInstance().ConsultarTransacaoV2(JsonConvert.DeserializeObject<CombateaFraudeRGResponseModel>(combateFraude.Resposta)._id);

//            // obténdo detalhe da consulta do CAF
//            dynamic combateFraudeDetalhe = JsonConvert.DeserializeObject(combateFraude.Detalhe);

//            // obténdo envelope CCB ClickSign
//            var envelope = obterEnvelope(proposta.Id);

//            // Indica que o processo teve geolocalização
//            var geolocalizacao = true;

//            // IP do usuário
//            var userIp = string.Empty;

//            try
//            {
//               /*
//                   Evelope nulo?
//                       Então a assinatura foi física, por isso recuperando o IP parametrizado do Banco. 
//                       Mesmo a assinatura ocorrendo na promotora, para o INSS a promotora é dentro do perímetro seguro do banco.
//               */
//               if (envelope == null) userIp = ConfiguracaoService.GetInstance().Config<string>("consignado.dataprev.job.informacaocomplementar.autorizacaofisica.IPBanco");

//               try
//               {
//                  if (combateFraudeDetalhe?.attributes?.acceptedTermsData != null || combateFraudeDetalhe?.attributes?.acceptedTermsData[0]?.userIp != null)
//                     userIp = combateFraudeDetalhe?.attributes?.acceptedTermsData[0]?.userIp;
//               }
//               catch { }

//               if (string.IsNullOrWhiteSpace(userIp))
//               {
//                  var consulta = PropostaService.GetInstance().ListarConsultas(proposta.Proponente.Id).FirstOrDefault(c => c.Consulta == "Geolocalização");

//                  if (consulta == null || !consulta.IdConsulta.HasValue)
//                     throw new Exception("Erro ao obter IP/Geolocalização.");

//                  //Busca a Consulta no Cacheconsulta
//                  ConsultaModel consultaCache = new ConsultaModel();

//                  consultaCache.codigoAcesso = ConfiguracaoService.GetInstance().Config<string>("CacheConsulta.CodigoAcesso");
//                  consultaCache.IgnorarBalde = false;
//                  consultaCache.IdConsulta = consulta.IdConsulta;

//                  var retorno = obterConsulta(consultaCache);

//                  var result = JsonConvert.DeserializeObject<GeolocalizacaoResponseModel>(retorno.Conteudo, new JsonSerializerSettings() { Error = (sender, error) => error.ErrorContext.Handled = true });

//                  userIp = result.ip;
//               }

//               if (combateFraudeDetalhe?.metadata?.location == null || combateFraudeDetalhe?.metadata?.location?.latitude == null)
//                  geolocalizacao = false;

//               if (combateFraudeDetalhe?.metadata?.location == null || combateFraudeDetalhe?.metadata?.location?.longitude == null)
//                  geolocalizacao = false;

//               if (combateFraudeDetalhe?.metadata?.browser?.userAgent?.ToString().Substring(0, 40) == null)
//                  throw new Exception("Erro ao obter dispositivo - CAF.");
//            }
//            catch (Exception ex)
//            {
//               throw new Exception("Erro ao obter IP/Geolocalização/Dispositivo do CAF.", ex);
//            }

//            byte[] front = null;

//            byte[] back = null;

//            byte[] selfie = null;

//            try
//            {
//               if (combateFraude.front.Length <= 1)
//                  throw new Exception("Documento com foto frente está inválido.");

//               using (MemoryStream ms = new MemoryStream(combateFraude.front))
//                  front = ImageToByteArray(Image.FromStream(ms, true), combateFraude.front.Length > 1000000);

//               if (combateFraude.back.Length <= 1)
//                  combateFraude.back = combateFraude.front;

//               using (MemoryStream ms = new MemoryStream(combateFraude.back))
//                  back = ImageToByteArray(Image.FromStream(ms, true), combateFraude.back.Length > 1000000);

//               if (combateFraude.selfie.Length <= 1)
//                  throw new Exception("Selfie está inválido.");

//               using (MemoryStream ms = new MemoryStream(combateFraude.selfie))
//                  selfie = ImageToByteArray(Image.FromStream(ms, true), combateFraude.selfie.Length > 1000000);
//            }
//            catch (Exception ex)
//            {
//               throw new Exception("Erro ao tentar converter Octet-stream para JPE - CAF.", ex);
//            }

//            PFFaceResult pFFaceResult = null;

//            try
//            {
//               CacheConsulta.Model.DataValid.Request.PFFace.PFFaceInput datavalid = new CacheConsulta.Model.DataValid.Request.PFFace.PFFaceInput
//               {
//                  key = new CacheConsulta.Model.DataValid.Request.PFFace.key { cpf = proposta.Proponente.CpfCnpj },
//                  answer = new CacheConsulta.Model.DataValid.Request.PFFace.answer
//                  {
//                     nome = proposta.Proponente.Nome,
//                     sexo = proposta.Proponente.Sexo,
//                     nacionalidade = 1,
//                     data_nascimento = proposta.Proponente.DataNascimento.Value.ToString("yyyy-MM-dd"),
//                     situacao_cpf = "regular",
//                     filiacao = new CacheConsulta.Model.DataValid.Request.PFFace.filiacao
//                     {
//                        nome_mae = proposta.Proponente.Mae,
//                        nome_pai = proposta.Proponente.Pai
//                     },
//                     documento = new CacheConsulta.Model.DataValid.Request.PFFace.documento
//                     {
//                        tipo = proposta.Proponente.TipoDocumentoIdentidade.Value == 9 ? 1 : proposta.Proponente.TipoDocumentoIdentidade.Value,
//                        numero = proposta.Proponente.NumeroDocumentoIdentidade,
//                        orgao_expedidor = proposta.Proponente.OrgaoEmissorDescricao,
//                        uf_expedidor = proposta.Proponente.UFEmissaoDocumentoIdentidade
//                     },
//                     biometria_face = Convert.ToBase64String(selfie)
//                  }
//               };

//               ConsultaModel consulta = new ConsultaModel
//               {
//                  CpfCnpj = long.Parse(proposta.Proponente.CpfCnpj),
//                  NomeConsulta = "DataValid-PF-Face",
//                  codigoAcesso = ConfiguracaoService.GetInstance().Config<string>("CacheConsulta.CodigoAcesso"),
//                  IgnorarBalde = false,
//                  DataValid = datavalid
//               };

//               var retornoDataValid = obterConsulta(consulta);

//               if (retornoDataValid == null)
//                  throw new Exception("Erro ao tentar efetuar consulta DataValid-PF-Face");

//               if (string.IsNullOrWhiteSpace(retornoDataValid.Conteudo))
//                  throw new Exception("Conteúdo da consulta DataValid-PF-Face inválido.");

//               // result da biometria facial
//               pFFaceResult = JsonConvert.DeserializeObject<PFFaceResult>(retornoDataValid.Conteudo);

//               if (pFFaceResult == null)
//                  throw new Exception("Conteúdo da consulta DataValid-PF-Face inválido.");

//               if (!pFFaceResult.biometria_face.disponivel)
//                  PropostaService.GetInstance().GravarHistoricoProposta(proposta, "Biometria Facial não disponível.");
//            }
//            catch (Exception ex)
//            {
//               LogService.GetInstance().GravarLogErro(ex, ex.Message);
//               /*
//                  Deu algum na consulta da Serpo?Neste caso paraliza para ser analisado
//               */

//               // tratamento para não estourar erro 
//               pFFaceResult = new PFFaceResult { biometria_face = new biometria_face { disponivel = false } };

//               //throw new Exception("Erro ao tentar consultar biometria facial - Serpro DataValid-PF-Face.", ex);
//            }

//            InformacaoContratoRequestModel informacaoComplementar = new InformacaoContratoRequestModel
//            {
//               NumeroBeneficio = long.Parse(proposta.Proponente.NumeroBeneficio),
//               NumeroContrato = proposta.Operacoes.ContratoLegado,
//               ContratoEmprestimo = Convert.ToBase64String(CCBPDFA),
//               IndicadorAssinaturaCertDigitalIcpBrasil = false,
//               Ip = userIp,
//               IndicadorAnalfabetismo = proposta.Proponente.IndicadorAnalfabetismo,

//               RegistroBiometricoFacial = Convert.ToBase64String(selfie),
//               BaseBiometrica = "SERPRO",
//               Score = pFFaceResult?.biometria_face.similaridade,

//               IndicadorValidacaoComDocOficial = false,
//               DocumentoOficialComFotoFrente = Convert.ToBase64String(front),
//               DocumentoOficialComFotoVerso = Convert.ToBase64String(back),

//               Dispositivo = combateFraudeDetalhe.metadata.browser.userAgent.ToString().Substring(0, 40),
//               NsuContrato = proposta.Operacoes.ContratoLegado,
//               TipoAutenticacao = 1,

//               Proposta = proposta.Id,
//               CpfCnpj = long.Parse(proposta.Proponente.CpfCnpj),
//               Fase = proposta?.Fase ?? null
//            };

//            /*
//                 Envelope é nulo?
//            */
//            if (envelope == null)
//               informacaoComplementar.DataHoraAssinatura = autorizacao.DataHoraCriacaoTermo.HasValue ? autorizacao.DataHoraCriacaoTermo?.ToString("ddMMyyyyHHmmss") : autorizacao.DataHoraAutorizacaoDigital?.ToString("ddMMyyyyHHmmss");
//            else
//               informacaoComplementar.DataHoraAssinatura = envelope.DataAssinatura?.ToString("ddMMyyyyHHmmss");

//            /*
//                Quais são as faixas de similaridade biométrica definidas pelo Datavalid?
//                  O retorno das validações biométricas são definidas por faixa e percentual. De acordo com o percentual de semelhança, a faixa de probabilidade é identificada. As faixas se aplicam tanto para validação facial quanto para digital.
//                     Probabilidade	Faixas
//                     Altíssima probabilidade	100% - 93%
//                     Alta probabilidade	92,99% - 85%
//                     Baixa probabilidade	84,99% - 32%
//                     Baixíssima probabilidade	31,99% - 0%
//                  Score menor do 90% probabilidade baixa, neste caso informar que foi feita validação via documento com foto (CAF)
//             */

//            /*
//               Score é maior do que 85%?
//               Neste caso não precisa enviar os campos abaixo

//                  DocumentoOficialComFotoFrente (Limpar)
//                  DocumentoOficialComFotoVerso  (Limpar)
//                  IndicadorValidacaoComDocOficial (False)
//            */
//            if (pFFaceResult?.biometria_face?.probabilidade == "Altíssima probabilidade" || pFFaceResult?.biometria_face?.probabilidade == "Alta probabilidade")
//            {
//               informacaoComplementar.DocumentoOficialComFotoFrente = null;
//               informacaoComplementar.DocumentoOficialComFotoVerso = null;
//               informacaoComplementar.IndicadorValidacaoComDocOficial = false;
//            }

//            /*
//               Ocorreu algum erro na Serpro, ou Score é nulo/0/menor do 85%, 
//                  neste caso descartamos a Serpro e informamos para a DataPrev que a validação foi feita via documento oficial com foto.   
//                Informar que a validação foi feita via documento oficial nas condições abaixo
//                  - Erro na Serpro
//                  - Score nulo ou 0 de acordo com erro na Serpro
//                  - Biometria não disponivel, não é erro mas não retornou nada
//                  - Quando o Score for menor do que 85%

//            */
//            if (pFFaceResult?.biometria_face?.disponivel == false || pFFaceResult?.biometria_face?.probabilidade == "Baixa probabilidade" || pFFaceResult?.biometria_face?.probabilidade == "Baixíssima probabilidade")
//            {
//               informacaoComplementar.IndicadorValidacaoComDocOficial = true;
//               informacaoComplementar.RegistroBiometricoFacial = null;
//               informacaoComplementar.BaseBiometrica = null;
//               informacaoComplementar.Score = null;
//            }

//            if (geolocalizacao)
//            {
//               informacaoComplementar.Latitude = combateFraudeDetalhe.metadata.location.latitude;
//               informacaoComplementar.Longitude = combateFraudeDetalhe.metadata.location.longitude;
//            }

//            autorizacao.ConsignadoDetalhe.Beneficio.Beneficios.Clear();
//            autorizacao.ConsignadoDetalhe.Beneficio.Beneficios.Add(new Beneficio { InformacaoContrato = informacaoComplementar });

//            // enviando solicitação para informações complementares
//            DataPrevService.GetInstance().SolicitarInformacaoContrato(autorizacao);
//         }
//         catch (Exception ex)
//         {
//            try
//            {
//               var ocorencias = PropostaService.GetInstance().ListarOcorrencias(proposta.Id).Where(c => c.Ocorrencia == 62);

//               foreach (var item in ocorencias)
//                  PropostaService.GetInstance().ExcluirOcorrencia(new Ocorrencias { Id = (int)item.Id });

//            }
//            catch { }

//            string mensagemErro = "Falha ao enviar informações complementares para DataPrev: " + ex.Message;
//            LogService.GetInstance().GravarLogDebug(mensagemErro + " - Stacktrace: " + ex.StackTrace);
//            throw new Exception(mensagemErro, ex);
//         }
//      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="format"></param>
      /// <returns></returns>
      protected ImageCodecInfo GetEncoder(ImageFormat format)
      {
         ImageCodecInfo[] codecs = ImageCodecInfo.GetImageEncoders();

         foreach (ImageCodecInfo codec in codecs)
         {
            if (codec.FormatID == format.Guid)
               return codec;
         }

         return null;
      }

      /// <summary>
      /// Convertendo Image para byte[] reduzindo o quality
      /// </summary>
      /// <param name="imageIn"></param>
      /// <param name="reduceQuality"></param>
      /// <returns></returns>
      protected byte[] ImageToByteArray(System.Drawing.Image imageIn, bool reduceQuality = false)
      {
#if DEBUG
         // path da imagem que será salva com 50% de redução da qualidade
         var pathImage = string.Concat(Environment.CurrentDirectory, @"\Tmp\ImageReduziceQualityFifty.jpg");
#else
         // path da imagem que será salva com 50% de redução da qualidade
         var pathImage = string.Concat(jobInformacaoComplementarPath, @"\Tmp\ImageReduziceQualityFifty.jpg");
#endif

         try
         {
            // reduzir qualidade da imagem?
            if (reduceQuality)
            {
               // Get a bitmap. The using statement ensures objects  
               // are automatically disposed from memory after use.  
               using (Bitmap bmp1 = new Bitmap(imageIn))
               {
                  ImageCodecInfo jpgEncoder = GetEncoder(ImageFormat.Jpeg);

                  // Create an Encoder object based on the GUID  
                  // for the Quality parameter category.  
                  System.Drawing.Imaging.Encoder myEncoder = System.Drawing.Imaging.Encoder.Quality;

                  // Create an EncoderParameters object.  
                  // An EncoderParameters object has an array of EncoderParameter  
                  // objects. In this case, there is only one  
                  // EncoderParameter object in the array.  
                  EncoderParameters myEncoderParameters = new EncoderParameters(1);

                  EncoderParameter myEncoderParameter = new EncoderParameter(myEncoder, 50L);
                  myEncoderParameters.Param[0] = myEncoderParameter;
                  bmp1.Save(pathImage, jpgEncoder, myEncoderParameters);

                  // free file
                  bmp1.Dispose();
                  myEncoderParameter.Dispose();
               }

               imageIn = System.Drawing.Image.FromFile(pathImage);
            }

            using (var ms = new MemoryStream())
            {
               imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
               return ms.ToArray();
            }
         }
         finally
         {
            imageIn.Dispose();

            File.Delete(pathImage);
         }
      }

      /// <summary>
      /// Validando se a proposta está rejeitada, neste caso não é possível executar comandos de averbação ou rfinanciamento
      /// </summary>
      /// <param name="consignado"></param>
      /// <exception cref="DataPrevException"></exception>
      protected void CheckPropostaRejeitada(ConsignadoAutorizacaoModel consignado)
      {
         // obter proposta
         var proposta = PropostaService.GetInstance().ObterProposta((int)consignado.Proposta);

         /*
            Validando se a proposta está rejeitada ou se existe uma ocorrência que rejeitou e não foi liberada.
         */
         if (proposta.Status == 4 || proposta.Ocorrencias.Any(c => c.Ocorrencia == 1 && !c.Liberada))
         {
            PropostaService.GetInstance().IncluirHistorico(new PropostaHistorico { Proposta = consignado.Proposta, Usuario = "System", DataExecucao = DateTime.Now, Fase = (consignado.Fase != null ? consignado.Fase : 0), Acao = "AVERBAÇÃO NÃO EXECUTADA: PROPOSTA COM STATUS REJEITADA", Simulacao = consignado.Simulacao });

            // subindo exceção para paralizar o processamento da fila atual
            throw new DataPrevException("AVERBAÇÃO/REFINANCIAMENTO NÃO EXECUTADA: PROPOSTA COM STATUS REJEITADA", new Exception("Job Encerrado"));
         }
      }

      /// <summary>
      /// Validar se o produto pode rodar de acordo com o parâmetro de Dias Uteis Averbação.
      /// </summary>
      /// <param name="consignado"></param>
      /// <param name="validarFeriado"></param>
      /// <returns></returns>
      protected bool CheckProdutoExecucao(ConsignadoAutorizacaoModel consignado, Func<DateTime, bool> validarFeriado)
      {
         // obter proposta
         if (consignado.Proposta == null)
            return false;

         var proposta = PropostaService.GetInstance().ObterProposta((int)consignado.Proposta);

         // obter o produto
         var produto = PropostaService.GetInstance().ObtemProduto(proposta.Operacoes.Produto);

         // obter os parametros do produto
         dynamic parametros = JsonConvert.DeserializeObject(produto.Parametros);

         if (parametros?.DiasUteisAverbacao.Value == 0)
            return true;

         return DateTime.Now.Date >= Extensions.AddWorkdays(consignado.DataEnvioProcessamento, (int)parametros?.DiasUteisAverbacao?.Value - 1, validarFeriado).Date;
      }

      #endregion

      #region *-------------------------- Integração API DataPrev -----------------*

      /// <summary>
      /// Realiza averbação do contrato.
      /// </summary>
      /// <param name="model"></param>
      /// <returns></returns>
      /// <exception cref="System.Exception"></exception>
      /// <exception cref="DataPrevException">Erros</exception>
      //TODO: Reescrever o LogTracer
      //[LogTracer(enableInfo = enableLogTracking, responseSave = true, provider = LogTracerProvider.DB)]
      protected AverbacaoEmprestimoConsignadoResponseModel AverbacaoEmprestimoConsignado(AverbacaoEmprestimoConsignadoModel model)
      {
         if (System.Net.ServicePointManager.SecurityProtocol == (SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls))
            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;

         if (model == null)
            throw new DataPrevException("Modelo não pode ser nulo!");

         //create obj request
         var execute = new ExecuteRequest(pathBase, ObterAcessToken, rootAPIPath, true);

         //execute request cep
         var response = execute.RequestCertificate("emprestimos/averbar-consignado", Method.POST, urlCertificado, passwordCertificado, body: Newtonsoft.Json.JsonConvert.SerializeObject(model));

         //Status: 200 - Execução com sucesso.r
         if (response.StatusCode == System.Net.HttpStatusCode.OK)
            return Newtonsoft.Json.JsonConvert.DeserializeObject<AverbacaoEmprestimoConsignadoResponseModel>(response.Content);

         //Status: 200 - Execução com sucesso.r
         if (response.StatusCode == System.Net.HttpStatusCode.PreconditionFailed)
            return new AverbacaoEmprestimoConsignadoResponseModel { Erros = Newtonsoft.Json.JsonConvert.DeserializeObject<AverbacaoEmprestimoConsignadoErroModel>(response.Content) };

         throw new DataPrevException(TratarErrosResponse(response));
      }

      /// <summary>
      /// Solicitação da autorização da consulta de dados do benefício
      /// </summary>
      /// <param name="model">SolicitarAutorizacaoConsultaBeneficioModel</param>
      /// <returns></returns>
      /// <exception cref="System.Exception">Validação de modelo.</exception>
      //TODO: Reescrever o LogTracer
      //[LogTracer(enableInfo = enableLogTracking, responseSave = true, provider = LogTracerProvider.DB)]
      protected AutorizacaoConsultaBeneficioResponseModel AutorizacaoConsultaBeneficio(AutorizacaoConsultaBeneficioRequestModel model)
      {
         if (System.Net.ServicePointManager.SecurityProtocol == (SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls))
            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;

         if (model == null)
            throw new DataPrevException("Modelo não pode ser nulo!");

         //create obj request
         var execute = new ExecuteRequest(pathBase, ObterAcessToken, rootAPIPath, true);

         //execute request cep
         var response = execute.RequestCertificate("beneficios/autorizar-consulta-dados", Method.POST, urlCertificado, passwordCertificado, null, Newtonsoft.Json.JsonConvert.SerializeObject(model));

         //Status: 200 - Execução com sucesso.r
         if (response.StatusCode == System.Net.HttpStatusCode.OK)
            return Newtonsoft.Json.JsonConvert.DeserializeObject<AutorizacaoConsultaBeneficioResponseModel>(response.Content);

         if (response.StatusCode == System.Net.HttpStatusCode.GatewayTimeout || response.StatusCode == System.Net.HttpStatusCode.RequestTimeout)
            return new AutorizacaoConsultaBeneficioResponseModel { Error = Newtonsoft.Json.JsonConvert.DeserializeObject<AutorizacaoConsultaBeneficioErroModel>(response.Content) };

         throw new DataPrevException(TratarErrosResponse(response));
      }

      /// <summary>
      /// Solicitar a consulta de lista de benefícios a partir do token
      /// </summary>
      /// <param name="model">ConsultarListaAutorizadosModel</param>
      /// <returns></returns>
      /// <exception cref="System.Exception"></exception>
      //TODO: Reescrever o LogTracer
      //[LogTracer(enableInfo = enableLogTracking, responseSave = true, provider = LogTracerProvider.DB)]
      protected BeneficioResponseModel ConsultarListaBeneficios(BeneficioRequestModel model)
      {
         if (System.Net.ServicePointManager.SecurityProtocol == (SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls))
            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;

         if (model == null)
            throw new System.Exception("Modelo não pode ser nulo!");

         //create obj request
         var execute = new ExecuteRequest(pathBase, ObterAcessToken, rootAPIPath, true);

         //create parameters
#pragma warning disable CS0618 // Type or member is obsolete
         IEnumerable<Parameter> parameters = new List<Parameter>()
                  {
                new Parameter("tokenAutorizacao", model.TokenAutorizacao.ToString(), ParameterType.HttpHeader),
                new Parameter("cpf", model.Cpf.ToString(), ParameterType.QueryString),
                new Parameter("codigoSolicitante", model.CodigoSolicitante.ToString(), ParameterType.QueryString)
            };
#pragma warning restore CS0618 // Type or member is obsolete

         //execute request cep
         var response = execute.RequestCertificate("beneficios/listar-autorizados", Method.GET, urlCertificado, passwordCertificado, parameters);

         //Status: 200 - Execução com sucesso.r
         if (response.StatusCode == System.Net.HttpStatusCode.OK)
            return Newtonsoft.Json.JsonConvert.DeserializeObject<BeneficioResponseModel>(response.Content);

         //Status: 200 - Execução com sucesso.r
         if (response.StatusCode == System.Net.HttpStatusCode.PreconditionFailed)
            return new BeneficioResponseModel { Error = Newtonsoft.Json.JsonConvert.DeserializeObject<BeneficioErroModel>(response.Content) };

         throw new DataPrevException(TratarErrosResponse(response));
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="model"></param>
      /// <returns></returns>
      /// <exception cref="System.Exception"></exception>
      /// <exception cref="DataPrevException"></exception>
      //TODO: Reescrever o LogTracer
      //[LogTracer(enableInfo = enableLogTracking, responseSave = true, provider = LogTracerProvider.DB)]
      protected InfoBeneficioResponseModel ConsultarBeneficio(BeneficioRequestModel model)
      {
         if (System.Net.ServicePointManager.SecurityProtocol == (SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls))
            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;

         if (model == null)
            throw new System.Exception("Modelo não pode ser nulo!");

         //create obj request
         var execute = new ExecuteRequest(pathBase, ObterAcessToken, rootAPIPath, true);

         //create parameters
#pragma warning disable CS0618 // Type or member is obsolete
         IEnumerable<Parameter> parameters = new List<Parameter>()
                  {
                new Parameter("tokenAutorizacao", model.TokenAutorizacao.ToString(), ParameterType.HttpHeader),
                new Parameter("numeroBeneficio", model.NumeroBeneficio.ToString(), ParameterType.QueryString),
                new Parameter("cpf", model.Cpf.ToString(), ParameterType.QueryString),
                new Parameter("codigoSolicitante", model.CodigoSolicitante.ToString(), ParameterType.QueryString)
            };
#pragma warning restore CS0618 // Type or member is obsolete

         //execute request cep
         var response = execute.RequestCertificate("beneficios/consultar-dados", Method.GET, urlCertificado, passwordCertificado, parameters);

         //Status: 200 - Execução com sucesso.r
         if (response.StatusCode == System.Net.HttpStatusCode.OK)
            return Newtonsoft.Json.JsonConvert.DeserializeObject<InfoBeneficioResponseModel>(response.Content);

         //Status: 200 - Execução com sucesso.r
         if (response.StatusCode == System.Net.HttpStatusCode.PreconditionFailed)
            return new InfoBeneficioResponseModel { Error = Newtonsoft.Json.JsonConvert.DeserializeObject<InfoBeneficioErroModel>(response.Content) };

         throw new Exception(TratarErrosResponse(response));
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="model"></param>
      /// <returns></returns>
      /// <exception cref="System.Exception"></exception>
      /// <exception cref="DataPrevException"></exception>
      //TODO: Reescrever o LogTracer
      //[LogTracer(enableInfo = enableLogTracking, responseSave = true, provider = LogTracerProvider.DB)]
      protected CompetenciaResponseModel ConsultaDataCompetencia(string competenciaConsulta)
      {
         if (ServicePointManager.SecurityProtocol == (SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls))
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;

         if (string.IsNullOrEmpty(competenciaConsulta))
            throw new Exception("competenciaConsulta não pode ser nulo!");

         //create obj request
         var execute = new ExecuteRequest(pathBase, ObterAcessToken, rootAPIPath, true);

         //create parameters
#pragma warning disable CS0618 // Type or member is obsolete
         IEnumerable<Parameter> parameters = new List<Parameter>() { new Parameter("competenciaConsulta", competenciaConsulta, ParameterType.QueryString) };
#pragma warning restore CS0618 // Type or member is obsolete

         //execute request cep
         var response = execute.RequestCertificate("emprestimos/consultar-datas-competencias", Method.GET, urlCertificado, passwordCertificado, parameters);

         //Status: 200 - Execução com sucesso.r
         if (response.StatusCode == System.Net.HttpStatusCode.OK)
            return Newtonsoft.Json.JsonConvert.DeserializeObject<CompetenciaResponseModel>(response.Content);

         //Status: 200 - Execução com sucesso.r
         if (response.StatusCode == System.Net.HttpStatusCode.PreconditionFailed)
            return new CompetenciaResponseModel { Error = Newtonsoft.Json.JsonConvert.DeserializeObject<CompetenciaErroModel>(response.Content) };

         throw new Exception(TratarErrosResponse(response));
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="model"></param>
      /// <returns></returns>
      /// <exception cref="System.Exception"></exception>
      /// <exception cref="DataPrevException"></exception>
      //TODO: Reescrever o LogTracer
      //[LogTracer(enableInfo = enableLogTracking, responseSave = true, provider = LogTracerProvider.DB)]
      protected ConsultaEmprestimoConsignadoResponseModel ConsultarEmprestimoConsignado(ConsultaEmprestimoConsignadoRequestModel model)
      {
         if (ServicePointManager.SecurityProtocol == (SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls))
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;

         if (model == null)
            throw new Exception("Modelo não pode ser nulo!");

         //create obj request
         var execute = new ExecuteRequest(pathBase, ObterAcessToken, rootAPIPath, true);

         //create parameters
#pragma warning disable CS0618 // Type or member is obsolete
         IEnumerable<Parameter> parameters = new List<Parameter>()
                  {
                new Parameter("codigoSolicitante", model.CodigoSolicitante, ParameterType.QueryString),
                new Parameter("numeroContrato", model.NumeroContrato.ToString(), ParameterType.QueryString)
            };
#pragma warning restore CS0618 // Type or member is obsolete

         //execute request cep
         var response = execute.RequestCertificate("emprestimos/consultar-emprestimo", Method.GET, urlCertificado, passwordCertificado, parameters);

         //Status: 200 - Execução com sucesso.r
         if (response.StatusCode == HttpStatusCode.OK)
            return JsonConvert.DeserializeObject<ConsultaEmprestimoConsignadoResponseModel>(response.Content);

         //Status: 200 - Execução com sucesso.r
         if (response.StatusCode == HttpStatusCode.PreconditionFailed)
            return new ConsultaEmprestimoConsignadoResponseModel { Erro = JsonConvert.DeserializeObject<ConsultaEmprestimoConsignadoErroModel>(response.Content) };

         throw new Exception(TratarErrosResponse(response));
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="model"></param>
      /// <returns></returns>
      /// <exception cref="System.Exception"></exception>
      /// <exception cref="DataPrevException"></exception>
      //TODO: Reescrever o LogTracer
      //[LogTracer(enableInfo = enableLogTracking, responseSave = true, provider = LogTracerProvider.DB)]
      protected AutorizarDesbloqueioResponseModel AutorizarDesbloqueio(AutorizarDesbloqueioRequestModel model)
      {
         if (ServicePointManager.SecurityProtocol == (SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls))
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;

         if (model == null)
            throw new Exception("Modelo não pode ser nulo!");

         //create obj request
         var execute = new ExecuteRequest(pathBase, ObterAcessToken, rootAPIPath, true);

         //execute request cep
         var response = execute.RequestCertificate("beneficios/autorizar-desbloqueio-beneficio", Method.POST, urlCertificado, passwordCertificado, body: Newtonsoft.Json.JsonConvert.SerializeObject(model));

         //Status: 200 - Execução com sucesso.r
         if (response.StatusCode == HttpStatusCode.OK)
            return new AutorizarDesbloqueioResponseModel { Sucess = true };

         //Status: 200 - Execução com sucesso.r
         if (response.StatusCode == HttpStatusCode.PreconditionFailed)
            return new AutorizarDesbloqueioResponseModel { Error = JsonConvert.DeserializeObject<AutorizarDesbloqueioErroModel>(response.Content) };

         throw new Exception(TratarErrosResponse(response));
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="model"></param>
      /// <returns></returns>
      /// <exception cref="System.Exception"></exception>
      /// <exception cref="DataPrevException"></exception>
      //TODO: Reescrever o LogTracer
      //[LogTracer(enableInfo = enableLogTracking, responseSave = true, provider = LogTracerProvider.DB)]
      protected InformacaoContratoResponseModel IncluirInformacao(InformacaoContratoRequestModel model)
      {
         if (ServicePointManager.SecurityProtocol == (SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls))
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;

         if (model == null)
            throw new Exception("Modelo não pode ser nulo!");

         //create obj request
         var execute = new ExecuteRequest(pathBase, ObterAcessToken, rootAPIPath, true);

         //execute request cep
         var response = execute.RequestCertificate("emprestimos/incluir-informacoes-contrato", Method.POST, urlCertificado, passwordCertificado, body: JsonConvert.SerializeObject(model));

         //Status: 200 - Execução com sucesso.r
         if (response.StatusCode == HttpStatusCode.OK)
            return JsonConvert.DeserializeObject<InformacaoContratoResponseModel>(response.Content);

         //Status: 200 - Execução com sucesso.r
         if (response.StatusCode == HttpStatusCode.PreconditionFailed)
            return new InformacaoContratoResponseModel { Error = JsonConvert.DeserializeObject<InformacaoContratoErroModel>(response.Content) };

         throw new Exception(TratarErrosResponse(response));
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="model"></param>
      /// <returns></returns>
      /// <exception cref="System.Exception"></exception>
      /// <exception cref="DataPrevException"></exception>
      protected ExcluirConsignadoResponseModel ExcluirConsignado(ExcluirConsignadoRequestModel model)
      {
         if (System.Net.ServicePointManager.SecurityProtocol == (SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls))
            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;

         if (model == null)
            throw new System.Exception("Modelo não pode ser nulo!");

         //create obj request
         var execute = new ExecuteRequest(pathBase, ObterAcessToken, rootAPIPath, true);

         //execute request cep
         var response = execute.RequestCertificate("emprestimos/excluir-consignado", Method.PUT, urlCertificado, passwordCertificado, body: Newtonsoft.Json.JsonConvert.SerializeObject(model));

         //Status: 200 - Execução com sucesso.r
         if (response.StatusCode == System.Net.HttpStatusCode.OK)
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ExcluirConsignadoResponseModel>(response.Content);

         //Status: 200 - Execução com sucesso.r
         if (response.StatusCode == System.Net.HttpStatusCode.PreconditionFailed)
            return new ExcluirConsignadoResponseModel { Error = Newtonsoft.Json.JsonConvert.DeserializeObject<ExcluirConsignadoErroModel>(response.Content) };

         throw new Exception(TratarErrosResponse(response));
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="model"></param>
      /// <returns></returns>
      /// <exception cref="System.Exception"></exception>
      /// <exception cref="DataPrevException"></exception>
      protected AverbacaoPortabilidadeResponseModel AverbacaoPortabilidade(AverbacaoPortabilidadeModel model)
      {
         if (System.Net.ServicePointManager.SecurityProtocol == (SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls))
            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;

         if (model == null)
            throw new System.Exception("Modelo não pode ser nulo!");

         //create obj request
         var execute = new ExecuteRequest(pathBase, ObterAcessToken, rootAPIPath, true);

         //execute request cep
         var response = execute.RequestCertificate("emprestimos/averbar-portabilidade", Method.POST, urlCertificado, passwordCertificado, body: Newtonsoft.Json.JsonConvert.SerializeObject(model));

         //Status: 200 - Execução com sucesso.r
         if (response.StatusCode == System.Net.HttpStatusCode.OK)
            return Newtonsoft.Json.JsonConvert.DeserializeObject<AverbacaoPortabilidadeResponseModel>(response.Content);

         //Status: 200 - Execução com sucesso.r
         if (response.StatusCode == System.Net.HttpStatusCode.PreconditionFailed)
            return new AverbacaoPortabilidadeResponseModel { Error = Newtonsoft.Json.JsonConvert.DeserializeObject<AverbacaoPortabilidadeErroModel>(response.Content) };

         throw new Exception(TratarErrosResponse(response));
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="model"></param>
      /// <returns></returns>
      /// <exception cref="System.Exception"></exception>
      /// <exception cref="DataPrevException"></exception>
      protected ExcluirPortabilidadeResponseModel ExcluirPortabilidade(ExcluirPortabilidadeModel model)
      {
         if (System.Net.ServicePointManager.SecurityProtocol == (SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls))
            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;

         if (model == null)
            throw new System.Exception("Modelo não pode ser nulo!");

         //create obj request
         var execute = new ExecuteRequest(pathBase, ObterAcessToken, rootAPIPath, true);

         //execute request cep
         var response = execute.RequestCertificate("emprestimos/excluir-portabilidade", Method.PUT, urlCertificado, passwordCertificado, body: Newtonsoft.Json.JsonConvert.SerializeObject(model));

         //Status: 200 - Execução com sucesso.r
         if (response.StatusCode == System.Net.HttpStatusCode.OK)
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ExcluirPortabilidadeResponseModel>(response.Content);

         //Status: 200 - Execução com sucesso.r
         if (response.StatusCode == System.Net.HttpStatusCode.PreconditionFailed)
            return new ExcluirPortabilidadeResponseModel { Error = Newtonsoft.Json.JsonConvert.DeserializeObject<ExcluirPortabilidadeErroModel>(response.Content) };

         throw new Exception(TratarErrosResponse(response));
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="model"></param>
      /// <returns></returns>
      /// <exception cref="System.Exception"></exception>
      /// <exception cref="DataPrevException"></exception>      
      protected ReativarEmprestimoConsignadoResponseModel ReativarEmprestimoConsignado(ReativarEmprestimoConsignadoModel model)
      {
         if (System.Net.ServicePointManager.SecurityProtocol == (SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls))
            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;

         if (model == null)
            throw new System.Exception("Modelo não pode ser nulo!");

         //create obj request
         var execute = new ExecuteRequest(pathBase, ObterAcessToken, rootAPIPath, true);

         //execute request cep
         var response = execute.RequestCertificate("emprestimos/reativar-consignado", Method.PUT, urlCertificado, passwordCertificado, body: Newtonsoft.Json.JsonConvert.SerializeObject(model));

         //Status: 200 - Execução com sucesso.r
         if (response.StatusCode == System.Net.HttpStatusCode.OK)
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ReativarEmprestimoConsignadoResponseModel>(response.Content);

         //Status: 200 - Execução com sucesso.r
         if (response.StatusCode == System.Net.HttpStatusCode.PreconditionFailed)
            return new ReativarEmprestimoConsignadoResponseModel { Error = Newtonsoft.Json.JsonConvert.DeserializeObject<ReativarEmprestimoConsignadoErroModel>(response.Content) };

         throw new Exception(TratarErrosResponse(response));
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="model"></param>
      /// <returns></returns>
      /// <exception cref="System.Exception"></exception>
      /// <exception cref="DataPrevException"></exception>
      protected SuspensaoEmprestimoConsignadoResponseModel SuspensaoEmprestimoConsignado(SuspensaoEmprestimoConsignadoModel model)
      {
         if (System.Net.ServicePointManager.SecurityProtocol == (SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls))
            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;

         if (model == null)
            throw new System.Exception("Modelo não pode ser nulo!");

         //create obj request
         var execute = new ExecuteRequest(pathBase, ObterAcessToken, rootAPIPath, true);

         //execute request cep
         var response = execute.RequestCertificate("emprestimos/suspender-consignado", Method.PUT, urlCertificado, passwordCertificado, body: Newtonsoft.Json.JsonConvert.SerializeObject(model));

         //Status: 200 - Execução com sucesso.r
         if (response.StatusCode == System.Net.HttpStatusCode.OK)
            return Newtonsoft.Json.JsonConvert.DeserializeObject<SuspensaoEmprestimoConsignadoResponseModel>(response.Content);

         //Status: 200 - Execução com sucesso.r
         if (response.StatusCode == System.Net.HttpStatusCode.PreconditionFailed)
            return new SuspensaoEmprestimoConsignadoResponseModel { Error = Newtonsoft.Json.JsonConvert.DeserializeObject<ErrorResponseModel>(response.Content) };

         throw new Exception(TratarErrosResponse(response));
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="model"></param>
      /// <returns></returns>
      /// <exception cref="System.Exception"></exception>
      /// <exception cref="DataPrevException"></exception>
      protected ExclusaoDescontoCartaoResponseModel ExclusaoDescontoCartao(ExclusaoDescontoCartaoModel model)
      {
         if (System.Net.ServicePointManager.SecurityProtocol == (SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls))
            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;

         if (model == null)
            throw new System.Exception("Modelo não pode ser nulo!");

         //create obj request
         var execute = new ExecuteRequest(pathBase, ObterAcessToken, rootAPIPath, true);

         //execute request cep
         var response = execute.RequestCertificate("emprestimos/excluir-desconto-cartao", Method.POST, urlCertificado, passwordCertificado, body: Newtonsoft.Json.JsonConvert.SerializeObject(model));

         //Status: 200 - Execução com sucesso.r
         if (response.StatusCode == System.Net.HttpStatusCode.OK)
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ExclusaoDescontoCartaoResponseModel>(response.Content);

         //Status: 200 - Execução com sucesso.r
         if (response.StatusCode == System.Net.HttpStatusCode.PreconditionFailed)
         {
            return new ExclusaoDescontoCartaoResponseModel { Erros = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Erro>>(response.Content) };
         }

         throw new Exception(TratarErrosResponse(response));
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="model"></param>
      /// <returns></returns>
      /// <exception cref="System.Exception"></exception>
      /// <exception cref="DataPrevException"></exception>
      protected InclusaoDescontoCartaoResponseModel InclusaoDescontoCartao(InclusaoDescontoCartaoModel model)
      {
         if (System.Net.ServicePointManager.SecurityProtocol == (SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls))
            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;

         if (model == null)
            throw new System.Exception("Modelo não pode ser nulo!");

         //create obj request
         var execute = new ExecuteRequest(pathBase, ObterAcessToken, rootAPIPath, true);

         //execute request cep
         var response = execute.RequestCertificate("emprestimos/incluir-desconto-cartao", Method.POST, urlCertificado, passwordCertificado, body: Newtonsoft.Json.JsonConvert.SerializeObject(model));

         //Status: 200 - Execução com sucesso.r
         if (response.StatusCode == System.Net.HttpStatusCode.OK)
            return Newtonsoft.Json.JsonConvert.DeserializeObject<InclusaoDescontoCartaoResponseModel>(response.Content);

         //Status: 200 - Execução com sucesso.r
         if (response.StatusCode == System.Net.HttpStatusCode.PreconditionFailed)
         {
            return new InclusaoDescontoCartaoResponseModel { Error = Newtonsoft.Json.JsonConvert.DeserializeObject<ErrorResponseModel>(response.Content) };
         }

         throw new Exception(TratarErrosResponse(response));
      }

      /// <summary>
      /// Solicitação de informacaoComplementarContrato
      /// </summary>
      /// <param name="model"></param>
      /// <returns></returns>
      /// <exception cref="System.Exception"></exception>
      /// <exception cref="DataPrevException"></exception>
      //TODO: Reescrever o LogTracer
      //[LogTracer(enableInfo = enableLogTracking, responseSave = true, provider = LogTracerProvider.DB)]
      protected RefinanciamentoResponseModel Refinanciamento(RefinanciamentoModel model)
      {
         if (System.Net.ServicePointManager.SecurityProtocol == (SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls))
            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;

         if (model == null)
            throw new System.Exception("Modelo não pode ser nulo!");

         //create obj request
         var execute = new ExecuteRequest(pathBase, ObterAcessToken, rootAPIPath, true);

         //execute request cep
         var response = execute.RequestCertificate("emprestimos/realizar-refinanciamento", Method.POST, urlCertificado, passwordCertificado, body: Newtonsoft.Json.JsonConvert.SerializeObject(model, Formatting.None));

         //Status: 200 - Execução com sucesso.r
         if (response.StatusCode == System.Net.HttpStatusCode.OK)
            return Newtonsoft.Json.JsonConvert.DeserializeObject<RefinanciamentoResponseModel>(response.Content);

         //Status: 200 - Execução com sucesso.r
         if (response.StatusCode == System.Net.HttpStatusCode.PreconditionFailed)
            return new RefinanciamentoResponseModel { Error = Newtonsoft.Json.JsonConvert.DeserializeObject<RefinanciamentoErroModel>(response.Content) };

         throw new Exception(TratarErrosResponse(response));
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="model"></param>
      /// <returns></returns>
      /// <exception cref="System.Exception"></exception>
      /// <exception cref="DataPrevException"></exception>
      protected ReverterRefinanciamentoResponseModel ReverterRefinanciamento(ReverterRefinanciamentoModel model)
      {
         if (System.Net.ServicePointManager.SecurityProtocol == (SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls))
            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;

         if (model == null)
            throw new System.Exception("Modelo não pode ser nulo!");

         //create obj request
         var execute = new ExecuteRequest(pathBase, ObterAcessToken, rootAPIPath, true);

         //execute request cep
         var response = execute.RequestCertificate("emprestimos/reverter-refinanciamento", Method.POST, urlCertificado, passwordCertificado, body: Newtonsoft.Json.JsonConvert.SerializeObject(model));

         //Status: 200 - Execução com sucesso.r
         if (response.StatusCode == System.Net.HttpStatusCode.OK)
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ReverterRefinanciamentoResponseModel>(response.Content);

         //Status: 200 - Execução com sucesso.r
         if (response.StatusCode == System.Net.HttpStatusCode.PreconditionFailed)
            return new ReverterRefinanciamentoResponseModel { Error = Newtonsoft.Json.JsonConvert.DeserializeObject<ReverterRefinanciamentoErroModel>(response.Content) };

         throw new Exception(TratarErrosResponse(response));
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="model"></param>
      /// <returns></returns>
      /// <exception cref="System.Exception"></exception>
      /// <exception cref="DataPrevException"></exception>
      protected AverbacaoRMCResponseModel AverbacaoRMC(AverbacaoRMCModel model)
      {
         if (System.Net.ServicePointManager.SecurityProtocol == (SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls))
            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;

         if (model == null)
            throw new System.Exception("Modelo não pode ser nulo!");

         //create obj request
         var execute = new ExecuteRequest(pathBase, ObterAcessToken, rootAPIPath, true);

         //execute request cep
         var response = execute.RequestCertificate("emprestimos/averbar-rmc", Method.POST, urlCertificado, passwordCertificado, body: Newtonsoft.Json.JsonConvert.SerializeObject(model));

         //Status: 200 - Execução com sucesso.r
         if (response.StatusCode == System.Net.HttpStatusCode.OK)
            return Newtonsoft.Json.JsonConvert.DeserializeObject<AverbacaoRMCResponseModel>(response.Content);

         //Status: 200 - Execução com sucesso.r
         if (response.StatusCode == System.Net.HttpStatusCode.PreconditionFailed)
            return new AverbacaoRMCResponseModel { Erro = Newtonsoft.Json.JsonConvert.DeserializeObject<AverbacaoRMCErroModel>(response.Content) };

         throw new Exception(TratarErrosResponse(response));
      }

      /// <summary>
      /// Incluir Taxa de Juros
      /// </summary>
      /// <param name="model"></param>
      /// <exception cref="System.Exception"></exception>
      /// <exception cref="Exception"></exception>
      protected void IncluirTaxaJuros(TaxaJurosModel model)
      {
         if (System.Net.ServicePointManager.SecurityProtocol == (SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls))
            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;

         if (model == null)
            throw new System.Exception("Modelo não pode ser nulo!");

         //create obj request
         var execute = new ExecuteRequest(pathBase, ObterAcessToken, rootAPIPath, true);

         //execute request cep
         var response = execute.RequestCertificate("instituicoesfinanceiras/incluir-taxas-juros", Method.POST, urlCertificado, passwordCertificado, body: Newtonsoft.Json.JsonConvert.SerializeObject(model));

         //Status: 200 - Execução com sucesso.r
         if (response.StatusCode == System.Net.HttpStatusCode.OK)
            return;

         throw new Exception(TratarErrosResponse(response));
      }

      private string TratarErrosResponse(ResponseBusModel response)
      {
         //Status: 403 - Token inválido...
         if (response.StatusCode == System.Net.HttpStatusCode.Forbidden)
            return string.Format("Token inválido ({0} - {1})", response.StatusCode, Newtonsoft.Json.JsonConvert.SerializeObject(response));

         //Status: 403 - Token inválido...
         if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
            return string.Format("Não autorizado ({0} - {1})", response.StatusCode, Newtonsoft.Json.JsonConvert.SerializeObject(response));

         if (response.StatusCode == System.Net.HttpStatusCode.InternalServerError)
            return string.Format("Internal Server Error ({0} - {1})", response.StatusCode, Newtonsoft.Json.JsonConvert.SerializeObject(response));

         if (response.StatusCode == System.Net.HttpStatusCode.PreconditionFailed)
            return string.Format("{0}", Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(response.Content).erros[0].mensagem);

         return Newtonsoft.Json.JsonConvert.SerializeObject(response);
      }

      #endregion

      #region *-------------------------- Métodos Públicos ------------------------*

      public string Ping(string ping) => "Pong";

      /// <summary>
      /// 
      /// </summary>
      /// <param name="model"></param>
      /// <returns></returns>
      //TODO: Reescrever o LogTracer
      //[LogTracer(enableInfo = enableLogTracking, provider = LogTracerProvider.file)]
      public ConsignadoAutorizacaoModel Autorizacao(ConsignadoAutorizacaoModel model)
      {
         model.CodigoSolicitante = codigoSolicitante;

         var temAutorizacao = ConsultarAutorizacao(model);

         if (temAutorizacao.TokenAutorizacao != null)
            return temAutorizacao;

         AutorizacaoConsultaBeneficio(model);

         return model;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="model"></param>
      /// <returns></returns>
      //TODO: Reescrever o LogTracer
      //[LogTracer(enableInfo = enableLogTracking, provider = LogTracerProvider.file)]
      public ConsignadoAutorizacaoModel ConsultarAutorizacao(ConsignadoAutorizacaoModel model)
      {
         // validação do modelo
         new DataPrevValidator().ValidateAndThrow(model);

         // realizar consulta
         var listaAutorizacao = new ConsignadoAutorizacaoBusiness().ConsultarAutorizacaoCPF(model.CpfCnpj);

         // gravando histórico
         PropostaService.GetInstance().IncluirHistorico(new PropostaHistorico { Proposta = (int?)model.Proposta, Usuario = model.UsuarioExecucao, DataExecucao = DateTime.Now, Fase = (model.Fase != null ? model.Fase : 0), Acao = "ConsultarAutorizacao", Simulacao = (int?)model.Simulacao });

         /*
             Não tem autorização?
                 Retorna o mesmo modelo
          */
         if (listaAutorizacao.Count == 0)
            return model;

         // obténdo a última autorização valida
         var autorizacaoValida = listaAutorizacao.OrderByDescending(c => c.DataValidadeAutorizacao).First();

         if (autorizacaoValida.DataValidadeAutorizacao.Value.Date >= DateTime.Now.Date)
            return autorizacaoValida;

         /*
            Autorização não é valida, por isso limpandos os Id, TokenAutorização, estourar lá em cima. 
         */
         autorizacaoValida.Id = null;
         autorizacaoValida.TokenAutorizacao = null;

         // retornando autorização válida.
         return (ConsignadoAutorizacaoModel)autorizacaoValida;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="autorizacao"></param>
      /// <returns></returns>
      public ConsignadoAutorizacaoModel ConsultarAutorizacao(int? autorizacao) => new ConsignadoAutorizacaoBusiness().ConsultarAutorizacao(autorizacao);

      /// <summary>
      /// 
      /// </summary>
      /// <param name="model"></param>
      /// <param name="usuario"></param>
      /// <returns></returns>
      //TODO: Reescrever o LogTracer
      //[LogTracer(enableInfo = enableLogTracking, provider = LogTracerProvider.file)]
      private void AutorizacaoConsultaBeneficio(ConsignadoAutorizacaoModel model)
      {
         // validação do modelo
         new DataPrevValidator().ValidateAndThrow(model);

         // clonando objeto
         var modelAutorizacao = (ConsignadoAutorizacaoModel)model.Clone();

         if (modelAutorizacao.NsuAutorizacaoDigital.HasValue)
            modelAutorizacao.AutorizacaoDigital();
         else
            modelAutorizacao.AutorizacaoPDFA();

         // realizando a consulta de autorização
         var autorizacao = AutorizacaoConsultaBeneficio((AutorizacaoConsultaBeneficioRequestModel)modelAutorizacao);

         // gravando histórico
         PropostaService.GetInstance().IncluirHistorico(new PropostaHistorico { Proposta = model.Proposta, Usuario = model.UsuarioExecucao, DataExecucao = DateTime.Now, Fase = (model.Fase != null ? model.Fase : 0), Acao = "AutorizacaoConsultaBeneficio", Simulacao = (int?)model.Simulacao });

         // sobe exception e gravar na log
         if (autorizacao.Error != null)
            throw new Exception("Erro ao tentar obter autorização!");

         // atribuindo os dados da autorização concedida no modelo.
         model.TokenAutorizacao = autorizacao.TokenAutorizacao;
         model.TipoConsignado = (int)TipoConsignado.DataPrev;
         model.DataValidadeAutorizacao = DateTime.ParseExact(autorizacao.DataValidadeAutorizacao, "ddMMyyyy", CultureInfo.InvariantCulture);

         new ConsignadoAutorizacaoBusiness().Incluir((ConsignadoAutorizacao)model);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="competenciaConsulta"></param>
      /// <param name="usuario"></param>
      /// <returns></returns>
      /// <exception cref="DataPrevException"></exception>
      //TODO: Reescrever o LogTracer
      //[LogTracer(enableInfo = enableLogTracking, provider = LogTracerProvider.file)]
      public CompetenciaResponseModel ConsultaDataCompetencia(string competenciaConsulta, int proposta, string usuario)
      {
         if (string.IsNullOrEmpty(competenciaConsulta))
            throw new DataPrevException("Data competência não pode ser vazia ou nula!");

         if (string.IsNullOrEmpty(usuario))
            throw new DataPrevException("Usuário não pode ser vazio ou nula!");

         // gravando histórico
         PropostaService.GetInstance().IncluirHistorico(new PropostaHistorico { Proposta = proposta, Usuario = usuario, DataExecucao = DateTime.Now, Fase = 0, Acao = "ConsultaDataCompetencia" });

         return ConsultaDataCompetencia(competenciaConsulta);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="model"></param>
      /// <returns></returns>
      /// <exception cref="Exception"></exception>
      //TODO: Reescrever o LogTracer
      //[LogTracer(enableInfo = enableLogTracking, provider = LogTracerProvider.file)]
      public ConsignadoAutorizacaoModel ConsultarListaBeneficios(ConsignadoAutorizacaoModel model)
      {
         // validação do modelo
         new DataPrevValidatorBeneficio().ValidateAndThrow(model);

         // gravando histórico
         PropostaService.GetInstance().IncluirHistorico(new PropostaHistorico { Proposta = (int?)model.Proposta, Simulacao = (int?)model.Simulacao, Usuario = model.UsuarioExecucao, DataExecucao = DateTime.Now, Fase = (model.Fase != null ? model.Fase : 0), Acao = "ConsultarListaBeneficios" });

         // consultando autorização

         var autorizacao = (model.Id == null ? ConsultarAutorizacao(model) : ConsultarAutorizacao(model.Id));

         if (autorizacao.TokenAutorizacao == null)
            throw new Exception("Não existe autorização!");

         autorizacao.CodigoSolicitante = codigoSolicitante;

         var listaBeneficios = ConsultarListaBeneficios(new BeneficioRequestModel
         {
            Cpf = model.CpfCnpj,
            CodigoSolicitante = 611,
            TokenAutorizacao = autorizacao.TokenAutorizacao,
            Proposta = model.Proposta,
            CpfCnpj = model.CpfCnpj,
            Simulacao = model.Simulacao,
            Fase = model.Fase
         });

         if (autorizacao.ConsignadoDetalhe == null)
            autorizacao.ConsignadoDetalhe = new ConsignadoDetalhe();

         autorizacao.ConsignadoDetalhe.Beneficio = listaBeneficios;

         new ConsignadoAutorizacaoBusiness().Alterar((ConsignadoAutorizacao)autorizacao);

         return autorizacao;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="model"></param>
      /// <returns></returns>
      /// <exception cref="Exception"></exception>
      //TODO: Reescrever o LogTracer
      //[LogTracer(enableInfo = enableLogTracking, provider = LogTracerProvider.file)]
      public ConsignadoAutorizacaoModel ConsultarMargem(ConsignadoAutorizacaoModel model)
      {
         // validação do modelo
         new DataPrevValidatorBeneficioMargem().ValidateAndThrow(model);

         // gravando histórico
         PropostaService.GetInstance().IncluirHistorico(new PropostaHistorico { Proposta = (int?)model.Proposta, Simulacao = (int?)model.Simulacao, Usuario = model.UsuarioExecucao, DataExecucao = DateTime.Now, Fase = (model.Fase != null ? model.Fase : 0), Acao = "ConsultarMargem" });

         // consultando autorização
         var autorizacao = (model.Id == null ? ConsultarAutorizacao(model) : ConsultarAutorizacao(model.Id));

         if (autorizacao.TokenAutorizacao == null)
            throw new Exception("Não existe autorização!");

         var beneficioMargem = ConsultarBeneficio(new BeneficioRequestModel
         {
            Cpf = model.CpfCnpj,
            CodigoSolicitante = codigoSolicitante,
            NumeroBeneficio = model.NumeroBeneficio,
            TokenAutorizacao = autorizacao.TokenAutorizacao,
            Proposta = model.Proposta,
            CpfCnpj = model.CpfCnpj,
            Simulacao = model.Simulacao,
            Fase = model.Fase
         });

         autorizacao.ConsignadoDetalhe.Beneficio.Beneficios.Find(c => c.NumeroBeneficio == model.NumeroBeneficio).InfoBeneficio = beneficioMargem;

         //var beneficio = autorizacao.ConsignadoDetalhe.Beneficio.Beneficios.Find(c => c.NumeroBeneficio == model.NumeroBeneficio).InfoBeneficio = beneficioMargem;

         new ConsignadoAutorizacaoBusiness().Alterar((ConsignadoAutorizacao)autorizacao);

         return autorizacao;
      }

      /// <summary>
      /// Envia a solicitação de averbação para processamento.
      /// </summary>
      /// <param name="model"></param>
      /// <exception cref="DataPrevException"></exception>
      //TODO: Reescrever o LogTracer
      //[LogTracer(enableInfo = enableLogTracking, provider = LogTracerProvider.DB)]
      public void SolicitarAverbacao(ConsignadoAutorizacaoModel model)
      {
         // validação do modelo
         new DataPrevValidator().ValidateAndThrow(model);

         if (model?.ConsignadoDetalhe?.Beneficio?.Beneficios?.FirstOrDefault()?.Averbacao == null)
            throw new DataPrevException("Averbação não pode ser nulo!");

         if (!model.Proposta.HasValue)
            throw new DataPrevException("Proposta não pode ser nulo!");

         // setando o código do solicitante
         model.ConsignadoDetalhe.Beneficio.Beneficios.FirstOrDefault().Averbacao.CodigoSolicitante = codigoSolicitante;

         // validação do modelo
         new DataPrevValidatorAverbacao().ValidateAndThrow(model.ConsignadoDetalhe.Beneficio.Beneficios.FirstOrDefault().Averbacao);

         // Validar Autorização no momento de enviar uma solicitação de Averbação?
         if (validarAutorizacaoAverbacao)
         {
            // buscando autorização
            var autorizacao = ConsultarAutorizacao(model);

            if (autorizacao.TokenAutorizacao == null)
               throw new DataPrevException("Não existe autorização!");
         }

         /*
            Limpando os campos byte[] não serão necessários para averbação
               Não é possível utilizar a propridadee JsonIgnore pq existe uma configuração na serialização para não ignorar essa propriedade
         */
         model.TermoAutorizacaoBeneficiario = null;
         model.DocumentoIdentificacao = null;

         ConsignadoService.GetInstance().AdicionarFila(model, jobAverbacao, true);
      }

      /// <summary>
      /// Envia a solicitação de informacaoComplementarContrato para processamento.
      /// </summary>
      /// <param name="model"></param>
      /// <exception cref="DataPrevException"></exception>
      //TODO: Reescrever o LogTracer
      //[LogTracer(enableInfo = enableLogTracking, provider = LogTracerProvider.DB)]
      public void SolicitarRefinanciamento(ConsignadoAutorizacaoModel model)
      {
         // validação do modelo
         new DataPrevValidator().ValidateAndThrow(model);

         if (model?.ConsignadoDetalhe?.Beneficio?.Beneficios?.FirstOrDefault()?.Refinanciamento == null)
            throw new DataPrevException("Refinanciamento não pode ser nulo!");

         if (!model.Proposta.HasValue)
            throw new DataPrevException("Proposta não pode ser nulo!");

         // setando o código do solicitante
         model.ConsignadoDetalhe.Beneficio.Beneficios.FirstOrDefault().Refinanciamento.CodigoSolicitante = codigoSolicitante;

         // validação do modelo
         new DataPrevValidatorRefinanciamento().ValidateAndThrow(model.ConsignadoDetalhe.Beneficio.Beneficios.FirstOrDefault().Refinanciamento);

         // Validar Autorização no momento de enviar uma solicitação de Refinanciamento?
         if (validarAutorizacaoRefinanciamento)
         {
            // buscando autorização
            var autorizacao = ConsultarAutorizacao(model);

            if (autorizacao.TokenAutorizacao == null)
               throw new DataPrevException("Não existe autorização!");
         }

         /*
            Limpando os campos byte[] não serão necessários para informacaoComplementarContrato
               Não é possível utilizar a propridadee JsonIgnore pq existe uma configuração na serialização para não ignorar essa propriedade
         */
         model.TermoAutorizacaoBeneficiario = null;
         model.DocumentoIdentificacao = null;

         ConsignadoService.GetInstance().AdicionarFila(model, jobRefinanciamento, true);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="model"></param>
      //TODO: Reescrever o LogTracer
      //[LogTracer(enableInfo = enableLogTracking, provider = LogTracerProvider.DB)]
      public void SolicitarInformacaoContrato(ConsignadoAutorizacaoModel model)
      {
         // validação do modelo
         new DataPrevValidator().ValidateAndThrow(model);

         if (model?.ConsignadoDetalhe?.Beneficio?.Beneficios?.FirstOrDefault()?.InformacaoContrato == null)
            throw new DataPrevException("Informação complementar não pode ser nulo!");

         if (!model.Proposta.HasValue)
            throw new DataPrevException("Proposta não pode ser nulo!");

         // setando o código do solicitante
         model.ConsignadoDetalhe.Beneficio.Beneficios.FirstOrDefault().InformacaoContrato.CodigoSolicitante = codigoSolicitante;

         // validação do modelo
         new DataPrevValidatorInformacaoComplementarContrato().ValidateAndThrow(model.ConsignadoDetalhe.Beneficio.Beneficios.FirstOrDefault().InformacaoContrato);

         /*
            Limpando os campos byte[] não serão necessários para averbação
               Não é possível utilizar a propridadee JsonIgnore pq existe uma configuração na serialização para não ignorar essa propriedade
         */
         model.TermoAutorizacaoBeneficiario = null;
         model.DocumentoIdentificacao = null;

         ConsignadoService.GetInstance().AdicionarFila(model, jobInformacaoComplementarContrato, true);
      }

      /// <summary>
      /// Exclusão de averbação.
      /// </summary>
      /// <param name="proposta">Número da proposta.</param>
      /// <param name="numeroBeneficio">Número do beneficio.</param>
      /// <param name="fase">Fase</param>
      /// <param name="motivoExlcusao"></param>
      /// 1 Desistência do empréstimo (prazo menor que 15 dias corridos da data de assinatura do contrato)
      /// 2 Falecimento
      /// 3 Liquidação antecipada
      /// 4 RMC - Cancelamento do Cartão a pedido do cliente
      /// 5 RMC - Cancelamento do Cartão a pedido do Banco
      /// 7 Ação judicial
      /// 8 Exclusão por fraude
      /// 9 Outros
      /// 10 Cancelamento fora do prazo de reversão do informacaoComplementarContrato
      //TODO: Reescrever o LogTracer
      //[LogTracer(enableInfo = enableLogTracking, provider = LogTracerProvider.DB)]
      public void SolicitarExclusaoAverbacao(int? proposta, long? numeroBeneficio, int? fase, long? motivoExlcusao)
      {
         var propostaObj = PropostaService.GetInstance().ObterProposta(proposta);

         // gravando histórico
         PropostaService.GetInstance().IncluirHistorico(new PropostaHistorico { Proposta = proposta, Usuario = "System", DataExecucao = DateTime.Now, Fase = fase, Acao = "Excluir Averbação" });

         // criando objeto para excluir averbação
         var exclusao = new ExcluirConsignadoRequestModel
         {
            CodigoSolicitante = codigoSolicitante,
            Proposta = proposta,
            NumeroBeneficio = numeroBeneficio,
            NumeroContrato = propostaObj.Operacoes.ContratoLegado,
            MotivoExclusao = motivoExlcusao
         };

         // adicionando na fila
         ConsignadoService.GetInstance().AdicionarFila(exclusao, jobExclusaoAverbacao, true);
      }

      /// <summary>
      /// Obter Logs
      /// </summary>
      /// <param name="proposta">Proposta</param>
      /// <param name="simulacao">Simulação</param>
      /// <returns></returns>
      public List<LogInfo> ObterLogs(long? proposta, int? simulacao)
      {
         var logs = LogService.GetInstance().Obter(proposta, simulacao);

         foreach (var log in logs)
         {
            if (!string.IsNullOrEmpty(log.Request))
            {
               if (log.MethodName == "SolicitarAverbacao")
               {
                  dynamic request = JsonConvert.DeserializeObject<dynamic>(log.Request);

                  log.Response = JsonConvert.SerializeObject(request.model.ConsignadoDetalhe.Beneficio.beneficios[0].Averbacao, Formatting.Indented);
               }
               else if (log.MethodName == "Refinanciamento")
               {
                  if (log.Response != null)
                  {
                     dynamic request = JsonConvert.DeserializeObject<dynamic>(log.Response);
                     log.Response = JsonConvert.SerializeObject(request, Formatting.Indented);
                  }
               }
               else if (log.MethodName == "SolicitarRefinanciamento")
               {
                  dynamic request = JsonConvert.DeserializeObject<dynamic>(log.Request);

                  log.Response = JsonConvert.SerializeObject(request.model.ConsignadoDetalhe, Formatting.Indented);
               }
               else if (log.MethodName == "SolicitarInformacaoContrato")
               {
                  dynamic request = JsonConvert.DeserializeObject<dynamic>(log.Request);

                  request.model.ConsignadoDetalhe.Beneficio.beneficios[0].InformacaoContrato.contratoEmprestimo = null;
                  request.model.ConsignadoDetalhe.Beneficio.beneficios[0].InformacaoContrato.documentoOficialComFotoFrente = null;
                  request.model.ConsignadoDetalhe.Beneficio.beneficios[0].InformacaoContrato.documentoOficialComFotoVerso = null;
                  request.model.ConsignadoDetalhe.Beneficio.beneficios[0].InformacaoContrato.registroBiometricoFacial = null;

                  log.Response = JsonConvert.SerializeObject(request.model.ConsignadoDetalhe.Beneficio.beneficios[0].InformacaoContrato, Formatting.Indented);
               }
            }
         }

         return logs;
      }

      /// <summary>
      /// 
      /// </summary>
      //TODO: Revisar
      //[LogTracer(enableInfo = enableLogTracking, provider = LogTracerProvider.file)]
      //      public void GerarEnvioInformacaoComplementar(ConfiguracaoJobModel contexto, Func<long?, ClickSignEnvelope> obterEnvelope, Func<ConsultaModel, CacheConsultaModel> obterConsulta)
      //      {
      //         // recuperando a lista de propostas que falta enviar informação complementar
      //         var propostasNaoProcessadas = new ViewConsignadoEnvioInformacaoComplementarBusiness().Listar(null);

      //         if (propostasNaoProcessadas == null || propostasNaoProcessadas.Count == 0)
      //            return;

      //         foreach (var proposta in propostasNaoProcessadas)
      //         {
      //            var propostaObj = PropostaService.GetInstance().ObterProposta(proposta.Proposta);
      //#if DEBUG
      //            // aguardando 30s segundos para enviar nova fila, para não tomar block da DataPrev (Debug)
      //            Thread.Sleep(30000);
      //#else
      //            // aguardando 10s segundos para enviar nova fila, para não tomar block da DataPrev
      //            Thread.Sleep(10000);
      //#endif

      //            try
      //            {
      //               // setando número da proposta na fila
      //               contexto.idFila = proposta.Proposta.Value;

      //               ObterInformacaoComplementar(propostaObj, obterEnvelope, obterConsulta);
      //            }
      //            catch (Exception ex)
      //            {
      //               // deu erro?Notifica, remove da lista e processa os demais, na proxima execução vai pegar a fila com problema até analisar o que ocorre
      //               //propostasNaoProcessadas.Remove(proposta);

      //               //Notifica o erro ocorrido...
      //               try { NotificarErroJob(contexto, ex); } catch { }
      //            }
      //         }
      //      }

      #endregion

      #region *------------------------- Job Processamento ------------------------*

      /// <summary>
      /// Job pode executar?
      /// </summary>
      /// <returns></returns>
      //TODO: Reescrever o LogTracer
      //[LogTracer(enableInfo = enableLogTracking, provider = LogTracerProvider.file)]
      public bool Execute(ConfiguracaoJobModel contexto)
      {
         /*
            ParametrosExtras nulo?Não é obrigatório ter parametros para execução, mas caso tenha precisa ser válidos   
         */
         if (contexto == null)
            return false;

         if (contexto.ParametrosExtras == null)
            return true;

         if (contexto.ParametrosExtras.Excecao == null)
            return false;

         if (contexto.ParametrosExtras.Excecao.Count == 0)
            return false;

         foreach (var excecao in contexto.ParametrosExtras.Excecao)
         {
            if (excecao.DataInicio.Date <= DateTime.Now.Date && excecao.DataFim >= DateTime.Now.Date)
            {
               if ((DateTime.Now.Date >= excecao.DataInicio.Date) && (DateTime.Now.Date <= excecao.DataFim.Date))
               {
                  var horarioExecucaoInicio = DateTime.Parse(DateTime.Today.ToString("yyyy/MM/dd") + " " + excecao.HorarioInicial);
                  var horarioExecucaoFim = DateTime.Parse(DateTime.Today.ToString("yyyy/MM/dd") + " " + excecao.HorarioFinal);

                  var now = DateTime.Now;
                  if ((now >= horarioExecucaoInicio) && (now <= horarioExecucaoFim))
                     return false; //não pode executar o job
               }
            }
         }

         return true;
      }

      /// <summary>
      /// Responsável por executar a averbação de contratos de empréstimo consignado.
      /// </summary>
      /// <param name="contexto"></param>
      /// <param name="validarFeriado">Função para validar Feriado.</param>
      //TODO: Reescrever o LogTracer
      //[LogTracer(enableInfo = true, provider = LogTracerProvider.file)]
      public void ExecutarAverbacao(ConfiguracaoJobModel contexto, Func<DateTime, bool> validarFeriado)
      {
         // setando a cultura
         Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");

         // job que está sendo executado no momento
         Job job = null;

         // objeto que contém o consignado
         ConsignadoAutorizacaoModel consignado = null;

         //  obter mensagens que ainda não foram processadas, ou seja mensagens com os status
         //  "Em Fila de Processamento" e "Em Processamento"
         //  e que o job informado não tenha excedido o limite de execução.
         var mensagensNaoProcessadas = ConsignadoService.GetInstance().ObterMensagensNaoProcessadas(contexto.IdJob);

         foreach (var mensagem in mensagensNaoProcessadas)
         {
            try
            {
               // obténdo o job
               job = new JobBusiness().Obtem(contexto.IdJob);

               // atualizando o job para o processando
               job.IdJobStatus = JobStatus.PROCESSANDO;

               // setando data de processamento da mensagem
               job.DataProcessamento = DateTime.Now;

               // setando o id da mensagem no contexto da execução
               contexto.idFila = mensagem.Id.Value;

               // setando data de processamento da mensagem
               contexto.DataProcessamento = DateTime.Now;

               try
               {
                  // recuperando os dados da pessoa
                  consignado = JsonConvert.DeserializeObject<ConsignadoAutorizacaoModel>(mensagem.Mensagem, new JsonSerializerSettings { ContractResolver = new IncludeIgnored(true) });
               }
               catch (Exception ex)
               {
                  if (ex is JsonReaderException)
                     throw new Exception(string.Format("Erro ao tentar deserializar o objeto {0} - Erro {1}", ((JsonReaderException)ex).Path, ex.Message));

                  throw ex;
               }

               //Mensagem não pode ser nula!
               if (consignado == null) throw new DataPrevException("Mensagem não pode ser nula!");

               // Não é permitido realizar execução de averbação sem número da proposta!
               if (!consignado.Proposta.HasValue) throw new DataPrevException("Não é permitido realizar execução de averbação sem número da proposta!");

               // validando a configuração de execução por produto.
               if (!CheckProdutoExecucao(consignado, validarFeriado))
                  continue;

               // informando ao Job que iniciou o processamento
               ConsignadoService.GetInstance().AtualizarJob(job);

               // valiando se a proposta está rejeitada, não pode executar o comando de averbação ou refinanciamento.
               CheckPropostaRejeitada(consignado);

               // Obténdo a lista de ocorrências da DataPrev
               this.consignadoOcorrencia = new JobConsignadoOcorrenciaBusiness().ObterConsignadoOcorrencia(contexto.IdJob);

               // Não é possível recuperar lista de ocorrências!
               if (this.consignadoOcorrencia.Count == 0) throw new DataPrevException("Não é possível recuperar lista de ocorrências!");

               // recuperando objeto de averbação
               var averbacao = consignado.ConsignadoDetalhe.Beneficio.Beneficios.FirstOrDefault().Averbacao;

               // executando averbação
               var retornoAverbacao = this.AverbacaoEmprestimoConsignado(averbacao);

               // gravando o retorno na execução do Job
               job.Result = JsonConvert.SerializeObject(retornoAverbacao);

               if (retornoAverbacao == null) throw new DataPrevException("Averbação sem retorno");

               // gravando histórico
               PropostaService.GetInstance().IncluirHistorico(new PropostaHistorico { Proposta = consignado.Proposta, Usuario = "System", DataExecucao = DateTime.Now, Fase = (consignado.Fase != null ? consignado.Fase : 0), Acao = "Retorno Averbação", Simulacao = consignado.Simulacao });

               // processar a mensagem de retorno
               ProcessarRetorno(new ConsignadoResponseModel { NumeroContrato = retornoAverbacao.NumeroContrato, HashOperacao = retornoAverbacao.HashOperacao, Erros = retornoAverbacao?.Erros?.Erros, CodigoSucesso = retornoAverbacao.CodigoSucesso }, consignado, contexto);

               // finalizando o job
               ConsignadoService.GetInstance().FinalizaJob(job);
            }
            catch (Exception ex)
            {
               LogService.GetInstance().Error(LogTracerProvider.file, consignado?.CpfCnpj.ToString(), component: component, exception: ex);

               //Registra a exceção na tentativa de execução deste job.
               try { ConsignadoService.GetInstance().AtualizarJob(job, ex); } catch { }

               //Notifica o erro ocorrido...
               try { ConsignadoService.GetInstance().NotificarErroJob(contexto, ex); } catch { }
            }
            finally
            {
               /*
                  Validando se houve uma tentantiva de execução, caso não exista não precisa atualizar o job 
                     Atualizando o job com os ultimas informações (Bod, Id Fila)...
               */
               if (job.idJobTentativa.HasValue)
                  ConsignadoService.GetInstance().AtualizarJobFilaLegado(job, mensagem.Id, job.Result);
            }
         }

         try
         {
            // reorganizando a fila de processamento
            ConsignadoService.GetInstance().ReoganizarFila();
         }
         catch (Exception ex)
         {
            LogService.GetInstance().Error(LogTracerProvider.file, consignado?.CpfCnpj.ToString(), component: component, exception: ex);

            //Notifica o erro ocorrido...
            try { ConsignadoService.GetInstance().NotificarErroJob(contexto, ex); } catch { }
         }
      }

      /// <summary>
      /// Responsável por executar a operação de excluir averbação.
      /// </summary>
      /// <param name="contexto"></param>
      //TODO: Reescrever o LogTracer
      //[LogTracer(enableInfo = true, provider = LogTracerProvider.file)]
      public void ExcluirAverbacao(ConfiguracaoJobModel contexto)
      {
         // setando a cultura
         Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");

         // job que está sendo executado no momento
         Job job = null;

         // objeto que contém o consignado
         ExcluirConsignadoRequestModel consignado = null;

         //  obter mensagens que ainda não foram processadas, ou seja mensagens com os status
         //  "Em Fila de Processamento" e "Em Processamento"
         //  e que o job informado não tenha excedido o limite de execução.
         var mensagensNaoProcessadas = ConsignadoService.GetInstance().ObterMensagensNaoProcessadas(contexto.IdJob);

         foreach (var mensagem in mensagensNaoProcessadas)
         {
            try
            {
               /// obténdo o job
               job = new JobBusiness().Obtem(contexto.IdJob);

               /// atualizando o job para o processando
               job.IdJobStatus = JobStatus.PROCESSANDO;

               // setando data de processamento da mensagem
               job.DataProcessamento = DateTime.Now;

               /// informando ao Job que iniciou o processamento
               ConsignadoService.GetInstance().AtualizarJob(job);

               contexto.idFila = mensagem.Id.Value;

               // setando data de processamento da mensagem
               contexto.DataProcessamento = DateTime.Now;

               try
               {
                  // recuperando os dados da pessoa
                  consignado = JsonConvert.DeserializeObject<ExcluirConsignadoRequestModel>(mensagem.Mensagem, new JsonSerializerSettings { ContractResolver = new IncludeIgnored(true) });
               }
               catch (Exception ex)
               {
                  if (ex is JsonReaderException)
                     throw new Exception(string.Format("Erro ao tentar deserializar o objeto {0} - Erro {1}", ((JsonReaderException)ex).Path, ex.Message));

                  throw ex;
               }

               //Mensagem não pode ser nula!
               if (consignado == null) throw new DataPrevException("Mensagem não pode ser nula!");

               // Não é permitido realizar execução de averbação sem número da proposta!
               if (!consignado.Proposta.HasValue) throw new DataPrevException("Não é permitido realizar execução de averbação sem número da proposta!");

               // Obténdo a lista de ocorrências da DataPrev
               this.consignadoOcorrencia = new JobConsignadoOcorrenciaBusiness().ObterConsignadoOcorrencia(contexto.IdJob);

               // Não é possível recuperar lista de ocorrências!
               if (this.consignadoOcorrencia.Count == 0) throw new DataPrevException("Não é possível recuperar lista de ocorrências!");

               // executando averbação
               var retornoExcluirAverbacao = this.ExcluirConsignado(consignado);

               // gravando o retorno na execução do Job
               job.Result = JsonConvert.SerializeObject(retornoExcluirAverbacao);

               if (retornoExcluirAverbacao == null) throw new DataPrevException("Averbação sem retorno");

               // gravando histórico
               PropostaService.GetInstance().IncluirHistorico(new PropostaHistorico { Proposta = consignado.Proposta, Usuario = "System", DataExecucao = DateTime.Now, Fase = (consignado.Fase != null ? consignado.Fase : 0), Acao = "Retorno Excluir Averbação", Simulacao = consignado.Simulacao });

               /*Deu erro na fila 47  - Emprestimo já cadastrado HX - veja isso Saulo */
               ProcessarRetorno(
                  new ConsignadoResponseModel
                  {
                     NumeroContrato = retornoExcluirAverbacao.NumeroContrato,
                     HashOperacao = retornoExcluirAverbacao.HashOperacao,
                     Erros = retornoExcluirAverbacao?.Error?.Erros,
                     CodigoSucesso = retornoExcluirAverbacao.CodigoSucesso
                  }, consignado, contexto);

               // finalizando o job
               ConsignadoService.GetInstance().FinalizaJob(job);
            }
            catch (Exception ex)
            {
               LogService.GetInstance().Error(LogTracerProvider.file, consignado?.CpfCnpj.ToString(), component: component, exception: ex);

               //Registra a exceção na tentativa de execução deste job.
               try { ConsignadoService.GetInstance().AtualizarJob(job, ex); } catch { }

               //Notifica o erro ocorrido...
               try { ConsignadoService.GetInstance().NotificarErroJob(contexto, ex); } catch { }
            }
            finally
            {
               // atualizando o job com os ultimas informações (Bod, Id Fila)...
               ConsignadoService.GetInstance().AtualizarJobFilaLegado(job, mensagem.Id, job.Result);
            }
         }

         // reorganizando a fila de processamento
         ConsignadoService.GetInstance().ReoganizarFila();
      }

      /// <summary>
      /// Responsável por executar a operação de informacaoComplementarContrato.
      /// </summary>
      /// <param name="contexto"></param>
      //TODO: Reescrever o LogTracer
      //[LogTracer(enableInfo = true, provider = LogTracerProvider.file)]
      public void ExecutarRefinanciamento(ConfiguracaoJobModel contexto, Func<DateTime, bool> validarFeriado)
      {
         // setando a cultura
         Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");

         // job que está sendo executado no momento
         Job job = null;

         // objeto que contém o refin
         ConsignadoAutorizacaoModel consignado = null;

         //  obter mensagens que ainda não foram processadas, ou seja mensagens com os status
         //  "Em Fila de Processamento" e "Em Processamento"
         //  e que o job informado não tenha excedido o limite de execução.
         var mensagensNaoProcessadas = ConsignadoService.GetInstance().ObterMensagensNaoProcessadas(contexto.IdJob);

         foreach (var mensagem in mensagensNaoProcessadas)
         {
            try
            {
               // obténdo o job
               job = new JobBusiness().Obtem(contexto.IdJob);

               // atualizando o job para o processando
               job.IdJobStatus = JobStatus.PROCESSANDO;

               // setando data de processamento da mensagem
               job.DataProcessamento = DateTime.Now;

               // setando o id da mensagem no contexto da execução
               contexto.idFila = mensagem.Id.Value;

               // setando data de processamento da mensagem
               contexto.DataProcessamento = DateTime.Now;

               try
               {
                  // recuperando os dados da pessoa
                  consignado = JsonConvert.DeserializeObject<ConsignadoAutorizacaoModel>(mensagem.Mensagem, new JsonSerializerSettings { ContractResolver = new IncludeIgnored(true) });
               }
               catch (Exception ex)
               {
                  if (ex is JsonReaderException)
                     throw new Exception(string.Format("Erro ao tentar deserializar o objeto {0} - Erro {1}", ((JsonReaderException)ex).Path, ex.Message));

                  throw ex;
               }

               //Mensagem não pode ser nula!
               if (consignado == null) throw new DataPrevException("Mensagem não pode ser nula!");

               // Não é permitido realizar execução de averbação sem número da proposta!
               if (!consignado.Proposta.HasValue) throw new DataPrevException("Não é permitido realizar execução de averbação sem número da proposta!");

               // validando a configuração de execução por produto.
               if (!CheckProdutoExecucao(consignado, validarFeriado))
                  continue;

               // informando ao Job que iniciou o processamento
               ConsignadoService.GetInstance().AtualizarJob(job);

               // valiando se a proposta está rejeitada, não pode executar o comando de averbação ou refinanciamento.
               CheckPropostaRejeitada(consignado);

               // Obténdo a lista de ocorrências da DataPrev
               this.consignadoOcorrencia = new JobConsignadoOcorrenciaBusiness().ObterConsignadoOcorrencia(contexto.IdJob);

               // recuperando objeto de averbação
               var refinanciamento = consignado.ConsignadoDetalhe.Beneficio.Beneficios.FirstOrDefault().Refinanciamento;

               // Não é possível recuperar lista de ocorrências!
               if (this.consignadoOcorrencia.Count == 0) throw new DataPrevException("Não é possível recuperar lista de ocorrências!");

               // executando averbação
               var retornoRefinaciamento = this.Refinanciamento(refinanciamento);

               // gravando o retorno na execução do Job
               job.Result = JsonConvert.SerializeObject(retornoRefinaciamento);

               if (retornoRefinaciamento == null) throw new DataPrevException("Averbação sem retorno");

               // gravando histórico
               PropostaService.GetInstance().IncluirHistorico(new PropostaHistorico { Proposta = consignado.Proposta, Usuario = "System", DataExecucao = DateTime.Now, Fase = (consignado.Fase != null ? consignado.Fase : 0), Acao = "Retorno Averbação", Simulacao = consignado.Simulacao });

               /*
                  Tem uma lista de erros não padronizada? 
               */
               if (retornoRefinaciamento?.Error?.ListaErrosContratos?.Count > 0)
                  retornoRefinaciamento.Error.Erros.AddRange(retornoRefinaciamento?.Error?.ListaErrosContratos.FirstOrDefault().Erros);

               /*Deu erro na fila 47  - Emprestimo já cadastrado HX - veja isso Saulo */
               ProcessarRetorno(
                  new ConsignadoResponseModel
                  {
                     NumeroContrato = retornoRefinaciamento.NumeroContrato,
                     HashOperacao = retornoRefinaciamento.HashOperacao,
                     Erros = retornoRefinaciamento?.Error?.Erros,
                     CodigoSucesso = retornoRefinaciamento.CodigoSucesso
                  },
                  consignado, contexto);

               // finalizando o job
               ConsignadoService.GetInstance().FinalizaJob(job);
            }
            catch (Exception ex)
            {
               LogService.GetInstance().Error(LogTracerProvider.file, consignado?.CpfCnpj.ToString(), component: component, exception: ex);

               //Registra a exceção na tentativa de execução deste job.
               try { ConsignadoService.GetInstance().AtualizarJob(job, ex); } catch { }

               //Notifica o erro ocorrido...
               try { ConsignadoService.GetInstance().NotificarErroJob(contexto, ex); } catch { }
            }
            finally
            {
               /*
                  Validando se houve uma tentantiva de execução, caso não exista não precisa atualizar o job 
                     Atualizando o job com os ultimas informações (Bod, Id Fila)...
               */
               if (job.idJobTentativa.HasValue)
                  ConsignadoService.GetInstance().AtualizarJobFilaLegado(job, mensagem.Id, job.Result);
            }
         }

         try
         {
            // reorganizando a fila de processamento
            ConsignadoService.GetInstance().ReoganizarFila();
         }
         catch (Exception ex)
         {
            LogService.GetInstance().Error(LogTracerProvider.file, consignado?.CpfCnpj.ToString(), component: component, exception: ex);

            //Notifica o erro ocorrido...
            try { ConsignadoService.GetInstance().NotificarErroJob(contexto, ex); } catch { }
         }
      }

      /// <summary>
      /// Responsável por executar a operação de 
      /// </summary>
      /// <param name="contexto"></param>
      //TODO: Reescrever o LogTracer
      //[LogTracer(enableInfo = true, provider = LogTracerProvider.file)]
      public void ExecutarInformacaoContrato(ConfiguracaoJobModel contexto)
      {
         // setando a cultura
         Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");

         // job que está sendo executado no momento
         Job job = null;

         // objeto que contém o refin
         ConsignadoAutorizacaoModel consignado = null;

         //  obter mensagens que ainda não foram processadas, ou seja mensagens com os status
         //  "Em Fila de Processamento" e "Em Processamento"
         //  e que o job informado não tenha excedido o limite de execução.
         var mensagensNaoProcessadas = ConsignadoService.GetInstance().ObterMensagensNaoProcessadas(contexto.IdJob);

         foreach (var mensagem in mensagensNaoProcessadas)
         {
#if DEBUG
            // aguardando 30s segundos para enviar nova fila, para não tomar block da DataPrev (Debug)
            Thread.Sleep(30000);
#endif
            try
            {
               // obténdo o job
               job = new JobBusiness().Obtem(contexto.IdJob);

               // atualizando o job para o processando
               job.IdJobStatus = JobStatus.PROCESSANDO;

               // setando data de processamento da mensagem
               job.DataProcessamento = DateTime.Now;

               // informando ao Job que iniciou o processamento
               ConsignadoService.GetInstance().AtualizarJob(job);

               contexto.idFila = mensagem.Id.Value;

               // setando data de processamento da mensagem
               contexto.DataProcessamento = DateTime.Now;

               try
               {
                  // recuperando os dados da pessoa
                  consignado = JsonConvert.DeserializeObject<ConsignadoAutorizacaoModel>(mensagem.Mensagem, new JsonSerializerSettings { ContractResolver = new IncludeIgnored(true) });
               }
               catch (Exception ex)
               {
                  if (ex is JsonReaderException)
                     throw new Exception(string.Format("Erro ao tentar deserializar o objeto {0} - Erro {1}", ((JsonReaderException)ex).Path, ex.Message));

                  throw ex;
               }

               //Mensagem não pode ser nula!
               if (consignado == null) throw new DataPrevException("Mensagem não pode ser nula!");

               // Não é permitido realizar execução de averbação sem número da proposta!
               if (!consignado.Proposta.HasValue) throw new DataPrevException("Não é permitido realizar execução de averbação sem número da proposta!");

               // Obténdo a lista de ocorrências da DataPrev
               this.consignadoOcorrencia = new JobConsignadoOcorrenciaBusiness().ObterConsignadoOcorrencia(contexto.IdJob);

               // recuperando objeto de informação complementar 
               var informacaoComplementarContrato = consignado.ConsignadoDetalhe.Beneficio.Beneficios.FirstOrDefault().InformacaoContrato;

               // Não é possível recuperar lista de ocorrências!
               if (this.consignadoOcorrencia.Count == 0) throw new DataPrevException("Não é possível recuperar lista de ocorrências!");

               // executando averbação
               var retorno = this.IncluirInformacao(informacaoComplementarContrato);

               // gravando o retorno na execução do Job
               job.Result = JsonConvert.SerializeObject(retorno);

               if (retorno == null) throw new DataPrevException("Comando sem retorno");

               // gravando histórico
               PropostaService.GetInstance().IncluirHistorico(new PropostaHistorico { Proposta = consignado.Proposta, Usuario = "System", DataExecucao = DateTime.Now, Fase = (consignado.Fase != null ? consignado.Fase : 0), Acao = "Retorno Informação Complementar Contrato", Simulacao = consignado.Simulacao });

               /*
                  Tem uma lista de erros não padronizada? 
               */
               if (retorno?.Error?.ListaErrosContratos?.Count > 0)
                  retorno.Error.Erros.AddRange(retorno?.Error?.ListaErrosContratos.FirstOrDefault().Erros);

               /*Deu erro na fila 47  - Emprestimo já cadastrado HX - veja isso Saulo */
               ProcessarRetorno(
                  new ConsignadoResponseModel
                  {
                     NumeroContrato = retorno.NumeroContrato,
                     HashOperacao = retorno.HashOperacao,
                     Erros = retorno?.Error?.Erros,
                     CodigoSucesso = retorno.Codigo
                  },
                  consignado, contexto);

               // finalizando o job
               ConsignadoService.GetInstance().FinalizaJob(job);
            }
            catch (Exception ex)
            {
               LogService.GetInstance().Error(LogTracerProvider.file, consignado?.CpfCnpj.ToString(), component: component, exception: ex);

               //Registra a exceção na tentativa de execução deste job.
               try { ConsignadoService.GetInstance().AtualizarJob(job, ex); } catch { }

               //Notifica o erro ocorrido...
               try { ConsignadoService.GetInstance().NotificarErroJob(contexto, ex); } catch { }
            }
            finally
            {
               // atualizando o job com os ultimas informações (Bod, Id Fila)...
               ConsignadoService.GetInstance().AtualizarJobFilaLegado(job, mensagem.Id, job.Result);
            }
         }

         try
         {
            // reorganizando a fila de processamento
            ConsignadoService.GetInstance().ReoganizarFila();
         }
         catch (Exception ex)
         {
            LogService.GetInstance().Error(LogTracerProvider.file, consignado?.CpfCnpj.ToString(), component: component, exception: ex);

            //Notifica o erro ocorrido...
            try { ConsignadoService.GetInstance().NotificarErroJob(contexto, ex); } catch { }
         }
      }

      /// <summary>
      /// Responsável por executar a operação de 
      /// </summary>
      /// <param name="contexto"></param>
      //TODO: Reescrever o LogTracer
      //[LogTracer(enableInfo = true, provider = LogTracerProvider.file)]
      public void ExecutarEnvioTaxaJuros(ConfiguracaoJobModel contexto)
      {
         // setando a cultura
         Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");

         // job que está sendo executado no momento
         Job job = null;

         try
         {
            /// obténdo o job
            job = new JobBusiness().Obtem(contexto.IdJob);

            /// atualizando o job para o processando
            job.IdJobStatus = JobStatus.PROCESSANDO;

            // setando data de processamento da mensagem
            job.DataProcessamento = DateTime.Now;

            /// informando ao Job que iniciou o processamento
            ConsignadoService.GetInstance().AtualizarJob(job);

            // setando data de processamento da mensagem
            contexto.DataProcessamento = DateTime.Now;

            var taxaJuros = new TaxaJurosModel
            {
               codigoSolicitante = codigoSolicitante,
               ValorTaxaMensalMinima = contexto.ParametrosExtras.TaxaJuros.ValorTaxaMensalMinima,
               ValorTaxaMensalMaxima = contexto.ParametrosExtras.TaxaJuros.ValorTaxaMensalMaxima,
               ValorTaxaMensalMinimaRMC = contexto.ParametrosExtras.TaxaJuros.ValorTaxaMensalMinimaRMC == 0 ? (decimal?)null : contexto.ParametrosExtras.TaxaJuros.ValorTaxaMensalMinimaRMC,
               ValorTaxaMensalMaximaRMC = contexto.ParametrosExtras.TaxaJuros.ValorTaxaMensalMaximaRMC == 0 ? (decimal?)null : contexto.ParametrosExtras.TaxaJuros.ValorTaxaMensalMaximaRMC,
               ValorTaxaMensalMinimaRCC = contexto.ParametrosExtras.TaxaJuros.ValorTaxaMensalMinimaRCC == 0 ? (decimal?)null : contexto.ParametrosExtras.TaxaJuros.ValorTaxaMensalMinimaRCC,
               ValorTaxaMensalMaximaRCC = contexto.ParametrosExtras.TaxaJuros.ValorTaxaMensalMaximaRCC == 0 ? (decimal?)null : contexto.ParametrosExtras.TaxaJuros.ValorTaxaMensalMaximaRCC,
               Atendimento = contexto.ParametrosExtras.TaxaJuros.Atendimento.ConvertAll(c => new Consignado.Model.DataPrev.Atendimento { Descricao = c.Descricao, Nome = c.Nome })
            };

            IncluirTaxaJuros(taxaJuros);

            // finalizando o job
            ConsignadoService.GetInstance().FinalizaJob(job);
         }
         catch (Exception ex)
         {
            LogService.GetInstance().Error(LogTracerProvider.file, null, component: component, exception: ex);

            //Registra a exceção na tentativa de execução deste job.
            try { ConsignadoService.GetInstance().AtualizarJob(job, ex); } catch { }

            //Notifica o erro ocorrido...
            try { ConsignadoService.GetInstance().NotificarErroJob(contexto, ex); } catch { }
         }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <typeparam name="T"></typeparam>
      /// <param name="retorno"></param>
      /// <param name="consignado"></param>
      /// <param name="contexto"></param>
      /// <exception cref="DataPrevException"></exception>
      protected void ProcessarRetorno<T>(ConsignadoResponseModel retorno, T consignado, ConfiguracaoJobModel contexto) where T : PropostaBaseModel
      {
         // Tem retorno de sucesso?
         if (retorno?.CodigoSucesso != null)
         {
            // buscando codigo de sucesso
            var ocorrenciaSucesso = this.consignadoOcorrencia.Find(c => c.CodigoConsignadoOcorrencia == retorno?.CodigoSucesso);

            // Código de retorno não localizado!
            if (ocorrenciaSucesso == null) throw new DataPrevException("Código de retorno não localizado!");

            // Código de sucesso é aprovação BD
            if (ocorrenciaSucesso.Acao != (int)ConsignadoOcorrenciaAcaoEnum.Aprovar)
               throw new DataPrevException("Código de retorno não parametrizado!");

            try
            {
               // Registrar o retorno do job de envio de informação complementar
               if (contexto.IdJob == jobInformacaoComplementarContrato && ocorrenciaSucesso.Acao == (int)ConsignadoOcorrenciaAcaoEnum.Aprovar)
               {
                  var informacaoComplementar = string.Format("Informação Complementar efetuada com sucesso - {0} - contrato - {1} - codigoSucesso - {2} - hashOperacao", retorno.NumeroContrato, retorno.CodigoSucesso, retorno.HashOperacao);

                  // gravando histórico
                  PropostaService.GetInstance().IncluirHistorico(new PropostaHistorico { Proposta = consignado.Proposta, Usuario = "System", DataExecucao = DateTime.Now, Fase = (consignado.Fase != null ? consignado.Fase : 0), Acao = "Retorno Informação Complementar Contrato com sucesso", Simulacao = consignado.Simulacao });

                  return;
               }

               var complemento = string.Format("Averbação efetuada com sucesso - Competencia Inicio Desconto - {0} - contrato - {1} - codigoSucesso - {2} - hashOperacao - {3}", retorno.CodigoSucesso, retorno.NumeroContrato, retorno.CodigoSucesso, retorno.HashOperacao);

               // liberar ocorrências na proposta
               PropostaService.GetInstance().LiberarOcorrencias(consignado.Proposta, ocorrenciaRestritiva, "System", complemento, true);

               // obter proposta
               var proposta = PropostaService.GetInstance().ObterProposta((int)consignado.Proposta);

               if (proposta.Fase == 8 && proposta.Status == 3) //  AVERBAÇÃO/AGUARDANDO
               {
                  proposta.Status = 12; //SUBMETIDA
                  SubmeterProposta(proposta.Id);

                  // gravando histórico
                  PropostaService.GetInstance().IncluirHistorico(new PropostaHistorico { Proposta = consignado.Proposta, Usuario = "System", DataExecucao = DateTime.Now, Fase = (consignado.Fase != null ? consignado.Fase : 0), Acao = "Aprovar Proposta", Simulacao = consignado.Simulacao });
               }
            }
            catch (Exception ex)
            {
               /*
                 Exception?Neste caso não será possível reprocessar o job, averbação já foi realizada.
                       Somente gravar log e enviar notificação.
               */
               LogService.GetInstance().Error(LogTracerProvider.file, consignado?.CpfCnpj.ToString(), component: component, exception: ex);

               //Notifica o erro ocorrido...
               try { ConsignadoService.GetInstance().NotificarErroJob(contexto, ex); } catch { }
            }
         }
         else if (retorno?.Erros.Count > 0)
         {
            // local function
            List<JobConsignadoOcorrencia> ObterOcorrencia(List<Erro> erro)
            {
               var listaFilter = new List<JobConsignadoOcorrencia>();

               erro.ForEach(x =>
               {
                  var filter = this.consignadoOcorrencia.Find(c => c.CodigoConsignadoOcorrencia == x.Codigo);

                  if (filter != null)
                     listaFilter.Add(filter);
               });

               return listaFilter;
            }

            // Buscando ocorrências de acordo com código de erros retornados
            var ocorrenciaErro = ObterOcorrencia(retorno.Erros);

            // Código de retorno não localizado!
            if (ocorrenciaErro == null) throw new DataPrevException("Código de retorno não localizado!");

            if (ocorrenciaErro.Any(x => x.Acao == (int)ConsignadoOcorrenciaAcaoEnum.Aprovar))
            {
               try
               {
                  var complemento = string.Format("Averbação efetuada com sucesso - Competencia Inicio Desconto - {0} - contrato - {1} - codigoSucesso - {2} - hashOperacao - {3}", retorno.CodigoSucesso, retorno.NumeroContrato, retorno.CodigoSucesso, retorno.HashOperacao);

                  // liberar ocorrências na proposta
                  PropostaService.GetInstance().LiberarOcorrencias(consignado.Proposta, ocorrenciaRestritiva, "System", complemento, true);

                  // submeter proposta
                  var proposta = PropostaService.GetInstance().ObterProposta((int)consignado.Proposta);

                  if (proposta.Fase == 8 && proposta.Status == 3)
                  {
                     proposta.Status = 12;
                     SubmeterProposta(proposta.Id);

                     // gravando histórico
                     PropostaService.GetInstance().IncluirHistorico(new PropostaHistorico { Proposta = consignado.Proposta, Usuario = "System", DataExecucao = DateTime.Now, Fase = (consignado.Fase != null ? consignado.Fase : 0), Acao = "Aprovar Proposta", Simulacao = consignado.Simulacao });
                  }
               }
               catch (Exception ex)
               {
                  /*
                    Exception?Ocorreu um erro ao tentar reprovar a proposta
                          Somente gravar log e enviar notificação.
                  */
                  LogService.GetInstance().Error(LogTracerProvider.file, consignado?.CpfCnpj.ToString(), component: component, exception: ex);

                  //Notifica o erro ocorrido...
                  try { ConsignadoService.GetInstance().NotificarErroJob(contexto, ex); } catch { }
               }
            }
            else if (ocorrenciaErro.Any(x => x.Acao == (int)ConsignadoOcorrenciaAcaoEnum.Reprovar))
            {
               try
               {
                  // agrupando mensagens de erros para subir uma exceção para paralizar o processamento da fila atual
                  var erros = string.Join("-", retorno.Erros.Select(c => string.Concat(c.Codigo, "-", c.Mensagem)));

                  // inserindo ocorrência na proposta
                  InserirOcorrenciaProposta(contexto, consignado, erros);

                  /*
                      Rejeitar Proposta nos casos onde o Job for diferente de Informação Complementar
                          O job de Informação Complementar é a última etapa, não tem como rejeitar a proosta
                  */
                  if (contexto.IdJob != jobInformacaoComplementarContrato)
                  {
                     // submeter proposta
                     var proposta = PropostaService.GetInstance().ObterProposta((int)consignado.Proposta);
                     proposta.MensagemInterna = erros;
                     PropostaService.GetInstance().RejeitaProposta(proposta, "System", false);
                  }

                  // gravando histórico
                  PropostaService.GetInstance().IncluirHistorico(new PropostaHistorico { Proposta = consignado.Proposta, Usuario = "System", DataExecucao = DateTime.Now, Fase = (consignado.Fase != null ? consignado.Fase : 0), Acao = "Rejeitar Proposta", Simulacao = consignado.Simulacao });

                  // subindo exceção para paralizar o processamento da fila atual
                  throw new DataPrevException(erros, new Exception("Job Encerrado"));
               }
               catch (Exception ex)
               {
                  /*
                    Exception?Ocorreu um erro ao tentar reprovar a proposta
                          Somente gravar log e enviar notificação.
                  */
                  LogService.GetInstance().Error(LogTracerProvider.file, consignado?.CpfCnpj.ToString(), component: component, exception: ex);

                  //Notifica o erro ocorrido...
                  try { ConsignadoService.GetInstance().NotificarErroJob(contexto, ex); } catch { }
               }
            }
            else if (ocorrenciaErro.Any(x => x.Acao == (int)ConsignadoOcorrenciaAcaoEnum.Reenviar))
            {
               // agrupando mensagens de erros para subir uma exceção para paralizar o processamento da fila atual
               var erros = string.Join("-", retorno.Erros.Select(c => string.Concat(c.Codigo, "-", c.Mensagem)));

               // inserindo ocorrência na proposta
               InserirOcorrenciaProposta(contexto, consignado, erros);

               // gravando histórico
               PropostaService.GetInstance().IncluirHistorico(new PropostaHistorico { Proposta = consignado.Proposta, Usuario = "System", DataExecucao = DateTime.Now, Fase = (consignado.Fase != null ? consignado.Fase : 0), Acao = "Reenviar Proposta", Simulacao = consignado.Simulacao });

               // subindo exceção para paralizar o processamento da fila atual
               throw new DataPrevException(erros);
            }
            else if (ocorrenciaErro.Any(x => x.Acao == (int)ConsignadoOcorrenciaAcaoEnum.Pendenciar))
            {
               // agrupando mensagens de erros para subir uma exceção para paralizar o processamento da fila atual
               var erros = string.Join("-", retorno.Erros.Select(c => string.Concat(c.Codigo, "-", c.Mensagem)));

               // obténdo a ocorrência com todos os dados
               var ocorrenciaPendenciar = ocorrenciaErro.Find(c => c.Acao == (int)ConsignadoOcorrenciaAcaoEnum.Pendenciar);

               // inserindo ocorrência na proposta
               //InserirOcorrenciaProposta(contexto, consignado, retorno.Erros?.FirstOrDefault()?.Mensagem);

               // obténdo a proposta
               var proposta = PropostaService.GetInstance().ObterProposta((int)consignado.Proposta);

               try
               {
                  /*
                     Pendenciando proposta
                        Fase - 8 - Averbação
                  */
                  PropostaService.GetInstance().PendenciarProposta(proposta, ocorrenciaPendenciar.Ocorrencia, erros, "System");
               }
               catch (Exception ex)
               {
                  throw new DataPrevException(String.Format("Erro ao tentar pendenciar proposta - {0}", consignado.Proposta), ex);
               }

               // subindo exceção para paralizar o processamento da fila atual
               throw new DataPrevException(erros, new Exception("Job Encerrado"));
            }
            else
               throw new DataPrevException("Código de retorno não localizado (Ocorrência)", new Exception("Job Encerrado"));
         }
         else
            throw new DataPrevException("Código de retorno não parametrizado!", new Exception("Job Encerrado"));
      }

      #endregion
   }
}
