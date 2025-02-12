
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
	public partial class Pessoas : EntityBase
	{
		#region Propriedades
		[Identity, DataMember, JsonProperty("Id")]
		public int? Id { get; set; }

		[DataLength(14), MaxLength(14), StringLength(14), DataMember, JsonProperty("CpfCnpj")]
		public string CpfCnpj { get; set; }

		[DataLength(150), MaxLength(150), StringLength(150), DataMember, JsonProperty("Nome")]
		public string Nome { get; set; }

		[DataLength(1), MaxLength(1), StringLength(1), DataMember, JsonProperty("TipoPessoa")]
		public string TipoPessoa { get; set; }

		[DataMember, JsonProperty("DataNascimento")]
		public DateTime? DataNascimento { get; set; }

		[DataMember, JsonProperty("Nacionalidade")]
		public int? Nacionalidade { get; set; }

		[DataLength(30), MaxLength(30), StringLength(30), DataMember, JsonProperty("Naturalidade")]
		public string Naturalidade { get; set; }

		[DataLength(1), MaxLength(1), StringLength(1), DataMember, JsonProperty("Sexo")]
		public string Sexo { get; set; }

		[DataMember, JsonProperty("EstadoCivil")]
		public int? EstadoCivil { get; set; }

		[DataMember, JsonProperty("Pis")]
		public long? Pis { get; set; }

		[DataMember, JsonProperty("TipoDocumentoIdentidade")]
		public int? TipoDocumentoIdentidade { get; set; }

		[DataLength(15), MaxLength(15), StringLength(15), DataMember, JsonProperty("NumeroDocumentoIdentidade")]
		public string NumeroDocumentoIdentidade { get; set; }

		[DataMember, JsonProperty("OrgaoEmissor")]
		public int? OrgaoEmissor { get; set; }

		[DataLength(2), MaxLength(2), StringLength(2), DataMember, JsonProperty("UFEmissaoDocumentoIdentidade")]
		public string UFEmissaoDocumentoIdentidade { get; set; }

		[DataMember, JsonProperty("DataEmissaoDocumentoIdentidade")]
		public DateTime? DataEmissaoDocumentoIdentidade { get; set; }

		[DataLength(100), MaxLength(100), StringLength(100), DataMember, JsonProperty("Mae")]
		public string Mae { get; set; }

		[DataLength(100), MaxLength(100), StringLength(100), DataMember, JsonProperty("Pai")]
		public string Pai { get; set; }

		[DataLength(100), MaxLength(100), StringLength(100), DataMember, JsonProperty("Conjuge")]
		public string Conjuge { get; set; }

		[DataMember, JsonProperty("CBO")]
		public int? CBO { get; set; }

		[DataMember, JsonProperty("DDDResidencial")]
		public int? DDDResidencial { get; set; }

		[DataLength(18), MaxLength(18), StringLength(18), DataMember, JsonProperty("TelefoneResidencial")]
		public string TelefoneResidencial { get; set; }

		[DataMember, JsonProperty("DDDCelular")]
		public int? DDDCelular { get; set; }

		[DataMember, JsonProperty("Celular")]
		public int? Celular { get; set; }

		[DataMember, JsonProperty("DDDRecado")]
		public int? DDDRecado { get; set; }

		[DataMember, JsonProperty("TelefoneRecado")]
		public int? TelefoneRecado { get; set; }

		[DataLength(100), MaxLength(100), StringLength(100), DataMember, JsonProperty("Email")]
		public string Email { get; set; }

		[DataLength(1), MaxLength(1), StringLength(1), DataMember, JsonProperty("PPE")]
		public bool PPE { get; set; }

		[DataLength(8), MaxLength(8), StringLength(8), DataMember, JsonProperty("CEPResidencial")]
		public string CEPResidencial { get; set; }

		[DataLength(100), MaxLength(100), StringLength(100), DataMember, JsonProperty("EnderecoResidencial")]
		public string EnderecoResidencial { get; set; }

		[DataLength(7), MaxLength(7), StringLength(7), DataMember, JsonProperty("NumeroResidencial")]
		public string NumeroResidencial { get; set; }

		[DataLength(50), MaxLength(50), StringLength(50), DataMember, JsonProperty("ComplementoResidencial")]
		public string ComplementoResidencial { get; set; }

		[DataLength(50), MaxLength(50), StringLength(50), DataMember, JsonProperty("BairroResidencial")]
		public string BairroResidencial { get; set; }

		[DataLength(80), MaxLength(80), StringLength(80), DataMember, JsonProperty("CidadeResidencial")]
		public string CidadeResidencial { get; set; }

		[DataLength(2), MaxLength(2), StringLength(2), DataMember, JsonProperty("EstadoResidencial")]
		public string EstadoResidencial { get; set; }

		[DataMember, JsonProperty("TempoResidenciaAnos")]
		public int? TempoResidenciaAnos { get; set; }

		[DataMember, JsonProperty("TempoResidenciaMeses")]
		public int? TempoResidenciaMeses { get; set; }

		[DataMember, JsonProperty("TempoResidenciaAnteriorAnos")]
		public int? TempoResidenciaAnteriorAnos { get; set; }

		[DataMember, JsonProperty("TempoResidenciaAnteriorMeses")]
		public int? TempoResidenciaAnteriorMeses { get; set; }

		[DataLength(8), MaxLength(8), StringLength(8), DataMember, JsonProperty("CEPComercial")]
		public string CEPComercial { get; set; }

		[DataLength(100), MaxLength(100), StringLength(100), DataMember, JsonProperty("EnderecoComercial")]
		public string EnderecoComercial { get; set; }

		[DataLength(7), MaxLength(7), StringLength(7), DataMember, JsonProperty("NumeroComercial")]
		public string NumeroComercial { get; set; }

		[DataLength(50), MaxLength(50), StringLength(50), DataMember, JsonProperty("ComplementoComercial")]
		public string ComplementoComercial { get; set; }

		[DataLength(50), MaxLength(50), StringLength(50), DataMember, JsonProperty("BairroComercial")]
		public string BairroComercial { get; set; }

		[DataLength(80), MaxLength(80), StringLength(80), DataMember, JsonProperty("CidadeComercial")]
		public string CidadeComercial { get; set; }

		[DataLength(2), MaxLength(2), StringLength(2), DataMember, JsonProperty("UFComercial")]
		public string UFComercial { get; set; }

		[DataLength(100), MaxLength(100), StringLength(100), DataMember, JsonProperty("Empresa")]
		public string Empresa { get; set; }

		[DataLength(100), MaxLength(100), StringLength(100), DataMember, JsonProperty("Cargo")]
		public string Cargo { get; set; }

		[DataMember, JsonProperty("DDDComercial")]
		public int? DDDComercial { get; set; }

		[DataLength(18), MaxLength(18), StringLength(18), DataMember, JsonProperty("TelefoneComercial")]
		public string TelefoneComercial { get; set; }

		[DataMember, JsonProperty("CnpjEmpresa")]
		public int? CnpjEmpresa { get; set; }

		[DataLength(100), MaxLength(100), StringLength(100), DataMember, JsonProperty("NomeEmpresa")]
		public string NomeEmpresa { get; set; }

		[DataLength(18,2), DataMember, JsonProperty("ValorRenda")]
		public decimal? ValorRenda { get; set; }

		[DataLength(12,2), DataMember, JsonProperty("ValorOutrasRendas")]
		public decimal? ValorOutrasRendas { get; set; }

		[DataLength(20), MaxLength(20), StringLength(20), DataMember, JsonProperty("NumeroBeneficio")]
		public string NumeroBeneficio { get; set; }

		[DataLength(20), MaxLength(20), StringLength(20), DataMember, JsonProperty("NumeroBeneficio2")]
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

		[DataMember, JsonProperty("IndicadorAnalfabetismo")]
		public bool IndicadorAnalfabetismo { get; set; }

		#endregion

		#region Metadados
		public static class METADADO
		{
			public static readonly TableReference tabelaNAME = "Pessoas";
			public static readonly FieldReference Id = "Pessoas.Id";
			public static readonly FieldReference CpfCnpj = "Pessoas.CpfCnpj";
			public static readonly FieldReference Nome = "Pessoas.Nome";
			public static readonly FieldReference TipoPessoa = "Pessoas.TipoPessoa";
			public static readonly FieldReference DataNascimento = "Pessoas.DataNascimento";
			public static readonly FieldReference Nacionalidade = "Pessoas.Nacionalidade";
			public static readonly FieldReference Naturalidade = "Pessoas.Naturalidade";
			public static readonly FieldReference Sexo = "Pessoas.Sexo";
			public static readonly FieldReference EstadoCivil = "Pessoas.EstadoCivil";
			public static readonly FieldReference Pis = "Pessoas.Pis";
			public static readonly FieldReference TipoDocumentoIdentidade = "Pessoas.TipoDocumentoIdentidade";
			public static readonly FieldReference NumeroDocumentoIdentidade = "Pessoas.NumeroDocumentoIdentidade";
			public static readonly FieldReference OrgaoEmissor = "Pessoas.OrgaoEmissor";
			public static readonly FieldReference UFEmissaoDocumentoIdentidade = "Pessoas.UFEmissaoDocumentoIdentidade";
			public static readonly FieldReference DataEmissaoDocumentoIdentidade = "Pessoas.DataEmissaoDocumentoIdentidade";
			public static readonly FieldReference Mae = "Pessoas.Mae";
			public static readonly FieldReference Pai = "Pessoas.Pai";
			public static readonly FieldReference Conjuge = "Pessoas.Conjuge";
			public static readonly FieldReference CBO = "Pessoas.CBO";
			public static readonly FieldReference DDDResidencial = "Pessoas.DDDResidencial";
			public static readonly FieldReference TelefoneResidencial = "Pessoas.TelefoneResidencial";
			public static readonly FieldReference DDDCelular = "Pessoas.DDDCelular";
			public static readonly FieldReference Celular = "Pessoas.Celular";
			public static readonly FieldReference DDDRecado = "Pessoas.DDDRecado";
			public static readonly FieldReference TelefoneRecado = "Pessoas.TelefoneRecado";
			public static readonly FieldReference Email = "Pessoas.Email";
			public static readonly FieldReference PPE = "Pessoas.PPE";
			public static readonly FieldReference CEPResidencial = "Pessoas.CEPResidencial";
			public static readonly FieldReference EnderecoResidencial = "Pessoas.EnderecoResidencial";
			public static readonly FieldReference NumeroResidencial = "Pessoas.NumeroResidencial";
			public static readonly FieldReference ComplementoResidencial = "Pessoas.ComplementoResidencial";
			public static readonly FieldReference BairroResidencial = "Pessoas.BairroResidencial";
			public static readonly FieldReference CidadeResidencial = "Pessoas.CidadeResidencial";
			public static readonly FieldReference EstadoResidencial = "Pessoas.EstadoResidencial";
			public static readonly FieldReference TempoResidenciaAnos = "Pessoas.TempoResidenciaAnos";
			public static readonly FieldReference TempoResidenciaMeses = "Pessoas.TempoResidenciaMeses";
			public static readonly FieldReference TempoResidenciaAnteriorAnos = "Pessoas.TempoResidenciaAnteriorAnos";
			public static readonly FieldReference TempoResidenciaAnteriorMeses = "Pessoas.TempoResidenciaAnteriorMeses";
			public static readonly FieldReference CEPComercial = "Pessoas.CEPComercial";
			public static readonly FieldReference EnderecoComercial = "Pessoas.EnderecoComercial";
			public static readonly FieldReference NumeroComercial = "Pessoas.NumeroComercial";
			public static readonly FieldReference ComplementoComercial = "Pessoas.ComplementoComercial";
			public static readonly FieldReference BairroComercial = "Pessoas.BairroComercial";
			public static readonly FieldReference CidadeComercial = "Pessoas.CidadeComercial";
			public static readonly FieldReference UFComercial = "Pessoas.UFComercial";
			public static readonly FieldReference Empresa = "Pessoas.Empresa";
			public static readonly FieldReference Cargo = "Pessoas.Cargo";
			public static readonly FieldReference DDDComercial = "Pessoas.DDDComercial";
			public static readonly FieldReference TelefoneComercial = "Pessoas.TelefoneComercial";
			public static readonly FieldReference CnpjEmpresa = "Pessoas.CnpjEmpresa";
			public static readonly FieldReference NomeEmpresa = "Pessoas.NomeEmpresa";
			public static readonly FieldReference ValorRenda = "Pessoas.ValorRenda";
			public static readonly FieldReference ValorOutrasRendas = "Pessoas.ValorOutrasRendas";
			public static readonly FieldReference NumeroBeneficio = "Pessoas.NumeroBeneficio";
			public static readonly FieldReference NumeroBeneficio2 = "Pessoas.NumeroBeneficio2";
			public static readonly FieldReference EspecieBeneficio = "Pessoas.EspecieBeneficio";
			public static readonly FieldReference Orgao = "Pessoas.Orgao";
			public static readonly FieldReference UFBeneficio = "Pessoas.UFBeneficio";
			public static readonly FieldReference IfPagadora = "Pessoas.IfPagadora";
			public static readonly FieldReference AgenciaPagadora = "Pessoas.AgenciaPagadora";
			public static readonly FieldReference ContaCorrente = "Pessoas.ContaCorrente";
			public static readonly FieldReference IndicadorAnalfabetismo = "Pessoas.IndicadorAnalfabetismo";
		}
		#endregion
	}
}
