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
   public class FinalizarFluxo : IPoliticaCTCRequisicao
   {
      public void Execute(CTCRequisicao requisicao, int? fase, int? tipoFluxo, string tipoPessoaPolitica)
      {
         LogService.GetInstance().GravarLogDebug("Processando Politica de Finalizar a Requisicao: " + requisicao.Id.ToString());
         try
         {
            requisicao.Status = "CONCLUIDO";
            CTCService.GetInstance().AlterarRequesicao(requisicao);
         }
         catch (Exception ex)
         {
            LogService.GetInstance().GravarLogErro(ex, "Erro ao colocar a Requisicao: " + requisicao.Id.ToString() + " no status de Concluído!");
         }
         LogService.GetInstance().GravarLogDebug("Término do Processamento da Politica de Finalizar a Requisição: " + requisicao.Id.ToString());
      }
   }
}
