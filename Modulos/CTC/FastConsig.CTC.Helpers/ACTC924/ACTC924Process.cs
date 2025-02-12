using FastConsig.CTC.Business;
using FastConsig.CTC.Entity;
using FastConsig.CTC.Model.Interfaces;
using FastConsig.CTC.Services;
using System.Linq;

namespace FastConsig.CTC.Helpers.ACTC924
{
   public class ACTC924Process : IACTCProcess
   {
      public void Execute(int? idArquivo)
      {
         var arquivo = CTCService.GetInstance().BuscarArquivo(idArquivo);

         //Atualiza a Situação para Processando
         arquivo.SituacaoArquivo = 2;
         arquivo.Status = "PROCESSANDO";
         CTCService.GetInstance().AlterarArquivo(arquivo);

         FastConsig.CTC.Model.ACTC924.ACTC924 obj = (FastConsig.CTC.Model.ACTC924.ACTC924)new ACTC924Parser().Parse(new System.IO.StringReader(arquivo.Conteudo));

         CTC924 ctc = new CTC924();

         ctc.DataReferencia = obj.BCARQ.DtRef;
         ctc.Arquivo = idArquivo;

         new CTC924Business().Incluir(ctc);

         foreach (var d in obj.SISARQ.Item.Grupo_ACTC924_DadRelatPosAnl)
         {
            var detalheCtc = new CTC924Detalhes();
            detalheCtc.CTC924 = ctc.Id;

            detalheCtc.CEPEnderecoCliente = d.Grupo_ACTC924_Cli.FirstOrDefault().CEPEndCli;
            detalheCtc.CidadeEnderecoCliente = d.Grupo_ACTC924_Cli.FirstOrDefault().CidEndCli;
            detalheCtc.CpfCnpjCliente = d.Grupo_ACTC924_Cli.FirstOrDefault().CNPJ_CPFCli;
            detalheCtc.NomeCliente = d.Grupo_ACTC924_Cli.FirstOrDefault().NomCli;
            detalheCtc.TelefoneCliente = d.Grupo_ACTC924_Cli.FirstOrDefault().TelCli;
            detalheCtc.EmailCliente = d.Grupo_ACTC924_Cli.FirstOrDefault().EmailCli;
            detalheCtc.LogradouroEnderecoCliente = d.Grupo_ACTC924_Cli.FirstOrDefault().LogradEndCli;
            detalheCtc.NumeroEnderecoCliente = d.Grupo_ACTC924_Cli.FirstOrDefault().NumEndCli;
            detalheCtc.UFEnderecoCliente = d.Grupo_ACTC924_Cli.FirstOrDefault().UFEndCli;
            detalheCtc.TipoCliente = d.Grupo_ACTC924_Cli.FirstOrDefault().TpCli.ToString();

            detalheCtc.CNPJBaseIFOriginal = d.CNPJBase_IFOrContrto;
            detalheCtc.CNPJCorrespondenteBancario = d.CNPJCorrespBanc;
            detalheCtc.Contrato = d.CodContrtoOr;
            detalheCtc.TipoContrato = d.TpContrto;
            detalheCtc.DataSolicitacao = d.DtSolictcPortldd;
            detalheCtc.NUPortabilidade = d.NUPortlddCTC;
            detalheCtc.SituacaoPortabilidadeCTC = d.SitPortlddCTC;
            detalheCtc.ISPBProponente = d.ISPBPropnt;
            detalheCtc.EnteConsignante = d.TpEnteCons;

            if (d.Grupo_ACTC924_PortlddAprovd != null)
            {
               detalheCtc.DataReferenciaSaldoDevedorProponente = d.Grupo_ACTC924_PortlddAprovd.FirstOrDefault().DtRefSaldDevdrContbPropnt.FirstOrDefault().Date;
               detalheCtc.ValorSaldoDevedorProponente = d.Grupo_ACTC924_PortlddAprovd.FirstOrDefault().VlrSaldDevdrContbPropnt.FirstOrDefault();
               detalheCtc.DataReferenciaSaldoDevedorOriginal = d.Grupo_ACTC924_PortlddAprovd.FirstOrDefault().DtRefSaldDevdrContbOrContrto.FirstOrDefault().Date;
               detalheCtc.ValorSaldoDevedorOriginal = d.Grupo_ACTC924_PortlddAprovd.FirstOrDefault().VlrSaldDevdrContbOrContrto.FirstOrDefault();
            }

            if (d.Grupo_ACTC924_DcrsoPrz != null)
            {
               detalheCtc.DataDecursoPrazo = d.Grupo_ACTC924_DcrsoPrz.FirstOrDefault().DtDcrsoPrzPortldd;
               detalheCtc.MotivoDecursoPrazo = d.Grupo_ACTC924_DcrsoPrz.FirstOrDefault().MtvDcrsoPrzPortldd;
            }

            if (d.Grupo_ACTC924_Cancelt != null)
            {
               detalheCtc.DataCancelamento = d.Grupo_ACTC924_Cancelt.FirstOrDefault().DtCanceltPortldd;
               detalheCtc.MotivoCancelamento = d.Grupo_ACTC924_Cancelt.FirstOrDefault().MtvCanceltPortldd;
               detalheCtc.ISPBSolicitanteCancelamento = d.Grupo_ACTC924_Cancelt.FirstOrDefault().ISPBSolicttCancel;
            }

            if (d.Grupo_ACTC924_DevLiquid != null)
            {
               detalheCtc.DataDevolucaoLiquidacao = d.Grupo_ACTC924_DevLiquid.FirstOrDefault().DtDevLiquidPortldd;
               detalheCtc.SituacaoDevolucaoLiquidacao = d.Grupo_ACTC924_DevLiquid.FirstOrDefault().SitDevLiquidPortldd;
               detalheCtc.MotivoDevolucaoLiquidacao = d.Grupo_ACTC924_DevLiquid.FirstOrDefault().MtvDevLiquidPortldd;
               detalheCtc.ValorDevolucaoLiquidacao = d.Grupo_ACTC924_DevLiquid.FirstOrDefault().VlrDevLiquidPortldd;
            }

            if (d.Grupo_ACTC924_Liquid != null)
            {
               detalheCtc.DataLiquidacao = d.Grupo_ACTC924_Liquid.FirstOrDefault().DtLiquidPortldd;
               detalheCtc.SituacaoLiquidacao = d.Grupo_ACTC924_Liquid.FirstOrDefault().SitLiquidPortldd;
               detalheCtc.ValorLiquidacaoPortabilidade = d.Grupo_ACTC924_Liquid.FirstOrDefault().VlrLiquidPortldd;
            }

            if (d.Grupo_ACTC924_EftcPortldd != null)
            {
               detalheCtc.DataEfetivacaoPortabilidade = d.Grupo_ACTC924_EftcPortldd.FirstOrDefault().DtEftcPortldd;
               detalheCtc.SituacaoEfetivacaoPortabilidade = d.Grupo_ACTC924_EftcPortldd.FirstOrDefault().SitEftcPortldd;
               detalheCtc.ValorRCO = d.Grupo_ACTC924_EftcPortldd.FirstOrDefault().VlrRCO;
            }

            new CTC924DetalhesBusiness().Incluir(detalheCtc);

            arquivo.Mensagem = "Processamento Concluído com Sucesso";
            arquivo.SituacaoArquivo = 2;
            arquivo.Status = "CONCLUIDO";
            CTCService.GetInstance().AlterarArquivo(arquivo);
         }
      }
   }
}
