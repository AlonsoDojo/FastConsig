using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.Core.Model.Interfaces
{
   public interface IPoliticaSimulacao
   {
      void Execute(SimulacaoPropostaModel proposta);
   }
}
