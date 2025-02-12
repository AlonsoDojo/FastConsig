using FastConsig.Core.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.Consignado.Model.DataPrev
{
   public class ClassificadorOrigemAverbacao : PropostaBaseModel
   {
      [JsonProperty("codigo", NullValueHandling = NullValueHandling.Ignore)]
      public long? Codigo { get; set; }

      [JsonProperty("descricao", NullValueHandling = NullValueHandling.Ignore)]
      public string Descricao { get; set; }
   }
}
