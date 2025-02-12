using FastConsig.Core.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.Consignado.Model.DataPrev
{
   public class ExcluirPortabilidadeModel : PropostaBaseModel
   {
      [JsonProperty("numeroUnico", NullValueHandling = NullValueHandling.Ignore)]
      public long? NumeroUnico { get; set; }

      [JsonProperty("numeroBeneficio", NullValueHandling = NullValueHandling.Ignore)]
      public long? NumeroBeneficio { get; set; }

      [JsonProperty("codigoOrigem", NullValueHandling = NullValueHandling.Ignore)]
      public long? CodigoOrigem { get; set; }

      [JsonProperty("listaContratosExcluidos", NullValueHandling = NullValueHandling.Ignore)]
      public List<ListaContratosExcluido> ListaContratosExcluidos { get; set; }

      [JsonProperty("codigoProponente", NullValueHandling = NullValueHandling.Ignore)]
      public long? CodigoProponente { get; set; }
   }
}
