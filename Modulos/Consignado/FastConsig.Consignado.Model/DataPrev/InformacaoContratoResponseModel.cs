using FastConsig.Core.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.Consignado.Model.DataPrev
{
   public class InformacaoContratoResponseModel : PropostaBaseModel
   {
      [JsonProperty("codigo", NullValueHandling = NullValueHandling.Ignore)]
      public string Codigo { get; set; }

      [JsonProperty("numeroBeneficio", NullValueHandling = NullValueHandling.Ignore)]
      public long? NumeroBeneficio { get; set; }

      [JsonProperty("codigoSolicitante", NullValueHandling = NullValueHandling.Ignore)]
      public long? CodigoSolicitante { get; set; }

      [JsonProperty("numeroContrato", NullValueHandling = NullValueHandling.Ignore)]
      public string NumeroContrato { get; set; }

      [JsonProperty("hashOperacao", NullValueHandling = NullValueHandling.Ignore)]
      public long? HashOperacao { get; set; }

      public InformacaoContratoErroModel Error { get; set; }
   }
}
