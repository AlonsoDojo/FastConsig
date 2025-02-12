using FastConsig.Common.Services;
using FastConsig.CTC.Entity;
using FastConsig.CTC.Model.Interfaces;
using FastConsig.CTC.Services;

namespace FastConsig.CTC.Helpers.ACTC901
{
   public class ACTC901Process : IACTCProcess
   {
      public void Execute(int? idArquivo)
      {
         //Busca o Arquivo
         var arquivo = CTCService.GetInstance().BuscarArquivo(idArquivo);

         //Atualiza a Situação para Processando
         arquivo.SituacaoArquivo = 2;
         arquivo.Status = "PROCESSANDO";
         CTCService.GetInstance().AlterarArquivo(arquivo);

         //Busca o Parametro de Prazo de Expiração da Resposta de Retenção e Aceite
         int prazoRetencao = int.Parse(ConfiguracaoService.GetInstance().Obter("CTC.Dias.Retencao").Conteudo.ToString());
         int prazoAceite = int.Parse(ConfiguracaoService.GetInstance().Obter("CTC.Dias.Aceite").Conteudo.ToString());

         //Deserializa o Arquivo
         FastConsig.CTC.Model.ACTC901.ACTC901 obj = (FastConsig.CTC.Model.ACTC901.ACTC901)new ACTC901Parser().Parse(new System.IO.StringReader(arquivo.Conteudo));

         CTCService.GetInstance().ExcluirMovimentacaoRCO(obj.SISARQ.Item.AnoMesRefApurc.Replace("-", ""));

         if (obj.SISARQ.Item.Grupo_ACTC901_RCOARecb != null)
         {

            foreach (var item in obj.SISARQ.Item.Grupo_ACTC901_RCOARecb)
            {
               //Insere os dados na tabela de requisições
               CTCRCO movimento = new CTCRCO
               {
                  Tipo = "R",
                  AnoMes = obj.SISARQ.Item.AnoMesRefApurc.Replace("-", ""),
                  BaseCalculoRCO = item.VlrBaseCalcRCO,
                  DataMovimentoLiquidacaoSTR = item.DtMovtoSTRLiquid,
                  DataReferenciaSaldoDevedor = item.DtRefSaldDevdrContb,
                  IdentidadeParticipanteAdministrado = item.IdentdPartAdmdo,
                  ISPBContraParte = item.ISPBCtrapart,
                  ValorRCO = item.VlrRCOARecb,
                  ValorSaldoDevedor = item.VlrSaldDevdrContb,
                  ValorSaldoDevedorAD = item.VlrSaldDevdrContbAD,
                  ValorSTRLiquidacaoPortabilidade = item.VlrSTRLiquidPortldd,
                  NUPortabilidade = item.NUPortlddCTC,
                  Contrato = item.CodContrtoOr,
                  TipoContrato = item.TpContrto,
                  EnteConsignante = item.TpEnteCons,
                  DataContrato = item.DtContrOp,
                  DataVencimentoUltimaParcela = item.DtVencUltParclContrto,
                  Arquivo = arquivo.Id
               };

               CTCService.GetInstance().InserirMovimentoRCO(movimento);

               CTCRequisicao requisicao = CTCService.GetInstance().BuscarRequisicao(item.NUPortlddCTC);

               if (requisicao != null)
               {
                  requisicao.ValorRCOApurado = item.VlrRCOARecb;
                  CTCService.GetInstance().AlterarRequesicao(requisicao);
               }
            }
         }

         if (obj.SISARQ.Item.Grupo_ACTC901_RCOAPagar != null)
         {
            foreach (var item in obj.SISARQ.Item.Grupo_ACTC901_RCOAPagar)
            {
               //Insere os dados na tabela de requisições
               CTCRCO movimento = new CTCRCO
               {
                  Tipo = "P",
                  ISPBBancoPagamento = item.ISPBBcoPagtoRCO,
                  CodigoBancoPagamento = item.CodBcoPagtoRCO,
                  AgenciaPagamento = item.AgBancPagtoRCO,
                  ContaPagamento = item.CtBancPagtoRCO,
                  AnoMes = obj.SISARQ.Item.AnoMesRefApurc.Replace("-", ""),
                  BaseCalculoRCO = item.VlrBaseCalcRCO,
                  DataMovimentoLiquidacaoSTR = item.DtMovtoSTRLiquid,
                  DataReferenciaSaldoDevedor = item.DtRefSaldDevdrContb,
                  IdentidadeParticipanteAdministrado = item.IdentdPartAdmdo,
                  ISPBContraParte = item.ISPBCtrapart,
                  ValorRCO = item.VlrRCOAPagar,
                  ValorSaldoDevedor = item.VlrSaldDevdrContb,
                  ValorSaldoDevedorAD = item.VlrSaldDevdrContbAD,
                  ValorSTRLiquidacaoPortabilidade = item.VlrSTRLiquidPortldd,
                  NUPortabilidade = item.NUPortlddCTC,
                  Contrato = item.CodContrtoOr,
                  TipoContrato = item.TpContrto,
                  EnteConsignante = item.TpEnteCons,
                  DataContrato = item.DtContrOp,
                  DataVencimentoUltimaParcela = item.DtVencUltParclContrto,
                  Arquivo = arquivo.Id
               };

               CTCService.GetInstance().InserirMovimentoRCO(movimento);
            }
         }
         //Atualiza a Situação para Processado
         arquivo.SituacaoArquivo = 2;
         arquivo.Status = "CONCLUIDO";
         CTCService.GetInstance().AlterarArquivo(arquivo);
      }
   }
}
