
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
	public partial class PropostaPendencia : EntityBase
	{
		#region Propriedades
		[Key, Identity, DataMember, JsonProperty("Id")]
		public int? Id { get; set; }

		[ForeignKey, DataMember, JsonProperty("Proposta")]
		public int? Proposta { get; set; }

		[DataMember, JsonProperty("DataHora")]
		public DateTime? DataHora { get; set; }

		[ForeignKey, DataMember, JsonProperty("FaseAtual")]
		public int? FaseAtual { get; set; }

		[DataMember, JsonProperty("StatusAtual")]
		public int? StatusAtual { get; set; }

		[ForeignKey, DataMember, JsonProperty("FaseDestino")]
		public int? FaseDestino { get; set; }

		[DataMember, JsonProperty("Concluido")]
		public bool Concluido { get; set; }

		[DataLength(100), MaxLength(100), StringLength(100), DataMember, JsonProperty("Analista")]
		public string Analista { get; set; }

		[DataLength(2147483647), MaxLength(2147483647), StringLength(2147483647), DataMember, JsonProperty("Validacoes")]
		public string Validacoes { get; set; }

		#endregion

		#region Metadados
		public static class METADADO
		{
			public static readonly TableReference tabelaNAME = "PropostaPendencia";
			public static readonly FieldReference Id = "PropostaPendencia.Id";
			public static readonly FieldReference Proposta = "PropostaPendencia.Proposta";
			public static readonly FieldReference DataHora = "PropostaPendencia.DataHora";
			public static readonly FieldReference FaseAtual = "PropostaPendencia.FaseAtual";
			public static readonly FieldReference StatusAtual = "PropostaPendencia.StatusAtual";
			public static readonly FieldReference FaseDestino = "PropostaPendencia.FaseDestino";
			public static readonly FieldReference Concluido = "PropostaPendencia.Concluido";
			public static readonly FieldReference Analista = "PropostaPendencia.Analista";
			public static readonly FieldReference Validacoes = "PropostaPendencia.Validacoes";
		}
		#endregion
	}
}
