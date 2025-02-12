using Newtonsoft.Json; 
using System; 
namespace FastConsig.Barramento.Model.BMP.Pessoa{ 

    public class DtoEnderecoResponse
    {
        [JsonProperty("codigo")]
        public string codigo { get; set; }

        [JsonProperty("cep")]
        public string cep { get; set; }

        [JsonProperty("logradouro")]
        public string logradouro { get; set; }

        [JsonProperty("nroLogradouro")]
        public string nroLogradouro { get; set; }

        [JsonProperty("bairro")]
        public string bairro { get; set; }

        [JsonProperty("complemento")]
        public string complemento { get; set; }

        [JsonProperty("cidade")]
        public string cidade { get; set; }

        [JsonProperty("uf")]
        public string uf { get; set; }

        [JsonProperty("tipoEndereco")]
        public int? tipoEndereco { get; set; }

        [JsonProperty("tipoResidencia")]
        public int? tipoResidencia { get; set; }

        [JsonProperty("enderecoDesde")]
        public DateTime? enderecoDesde { get; set; }

        [JsonProperty("enderecoPrincipal")]
        public bool? enderecoPrincipal { get; set; }

        [JsonProperty("enderecoCorrespondencia")]
        public bool? enderecoCorrespondencia { get; set; }
    }

}