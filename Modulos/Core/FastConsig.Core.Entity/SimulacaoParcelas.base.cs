
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
	public partial class SimulacaoParcelas : EntityBase
	{
		#region Propriedades
		[Key, Identity, DataMember, JsonProperty("Id")]
		public int? Id { get; set; }

		[ForeignKey, DataMember, JsonProperty("Simulacao")]
		public int? Simulacao { get; set; }

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

		#endregion

		#region Metadados
		public static class METADADO
		{
			public static readonly TableReference tabelaNAME = "SimulacaoParcelas";
			public static readonly FieldReference Id = "SimulacaoParcelas.Id";
			public static readonly FieldReference Simulacao = "SimulacaoParcelas.Simulacao";
			public static readonly FieldReference DataVencimento = "SimulacaoParcelas.DataVencimento";
			public static readonly FieldReference ValorLimite = "SimulacaoParcelas.ValorLimite";
			public static readonly FieldReference ValorParcela = "SimulacaoParcelas.ValorParcela";
			public static readonly FieldReference ValorRepasse = "SimulacaoParcelas.ValorRepasse";
			public static readonly FieldReference IofNormal = "SimulacaoParcelas.IofNormal";
			public static readonly FieldReference IofAdicional = "SimulacaoParcelas.IofAdicional";
			public static readonly FieldReference Principal = "SimulacaoParcelas.Principal";
			public static readonly FieldReference Renda = "SimulacaoParcelas.Renda";
			public static readonly FieldReference Parcela = "SimulacaoParcelas.Parcela";
			public static readonly FieldReference ValorTotal = "SimulacaoParcelas.ValorTotal";
			public static readonly FieldReference ValorAmortizacaoSemIOF = "SimulacaoParcelas.ValorAmortizacaoSemIOF";
			public static readonly FieldReference ValorJuros = "SimulacaoParcelas.ValorJuros";
			public static readonly FieldReference ValorJurosAcumulado = "SimulacaoParcelas.ValorJurosAcumulado";
			public static readonly FieldReference ValorSaldo = "SimulacaoParcelas.ValorSaldo";
			public static readonly FieldReference ValorSaldoRestante = "SimulacaoParcelas.ValorSaldoRestante";
			public static readonly FieldReference ValorReforco = "SimulacaoParcelas.ValorReforco";
			public static readonly FieldReference TipoParcela = "SimulacaoParcelas.TipoParcela";
			public static readonly FieldReference Dias = "SimulacaoParcelas.Dias";
			public static readonly FieldReference IOFTotal = "SimulacaoParcelas.IOFTotal";
			public static readonly FieldReference DiasIOF = "SimulacaoParcelas.DiasIOF";
			public static readonly FieldReference ValorBaseIOF = "SimulacaoParcelas.ValorBaseIOF";
			public static readonly FieldReference ValorProjetado = "SimulacaoParcelas.ValorProjetado";
		}
		#endregion
	}
}
