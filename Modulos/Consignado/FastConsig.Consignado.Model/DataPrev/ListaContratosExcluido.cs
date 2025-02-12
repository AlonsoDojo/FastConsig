using FastConsig.Core.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.Consignado.Model.DataPrev
{
   public class ListaContratosExcluido : PropostaBaseModel
   {
      [JsonProperty("numeroContrato", NullValueHandling = NullValueHandling.Ignore)]
      public string NumeroContrato { get; set; }

      [JsonProperty("ultimaParcelaPaga", NullValueHandling = NullValueHandling.Ignore)]
      public string UltimaParcelaPaga { get; set; }
   }
}
