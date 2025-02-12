using FastConsig.CTC.Business;
using FastConsig.CTC.Entity;
using FastConsig.CTC.Model.Interfaces;
using FastConsig.CTC.Services;
using System.Linq;

namespace FastConsig.CTC.Helpers.ACTC921
{
   public class ACTC921Process : IACTCProcess
   {
      public void Execute(int? idArquivo)
      {
         //Busca o Arquivo
         var arquivo = CTCService.GetInstance().BuscarArquivo(idArquivo);

         //Atualiza a Situação para Processando
         arquivo.SituacaoArquivo = 2;
         arquivo.Status = "PROCESSANDO";
         CTCService.GetInstance().AlterarArquivo(arquivo);

         FastConsig.CTC.Model.ACTC921.ACTC921 obj = (FastConsig.CTC.Model.ACTC921.ACTC921)new ACTC921Parser().Parse(new System.IO.StringReader(arquivo.Conteudo));

         CTC921 ctc = new CTC921();

         ctc.DataReferenciaArquivo = obj.BCARQ.DtRef;
         ctc.Arquivo = idArquivo;
         ctc.DataInicio = obj.SISARQ.Item.Grupo_ACTC921_RelatConclcTar.DtIniApurc;
         ctc.DataFim = obj.SISARQ.Item.Grupo_ACTC921_RelatConclcTar.DtFimApurc;
         ctc.MesAno = obj.SISARQ.Item.Grupo_ACTC921_RelatConclcTar.AnoMesRefApurc.Replace("-", "");
         ctc.TipoRelatorio = obj.SISARQ.Item.Grupo_ACTC921_RelatConclcTar.TpRelat;
         ctc.SituacaoProcessamento = obj.SISARQ.Item.Grupo_ACTC921_RelatConclcTar.SitProc;

         new CTC921Business().Incluir(ctc);

         foreach (var detalheArquivo in obj.SISARQ.Item.Grupo_ACTC921_RelatConclcTar.Grupo_ACTC921_TpContrto)
         {
            foreach(var item in detalheArquivo.Grupo_ACTC921_EvtTar)
            {
               CTC921Detalhes arq = new CTC921Detalhes() { CTC921 = ctc.Id, TipoContrato = detalheArquivo.TpContrto, CNPJIFOriginadoraContrato = item.CNPJBase_IFOrContrto, Contrato = item.CodContrtoOr, CpfCnpjCliente = item.Grupo_ACTC921_Cli.FirstOrDefault().CNPJ_CPFCli, DataTarifa = item.DtEvtTar, EmailCliente = item.Grupo_ACTC921_Cli.FirstOrDefault().EmailCli, EnteConsignante = item.TpEnteCons, EventoTarifa = item.CodEvtTar, ISPBProponente = item.ISPBPropnt, NomeCliente = item.Grupo_ACTC921_Cli.FirstOrDefault().NomCli, NUPortabilidade = item.NUPortlddCTC, TelefoneCliente = item.Grupo_ACTC921_Cli.FirstOrDefault().TelCli, TipoCliente = item.Grupo_ACTC921_Cli.FirstOrDefault().TpCli.ToString() };
               new CTC921DetalhesBusiness().Incluir(arq);
            }


         }

         //Atualiza a Situação para Processado
         arquivo.Mensagem = "Processamento Concluído com Sucesso";
         arquivo.SituacaoArquivo = 2;
         arquivo.Status = "CONCLUIDO";
         CTCService.GetInstance().AlterarArquivo(arquivo);
      }
   }
}