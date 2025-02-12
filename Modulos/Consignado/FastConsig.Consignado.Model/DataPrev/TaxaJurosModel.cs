using FastConsig.Core.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.Consignado.Model.DataPrev
{
   public class TaxaJurosModel : PropostaBaseModel
   {
      [JsonProperty("codigoSolicitante")]
      public int codigoSolicitante { get; set; }

      [JsonProperty("valorTaxaMensalMinima")]
      public decimal? ValorTaxaMensalMinima { get; set; }

      [JsonProperty("valorTaxaMensalMaxima")]
      public decimal? ValorTaxaMensalMaxima { get; set; }

      [JsonProperty("valorTaxaMensalMinimaRMC")]
      public decimal? ValorTaxaMensalMinimaRMC { get; set; }

      [JsonProperty("valorTaxaMensalMaximaRMC")]
      public decimal? ValorTaxaMensalMaximaRMC { get; set; }

      [JsonProperty("valorTaxaMensalMinimaRCC")]
      public decimal? ValorTaxaMensalMinimaRCC { get; set; }

      [JsonProperty("valorTaxaMensalMaximaRCC")]
      public decimal? ValorTaxaMensalMaximaRCC { get; set; }

      [JsonProperty("atendimento")]
      public List<Atendimento> Atendimento { get; set; }
   }
}
