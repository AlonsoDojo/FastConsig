
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
	public partial class PoliticaConfiguracaoExecucaoSimulacao : EntityBase
	{
		#region Propriedades
		[Key, Identity, DataMember, JsonProperty("Id")]
		public int? Id { get; set; }

		[ForeignKey, DataMember, JsonProperty("Produto")]
		public int? Produto { get; set; }

		[ForeignKey, DataMember, JsonProperty("TipoPessoa")]
		public int? TipoPessoa { get; set; }

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
			public static readonly TableReference tabelaNAME = "PoliticaConfiguracaoExecucaoSimulacao";
			public static readonly FieldReference Id = "PoliticaConfiguracaoExecucaoSimulacao.Id";
			public static readonly FieldReference Produto = "PoliticaConfiguracaoExecucaoSimulacao.Produto";
			public static readonly FieldReference TipoPessoa = "PoliticaConfiguracaoExecucaoSimulacao.TipoPessoa";
			public static readonly FieldReference Politica = "PoliticaConfiguracaoExecucaoSimulacao.Politica";
			public static readonly FieldReference Peso = "PoliticaConfiguracaoExecucaoSimulacao.Peso";
			public static readonly FieldReference Entrada = "PoliticaConfiguracaoExecucaoSimulacao.Entrada";
			public static readonly FieldReference Saida = "PoliticaConfiguracaoExecucaoSimulacao.Saida";
		}
		#endregion
	}
}
