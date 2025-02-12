using Newtonsoft.Json; 
namespace FastConsig.Barramento.Model.BMP.Pessoa{ 

    public class PessoaRequest
    {
        [JsonProperty("dto")]
        public DtoPessoaRequest dto { get; set; }
    }

}