using Newtonsoft.Json; 
namespace FastConsig.Barramento.Model.BMP.Pessoa{ 

    public class DtoPessoaRequest
    {
        [JsonProperty("codigo")]
        public string codigo { get; set; }

        [JsonProperty("nome")]
        public string nome { get; set; }

        [JsonProperty("documentoFederal")]
        public string documentoFederal { get; set; }

        [JsonProperty("identificadorEmpresaERP")]
        public string identificadorEmpresaERP { get; set; }

        [JsonProperty("codigoAtividadeProfissional")]
        public int? codigoAtividadeProfissional { get; set; }

        [JsonProperty("textoInfoHistCliente")]
        public string textoInfoHistCliente { get; set; }

        [JsonProperty("score")]
        public string score { get; set; }

        [JsonProperty("rating")]
        public string rating { get; set; }

        [JsonProperty("pf")]
        public Pf pf { get; set; }

        [JsonProperty("pj")]
        public Pj pj { get; set; }

        [JsonProperty("pessoaDadosContato")]
        public PessoaDadosContato pessoaDadosContato { get; set; }

        [JsonProperty("pessoaDadoFinanceiro")]
        public PessoaDadoFinanceiro pessoaDadoFinanceiro { get; set; }

        [JsonProperty("pessoaQualificacao")]
        public PessoaQualificacao pessoaQualificacao { get; set; }
    }

}