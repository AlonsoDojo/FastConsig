using FastConsig.Core.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.Consignado.Model.DataPrev
{
   public class AutorizacaoConsultaBeneficioResponseModel : PropostaBaseModel
   {
      [JsonProperty("dataValidadeAutorizacao", NullValueHandling = NullValueHandling.Ignore)]
      public string DataValidadeAutorizacao { get; set; }

      [JsonProperty("tokenAutorizacao", NullValueHandling = NullValueHandling.Ignore)]
      public string TokenAutorizacao { get; set; }

      public AutorizacaoConsultaBeneficioErroModel Error { get; set; }
   }
}
