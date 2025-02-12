using FastConsig.Core.Model;
using FastConsig.Core.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.Core.Politicas.Simulacao
{
   public class ConsultaAutorizacaoValida : IPoliticaSimulacao
   {
      public void Execute(SimulacaoPropostaModel proposta)
      {
         //TODO: Validar a Familia do Produto em com base nela implementar
         throw new NotImplementedException();
      }
   }
}
