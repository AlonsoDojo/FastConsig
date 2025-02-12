using FastConsig.Common.Helpers;
using FastConsig.Common.Loggin;
using FastConsig.Common.Services;
using FastConsig.CTC.Business;
using FastConsig.CTC.Entity;
using FastConsig.CTC.Model;
using FastConsig.CTC.Model.Interfaces;
using FastConsig.Seguranca.Entity;
using Framework.Data;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Transactions;

namespace FastConsig.CTC.Services
{
   public class CTCService
   {
      #region "Singleton"
      private static CTCService _instance;
      public static CTCService GetInstance()
      {
         if (_instance == null)
            _instance = new CTCService();

         return _instance;
      }
      #endregion

      #region "Arquivos"
      public List<CTCDominioArquivo> ListarArquivosMonitorar()
      {
         return new CTCDominioArquivoBusiness().Listar(WhereBuilder.Create().Add(CTCDominioArquivo.METADADO.Monitorar, Filter.Equal, true));
      }
      public List<CTCDominioArquivo> ListarArquivosDominio()
      {
         return new CTCDominioArquivoBusiness().Listar(null);
      }
      public CTCDominioArquivo BuscarArquivosDominio(int? id)
      {
         return new CTCDominioArquivoBusiness().Obtem(id);
      }
      public CTCDominioArquivo BuscarArquivosDominio(string nomeArquivo)
      {
         return new CTCDominioArquivoBusiness().Listar(WhereBuilder.Create().Add(CTCDominioArquivo.METADADO.NomeArquivo, Filter.Equal, nomeArquivo))?.FirstOrDefault();
      }
      public void AlterarArquivosDominio(CTCDominioArquivo obj)
      {
         new CTCDominioArquivoBusiness().Alterar(obj);
      }
      public List<CTCDominioArquivo> ListarArquivosDominio(FiltroMonitorArquivosModel filtro)
      {
         WhereBuilder where = WhereBuilder.Create();

         if (filtro.TipoArquivo != null)
         {
            where.Add(CTCDominioArquivo.METADADO.Id, Filter.Equal, filtro.TipoArquivo, Link.And);
         }

         return new CTCDominioArquivoBusiness().Listar(where);
      }
      public List<CTCArquivos> ListarArquivosAguardandoProcessamento(string fluxo)
      {
         return new CTCArquivosBusiness().Listar(WhereBuilder.Create().Add(CTCArquivos.METADADO.FluxoArquivo, Filter.Equal, fluxo, Link.And)
                                                                      .Add(CTCArquivos.METADADO.SituacaoArquivo, Filter.Equal, 1, Link.And)
                                                                      .Add(CTCArquivos.METADADO.Status, Filter.Equal, "CONCLUIDO"));
      }
      public List<CTCArquivos> ListarArquivosAguardandoEnvio(string fluxo)
      {
         return new CTCArquivosBusiness().Listar(WhereBuilder.Create().Add(CTCArquivos.METADADO.FluxoArquivo, Filter.Equal, fluxo, Link.And)
                                                             .Add(CTCArquivos.METADADO.SituacaoArquivo, Filter.Equal, 2, Link.And)
                                                             .Add(CTCArquivos.METADADO.Status, Filter.Equal, "AGUARDANDO ENVIO", Link.And)
                                                             .Add(CTCArquivos.METADADO.DataReferencia, Filter.Equal, DateTime.Now.Date, Link.And));
      }

      public List<CTCTedsRecebidas> ListarTedsRecebidasNaoProcessadas()
      {
         return new CTCTedsRecebidasBusiness().Listar(WhereBuilder.Create().Add(CTCTedsRecebidas.METADADO.Processado, Filter.Equal, false));
      }
      public int? InserirArquivo(string nomeArquivo, int? dominioArquivo, string conteudo, string ISPBEmissor, string ISPBDestinatario, DateTime? DataReferencia, DateTime? DataHoraArquivo, string fluxoArquivo, string numeroControleEmissor, string numeroControleDestinatario)
      {
         var objArquivo = new CTCArquivos
         {
            NomeArquivo = nomeArquivo,
            Conteudo = conteudo,
            DominioArquivo = dominioArquivo,
            SituacaoArquivo = 1,
            ISPBEmissor = ISPBEmissor,
            ISPBDestinatario = ISPBDestinatario,
            DataReferencia = DataReferencia,
            Status = "CONCLUIDO",
            DataHoraArquivo = DataHoraArquivo,
            FluxoArquivo = fluxoArquivo,
            DataEntrada = DateTime.Now,
            NumeroControleEmissor = numeroControleEmissor,
            NumeroControleDestinatario = numeroControleDestinatario
         };

         new CTCArquivosBusiness().Incluir(objArquivo);
         return objArquivo.Id;
      }
      public void InserirArquivo(CTCArquivos arquivo)
      {
         new CTCArquivosBusiness().Incluir(arquivo);
      }
      public CTCArquivos BuscarArquivo(int? idArquivo)
      {
         return new CTCArquivosBusiness().Obtem(idArquivo);
      }
      public CTCArquivos BuscarArquivo(string nomeArquivo)
      {
         return new CTCArquivosBusiness().Listar(WhereBuilder.Create().Add(CTCArquivos.METADADO.NomeArquivo, Filter.Equal, nomeArquivo)).FirstOrDefault();
      }
      public void AlterarArquivo(CTCArquivos arquivo)
      {
         new CTCArquivosBusiness().Alterar(arquivo);
      }
      public List<CTCArquivos> ListarHistoricoArquivos()
      {
         return new CTCArquivosBusiness().Listar(null);
      }
      public List<CTCArquivos> ListarHistoricoArquivos(FiltroMonitorArquivosModel filtro)
      {
         WhereBuilder where = WhereBuilder.Create();

         if (filtro.DataInicial != null)
         {
            where.Add(CTCArquivos.METADADO.DataHoraArquivo, Filter.GreatherOrEqual, filtro.DataInicial, Link.And);
         }

         if (filtro.DataFinal != null)
         {
            where.Add(CTCArquivos.METADADO.DataHoraArquivo, Filter.LessOrEqual, filtro.DataFinal, Link.And);
         }

         if (filtro.Arquivo != null)
         {
            where.Add(CTCArquivos.METADADO.NomeArquivo, Filter.Equal, filtro.Arquivo, Link.And);
         }

         if (filtro.ISPBOrigem != null)
         {
            where.Add(CTCArquivos.METADADO.ISPBEmissor, Filter.Equal, filtro.ISPBOrigem, Link.And);
         }

         if (filtro.ISPBDestino != null)
         {
            where.Add(CTCArquivos.METADADO.ISPBDestinatario, Filter.Equal, filtro.ISPBDestino, Link.And);
         }

         return new CTCArquivosBusiness().Listar(where);
      }
      public List<CTCArquivoRequisicao> ListarHistoricoArquivos(int? identificador)
      {
         return new CTCArquivoRequisicaoBusiness().Listar(WhereBuilder.Create().Add(CTCArquivoRequisicao.METADADO.Requisicao, Filter.Equal, identificador));
      }
      public void SubmeterArquivo(int? idArquivo)
      {
         throw new NotImplementedException();
      }
      public int? BuscarSequenciaArquivo(int? tipoArquivo, DateTime dataReferencia)
      {
         int? sequencia = 0;

         TransactionHelper.Run(TransactionScopeOption.Required, () =>
         {
            CTCControleSequenciaAquivos objSequencia = new CTCControleSequenciaAquivosBusiness().Listar(WhereBuilder.Create().Add(CTCControleSequenciaAquivos.METADADO.Arquivo, Filter.Equal, tipoArquivo, Link.And)
                                                                                               .Add(CTCControleSequenciaAquivos.METADADO.DataReferencia, Filter.Equal, dataReferencia))?.FirstOrDefault();

            if (objSequencia == null)
            {
               TransactionHelper.Run(TransactionScopeOption.Required, () => InicializaSequenciaArquivos(dataReferencia));
               objSequencia = new CTCControleSequenciaAquivosBusiness().Listar(WhereBuilder.Create().Add(CTCControleSequenciaAquivos.METADADO.Arquivo, Filter.Equal, tipoArquivo, Link.And)
                                                                                               .Add(CTCControleSequenciaAquivos.METADADO.DataReferencia, Filter.Equal, dataReferencia))?.FirstOrDefault();
            }

            sequencia += objSequencia.Sequencia + 1;

            objSequencia.Sequencia = sequencia;

            new CTCControleSequenciaAquivosBusiness().Alterar(objSequencia);
         });

         return sequencia;
      }
      public string GeraNomeArquivo(string tipoArquivo, DateTime dataReferencia)
      {
         CTCDominioArquivo dominio = CTCService.GetInstance().BuscarArquivosDominio(tipoArquivo);
         int? sequencia = this.BuscarSequenciaArquivo(dominio.Id, dataReferencia.Date);
         string nome = tipoArquivo + "_" + ConfiguracaoService.GetInstance().Config<string>("CTC.ISPB.Instituicao") + "_" + dataReferencia.ToString("yyyyMMdd") + "_" + sequencia.ToString().PadLeft(5, '0');
         return nome;
      }
      private void InicializaSequenciaArquivos(DateTime dataReferencia)
      {
         List<CTCControleSequenciaAquivos> arquivos = new CTCControleSequenciaAquivosBusiness().Listar(WhereBuilder.Create().Add(CTCControleSequenciaAquivos.METADADO.DataReferencia, Filter.Equal, new DateTime(2020, 01, 01)));

         foreach (CTCControleSequenciaAquivos a in arquivos)
         {
            a.DataReferencia = dataReferencia;
            a.Id = null;

            new CTCControleSequenciaAquivosBusiness().Incluir(a);
         }
      }
      public void ProcessamentoArquivos()
      {
         //Busca Arquivos de Entrada
         List<CTCArquivos> arquivo = CTCService.GetInstance().ListarArquivosAguardandoProcessamento("E").ToList();

         LogService.GetInstance().GravarLogDebug("Processamento dos Arquivos CTC de Entrada - " + arquivo.Count() + " Aguardando Processamento");

         foreach (var a in arquivo)
         {
            Task.Run(() =>
               TransactionHelper.Run(
                  TransactionScopeOption.Required, () =>
                  {
                     CTCDominioArquivo tipoArquivo = CTCService.GetInstance().BuscarArquivosDominio(a.DominioArquivo);
                     try
                     {
                        Type typeProcess = Type.GetType(tipoArquivo.Process + ", FastConsig.CTC.Helpers");
                        if (typeProcess == null)
                           throw new Exception("Classe de Processamento não definada");
                        dynamic classeProcess = Activator.CreateInstance(typeProcess) as IACTCProcess;
                        classeProcess.Execute(a.Id);
                     }
                     catch (Exception ex)
                     {
                        if (ex.Message != "Portabilidade Retida")
                        {
                           a.Mensagem = "Mensagem: " + ex.Message + " - Stacktrace: " + ex.StackTrace;
                           a.SituacaoArquivo = 2;
                           a.Status = "COM ERRO";
                           new CTCArquivosBusiness().Alterar(a);
                        }
                     }
                  }
               )
            );
         }

         TransactionHelper.Run(TransactionScopeOption.Required, () =>
         {
            //Processa o Fluxo do Arquivo
            //Busca Arquivos de Saida
            List<CTCArquivos> arquivosSaida = CTCService.GetInstance().ListarArquivosAguardandoEnvio("S").OrderBy(x => x.GradeHorariaInicial).ToList();

            LogService.GetInstance().GravarLogDebug("Processamento dos Arquivos CTC de Saída - " + arquivosSaida.Count() + " Aguardando Processamento");

            foreach (var a in arquivosSaida)
            {
               CTCDominioArquivo tipoArquivo = CTCService.GetInstance().BuscarArquivosDominio(a.DominioArquivo);
               try
               {
                  //Verifica a Grade Horária do Arquivo
                  if (DateTime.Now > DateTime.Now.Date.AddHours(tipoArquivo.GradeHorariaInicial.Value.Hour).AddMinutes(tipoArquivo.GradeHorariaInicial.Value.Minute) && DateTime.Now < DateTime.Now.Date.AddHours(tipoArquivo.GradeHorariaFinal.Value.Hour).AddMinutes(tipoArquivo.GradeHorariaFinal.Value.Minute))
                  {
                     //Gera o Arquivo no Diretório de Saída
                     string xml = a.Conteudo;

                     using (var s = File.Create(ConfiguracaoService.GetInstance().Config<string>("CTC.Caminho.Saida.Descriptografado") + "\\" + a.NomeArquivo + ".xml"))
                     {
                        using (var sw = new StreamWriter(s, new UnicodeEncoding(true, false)))
                        {
                           sw.Write(xml);
                        }
                     }

                     File.Copy(ConfiguracaoService.GetInstance().Config<string>("CTC.Caminho.Saida.Descriptografado") + "\\" + a.NomeArquivo + ".xml",
                               ConfiguracaoService.GetInstance().Config<string>("CTC.Caminho.Saida.Criptografado") + "\\" + a.NomeArquivo + ".xml");
                     //                     Thread.Sleep(1000);

                     //CIPService.GetInstance().CriptografarArquivo(
                     //   ConfiguracaoService.GetInstance().Config<string>("CTC.Caminho.Saida.Descriptografado") + "\\" + a.NomeArquivo + ".xml",
                     //   ConfiguracaoService.GetInstance().Config<string>("CTC.Caminho.Saida.Criptografado") + "\\" + a.NomeArquivo,
                     //   ConfiguracaoService.GetInstance().Config<string>("CTC.Serial.Certificado.Publico"),
                     //   ConfiguracaoService.GetInstance().Config<string>("CTC.Serial.Certificado.Privado"),
                     //   ConfiguracaoService.GetInstance().Config<string>("CTC.Serial.Certificado.C3"));

                     a.Status = "CONCLUIDO";

                     CTCService.GetInstance().AlterarArquivo(a);
                     //TODO: Precisa alterar aqui para tratar as Solicitações

                     if (a.Identificador != null)
                     {
                        CTCService.GetInstance().SubmeterRequisicao(a.Identificador);
                     }
                  }
                  else
                  {
                     LogService.GetInstance().GravarLogDebug("Arquivo: " + a.NomeArquivo + " Fora da Grade Horária - Horário Inicial: " + tipoArquivo.GradeHorariaInicial.Value.ToString("HH:mm:ss") + " - Horário Final: " + tipoArquivo.GradeHorariaFinal.Value.ToString("HH:mm:ss"));
                  }

               }
               catch (Exception ex)
               {
                  a.Mensagem = "Mensagem: " + ex.Message + " - Stacktrace: " + ex.StackTrace;
                  a.SituacaoArquivo = 2;
                  a.Status = "COM ERRO";
                  new CTCArquivosBusiness().Alterar(a);
               }
            }
         });


         //Processa as TEDs Recebidas
         List<CTCTedsRecebidas> teds = CTCService.GetInstance().ListarTedsRecebidasNaoProcessadas();

         LogService.GetInstance().GravarLogDebug("[CTC] Processamento das TEDs Recebidas - " + teds.Count() + " Aguardando Processamento");

         foreach (CTCTedsRecebidas t in teds)
         {
            TransactionHelper.Run(TransactionScopeOption.Required, () =>
            {
               //try
               //{
               //   STR0047Model model = JsonConvert.DeserializeObject<STR0047Model>(t.Mensagem);

               //   CTCPagamentosRecebidos pagamento = new CTCPagamentosRecebidos();

               //   if (model.parametros.Where(x => x.CodMsg != null).FirstOrDefault().CodMsg.Contains("STR0047"))
               //   {
               //      pagamento.ValorLancamento = (decimal?)model.valor;
               //      pagamento.AgenciaCreditada = model.parametros.Where(x => x.AgCredtd != null).FirstOrDefault()?.AgCredtd;
               //      pagamento.CNPJCreditado = model.parametros.Where(x => x.CNPJCliCredtd != null).FirstOrDefault()?.CNPJCliCredtd;
               //      pagamento.ISPBCreditado = model.parametros.Where(x => x.ISPBIFCredtd != null).FirstOrDefault().ISPBIFCredtd;
               //      pagamento.ISPBDebitado = model.parametros.Where(x => x.ISPBIFDebtd != null).FirstOrDefault().ISPBIFDebtd;
               //      pagamento.Evento = model.evento_id;
               //      pagamento.AgenciaDebitada = model.parametros.Where(x => x.AgDebtd != null).FirstOrDefault()?.AgDebtd;
               //      pagamento.ContaCreditada = model.parametros.Where(x => x.CtCredtd != null).FirstOrDefault()?.CtCredtd;
               //      try
               //      {
               //         pagamento.DataBACEN = DateTime.ParseExact(model.parametros?.Where(x => x.DtHrBC != null).FirstOrDefault().DtHrBC, "yyyyMMddHHmmss", CultureInfo.InvariantCulture);
               //      }
               //      catch (Exception) { }
               //      pagamento.DataMovimento = DateTime.ParseExact(model.parametros.Where(x => x.DtMovto != null).FirstOrDefault().DtMovto, "yyyyMMdd", CultureInfo.InvariantCulture);
               //      pagamento.ISPBPrestador = model.parametros.Where(x => x.ISPBPrestd != null).FirstOrDefault().ISPBPrestd;

               //      try
               //      {
               //         pagamento.NomeClienteCreditado = model.parametros.Where(x => x.NomCliCredtd != null).FirstOrDefault().NomCliCredtd;
               //      }
               //      catch (Exception) { }

               //      try
               //      {
               //         pagamento.NumeroControle = model.parametros.Where(x => x.NumCtrlSTR != null).FirstOrDefault().NumCtrlSTR;
               //      }
               //      catch (Exception) { }

               //      try
               //      {
               //         pagamento.NUPortabilidade = model.parametros.Where(x => x.NUPortdd != null).FirstOrDefault().NUPortdd;
               //      }
               //      catch (Exception) { }


               //      pagamento.Acatado = false;
               //      pagamento.Conciliado = false;
               //      pagamento.Devolvido = false;

               //      try
               //      {
               //         CTCService.GetInstance().InserirPagamento(pagamento);

               //         t.Processado = true;
               //         CTCService.GetInstance().AlterarTedRecebida(t);

               //      }
               //      catch (Exception ex)
               //      {
               //         if (ex.Message.Contains("KEY_CTCPagamentosRecebidos_Evento"))
               //         {
               //            LogServices.GetInstance().GravarLogInfo("[CTC] Desconsiderando o Evento de TED Recebida: " + t.Evento);
               //         }
               //         else
               //         {
               //            LogServices.GetInstance().GravarLogErro(ex, "[CTC] Falha ao Processar a STR do Evento " + t.Evento + " - Message: " + ex.Message + " - Stacktrace: " + ex.StackTrace);
               //         }
               //      }
               //   }
               //   else
               //   {
               //      //TODO: Efetuar o Processamento das STR0048 quando estivermos devolvendo automáticamente os pagamentos
               //      LogServices.GetInstance().GravarLogInfo("[CTC] Ignorando a STR0048 do Evento " + t.Evento);
               //      t.Processado = true;
               //      CTCService.GetInstance().AlterarTedRecebida(t);
               //   }
               //}
               //catch (Exception ax)
               //{
               //   LogServices.GetInstance().GravarLogErro(ax, "[CTC] Falha ao Processar a STR - Message: " + ax.Message + " - Stacktrace: " + ax.StackTrace);
               //}
            });
         }


      }

      public void ProcessamentoArquivosSaida()
      {
         TransactionHelper.Run(TransactionScopeOption.Required, () =>
         {
            //Processa o Fluxo do Arquivo
            //Busca Arquivos de Saida

            List<CTCArquivos> arquivosSaida;

            try
            {
               arquivosSaida = CTCService.GetInstance().ListarArquivosAguardandoEnvio("S").OrderBy(x => x.GradeHorariaInicial).Take(60).ToList();

               LogService.GetInstance().GravarLogDebug("Processamento dos Arquivos CTC de Saída - " + arquivosSaida.Count() + " Aguardando Processamento");

               foreach (var a in arquivosSaida)
               {
                  CTCDominioArquivo tipoArquivo = CTCService.GetInstance().BuscarArquivosDominio(a.DominioArquivo);
                  try
                  {
                     //Verifica a Grade Horária do Arquivo
                     if (DateTime.Now > DateTime.Now.Date.AddHours(tipoArquivo.GradeHorariaInicial.Value.Hour).AddMinutes(tipoArquivo.GradeHorariaInicial.Value.Minute) && DateTime.Now < DateTime.Now.Date.AddHours(tipoArquivo.GradeHorariaFinal.Value.Hour).AddMinutes(tipoArquivo.GradeHorariaFinal.Value.Minute))
                     {
                        //Gera o Arquivo no Diretório de Saída
                        string xml = a.Conteudo;

                        using (var s = File.Create(ConfiguracaoService.GetInstance().Config<string>("CTC.Caminho.Saida.Descriptografado") + "\\" + a.NomeArquivo + ".xml"))
                        {
                           using (var sw = new StreamWriter(s, new UnicodeEncoding(true, false)))
                           {
                              sw.Write(xml);
                           }
                        }

                        File.Copy(ConfiguracaoService.GetInstance().Config<string>("CTC.Caminho.Saida.Descriptografado") + "\\" + a.NomeArquivo + ".xml",
                                  ConfiguracaoService.GetInstance().Config<string>("CTC.Caminho.Saida.Criptografado") + "\\" + a.NomeArquivo + ".xml");
                        Thread.Sleep(500);

                        //CIPService.GetInstance().CriptografarArquivo(
                        //   ConfiguracaoService.GetInstance().Config<string>("CTC.Caminho.Saida.Descriptografado") + "\\" + a.NomeArquivo + ".xml",
                        //   ConfiguracaoService.GetInstance().Config<string>("CTC.Caminho.Saida.Criptografado") + "\\" + a.NomeArquivo,
                        //   ConfiguracaoService.GetInstance().Config<string>("CTC.Serial.Certificado.Publico"),
                        //   ConfiguracaoService.GetInstance().Config<string>("CTC.Serial.Certificado.Privado"),
                        //   ConfiguracaoService.GetInstance().Config<string>("CTC.Serial.Certificado.C3"));

                        a.Status = "CONCLUIDO";

                        CTCService.GetInstance().AlterarArquivo(a);
                        //TODO: Precisa alterar aqui para tratar as Solicitações

                        if (a.Identificador != null)
                        {
                           CTCService.GetInstance().SubmeterRequisicao(a.Identificador);
                        }
                     }
                     else
                     {
                        LogService.GetInstance().GravarLogDebug("Arquivo: " + a.NomeArquivo + " Fora da Grade Horária - Horário Inicial: " + tipoArquivo.GradeHorariaInicial.Value.ToString("HH:mm:ss") + " - Horário Final: " + tipoArquivo.GradeHorariaFinal.Value.ToString("HH:mm:ss"));
                     }

                  }
                  catch (Exception ex)
                  {
                     a.Mensagem = "Mensagem: " + ex.Message + " - Stacktrace: " + ex.StackTrace;
                     a.SituacaoArquivo = 2;
                     a.Status = "COM ERRO";
                     new CTCArquivosBusiness().Alterar(a);
                  }
               }

            }
            catch (Exception x)
            {
               LogService.GetInstance().GravarLogDebug("Falha ao obter os arquivos de saída - Mensagem: " + x.Message + " - Stacktrace: " + x.StackTrace);
            }






            //Processa as TEDs Recebidas
            //List<CTCTedsRecebidas> teds = CTCService.GetInstance().ListarTedsRecebidasNaoProcessadas();

            //LogServices.GetInstance().GravarLogDebug("Processamento das TEDs Recebidas - " + teds.Count() + " Aguardando Processamento");

            //foreach (CTCTedsRecebidas t in teds)
            //{
            //   STR0047Model model = JsonConvert.DeserializeObject<STR0047Model>(t.Mensagem);

            //   CTCPagamentosRecebidos pagamento = new CTCPagamentosRecebidos();

            //   if (!model.parametros.Where(x => x.CodMsg != null).FirstOrDefault().CodMsg.Contains("STR0048"))
            //   {
            //      pagamento.ValorLancamento = (decimal?)model.valor;
            //      pagamento.AgenciaCreditada = model.parametros.Where(x => x.AgCredtd != null).FirstOrDefault()?.AgCredtd;
            //      pagamento.CNPJCreditado = model.parametros.Where(x => x.CNPJCliCredtd != null).FirstOrDefault()?.CNPJCliCredtd;
            //      pagamento.ISPBCreditado = model.parametros.Where(x => x.ISPBIFCredtd != null).FirstOrDefault().ISPBIFCredtd;
            //      pagamento.ISPBDebitado = model.parametros.Where(x => x.ISPBIFDebtd != null).FirstOrDefault().ISPBIFDebtd;
            //      pagamento.Evento = model.evento_id;
            //      pagamento.AgenciaDebitada = model.parametros.Where(x => x.AgDebtd != null).FirstOrDefault()?.AgDebtd;
            //      pagamento.ContaCreditada = model.parametros.Where(x => x.CtCredtd != null).FirstOrDefault()?.CtCredtd;
            //      pagamento.DataBACEN = DateTime.ParseExact(model.parametros.Where(x => x.DtHrBC != null).FirstOrDefault().DtHrBC, "yyyyMMddHHmmss", CultureInfo.InvariantCulture);
            //      pagamento.DataMovimento = DateTime.ParseExact(model.parametros.Where(x => x.DtMovto != null).FirstOrDefault().DtMovto, "yyyyMMdd", CultureInfo.InvariantCulture);
            //      pagamento.ISPBPrestador = model.parametros.Where(x => x.ISPBPrestd != null).FirstOrDefault().ISPBPrestd;
            //      pagamento.NomeClienteCreditado = model.parametros.Where(x => x.NomCliCredtd != null).FirstOrDefault().NomCliCredtd;
            //      pagamento.NumeroControle = model.parametros.Where(x => x.NumCtrlSTR != null).FirstOrDefault().NumCtrlSTR;
            //      pagamento.NUPortabilidade = model.parametros.Where(x => x.NUPortdd != null).FirstOrDefault().NUPortdd;
            //      pagamento.Acatado = false;
            //      pagamento.Conciliado = false;
            //      pagamento.Devolvido = false;

            //      try
            //      {
            //         CTCService.GetInstance().InserirPagamento(pagamento);

            //         t.Processado = true;
            //         CTCService.GetInstance().AlterarTedRecebida(t);

            //      }
            //      catch (Exception ex)
            //      {
            //         LogServices.GetInstance().GravarLogErro("Falha ao Processar a STR do Evento " + t.Evento + " - Message: " + ex.Message + " - Stacktrace: " + ex.StackTrace);
            //      }
            //   }
            //   else
            //   {
            //      //TODO: Efetuar o Processamento das STR0048 quando estivermos devolvendo automáticamente os pagamentos
            //      LogServices.GetInstance().GravarLogErro("Ignorando a STR0048 do Evento " + t.Evento);
            //      t.Processado = true;
            //      CTCService.GetInstance().AlterarTedRecebida(t);
            //   }
            //}
         });

      }

      public void ProcessamentoAGEN001()
      {
         TransactionHelper.Run(TransactionScopeOption.Required, () =>
         {
            string nomeArquivo = CTCService.GetInstance().GeraNomeArquivo("AGEN001", DateTime.Now.Date);

            CTCArquivos arquivoCTC = new CTCArquivos()
            {
               DataReferencia = DateTime.Now.Date,
               DataEntrada = DateTime.Now,
               DataHoraArquivo = DateTime.Now,
               DominioArquivo = 122,
               FluxoArquivo = "S",
               Conteudo = " ",
               ISPBEmissor = "61820817",
               ISPBDestinatario = "61820817",
               NomeArquivo = nomeArquivo,
               Status = "AGUARDANDO ENVIO",
               SituacaoArquivo = 2, /*Processamento*/
               Identificador = null
            };

            CTCService.GetInstance().InserirArquivo(arquivoCTC);
         });
      }
      #endregion

      #region "Requisições"
      public void SubmeterRequisicao(CTCRequisicao requisicao)
      {
         //Verifica qual a fase da proposta
         int? fase = requisicao.Fase;
         int? tipoFluxo = requisicao.TipoFluxo;

         //se for entrada na fase chama as politicas de entrada
         bool entrada = false;
         //se for saida da fase ... chama as politicas de saida
         bool saida = false;

         if (requisicao.Id == null)
         {
            entrada = true;
         }
         else
         {
            if (requisicao.Status == "PROCESSANDO" || requisicao.Status == "REPROCESSANDO" || requisicao.Status == "COM ERRO")
            {
               requisicao.Status = "AGUARDANDO";
               entrada = true;
            }
            else
            {
               saida = true;

               var politicasSaida = ListarPoliticasFase(fase, tipoFluxo, requisicao.TipoArquivo, requisicao.Status, entrada, saida);

               if (politicasSaida == null || politicasSaida.Count == 0)
               {
                  saida = false;
                  entrada = true;

                  var politicasEntrada = ListarPoliticasFase(fase, tipoFluxo, requisicao.TipoArquivo, requisicao.Status, entrada, saida);

               }
            }
         }

         //TransactionHelper.Run(TransactionScopeOption.Required, () => AtualizaProposta(proposta));
         //proposta = ObterProposta(proposta.Id);

         List<CTCPoliticaConfiguracaoExecucao> politicas = null;

         try
         {
            //Busca as politicas que tem que ser executadas na Fase em que a proposta esta
            politicas = ListarPoliticasFase(fase, tipoFluxo, requisicao.TipoArquivo, requisicao.Status, entrada, saida);

            if (politicas == null)
               throw new Exception("Nenhuma politica foi encontrada!");
         }
         catch (Exception ex)
         {
            LogService.GetInstance().GravarLogErro(ex, ex.Message);

            throw new Exception("Erro ao tentar obter politicas", ex);
         }

         foreach (CTCPoliticaConfiguracaoExecucao p in politicas)
         {
            if ((requisicao.TipoPessoa == "F" ? 1 : 2) == p.TipoPessoa)
            {
               try
               {
                  ExecutaPoliticaRequisicao(p.Metodo, requisicao, fase, tipoFluxo, requisicao.TipoPessoa);
               }
               catch (Exception ex)
               {
                  if (requisicao.Status == "SUBMETIDA")
                  {
                     requisicao.Status = "SALVA";
                  }

                  TransactionHelper.Run(TransactionScopeOption.Required, () => AlterarRequesicao(requisicao));
                  requisicao = this.BuscarRequisicao(requisicao.Id);
                  throw new Exception(ex.Message, ex);
               }
            }
         }
      }
      public void SubmeterRequisicao(int? idRequisicao)
      {
         CTCRequisicao requisicao = new CTCRequisicaoBusiness().Obtem(idRequisicao);
         this.SubmeterRequisicao(requisicao);
      }
      public List<CTCPoliticaConfiguracaoExecucao> ListarPoliticasFase(int? fase, int? tipoFluxo, int? tipoArquivo, string status, bool entrada, bool saida)
      {
         try
         {
            Framework.Data.WhereBuilder where = Framework.Data.WhereBuilder.Create().Add(CTCPoliticaConfiguracaoExecucao.METADADO.Fase, Filter.Equal, fase, Link.And)
                                                                                    .Add(CTCPoliticaConfiguracaoExecucao.METADADO.TipoArquivo, Filter.Equal, tipoArquivo, Link.And)
                                                                                    .Add(CTCPoliticaConfiguracaoExecucao.METADADO.TipoFluxo, Filter.Equal, tipoFluxo, Link.And);
            where.Add(CTCPoliticaConfiguracaoExecucao.METADADO.Entrada, Filter.Equal, entrada, Link.And);
            where.Add(CTCPoliticaConfiguracaoExecucao.METADADO.Saida, Filter.Equal, saida, Link.And);

            return new CTCPoliticaConfiguracaoExecucaoBusiness().Listar(where)?.OrderBy(x => x.Peso)?.ToList();
         }
         catch (Exception ex)
         {
            throw new Exception("Erro ao executar ListarPoliticasFase", ex);
         }
      }
      public void ExecutaPoliticaRequisicao(string politica, CTCRequisicao requisicao, int? fase, int? tipoFluxo, string tipoPessoaPolitica)
      {
         Type t = Type.GetType(politica + ", FastConsig.CTC.Politicas");
         dynamic o = Activator.CreateInstance(t) as IPoliticaCTCRequisicao;
         o.Execute(requisicao, fase, tipoFluxo, tipoPessoaPolitica);
      }
      public int? BuscaProximaFase(int? tipoArquivo, int? faseAtual, int? fluxo)
      {
         //busca a sequencia da fase atual
         var sequencia = new CTCFasesFluxoBusiness().Listar(Framework.Data.WhereBuilder.Create().Add(CTCFasesFluxo.METADADO.TipoArquivo, Filter.Equal, tipoArquivo, Link.And)
                                                                                                .Add(CTCFasesFluxo.METADADO.Fase, Filter.Equal, faseAtual, Link.And)
                                                                                                .Add(CTCFasesFluxo.METADADO.TipoFluxo, Filter.Equal, fluxo, Link.And)).FirstOrDefault().Ordem;

         //Busca a Próxima Fase
         var novaFase = new CTCFasesFluxoBusiness().Listar(Framework.Data.WhereBuilder.Create().Add(CTCFasesFluxo.METADADO.TipoArquivo, Filter.Equal, tipoArquivo, Link.And)
                                                                                               .Add(CTCFasesFluxo.METADADO.TipoFluxo, Filter.Equal, fluxo, Link.And)
                                                                                               .Add(CTCFasesFluxo.METADADO.Ordem, Filter.GreatherThan, sequencia, Link.And)).OrderBy(x => x.Ordem).FirstOrDefault();

         if (novaFase == null)
         {
            throw new Exception("Sem Fases do Processo a Seguir");
         }

         return novaFase.Fase;
      }
      public void InserirRequesicao(CTCRequisicao obj)
      {
         new CTCRequisicaoBusiness().Incluir(obj);
      }
      public void AlterarRequesicao(CTCRequisicao obj)
      {
         new CTCRequisicaoBusiness().Alterar(obj);
      }
      public CTCRequisicao BuscarRequisicao(int? requisicao)
      {
         return new CTCRequisicaoBusiness().Obtem(requisicao);
      }
      public CTCRequisicao BuscarRequisicao(string nuPortabilidade)
      {
         return new CTCRequisicaoBusiness().Listar(WhereBuilder.Create().Add(CTCRequisicao.METADADO.NUPortabilidade, Filter.Equal, nuPortabilidade)).FirstOrDefault();
      }
      public void InserirRequesicaoSimulacao(CTCRequisicaoSimulacao obj)
      {
         new CTCRequisicaoSimulacaoBusiness().Incluir(obj);
      }
      public CTCRequisicaoSimulacao BuscarRequesicaoSimulacao(int? id)
      {
         return new CTCRequisicaoSimulacaoBusiness().Obtem(id);
      }
      public List<CTCRequisicaoSimulacao> ListarRequesicaoSimulacao(int? requisicao)
      {
         return new CTCRequisicaoSimulacaoBusiness().Listar(WhereBuilder.Create().Add(CTCRequisicaoSimulacao.METADADO.Requisicao, Filter.Equal, requisicao));
      }
      public List<CTCRequisicaoHistorico> ListarRequesicaoHistorico(int? requisicao)
      {
         return new CTCRequisicaoHistoricoBusiness().Listar(WhereBuilder.Create().Add(CTCRequisicaoHistorico.METADADO.Requisicao, Filter.Equal, requisicao)).OrderByDescending(x => x.DataOcorrencia).ToList();
      }
      public List<CTCRequisicaoSimulacao> ListarRequesicaoSimulacao(int? requisicao, bool comparativos = false, bool simulacoes = false)
      {
         WhereBuilder where = WhereBuilder.Create().Add(CTCRequisicaoSimulacao.METADADO.Requisicao, Filter.Equal, requisicao, Link.And);

         if (comparativos)
         {
            where.Add(Block.Begin);
            where.Add(CTCRequisicaoSimulacao.METADADO.Tipo, Filter.Equal, 1, Link.Or);
            where.Add(CTCRequisicaoSimulacao.METADADO.Tipo, Filter.Equal, 2, Link.And);
            where.Add(Block.End);
         }

         if (simulacoes)
         {
            where.Add(Block.Begin);
            where.Add(CTCRequisicaoSimulacao.METADADO.Tipo, Filter.Equal, 3, Link.And);
            where.Add(Block.End);
         }

         return new CTCRequisicaoSimulacaoBusiness().Listar(where);
      }
      public void InserirOcorrencia(CTCRequisicaoHistorico obj)
      {
         new CTCRequisicaoHistoricoBusiness().Incluir(obj);
      }

      public void InserirVinculoArquivo(CTCArquivoRequisicao obj)
      {
         new CTCArquivoRequisicaoBusiness().Incluir(obj);
      }

      public List<CTCMotivoRetencaoContrato> ListarMotivoRetencao()
      {
         return new CTCMotivoRetencaoContratoBusiness().Listar(null);
      }
      public List<CTCMotivoRetencaoContrato> ListarMotivoRetencao(string tipoContrato)
      {
         WhereBuilder where = WhereBuilder.Create();

         switch (tipoContrato)
         {
            case "0202":
               where.Add(CTCMotivoRetencaoContrato.METADADO.Consignado, Filter.Equal, true);
               break;
            case "0203":
               where.Add(CTCMotivoRetencaoContrato.METADADO.CreditoPessoal, Filter.Equal, true);
               break;
            case "0211":
               where.Add(CTCMotivoRetencaoContrato.METADADO.CreditoImobiliario, Filter.Equal, true);
               break;
            case "0299":
               where.Add(CTCMotivoRetencaoContrato.METADADO.CreditoImobiliario, Filter.Equal, true);
               break;
            case "0401":
               where.Add(CTCMotivoRetencaoContrato.METADADO.FinancimentoVeiculo, Filter.Equal, true);
               break;
            case "0901":
               where.Add(CTCMotivoRetencaoContrato.METADADO.CreditoImobiliario, Filter.Equal, true);
               break;
            case "0902":
               where.Add(CTCMotivoRetencaoContrato.METADADO.CreditoImobiliario, Filter.Equal, true);
               break;
            case "0903":
               where.Add(CTCMotivoRetencaoContrato.METADADO.CreditoImobiliario, Filter.Equal, true);
               break;
            case "0212":
               where.Add(CTCMotivoRetencaoContrato.METADADO.OutrosCreditos, Filter.Equal, true);
               break;
            case "0402":
               where.Add(CTCMotivoRetencaoContrato.METADADO.OutrosCreditos, Filter.Equal, true);
               break;
            case "0403":
               where.Add(CTCMotivoRetencaoContrato.METADADO.OutrosCreditos, Filter.Equal, true);
               break;
            case "0213":
               where.Add(CTCMotivoRetencaoContrato.METADADO.ChequeEspecial, Filter.Equal, true);
               break;
            case "0215":
               where.Add(CTCMotivoRetencaoContrato.METADADO.CapitalGiro, Filter.Equal, true);
               break;
            case "0216":
               where.Add(CTCMotivoRetencaoContrato.METADADO.CapitalGiro, Filter.Equal, true);
               break;
            case "0217":
               where.Add(CTCMotivoRetencaoContrato.METADADO.CapitalGiro, Filter.Equal, true);
               break;
            case "":
               break;
            default:
               break;
         }

         return new CTCMotivoRetencaoContratoBusiness().Listar(where);
      }
      public List<CTCMotivoCancelamentoPortabilidade> ListarMotivoCancelamento()
      {
         return new CTCMotivoCancelamentoPortabilidadeBusiness().Listar(null);
      }
      public List<CTCMotivoCancelamentoPortabilidade> ListarMotivoCancelamento(string tipoContrato)
      {
         WhereBuilder where = WhereBuilder.Create();

         switch (tipoContrato)
         {
            case "0202":
               where.Add(CTCMotivoCancelamentoPortabilidade.METADADO.Consignado, Filter.Equal, true);
               break;
            case "0203":
               where.Add(CTCMotivoCancelamentoPortabilidade.METADADO.CreditoPessoal, Filter.Equal, true);
               break;
            case "0211":
               where.Add(CTCMotivoCancelamentoPortabilidade.METADADO.CreditoImobiliario, Filter.Equal, true);
               break;
            case "0299":
               where.Add(CTCMotivoCancelamentoPortabilidade.METADADO.CreditoImobiliario, Filter.Equal, true);
               break;
            case "0401":
               where.Add(CTCMotivoCancelamentoPortabilidade.METADADO.FinancimentoVeiculo, Filter.Equal, true);
               break;
            case "0901":
               where.Add(CTCMotivoCancelamentoPortabilidade.METADADO.CreditoImobiliario, Filter.Equal, true);
               break;
            case "0902":
               where.Add(CTCMotivoCancelamentoPortabilidade.METADADO.CreditoImobiliario, Filter.Equal, true);
               break;
            case "0903":
               where.Add(CTCMotivoCancelamentoPortabilidade.METADADO.CreditoImobiliario, Filter.Equal, true);
               break;
            case "0212":
               where.Add(CTCMotivoCancelamentoPortabilidade.METADADO.OutrosCreditos, Filter.Equal, true);
               break;
            case "0402":
               where.Add(CTCMotivoCancelamentoPortabilidade.METADADO.OutrosCreditos, Filter.Equal, true);
               break;
            case "0403":
               where.Add(CTCMotivoCancelamentoPortabilidade.METADADO.OutrosCreditos, Filter.Equal, true);
               break;
            case "0213":
               where.Add(CTCMotivoCancelamentoPortabilidade.METADADO.ChequeEspecial, Filter.Equal, true);
               break;
            case "0215":
               where.Add(CTCMotivoCancelamentoPortabilidade.METADADO.CapitalGiro, Filter.Equal, true);
               break;
            case "0216":
               where.Add(CTCMotivoCancelamentoPortabilidade.METADADO.CapitalGiro, Filter.Equal, true);
               break;
            case "0217":
               where.Add(CTCMotivoCancelamentoPortabilidade.METADADO.CapitalGiro, Filter.Equal, true);
               break;
            case "":
               break;
            default:
               break;
         }

         return new CTCMotivoCancelamentoPortabilidadeBusiness().Listar(where);
      }
      public List<CTCMotivoDecursoPrazoPortabilidade> ListarMotivoDecursodePrazo()
      {
         return new CTCMotivoDecursoPrazoPortabilidadeBusiness().Listar(null);
      }
      public List<CTCMotivoDevolucaoLiquidacaoPortabilidade> ListarMotivoDevolucaoLiquidacao()
      {
         return new CTCMotivoDevolucaoLiquidacaoPortabilidadeBusiness().Listar(null);
      }
      public DateTime BuscarDataSaldo()
      {
         DateTime data = ConfiguracaoService.GetInstance().Config<DateTime>("CTC.DataSaldo");

         //Se a Data Saldo menor que a Data Atual muda para a Data Atual
         if (data < DateTime.Now.Date)
         {
            data = DateTime.Now.Date;
            ConfiguracaoService.GetInstance().Salvar(new Configuracao() { Chave = "CTC.DataSaldo", Conteudo = data.Date.ToString() });
         }

         //Se a Grade Horária do ACTC103 estiver estourada muda para o próximo dia
         CTCDominioArquivo grade = this.BuscarArquivosDominio("ACTC103");

         DateTime dataComparacaoFinal = data.AddHours(grade.GradeHorariaFinal.Value.Hour).AddMinutes(grade.GradeHorariaFinal.Value.Minute);

         if (DateTime.Now > dataComparacaoFinal)
         {
            data = data.AddDays(1);
         }

         //Se a Data Saldo for Feriado muda para o próximo dia útil
         while (true)
         {
            if (!this.DiaUtil(data))
            {
               data = data.AddDays(1);
            }
            else
            {
               ConfiguracaoService.GetInstance().Salvar(new Configuracao() { Chave = "CTC.DataSaldo", Conteudo = data.Date.ToString() });
               break;
            }
         }




         return data;
      }

      public DateTime BuscarDataCancelamento()
      {
         DateTime data = ConfiguracaoService.GetInstance().Config<DateTime>("CTC.DataCancelamento");

         //Se a Data Saldo menor que a Data Atual muda para a Data Atual
         if (data < DateTime.Now.Date)
         {
            data = DateTime.Now.Date;
            ConfiguracaoService.GetInstance().Salvar(new Configuracao() { Chave = "CTC.DataCancelamento", Conteudo = data.Date.ToString() });
         }

         //Se a Grade Horária do ACTC103 estiver estourada muda para o próximo dia
         CTCDominioArquivo grade = this.BuscarArquivosDominio("ACTC900");

         DateTime dataComparacaoFinal = data.AddHours(grade.GradeHorariaFinal.Value.Hour).AddMinutes(grade.GradeHorariaFinal.Value.Minute);

         if (DateTime.Now > dataComparacaoFinal)
         {
            data = data.AddDays(1);
         }

         //Se a Data Saldo for Feriado muda para o próximo dia útil
         while (true)
         {
            if (!this.DiaUtil(data))
            {
               data = data.AddDays(1);
            }
            else
            {
               ConfiguracaoService.GetInstance().Salvar(new Configuracao() { Chave = "CTC.DataCancelamento", Conteudo = data.Date.ToString() });
               break;
            }
         }

         return data;
      }
      public DateTime BuscarDataResposta(string tipoArquivo)
      {
         DateTime data = DateTime.Now.Date;

         //Se a Grade Horária do Arquivo estiver estourada muda para o próximo dia
         CTCDominioArquivo grade = this.BuscarArquivosDominio(tipoArquivo);

         DateTime dataComparacaoFinal = data.AddHours(grade.GradeHorariaFinal.Value.Hour).AddMinutes(grade.GradeHorariaFinal.Value.Minute);

         if (DateTime.Now > dataComparacaoFinal)
         {
            data = data.AddDays(1);
         }

         //Se a Data Saldo for Feriado muda para o próximo dia útil
         while (true)
         {
            if (!this.DiaUtil(data))
            {
               data = data.AddDays(1);
            }
            else
            {
               break;
            }
         }
         return data;
      }
      public void AceitarPortabilidade(CTCRequisicao requisicao, string usuario)
      {
         //Muda o Fluxo da Requisição para 3 (Aceitação)
         requisicao.TipoFluxo = 3;
         requisicao.DataReferenciaSaldoResposta = CTCService.GetInstance().BuscarDataSaldo();
         requisicao.DataRespostaSaldo = DateTime.Now;
         requisicao.UsuarioAceite = usuario;
         requisicao.Fase = CTCService.GetInstance().BuscaProximaFase(requisicao.TipoArquivo, requisicao.Fase, requisicao.TipoFluxo);
         requisicao.Status = "PROCESSANDO";

         AlterarRequesicao(requisicao);
         SubmeterRequisicao(requisicao);
      }
      public void ReterPortabilidade(CTCRequisicao requisicao, string usuario)
      {
         //Muda o Fluxo da Requisição para 4 (Retenção)
         requisicao.TipoFluxo = 4;
         requisicao.DataRetencao = DateTime.Now;
         requisicao.DataReferenciaRetencao = CTCService.GetInstance().BuscarDataSaldo();
         requisicao.UsuarioRetencao = usuario;
         requisicao.Fase = CTCService.GetInstance().BuscaProximaFase(requisicao.TipoArquivo, requisicao.Fase, requisicao.TipoFluxo);
         requisicao.Status = "PROCESSANDO";

         string motivoRetencao = this.ListarMotivoRetencao().Where(x => x.Codigo == requisicao.MotivoRetencao).FirstOrDefault().Descricao;

         InserirOcorrencia(new CTCRequisicaoHistorico() { DataOcorrencia = DateTime.Now, Ocorrencia = 7, Requisicao = requisicao.Id, Usuario = usuario, Complemento = "Portabilidade Retida - Motivo: " + motivoRetencao });

         AlterarRequesicao(requisicao);
         SubmeterRequisicao(requisicao);
      }
      public void InformarPagamento(CTCRequisicao requisicao, string usuario)
      {
         requisicao.UsuarioPagamento = usuario;
         requisicao.Status = "PROCESSANDO";

         InserirOcorrencia(new CTCRequisicaoHistorico() { DataOcorrencia = DateTime.Now, Ocorrencia = 8, Requisicao = requisicao.Id, Usuario = usuario, Complemento = "Pagamento no Valor de R$ " + requisicao.ValorPago.Value.ToString("N2") + " Confirmado em: " + requisicao.DataPagamento.Value.ToString("dd/MM/yyyy") });

         AlterarRequesicao(requisicao);
         SubmeterRequisicao(requisicao);
      }
      public void CancelarPortabilidade(CTCRequisicao requisicao, string usuario)
      {
         requisicao.TipoFluxo = 6; /*Cancelamento quando esta aguardando Pagamento*/
         requisicao.Fase = CTCService.GetInstance().BuscaProximaFase(requisicao.TipoArquivo, requisicao.Fase, requisicao.TipoFluxo);
         requisicao.UsuarioCancelamento = usuario;
         requisicao.DataCancelamento = CTCService.GetInstance().BuscarDataCancelamento();
         requisicao.Status = "PROCESSANDO";

         string motivoCancelamento = this.ListarMotivoCancelamento().Where(x => x.Codigo == requisicao.MotivoCancelamento).FirstOrDefault().Descricao;

         InserirOcorrencia(new CTCRequisicaoHistorico() { DataOcorrencia = DateTime.Now, Ocorrencia = 9, Requisicao = requisicao.Id, Usuario = usuario, Complemento = "Cancelada a Portabilidade pelo Motivo: " + motivoCancelamento });

         AlterarRequesicao(requisicao);
         SubmeterRequisicao(requisicao);
      }

      #endregion

      #region "Solicitações"
      public void SubmeterSolicitacao(int? idSolicitacao)
      {
         throw new NotImplementedException();
      }
      public List<CTCRequisicao> ListarRequisicoes(FiltroMonitorArquivosModel filtro)
      {
         WhereBuilder where = WhereBuilder.Create();

         if (filtro.DataInicial != null)
         {
            where.Add(CTCRequisicao.METADADO.DataReferencia, Filter.GreatherOrEqual, filtro.DataInicial, Link.And);
         }

         if (filtro.DataFinal != null)
         {
            where.Add(CTCRequisicao.METADADO.DataReferencia, Filter.LessOrEqual, filtro.DataFinal, Link.And);
         }

         if (filtro.Contrato != null)
         {
            where.Add(CTCRequisicao.METADADO.Contrato, Filter.Like, "%" + filtro.Contrato, Link.And);
         }

         if (filtro.CPF != null)
         {
            where.Add(CTCRequisicao.METADADO.CpfCnpjCliente, Filter.Equal, filtro.CPF, Link.And);
         }

         if (filtro.Fase != null)
         {
            where.Add(CTCRequisicao.METADADO.Fase, Filter.Equal, filtro.Fase, Link.And);
         }

         if (filtro.NUPortabilidade != null)
         {
            where.Add(CTCRequisicao.METADADO.NUPortabilidade, Filter.Equal, filtro.NUPortabilidade, Link.And);
         }

         return new CTCRequisicaoBusiness().Listar(where);
      }
      #endregion

      #region "Integrações"
      #endregion

      #region "Ocorrências"
      public void InserirOcorrencia(CTCOcorrencia obj)
      {
         new CTCOcorrenciaBusiness().Incluir(obj);
      }
      public void AlterarOcorrencia(CTCOcorrencia obj)
      {
         new CTCOcorrenciaBusiness().Alterar(obj);
      }
      public void ExcluirOcorrencia(CTCOcorrencia obj)
      {
         new CTCOcorrenciaBusiness().Excluir(obj.Id);
      }
      public void ExcluirOcorrencia(int? id)
      {
         new CTCOcorrenciaBusiness().Excluir(id);
      }
      public CTCOcorrencia BuscarOcorrencia(int? id)
      {
         return new CTCOcorrenciaBusiness().Obtem(id);
      }
      public List<CTCOcorrencia> ListarOcorrencias()
      {
         return new CTCOcorrenciaBusiness().Listar(WhereBuilder.Create().Add(CTCOcorrencia.METADADO.Visivel, Filter.Equal, true));
      }
      #endregion

      #region "Calculo da RCO"
      /// <summary>
      /// Efetua o Cálculo da RCO*
      /// *RCO -> Ressarcimento de Custos de Originação (É pago pela Instituição Proponente)
      /// </summary>
      /// <param name="tipoContrato"></param>
      /// <param name="enteConsignante"></param>
      /// <param name="dataInicioContrato"></param>
      /// <param name="dataVencimentoContrato"></param>
      /// <param name="dataSaldoDevedor"></param>
      /// <param name="valorContrato"></param>
      /// <returns></returns>
      public decimal? CalculaValorRCO(string tipoContrato, string enteConsignante, DateTime dataInicioContrato, DateTime dataVencimentoContrato, DateTime dataReferencia, decimal? valorContrato)
      {
         var faixaVigente = BuscarFaixaRCOVigente(dataReferencia);

         if (faixaVigente == null)
            throw new Exception("Não Existe Faixa RCO Vigente para a Data Referência Informada");

         var valorReferencia = BuscarValorReferenciaRCO(faixaVigente, tipoContrato, enteConsignante, valorContrato);

         if (valorReferencia == null)
            throw new Exception("Não Existe Faixa RCO Vigente para a Data Referência/Valor Informado");


         return CalculoRCO(valorReferencia, dataInicioContrato, dataVencimentoContrato, dataReferencia);
      }

      private decimal? CalculoRCO(decimal? valorFixo, DateTime dataInicioContrato, DateTime dataVencimentoContrato, DateTime dataSaldoDevedor)
      {
         return (valorFixo * (decimal?)((dataVencimentoContrato - dataSaldoDevedor).TotalDays / (dataVencimentoContrato - dataInicioContrato).TotalDays));
      }

      private int? BuscarFaixaRCOVigente(DateTime dataBase)
      {
         return new CTCVigenciaFaixasRCOBusiness().Listar(WhereBuilder.Create().Add(CTCVigenciaFaixasRCO.METADADO.VigenciaInicial, Filter.LessOrEqual, dataBase, Link.And)
            .Add(Block.Begin)
               .Add(CTCVigenciaFaixasRCO.METADADO.VigenciaFinal, Filter.IsNull, null, Link.Or)
               .Add(CTCVigenciaFaixasRCO.METADADO.VigenciaFinal, Filter.LessOrEqual, dataBase, Link.Or)
               .Add(Block.End)).FirstOrDefault()?.Id;
      }

      private decimal? BuscarValorReferenciaRCO(int? vigencia, string tipoContrato, string enteConsignante, decimal? valor)
      {
         return new CTCFaixasRCOBusiness().Listar(WhereBuilder.Create().Add(CTCFaixasRCO.METADADO.Vigencia, Filter.Equal, vigencia, Link.And)
                                                                       .Add(CTCFaixasRCO.METADADO.TipoContrato, Filter.Equal, tipoContrato, Link.And)
                                                                       .Add(CTCFaixasRCO.METADADO.EnteConsignante, Filter.Equal, enteConsignante, Link.And)
                                                                       .Add(CTCFaixasRCO.METADADO.ValorInicial, Filter.LessOrEqual, valor, Link.And)
                                                                       .Add(CTCFaixasRCO.METADADO.ValorFinal, Filter.GreatherOrEqual, valor, Link.And)).FirstOrDefault()?.Valor;
      }
      #endregion

      #region "Contas de Pagamento"
      public List<CTCContas> ListarContasPagamento()
      {
         return new CTCContasBusiness().Listar(null);
      }

      public void InserirContaPagamento(CTCContas obj)
      {
         new CTCContasBusiness().Incluir(obj);
      }

      public void AlterarContaPagamento(CTCContas obj)
      {
         new CTCContasBusiness().Alterar(obj);
      }

      public CTCContas BuscarContaPagamento(int? id)
      {
         return new CTCContasBusiness().Obtem(id);
      }
      #endregion

      #region "Tabelas Auxiliares"
      public List<CTCTipoParte> ListarTipoParte()
      {
         return new CTCTipoParteBusiness().Listar(null);
      }

      public List<CTCTipoParteDestino> ListarTipoParteDestino()
      {
         return new CTCTipoParteDestinoBusiness().Listar(null);
      }

      public List<ComboValueBoleano> ListarSimNaoBoleano()
      {
         var retorno = new List<ComboValueBoleano>();
         retorno.Add(new ComboValueBoleano { Id = true, Descricao = "SIM" });
         retorno.Add(new ComboValueBoleano { Id = false, Descricao = "NÃO" });

         return retorno;
      }

      public List<ComboValueString> ListarTipoMovimentoRCO()
      {
         var retorno = new List<ComboValueString>();
         retorno.Add(new ComboValueString { Id = "P", Descricao = "A Pagar" });
         retorno.Add(new ComboValueString { Id = "R", Descricao = "A Receber" });

         return retorno;
      }

      public List<CTCFases> ListarFases()
      {
         return new CTCFasesBusiness().Listar(null);
      }
      #endregion

      #region "Tipo Contrato"
      public List<CTCTipoContratoProdutoRetencao> ListarTipoContratoProdutoRetencao()
      {
         return new CTCTipoContratoProdutoRetencaoBusiness().Listar(null);
      }

      public List<CTCTipoContrato> ListarTipoContrato()
      {
         return new CTCTipoContratoBusiness().Listar(null);
      }

      public CTCTipoContratoProdutoRetencao BuscarTipoContratoProdutoRetencao(int? id)
      {
         return new CTCTipoContratoProdutoRetencaoBusiness().Obtem(id);
      }

      public void AlterarTipoContratoProdutoRetencao(CTCTipoContratoProdutoRetencao obj)
      {
         new CTCTipoContratoProdutoRetencaoBusiness().Alterar(obj);
      }
      #endregion

      #region "Ente Consignante"
      public List<CTCEnteConsignante> ListarEntesConsignantes()
      {
         return new CTCEnteConsignanteBusiness().Listar(null);
      }
      #endregion

      //#region "Produtos Legado"
      //public List<ProdutosSicred> ListarProdutosLegado()
      //{
      //   return new ProdutosSicredBusiness().Listar(null);
      //}
      //#endregion

      //#region "Produtos Credit Manager"
      //public List<Produtos> ListarProdutos()
      //{
      //   return new ProdutosBusiness().Listar(null);
      //}
      //#endregion

      #region "Movimentação RCO"
      public void InserirMovimentoRCO(CTCRCO movimento)
      {
         new CTCRCOBusiness().Incluir(movimento);
      }

      public List<CTCRCO> ListarMovimentacaoRCO(string competencia)
      {
         return new CTCRCOBusiness().Listar(WhereBuilder.Create().Add(CTCRCO.METADADO.AnoMes, Filter.Equal, competencia));
      }

      public void ExcluirMovimentacaoRCO(string competencia)
      {
         new CTCRCOBusiness().ExcluirPor_Competencia(competencia);
      }

      #endregion

      #region "Geral"
      public bool DiaUtil(DateTime data)
      {
         var client = new RestClient(ConfiguracaoService.GetInstance().Config<string>("portalpaulista.sicred.services.url") + "DiaUtil/" + data.ToString("yyyy-MM-dd"));
         client.Timeout = -1;
         var request = new RestRequest(Method.GET);
         IRestResponse response = client.Execute(request);
         bool resp = JsonConvert.DeserializeObject<bool>(response.Content);

         return resp;
      }
      #endregion

      #region "Geração de Arquivos"

      #endregion

      #region "TEDs"
      public void AlterarTedRecebida(CTCTedsRecebidas obj)
      {
         new CTCTedsRecebidasBusiness().Alterar(obj);
      }
      public void InserirPagamento(CTCPagamentosRecebidos obj)
      {
         new CTCPagamentosRecebidosBusiness().Incluir(obj);
      }

      public CTCPagamentosRecebidos BuscarPagamento(string NU)
      {
         return new CTCPagamentosRecebidosBusiness().Listar(WhereBuilder.Create().Add(CTCPagamentosRecebidos.METADADO.NUPortabilidade, Filter.Equal, NU)).FirstOrDefault();
      }

      #endregion
   }

   [Serializable]
   public class ComboValueBoleano
   {
      public bool Id { get; set; }
      public string Descricao { get; set; }
   }

   [Serializable]
   public class ComboValueString
   {
      public string Id { get; set; }
      public string Descricao { get; set; }
   }
}
