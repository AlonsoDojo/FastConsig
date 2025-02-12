using Newtonsoft.Json; 
using System; 
namespace FastConsig.Barramento.Model.BMP.Proposta{ 

    public class PropostaLancamentoResponse
    {
        [JsonProperty("campoID")]
        public string campoID { get; set; }

        [JsonProperty("descricaoCampo")]
        public string descricaoCampo { get; set; }

        [JsonProperty("vlrTransacao")]
        public int? vlrTransacao { get; set; }

        [JsonProperty("dtPrevPagto")]
        public DateTime? dtPrevPagto { get; set; }

        [JsonProperty("dtPagamento")]
        public DateTime? dtPagamento { get; set; }

        [JsonProperty("situacao")]
        public int? situacao { get; set; }

        [JsonProperty("linhaDigitavel")]
        public string linhaDigitavel { get; set; }

        [JsonProperty("dtVenctoBoleto")]
        public DateTime? dtVenctoBoleto { get; set; }

        [JsonProperty("vlrBoleto")]
        public int? vlrBoleto { get; set; }

        [JsonProperty("codigoBanco")]
        public int? codigoBanco { get; set; }

        [JsonProperty("numeroBanco")]
        public string numeroBanco { get; set; }

        [JsonProperty("tipoConta")]
        public int? tipoConta { get; set; }

        [JsonProperty("agencia")]
        public string agencia { get; set; }

        [JsonProperty("agenciaDig")]
        public string agenciaDig { get; set; }

        [JsonProperty("conta")]
        public string conta { get; set; }

        [JsonProperty("contaDig")]
        public string contaDig { get; set; }

        [JsonProperty("documentoFederal")]
        public string documentoFederal { get; set; }

        [JsonProperty("nomePagamento")]
        public string nomePagamento { get; set; }

        [JsonProperty("textoRetornoPagamento")]
        public string textoRetornoPagamento { get; set; }

        [JsonProperty("autenticacaoBancaria")]
        public string autenticacaoBancaria { get; set; }

        [JsonProperty("controleBancario")]
        public string controleBancario { get; set; }

        [JsonProperty("descricaoOcorrencia")]
        public string descricaoOcorrencia { get; set; }
    }

}