using Newtonsoft.Json; 
namespace FastConsig.Barramento.Model.BMP.Pessoa{ 

    public class EnderecoRequest
    {
        [JsonProperty("dto")]
        public DtoEndereco dto { get; set; }

        [JsonProperty("param")]
        public ParamPessoaResponse param { get; set; }
    }

}