using Newtonsoft.Json; 
namespace FastConsig.Barramento.Model.BMP.Proposta{ 

    public class MessageLiberarPagamentoResponse
    {
        [JsonProperty("messageType")]
        public int? messageType { get; set; }

        [JsonProperty("code")]
        public string code { get; set; }

        [JsonProperty("context")]
        public string context { get; set; }

        [JsonProperty("description")]
        public string description { get; set; }

        [JsonProperty("field")]
        public string field { get; set; }
    }

}