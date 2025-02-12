using Newtonsoft.Json; 
using System.Collections.Generic; 
using System; 
namespace FastConsig.Barramento.Model.BMP.Proposta{ 

    public class ConsultarPropostaResponse
    {
        [JsonProperty("msg")]
        public string msg { get; set; }

        [JsonProperty("hasError")]
        public bool? hasError { get; set; }

        [JsonProperty("messages")]
        public List<MessageConsultarPropostaResponse> messages { get; set; }

        [JsonProperty("codigo")]
        public string codigo { get; set; }

        [JsonProperty("dtInclusao")]
        public string dtInclusao { get; set; }

        [JsonProperty("situacao")]
        public int? situacao { get; set; }

        [JsonProperty("vlrFinanciado")]
        public int? vlrFinanciado { get; set; }

        [JsonProperty("qtdeParcelas")]
        public int? qtdeParcelas { get; set; }

        [JsonProperty("vlrParcela")]
        public int? vlrParcela { get; set; }

        [JsonProperty("vlrTAC")]
        public int? vlrTAC { get; set; }

        [JsonProperty("vlrBoleto")]
        public int? vlrBoleto { get; set; }

        [JsonProperty("vlrSeguro")]
        public int? vlrSeguro { get; set; }

        [JsonProperty("vlrIOF")]
        public int? vlrIOF { get; set; }

        [JsonProperty("vlrOutrasDespesas")]
        public int? vlrOutrasDespesas { get; set; }

        [JsonProperty("vlrOutrosServicos")]
        public int? vlrOutrosServicos { get; set; }

        [JsonProperty("vlrTotalCredito")]
        public int? vlrTotalCredito { get; set; }

        [JsonProperty("vlrTotalDivida")]
        public int? vlrTotalDivida { get; set; }

        [JsonProperty("vlrDesembolso")]
        public int? vlrDesembolso { get; set; }

        [JsonProperty("percCETMensal")]
        public int? percCETMensal { get; set; }

        [JsonProperty("percCETAnual")]
        public int? percCETAnual { get; set; }

        [JsonProperty("percJurosMensal")]
        public int? percJurosMensal { get; set; }

        [JsonProperty("percJurosAnual")]
        public int? percJurosAnual { get; set; }

        [JsonProperty("codigoOperacao")]
        public string codigoOperacao { get; set; }

        [JsonProperty("tipoContrato")]
        public string tipoContrato { get; set; }

        [JsonProperty("dtPagamento")]
        public DateTime? dtPagamento { get; set; }

        [JsonProperty("codigoProposta")]
        public string codigoProposta { get; set; }

        [JsonProperty("numeroCCB")]
        public string numeroCCB { get; set; }

        [JsonProperty("motivoRejeicao")]
        public string motivoRejeicao { get; set; }

        [JsonProperty("textoRetornoPagamento")]
        public string textoRetornoPagamento { get; set; }

        [JsonProperty("autenticacaoBancaria")]
        public string autenticacaoBancaria { get; set; }

        [JsonProperty("controleBancario")]
        public string controleBancario { get; set; }

        [JsonProperty("textoMotivoAnalise")]
        public string textoMotivoAnalise { get; set; }

        [JsonProperty("nomeFavorecido")]
        public string nomeFavorecido { get; set; }

        [JsonProperty("documentoFavorecido")]
        public string documentoFavorecido { get; set; }

        [JsonProperty("propostaLancamentos")]
        public List<PropostaLancamentoResponse> propostaLancamentos { get; set; }

        [JsonProperty("propostaContaPagamento")]
        public PropostaContaPagamentoResponse propostaContaPagamento { get; set; }
    }

}