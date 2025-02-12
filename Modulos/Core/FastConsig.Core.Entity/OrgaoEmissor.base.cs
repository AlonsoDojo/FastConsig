
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
	public partial class OrgaoEmissor : EntityBase
	{
		#region Propriedades
		[Key, Identity, DataMember, JsonProperty("Id")]
		public int? Id { get; set; }

		[DataLength(50), MaxLength(50), StringLength(50), DataMember, JsonProperty("Descricao")]
		public string Descricao { get; set; }

		[DataLength(10), MaxLength(10), StringLength(10), DataMember, JsonProperty("Abreviatura")]
		public string Abreviatura { get; set; }

		[DataLength(10), MaxLength(10), StringLength(10), DataMember, JsonProperty("CodigoIntegracaoMatera")]
		public string CodigoIntegracaoMatera { get; set; }

		[DataLength(2), MaxLength(2), StringLength(2), DataMember, JsonProperty("CodigoIntegracaoSicred")]
		public string CodigoIntegracaoSicred { get; set; }

		[DataLength(2), MaxLength(2), StringLength(2), DataMember, JsonProperty("CodigoIntegracaoBMP")]
		public string CodigoIntegracaoBMP { get; set; }

		#endregion

		#region Metadados
		public static class METADADO
		{
			public static readonly TableReference tabelaNAME = "OrgaoEmissor";
			public static readonly FieldReference Id = "OrgaoEmissor.Id";
			public static readonly FieldReference Descricao = "OrgaoEmissor.Descricao";
			public static readonly FieldReference Abreviatura = "OrgaoEmissor.Abreviatura";
			public static readonly FieldReference CodigoIntegracaoMatera = "OrgaoEmissor.CodigoIntegracaoMatera";
			public static readonly FieldReference CodigoIntegracaoSicred = "OrgaoEmissor.CodigoIntegracaoSicred";
			public static readonly FieldReference CodigoIntegracaoBMP = "OrgaoEmissor.CodigoIntegracaoBMP";
		}
		#endregion
	}
}
