using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.Barramento.Model
{
   [Serializable]
   public class PrazoTabelaFinanceiraModel
   {
      public string Empresa { get; set; }

      public int? Plano { get; set; }

      public int? Prazo { get; set; }

      public decimal? Taxa { get; set; }

      public decimal? TaxaMinima { get; set; }

      public decimal? TaxaMaxima { get; set; }
   }
}
