using Newtonsoft.Json; 
namespace FastConsig.Barramento.Model.BMP.Pessoa{ 

    public class DtoDocumentoRequest
    {
        [JsonProperty("documentoCliente")]
        public string documentoCliente { get; set; }
    }

}