using FastConsig.Core.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.Consignado.Model.DataPrev
{
   public class ExclusaoDescontoCartaoModel : PropostaBaseModel
   {

      [JsonProperty("numeroBeneficio")]
      public long NumeroBeneficio { get; set; }

      [JsonProperty("codigoSolicitante")]
      public long CodigoSolicitante { get; set; }

      [JsonProperty("numeroContrato")]
      public string NumeroContrato { get; set; }

      [JsonProperty("motivoExclusao")]
      public long MotivoExclusao { get; set; }
   }
}
