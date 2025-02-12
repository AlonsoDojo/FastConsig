using Newtonsoft.Json; 
using System.Collections.Generic; 
namespace FastConsig.Barramento.Model.BMP.Proposta{ 

    public class LiberarPagamentoRequest
    {
        [JsonProperty("dto")]
        public DtoLiberarPagamentoRequest dto { get; set; }

        [JsonProperty("parametros")]
        public List<ParametroLiberarPagamentoRequest> parametros { get; set; }
    }

}