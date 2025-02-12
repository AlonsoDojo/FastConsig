
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
	public partial class PropostaContratosREFIN : EntityBase
	{
		#region Propriedades
		[Key, Identity, DataMember, JsonProperty("Id")]
		public int? Id { get; set; }

		[DataMember, JsonProperty("Proposta")]
		public int? Proposta { get; set; }

		[DataLength(2), MaxLength(2), StringLength(2), DataMember, JsonProperty("Empresa")]
		public string Empresa { get; set; }

		[DataLength(4), MaxLength(4), StringLength(4), DataMember, JsonProperty("Agencia")]
		public string Agencia { get; set; }

		[DataLength(10), MaxLength(10), StringLength(10), DataMember, JsonProperty("Contrato")]
		public string Contrato { get; set; }

		[DataLength(14), MaxLength(14), StringLength(14), DataMember, JsonProperty("CpfCnpj")]
		public string CpfCnpj { get; set; }

		[DataMember, JsonProperty("DataSituacao")]
		public DateTime? DataSituacao { get; set; }

		[DataMember, JsonProperty("Emissao")]
		public DateTime? Emissao { get; set; }

		[DataMember, JsonProperty("Vencimento")]
		public DateTime? Vencimento { get; set; }

		[DataLength(3), MaxLength(3), StringLength(3), DataMember, JsonProperty("Prazo")]
		public string Prazo { get; set; }

		[DataLength(6), MaxLength(6), StringLength(6), DataMember, JsonProperty("Produto")]
		public string Produto { get; set; }

		[DataMember, JsonProperty("DiasAtraso")]
		public int? DiasAtraso { get; set; }

		[DataLength(18,2), DataMember, JsonProperty("Principal")]
		public decimal? Principal { get; set; }

		[DataLength(18,2), DataMember, JsonProperty("ValorContrato")]
		public decimal? ValorContrato { get; set; }

		[DataLength(18,2), DataMember, JsonProperty("ValorTotalAPagar")]
		public decimal? ValorTotalAPagar { get; set; }

		[DataLength(18,2), DataMember, JsonProperty("Tac")]
		public decimal? Tac { get; set; }

		[DataLength(18,2), DataMember, JsonProperty("Seguro")]
		public decimal? Seguro { get; set; }

		[DataLength(18,6), DataMember, JsonProperty("TaxaMensal")]
		public decimal? TaxaMensal { get; set; }

		[DataLength(18,6), DataMember, JsonProperty("TaxaAnual")]
		public decimal? TaxaAnual { get; set; }

		[DataLength(18,2), DataMember, JsonProperty("SaldoDevedor")]
		public decimal? SaldoDevedor { get; set; }

		[DataMember, JsonProperty("DataSaldoDevedor")]
		public DateTime? DataSaldoDevedor { get; set; }

		[DataLength(18,2), DataMember, JsonProperty("SaldoAtual")]
		public decimal? SaldoAtual { get; set; }

		[DataLength(18,2), DataMember, JsonProperty("IofAtraso")]
		public decimal? IofAtraso { get; set; }

		[DataLength(18,2), DataMember, JsonProperty("SaldoPrincipalEmAberto")]
		public decimal? SaldoPrincipalEmAberto { get; set; }

		[DataLength(20), MaxLength(20), StringLength(20), DataMember, JsonProperty("Matricula")]
		public string Matricula { get; set; }

		[DataLength(3), MaxLength(3), StringLength(3), DataMember, JsonProperty("TipoBeneficio")]
		public string TipoBeneficio { get; set; }

		[DataLength(2), MaxLength(2), StringLength(2), DataMember, JsonProperty("UfBeneficio")]
		public string UfBeneficio { get; set; }

		[DataLength(1), MaxLength(1), StringLength(1), DataMember, JsonProperty("Titularidade")]
		public string Titularidade { get; set; }

		[DataLength(2), MaxLength(2), StringLength(2), DataMember, JsonProperty("MeioRecebimentoBeneficio")]
		public string MeioRecebimentoBeneficio { get; set; }

		[DataMember, JsonProperty("Utilizado")]
		public bool Utilizado { get; set; }

		[DataLength(18,2), DataMember, JsonProperty("ValorParcela")]
		public decimal? ValorParcela { get; set; }

		[DataMember, JsonProperty("ParcelasEmAberto")]
		public int? ParcelasEmAberto { get; set; }

		#endregion

		#region Metadados
		public static class METADADO
		{
			public static readonly TableReference tabelaNAME = "PropostaContratosREFIN";
			public static readonly FieldReference Id = "PropostaContratosREFIN.Id";
			public static readonly FieldReference Proposta = "PropostaContratosREFIN.Proposta";
			public static readonly FieldReference Empresa = "PropostaContratosREFIN.Empresa";
			public static readonly FieldReference Agencia = "PropostaContratosREFIN.Agencia";
			public static readonly FieldReference Contrato = "PropostaContratosREFIN.Contrato";
			public static readonly FieldReference CpfCnpj = "PropostaContratosREFIN.CpfCnpj";
			public static readonly FieldReference DataSituacao = "PropostaContratosREFIN.DataSituacao";
			public static readonly FieldReference Emissao = "PropostaContratosREFIN.Emissao";
			public static readonly FieldReference Vencimento = "PropostaContratosREFIN.Vencimento";
			public static readonly FieldReference Prazo = "PropostaContratosREFIN.Prazo";
			public static readonly FieldReference Produto = "PropostaContratosREFIN.Produto";
			public static readonly FieldReference DiasAtraso = "PropostaContratosREFIN.DiasAtraso";
			public static readonly FieldReference Principal = "PropostaContratosREFIN.Principal";
			public static readonly FieldReference ValorContrato = "PropostaContratosREFIN.ValorContrato";
			public static readonly FieldReference ValorTotalAPagar = "PropostaContratosREFIN.ValorTotalAPagar";
			public static readonly FieldReference Tac = "PropostaContratosREFIN.Tac";
			public static readonly FieldReference Seguro = "PropostaContratosREFIN.Seguro";
			public static readonly FieldReference TaxaMensal = "PropostaContratosREFIN.TaxaMensal";
			public static readonly FieldReference TaxaAnual = "PropostaContratosREFIN.TaxaAnual";
			public static readonly FieldReference SaldoDevedor = "PropostaContratosREFIN.SaldoDevedor";
			public static readonly FieldReference DataSaldoDevedor = "PropostaContratosREFIN.DataSaldoDevedor";
			public static readonly FieldReference SaldoAtual = "PropostaContratosREFIN.SaldoAtual";
			public static readonly FieldReference IofAtraso = "PropostaContratosREFIN.IofAtraso";
			public static readonly FieldReference SaldoPrincipalEmAberto = "PropostaContratosREFIN.SaldoPrincipalEmAberto";
			public static readonly FieldReference Matricula = "PropostaContratosREFIN.Matricula";
			public static readonly FieldReference TipoBeneficio = "PropostaContratosREFIN.TipoBeneficio";
			public static readonly FieldReference UfBeneficio = "PropostaContratosREFIN.UfBeneficio";
			public static readonly FieldReference Titularidade = "PropostaContratosREFIN.Titularidade";
			public static readonly FieldReference MeioRecebimentoBeneficio = "PropostaContratosREFIN.MeioRecebimentoBeneficio";
			public static readonly FieldReference Utilizado = "PropostaContratosREFIN.Utilizado";
			public static readonly FieldReference ValorParcela = "PropostaContratosREFIN.ValorParcela";
			public static readonly FieldReference ParcelasEmAberto = "PropostaContratosREFIN.ParcelasEmAberto";
		}
		#endregion
	}
}
