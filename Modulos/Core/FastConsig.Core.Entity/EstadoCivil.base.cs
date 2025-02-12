
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
	public partial class EstadoCivil : EntityBase
	{
		#region Propriedades
		[Key, Identity, DataMember, JsonProperty("Id")]
		public int? Id { get; set; }

		[DataLength(50), MaxLength(50), StringLength(50), DataMember, JsonProperty("Descricao")]
		public string Descricao { get; set; }

		[DataLength(1), MaxLength(1), StringLength(1), DataMember, JsonProperty("CodigoIntegracaoSicred")]
		public string CodigoIntegracaoSicred { get; set; }

		[DataMember, JsonProperty("CodigoIntegracaoMatera")]
		public int? CodigoIntegracaoMatera { get; set; }

		[DataMember, JsonProperty("CodigoIntegracaoBMP")]
		public int? CodigoIntegracaoBMP { get; set; }

		#endregion

		#region Metadados
		public static class METADADO
		{
			public static readonly TableReference tabelaNAME = "EstadoCivil";
			public static readonly FieldReference Id = "EstadoCivil.Id";
			public static readonly FieldReference Descricao = "EstadoCivil.Descricao";
			public static readonly FieldReference CodigoIntegracaoSicred = "EstadoCivil.CodigoIntegracaoSicred";
			public static readonly FieldReference CodigoIntegracaoMatera = "EstadoCivil.CodigoIntegracaoMatera";
			public static readonly FieldReference CodigoIntegracaoBMP = "EstadoCivil.CodigoIntegracaoBMP";
		}
		#endregion
	}
}
