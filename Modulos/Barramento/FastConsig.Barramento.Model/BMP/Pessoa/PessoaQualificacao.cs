using Newtonsoft.Json; 
using System; 
namespace FastConsig.Barramento.Model.BMP.Pessoa{ 

    public class PessoaQualificacao
    {
        [JsonProperty("codigo")]
        public string codigo { get; set; }

        [JsonProperty("codigoProfissao")]
        public int? codigoProfissao { get; set; }

        [JsonProperty("vlrRenda")]
        public double? vlrRenda { get; set; }

        [JsonProperty("dtAdmissao")]
        public DateTime? dtAdmissao { get; set; }

        [JsonProperty("dtDemissao")]
        public DateTime? dtDemissao { get; set; }

        [JsonProperty("nroMatricula")]
        public string nroMatricula { get; set; }

        [JsonProperty("nomeEmpresa")]
        public string nomeEmpresa { get; set; }

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

        [JsonProperty("telefoneFixo")]
        public string telefoneFixo { get; set; }
    }

}