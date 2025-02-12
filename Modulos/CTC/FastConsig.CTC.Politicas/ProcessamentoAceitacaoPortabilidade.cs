using FastConsig.Common.Loggin;
using FastConsig.CTC.Entity;
using FastConsig.CTC.Model.ACTC103;
using FastConsig.CTC.Model.Interfaces;
using FastConsig.CTC.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FastConsig.CTC.Politicas
{
   public class ProcessamentoAceitacaoPortabilidade : IPoliticaCTCRequisicao
   {
      public void Execute(CTCRequisicao requisicao, int? fase, int? tipoFluxo, string tipoPessoaPolitica)
      {
         //TODO: Reescrever

         //   /*Busca as Informações Necessárias para a Geração do Arquivo*/
         //   List<ContratoResponseModel> contratos = (List<ContratoResponseModel>)SICREDServices.GetInstance().BuscarContratos("01", requisicao.CpfCnpjCliente, dataSimulacao: (DateTime)requisicao.DataReferenciaSaldoResposta);
         //   ContratoResponseModel contrato = contratos.Where(x => x.codigoContrato == requisicao.ContratoFormatado).FirstOrDefault();

         //   var detalheContrato = SICREDServices.GetInstance().BuscarDetalheContrato(contrato.empresa, contrato.agencia, contrato.codigoContrato);

         //   var conta = CTCService.GetInstance().ListarTipoContratoProdutoRetencao().Where(x => x.TipoContrato == requisicao.TipoContrato && x.EnteConsignante == requisicao.EnteConsignante.PadLeft(2, '0') && x.ProdutoOrigem == requisicao.ProdutoOrigem).FirstOrDefault().ContaPagamento;

         //   CTCContas contaPagamento = CTCService.GetInstance().BuscarContaPagamento(conta);

         //   CTC.Model.ACTC103.ACTC103 arquivo = new Model.ACTC103.ACTC103();
         //   CTCDominioArquivo dominio = CTCService.GetInstance().BuscarArquivosDominio("ACTC103");

         //   ACTC103 aCTC103 = new ACTC103();

         //   string nomeArquivo = CTCService.GetInstance().GeraNomeArquivo("ACTC103", requisicao.DataReferenciaSaldoResposta.Value.Date);

         //   CTCArquivos arquivoCTC = new CTCArquivos()
         //   {
         //      DataReferencia = requisicao.DataReferenciaSaldoResposta.Value.Date,
         //      DataEntrada = DateTime.Now,
         //      DataHoraArquivo = (requisicao.DataReferenciaSaldoResposta > DateTime.Now.Date ? requisicao.DataReferenciaSaldoResposta.Value.AddHours(dominio.GradeHorariaInicial.Value.Hour) : DateTime.Now),
         //      DominioArquivo = dominio.Id,
         //      FluxoArquivo = "S",
         //      ISPBEmissor = dominio.ISPBEmissor,
         //      ISPBDestinatario = dominio.ISPBDestinatario,
         //      NomeArquivo = nomeArquivo,
         //      Status = "PROCESSANDO",
         //      SituacaoArquivo = 2, /*Processamento*/
         //      Identificador = requisicao.Id
         //   };

         //   CTCService.GetInstance().InserirArquivo(arquivoCTC);

         //   CTCService.GetInstance().InserirVinculoArquivo(new CTCArquivoRequisicao() { Arquivo = arquivoCTC.Id, Requisicao = requisicao.Id });

         //   arquivoCTC.NumeroControleEmissor = DateTime.Now.Date.ToString("yyyyMMdd") + arquivoCTC.Id.ToString().PadLeft(12, '0');

         //   CTCService.GetInstance().AlterarArquivo(arquivoCTC);


         //   Model.ACTC103.BCARQComplexType bcarq = new Model.ACTC103.BCARQComplexType();
         //   Model.ACTC103.Grupo_SeqComplexType grupoBcArq = new Model.ACTC103.Grupo_SeqComplexType();
         //   bcarq.DtHrArq = (requisicao.DataReferenciaSaldoResposta > DateTime.Now.Date ? requisicao.DataReferenciaSaldoResposta.Value.AddHours(dominio.GradeHorariaInicial.Value.Hour) : DateTime.Now);
         //   bcarq.DtRef = requisicao.DataReferenciaSaldoResposta.Value.Date;
         //   bcarq.ISPBEmissor = dominio.ISPBEmissor;
         //   bcarq.ISPBDestinatario = dominio.ISPBDestinatario;
         //   bcarq.NomArq = nomeArquivo;

         //   bcarq.NumCtrlEmis = arquivoCTC.NumeroControleEmissor;
         //   arquivo.BCARQ = bcarq;

         //   SISARQComplexType sisarq = new SISARQComplexType();
         //   Model.ACTC103.ACTC103ComplexType sisarqItem = new Model.ACTC103.ACTC103ComplexType();
         //   Model.ACTC103.Grupo_ACTC103_PortlddComplexType itemItem = new Model.ACTC103.Grupo_ACTC103_PortlddComplexType();

         //   itemItem.NUPortlddCTC = requisicao.NUPortabilidade;
         //   itemItem.IdentdPartAdmdo = dominio.ISPBEmissor;
         //   itemItem.NumCtrlIF = arquivoCTC.NumeroControleEmissor;

         //   Grupo_ACTC103_PortlddAprovdComplexType aprovacao = new Grupo_ACTC103_PortlddAprovdComplexType();

         //   aprovacao.CanalOperacaoOrigem = "01";
         //   aprovacao.CNPJBase_IFOrContrto = dominio.ISPBEmissor.ToString();
         //   aprovacao.TpContrto = requisicao.TipoContrato;
         //   aprovacao.DtContrOp = (DateTime)contrato.emissao.Value.Date;
         //   aprovacao.CodMoeda = requisicao.Moeda;

         //   if (contrato.codigoProduto == "000001")
         //   {
         //      aprovacao.TpEnteCons = "01";
         //   }
         //   else if (contrato.codigoProduto == "000002")
         //   {
         //      aprovacao.TpEnteCons = "01";
         //   }
         //   else if (contrato.codigoProduto == "000003")
         //   {
         //      aprovacao.TpEnteCons = "01";
         //   }
         //   else if (contrato.codigoProduto == "000012")
         //   {
         //      aprovacao.TpEnteCons = "01";
         //   }
         //   else if (contrato.codigoProduto == "000013")
         //   {
         //      aprovacao.TpEnteCons = "01";
         //   }
         //   else if (contrato.codigoProduto == "000102")
         //   {
         //      aprovacao.TpEnteCons = "01";
         //   }
         //   else if (contrato.codigoProduto == "000103")
         //   {
         //      aprovacao.TpEnteCons = "01";
         //   }
         //   else if (contrato.codigoProduto == "000112")
         //   {
         //      aprovacao.TpEnteCons = "01";
         //   }
         //   else if (contrato.codigoProduto == "000113")
         //   {
         //      aprovacao.TpEnteCons = "01";
         //   }
         //   else if (contrato.codigoProduto == "100000")
         //   {
         //      aprovacao.TpEnteCons = "03";
         //   }
         //   else if (contrato.codigoProduto == "100001")
         //   {
         //      aprovacao.TpEnteCons = "03";
         //   }
         //   else if (contrato.codigoProduto == "100002")
         //   {
         //      aprovacao.TpEnteCons = "03";
         //   }
         //   else if (contrato.codigoProduto == "100011")
         //   {
         //      aprovacao.TpEnteCons = "03";
         //   }
         //   else if (contrato.codigoProduto == "100012")
         //   {
         //      aprovacao.TpEnteCons = "03";
         //   }
         //   else if (contrato.codigoProduto == "100101")
         //   {
         //      aprovacao.TpEnteCons = "03";
         //   }
         //   else if (contrato.codigoProduto == "100102")
         //   {
         //      aprovacao.TpEnteCons = "03";
         //   }
         //   else if (contrato.codigoProduto == "100111")
         //   {
         //      aprovacao.TpEnteCons = "03";
         //   }
         //   else if (contrato.codigoProduto == "100112")
         //   {
         //      aprovacao.TpEnteCons = "03";
         //   }
         //   else
         //   {
         //      aprovacao.TpEnteCons = requisicao.EnteConsignante;
         //   }

         //   decimal valorRCO = (decimal)CTCService.GetInstance().CalculaValorRCO(requisicao.TipoContrato, aprovacao.TpEnteCons, (DateTime)contrato.emissao, (DateTime)contrato.vencimento, (DateTime)requisicao.DataReferenciaSaldoResposta, contrato.valorContratado);

         //   requisicao.EnteConsignante = aprovacao.TpEnteCons;
         //   requisicao.ValorRCOCalculado = valorRCO;
         //   aprovacao.DtRefSaldDevdrContb = (DateTime)requisicao.DataReferenciaSaldoResposta;
         //   aprovacao.VlrSaldDevdrContb = (decimal)contrato.saldoDevedor;
         //   aprovacao.TxCET = (decimal)contrato.cetAno;
         //   aprovacao.TxJurosEft = (decimal)contrato.taxaAnual;
         //   aprovacao.IndRemun = "99";
         //   aprovacao.RegmAmtzc = "01";
         //   aprovacao.QtdTotParclContrto = contrato.prazo.ToString();
         //   aprovacao.Grupo_ACTC103_ParclNorml = new Grupo_ACTC103_ParclNormlComplexType();
         //   aprovacao.Grupo_ACTC103_ParclNorml.VlrFaceParclContrto = new Valor_CodErro() { Value = (decimal)contrato.Parcelas.FirstOrDefault().valorParcela };
         //   aprovacao.QtdTotParclContrtoVencd = (contrato.Parcelas.Where(x => (x.situacao == "A" || x.situacao == "R") && x.diasAtraso > 0).Count()).ToString();
         //   aprovacao.QtdTotParclContrtoVencr = (contrato.Parcelas.Where(x => (x.situacao == "A" || x.situacao == "R") && x.diasAtraso <= 0).Count()).ToString();
         //   aprovacao.Grupo_ACTC103_ParclNorml.DtPrimParclContrtoVencr = new Data_CodErro() { Value = (DateTime)contrato.Parcelas.Where(x => x.situacao == "A" || x.situacao == "R").OrderBy(x => x.vencimento).FirstOrDefault().vencimento };
         //   aprovacao.Grupo_ACTC103_ParclNorml.DtVencUltParclContrto = new Data_CodErro() { Value = (DateTime)contrato.Parcelas.Where(x => x.situacao == "A" || x.situacao == "R").OrderByDescending(x => x.vencimento).FirstOrDefault().vencimento };
         //   aprovacao.IOFRecContrtoOrig = (decimal)((contrato.iofPrazo == null ? 0 : contrato.iofPrazo) + (contrato.iofAdicional == null ? 0 : contrato.iofAdicional));
         //   aprovacao.CNPJIFOrigdr = ConfiguracaoService.GetInstance().Config<string>("CTC.CNPJ.Instituicao");
         //   aprovacao.Ind_MultIPOC = Indr.N;
         //   aprovacao.IPOC = detalheContrato.FirstOrDefault().IPOC.Trim();
         //   aprovacao.CodContrtoSCR = detalheContrato.FirstOrDefault().IPOC.Trim();
         //   aprovacao.CodContrtoOr = requisicao.Contrato;
         //   aprovacao.ISPBBcoIFOrigdr = contaPagamento.ISPB;
         //   aprovacao.CodBcoIFOrigdr = contaPagamento.Banco;
         //   aprovacao.AgBancIFOrigdr = contaPagamento.Agencia;
         //   aprovacao.CtBancIFOrigdr = contaPagamento.Conta;
         //   aprovacao.CNPJCanalOrigem = SICREDServices.GetInstance().ListarLojas().Where(x => x.LOJISTA == detalheContrato.FirstOrDefault().LOJISTA && x.LOJA == detalheContrato.FirstOrDefault().LOJA).FirstOrDefault().CgcCpf.Trim();

         //   DateTime dataLiberacao = (DateTime)detalheContrato.FirstOrDefault().DATALIBERACAO;

         //   while (true)
         //   {
         //      if (!CTCService.GetInstance().DiaUtil(dataLiberacao))
         //      {
         //         dataLiberacao = dataLiberacao.AddDays(1);
         //      }
         //      else
         //      {
         //         break;
         //      }
         //   }

         //   aprovacao.DtLibNovoRec = dataLiberacao;
         //   aprovacao.IOFAlqContrtoOrigBas = (decimal)detalheContrato.FirstOrDefault().ALIQIOF;
         //   aprovacao.IOFAlqContrtoOrigAdc = (detalheContrato.FirstOrDefault().ALIQIOFADICIONAL == null ? 0 : (decimal)detalheContrato.FirstOrDefault().ALIQIOFADICIONAL);

         //   int i = 1;

         //   aprovacao.Grupo_ACTC103_SubIOFComp = new Grupo_ACTC103_SubIOFComplexType();


         //   foreach (var parcela in contrato.Parcelas.Where(x => x.situacao == "A" || x.situacao == "R").OrderBy(x => x.vencimento).ToList())
         //   {
         //      if (i == 1)
         //      {
         //         aprovacao.Grupo_ACTC103_SubIOFComp.DtVlrParclContrto1 = new Data_CodErro() { Value = (DateTime)parcela.vencimento };
         //         aprovacao.Grupo_ACTC103_SubIOFComp.SaldVlrParclContrto1 = new Valor_CodErro() { Value = (decimal)parcela.principalEmAberto };
         //      }

         //      if (i == 2)
         //      {
         //         aprovacao.Grupo_ACTC103_SubIOFComp.DtVlrParclContrto2 = new Data_CodErro() { Value = (DateTime)parcela.vencimento };
         //         aprovacao.Grupo_ACTC103_SubIOFComp.SaldVlrParclContrto2 = new Valor_CodErro() { Value = (decimal)parcela.principalEmAberto };
         //      }

         //      if (i == 3)
         //      {
         //         aprovacao.Grupo_ACTC103_SubIOFComp.DtVlrParclContrto3 = new Data_CodErro() { Value = (DateTime)parcela.vencimento };
         //         aprovacao.Grupo_ACTC103_SubIOFComp.SaldVlrParclContrto3 = new Valor_CodErro() { Value = (decimal)parcela.principalEmAberto };
         //      }

         //      if (i == 4)
         //      {
         //         aprovacao.Grupo_ACTC103_SubIOFComp.DtVlrParclContrto4 = new Data_CodErro() { Value = (DateTime)parcela.vencimento };
         //         aprovacao.Grupo_ACTC103_SubIOFComp.SaldVlrParclContrto4 = new Valor_CodErro() { Value = (decimal)parcela.principalEmAberto };
         //      }

         //      if (i == 5)
         //      {
         //         aprovacao.Grupo_ACTC103_SubIOFComp.DtVlrParclContrto5 = new Data_CodErro() { Value = (DateTime)parcela.vencimento };
         //         aprovacao.Grupo_ACTC103_SubIOFComp.SaldVlrParclContrto5 = new Valor_CodErro() { Value = (decimal)parcela.principalEmAberto };
         //      }

         //      if (i == 6)
         //      {
         //         aprovacao.Grupo_ACTC103_SubIOFComp.DtVlrParclContrto6 = new Data_CodErro() { Value = (DateTime)parcela.vencimento };
         //         aprovacao.Grupo_ACTC103_SubIOFComp.SaldVlrParclContrto6 = new Valor_CodErro() { Value = (decimal)parcela.principalEmAberto };
         //      }

         //      if (i == 7)
         //      {
         //         aprovacao.Grupo_ACTC103_SubIOFComp.DtVlrParclContrto7 = new Data_CodErro() { Value = (DateTime)parcela.vencimento };
         //         aprovacao.Grupo_ACTC103_SubIOFComp.SaldVlrParclContrto7 = new Valor_CodErro() { Value = (decimal)parcela.principalEmAberto };
         //      }

         //      if (i == 8)
         //      {
         //         aprovacao.Grupo_ACTC103_SubIOFComp.DtVlrParclContrto8 = new Data_CodErro() { Value = (DateTime)parcela.vencimento };
         //         aprovacao.Grupo_ACTC103_SubIOFComp.SaldVlrParclContrto8 = new Valor_CodErro() { Value = (decimal)parcela.principalEmAberto };
         //      }

         //      if (i == 9)
         //      {
         //         aprovacao.Grupo_ACTC103_SubIOFComp.DtVlrParclContrto9 = new Data_CodErro() { Value = (DateTime)parcela.vencimento };
         //         aprovacao.Grupo_ACTC103_SubIOFComp.SaldVlrParclContrto9 = new Valor_CodErro() { Value = (decimal)parcela.principalEmAberto };
         //      }

         //      if (i == 10)
         //      {
         //         aprovacao.Grupo_ACTC103_SubIOFComp.DtVlrParclContrto10 = new Data_CodErro() { Value = (DateTime)parcela.vencimento };
         //         aprovacao.Grupo_ACTC103_SubIOFComp.SaldVlrParclContrto10 = new Valor_CodErro() { Value = (decimal)parcela.principalEmAberto };
         //      }

         //      if (i == 11)
         //      {
         //         aprovacao.Grupo_ACTC103_SubIOFComp.DtVlrParclContrto11 = new Data_CodErro() { Value = (DateTime)parcela.vencimento };
         //         aprovacao.Grupo_ACTC103_SubIOFComp.SaldVlrParclContrto11 = new Valor_CodErro() { Value = (decimal)parcela.principalEmAberto };
         //      }

         //      if (i == 12)
         //      {
         //         aprovacao.Grupo_ACTC103_SubIOFComp.DtVlrParclContrto12 = new Data_CodErro() { Value = (DateTime)parcela.vencimento };
         //         aprovacao.Grupo_ACTC103_SubIOFComp.SaldVlrParclContrto12 = new Valor_CodErro() { Value = (decimal)parcela.principalEmAberto };
         //      }

         //      if (i == 13)
         //      {
         //         aprovacao.Grupo_ACTC103_SubIOFComp.DtVlrParclContrto13 = new Data_CodErro() { Value = (DateTime)parcela.vencimento };
         //         aprovacao.Grupo_ACTC103_SubIOFComp.SaldVlrParclContrto13 = new Valor_CodErro() { Value = (decimal)parcela.principalEmAberto };
         //      }

         //      i++;
         //      if (i > 13)
         //      {
         //         break;
         //      }
         //   }

         //   itemItem.Item = aprovacao;
         //   Model.ACTC103.Grupo_ACTC103_PortlddComplexType[] item = new Model.ACTC103.Grupo_ACTC103_PortlddComplexType[1];
         //   item[0] = itemItem;
         //   sisarqItem.Grupo_ACTC103_Portldd = item;

         //   sisarq.Item = sisarqItem;
         //   arquivo.SISARQ = sisarq;

         //   Type typeBuilder = Type.GetType(dominio.Builder + ", BancoPaulista.CTC.Helpers");
         //   Type typeValidator = Type.GetType(dominio.Validator + ", BancoPaulista.CTC.Helpers");
         //   dynamic classeBuilder = Activator.CreateInstance(typeBuilder) as IACTCBuilder;
         //   dynamic classeValidator = Activator.CreateInstance(typeValidator) as IACTCValidator;
         //   var XML = classeBuilder.GetXML(arquivo);

         //   requisicao.SaldoAceiteInformado = (decimal)contrato.saldoDevedor;

         //   CTCService.GetInstance().AlterarRequesicao(requisicao);

         //   CTCService.GetInstance().InserirOcorrencia(new CTCRequisicaoHistorico() { DataOcorrencia = DateTime.Now, Ocorrencia = 6, Requisicao = requisicao.Id, Usuario = requisicao.UsuarioAceite, Complemento = "Portabilidade Aceita - Data Referência: " + requisicao.DataReferenciaSaldoResposta.Value.ToString("dd/MM/yyyy") + " - Saldo Devedor: " + requisicao.SaldoAceiteInformado.Value.ToString("N2") });

         //   arquivoCTC.Conteudo = XML;
         //   string erro = "";
         //   bool validacao = classeValidator.Validate("ACTC103", XML, out erro);

         //   if (validacao)
         //   {
         //      arquivoCTC.Status = "AGUARDANDO ENVIO";
         //   }
         //   else
         //   {
         //      arquivoCTC.Mensagem = erro;
         //      arquivoCTC.Status = "COM ERRO";
         //   }
         //   CTCService.GetInstance().AlterarArquivo(arquivoCTC);

         //   if (!validacao)
         //   {
         //      LogService.GetInstance().GravarLogDebug("Falha na Validação do Arquivo de Envio a Nuclea Requisição: " + requisicao.Id + " - Mensagem: " + erro);
         //      throw new Exception("Falha na Validação do Arquivo de Envio a Nuclea " + erro);
         //   }
      }
   }
}
