
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
	public partial class TipoPolitica : EntityBase
	{
		#region Propriedades
		[Key, Identity, DataMember, JsonProperty("Id")]
		public int? Id { get; set; }

		[DataLength(50), MaxLength(50), StringLength(50), DataMember, JsonProperty("Descricao")]
		public string Descricao { get; set; }

		#endregion

		#region Metadados
		public static class METADADO
		{
			public static readonly TableReference tabelaNAME = "TipoPolitica";
			public static readonly FieldReference Id = "TipoPolitica.Id";
			public static readonly FieldReference Descricao = "TipoPolitica.Descricao";
		}
		#endregion
	}
}
