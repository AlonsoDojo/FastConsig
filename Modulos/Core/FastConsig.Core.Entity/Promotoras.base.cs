
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
	public partial class Promotoras : EntityBase
	{
		#region Propriedades
		[Key, DataMember, JsonProperty("Id")]
		public int? Id { get; set; }

		[DataLength(100), MaxLength(100), StringLength(100), DataMember, JsonProperty("Nome")]
		public string Nome { get; set; }

		[DataLength(8), MaxLength(8), StringLength(8), DataMember, JsonProperty("Cep")]
		public string Cep { get; set; }

		[DataLength(100), MaxLength(100), StringLength(100), DataMember, JsonProperty("Endereco")]
		public string Endereco { get; set; }

		[DataLength(8), MaxLength(8), StringLength(8), DataMember, JsonProperty("Numero")]
		public string Numero { get; set; }

		[DataLength(50), MaxLength(50), StringLength(50), DataMember, JsonProperty("Complemento")]
		public string Complemento { get; set; }

		[DataLength(50), MaxLength(50), StringLength(50), DataMember, JsonProperty("Bairro")]
		public string Bairro { get; set; }

		[DataLength(50), MaxLength(50), StringLength(50), DataMember, JsonProperty("Cidade")]
		public string Cidade { get; set; }

		[DataLength(2), MaxLength(2), StringLength(2), DataMember, JsonProperty("Estado")]
		public string Estado { get; set; }

		[DataLength(15), MaxLength(15), StringLength(9), DataMember, JsonProperty("Telefone")]
		public string Telefone { get; set; }

		[DataLength(100), MaxLength(100), StringLength(100), DataMember, JsonProperty("Email")]
		public string Email { get; set; }

		[DataLength(14), MaxLength(14), StringLength(14), DataMember, JsonProperty("Cnpj")]
		public string Cnpj { get; set; }

		[DataMember, JsonProperty("Ativo")]
		public bool Ativo { get; set; }

		[DataMember, JsonProperty("Correspondente")]
		public bool Correspondente { get; set; }

		[DataLength(100), MaxLength(100), StringLength(100), DataMember, JsonProperty("NomeFantasia")]
		public string NomeFantasia { get; set; }

		[DataLength(5,2), DataMember, JsonProperty("IndiceReclamacoes")]
		public decimal? IndiceReclamacoes { get; set; }

		[DataMember, JsonProperty("ResultadoReclamacoes")]
		public int? ResultadoReclamacoes { get; set; }

		[DataLength(5,2), DataMember, JsonProperty("IndiceAcoesJudiciais")]
		public decimal? IndiceAcoesJudiciais { get; set; }

		[DataMember, JsonProperty("ResultadoAcoesJudiciais")]
		public int? ResultadoAcoesJudiciais { get; set; }

		[DataMember, JsonProperty("IndicadorNaoConformidade")]
		public bool IndicadorNaoConformidade { get; set; }

		[DataMember, JsonProperty("DataBaseConsultaQuadroSocietario")]
		public DateTime? DataBaseConsultaQuadroSocietario { get; set; }

		[ForeignKey, DataMember, JsonProperty("Gerente")]
		public int? Gerente { get; set; }

		#endregion

		#region Metadados
		public static class METADADO
		{
			public static readonly TableReference tabelaNAME = "Promotoras";
			public static readonly FieldReference Id = "Promotoras.Id";
			public static readonly FieldReference Nome = "Promotoras.Nome";
			public static readonly FieldReference Cep = "Promotoras.Cep";
			public static readonly FieldReference Endereco = "Promotoras.Endereco";
			public static readonly FieldReference Numero = "Promotoras.Numero";
			public static readonly FieldReference Complemento = "Promotoras.Complemento";
			public static readonly FieldReference Bairro = "Promotoras.Bairro";
			public static readonly FieldReference Cidade = "Promotoras.Cidade";
			public static readonly FieldReference Estado = "Promotoras.Estado";
			public static readonly FieldReference Telefone = "Promotoras.Telefone";
			public static readonly FieldReference Email = "Promotoras.Email";
			public static readonly FieldReference Cnpj = "Promotoras.Cnpj";
			public static readonly FieldReference Ativo = "Promotoras.Ativo";
			public static readonly FieldReference Correspondente = "Promotoras.Correspondente";
			public static readonly FieldReference NomeFantasia = "Promotoras.NomeFantasia";
			public static readonly FieldReference IndiceReclamacoes = "Promotoras.IndiceReclamacoes";
			public static readonly FieldReference ResultadoReclamacoes = "Promotoras.ResultadoReclamacoes";
			public static readonly FieldReference IndiceAcoesJudiciais = "Promotoras.IndiceAcoesJudiciais";
			public static readonly FieldReference ResultadoAcoesJudiciais = "Promotoras.ResultadoAcoesJudiciais";
			public static readonly FieldReference IndicadorNaoConformidade = "Promotoras.IndicadorNaoConformidade";
			public static readonly FieldReference DataBaseConsultaQuadroSocietario = "Promotoras.DataBaseConsultaQuadroSocietario";
			public static readonly FieldReference Gerente = "Promotoras.Gerente";
		}
		#endregion
	}
}
