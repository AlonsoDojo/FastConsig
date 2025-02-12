
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
	public partial class PropostaOcorrencias : EntityBase
	{
		#region Propriedades
		[DataMember, JsonProperty("Proposta")]
		public int? Proposta { get; set; }

		[DataMember, JsonProperty("Ocorrencia")]
		public int? Ocorrencia { get; set; }

		[DataMember, JsonProperty("DataOcorrencia")]
		public DateTime? DataOcorrencia { get; set; }

		[DataMember, JsonProperty("Restritiva")]
		public string Restritiva { get; set; }

		[DataLength(2147483647), MaxLength(2147483647), StringLength(2147483647), DataMember, JsonProperty("Complemento")]
		public string Complemento { get; set; }

		[Key, Identity, DataMember, JsonProperty("Id")]
		public int? Id { get; set; }

		[DataMember, JsonProperty("Liberada")]
		public bool Liberada { get; set; }

		[DataLength(100), MaxLength(100), StringLength(100), DataMember, JsonProperty("UsuarioLiberador")]
		public string UsuarioLiberador { get; set; }

		[DataLength(2147483647), MaxLength(2147483647), StringLength(2147483647), DataMember, JsonProperty("Motivo")]
		public string Motivo { get; set; }

		[DataMember, JsonProperty("DataHoraLiberacao")]
		public DateTime? DataHoraLiberacao { get; set; }

		[DataMember, JsonProperty("Severidade")]
		public int? Severidade { get; set; }

		[DataMember, JsonProperty("Fase")]
		public int? Fase { get; set; }

		[DataLength(50), MaxLength(50), StringLength(50), DataMember, JsonProperty("Usuario")]
		public string Usuario { get; set; }

		[DataMember, JsonProperty("Pessoa")]
		public int? Pessoa { get; set; }

		#endregion

		#region Metadados
		public static class METADADO
		{
			public static readonly TableReference tabelaNAME = "PropostaOcorrencias";
			public static readonly FieldReference Proposta = "PropostaOcorrencias.Proposta";
			public static readonly FieldReference Ocorrencia = "PropostaOcorrencias.Ocorrencia";
			public static readonly FieldReference DataOcorrencia = "PropostaOcorrencias.DataOcorrencia";
			public static readonly FieldReference Restritiva = "PropostaOcorrencias.Restritiva";
			public static readonly FieldReference Complemento = "PropostaOcorrencias.Complemento";
			public static readonly FieldReference Id = "PropostaOcorrencias.Id";
			public static readonly FieldReference Liberada = "PropostaOcorrencias.Liberada";
			public static readonly FieldReference UsuarioLiberador = "PropostaOcorrencias.UsuarioLiberador";
			public static readonly FieldReference Motivo = "PropostaOcorrencias.Motivo";
			public static readonly FieldReference DataHoraLiberacao = "PropostaOcorrencias.DataHoraLiberacao";
			public static readonly FieldReference Severidade = "PropostaOcorrencias.Severidade";
			public static readonly FieldReference Fase = "PropostaOcorrencias.Fase";
			public static readonly FieldReference Usuario = "PropostaOcorrencias.Usuario";
			public static readonly FieldReference Pessoa = "PropostaOcorrencias.Pessoa";
		}
		#endregion
	}
}
