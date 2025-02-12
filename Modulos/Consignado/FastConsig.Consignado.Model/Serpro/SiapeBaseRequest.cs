using FastConsig.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.Consignado.Model.Serpro
{
   public class SiapeBaseRequest : PropostaBaseModel
   {
      public string NrCpf { get; set; }

      public string CdConsig { get; set; }

      public string CdSenhaConsig { get; set; }
   }
}
