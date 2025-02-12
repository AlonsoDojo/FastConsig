using Newtonsoft.Json; 
using System.Collections.Generic; 
namespace FastConsig.Barramento.Model.BMP.Proposta{ 

    public class CancelarPropostaRequest
    {
        [JsonProperty("dto")]
        public DtoCancelarPropostaRequest dto { get; set; }

        [JsonProperty("textoMotivoCancelamento")]
        public string textoMotivoCancelamento { get; set; }

        [JsonProperty("parametros")]
        public List<ParametroCancelarPropostaRequest> parametros { get; set; }
    }

}