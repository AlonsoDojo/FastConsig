
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
	public partial class Produtos : EntityBase
	{
		#region Propriedades
		[Key, DataMember, JsonProperty("Id")]
		public int? Id { get; set; }

		[DataLength(255), MaxLength(255), StringLength(255), DataMember, JsonProperty("Nome")]
		public string Nome { get; set; }

		[DataMember, JsonProperty("Ativo")]
		public bool Ativo { get; set; }

		[DataLength(80), MaxLength(80), StringLength(80), DataMember, JsonProperty("PaginaPadrao")]
		public string PaginaPadrao { get; set; }

		[DataMember, JsonProperty("ExibeBlocoCelularEmail")]
		public bool ExibeBlocoCelularEmail { get; set; }

		[DataMember, JsonProperty("ExibeBlocoDataNascimento")]
		public bool ExibeBlocoDataNascimento { get; set; }

		[DataMember, JsonProperty("GerentePadrao")]
		public int? GerentePadrao { get; set; }

		[DataLength(2147483647), MaxLength(2147483647), StringLength(2147483647), DataMember, JsonProperty("Parametros")]
		public string Parametros { get; set; }

		[DataLength(2147483647), MaxLength(2147483647), StringLength(2147483647), DataMember, JsonProperty("Observacoes")]
		public string Observacoes { get; set; }

		[DataMember, JsonProperty("BuscaDadosCadastrais")]
		public bool BuscaDadosCadastrais { get; set; }

		[DataMember, JsonProperty("PermiteBuscarUltimoCadastro")]
		public bool PermiteBuscarUltimoCadastro { get; set; }

		[DataMember, JsonProperty("ExibeSelecaoTabelas")]
		public bool ExibeSelecaoTabelas { get; set; }

		[DataMember, JsonProperty("ExibeValorSolicitado")]
		public bool ExibeValorSolicitado { get; set; }

		[DataMember, JsonProperty("ExibePrazo")]
		public bool ExibePrazo { get; set; }

		[DataMember, JsonProperty("AplicavelPF")]
		public bool AplicavelPF { get; set; }

		[DataMember, JsonProperty("AplicavelPJ")]
		public bool AplicavelPJ { get; set; }

		[DataMember, JsonProperty("ExibirDatasSimulacao")]
		public bool ExibirDatasSimulacao { get; set; }

		[DataMember, JsonProperty("ExibeDataEmissao")]
		public bool ExibeDataEmissao { get; set; }

		[DataMember, JsonProperty("ExibeDataPrimeiroVencimento")]
		public bool ExibeDataPrimeiroVencimento { get; set; }

		[DataMember, JsonProperty("ExibeCaptcha")]
		public bool ExibeCaptcha { get; set; }

		[DataMember, JsonProperty("ExibeNumeroBeneficio")]
		public bool ExibeNumeroBeneficio { get; set; }

		[DataMember, JsonProperty("ValidaCertificado")]
		public bool ValidaCertificado { get; set; }

		[ForeignKey, DataMember, JsonProperty("TipoCertificado")]
		public int? TipoCertificado { get; set; }

		[DataMember, JsonProperty("ExpirarProposta")]
		public bool ExpirarProposta { get; set; }

		[DataMember, JsonProperty("DiasExpiracao")]
		public int? DiasExpiracao { get; set; }

		[DataMember, JsonProperty("ExibirFormaComunicacao")]
		public bool ExibirFormaComunicacao { get; set; }

		[DataMember, JsonProperty("ExibeOrgao")]
		public bool ExibeOrgao { get; set; }

		[DataMember, JsonProperty("ExibeEspecieBeneficio")]
		public bool ExibeEspecieBeneficio { get; set; }

		[ForeignKey, DataMember, JsonProperty("FamiliaProduto")]
		public int? FamiliaProduto { get; set; }

      [DataMember, JsonProperty("ExibeInstituidor")]
      public bool ExibeInstituidor { get; set; }

      [DataMember, JsonProperty("BloqueiaPropostas")]
      public bool BloqueiaProposta { get; set; }

      [DataMember, JsonProperty("ProfissionalCertificadoObrigatorio")]
      public bool ProfissionalCertificadoObrigatorio { get; set; }
      
      #endregion

      #region Metadados
      public static class METADADO
		{
			public static readonly TableReference tabelaNAME = "Produtos";
			public static readonly FieldReference Id = "Produtos.Id";
			public static readonly FieldReference Nome = "Produtos.Nome";
			public static readonly FieldReference Ativo = "Produtos.Ativo";
			public static readonly FieldReference PaginaPadrao = "Produtos.PaginaPadrao";
			public static readonly FieldReference ExibeBlocoCelularEmail = "Produtos.ExibeBlocoCelularEmail";
			public static readonly FieldReference ExibeBlocoDataNascimento = "Produtos.ExibeBlocoDataNascimento";
			public static readonly FieldReference GerentePadrao = "Produtos.GerentePadrao";
			public static readonly FieldReference Parametros = "Produtos.Parametros";
			public static readonly FieldReference Observacoes = "Produtos.Observacoes";
			public static readonly FieldReference BuscaDadosCadastrais = "Produtos.BuscaDadosCadastrais";
			public static readonly FieldReference PermiteBuscarUltimoCadastro = "Produtos.PermiteBuscarUltimoCadastro";
			public static readonly FieldReference ExibeSelecaoTabelas = "Produtos.ExibeSelecaoTabelas";
			public static readonly FieldReference ExibeValorSolicitado = "Produtos.ExibeValorSolicitado";
			public static readonly FieldReference ExibePrazo = "Produtos.ExibePrazo";
			public static readonly FieldReference AplicavelPF = "Produtos.AplicavelPF";
			public static readonly FieldReference AplicavelPJ = "Produtos.AplicavelPJ";
			public static readonly FieldReference ExibirDatasSimulacao = "Produtos.ExibirDatasSimulacao";
			public static readonly FieldReference ExibeDataEmissao = "Produtos.ExibeDataEmissao";
			public static readonly FieldReference ExibeDataPrimeiroVencimento = "Produtos.ExibeDataPrimeiroVencimento";
			public static readonly FieldReference ExibeCaptcha = "Produtos.ExibeCaptcha";
			public static readonly FieldReference ExibeNumeroBeneficio = "Produtos.ExibeNumeroBeneficio";
			public static readonly FieldReference ValidaCertificado = "Produtos.ValidaCertificado";
			public static readonly FieldReference TipoCertificado = "Produtos.TipoCertificado";
			public static readonly FieldReference ExpirarProposta = "Produtos.ExpirarProposta";
			public static readonly FieldReference DiasExpiracao = "Produtos.DiasExpiracao";
			public static readonly FieldReference ExibirFormaComunicacao = "Produtos.ExibirFormaComunicacao";
			public static readonly FieldReference ExibeOrgao = "Produtos.ExibeOrgao";
			public static readonly FieldReference ExibeEspecieBeneficio = "Produtos.ExibeEspecieBeneficio";
			public static readonly FieldReference FamiliaProduto = "Produtos.FamiliaProduto";
         public static readonly FieldReference ExibeInstituidor = "Produtos.ExibeInstituidor";
         public static readonly FieldReference BloqueiaProposta= "Produtos.BloqueiaProposta";
         public static readonly FieldReference ProfissionalCertificadoObrigatorio = "Produtos.ProfissionalCertificadoObrigatorio";
      }
		#endregion
	}
}
