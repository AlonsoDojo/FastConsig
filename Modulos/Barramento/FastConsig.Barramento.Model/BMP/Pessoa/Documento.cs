using Newtonsoft.Json; 
using System; 
namespace FastConsig.Barramento.Model.BMP.Pessoa{ 

    public class Documento
    {
        [JsonProperty("codigo")]
        public string codigo { get; set; }

        [JsonProperty("tipoDocumento")]
        public int? tipoDocumento { get; set; }

        [JsonProperty("nomeArquivo")]
        public string nomeArquivo { get; set; }

        [JsonProperty("extensao")]
        public string extensao { get; set; }

        [JsonProperty("dtValidade")]
        public DateTime? dtValidade { get; set; }

        [JsonProperty("arquivo")]
        public string arquivo { get; set; }
    }

}