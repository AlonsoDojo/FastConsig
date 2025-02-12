using Newtonsoft.Json; 
using System.Collections.Generic; 
namespace FastConsig.Barramento.Model.BMP.Proposta{ 

    public class FinalizarContratoResponse
    {
        [JsonProperty("msg")]
        public string msg { get; set; }

        [JsonProperty("hasError")]
        public bool? hasError { get; set; }

        [JsonProperty("messages")]
        public List<MessageFinalizarContratoResponse> messages { get; set; }

        [JsonProperty("parametros")]
        public List<ParametroFinalizarContratoResponse> parametros { get; set; }
    }

}