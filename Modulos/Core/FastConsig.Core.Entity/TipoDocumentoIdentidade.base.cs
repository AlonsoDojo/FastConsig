
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
	public partial class TipoDocumentoIdentidade : EntityBase
	{
		#region Propriedades
		[Key, Identity, DataMember, JsonProperty("Id")]
		public int? Id { get; set; }

		[DataLength(40), MaxLength(40), StringLength(40), DataMember, JsonProperty("Descricao")]
		public string Descricao { get; set; }

		[DataLength(10), MaxLength(10), StringLength(10), DataMember, JsonProperty("Abreviatura")]
		public string Abreviatura { get; set; }

		[DataLength(5), MaxLength(5), StringLength(5), DataMember, JsonProperty("CodigoIntegracaoMatera")]
		public string CodigoIntegracaoMatera { get; set; }

		[DataLength(2), MaxLength(2), StringLength(2), DataMember, JsonProperty("CodigoIntegracaoSicred")]
		public string CodigoIntegracaoSicred { get; set; }

		[DataLength(5), MaxLength(5), StringLength(5), DataMember, JsonProperty("CodigoIntegracaoBMP")]
		public string CodigoIntegracaoBMP { get; set; }

		[DataMember, JsonProperty("Visivel")]
		public bool Visivel { get; set; }

		#endregion

		#region Metadados
		public static class METADADO
		{
			public static readonly TableReference tabelaNAME = "TipoDocumentoIdentidade";
			public static readonly FieldReference Id = "TipoDocumentoIdentidade.Id";
			public static readonly FieldReference Descricao = "TipoDocumentoIdentidade.Descricao";
			public static readonly FieldReference Abreviatura = "TipoDocumentoIdentidade.Abreviatura";
			public static readonly FieldReference CodigoIntegracaoMatera = "TipoDocumentoIdentidade.CodigoIntegracaoMatera";
			public static readonly FieldReference CodigoIntegracaoSicred = "TipoDocumentoIdentidade.CodigoIntegracaoSicred";
			public static readonly FieldReference CodigoIntegracaoBMP = "TipoDocumentoIdentidade.CodigoIntegracaoBMP";
			public static readonly FieldReference Visivel = "TipoDocumentoIdentidade.Visivel";
		}
		#endregion
	}
}
