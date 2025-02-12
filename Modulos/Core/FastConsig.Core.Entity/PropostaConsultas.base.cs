
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
	public partial class PropostaConsultas : EntityBase
	{
		#region Propriedades
		[Key, Identity, DataMember, JsonProperty("Id")]
		public int? Id { get; set; }

		[DataMember, JsonProperty("Pessoa")]
		public int? Pessoa { get; set; }

		[DataMember, JsonProperty("Proposta")]
		public int? Proposta { get; set; }

		[DataLength(100), MaxLength(100), StringLength(100), DataMember, JsonProperty("Consulta")]
		public string Consulta { get; set; }

		[DataMember, JsonProperty("IdConsulta")]
		public int? IdConsulta { get; set; }

		[DataMember, JsonProperty("Resultado")]
		public byte[] Resultado { get; set; }

		#endregion

		#region Metadados
		public static class METADADO
		{
			public static readonly TableReference tabelaNAME = "PropostaConsultas";
			public static readonly FieldReference Id = "PropostaConsultas.Id";
			public static readonly FieldReference Pessoa = "PropostaConsultas.Pessoa";
			public static readonly FieldReference Proposta = "PropostaConsultas.Proposta";
			public static readonly FieldReference Consulta = "PropostaConsultas.Consulta";
			public static readonly FieldReference IdConsulta = "PropostaConsultas.IdConsulta";
			public static readonly FieldReference Resultado = "PropostaConsultas.Resultado";
		}
		#endregion
	}
}
