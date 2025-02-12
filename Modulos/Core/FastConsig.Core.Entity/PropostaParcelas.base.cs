
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
	public partial class PropostaParcelas : EntityBase
	{
		#region Propriedades
		[Key, Identity, DataMember, JsonProperty("Id")]
		public int? Id { get; set; }

		[DataMember, JsonProperty("Proposta")]
		public int? Proposta { get; set; }

		[DataMember, JsonProperty("Operacao")]
		public int? Operacao { get; set; }

		[DataMember, JsonProperty("DataVencimento")]
		public DateTime? DataVencimento { get; set; }

		[DataLength(12,2), DataMember, JsonProperty("ValorLimite")]
		public decimal? ValorLimite { get; set; }

		[DataLength(12,2), DataMember, JsonProperty("ValorParcela")]
		public decimal? ValorParcela { get; set; }

		[DataLength(12,2), DataMember, JsonProperty("ValorRepasse")]
		public decimal? ValorRepasse { get; set; }

		[DataLength(12,2), DataMember, JsonProperty("IofNormal")]
		public decimal? IofNormal { get; set; }

		[DataLength(12,2), DataMember, JsonProperty("IofAdicional")]
		public decimal? IofAdicional { get; set; }

		[DataLength(12,2), DataMember, JsonProperty("Principal")]
		public decimal? Principal { get; set; }

		[DataLength(12,2), DataMember, JsonProperty("Renda")]
		public decimal? Renda { get; set; }

		[DataMember, JsonProperty("Parcela")]
		public int? Parcela { get; set; }

		[DataLength(12,2), DataMember, JsonProperty("ValorTotal")]
		public decimal? ValorTotal { get; set; }

		[DataLength(12,2), DataMember, JsonProperty("ValorAmortizacaoSemIOF")]
		public decimal? ValorAmortizacaoSemIOF { get; set; }

		[DataLength(12,2), DataMember, JsonProperty("ValorJuros")]
		public decimal? ValorJuros { get; set; }

		[DataLength(12,2), DataMember, JsonProperty("ValorJurosAcumulado")]
		public decimal? ValorJurosAcumulado { get; set; }

		[DataLength(12,2), DataMember, JsonProperty("ValorSaldo")]
		public decimal? ValorSaldo { get; set; }

		[DataLength(12,2), DataMember, JsonProperty("ValorSaldoRestante")]
		public decimal? ValorSaldoRestante { get; set; }

		[DataLength(12,2), DataMember, JsonProperty("ValorReforco")]
		public decimal? ValorReforco { get; set; }

		[DataLength(50), MaxLength(50), StringLength(50), DataMember, JsonProperty("TipoParcela")]
		public string TipoParcela { get; set; }

		[DataMember, JsonProperty("Dias")]
		public int? Dias { get; set; }

		[DataLength(12,2), DataMember, JsonProperty("IOFTotal")]
		public decimal? IOFTotal { get; set; }

		[DataMember, JsonProperty("DiasIOF")]
		public int? DiasIOF { get; set; }

		[DataLength(12,2), DataMember, JsonProperty("ValorBaseIOF")]
		public decimal? ValorBaseIOF { get; set; }

		[DataLength(12,2), DataMember, JsonProperty("ValorProjetado")]
		public decimal? ValorProjetado { get; set; }

		[DataMember, JsonProperty("DataPagamento")]
		public DateTime? DataPagamento { get; set; }

		[DataLength(12,2), DataMember, JsonProperty("ValorPago")]
		public decimal? ValorPago { get; set; }

		[DataLength(50), MaxLength(50), StringLength(50), DataMember, JsonProperty("NU")]
		public string NU { get; set; }

		#endregion

		#region Metadados
		public static class METADADO
		{
			public static readonly TableReference tabelaNAME = "PropostaParcelas";
			public static readonly FieldReference Id = "PropostaParcelas.Id";
			public static readonly FieldReference Proposta = "PropostaParcelas.Proposta";
			public static readonly FieldReference Operacao = "PropostaParcelas.Operacao";
			public static readonly FieldReference DataVencimento = "PropostaParcelas.DataVencimento";
			public static readonly FieldReference ValorLimite = "PropostaParcelas.ValorLimite";
			public static readonly FieldReference ValorParcela = "PropostaParcelas.ValorParcela";
			public static readonly FieldReference ValorRepasse = "PropostaParcelas.ValorRepasse";
			public static readonly FieldReference IofNormal = "PropostaParcelas.IofNormal";
			public static readonly FieldReference IofAdicional = "PropostaParcelas.IofAdicional";
			public static readonly FieldReference Principal = "PropostaParcelas.Principal";
			public static readonly FieldReference Renda = "PropostaParcelas.Renda";
			public static readonly FieldReference Parcela = "PropostaParcelas.Parcela";
			public static readonly FieldReference ValorTotal = "PropostaParcelas.ValorTotal";
			public static readonly FieldReference ValorAmortizacaoSemIOF = "PropostaParcelas.ValorAmortizacaoSemIOF";
			public static readonly FieldReference ValorJuros = "PropostaParcelas.ValorJuros";
			public static readonly FieldReference ValorJurosAcumulado = "PropostaParcelas.ValorJurosAcumulado";
			public static readonly FieldReference ValorSaldo = "PropostaParcelas.ValorSaldo";
			public static readonly FieldReference ValorSaldoRestante = "PropostaParcelas.ValorSaldoRestante";
			public static readonly FieldReference ValorReforco = "PropostaParcelas.ValorReforco";
			public static readonly FieldReference TipoParcela = "PropostaParcelas.TipoParcela";
			public static readonly FieldReference Dias = "PropostaParcelas.Dias";
			public static readonly FieldReference IOFTotal = "PropostaParcelas.IOFTotal";
			public static readonly FieldReference DiasIOF = "PropostaParcelas.DiasIOF";
			public static readonly FieldReference ValorBaseIOF = "PropostaParcelas.ValorBaseIOF";
			public static readonly FieldReference ValorProjetado = "PropostaParcelas.ValorProjetado";
			public static readonly FieldReference DataPagamento = "PropostaParcelas.DataPagamento";
			public static readonly FieldReference ValorPago = "PropostaParcelas.ValorPago";
			public static readonly FieldReference NU = "PropostaParcelas.NU";
		}
		#endregion
	}
}
