
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
	public partial class TipoCompromisso : EntityBase
	{
		#region Propriedades
		[Key, Identity, DataMember, JsonProperty("Id")]
		public int? Id { get; set; }

		[DataLength(50), MaxLength(50), StringLength(50), DataMember, JsonProperty("Descricao")]
		public string Descricao { get; set; }

		[DataMember, JsonProperty("Visivel")]
		public bool Visivel { get; set; }

		#endregion

		#region Metadados
		public static class METADADO
		{
			public static readonly TableReference tabelaNAME = "TipoCompromisso";
			public static readonly FieldReference Id = "TipoCompromisso.Id";
			public static readonly FieldReference Descricao = "TipoCompromisso.Descricao";
			public static readonly FieldReference Visivel = "TipoCompromisso.Visivel";
		}
		#endregion
	}
}
