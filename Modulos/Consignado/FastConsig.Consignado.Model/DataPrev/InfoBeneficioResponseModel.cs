using FastConsig.Core.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.Consignado.Model.DataPrev
{
   public class InfoBeneficioResponseModel : PropostaBaseModel
   {
      [JsonProperty("numeroBeneficio", NullValueHandling = NullValueHandling.Ignore)]
      public long? NumeroBeneficio { get; set; }

      [JsonProperty("cpf", NullValueHandling = NullValueHandling.Ignore)]
      public long? Cpf { get; set; }

      [JsonProperty("dataNascimento", NullValueHandling = NullValueHandling.Ignore)]
      public string DataNascimento { get; set; }

      [JsonProperty("nomeBeneficiario", NullValueHandling = NullValueHandling.Ignore)]
      public string NomeBeneficiario { get; set; }

      [JsonProperty("situacaoBeneficio", NullValueHandling = NullValueHandling.Ignore)]
      public EspecieBeneficio SituacaoBeneficio { get; set; }

      [JsonProperty("especieBeneficio", NullValueHandling = NullValueHandling.Ignore)]
      public EspecieBeneficio EspecieBeneficio { get; set; }

      [JsonProperty("concessaoJudicial", NullValueHandling = NullValueHandling.Ignore)]
      public bool? ConcessaoJudicial { get; set; }

      [JsonProperty("ufPagamento", NullValueHandling = NullValueHandling.Ignore)]
      public string UfPagamento { get; set; }

      [JsonProperty("tipoCredito", NullValueHandling = NullValueHandling.Ignore)]
      public EspecieBeneficio TipoCredito { get; set; }

      [JsonProperty("cbcIfPagadora", NullValueHandling = NullValueHandling.Ignore)]
      public long? CbcIfPagadora { get; set; }

      [JsonProperty("agenciaPagadora", NullValueHandling = NullValueHandling.Ignore)]
      public long? AgenciaPagadora { get; set; }

      [JsonProperty("contaCorrente", NullValueHandling = NullValueHandling.Ignore)]
      public string ContaCorrente { get; set; }

      [JsonProperty("possuiRepresentanteLegal", NullValueHandling = NullValueHandling.Ignore)]
      public bool? PossuiRepresentanteLegal { get; set; }

      [JsonProperty("possuiProcurador", NullValueHandling = NullValueHandling.Ignore)]
      public bool? PossuiProcurador { get; set; }

      [JsonProperty("possuiEntidadeRepresentacao", NullValueHandling = NullValueHandling.Ignore)]
      public bool? PossuiEntidadeRepresentacao { get; set; }

      [JsonProperty("pensaoAlimenticia", NullValueHandling = NullValueHandling.Ignore)]
      public EspecieBeneficio PensaoAlimenticia { get; set; }

      [JsonProperty("bloqueadoParaEmprestimo", NullValueHandling = NullValueHandling.Ignore)]
      public bool? BloqueadoParaEmprestimo { get; set; }

      [JsonProperty("dataDespachoBeneficio", NullValueHandling = NullValueHandling.Ignore)]
      public long? DataDespachoBeneficio { get; set; }

      [JsonProperty("margemDisponivel", NullValueHandling = NullValueHandling.Ignore)]
      public long? MargemDisponivel { get; set; }

      [JsonProperty("margemDisponivelCartao", NullValueHandling = NullValueHandling.Ignore)]
      public long? MargemDisponivelCartao { get; set; }

      [JsonProperty("valorLimiteCartao", NullValueHandling = NullValueHandling.Ignore)]
      public long? ValorLimiteCartao { get; set; }

      [JsonProperty("qtdEmprestimosAtivosSuspensos", NullValueHandling = NullValueHandling.Ignore)]
      public long? QtdEmprestimosAtivosSuspensos { get; set; }

      [JsonProperty("qtdEmprestimosAtivos", NullValueHandling = NullValueHandling.Ignore)]
      public long? QtdEmprestimosAtivos { get; set; }

      [JsonProperty("qtdEmprestimosSuspensos", NullValueHandling = NullValueHandling.Ignore)]
      public long? QtdEmprestimosSuspensos { get; set; }

      [JsonProperty("qtdEmprestimosRefin", NullValueHandling = NullValueHandling.Ignore)]
      public long? QtdEmprestimosRefin { get; set; }

      [JsonProperty("qtdEmprestimosPorta", NullValueHandling = NullValueHandling.Ignore)]
      public long? QtdEmprestimosPorta { get; set; }

      [JsonProperty("dataConsulta", NullValueHandling = NullValueHandling.Ignore)]
      public long DataConsulta { get; set; }

      [JsonProperty("elegivelEmprestimo", NullValueHandling = NullValueHandling.Ignore)]
      public bool? ElegivelEmprestimo { get; set; }

      [JsonProperty("margemDisponivelRCC", NullValueHandling = NullValueHandling.Ignore)]
      public decimal? MargemDisponivelRcc { get; set; }

      [JsonProperty("valorLimiteRCC", NullValueHandling = NullValueHandling.Ignore)]
      public decimal? ValorLimiteRcc { get; set; }

      [JsonProperty("valorLiquido", NullValueHandling = NullValueHandling.Ignore)]
      public decimal? ValorLiquido { get; set; }

      public InfoBeneficioErroModel Error { get; set; }
   }
}
