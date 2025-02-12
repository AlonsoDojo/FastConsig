
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
	public partial class SimulacaoParcelasREFIN : EntityBase
	{
		#region Propriedades
		[Key, Identity, DataMember, JsonProperty("Id")]
		public int? Id { get; set; }

		[DataMember, JsonProperty("Simulacao")]
		public int? Simulacao { get; set; }

		[DataLength(2), MaxLength(2), StringLength(2), DataMember, JsonProperty("Empresa")]
		public string Empresa { get; set; }

		[DataLength(4), MaxLength(4), StringLength(4), DataMember, JsonProperty("Agencia")]
		public string Agencia { get; set; }

		[DataLength(10), MaxLength(10), StringLength(10), DataMember, JsonProperty("Contrato")]
		public string Contrato { get; set; }

		[DataLength(3), MaxLength(3), StringLength(3), DataMember, JsonProperty("Parcela")]
		public string Parcela { get; set; }

		[DataMember, JsonProperty("Vencimento")]
		public DateTime? Vencimento { get; set; }

		[DataLength(18,2), DataMember, JsonProperty("ValorPrestacao")]
		public decimal? ValorPrestacao { get; set; }

		[DataLength(18,2), DataMember, JsonProperty("SaldoDevedor")]
		public decimal? SaldoDevedor { get; set; }

		[DataLength(1), MaxLength(1), StringLength(1), DataMember, JsonProperty("Situacao")]
		public string Situacao { get; set; }

		[DataMember, JsonProperty("DataPagamento")]
		public DateTime? DataPagamento { get; set; }

		[DataLength(18,2), DataMember, JsonProperty("PrincipalEmAberto")]
		public decimal? PrincipalEmAberto { get; set; }

		[DataMember, JsonProperty("DiasAtraso")]
		public int? DiasAtraso { get; set; }

		[DataMember, JsonProperty("Utilizado")]
		public bool Utilizado { get; set; }

		#endregion

		#region Metadados
		public static class METADADO
		{
			public static readonly TableReference tabelaNAME = "SimulacaoParcelasREFIN";
			public static readonly FieldReference Id = "SimulacaoParcelasREFIN.Id";
			public static readonly FieldReference Simulacao = "SimulacaoParcelasREFIN.Simulacao";
			public static readonly FieldReference Empresa = "SimulacaoParcelasREFIN.Empresa";
			public static readonly FieldReference Agencia = "SimulacaoParcelasREFIN.Agencia";
			public static readonly FieldReference Contrato = "SimulacaoParcelasREFIN.Contrato";
			public static readonly FieldReference Parcela = "SimulacaoParcelasREFIN.Parcela";
			public static readonly FieldReference Vencimento = "SimulacaoParcelasREFIN.Vencimento";
			public static readonly FieldReference ValorPrestacao = "SimulacaoParcelasREFIN.ValorPrestacao";
			public static readonly FieldReference SaldoDevedor = "SimulacaoParcelasREFIN.SaldoDevedor";
			public static readonly FieldReference Situacao = "SimulacaoParcelasREFIN.Situacao";
			public static readonly FieldReference DataPagamento = "SimulacaoParcelasREFIN.DataPagamento";
			public static readonly FieldReference PrincipalEmAberto = "SimulacaoParcelasREFIN.PrincipalEmAberto";
			public static readonly FieldReference DiasAtraso = "SimulacaoParcelasREFIN.DiasAtraso";
			public static readonly FieldReference Utilizado = "SimulacaoParcelasREFIN.Utilizado";
		}
		#endregion
	}
}
