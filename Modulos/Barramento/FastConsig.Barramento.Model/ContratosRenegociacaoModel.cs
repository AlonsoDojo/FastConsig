using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.Barramento.Model
{
   public class ContratosRenegociacaoModel
   {
      [JsonProperty("agencia", NullValueHandling = NullValueHandling.Ignore)]
      public string agencia { get; set; }

      [JsonProperty("contrato", NullValueHandling = NullValueHandling.Ignore)]
      public string contrato { get; set; }
   }
}
