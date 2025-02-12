
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
	public partial class TipoComunicacao : EntityBase
	{
		#region Propriedades
		[Key, Identity, DataMember, JsonProperty("Id")]
		public int? Id { get; set; }

		[DataMember, JsonProperty("SMS")]
		public bool SMS { get; set; }

		[DataMember, JsonProperty("EMail")]
		public bool EMail { get; set; }

		[DataMember, JsonProperty("Whatsapp")]
		public bool Whatsapp { get; set; }

		[DataMember, JsonProperty("Fisico")]
		public bool Fisico { get; set; }

		#endregion

		#region Metadados
		public static class METADADO
		{
			public static readonly TableReference tabelaNAME = "TipoComunicacao";
			public static readonly FieldReference Id = "TipoComunicacao.Id";
			public static readonly FieldReference SMS = "TipoComunicacao.SMS";
			public static readonly FieldReference EMail = "TipoComunicacao.EMail";
			public static readonly FieldReference Whatsapp = "TipoComunicacao.Whatsapp";
			public static readonly FieldReference Fisico = "TipoComunicacao.Fisico";
		}
		#endregion
	}
}
