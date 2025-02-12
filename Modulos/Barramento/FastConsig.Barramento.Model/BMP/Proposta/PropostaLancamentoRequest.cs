using Newtonsoft.Json; 
using System; 
namespace FastConsig.Barramento.Model.BMP.Proposta{ 

    public class PropostaLancamentoRequest
    {
        [JsonProperty("campoID")]
        public string campoID { get; set; }

        [JsonProperty("vlrTransacao")]
        public int? vlrTransacao { get; set; }

        [JsonProperty("dtPagamento")]
        public DateTime? dtPagamento { get; set; }

        [JsonProperty("linhaDigitavel")]
        public string linhaDigitavel { get; set; }

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

        [JsonProperty("documentoFederalCedente")]
        public string documentoFederalCedente { get; set; }

        [JsonProperty("nomeCedente")]
        public string nomeCedente { get; set; }
    }

}