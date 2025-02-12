using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.Barramento.Model
{
   public class CalculoParcelaRequestModel
   {
      [JsonProperty("cpf", NullValueHandling = NullValueHandling.Ignore)]
      public string cpf { get; set; }

      [JsonProperty("loja", NullValueHandling = NullValueHandling.Ignore)]
      public int? loja { get; set; }

      [JsonProperty("lojista", NullValueHandling = NullValueHandling.Ignore)]
      public int? lojista { get; set; }

      [JsonProperty("plano", NullValueHandling = NullValueHandling.Ignore)]
      public int? plano { get; set; }

      [JsonProperty("produto", NullValueHandling = NullValueHandling.Ignore)]
      public int? produto { get; set; }

      [JsonProperty("empresa", NullValueHandling = NullValueHandling.Ignore)]
      public string empresa { get; set; }

      [JsonProperty("agencia", NullValueHandling = NullValueHandling.Ignore)]
      public string agencia { get; set; }

      [JsonProperty("dataInicio", NullValueHandling = NullValueHandling.Ignore)]
      public string dataInicio { get; set; }

      [JsonProperty("dataPrimeiroVencimento", NullValueHandling = NullValueHandling.Ignore)]
      public string dataPrimeiroVencimento { get; set; }

      [JsonProperty("prazo", NullValueHandling = NullValueHandling.Ignore)]
      public int? prazo { get; set; }

      [JsonProperty("valorSolicitado", NullValueHandling = NullValueHandling.Ignore)]
      public decimal? valorSolicitado { get; set; }

      [JsonProperty("valorEntrada", NullValueHandling = NullValueHandling.Ignore)]
      public decimal? valorEntrada { get; set; }

      [JsonProperty("valorParcela", NullValueHandling = NullValueHandling.Ignore)]
      public decimal? valorParcela { get; set; }

      [JsonProperty("valorSeguro", NullValueHandling = NullValueHandling.Ignore)]
      public decimal? valorSeguro { get; set; }

      [JsonProperty("simplesNacional", NullValueHandling = NullValueHandling.Ignore)]
      public bool simplesNacional { get; set; }

      [JsonProperty("tacFinanciada", NullValueHandling = NullValueHandling.Ignore)]
      public bool tacFinanciada { get; set; }

      [JsonProperty("iofFinanciado", NullValueHandling = NullValueHandling.Ignore)]
      public bool iofFinanciado { get; set; }

      [JsonProperty("contratosReneg", NullValueHandling = NullValueHandling.Ignore)]
      public List<ContratosRenegociacaoModel> contratosReneg { get; set; }

      [JsonProperty("conveniada", NullValueHandling = NullValueHandling.Ignore)]
      public string conveniada { get; set; }

      [JsonProperty("conveniadaOrgao", NullValueHandling = NullValueHandling.Ignore)]
      public string conveniadaOrgao { get; set; }

      [JsonProperty("pagarComissao", NullValueHandling = NullValueHandling.Ignore)]
      public bool pagarComissao { get; set; }
   }
}
