
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
	public partial class PropostaHierarquiaConsulta : EntityBase
	{
		#region Propriedades
		[Key, Identity, DataMember, JsonProperty("Id")]
		public int? Id { get; set; }

		[DataMember, JsonProperty("Proposta")]
		public int? Proposta { get; set; }

		[DataMember, JsonProperty("Nivel")]
		public int? Nivel { get; set; }

		[DataMember, JsonProperty("Pessoa")]
		public int? Pessoa { get; set; }

		[DataMember, JsonProperty("PessoaPai")]
		public int? PessoaPai { get; set; }

		[DataLength(2), MaxLength(2), StringLength(2), DataMember, JsonProperty("Papel")]
		public string Papel { get; set; }

		[DataLength(5,2), DataMember, JsonProperty("Participacao")]
		public decimal? Participacao { get; set; }

		#endregion

		#region Metadados
		public static class METADADO
		{
			public static readonly TableReference tabelaNAME = "PropostaHierarquiaConsulta";
			public static readonly FieldReference Id = "PropostaHierarquiaConsulta.Id";
			public static readonly FieldReference Proposta = "PropostaHierarquiaConsulta.Proposta";
			public static readonly FieldReference Nivel = "PropostaHierarquiaConsulta.Nivel";
			public static readonly FieldReference Pessoa = "PropostaHierarquiaConsulta.Pessoa";
			public static readonly FieldReference PessoaPai = "PropostaHierarquiaConsulta.PessoaPai";
			public static readonly FieldReference Papel = "PropostaHierarquiaConsulta.Papel";
			public static readonly FieldReference Participacao = "PropostaHierarquiaConsulta.Participacao";
		}
		#endregion
	}
}
