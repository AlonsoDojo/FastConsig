
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
	public partial class AutorizacaoDigitalConsignado : EntityBase
	{
		#region Propriedades
		[Key, Identity, DataMember, JsonProperty("Id")]
		public int? Id { get; set; }

		[DataMember, JsonProperty("Cpf")]
		public long? Cpf { get; set; }

		[DataMember, JsonProperty("TipoComunicacao")]
		public int? TipoComunicacao { get; set; }

		[DataMember, JsonProperty("Finalizado")]
		public bool Finalizado { get; set; }

		[DataMember, JsonProperty("DDD")]
		public int? DDD { get; set; }

		[DataMember, JsonProperty("Celular")]
		public long? Celular { get; set; }

		[DataMember, JsonProperty("DataHoraInicio")]
		public DateTime? DataHoraInicio { get; set; }

		[DataMember, JsonProperty("DataHoraFim")]
		public DateTime? DataHoraFim { get; set; }

		[DataLength(100), MaxLength(100), StringLength(100), DataMember, JsonProperty("NomeMae")]
		public string NomeMae { get; set; }

		[DataMember, JsonProperty("DataNascimento")]
		public DateTime? DataNascimento { get; set; }

		[DataLength(100), MaxLength(100), StringLength(100), DataMember, JsonProperty("Nome")]
		public string Nome { get; set; }

		[DataMember, JsonProperty("Consulta")]
		public int? Consulta { get; set; }

		[DataMember, JsonProperty("Simulacao")]
		public int? Simulacao { get; set; }

		#endregion

		#region Metadados
		public static class METADADO
		{
			public static readonly TableReference tabelaNAME = "AutorizacaoDigitalConsignado";
			public static readonly FieldReference Id = "AutorizacaoDigitalConsignado.Id";
			public static readonly FieldReference Cpf = "AutorizacaoDigitalConsignado.Cpf";
			public static readonly FieldReference TipoComunicacao = "AutorizacaoDigitalConsignado.TipoComunicacao";
			public static readonly FieldReference Finalizado = "AutorizacaoDigitalConsignado.Finalizado";
			public static readonly FieldReference DDD = "AutorizacaoDigitalConsignado.DDD";
			public static readonly FieldReference Celular = "AutorizacaoDigitalConsignado.Celular";
			public static readonly FieldReference DataHoraInicio = "AutorizacaoDigitalConsignado.DataHoraInicio";
			public static readonly FieldReference DataHoraFim = "AutorizacaoDigitalConsignado.DataHoraFim";
			public static readonly FieldReference NomeMae = "AutorizacaoDigitalConsignado.NomeMae";
			public static readonly FieldReference DataNascimento = "AutorizacaoDigitalConsignado.DataNascimento";
			public static readonly FieldReference Nome = "AutorizacaoDigitalConsignado.Nome";
			public static readonly FieldReference Consulta = "AutorizacaoDigitalConsignado.Consulta";
			public static readonly FieldReference Simulacao = "AutorizacaoDigitalConsignado.Simulacao";
		}
		#endregion
	}
}
