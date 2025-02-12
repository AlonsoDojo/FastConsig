
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
	public partial class SimulacaoPessoa : EntityBase
	{
		#region Propriedades
		[Key, Identity, DataMember, JsonProperty("Id")]
		public int? Id { get; set; }

		[DataLength(14), MaxLength(14), StringLength(14), DataMember, JsonProperty("CpfCnpj")]
		public string CpfCnpj { get; set; }

		[DataLength(100), MaxLength(100), StringLength(100), DataMember, JsonProperty("Nome")]
		public string Nome { get; set; }

		[DataLength(1), MaxLength(1), StringLength(1), DataMember, JsonProperty("TipoPessoa")]
		public string TipoPessoa { get; set; }

		[DataMember, JsonProperty("DataNascimento")]
		public DateTime? DataNascimento { get; set; }

		[DataLength(100), MaxLength(100), StringLength(100), DataMember, JsonProperty("NumeroBeneficio")]
		public string NumeroBeneficio { get; set; }

		[DataMember, JsonProperty("DDDCelular")]
		public int? DDDCelular { get; set; }

		[DataMember, JsonProperty("Celular")]
		public int? Celular { get; set; }

		[DataLength(100), MaxLength(100), StringLength(100), DataMember, JsonProperty("Email")]
		public string Email { get; set; }

		[DataLength(100), MaxLength(100), StringLength(100), DataMember, JsonProperty("NumeroBeneficio2")]
		public string NumeroBeneficio2 { get; set; }

		[DataMember, JsonProperty("EspecieBeneficio")]
		public int? EspecieBeneficio { get; set; }

		[DataMember, JsonProperty("Orgao")]
		public int? Orgao { get; set; }

		[DataLength(2), MaxLength(2), StringLength(2), DataMember, JsonProperty("UFBeneficio")]
		public string UFBeneficio { get; set; }

		[DataMember, JsonProperty("IfPagadora")]
		public int? IfPagadora { get; set; }

		[DataMember, JsonProperty("AgenciaPagadora")]
		public int? AgenciaPagadora { get; set; }

		[DataLength(20), MaxLength(20), StringLength(20), DataMember, JsonProperty("ContaCorrente")]
		public string ContaCorrente { get; set; }

		[DataMember, JsonProperty("Simulacao")]
		public int? Simulacao { get; set; }

		[DataMember, JsonProperty("IndicadorAnalfabetismo")]
		public bool IndicadorAnalfabetismo { get; set; }

		[DataLength(12,2), DataMember, JsonProperty("ValorRenda")]
		public decimal? ValorRenda { get; set; }

		#endregion

		#region Metadados
		public static class METADADO
		{
			public static readonly TableReference tabelaNAME = "SimulacaoPessoa";
			public static readonly FieldReference Id = "SimulacaoPessoa.Id";
			public static readonly FieldReference CpfCnpj = "SimulacaoPessoa.CpfCnpj";
			public static readonly FieldReference Nome = "SimulacaoPessoa.Nome";
			public static readonly FieldReference TipoPessoa = "SimulacaoPessoa.TipoPessoa";
			public static readonly FieldReference DataNascimento = "SimulacaoPessoa.DataNascimento";
			public static readonly FieldReference NumeroBeneficio = "SimulacaoPessoa.NumeroBeneficio";
			public static readonly FieldReference DDDCelular = "SimulacaoPessoa.DDDCelular";
			public static readonly FieldReference Celular = "SimulacaoPessoa.Celular";
			public static readonly FieldReference Email = "SimulacaoPessoa.Email";
			public static readonly FieldReference NumeroBeneficio2 = "SimulacaoPessoa.NumeroBeneficio2";
			public static readonly FieldReference EspecieBeneficio = "SimulacaoPessoa.EspecieBeneficio";
			public static readonly FieldReference Orgao = "SimulacaoPessoa.Orgao";
			public static readonly FieldReference UFBeneficio = "SimulacaoPessoa.UFBeneficio";
			public static readonly FieldReference IfPagadora = "SimulacaoPessoa.IfPagadora";
			public static readonly FieldReference AgenciaPagadora = "SimulacaoPessoa.AgenciaPagadora";
			public static readonly FieldReference ContaCorrente = "SimulacaoPessoa.ContaCorrente";
			public static readonly FieldReference Simulacao = "SimulacaoPessoa.Simulacao";
			public static readonly FieldReference IndicadorAnalfabetismo = "SimulacaoPessoa.IndicadorAnalfabetismo";
			public static readonly FieldReference ValorRenda = "SimulacaoPessoa.ValorRenda";
		}
		#endregion
	}
}
