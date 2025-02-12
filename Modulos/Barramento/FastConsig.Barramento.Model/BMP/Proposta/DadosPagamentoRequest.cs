using Newtonsoft.Json; 
namespace FastConsig.Barramento.Model.BMP.Proposta{ 

    public class DadosPagamentoRequest
    {
        [JsonProperty("dto")]
        public DtoDadosPagamentoRequest dto { get; set; }

        [JsonProperty("dtoPagto")]
        public DtoPagtoDadosPagamentoRequest dtoPagto { get; set; }
    }

}