
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
	public partial class AuditTable : EntityBase
	{
		#region Propriedades
		[Key, Identity, DataMember, JsonProperty("ID")]
		public int? ID { get; set; }

		[DataMember, JsonProperty("KeyFieldID")]
		public int? KeyFieldID { get; set; }

		[DataMember, JsonProperty("AuditActionTypeENUM")]
		public int? AuditActionTypeENUM { get; set; }

		[DataMember, JsonProperty("DateTimeStamp")]
		public DateTime? DateTimeStamp { get; set; }

		[DataLength(2147483647), MaxLength(2147483647), StringLength(2147483647), DataMember, JsonProperty("DataModel")]
		public string DataModel { get; set; }

		[DataLength(2147483647), MaxLength(2147483647), StringLength(2147483647), DataMember, JsonProperty("Changes")]
		public string Changes { get; set; }

		[DataLength(2147483647), MaxLength(2147483647), StringLength(2147483647), DataMember, JsonProperty("ValueBefore")]
		public string ValueBefore { get; set; }

		[DataLength(2147483647), MaxLength(2147483647), StringLength(2147483647), DataMember, JsonProperty("ValueAfter")]
		public string ValueAfter { get; set; }

		[DataLength(50), MaxLength(50), StringLength(50), DataMember, JsonProperty("Usuario")]
		public string Usuario { get; set; }

		#endregion

		#region Metadados
		public static class METADADO
		{
			public static readonly TableReference tabelaNAME = "AuditTable";
			public static readonly FieldReference ID = "AuditTable.ID";
			public static readonly FieldReference KeyFieldID = "AuditTable.KeyFieldID";
			public static readonly FieldReference AuditActionTypeENUM = "AuditTable.AuditActionTypeENUM";
			public static readonly FieldReference DateTimeStamp = "AuditTable.DateTimeStamp";
			public static readonly FieldReference DataModel = "AuditTable.DataModel";
			public static readonly FieldReference Changes = "AuditTable.Changes";
			public static readonly FieldReference ValueBefore = "AuditTable.ValueBefore";
			public static readonly FieldReference ValueAfter = "AuditTable.ValueAfter";
			public static readonly FieldReference Usuario = "AuditTable.Usuario";
		}
		#endregion
	}
}
