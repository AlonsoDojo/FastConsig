
#region Usings
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Framework;
using Framework.Data;
using System.Runtime.Serialization;
using Newtonsoft.Json;
#endregion

namespace FastConsig.Core.Entity
{
	[Serializable]
	[DataContract]
	public partial class SimulacaoOperacao : EntityBase
	{
		#region Propriedades
		[Key, Identity, DataMember, JsonProperty("Id")]
		public int? Id { get; set; }

		[ForeignKey, DataMember, JsonProperty("Simulacao")]
		public int? Simulacao { get; set; }

		[ForeignKey, DataMember, JsonProperty("Produto")]
		public int? Produto { get; set; }

		[DataMember, JsonProperty("Prazo")]
		public int? Prazo { get; set; }

		[DataLength(18), MaxLength(18), StringLength(18), DataMember, JsonProperty("ValorOperacao")]
		public decimal? ValorOperacao { get; set; }

		[DataLength(12), MaxLength(12), StringLength(12), DataMember, JsonProperty("Taxa")]
		public decimal? Taxa { get; set; }

		[DataLength(12,2), DataMember, JsonProperty("ValorEntrada")]
		public decimal? ValorEntrada { get; set; }

		[DataLength(12,2), DataMember, JsonProperty("ValorParcela")]
		public decimal? ValorParcela { get; set; }

		[DataLength(12,2), DataMember, JsonProperty("ValorTAC")]
		public decimal? ValorTAC { get; set; }

		[DataLength(12,2), DataMember, JsonProperty("ValorTFC")]
		public decimal? ValorTFC { get; set; }

		[DataLength(12,2), DataMember, JsonProperty("ValorPST")]
		public decimal? ValorPST { get; set; }

		[DataLength(12,2), DataMember, JsonProperty("ValorSeguro")]
		public decimal? ValorSeguro { get; set; }

		[DataLength(12,2), DataMember, JsonProperty("ValorIOF")]
		public decimal? ValorIOF { get; set; }

		[DataLength(12,2), DataMember, JsonProperty("ValorIOFNormal")]
		public decimal? ValorIOFNormal { get; set; }

		[DataLength(12,2), DataMember, JsonProperty("ValorIOFAdicional")]
		public decimal? ValorIOFAdicional { get; set; }

		[DataLength(12,2), DataMember, JsonProperty("ValorFinanciadoTotal")]
		public decimal? ValorFinanciadoTotal { get; set; }

		[DataLength(12,2), DataMember, JsonProperty("ValorLiberado")]
		public decimal? ValorLiberado { get; set; }

		[DataLength(15), MaxLength(15), StringLength(15), DataMember, JsonProperty("TaxaMes")]
		public decimal? TaxaMes { get; set; }

		[DataLength(15), MaxLength(15), StringLength(15), DataMember, JsonProperty("TaxaAno")]
		public decimal? TaxaAno { get; set; }

		[DataLength(15), MaxLength(15), StringLength(15), DataMember, JsonProperty("CETMes")]
		public decimal? CETMes { get; set; }

		[DataLength(15), MaxLength(15), StringLength(15), DataMember, JsonProperty("CETAno")]
		public decimal? CETAno { get; set; }

		[DataMember, JsonProperty("DataEmissao")]
		public DateTime? DataEmissao { get; set; }

		[DataMember, JsonProperty("DataPrimeiroVencimento")]
		public DateTime? DataPrimeiroVencimento { get; set; }

		[DataLength(6), MaxLength(6), StringLength(6), DataMember, JsonProperty("RedeLojas")]
		public int? RedeLojas { get; set; }

		[DataLength(4), MaxLength(4), StringLength(4), DataMember, JsonProperty("Loja")]
		public int? Loja { get; set; }

		[DataLength(4), MaxLength(4), StringLength(4), DataMember, JsonProperty("Tabela")]
		public int? Tabela { get; set; }

		[DataMember, JsonProperty("TacFinanciada")]
		public bool TacFinanciada { get; set; }

		[DataMember, JsonProperty("IOFFinaciado")]
		public bool IOFFinaciado { get; set; }

		[DataLength(12,2), DataMember, JsonProperty("ValorGarantia")]
		public decimal? ValorGarantia { get; set; }

		[DataMember, JsonProperty("MetodoAmortizacao")]
		public int? MetodoAmortizacao { get; set; }

		[DataLength(12,6), DataMember, JsonProperty("ValorIndexadorProjetado")]
		public decimal? ValorIndexadorProjetado { get; set; }

		[DataMember, JsonProperty("ObjetivoEmprestimo")]
		public int? ObjetivoEmprestimo { get; set; }

		[DataLength(12,2), DataMember, JsonProperty("ValorMargem")]
		public decimal? ValorMargem { get; set; }

		[DataLength(12,2), DataMember, JsonProperty("ValorRenegociacaoTotal")]
		public decimal? ValorRenegociacaoTotal { get; set; }

		#endregion

		#region Metadados
		public static class METADADO
		{
			public static readonly TableReference tabelaNAME = "SimulacaoOperacao";
			public static readonly FieldReference Id = "SimulacaoOperacao.Id";
			public static readonly FieldReference Simulacao = "SimulacaoOperacao.Simulacao";
			public static readonly FieldReference Produto = "SimulacaoOperacao.Produto";
			public static readonly FieldReference Prazo = "SimulacaoOperacao.Prazo";
			public static readonly FieldReference ValorOperacao = "SimulacaoOperacao.ValorOperacao";
			public static readonly FieldReference Taxa = "SimulacaoOperacao.Taxa";
			public static readonly FieldReference ValorEntrada = "SimulacaoOperacao.ValorEntrada";
			public static readonly FieldReference ValorParcela = "SimulacaoOperacao.ValorParcela";
			public static readonly FieldReference ValorTAC = "SimulacaoOperacao.ValorTAC";
			public static readonly FieldReference ValorTFC = "SimulacaoOperacao.ValorTFC";
			public static readonly FieldReference ValorPST = "SimulacaoOperacao.ValorPST";
			public static readonly FieldReference ValorSeguro = "SimulacaoOperacao.ValorSeguro";
			public static readonly FieldReference ValorIOF = "SimulacaoOperacao.ValorIOF";
			public static readonly FieldReference ValorIOFNormal = "SimulacaoOperacao.ValorIOFNormal";
			public static readonly FieldReference ValorIOFAdicional = "SimulacaoOperacao.ValorIOFAdicional";
			public static readonly FieldReference ValorFinanciadoTotal = "SimulacaoOperacao.ValorFinanciadoTotal";
			public static readonly FieldReference ValorLiberado = "SimulacaoOperacao.ValorLiberado";
			public static readonly FieldReference TaxaMes = "SimulacaoOperacao.TaxaMes";
			public static readonly FieldReference TaxaAno = "SimulacaoOperacao.TaxaAno";
			public static readonly FieldReference CETMes = "SimulacaoOperacao.CETMes";
			public static readonly FieldReference CETAno = "SimulacaoOperacao.CETAno";
			public static readonly FieldReference DataEmissao = "SimulacaoOperacao.DataEmissao";
			public static readonly FieldReference DataPrimeiroVencimento = "SimulacaoOperacao.DataPrimeiroVencimento";
			public static readonly FieldReference RedeLojas = "SimulacaoOperacao.RedeLojas";
			public static readonly FieldReference Loja = "SimulacaoOperacao.Loja";
			public static readonly FieldReference Tabela = "SimulacaoOperacao.Tabela";
			public static readonly FieldReference TacFinanciada = "SimulacaoOperacao.TacFinanciada";
			public static readonly FieldReference IOFFinaciado = "SimulacaoOperacao.IOFFinaciado";
			public static readonly FieldReference ValorGarantia = "SimulacaoOperacao.ValorGarantia";
			public static readonly FieldReference MetodoAmortizacao = "SimulacaoOperacao.MetodoAmortizacao";
			public static readonly FieldReference ValorIndexadorProjetado = "SimulacaoOperacao.ValorIndexadorProjetado";
			public static readonly FieldReference ObjetivoEmprestimo = "SimulacaoOperacao.ObjetivoEmprestimo";
			public static readonly FieldReference ValorMargem = "SimulacaoOperacao.ValorMargem";
			public static readonly FieldReference ValorRenegociacaoTotal = "SimulacaoOperacao.ValorRenegociacaoTotal";
		}
		#endregion
	}
}
