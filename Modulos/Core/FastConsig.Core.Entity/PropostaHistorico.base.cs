
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
	public partial class PropostaHistorico : EntityBase
	{
		#region Propriedades
		[Key, Identity, DataMember, JsonProperty("Id")]
		public int? Id { get; set; }

		[ForeignKey, DataMember, JsonProperty("Proposta")]
		public int? Proposta { get; set; }

		[DataMember, JsonProperty("Fase")]
		public int? Fase { get; set; }

		[DataMember, JsonProperty("DataExecucao")]
		public DateTime? DataExecucao { get; set; }

		[DataLength(100), MaxLength(100), StringLength(100), DataMember, JsonProperty("Usuario")]
		public string Usuario { get; set; }

		[ForeignKey, DataMember, JsonProperty("Simulacao")]
		public int? Simulacao { get; set; }

		[DataLength(2147483647), MaxLength(2147483647), StringLength(2147483647), DataMember, JsonProperty("Acao")]
		public string Acao { get; set; }

		#endregion

		#region Metadados
		public static class METADADO
		{
			public static readonly TableReference tabelaNAME = "PropostaHistorico";
			public static readonly FieldReference Id = "PropostaHistorico.Id";
			public static readonly FieldReference Proposta = "PropostaHistorico.Proposta";
			public static readonly FieldReference Fase = "PropostaHistorico.Fase";
			public static readonly FieldReference DataExecucao = "PropostaHistorico.DataExecucao";
			public static readonly FieldReference Usuario = "PropostaHistorico.Usuario";
			public static readonly FieldReference Simulacao = "PropostaHistorico.Simulacao";
			public static readonly FieldReference Acao = "PropostaHistorico.Acao";
		}
		#endregion
	}
}
