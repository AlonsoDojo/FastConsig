
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
	public partial class Estados : EntityBase
	{
		#region Propriedades
		[Key, DataLength(2), MaxLength(2), StringLength(2), DataMember, JsonProperty("Id")]
		public string Id { get; set; }

		[DataLength(50), MaxLength(50), StringLength(50), DataMember, JsonProperty("Nome")]
		public string Nome { get; set; }

		#endregion

		#region Metadados
		public static class METADADO
		{
			public static readonly TableReference tabelaNAME = "Estados";
			public static readonly FieldReference Id = "Estados.Id";
			public static readonly FieldReference Nome = "Estados.Nome";
		}
		#endregion
	}
}
