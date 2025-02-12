using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.Consignado.Model.DataPrev
{
   public class Atendimento
   {
      [JsonProperty("nome")]
      public string Nome { get; set; }

      [JsonProperty("descricao")]
      public string Descricao { get; set; }
   }
}
