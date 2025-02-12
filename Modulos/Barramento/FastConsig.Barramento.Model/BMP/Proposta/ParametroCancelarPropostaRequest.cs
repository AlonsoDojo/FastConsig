using Newtonsoft.Json; 
namespace FastConsig.Barramento.Model.BMP.Proposta{ 

    public class ParametroCancelarPropostaRequest
    {
        [JsonProperty("nome")]
        public string nome { get; set; }

        [JsonProperty("valor")]
        public string valor { get; set; }
    }

}