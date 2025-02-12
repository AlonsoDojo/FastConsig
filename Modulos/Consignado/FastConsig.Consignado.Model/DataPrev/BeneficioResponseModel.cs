using FastConsig.Core.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.Consignado.Model.DataPrev
{
   public class BeneficioResponseModel : PropostaBaseModel
   {
      [JsonProperty("beneficios", NullValueHandling = NullValueHandling.Ignore)]
      public List<Beneficio> Beneficios { get; set; }

      public BeneficioErroModel Error { get; set; }
   }
}
