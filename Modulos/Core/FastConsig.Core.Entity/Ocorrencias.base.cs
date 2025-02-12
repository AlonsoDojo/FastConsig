
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
	public partial class Ocorrencias : EntityBase
	{
		#region Propriedades
		[Key, Identity, DataMember, JsonProperty("Id")]
		public int? Id { get; set; }

		[DataLength(120), MaxLength(120), StringLength(120), DataMember, JsonProperty("Descricao")]
		public string Descricao { get; set; }

		[DataMember, JsonProperty("PermiteLiberacaoComplemento")]
		public bool PermiteLiberacaoComplemento { get; set; }

		[DataMember, JsonProperty("Pendencia")]
		public bool Pendencia { get; set; }

		[DataMember, JsonProperty("Recusa")]
		public bool Recusa { get; set; }

		[DataMember, JsonProperty("Informativa")]
		public bool Informativa { get; set; }

      [DataMember, JsonProperty("Sistema")]
      public bool Sistema { get; set; }
      #endregion

      #region Metadados
      public static class METADADO
		{
			public static readonly TableReference tabelaNAME = "Ocorrencias";
			public static readonly FieldReference Id = "Ocorrencias.Id";
			public static readonly FieldReference Descricao = "Ocorrencias.Descricao";
			public static readonly FieldReference PermiteLiberacaoComplemento = "Ocorrencias.PermiteLiberacaoComplemento";
			public static readonly FieldReference Pendencia = "Ocorrencias.Pendencia";
			public static readonly FieldReference Recusa = "Ocorrencias.Recusa";
			public static readonly FieldReference Informativa = "Ocorrencias.Informativa";
         public static readonly FieldReference Sistema = "Ocorrencias.Sistema";
      }
		#endregion
	}
}
