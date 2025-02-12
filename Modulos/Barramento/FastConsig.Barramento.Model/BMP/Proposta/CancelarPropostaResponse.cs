using Newtonsoft.Json; 
using System.Collections.Generic; 
namespace FastConsig.Barramento.Model.BMP.Proposta{ 

    public class CancelarPropostaResponse
    {
        [JsonProperty("msg")]
        public string msg { get; set; }

        [JsonProperty("hasError")]
        public bool? hasError { get; set; }

        [JsonProperty("messages")]
        public List<MessageCancelarPropostaResponse> messages { get; set; }

        [JsonProperty("parametros")]
        public List<ParametroCancelarPropostaResponse> parametros { get; set; }
    }

}