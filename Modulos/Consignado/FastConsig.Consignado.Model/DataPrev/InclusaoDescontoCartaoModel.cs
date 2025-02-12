using FastConsig.Core.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.Consignado.Model.DataPrev
{
   public class InclusaoDescontoCartaoModel : PropostaBaseModel
   {
      [JsonProperty("numeroBeneficio", NullValueHandling = NullValueHandling.Ignore)]
      public long? NumeroBeneficio { get; set; }

      [JsonProperty("codigoSolicitante", NullValueHandling = NullValueHandling.Ignore)]
      public long? CodigoSolicitante { get; set; }

      [JsonProperty("numeroContrato", NullValueHandling = NullValueHandling.Ignore)]
      public string NumeroContrato { get; set; }

      [JsonProperty("valorSaldoLimiteCartao", NullValueHandling = NullValueHandling.Ignore)]
      public long? ValorSaldoLimiteCartao { get; set; }

      [JsonProperty("valorUtilizadoMesCartao", NullValueHandling = NullValueHandling.Ignore)]
      public long? ValorUtilizadoMesCartao { get; set; }

      [JsonProperty("valorDesconto", NullValueHandling = NullValueHandling.Ignore)]
      public long? ValorDesconto { get; set; }

      [JsonProperty("valorIOF", NullValueHandling = NullValueHandling.Ignore)]
      public double? ValorIof { get; set; }

      [JsonProperty("valorTaxaAnual", NullValueHandling = NullValueHandling.Ignore)]
      public double? ValorTaxaAnual { get; set; }

      [JsonProperty("valorCETAnual", NullValueHandling = NullValueHandling.Ignore)]
      public long? ValorCetAnual { get; set; }
   }
}
