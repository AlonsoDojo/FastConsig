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
   public class AguardaNaFaseResposta : IPoliticaCTCRequisicao
   {
      public void Execute(CTCRequisicao requisicao, int? fase, int? tipoFluxo, string tipoPessoaPolitica)
      {
         LogService.GetInstance().GravarLogDebug("Processando Politica de Aguardar na Fase para a Requisicao: " + requisicao.Id.ToString());
         try
         {
            requisicao.Fase = 2; /*Resposta*/
            requisicao.TipoFluxo = 2; /*Resposta*/
            requisicao.Status = "AGUARDANDO";
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
