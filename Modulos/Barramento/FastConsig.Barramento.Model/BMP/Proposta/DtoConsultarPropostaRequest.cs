using Newtonsoft.Json; 
namespace FastConsig.Barramento.Model.BMP.Proposta{ 

    public class DtoConsultarPropostaRequest
    {
        [JsonProperty("codigoProposta")]
        public string codigoProposta { get; set; }

        [JsonProperty("codigoOperacao")]
        public string codigoOperacao { get; set; }

        [JsonProperty("numeroProposta")]
        public int? numeroProposta { get; set; }
    }

}