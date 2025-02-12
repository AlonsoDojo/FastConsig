
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
	public partial class RedeLoja : EntityBase
	{
		#region Propriedades
		[Key, Identity, DataMember, JsonProperty("Id")]
		public int? Id { get; set; }

		[DataLength(100), MaxLength(100), StringLength(100), DataMember, JsonProperty("Nome")]
		public string Nome { get; set; }

		[DataLength(40), MaxLength(40), StringLength(40), DataMember, JsonProperty("Abreviatura")]
		public string Abreviatura { get; set; }

		[DataLength(40), MaxLength(40), StringLength(40), DataMember, JsonProperty("Endereco")]
		public string Endereco { get; set; }

		[DataLength(7), MaxLength(7), StringLength(7), DataMember, JsonProperty("Numero")]
		public string Numero { get; set; }

		[DataLength(20), MaxLength(20), StringLength(20), DataMember, JsonProperty("Complemento")]
		public string Complemento { get; set; }

		[DataLength(20), MaxLength(20), StringLength(20), DataMember, JsonProperty("Cidade")]
		public string Cidade { get; set; }

		[DataLength(20), MaxLength(20), StringLength(20), DataMember, JsonProperty("Bairro")]
		public string Bairro { get; set; }

		[DataLength(2), MaxLength(2), StringLength(2), DataMember, JsonProperty("Estado")]
		public string Estado { get; set; }

		[DataLength(8), MaxLength(8), StringLength(8), DataMember, JsonProperty("Cep")]
		public string Cep { get; set; }

		[DataLength(14), MaxLength(14), StringLength(14), DataMember, JsonProperty("Cnpj")]
		public string Cnpj { get; set; }

		[ForeignKey, DataMember, JsonProperty("Promotora")]
		public int? Promotora { get; set; }

		#endregion

		#region Metadados
		public static class METADADO
		{
			public static readonly TableReference tabelaNAME = "RedeLoja";
			public static readonly FieldReference Id = "RedeLoja.Id";
			public static readonly FieldReference Nome = "RedeLoja.Nome";
			public static readonly FieldReference Abreviatura = "RedeLoja.Abreviatura";
			public static readonly FieldReference Endereco = "RedeLoja.Endereco";
			public static readonly FieldReference Numero = "RedeLoja.Numero";
			public static readonly FieldReference Complemento = "RedeLoja.Complemento";
			public static readonly FieldReference Cidade = "RedeLoja.Cidade";
			public static readonly FieldReference Bairro = "RedeLoja.Bairro";
			public static readonly FieldReference Estado = "RedeLoja.Estado";
			public static readonly FieldReference Cep = "RedeLoja.Cep";
			public static readonly FieldReference Cnpj = "RedeLoja.Cnpj";
			public static readonly FieldReference Promotora = "RedeLoja.Promotora";
		}
		#endregion
	}
}
