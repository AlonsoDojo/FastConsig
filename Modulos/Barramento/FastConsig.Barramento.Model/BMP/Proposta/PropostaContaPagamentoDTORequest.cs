using Newtonsoft.Json; 
namespace FastConsig.Barramento.Model.BMP.Proposta{ 

    public class PropostaContaPagamentoDTORequest
    {
        [JsonProperty("codigoBanco")]
        public int? codigoBanco { get; set; }

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

        [JsonProperty("numeroBanco")]
        public string numeroBanco { get; set; }

        [JsonProperty("documentoFederalPagamento")]
        public string documentoFederalPagamento { get; set; }

        [JsonProperty("nomePagamento")]
        public string nomePagamento { get; set; }
    }

}