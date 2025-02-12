
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
	public partial class Compromissos : EntityBase
	{
		#region Propriedades
		[Key, Identity, DataMember, JsonProperty("Id")]
		public int? Id { get; set; }

		[DataMember, JsonProperty("Proposta")]
		public int? Proposta { get; set; }

		[DataMember, JsonProperty("Pessoa")]
		public int? Pessoa { get; set; }

		[DataLength(2), MaxLength(2), StringLength(2), DataMember, JsonProperty("TipoCompromisso")]
		public string TipoCompromisso { get; set; }

		#endregion

		#region Metadados
		public static class METADADO
		{
			public static readonly TableReference tabelaNAME = "Compromissos";
			public static readonly FieldReference Id = "Compromissos.Id";
			public static readonly FieldReference Proposta = "Compromissos.Proposta";
			public static readonly FieldReference Pessoa = "Compromissos.Pessoa";
			public static readonly FieldReference TipoCompromisso = "Compromissos.TipoCompromisso";
		}
		#endregion
	}
}
