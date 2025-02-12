using FastConsig.Common.Loggin;
using FastConsig.CTC.Entity;
using FastConsig.CTC.Model.Interfaces;
using FastConsig.CTC.Services;
using System;
using System.Linq;

namespace FastConsig.CTC.Helpers.ACTC104
{
   public class ACTC104Process : IACTCProcess
   {
      public void Execute(int? idArquivo)
      {
         //Busca o Arquivo
         var arquivoACTC104 = CTCService.GetInstance().BuscarArquivo(idArquivo);

         //Atualiza a Situação para Processando
         arquivoACTC104.SituacaoArquivo = 2;
         arquivoACTC104.Status = "PROCESSANDO";
         CTCService.GetInstance().AlterarArquivo(arquivoACTC104);

         //Deserializa o Arquivo
         FastConsig.CTC.Model.ACTC104.ACTC104 obj = (FastConsig.CTC.Model.ACTC104.ACTC104)new ACTC104Parser().Parse(new System.IO.StringReader(arquivoACTC104.Conteudo));

         foreach (var item in obj.SISARQ.Item.Grupo_ACTC104_Portldd)
         {
            CTCRequisicao requisicao = CTCService.GetInstance().BuscarRequisicao(item.NUPortlddCTC.Value);

            if (requisicao != null)
            {
               //arquivoACTC104.Identificador = requisicao.Id;
               CTCService.GetInstance().InserirVinculoArquivo(new CTCArquivoRequisicao() { Arquivo = idArquivo, Requisicao = requisicao.Id });

               //Se Cancelamento Grupo_ACTC104_PortlddCancel
               if (item.Item.GetType().FullName == "FastConsig.CTC.Model.ACTC104.Grupo_PortlddCancel_ComplexType")
               {
                  FastConsig.CTC.Model.ACTC104.Grupo_PortlddCancel_ComplexType itemResposta = (Model.ACTC104.Grupo_PortlddCancel_ComplexType)item.Item;
                  string motivoCancelamento = CTCService.GetInstance().ListarMotivoCancelamento().Where(x => x.Codigo == itemResposta.MtvCanceltPortldd).FirstOrDefault().Descricao;
                  requisicao.MotivoCancelamento = itemResposta.MtvCanceltPortldd;
                  requisicao.DataCancelamento = itemResposta.DtCanceltPortldd;
                  requisicao.UsuarioCancelamento = "System";
                  requisicao.Status = "CANCELADO";
                  CTCService.GetInstance().InserirOcorrencia(new CTCRequisicaoHistorico() { Ocorrencia = 9, DataOcorrencia = DateTime.Now, Requisicao = requisicao.Id, Usuario = "System", Complemento = "Cancelamento Recebido via ACTC104 Processado em " + DateTime.Now.ToString("dd/MM/yyy HH:mm:ss") + " - Motivo do Cancelamento: " + motivoCancelamento });

                  CTCService.GetInstance().AlterarRequesicao(requisicao);

                  //Cancelada por Decurso de Prazo no Pagamento da STR
                  //Tem que calcular a data de Cancelamento conforme a grade horária
                  if (itemResposta.MtvCanceltPortldd == "006" || itemResposta.MtvCanceltPortldd == "6" || itemResposta.MtvCanceltPortldd == "06")
                  {
                     try
                     {
                        /*Busca as Informações Necessárias para a Geração do Arquivo*/
                        CTC.Model.ACTC900.ACTC900 arquivoCTC900 = new Model.ACTC900.ACTC900();
                        CTCDominioArquivo dominio = CTCService.GetInstance().BuscarArquivosDominio("ACTC900");

                        CTC.Model.ACTC900.ACTC900 aCTC900 = new CTC.Model.ACTC900.ACTC900();

                        string nomeArquivo = CTCService.GetInstance().GeraNomeArquivo("ACTC900", CTCService.GetInstance().BuscarDataCancelamento().Date);

                        CTCArquivos arquivoCTC = new CTCArquivos()
                        {
                           DataReferencia = CTCService.GetInstance().BuscarDataCancelamento().Date,
                           DataEntrada = DateTime.Now,
                           DataHoraArquivo = (CTCService.GetInstance().BuscarDataCancelamento() > DateTime.Now.Date ? CTCService.GetInstance().BuscarDataCancelamento().AddHours(dominio.GradeHorariaInicial.Value.Hour) : DateTime.Now),
                           DominioArquivo = dominio.Id,
                           FluxoArquivo = "S",
                           ISPBEmissor = dominio.ISPBEmissor,
                           ISPBDestinatario = dominio.ISPBDestinatario,
                           NomeArquivo = nomeArquivo,
                           Status = "PROCESSANDO",
                           SituacaoArquivo = 2, /*Processamento*/
                           Identificador = requisicao.Id
                        };

                        CTCService.GetInstance().InserirArquivo(arquivoCTC);

                        CTCService.GetInstance().InserirVinculoArquivo(new CTCArquivoRequisicao() { Arquivo = arquivoCTC.Id, Requisicao = requisicao.Id });

                        arquivoCTC.NumeroControleEmissor = DateTime.Now.Date.ToString("yyyyMMdd") + arquivoCTC.Id.ToString().PadLeft(12, '0');

                        CTCService.GetInstance().AlterarArquivo(arquivoCTC);


                        Model.ACTC900.BCARQComplexType bcarq = new Model.ACTC900.BCARQComplexType();
                        Model.ACTC900.Grupo_SeqComplexType grupoBcArq = new Model.ACTC900.Grupo_SeqComplexType();
                        bcarq.DtHrArq = (CTCService.GetInstance().BuscarDataCancelamento() > DateTime.Now.Date ? CTCService.GetInstance().BuscarDataCancelamento().AddHours(dominio.GradeHorariaInicial.Value.Hour) : DateTime.Now);
                        bcarq.DtRef = CTCService.GetInstance().BuscarDataCancelamento().Date;
                        bcarq.ISPBEmissor = dominio.ISPBEmissor;
                        bcarq.ISPBDestinatario = dominio.ISPBDestinatario;
                        bcarq.NomArq = nomeArquivo;

                        bcarq.NumCtrlEmis = arquivoCTC.NumeroControleEmissor;
                        arquivoCTC900.BCARQ = bcarq;

                        Model.ACTC900.SISARQComplexType sisarq = new Model.ACTC900.SISARQComplexType();
                        Model.ACTC900.ACTC900ComplexType sisarqItem = new Model.ACTC900.ACTC900ComplexType();
                        Model.ACTC900.Grupo_ACTC900_CancelPortlddComplexType itemItem = new Model.ACTC900.Grupo_ACTC900_CancelPortlddComplexType();

                        itemItem.NUPortlddCTC = requisicao.NUPortabilidade;
                        itemItem.IdentdPartAdmdo = dominio.ISPBEmissor;
                        itemItem.MtvCanceltPortldd = "007";
                        //TODO: Verificar qual data deve ser enviada
                        itemItem.DtCanceltPortldd = CTCService.GetInstance().BuscarDataCancelamento().Date;

                        Model.ACTC900.Grupo_ACTC900_CancelPortlddComplexType[] itemACTC900 = new Model.ACTC900.Grupo_ACTC900_CancelPortlddComplexType[1];
                        itemACTC900[0] = itemItem;
                        sisarqItem.Grupo_ACTC900_CanceltPortldd = itemACTC900;

                        sisarq.Item = sisarqItem;
                        arquivoCTC900.SISARQ = sisarq;

                        Type typeBuilder = Type.GetType(dominio.Builder + ", FastConsig.CTC.Helpers");
                        Type typeValidator = Type.GetType(dominio.Validator + ", FastConsig.CTC.Helpers");
                        dynamic classeBuilder = Activator.CreateInstance(typeBuilder) as IACTCBuilder;
                        dynamic classeValidator = Activator.CreateInstance(typeValidator) as IACTCValidator;
                        var XML = classeBuilder.GetXML(arquivoCTC900);

                        CTCService.GetInstance().AlterarRequesicao(requisicao);

                        arquivoCTC.Conteudo = XML;
                        string erro = "";
                        bool validacao = classeValidator.Validate("ACTC900", XML, out erro);

                        if (validacao)
                        {
                           arquivoCTC.Status = "AGUARDANDO ENVIO";
                        }
                        else
                        {
                           arquivoCTC.Mensagem = erro;
                           arquivoCTC.Status = "COM ERRO";
                        }

                        CTCService.GetInstance().AlterarArquivo(arquivoCTC);

                     }
                     catch (Exception exx)
                     {
                        LogService.GetInstance().GravarLogErro(exx, "Falha ao Gerar o Arquivo de Cancelamento por Motivo de Falta de Pagamento da Portabilidade de NU: " + item.NUPortlddCTC);
                     }
                  }
               }
               else if (item.Item.GetType().FullName == "FastConsig.CTC.Model.ACTC104.Grupo_SitLiquidPortldd_ComplexType")
               {
                  try
                  {
                     //Situação da Liquidação Grupo_ACTC104_SitLiquidPortldd
                     //TODO: Verificar o Valor (se valor a menor ou maior cancelar por divergencia de valor ... se valor igual efetivar
                     FastConsig.CTC.Model.ACTC104.Grupo_SitLiquidPortldd_ComplexType itemResposta = (Model.ACTC104.Grupo_SitLiquidPortldd_ComplexType)item.Item;
                     CTCPagamentosRecebidos tedRecebida = CTCService.GetInstance().BuscarPagamento(item.NUPortlddCTC.Value);

                     if (tedRecebida != null)
                     {
                        requisicao.DataPagamento = itemResposta.DtSitLiquidPortldd;
                        requisicao.ValorPago = tedRecebida.ValorLancamento;
                        CTCService.GetInstance().AlterarRequesicao(requisicao);
                     }

                     LogService.GetInstance().GravarLogDebug("Portabilidade Liquidada: NU: " + item.NUPortlddCTC + " - STR0047: " + (tedRecebida == null ? "Não Localizada" : "Valor: " + tedRecebida.ValorLancamento.Value.ToString("N2")));
                  }
                  catch (Exception exx)
                  {
                     LogService.GetInstance().GravarLogErro(exx, "Falha ao Localizar/Gravar o Pagamento da Portabilidade de NU: " + item.NUPortlddCTC);
                  }

               }

               //Se Aprovada Grupo_ACTC104_PortlddAprovd

               //Se Retida Grupo_ACTC104_PortlddRetd


               //Efetivação da Portabilidade Grupo_ACTC104_EftcPortldd

               CTCService.GetInstance().AlterarRequesicao(requisicao);
            }


         }

         //Atualiza a Situação para Processado

         arquivoACTC104.Mensagem = "Processamento Concluído com Sucesso";
         arquivoACTC104.SituacaoArquivo = 2;
         arquivoACTC104.Status = "CONCLUIDO";
         CTCService.GetInstance().AlterarArquivo(arquivoACTC104);

      }
   }
}
