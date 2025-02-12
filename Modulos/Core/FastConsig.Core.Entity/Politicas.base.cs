
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
	public partial class Politicas : EntityBase
	{
		#region Propriedades
		[Key, Identity, DataMember, JsonProperty("Id")]
		public int? Id { get; set; }

		[DataLength(255), MaxLength(255), StringLength(255), DataMember, JsonProperty("Descricao")]
		public string Descricao { get; set; }

		[DataLength(2147483647), MaxLength(2147483647), StringLength(2147483647), DataMember, JsonProperty("Metodo")]
		public string Metodo { get; set; }

		[ForeignKey, DataMember, JsonProperty("TipoPolitica")]
		public int? TipoPolitica { get; set; }

		[DataMember, JsonProperty("Simulacao")]
		public bool Simulacao { get; set; }

		[DataLength(2147483647), MaxLength(2147483647), StringLength(2147483647), DataMember, JsonProperty("ParametrosDefault")]
		public string ParametrosDefault { get; set; }

		#endregion

		#region Metadados
		public static class METADADO
		{
			public static readonly TableReference tabelaNAME = "Politicas";
			public static readonly FieldReference Id = "Politicas.Id";
			public static readonly FieldReference Descricao = "Politicas.Descricao";
			public static readonly FieldReference Metodo = "Politicas.Metodo";
			public static readonly FieldReference TipoPolitica = "Politicas.TipoPolitica";
			public static readonly FieldReference Simulacao = "Politicas.Simulacao";
			public static readonly FieldReference ParametrosDefault = "Politicas.ParametrosDefault";
		}
		#endregion
	}
}
