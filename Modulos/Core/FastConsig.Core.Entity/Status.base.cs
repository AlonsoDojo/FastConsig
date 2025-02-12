
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
	public partial class Status : EntityBase
	{
		#region Propriedades
		[Key, Identity, DataMember, JsonProperty("Id")]
		public int? Id { get; set; }

		[DataLength(50), MaxLength(50), StringLength(50), DataMember, JsonProperty("Descricao")]
		public string Descricao { get; set; }

      [DataMember, JsonProperty("Sistema")]
      public bool Sistema { get; set; }

      #endregion

      #region Metadados
      public static class METADADO
		{
			public static readonly TableReference tabelaNAME = "Status";
			public static readonly FieldReference Id = "Status.Id";
			public static readonly FieldReference Descricao = "Status.Descricao";
         public static readonly FieldReference Sistema = "Status.Sistema";
      }
		#endregion
	}
}
