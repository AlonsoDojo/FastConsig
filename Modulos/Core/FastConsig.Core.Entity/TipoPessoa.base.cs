
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
	public partial class TipoPessoa : EntityBase
	{
		#region Propriedades
		[Key, Identity, DataMember, JsonProperty("Id")]
		public int? Id { get; set; }

		[DataLength(1), MaxLength(1), StringLength(1), DataMember, JsonProperty("Codigo")]
		public string Codigo { get; set; }

		[DataLength(50), MaxLength(50), StringLength(50), DataMember, JsonProperty("Descricao")]
		public string Descricao { get; set; }

		#endregion

		#region Metadados
		public static class METADADO
		{
			public static readonly TableReference tabelaNAME = "TipoPessoa";
			public static readonly FieldReference Id = "TipoPessoa.Id";
			public static readonly FieldReference Codigo = "TipoPessoa.Codigo";
			public static readonly FieldReference Descricao = "TipoPessoa.Descricao";
		}
		#endregion
	}
}
