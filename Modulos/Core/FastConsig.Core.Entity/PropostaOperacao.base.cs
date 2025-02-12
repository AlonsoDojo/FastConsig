
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
	public partial class PropostaOperacao : EntityBase
	{
		#region Propriedades
		[DataMember, JsonProperty("Proposta")]
		public int? Proposta { get; set; }

		[Identity, DataMember, JsonProperty("Operacao")]
		public int? Operacao { get; set; }

		[DataMember, JsonProperty("Produto")]
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

		[DataMember, JsonProperty("IdSimulacao")]
		public int? Simulacao { get; set; }

		[DataMember, JsonProperty("MeioLiberacao")]
		public int? MeioLiberacao { get; set; }

		[DataLength(4), MaxLength(4), StringLength(4), DataMember, JsonProperty("Banco")]
		public string Banco { get; set; }

		[DataLength(4), MaxLength(4), StringLength(4), DataMember, JsonProperty("Agencia")]
		public string Agencia { get; set; }

		[DataLength(15), MaxLength(15), StringLength(15), DataMember, JsonProperty("Conta")]
		public string Conta { get; set; }

		[DataLength(50), MaxLength(50), StringLength(50), DataMember, JsonProperty("PropostaLegado")]
		public string PropostaLegado { get; set; }

		[DataLength(50), MaxLength(50), StringLength(50), DataMember, JsonProperty("ContratoLegado")]
		public string ContratoLegado { get; set; }

		[DataMember, JsonProperty("RedeLojas")]
		public int? RedeLojas { get; set; }

		[DataMember, JsonProperty("Loja")]
		public int? Loja { get; set; }

		[DataMember, JsonProperty("Tabela")]
		public int? Tabela { get; set; }

		[DataMember, JsonProperty("TacFinanciada")]
		public bool TacFinanciada { get; set; }

		[DataMember, JsonProperty("IOFFinaciado")]
		public bool IOFFinaciado { get; set; }

		[DataMember, JsonProperty("EspecieBeneficio")]
		public int? EspecieBeneficio { get; set; }

		[DataLength(15), MaxLength(15), StringLength(15), DataMember, JsonProperty("ComprometimentoRenda")]
		public string ComprometimentoRenda { get; set; }

		[DataMember, JsonProperty("Autorizacao")]
		public int? Autorizacao { get; set; }

		[DataLength(12,2), DataMember, JsonProperty("ValorMargem")]
		public decimal? ValorMargem { get; set; }

		[DataLength(12,2), DataMember, JsonProperty("ValorRenegociacaoTotal")]
		public decimal? ValorRenegociacaoTotal { get; set; }

		[DataMember, JsonProperty("MeioLiquidacao")]
		public int? MeioLiquidacao { get; set; }

		[DataLength(4), MaxLength(4), StringLength(4), DataMember, JsonProperty("BancoLiquidacao")]
		public string BancoLiquidacao { get; set; }

		[DataLength(4), MaxLength(4), StringLength(4), DataMember, JsonProperty("AgenciaLiquidacao")]
		public string AgenciaLiquidacao { get; set; }

		[DataLength(15), MaxLength(15), StringLength(15), DataMember, JsonProperty("ContaLiquidacao")]
		public string ContaLiquidacao { get; set; }

      [DataLength(15), MaxLength(15), StringLength(15), DataMember, JsonProperty("ChavePIX")]
      public string ChavePIX { get; set; }
      #endregion

      #region Metadados
      public static class METADADO
		{
			public static readonly TableReference tabelaNAME = "PropostaOperacao";
			public static readonly FieldReference Proposta = "PropostaOperacao.Proposta";
			public static readonly FieldReference Operacao = "PropostaOperacao.Operacao";
			public static readonly FieldReference Produto = "PropostaOperacao.Produto";
			public static readonly FieldReference Prazo = "PropostaOperacao.Prazo";
			public static readonly FieldReference ValorOperacao = "PropostaOperacao.ValorOperacao";
			public static readonly FieldReference Taxa = "PropostaOperacao.Taxa";
			public static readonly FieldReference ValorEntrada = "PropostaOperacao.ValorEntrada";
			public static readonly FieldReference ValorParcela = "PropostaOperacao.ValorParcela";
			public static readonly FieldReference ValorTAC = "PropostaOperacao.ValorTAC";
			public static readonly FieldReference ValorTFC = "PropostaOperacao.ValorTFC";
			public static readonly FieldReference ValorPST = "PropostaOperacao.ValorPST";
			public static readonly FieldReference ValorSeguro = "PropostaOperacao.ValorSeguro";
			public static readonly FieldReference ValorIOF = "PropostaOperacao.ValorIOF";
			public static readonly FieldReference ValorIOFNormal = "PropostaOperacao.ValorIOFNormal";
			public static readonly FieldReference ValorIOFAdicional = "PropostaOperacao.ValorIOFAdicional";
			public static readonly FieldReference ValorFinanciadoTotal = "PropostaOperacao.ValorFinanciadoTotal";
			public static readonly FieldReference ValorLiberado = "PropostaOperacao.ValorLiberado";
			public static readonly FieldReference TaxaMes = "PropostaOperacao.TaxaMes";
			public static readonly FieldReference TaxaAno = "PropostaOperacao.TaxaAno";
			public static readonly FieldReference CETMes = "PropostaOperacao.CETMes";
			public static readonly FieldReference CETAno = "PropostaOperacao.CETAno";
			public static readonly FieldReference DataEmissao = "PropostaOperacao.DataEmissao";
			public static readonly FieldReference DataPrimeiroVencimento = "PropostaOperacao.DataPrimeiroVencimento";
			public static readonly FieldReference Simulacao = "PropostaOperacao.Simulacao";
			public static readonly FieldReference MeioLiberacao = "PropostaOperacao.MeioLiberacao";
			public static readonly FieldReference Banco = "PropostaOperacao.Banco";
			public static readonly FieldReference Agencia = "PropostaOperacao.Agencia";
			public static readonly FieldReference Conta = "PropostaOperacao.Conta";
			public static readonly FieldReference PropostaLegado = "PropostaOperacao.PropostaLegado";
			public static readonly FieldReference ContratoLegado = "PropostaOperacao.ContratoLegado";
			public static readonly FieldReference RedeLojas = "PropostaOperacao.RedeLojas";
			public static readonly FieldReference Loja = "PropostaOperacao.Loja";
			public static readonly FieldReference Tabela = "PropostaOperacao.Tabela";
			public static readonly FieldReference TacFinanciada = "PropostaOperacao.TacFinanciada";
			public static readonly FieldReference IOFFinaciado = "PropostaOperacao.IOFFinaciado";
			public static readonly FieldReference EspecieBeneficio = "PropostaOperacao.EspecieBeneficio";
			public static readonly FieldReference ComprometimentoRenda = "PropostaOperacao.ComprometimentoRenda";
			public static readonly FieldReference Autorizacao = "PropostaOperacao.Autorizacao";
			public static readonly FieldReference ValorMargem = "PropostaOperacao.ValorMargem";
			public static readonly FieldReference ValorRenegociacaoTotal = "PropostaOperacao.ValorRenegociacaoTotal";
			public static readonly FieldReference MeioLiquidacao = "PropostaOperacao.MeioLiquidacao";
			public static readonly FieldReference BancoLiquidacao = "PropostaOperacao.BancoLiquidacao";
			public static readonly FieldReference AgenciaLiquidacao = "PropostaOperacao.AgenciaLiquidacao";
			public static readonly FieldReference ContaLiquidacao = "PropostaOperacao.ContaLiquidacao";
         public static readonly FieldReference ChavePIX = "PropostaOperacao.ChavePIX";
      }
		#endregion
	}
}
