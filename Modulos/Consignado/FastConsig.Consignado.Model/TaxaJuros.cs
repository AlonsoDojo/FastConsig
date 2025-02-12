using FastConsig.Consignado.Model.DataPrev;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.Consignado.Model
{
   [Serializable]
   public class TaxaJuros
   {
      public decimal ValorTaxaMensalMinima { get; set; }

      public decimal ValorTaxaMensalMaxima { get; set; }

      public decimal ValorTaxaMensalMinimaRMC { get; set; }

      public decimal ValorTaxaMensalMaximaRMC { get; set; }

      public decimal ValorTaxaMensalMinimaRCC { get; set; }

      public decimal ValorTaxaMensalMaximaRCC { get; set; }

      public string AtendimentoView { get; set; }

      public List<Atendimento> Atendimento { get; set; }
   }
}
