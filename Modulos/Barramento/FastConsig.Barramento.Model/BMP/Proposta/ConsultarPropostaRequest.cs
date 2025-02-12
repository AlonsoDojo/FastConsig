using Newtonsoft.Json; 
namespace FastConsig.Barramento.Model.BMP.Proposta{ 

    public class ConsultarPropostaRequest
    {
        [JsonProperty("dto")]
        public DtoConsultarPropostaRequest dto { get; set; }
    }

}