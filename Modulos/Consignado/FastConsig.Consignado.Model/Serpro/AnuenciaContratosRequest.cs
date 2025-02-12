using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.Consignado.Model.Serpro
{
   public class AnuenciaContratosRequest
   {
      public string cdConsig { get; set; }
      public string cdSenhaConsig { get; set; }
      public string cursorPaginacao { get; set; }
      public string dataHora { get; set; }
   }
}
