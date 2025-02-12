using FastConsig.Common.Loggin;
using FastConsig.Core.Model;
using FastConsig.Core.Model.Interfaces;
using FastConsig.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.Core.Politicas.Proposta
{
   public class AguardaNaFase : IPolitica
   {
      public void Execute(PropostaModel proposta, int? fase, string tipoPessoaPolitica)
      {
         LogService.GetInstance().GravarLogDebug("Processando Politica de Aguardar na Fase para a Proposta: " + proposta.Id.ToString());
         try
         {
            proposta.Status = 3; //AGUARDANDO
            PropostaService.GetInstance().AtualizaProposta(proposta);
         }
         catch (Exception ex)
         {
            LogService.GetInstance().GravarLogErro(ex, "Erro ao colocar a proposta: " + proposta.Id.ToString() + " no status de Aguardando!");
         }
         LogService.GetInstance().GravarLogDebug("Término do Processamento da Politica de Aguardar na Fase para a Proposta: " + proposta.Id.ToString());
      }
   }
}
