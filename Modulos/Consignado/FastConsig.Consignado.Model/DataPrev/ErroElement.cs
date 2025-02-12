using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.Consignado.Model.DataPrev
{
   public class ErroElement
   {
      [JsonProperty("codigo", NullValueHandling = NullValueHandling.Ignore)]
      public string Codigo { get; set; }

      [JsonProperty("mensagem", NullValueHandling = NullValueHandling.Ignore)]
      public string Mensagem { get; set; }
   }
}
