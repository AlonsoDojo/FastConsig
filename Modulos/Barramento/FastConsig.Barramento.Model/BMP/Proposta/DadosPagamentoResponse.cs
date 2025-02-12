using Newtonsoft.Json; 
using System.Collections.Generic; 
namespace FastConsig.Barramento.Model.BMP.Proposta{ 

    public class DadosPagamentoResponse
    {
        [JsonProperty("msg")]
        public string msg { get; set; }

        [JsonProperty("hasError")]
        public bool? hasError { get; set; }

        [JsonProperty("messages")]
        public List<MessageDadosPagamentoResponse> messages { get; set; }

        [JsonProperty("parametros")]
        public List<ParametroDadosPagamentoResponse> parametros { get; set; }
    }

}