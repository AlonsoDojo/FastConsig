
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
	public partial class TipoBeneficioINSS : EntityBase
	{
		#region Propriedades
		[Key, Identity, DataMember, JsonProperty("Id")]
		public int? Id { get; set; }

		[DataLength(100), MaxLength(100), StringLength(100), DataMember, JsonProperty("Descricao")]
		public string Descricao { get; set; }

		[DataLength(100), MaxLength(100), StringLength(100), DataMember, JsonProperty("Utilizacao")]
		public string Utilizacao { get; set; }

		[DataMember, JsonProperty("Aceito")]
		public bool Aceito { get; set; }

		#endregion

		#region Metadados
		public static class METADADO
		{
			public static readonly TableReference tabelaNAME = "TipoBeneficioINSS";
			public static readonly FieldReference Id = "TipoBeneficioINSS.Id";
			public static readonly FieldReference Descricao = "TipoBeneficioINSS.Descricao";
			public static readonly FieldReference Utilizacao = "TipoBeneficioINSS.Utilizacao";
			public static readonly FieldReference Aceito = "TipoBeneficioINSS.Aceito";
		}
		#endregion
	}
}
