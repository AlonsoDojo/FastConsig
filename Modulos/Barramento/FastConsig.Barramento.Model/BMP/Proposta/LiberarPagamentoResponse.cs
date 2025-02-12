using Newtonsoft.Json; 
using System.Collections.Generic; 
namespace FastConsig.Barramento.Model.BMP.Proposta{ 

    public class LiberarPagamentoResponse
    {
        [JsonProperty("msg")]
        public string msg { get; set; }

        [JsonProperty("hasError")]
        public bool? hasError { get; set; }

        [JsonProperty("messages")]
        public List<MessageLiberarPagamentoResponse> messages { get; set; }

        [JsonProperty("parametros")]
        public List<ParametroLiberarPagamentoResponse> parametros { get; set; }
    }

}