using Newtonsoft.Json; 
using System; 
namespace FastConsig.Barramento.Model.BMP.Proposta{ 

    public class AssinanteRequest
    {
        [JsonProperty("nome")]
        public string nome { get; set; }

        [JsonProperty("email")]
        public string email { get; set; }

        [JsonProperty("documento")]
        public string documento { get; set; }

        [JsonProperty("descricao")]
        public string descricao { get; set; }

        [JsonProperty("telefoneCelular")]
        public string telefoneCelular { get; set; }

        [JsonProperty("notificarPorEmail")]
        public bool? notificarPorEmail { get; set; }

        [JsonProperty("notificarPorWhatsApp")]
        public bool? notificarPorWhatsApp { get; set; }

        [JsonProperty("dtAssinatura")]
        public DateTime? dtAssinatura { get; set; }

        [JsonProperty("ipAssinatura")]
        public string ipAssinatura { get; set; }
    }

}