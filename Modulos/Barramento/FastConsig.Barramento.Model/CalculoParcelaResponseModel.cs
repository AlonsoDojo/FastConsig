using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.Barramento.Model
{
   public class CalculoParcelaResponseModel
   {
      [JsonProperty("errors")]
      public List<CalculoParcelaResponseErrorModel> errors { get; set; }

      [JsonProperty("prazo")]
      public int? prazo { get; set; }

      [JsonProperty("valorEntrada")]
      public decimal? valorEntrada { get; set; }

      [JsonProperty("valorSolicitado")]
      public decimal? valorSolicitado { get; set; }

      [JsonProperty("valorParcela")]
      public decimal? valorParcela { get; set; }

      [JsonProperty("valorTAC")]
      public decimal? valorTAC { get; set; }

      [JsonProperty("valorTFC")]
      public decimal? valorTFC { get; set; }

      [JsonProperty("valorPST")]
      public decimal? valorPST { get; set; }

      [JsonProperty("valorSeguro")]
      public decimal? valorSeguro { get; set; }

      [JsonProperty("valorIOF")]
      public decimal? valorIOF { get; set; }

      [JsonProperty("valorIOFNormal")]
      public decimal? valorIOFNormal { get; set; }

      [JsonProperty("valorIOFAdicional")]
      public decimal? valorIOFAdicional { get; set; }

      [JsonProperty("valorFinanciadoTotal")]
      public decimal? valorFinanciadoTotal { get; set; }

      [JsonProperty("valorLiberado")]
      public decimal? valorLiberado { get; set; }

      [JsonProperty("valorRenegociacaoTotal")]
      public decimal? valorRenegociacaoTotal { get; set; }

      [JsonProperty("taxaMes")]
      public decimal? taxaMes { get; set; }

      [JsonProperty("taxaAno")]
      public decimal? taxaAno { get; set; }

      [JsonProperty("cetMes")]
      public decimal? cetMes { get; set; }

      [JsonProperty("cetAno")]
      public decimal? cetAno { get; set; }

      [JsonProperty("dataEmissao")]
      public DateTime? dataEmissao { get; set; }

      [JsonProperty("dataPrimeiroVencimento")]
      public DateTime? dataPrimeiroVencimento { get; set; }

      [JsonProperty("renegociacoes")]
      public List<ContratosRenegociacaoResponseModel> renegociacoes { get; set; }

      [JsonProperty("idSimulacao")]
      public int? idSimulacao { get; set; }
   }
}
