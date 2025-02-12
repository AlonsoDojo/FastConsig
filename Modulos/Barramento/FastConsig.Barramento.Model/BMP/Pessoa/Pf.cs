using Newtonsoft.Json; 
namespace FastConsig.Barramento.Model.BMP.Pessoa{ 

    public class Pf
    {
        [JsonProperty("apelido")]
        public string apelido { get; set; }

        [JsonProperty("rg")]
        public string rg { get; set; }

        [JsonProperty("rgOrgao")]
        public string rgOrgao { get; set; }

        [JsonProperty("rguf")]
        public string rguf { get; set; }

        [JsonProperty("rgData")]
        public string rgData { get; set; }

        [JsonProperty("dtNasc")]
        public string dtNasc { get; set; }

        [JsonProperty("sexo")]
        public string sexo { get; set; }

        [JsonProperty("nacionalidade")]
        public string nacionalidade { get; set; }

        [JsonProperty("naturalDeCidade")]
        public string naturalDeCidade { get; set; }

        [JsonProperty("naturalDeUF")]
        public string naturalDeUF { get; set; }

        [JsonProperty("estadoCivil")]
        public int? estadoCivil { get; set; }

        [JsonProperty("escolaridade")]
        public int? escolaridade { get; set; }

        [JsonProperty("nomeCargo")]
        public string nomeCargo { get; set; }

        [JsonProperty("tipoOcupacao")]
        public int? tipoOcupacao { get; set; }

        [JsonProperty("outrasRendas")]
        public string outrasRendas { get; set; }

        [JsonProperty("vlrOutrasRendas")]
        public long? vlrOutrasRendas { get; set; }

        [JsonProperty("nomePai")]
        public string nomePai { get; set; }

        [JsonProperty("telefonePai")]
        public string telefonePai { get; set; }

        [JsonProperty("emailPai")]
        public string emailPai { get; set; }

        [JsonProperty("nomeMae")]
        public string nomeMae { get; set; }

        [JsonProperty("telefoneMae")]
        public string telefoneMae { get; set; }

        [JsonProperty("emailMae")]
        public string emailMae { get; set; }

        [JsonProperty("nomeConjuge")]
        public string nomeConjuge { get; set; }

        [JsonProperty("dtNascConjuge")]
        public string dtNascConjuge { get; set; }

        [JsonProperty("telefoneFixoConjuge")]
        public string telefoneFixoConjuge { get; set; }

        [JsonProperty("telefoneCelularConjuge")]
        public string telefoneCelularConjuge { get; set; }

        [JsonProperty("emailConjuge")]
        public string emailConjuge { get; set; }

        [JsonProperty("tempoCasadoConjuge")]
        public int? tempoCasadoConjuge { get; set; }

        [JsonProperty("cpfConjuge")]
        public string cpfConjuge { get; set; }

        [JsonProperty("rgConjuge")]
        public string rgConjuge { get; set; }

        [JsonProperty("rgOrgaoConjuge")]
        public string rgOrgaoConjuge { get; set; }

        [JsonProperty("rgufConjuge")]
        public string rgufConjuge { get; set; }

        [JsonProperty("rgDataConjuge")]
        public string rgDataConjuge { get; set; }

        [JsonProperty("mostrarConjugeCCB")]
        public bool? mostrarConjugeCCB { get; set; }

        [JsonProperty("fielDepositario")]
        public bool? fielDepositario { get; set; }

        [JsonProperty("terceiroGarantidor")]
        public bool? terceiroGarantidor { get; set; }
    }

}