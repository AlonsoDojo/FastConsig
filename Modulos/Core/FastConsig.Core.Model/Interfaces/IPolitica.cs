using FastConsig.Core.Entity;
using FastConsig.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.Core.Model.Interfaces
{
   public interface IPolitica
   {
      void Execute(PropostaModel proposta, int? fase, string tipoPessoaPolitica);
   }
}
