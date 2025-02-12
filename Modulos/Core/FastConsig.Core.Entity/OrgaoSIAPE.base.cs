
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
	public partial class OrgaoSIAPE : EntityBase
	{
		#region Propriedades
		[DataMember, JsonProperty("Codigo")]
		public int? Codigo { get; set; }

		[DataLength(255), MaxLength(255), StringLength(255), DataMember, JsonProperty("Descricao")]
		public string Descricao { get; set; }

		[DataMember, JsonProperty("Ativo")]
		public bool Ativo { get; set; }

		#endregion

		#region Metadados
		public static class METADADO
		{
			public static readonly TableReference tabelaNAME = "OrgaoSIAPE";
			public static readonly FieldReference Codigo = "OrgaoSIAPE.Codigo";
			public static readonly FieldReference Descricao = "OrgaoSIAPE.Descricao";
			public static readonly FieldReference Ativo = "OrgaoSIAPE.Ativo";
		}
		#endregion
	}
}
