using Newtonsoft.Json; 
namespace FastConsig.Barramento.Model.BMP.Pessoa{ 

    public class ParamEnderecoResponse
    {
        [JsonProperty("documentoCliente")]
        public string documentoCliente { get; set; }
    }

}