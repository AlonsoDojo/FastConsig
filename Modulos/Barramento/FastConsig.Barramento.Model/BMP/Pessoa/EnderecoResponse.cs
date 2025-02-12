using Newtonsoft.Json; 
namespace FastConsig.Barramento.Model.BMP.Pessoa{ 

    public class EnderecoResponse
    {
        [JsonProperty("dto")]
        public DtoEnderecoResponse dto { get; set; }

        [JsonProperty("param")]
        public ParamEnderecoResponse param { get; set; }
    }

}