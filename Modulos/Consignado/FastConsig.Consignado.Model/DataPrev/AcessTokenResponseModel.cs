using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.Consignado.Model.DataPrev
{
   public class AcessTokenResponseModel
   {
      [JsonProperty("access_token", NullValueHandling = NullValueHandling.Ignore)]
      public string AccessToken { get; set; }

      [JsonProperty("scope", NullValueHandling = NullValueHandling.Ignore)]
      public string Scope { get; set; }

      [JsonProperty("token_type", NullValueHandling = NullValueHandling.Ignore)]
      public string TokenType { get; set; }

      [JsonProperty("expires_in", NullValueHandling = NullValueHandling.Ignore)]
      public long? ExpiresIn { get; set; }

      public DateTime Date { get; set; }
   }
}
