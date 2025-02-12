using FastConsig.Core.Model;
using FastConsig.Core.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.Core.Politicas.Proposta
{
   public class NotificacaoPorEmail : IPolitica
   {
      public void Execute(PropostaModel proposta, int? fase, string tipoPessoaPolitica)
      {
         throw new NotImplementedException();
      }
   }
}
