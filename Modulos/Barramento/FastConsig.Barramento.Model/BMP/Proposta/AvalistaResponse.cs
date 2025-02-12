using Newtonsoft.Json; 
using System.Collections.Generic; 
namespace FastConsig.Barramento.Model.BMP.Proposta{ 

    public class AvalistaResponse
    {
        [JsonProperty("msg")]
        public string msg { get; set; }

        [JsonProperty("hasError")]
        public bool? hasError { get; set; }

        [JsonProperty("messages")]
        public List<MessageAvalistaResponse> messages { get; set; }

        [JsonProperty("codigo")]
        public string codigo { get; set; }

        [JsonProperty("numero")]
        public int? numero { get; set; }
    }

}