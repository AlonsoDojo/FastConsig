
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
	public partial class OcorrenciaProdutoFase : EntityBase
	{
		#region Propriedades
		[Key, Identity, DataMember, JsonProperty("Id")]
		public int? Id { get; set; }

		[ForeignKey, DataMember, JsonProperty("Ocorrencia")]
		public int? Ocorrencia { get; set; }

		[ForeignKey, DataMember, JsonProperty("Produto")]
		public int? Produto { get; set; }

		[ForeignKey, DataMember, JsonProperty("Fase")]
		public int? Fase { get; set; }

		[DataMember, JsonProperty("Severidade")]
		public int? Severidade { get; set; }

		[ForeignKey, DataMember, JsonProperty("FaseDestino")]
		public int? FaseDestino { get; set; }

		[DataLength(2147483647), MaxLength(2147483647), StringLength(2147483647), DataMember, JsonProperty("Validacoes")]
		public string Validacoes { get; set; }

		#endregion

		#region Metadados
		public static class METADADO
		{
			public static readonly TableReference tabelaNAME = "OcorrenciaProdutoFase";
			public static readonly FieldReference Id = "OcorrenciaProdutoFase.Id";
			public static readonly FieldReference Ocorrencia = "OcorrenciaProdutoFase.Ocorrencia";
			public static readonly FieldReference Produto = "OcorrenciaProdutoFase.Produto";
			public static readonly FieldReference Fase = "OcorrenciaProdutoFase.Fase";
			public static readonly FieldReference Severidade = "OcorrenciaProdutoFase.Severidade";
			public static readonly FieldReference FaseDestino = "OcorrenciaProdutoFase.FaseDestino";
			public static readonly FieldReference Validacoes = "OcorrenciaProdutoFase.Validacoes";
		}
		#endregion
	}
}
