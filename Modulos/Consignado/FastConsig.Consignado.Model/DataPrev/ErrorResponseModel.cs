using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.Consignado.Model.DataPrev
{
   public class ErrorResponseModel
   {
      [JsonProperty("erros", NullValueHandling = NullValueHandling.Ignore)]
      public List<ErroElement> Erros { get; set; }
   }
}
