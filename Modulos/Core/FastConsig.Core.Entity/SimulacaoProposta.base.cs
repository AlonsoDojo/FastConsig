
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
	public partial class SimulacaoProposta : EntityBase
	{
		#region Propriedades
		[Key, Identity, DataMember, JsonProperty("Id")]
		public int? Id { get; set; }

		[DataMember, JsonProperty("DataCriacao")]
		public DateTime? DataCriacao { get; set; }

		[DataLength(80), MaxLength(80), StringLength(80), DataMember, JsonProperty("Usuario")]
		public string Usuario { get; set; }

		[ForeignKey, DataMember, JsonProperty("Promotora")]
		public int? Promotora { get; set; }

		[ForeignKey, DataMember, JsonProperty("Pessoa")]
		public int? Pessoa { get; set; }

		[DataMember, JsonProperty("TipoComunicacao")]
		public int? TipoComunicacao { get; set; }

		[DataLength(18,8), DataMember, JsonProperty("Taxa")]
		public decimal? Taxa { get; set; }

		[DataLength(50), MaxLength(50), StringLength(50), DataMember, JsonProperty("Guid")]
		public string Guid { get; set; }

		[DataMember, JsonProperty("Autorizacao")]
		public int? Autorizacao { get; set; }

		[DataMember, JsonProperty("TipoFormalizacao")]
		public int? TipoFormalizacao { get; set; }

		[DataMember, JsonProperty("Retencao")]
		public bool Retencao { get; set; }

		#endregion

		#region Metadados
		public static class METADADO
		{
			public static readonly TableReference tabelaNAME = "SimulacaoProposta";
			public static readonly FieldReference Id = "SimulacaoProposta.Id";
			public static readonly FieldReference DataCriacao = "SimulacaoProposta.DataCriacao";
			public static readonly FieldReference Usuario = "SimulacaoProposta.Usuario";
			public static readonly FieldReference Promotora = "SimulacaoProposta.Promotora";
			public static readonly FieldReference Pessoa = "SimulacaoProposta.Pessoa";
			public static readonly FieldReference TipoComunicacao = "SimulacaoProposta.TipoComunicacao";
			public static readonly FieldReference Taxa = "SimulacaoProposta.Taxa";
			public static readonly FieldReference Guid = "SimulacaoProposta.Guid";
			public static readonly FieldReference Autorizacao = "SimulacaoProposta.Autorizacao";
			public static readonly FieldReference TipoFormalizacao = "SimulacaoProposta.TipoFormalizacao";
			public static readonly FieldReference Retencao = "SimulacaoProposta.Retencao";
		}
		#endregion
	}
}
