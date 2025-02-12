using Newtonsoft.Json; 
using System.Collections.Generic; 
namespace FastConsig.Barramento.Model.BMP.Pessoa{ 

    public class PessoaResponse
    {
        [JsonProperty("msg")]
        public string msg { get; set; }

        [JsonProperty("hasError")]
        public bool? hasError { get; set; }

        [JsonProperty("messages")]
        public List<MessagePessoaResponse> messages { get; set; }

        [JsonProperty("codigo")]
        public string codigo { get; set; }
    }

}