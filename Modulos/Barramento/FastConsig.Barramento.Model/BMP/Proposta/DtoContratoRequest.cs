using Newtonsoft.Json; 
using System.Collections.Generic; 
using System; 
namespace FastConsig.Barramento.Model.BMP.Proposta{ 

    public class DtoContratoRequest
    {
        [JsonProperty("documentoCliente")]
        public string documentoCliente { get; set; }

        [JsonProperty("documentoPromotor")]
        public string documentoPromotor { get; set; }

        [JsonProperty("documentoParceiroCorrespondente")]
        public string documentoParceiroCorrespondente { get; set; }

        [JsonProperty("observacoesVendedor")]
        public string observacoesVendedor { get; set; }

        [JsonProperty("codigoOperacao")]
        public string codigoOperacao { get; set; }

        [JsonProperty("codigoVersaoCCB")]
        public int? codigoVersaoCCB { get; set; }

        [JsonProperty("tipoIndiceFinan")]
        public int? tipoIndiceFinan { get; set; }

        [JsonProperty("percIndiceFinan")]
        public long? percIndiceFinan { get; set; }

        [JsonProperty("vlrSolicitado")]
        public long? vlrSolicitado { get; set; }

        [JsonProperty("prazo")]
        public int? prazo { get; set; }

        [JsonProperty("percJurosNegociado")]
        public long? percJurosNegociado { get; set; }

        [JsonProperty("vlrIOF")]
        public long? vlrIOF { get; set; }

        [JsonProperty("percIOF")]
        public long? percIOF { get; set; }

        [JsonProperty("percIOFAdicional")]
        public long? percIOFAdicional { get; set; }

        [JsonProperty("vlrParcela")]
        public long? vlrParcela { get; set; }

        [JsonProperty("vlrTAC")]
        public long? vlrTAC { get; set; }

        [JsonProperty("vlrBoleto")]
        public long? vlrBoleto { get; set; }

        [JsonProperty("dtPrimeiroVencto")]
        public DateTime? dtPrimeiroVencto { get; set; }

        [JsonProperty("vlrOutrasDespesas")]
        public long? vlrOutrasDespesas { get; set; }

        [JsonProperty("vlrOutrosServicos")]
        public long? vlrOutrosServicos { get; set; }

        [JsonProperty("vlrSeguro")]
        public long? vlrSeguro { get; set; }

        [JsonProperty("vlrCorban")]
        public long? vlrCorban { get; set; }

        [JsonProperty("vlrAvaliacao")]
        public long? vlrAvaliacao { get; set; }

        [JsonProperty("vlrDespachante")]
        public long? vlrDespachante { get; set; }

        [JsonProperty("vlrRegistro")]
        public long? vlrRegistro { get; set; }

        [JsonProperty("vlrServTerceiro")]
        public long? vlrServTerceiro { get; set; }

        [JsonProperty("vlrRegistroCartorio")]
        public long? vlrRegistroCartorio { get; set; }

        [JsonProperty("vlrTxAdmMensal")]
        public long? vlrTxAdmMensal { get; set; }

        [JsonProperty("vlrSeguroMensal1")]
        public long? vlrSeguroMensal1 { get; set; }

        [JsonProperty("vlrSeguroMensal2")]
        public long? vlrSeguroMensal2 { get; set; }

        [JsonProperty("hotMoney")]
        public bool? hotMoney { get; set; }

        [JsonProperty("nroDiasAcrescimoHotMoney")]
        public int? nroDiasAcrescimoHotMoney { get; set; }

        [JsonProperty("rotativo")]
        public bool? rotativo { get; set; }

        [JsonProperty("tipoContrato")]
        public string tipoContrato { get; set; }

        [JsonProperty("percRetencao")]
        public long? percRetencao { get; set; }

        [JsonProperty("vlrRetencao")]
        public long? vlrRetencao { get; set; }

        [JsonProperty("vlrBlindagem")]
        public long? vlrBlindagem { get; set; }

        [JsonProperty("vlrAcessorios")]
        public long? vlrAcessorios { get; set; }

        [JsonProperty("vlrVistoria")]
        public long? vlrVistoria { get; set; }

        [JsonProperty("vlrCertiDocs")]
        public long? vlrCertiDocs { get; set; }

        [JsonProperty("propostaContaPagamentoDTO")]
        public PropostaContaPagamentoDTORequest propostaContaPagamentoDTO { get; set; }

        [JsonProperty("propostaLancamentos")]
        public List<PropostaLancamentoRequest> propostaLancamentos { get; set; }
    }

}