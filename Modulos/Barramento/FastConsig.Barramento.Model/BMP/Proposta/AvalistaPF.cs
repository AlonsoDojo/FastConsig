using Newtonsoft.Json; 
using System; 
namespace FastConsig.Barramento.Model.BMP.Proposta{ 

    public class AvalistaPF
    {
        [JsonProperty("rg")]
        public string rg { get; set; }

        [JsonProperty("rgOrgao")]
        public string rgOrgao { get; set; }

        [JsonProperty("rguf")]
        public string rguf { get; set; }

        [JsonProperty("rgData")]
        public DateTime? rgData { get; set; }

        [JsonProperty("nomePai")]
        public string nomePai { get; set; }

        [JsonProperty("nomeMae")]
        public string nomeMae { get; set; }

        [JsonProperty("estadoCivil")]
        public int? estadoCivil { get; set; }

        [JsonProperty("sexo")]
        public string sexo { get; set; }

        [JsonProperty("nroDependentes")]
        public int? nroDependentes { get; set; }

        [JsonProperty("telefoneFixo")]
        public string telefoneFixo { get; set; }

        [JsonProperty("telefoneCelular")]
        public string telefoneCelular { get; set; }

        [JsonProperty("dtNasc")]
        public DateTime? dtNasc { get; set; }

        [JsonProperty("email")]
        public string email { get; set; }

        [JsonProperty("localTrabalho")]
        public string localTrabalho { get; set; }

        [JsonProperty("cnpjTrabalho")]
        public string cnpjTrabalho { get; set; }

        [JsonProperty("cargoTrabalho")]
        public string cargoTrabalho { get; set; }

        [JsonProperty("vlrRendimentoTrabalho")]
        public int? vlrRendimentoTrabalho { get; set; }

        [JsonProperty("vlrOutrosRendimentos")]
        public int? vlrOutrosRendimentos { get; set; }

        [JsonProperty("obsOutrosRendimentos")]
        public string obsOutrosRendimentos { get; set; }

        [JsonProperty("cepTrabalho")]
        public string cepTrabalho { get; set; }

        [JsonProperty("logradouroTrabalho")]
        public string logradouroTrabalho { get; set; }

        [JsonProperty("nroLogradouroTrabalho")]
        public string nroLogradouroTrabalho { get; set; }

        [JsonProperty("bairroTrabalho")]
        public string bairroTrabalho { get; set; }

        [JsonProperty("complementoTrabalho")]
        public string complementoTrabalho { get; set; }

        [JsonProperty("cidadeTrabalho")]
        public string cidadeTrabalho { get; set; }

        [JsonProperty("ufTrabalho")]
        public string ufTrabalho { get; set; }

        [JsonProperty("telefoneFixoTrabalho")]
        public string telefoneFixoTrabalho { get; set; }

        [JsonProperty("telefoneCelularTrabalho")]
        public string telefoneCelularTrabalho { get; set; }

        [JsonProperty("emailTrabalho")]
        public string emailTrabalho { get; set; }

        [JsonProperty("nomeConjuge")]
        public string nomeConjuge { get; set; }

        [JsonProperty("cpfConjuge")]
        public string cpfConjuge { get; set; }

        [JsonProperty("rgConjuge")]
        public string rgConjuge { get; set; }

        [JsonProperty("rgOrgaoConjuge")]
        public string rgOrgaoConjuge { get; set; }

        [JsonProperty("rgufConjuge")]
        public string rgufConjuge { get; set; }

        [JsonProperty("rgDataConjuge")]
        public DateTime? rgDataConjuge { get; set; }

        [JsonProperty("localTrabalhoConjuge")]
        public string localTrabalhoConjuge { get; set; }

        [JsonProperty("vlrRendimentoTrabalhoConjuge")]
        public int? vlrRendimentoTrabalhoConjuge { get; set; }

        [JsonProperty("vlrOutrosRendimentosConjuge")]
        public int? vlrOutrosRendimentosConjuge { get; set; }

        [JsonProperty("obsOutrosRendimentosConjuge")]
        public string obsOutrosRendimentosConjuge { get; set; }

        [JsonProperty("refBanco1Nome")]
        public string refBanco1Nome { get; set; }

        [JsonProperty("refBanco1Agencia")]
        public string refBanco1Agencia { get; set; }

        [JsonProperty("refBanco1Conta")]
        public string refBanco1Conta { get; set; }

        [JsonProperty("refBanco1DtAbertura")]
        public DateTime? refBanco1DtAbertura { get; set; }

        [JsonProperty("refBanco1Gerente")]
        public string refBanco1Gerente { get; set; }

        [JsonProperty("refBanco1Telefone")]
        public string refBanco1Telefone { get; set; }

        [JsonProperty("refBanco2Nome")]
        public string refBanco2Nome { get; set; }

        [JsonProperty("refBanco2Agencia")]
        public string refBanco2Agencia { get; set; }

        [JsonProperty("refBanco2Conta")]
        public string refBanco2Conta { get; set; }

        [JsonProperty("refBanco2DtAbertura")]
        public DateTime? refBanco2DtAbertura { get; set; }

        [JsonProperty("refBanco2Gerente")]
        public string refBanco2Gerente { get; set; }

        [JsonProperty("refBanco2Telefone")]
        public string refBanco2Telefone { get; set; }

        [JsonProperty("refComercial1Nome")]
        public string refComercial1Nome { get; set; }

        [JsonProperty("refComercial1Parentesco")]
        public string refComercial1Parentesco { get; set; }

        [JsonProperty("refComercial1Telefone")]
        public string refComercial1Telefone { get; set; }

        [JsonProperty("refComercial2Nome")]
        public string refComercial2Nome { get; set; }

        [JsonProperty("refComercial2Parentesco")]
        public string refComercial2Parentesco { get; set; }

        [JsonProperty("refComercial2Telefone")]
        public string refComercial2Telefone { get; set; }

        [JsonProperty("refComercial3Nome")]
        public string refComercial3Nome { get; set; }

        [JsonProperty("refComercial3Parentesco")]
        public string refComercial3Parentesco { get; set; }

        [JsonProperty("refComercial3Telefone")]
        public string refComercial3Telefone { get; set; }

        [JsonProperty("patrimonio1Descricao")]
        public string patrimonio1Descricao { get; set; }

        [JsonProperty("patrimonio1Valor")]
        public int? patrimonio1Valor { get; set; }

        [JsonProperty("patrimonio2Descricao")]
        public string patrimonio2Descricao { get; set; }

        [JsonProperty("patrimonio2Valor")]
        public int? patrimonio2Valor { get; set; }

        [JsonProperty("patrimonio3Descricao")]
        public string patrimonio3Descricao { get; set; }

        [JsonProperty("patrimonio3Valor")]
        public int? patrimonio3Valor { get; set; }

        [JsonProperty("telefoneFixoConjuge")]
        public string telefoneFixoConjuge { get; set; }

        [JsonProperty("telefoneCelularConjuge")]
        public string telefoneCelularConjuge { get; set; }

        [JsonProperty("emailConjuge")]
        public string emailConjuge { get; set; }

        [JsonProperty("mostrarConjugeCCB")]
        public bool? mostrarConjugeCCB { get; set; }

        [JsonProperty("naturalDeCidade")]
        public string naturalDeCidade { get; set; }

        [JsonProperty("naturalDeUF")]
        public string naturalDeUF { get; set; }

        [JsonProperty("nacionalidade")]
        public string nacionalidade { get; set; }
    }

}