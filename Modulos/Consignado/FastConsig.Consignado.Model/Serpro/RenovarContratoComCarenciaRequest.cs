using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.Consignado.Model.Serpro
{
   public class RenovarContratoComCarenciaRequest : RenovarContratoV2Request
   {
      public string carenciaAte { get; set; }
   }
}
