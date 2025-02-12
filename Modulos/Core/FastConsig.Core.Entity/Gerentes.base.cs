
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
	public partial class Gerentes : EntityBase
	{
		#region Propriedades
		[Key, Identity, DataMember, JsonProperty("Id")]
		public int? Id { get; set; }

		[DataLength(120), MaxLength(120), StringLength(120), DataMember, JsonProperty("Nome")]
		public string Nome { get; set; }

		[DataLength(14), MaxLength(14), StringLength(14), DataMember, JsonProperty("Cpf")]
		public string Cpf { get; set; }

		#endregion

		#region Metadados
		public static class METADADO
		{
			public static readonly TableReference tabelaNAME = "Gerentes";
			public static readonly FieldReference Id = "Gerentes.Id";
			public static readonly FieldReference Nome = "Gerentes.Nome";
			public static readonly FieldReference Cpf = "Gerentes.Cpf";
		}
		#endregion
	}
}
