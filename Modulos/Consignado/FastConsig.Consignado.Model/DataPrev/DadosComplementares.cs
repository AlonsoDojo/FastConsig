using FastConsig.Core.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.Consignado.Model.DataPrev
{
   public class DadosComplementares : PropostaBaseModel
   {
      [JsonProperty("competenciaInicioDesconto", NullValueHandling = NullValueHandling.Ignore)]
      public long? CompetenciaInicioDesconto { get; set; }

      [JsonProperty("dataInicioContrato", NullValueHandling = NullValueHandling.Ignore)]
      public string DataInicioContrato { get; set; }

      [JsonProperty("dataFimContrato", NullValueHandling = NullValueHandling.Ignore)]
      public string DataFimContrato { get; set; }

      [JsonProperty("numeroParcelas", NullValueHandling = NullValueHandling.Ignore)]
      public long? NumeroParcelas { get; set; }

      [JsonProperty("valorLiberado", NullValueHandling = NullValueHandling.Ignore)]
      public long? ValorLiberado { get; set; }

      [JsonProperty("valorEmprestimo", NullValueHandling = NullValueHandling.Ignore)]
      public long? ValorEmprestimo { get; set; }

      [JsonProperty("valorParcela", NullValueHandling = NullValueHandling.Ignore)]
      public long? ValorParcela { get; set; }

      [JsonProperty("valorIOF", NullValueHandling = NullValueHandling.Ignore)]
      public double? ValorIof { get; set; }
   }
}
