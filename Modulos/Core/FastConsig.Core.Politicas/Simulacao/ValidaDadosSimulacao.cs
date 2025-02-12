using FastConsig.Core.Model;
using FastConsig.Core.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.Core.Politicas.Simulacao
{
   public class ValidaDadosSimulacao : IPoliticaSimulacao
   {
      public void Execute(SimulacaoPropostaModel proposta)
      {
         if (proposta.Operacao.Prazo == null)
         {
            throw new Exception("Prazo da Operação Inválido");
         }

         if (proposta.Operacao.ValorOperacao != null && proposta.Operacao.ValorOperacao > 0)
         {
            if (proposta.Operacao.ValorParcela != null && proposta.Operacao.ValorParcela > 0)
            {
               throw new Exception("Somente o Valor Solicitado ou Valor da Parcela deve ser Informado");
            }
         }

         if (proposta.Operacao.ValorParcela == 0 && proposta.Operacao.ValorOperacao == 0)
         {
            throw new Exception("Valor Solicitado ou Valor da Parcela deve ser Informado");
         }
      }
   }
}
