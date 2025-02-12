using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.Consignado.Model
{
   [Serializable]
   public class ParametroExtraModel
   {
      public ParametroExtraModel()
      {
         Excecao = new List<Excecao>();
      }

      public List<Excecao> Excecao { get; set; }

      // NUNCA APAGAR O FRAMEWORK UTILIZA
      public string ParametroExtra { get; set; }

      public TaxaJuros TaxaJuros { get; set; }
   }
}
