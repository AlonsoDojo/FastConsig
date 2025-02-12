using Newtonsoft.Json; 
namespace FastConsig.Barramento.Model.BMP.Pessoa{ 

    public class DocumentoRequest
    {
        [JsonProperty("dto")]
        public DtoDocumentoRequest dto { get; set; }

        [JsonProperty("documento")]
        public Documento documento { get; set; }
    }

}