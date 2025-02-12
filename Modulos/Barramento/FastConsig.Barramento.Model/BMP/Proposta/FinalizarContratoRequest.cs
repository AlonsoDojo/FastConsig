using Newtonsoft.Json; 
using System.Collections.Generic; 
namespace FastConsig.Barramento.Model.BMP.Proposta{ 

    public class FinalizarContratoRequest
    {
        [JsonProperty("dto")]
        public DtoFinalizarContratoRequest dto { get; set; }

        [JsonProperty("parametros")]
        public List<ParametroFinalizarContratoRequest> parametros { get; set; }
    }

}