using Newtonsoft.Json; 
using System.Collections.Generic; 
namespace FastConsig.Barramento.Model.BMP.Proposta{ 

    public class AssinaturaRequest
    {
        [JsonProperty("dto")]
        public DtoAssinaturaRequest dto { get; set; }

        [JsonProperty("assinantes")]
        public List<AssinanteRequest> assinantes { get; set; }
    }

}