using Newtonsoft.Json; 
using System.Collections.Generic; 
namespace FastConsig.Barramento.Model.BMP.Proposta{ 

    public class ContratoRequest
    {
        [JsonProperty("dto")]
        public DtoContratoRequest dto { get; set; }

        [JsonProperty("parametros")]
        public List<ParametroContratoRequest> parametros { get; set; }
    }

}