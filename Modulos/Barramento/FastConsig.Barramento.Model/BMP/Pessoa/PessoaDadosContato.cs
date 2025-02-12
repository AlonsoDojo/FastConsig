using Newtonsoft.Json; 
namespace FastConsig.Barramento.Model.BMP.Pessoa{ 

    public class PessoaDadosContato
    {
        [JsonProperty("email")]
        public string email { get; set; }

        [JsonProperty("telefoneFixo1")]
        public string telefoneFixo1 { get; set; }

        [JsonProperty("telefoneFixo2")]
        public string telefoneFixo2 { get; set; }

        [JsonProperty("telefoneCelular1")]
        public string telefoneCelular1 { get; set; }

        [JsonProperty("telefoneCelular2")]
        public string telefoneCelular2 { get; set; }

        [JsonProperty("telefoneFax")]
        public string telefoneFax { get; set; }

        [JsonProperty("paginaWeb")]
        public string paginaWeb { get; set; }
    }

}