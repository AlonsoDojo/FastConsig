
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
	public partial class PoliticaConfiguracaoExecucao : EntityBase
	{
		#region Propriedades
		[Key, Identity, DataMember, JsonProperty("Id")]
		public int? Id { get; set; }

		[ForeignKey, DataMember, JsonProperty("Produto")]
		public int? Produto { get; set; }

		[ForeignKey, DataMember, JsonProperty("TipoPessoa")]
		public int? TipoPessoa { get; set; }

		[ForeignKey, DataMember, JsonProperty("Fase")]
		public int? Fase { get; set; }

		[ForeignKey, DataMember, JsonProperty("Politica")]
		public int? Politica { get; set; }

		[DataMember, JsonProperty("Peso")]
		public int? Peso { get; set; }

		[DataMember, JsonProperty("Entrada")]
		public bool Entrada { get; set; }

		[DataMember, JsonProperty("Saida")]
		public bool Saida { get; set; }

		#endregion

		#region Metadados
		public static class METADADO
		{
			public static readonly TableReference tabelaNAME = "PoliticaConfiguracaoExecucao";
			public static readonly FieldReference Id = "PoliticaConfiguracaoExecucao.Id";
			public static readonly FieldReference Produto = "PoliticaConfiguracaoExecucao.Produto";
			public static readonly FieldReference TipoPessoa = "PoliticaConfiguracaoExecucao.TipoPessoa";
			public static readonly FieldReference Fase = "PoliticaConfiguracaoExecucao.Fase";
			public static readonly FieldReference Politica = "PoliticaConfiguracaoExecucao.Politica";
			public static readonly FieldReference Peso = "PoliticaConfiguracaoExecucao.Peso";
			public static readonly FieldReference Entrada = "PoliticaConfiguracaoExecucao.Entrada";
			public static readonly FieldReference Saida = "PoliticaConfiguracaoExecucao.Saida";
		}
		#endregion
	}
}
