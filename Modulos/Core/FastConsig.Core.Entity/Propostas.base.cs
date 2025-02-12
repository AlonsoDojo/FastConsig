
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
	public partial class Propostas : EntityBase
	{
		#region Propriedades
		[Key, Identity, DataMember, JsonProperty("Id")]
		public int? Id { get; set; }

		[DataMember, JsonProperty("DataCriacao")]
		public DateTime? DataCriacao { get; set; }

		[DataMember, JsonProperty("DataUltimaAlteracao")]
		public DateTime? DataUltimaAlteracao { get; set; }

		[DataMember, JsonProperty("Fase")]
		public int? Fase { get; set; }

		[DataMember, JsonProperty("Status")]
		public int? Status { get; set; }

		[DataLength(80), MaxLength(80), StringLength(80), DataMember, JsonProperty("Usuario")]
		public string Usuario { get; set; }

		[DataLength(2147483647), MaxLength(2147483647), StringLength(2147483647), DataMember, JsonProperty("Observacoes")]
		public string Observacoes { get; set; }

		[DataMember, JsonProperty("Gerente")]
		public int? Gerente { get; set; }

		[DataLength(2147483647), MaxLength(2147483647), StringLength(2147483647), DataMember, JsonProperty("MotivoRecusa")]
		public string MotivoRecusa { get; set; }

		[DataMember, JsonProperty("Promotora")]
		public int? Promotora { get; set; }

		[DataMember, JsonProperty("DataAtualizacao")]
		public DateTime? DataAtualizacao { get; set; }

		[DataLength(255), MaxLength(255), StringLength(255), DataMember, JsonProperty("UsuarioProposta")]
		public string UsuarioProposta { get; set; }

		[DataMember, JsonProperty("ProfissionalCertificado")]
		public long? ProfissionalCertificado { get; set; }

		[DataMember, JsonProperty("Pendente")]
		public bool Pendente { get; set; }

		[ForeignKey, DataMember, JsonProperty("TipoFormalizacao")]
		public int? TipoFormalizacao { get; set; }

		[DataMember, JsonProperty("TipoComunicacao")]
		public int? TipoComunicacao { get; set; }

		[DataLength(2147483647), MaxLength(2147483647), StringLength(2147483647), DataMember, JsonProperty("MensagemInterna")]
		public string MensagemInterna { get; set; }

		[DataMember, JsonProperty("Retencao")]
		public bool Retencao { get; set; }

		#endregion

		#region Metadados
		public static class METADADO
		{
			public static readonly TableReference tabelaNAME = "Propostas";
			public static readonly FieldReference Id = "Propostas.Id";
			public static readonly FieldReference DataCriacao = "Propostas.DataCriacao";
			public static readonly FieldReference DataUltimaAlteracao = "Propostas.DataUltimaAlteracao";
			public static readonly FieldReference Fase = "Propostas.Fase";
			public static readonly FieldReference Status = "Propostas.Status";
			public static readonly FieldReference Usuario = "Propostas.Usuario";
			public static readonly FieldReference Observacoes = "Propostas.Observacoes";
			public static readonly FieldReference Gerente = "Propostas.Gerente";
			public static readonly FieldReference MotivoRecusa = "Propostas.MotivoRecusa";
			public static readonly FieldReference Promotora = "Propostas.Promotora";
			public static readonly FieldReference DataAtualizacao = "Propostas.DataAtualizacao";
			public static readonly FieldReference UsuarioProposta = "Propostas.UsuarioProposta";
			public static readonly FieldReference ProfissionalCertificado = "Propostas.ProfissionalCertificado";
			public static readonly FieldReference Pendente = "Propostas.Pendente";
			public static readonly FieldReference TipoFormalizacao = "Propostas.TipoFormalizacao";
			public static readonly FieldReference TipoComunicacao = "Propostas.TipoComunicacao";
			public static readonly FieldReference MensagemInterna = "Propostas.MensagemInterna";
			public static readonly FieldReference Retencao = "Propostas.Retencao";
		}
		#endregion
	}
}
