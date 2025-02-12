using Newtonsoft.Json; 
namespace FastConsig.Barramento.Model.BMP.Proposta{ 

    public class Avalista
    {
        [JsonProperty("nome")]
        public string nome { get; set; }

        [JsonProperty("documentoFederal")]
        public string documentoFederal { get; set; }

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

        [JsonProperty("avalistaPF")]
        public AvalistaPF avalistaPF { get; set; }

        [JsonProperty("avalistaPJ")]
        public AvalistaPJ avalistaPJ { get; set; }
    }

}