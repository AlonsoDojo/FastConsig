
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
	public partial class Nacionalidade : EntityBase
	{
		#region Propriedades
		[Key, Identity, DataMember, JsonProperty("Id")]
		public int? Id { get; set; }

		[DataLength(50), MaxLength(50), StringLength(50), DataMember, JsonProperty("Descricao")]
		public string Descricao { get; set; }

		[DataLength(2), MaxLength(2), StringLength(2), DataMember, JsonProperty("CodigoIntegracaoMatera")]
		public string CodigoIntegracaoMatera { get; set; }

		[DataLength(2), MaxLength(2), StringLength(2), DataMember, JsonProperty("CodigoIntegracaoSicred")]
		public string CodigoIntegracaoSicred { get; set; }

		[DataLength(2), MaxLength(2), StringLength(2), DataMember, JsonProperty("CodigoIntegracaoBMP")]
		public string CodigoIntegracaoBMP { get; set; }

		#endregion

		#region Metadados
		public static class METADADO
		{
			public static readonly TableReference tabelaNAME = "Nacionalidade";
			public static readonly FieldReference Id = "Nacionalidade.Id";
			public static readonly FieldReference Descricao = "Nacionalidade.Descricao";
			public static readonly FieldReference CodigoIntegracaoMatera = "Nacionalidade.CodigoIntegracaoMatera";
			public static readonly FieldReference CodigoIntegracaoSicred = "Nacionalidade.CodigoIntegracaoSicred";
			public static readonly FieldReference CodigoIntegracaoBMP = "Nacionalidade.CodigoIntegracaoBMP";
		}
		#endregion
	}
}
