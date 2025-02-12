using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.Barramento.Model
{
   [Serializable]
   public class TabelaFinanceiraModel
   {
      public string Empresa { get; set; }

      public int? Plano { get; set; }

      public string DescricaoPlano { get; set; }

      public string Lojista { get; set; }

      public string Loja { get; set; }

      public string Promotora { get; set; }

      public string Produto { get; set; }

      public string PK
      {
         get
         {
            return this.Empresa + this.Promotora + this.Produto + this.Plano + this.Lojista + this.Loja;
         }
      }
      public int? CarenciaMinima { get; set; }

      public int? CarenciaMaxima { get; set; }
   }
}
