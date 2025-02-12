using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.Barramento.Model
{
   public class ContratosRenegociacaoResponseModel
   {
      [JsonProperty("agencia")]
      public string agencia { get; set; }

      [JsonProperty("contrato")]
      public string contrato { get; set; }

      [JsonProperty("saldoDevedor")]
      public decimal? saldoDevedor { get; set; }
   }
}
