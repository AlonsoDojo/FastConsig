using Newtonsoft.Json; 
namespace FastConsig.Barramento.Model.BMP.Pessoa{ 

    public class Pj
    {
        [JsonProperty("nomeFantasia")]
        public string nomeFantasia { get; set; }

        [JsonProperty("documentoEstadual")]
        public string documentoEstadual { get; set; }

        [JsonProperty("documentoMunicipal")]
        public string documentoMunicipal { get; set; }

        [JsonProperty("dtAberturaEmpresa")]
        public string dtAberturaEmpresa { get; set; }

        [JsonProperty("nomeResponsavelEmpresa")]
        public string nomeResponsavelEmpresa { get; set; }

        [JsonProperty("cpfResponsavelEmpresa")]
        public string cpfResponsavelEmpresa { get; set; }

        [JsonProperty("rgResponsavelEmpresa")]
        public string rgResponsavelEmpresa { get; set; }

        [JsonProperty("codigoRede")]
        public string codigoRede { get; set; }
    }

}