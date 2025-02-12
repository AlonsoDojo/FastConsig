using Newtonsoft.Json;

namespace FastConsig.Core.Model
{
   public class PropostaBaseModel
   {
      [JsonIgnore]
      public int? Proposta { get; set; }

      [JsonIgnore]
      public int? Simulacao { get; set; }

      [JsonIgnore]
      public long? CpfCnpj { get; set; }

      [JsonIgnore]
      public int? Fase { get; set; }
   }
}
