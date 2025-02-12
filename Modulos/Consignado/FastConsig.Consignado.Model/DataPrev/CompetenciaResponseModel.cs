using FastConsig.Core.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.Consignado.Model.DataPrev
{
   public class CompetenciaResponseModel : PropostaBaseModel
   {
      [JsonProperty("competenciaConsulta", NullValueHandling = NullValueHandling.Ignore)]
      public long? CompetenciaConsulta { get; set; }

      [JsonProperty("dataLimiteAverbacao", NullValueHandling = NullValueHandling.Ignore)]
      public string DataLimiteAverbacao { get; set; }

      [JsonProperty("dataLimiteOperacoes", NullValueHandling = NullValueHandling.Ignore)]
      public long? DataLimiteOperacoes { get; set; }

      [JsonProperty("competenciaAtual", NullValueHandling = NullValueHandling.Ignore)]
      public long? CompetenciaAtual { get; set; }

      [JsonProperty("processandoFolha", NullValueHandling = NullValueHandling.Ignore)]
      public bool? ProcessandoFolha { get; set; }

      [JsonProperty("competenciaMinimaAverbacao", NullValueHandling = NullValueHandling.Ignore)]
      public long? CompetenciaMinimaAverbacao { get; set; }

      [JsonProperty("competenciaDemaisOperacoes", NullValueHandling = NullValueHandling.Ignore)]
      public long? CompetenciaDemaisOperacoes { get; set; }

      /// <summary>
      /// Somente para tratar resposta de erro
      /// </summary>
      public CompetenciaErroModel Error { get; set; }
   }
}
