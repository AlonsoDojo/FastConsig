
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
	public partial class TipoDocumento : EntityBase
	{
		#region Propriedades
		[Key, Identity, DataMember, JsonProperty("Id")]
		public int? Id { get; set; }

		[DataLength(100), MaxLength(100), StringLength(100), DataMember, JsonProperty("Descricao")]
		public string Descricao { get; set; }

		[DataMember, JsonProperty("Selecionavel")]
		public bool Selecionavel { get; set; }

		#endregion

		#region Metadados
		public static class METADADO
		{
			public static readonly TableReference tabelaNAME = "TipoDocumento";
			public static readonly FieldReference Id = "TipoDocumento.Id";
			public static readonly FieldReference Descricao = "TipoDocumento.Descricao";
			public static readonly FieldReference Selecionavel = "TipoDocumento.Selecionavel";
		}
		#endregion
	}
}
