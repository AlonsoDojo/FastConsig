
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
	public partial class Fases : EntityBase
	{
		#region Propriedades
		[Key, Identity, DataMember, JsonProperty("Id")]
		public int? Id { get; set; }

		[DataLength(50), MaxLength(50), StringLength(50), DataMember, JsonProperty("Descricao")]
		public string Descricao { get; set; }

      public bool Sistema { get; set; }

      #endregion

      #region Metadados
      public static class METADADO
		{
			public static readonly TableReference tabelaNAME = "Fases";
			public static readonly FieldReference Id = "Fases.Id";
			public static readonly FieldReference Descricao = "Fases.Descricao";
         public static readonly FieldReference Sistema = "Fases.Sistema";
      }
		#endregion
	}
}
