using FastConsig.Common.Loggin;
using FastConsig.CTC.Entity;
using FastConsig.CTC.Model.Interfaces;
using FastConsig.CTC.Services;
using System;

namespace FastConsig.CTC.Politicas
{
   public class PulaFase : IPoliticaCTCRequisicao
   {
      public void Execute(CTCRequisicao requisicao, int? fase, int? tipoFluxo, string tipoPessoaPolitica)
      {
         LogService.GetInstance().GravarLogDebug("Processando Politica de Pular de Fase para a Requisicao: " + requisicao.Id.ToString() + " - Fase Entrada: " + requisicao.Fase);

         var faseAtual = requisicao.Fase;

         var proximaFase = CTCService.GetInstance().BuscaProximaFase(requisicao.TipoArquivo, fase, tipoFluxo);

         //Muda a Proposta para a Nova Fase
         var entrada = false;
         var saida = true;

         if (requisicao.Status == "SUBMETIDA")
         {
            entrada = false;
            saida = false;
         }

         requisicao.Fase = proximaFase;
         requisicao.Status = "PROCESSANDO";

         CTCService.GetInstance().AlterarRequesicao(requisicao);

         var politicas = CTCService.GetInstance().ListarPoliticasFase(fase, requisicao.TipoFluxo, requisicao.TipoArquivo, requisicao.Status, entrada, saida);

         foreach (CTCPoliticaConfiguracaoExecucao p in politicas)
         {
            if ((requisicao.TipoPessoa == "F" ? 1 : 0) == p.TipoPessoa)
            {
               try
               {
                  CTCService.GetInstance().ExecutaPoliticaRequisicao(p.Metodo, requisicao, fase, requisicao.TipoFluxo, requisicao.TipoPessoa);
               }
               catch (Exception ex)
               {
                  throw new Exception(ex.Message, ex);
               }
            }
         }

         CTCService.GetInstance().SubmeterRequisicao(requisicao);
         LogService.GetInstance().GravarLogDebug("Término do Processamento da Politica de Pular de Fase para a Requisição: " + requisicao.Id.ToString() + " Fase Saida: " + requisicao.Fase);

      }
   }
}
