using Newtonsoft.Json; 
namespace FastConsig.Barramento.Model.BMP.Pessoa{ 

    public class ParamPessoaResponse
    {
        [JsonProperty("documentoCliente")]
        public string documentoCliente { get; set; }
    }

}