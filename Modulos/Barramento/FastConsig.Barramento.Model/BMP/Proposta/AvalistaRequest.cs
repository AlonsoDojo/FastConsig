using Newtonsoft.Json; 
namespace FastConsig.Barramento.Model.BMP.Proposta{ 

    public class AvalistaRequest
    {
        [JsonProperty("dto")]
        public DtoAvalistaRequest dto { get; set; }

        [JsonProperty("avalista")]
        public Avalista avalista { get; set; }
    }

}