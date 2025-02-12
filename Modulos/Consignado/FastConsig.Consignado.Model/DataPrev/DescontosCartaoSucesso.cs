using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.Consignado.Model.DataPrev
{
   public partial class DescontosCartaoSucesso
   {
      [JsonProperty("competenciaExclusao", NullValueHandling = NullValueHandling.Ignore)]
      public long? CompetenciaExclusao { get; set; }

      [JsonProperty("numeroBeneficio", NullValueHandling = NullValueHandling.Ignore)]
      public long? NumeroBeneficio { get; set; }

      [JsonProperty("codigoSolicitante", NullValueHandling = NullValueHandling.Ignore)]
      public long? CodigoSolicitante { get; set; }

      [JsonProperty("numeroContrato", NullValueHandling = NullValueHandling.Ignore)]
      public string NumeroContrato { get; set; }

      [JsonProperty("codigoSucesso", NullValueHandling = NullValueHandling.Ignore)]
      public string CodigoSucesso { get; set; }

      [JsonProperty("mensagem", NullValueHandling = NullValueHandling.Ignore)]
      public string Mensagem { get; set; }

      [JsonProperty("hashOperacao", NullValueHandling = NullValueHandling.Ignore)]
      public long? HashOperacao { get; set; }
   }
}
