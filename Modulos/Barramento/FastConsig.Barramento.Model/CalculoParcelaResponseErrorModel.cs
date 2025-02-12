using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.Barramento.Model
{
   public class CalculoParcelaResponseErrorModel
   {
      [JsonProperty("code")]
      public int? code { get; set; }

      [JsonProperty("field")]
      public string field { get; set; }

      [JsonProperty("type")]
      public int? type { get; set; }

      [JsonProperty("errorMessage")]
      public string errorMessage { get; set; }
   }
}
