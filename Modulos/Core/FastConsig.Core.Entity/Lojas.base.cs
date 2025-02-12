
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
	public partial class Lojas : EntityBase
	{
		#region Propriedades
		[Key, Identity, DataMember, JsonProperty("Id")]
		public int? Id { get; set; }

		[ForeignKey, DataMember, JsonProperty("RedeLoja")]
		public int? RedeLoja { get; set; }

		[DataMember, JsonProperty("Loja")]
		public int? Loja { get; set; }

		[DataLength(40), MaxLength(40), StringLength(40), DataMember, JsonProperty("Nome")]
		public string Nome { get; set; }

		[DataLength(20), MaxLength(20), StringLength(20), DataMember, JsonProperty("Abreviatura")]
		public string Abreviatura { get; set; }

		[DataLength(40), MaxLength(40), StringLength(40), DataMember, JsonProperty("Endereco")]
		public string Endereco { get; set; }

		[DataLength(7), MaxLength(7), StringLength(7), DataMember, JsonProperty("Numero")]
		public string Numero { get; set; }

		[DataLength(20), MaxLength(20), StringLength(20), DataMember, JsonProperty("Complemento")]
		public string Complemento { get; set; }

		[DataLength(15), MaxLength(15), StringLength(15), DataMember, JsonProperty("Bairro")]
		public string Bairro { get; set; }

		[DataLength(20), MaxLength(20), StringLength(20), DataMember, JsonProperty("Cidade")]
		public string Cidade { get; set; }

		[DataLength(2), MaxLength(2), StringLength(2), DataMember, JsonProperty("Estado")]
		public string Estado { get; set; }

		[DataLength(8), MaxLength(8), StringLength(8), DataMember, JsonProperty("Cep")]
		public string Cep { get; set; }

		[DataLength(15), MaxLength(15), StringLength(15), DataMember, JsonProperty("Cnpj")]
		public string Cnpj { get; set; }

		#endregion

		#region Metadados
		public static class METADADO
		{
			public static readonly TableReference tabelaNAME = "Lojas";
			public static readonly FieldReference Id = "Lojas.Id";
			public static readonly FieldReference RedeLoja = "Lojas.RedeLoja";
			public static readonly FieldReference Loja = "Lojas.Loja";
			public static readonly FieldReference Nome = "Lojas.Nome";
			public static readonly FieldReference Abreviatura = "Lojas.Abreviatura";
			public static readonly FieldReference Endereco = "Lojas.Endereco";
			public static readonly FieldReference Numero = "Lojas.Numero";
			public static readonly FieldReference Complemento = "Lojas.Complemento";
			public static readonly FieldReference Bairro = "Lojas.Bairro";
			public static readonly FieldReference Cidade = "Lojas.Cidade";
			public static readonly FieldReference Estado = "Lojas.Estado";
			public static readonly FieldReference Cep = "Lojas.Cep";
			public static readonly FieldReference Cnpj = "Lojas.Cnpj";
		}
		#endregion
	}
}
