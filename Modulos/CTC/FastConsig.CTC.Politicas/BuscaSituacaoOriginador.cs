using FastConsig.Common.Loggin;
using FastConsig.CTC.Entity;
using FastConsig.CTC.Model.Interfaces;
using FastConsig.CTC.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.CTC.Politicas
{
   public class BuscaSituacaoOriginador : IPoliticaCTCRequisicao
   {
      public void Execute(CTCRequisicao requisicao, int? fase, int? tipoFluxo, string tipoPessoaPolitica)
      {
         //TODO: Avaliar
         //   List<ContratoResponseModel> contratos = (List<ContratoResponseModel>)SICREDServices.GetInstance().BuscarContratos("01", requisicao.CpfCnpjCliente, dataSimulacao: (DateTime)requisicao.DataReferenciaSaldo);

         //   if (contratos.Count == 0)
         //   {
         //      CTCService.GetInstance().InserirOcorrencia(new CTCRequisicaoHistorico() { Requisicao = requisicao.Id, DataOcorrencia = DateTime.Now, Usuario = "System", Ocorrencia = 2, Complemento = "Não foram localizados contratos para o CPF/CNPJ: " + requisicao.CpfCnpjCliente });
         //      requisicao.MotivoRetencao = "9"; //CPF Não é do Contrato
         //      requisicao.ObservacaoRetencao = "Retenção Automática";
         //      requisicao.Status = "PROCESSANDO";
         //      CTCService.GetInstance().ReterPortabilidade(requisicao, "System");
         //      requisicao.Status = "AGUARDANDO ENVIO";
         //      CTCService.GetInstance().AlterarRequesicao(requisicao);
         //      return;
         //   }
         //   else
         //   {
         //      ContratoResponseModel contrato = contratos.Where(x => x.codigoContrato == requisicao.ContratoFormatado).FirstOrDefault();

         //      if (contrato == null)
         //      {
         //         CTCService.GetInstance().InserirOcorrencia(new CTCRequisicaoHistorico() { Requisicao = requisicao.Id, DataOcorrencia = DateTime.Now, Usuario = "System", Ocorrencia = 3, Complemento = "Não foi localizado o Contrato: " + requisicao.ContratoFormatado + " para o CPF/CNPJ: " + requisicao.CpfCnpjCliente });

         //         //requisicao.MotivoRetencao = "2"; //Contrato não Encontrato ou não é da Modalidade Especificada
         //         //requisicao.ObservacaoRetencao = "Retenção Automática";
         //         //requisicao.Status = "PROCESSANDO";
         //         //CTCService.GetInstance().ReterPortabilidade(requisicao, "System");
         //         //requisicao.Status = "AGUARDANDO ENVIO";
         //         //CTCService.GetInstance().AlterarRequesicao(requisicao);
         //         return;
         //      }
         //      else
         //      {
         //         var detalhe = SICREDServices.GetInstance().BuscarDetalheContrato(contrato.empresa, contrato.agencia, contrato.codigoContrato).FirstOrDefault();


         //         //if (detalhe.TITULARIDADE == "T")
         //         //{
         //         //   CTCService.GetInstance().InserirOcorrencia(new CTCRequisicaoHistorico() { Requisicao = requisicao.Id, DataOcorrencia = DateTime.Now, Usuario = "System", Ocorrencia = 10, Complemento = "Contrato não é de Titularidade Própria" });
         //         //   requisicao.MotivoRetencao = "18"; //IF Credora Original Incorreta
         //         //   requisicao.ObservacaoRetencao = "Retenção Automática";
         //         //   requisicao.Status = "PROCESSANDO";
         //         //   CTCService.GetInstance().ReterPortabilidade(requisicao, "System");
         //         //   requisicao.Status = "AGUARDANDO ENVIO";
         //         //   CTCService.GetInstance().AlterarRequesicao(requisicao);
         //         //   return;
         //         //}

         //         if (detalhe.SITUACAO == "L")
         //         {
         //            CTCService.GetInstance().InserirOcorrencia(new CTCRequisicaoHistorico() { Requisicao = requisicao.Id, DataOcorrencia = DateTime.Now, Usuario = "System", Ocorrencia = 11, Complemento = "Contrato Liquidado" });
         //            requisicao.MotivoRetencao = "16"; //Contrato já Liquidado
         //            requisicao.ObservacaoRetencao = "Retenção Automática";
         //            requisicao.Status = "PROCESSANDO";
         //            CTCService.GetInstance().ReterPortabilidade(requisicao, "System");
         //            requisicao.Status = "AGUARDANDO ENVIO";
         //            CTCService.GetInstance().AlterarRequesicao(requisicao);
         //            return;
         //         }

         //         CTCRequisicaoSimulacao simulacao = new CTCRequisicaoSimulacao()
         //         {
         //            CET = contrato.cetAno,
         //            DataReferencia = contrato.dataSaldoDevedor,
         //            Parcelas = contrato.Parcelas.Where(x => x.situacao == "A" || x.situacao == "R").Count(),
         //            PrimeiroVencimento = contrato.Parcelas.Where(x => x.situacao == "A" || x.situacao == "R").OrderBy(x => x.vencimento).FirstOrDefault()?.vencimento,
         //            Requisicao = requisicao.Id,
         //            SaldoDevedor = contrato.saldoDevedor,
         //            Simulacao = 0,
         //            Tabela = "0000",
         //            Taxa = contrato.taxaAnual,
         //            Tipo = 1, /*No Originador*/
         //            UltimoVencimento = contrato.Parcelas.Where(x => x.situacao == "A" || x.situacao == "R").OrderByDescending(x => x.vencimento).FirstOrDefault()?.vencimento,
         //            ValorParcela = contrato.Parcelas.Where(x => x.situacao == "A" || x.situacao == "R").FirstOrDefault()?.valorParcela
         //         };

         //         CTCService.GetInstance().InserirRequesicaoSimulacao(simulacao);

         //         CTCService.GetInstance().InserirOcorrencia(new CTCRequisicaoHistorico() { Requisicao = requisicao.Id, DataOcorrencia = DateTime.Now, Usuario = "System", Ocorrencia = 4, Complemento = "Calculada a Posição no Originador com a data: " + requisicao.DataReferenciaSaldo.Value.ToString("dd/MM/yyyy") });

         //         //Complementa as Informações do Beneficio na Requisição

         //         try
         //         {
         //            if (contrato.codigoProduto == "000001")
         //            {
         //               requisicao.EnteConsignante = "01";
         //            }
         //            else if (contrato.codigoProduto == "000002")
         //            {
         //               requisicao.EnteConsignante = "01";
         //            }
         //            else if (contrato.codigoProduto == "000003")
         //            {
         //               requisicao.EnteConsignante = "01";
         //            }
         //            else if (contrato.codigoProduto == "000012")
         //            {
         //               requisicao.EnteConsignante = "01";
         //            }
         //            else if (contrato.codigoProduto == "000013")
         //            {
         //               requisicao.EnteConsignante = "01";
         //            }
         //            else if (contrato.codigoProduto == "000102")
         //            {
         //               requisicao.EnteConsignante = "01";
         //            }
         //            else if (contrato.codigoProduto == "000103")
         //            {
         //               requisicao.EnteConsignante = "01";
         //            }
         //            else if (contrato.codigoProduto == "000112")
         //            {
         //               requisicao.EnteConsignante = "01";
         //            }
         //            else if (contrato.codigoProduto == "000113")
         //            {
         //               requisicao.EnteConsignante = "01";
         //            }
         //            else if (contrato.codigoProduto == "100000")
         //            {
         //               requisicao.EnteConsignante = "03";
         //            }
         //            else if (contrato.codigoProduto == "100001")
         //            {
         //               requisicao.EnteConsignante = "03";
         //            }
         //            else if (contrato.codigoProduto == "100002")
         //            {
         //               requisicao.EnteConsignante = "03";
         //            }
         //            else if (contrato.codigoProduto == "100011")
         //            {
         //               requisicao.EnteConsignante = "03";
         //            }
         //            else if (contrato.codigoProduto == "100012")
         //            {
         //               requisicao.EnteConsignante = "03";
         //            }
         //            else if (contrato.codigoProduto == "100101")
         //            {
         //               requisicao.EnteConsignante = "03";
         //            }
         //            else if (contrato.codigoProduto == "100102")
         //            {
         //               requisicao.EnteConsignante = "03";
         //            }
         //            else if (contrato.codigoProduto == "100111")
         //            {
         //               requisicao.EnteConsignante = "03";
         //            }
         //            else if (contrato.codigoProduto == "100112")
         //            {
         //               requisicao.EnteConsignante = "03";
         //            }

         //            decimal valorRCO = 0;

         //            try
         //            {
         //               valorRCO = (decimal)CTCService.GetInstance().CalculaValorRCO(requisicao.TipoContrato, requisicao.EnteConsignante, (DateTime)contrato.emissao, (DateTime)contrato.vencimento, (DateTime)requisicao.DataReferenciaSaldo, contrato.valorContratado);
         //            }
         //            catch (Exception ex)
         //            {
         //               LogService.GetInstance().GravarLogDebug("Erro no Processamento da Politica de Busca da Situação no Originador - Falha no Calculo do RCO - Message: " + ex.Message + " - Stacktrace: " + ex.StackTrace);
         //               LogService.GetInstance().GravarLogDebug("Parametro Tipo Contrato: " + requisicao.TipoContrato);
         //               LogService.GetInstance().GravarLogDebug("Parametro Ente Consignante: " + requisicao.EnteConsignante);
         //               LogService.GetInstance().GravarLogDebug("Parametro Emissão: " + contrato.emissao);
         //               LogService.GetInstance().GravarLogDebug("Parametro Vencimento: " + contrato.vencimento);
         //               LogService.GetInstance().GravarLogDebug("Parametro Data Referencia: " + requisicao.DataReferenciaSaldoResposta);
         //               LogService.GetInstance().GravarLogDebug("Parametro Valor Contratado: " + contrato.valorContratado);
         //            }

         //            requisicao.ValorRCOCalculado = valorRCO;
         //            requisicao.DataNascimento = SICREDServices.GetInstance().ObterCliente(requisicao.CpfCnpjCliente).DataNascimento;
         //            requisicao.ProdutoOrigem = contrato.codigoProduto;
         //            requisicao.NumeroBeneficio = contrato.matricula;
         //            requisicao.UFBeneficio = contrato.ufBeneficio;
         //            requisicao.EspecieBeneficio = (contrato.tipoBeneficio == null ? 0 : int.Parse(contrato.tipoBeneficio));
         //         }
         //         catch (Exception exx)
         //         {
         //            LogService.GetInstance().GravarLogDebug("Erro no Processamento da Politica de Busca da Situação no Originador - Message: " + exx.Message + " - Stacktrace: " + exx.StackTrace);
         //         }
         //         CTCService.GetInstance().AlterarRequesicao(requisicao);
         //      }
         //   }
      }
   }
}
