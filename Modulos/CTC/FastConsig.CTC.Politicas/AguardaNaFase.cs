using FastConsig.Common.Loggin;
using FastConsig.CTC.Entity;
using FastConsig.CTC.Model.Interfaces;
using FastConsig.CTC.Services;
using System;

namespace FastConsig.CTC.Politicas
{
   public class AguardaNaFase : IPoliticaCTCRequisicao
   {
      public void Execute(CTCRequisicao requisicao, int? fase, int? tipoFluxo, string tipoPessoaPolitica)
      {
         LogService.GetInstance().GravarLogDebug("Processando Politica de Aguardar na Fase para a Requisicao: " + requisicao.Id.ToString());
         try
         {
            requisicao.Status = (requisicao.Status == "AGUARDANDO ENVIO" ? "AGUARDANDO ENVIO" : "AGUARDANDO");
            CTCService.GetInstance().AlterarRequesicao(requisicao);
         }
         catch (Exception ex)
         {
            LogService.GetInstance().GravarLogErro(ex, "Erro ao colocar a Requisicao: " + requisicao.Id.ToString() + " no status de Aguardando!");
         }
         LogService.GetInstance().GravarLogDebug("Término do Processamento da Politica de Aguardar na Fase para a Requisição: " + requisicao.Id.ToString());
      }
   }
}
