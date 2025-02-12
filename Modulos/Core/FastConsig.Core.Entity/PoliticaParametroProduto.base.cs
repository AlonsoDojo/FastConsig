
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
	public partial class PoliticaParametroProduto : EntityBase
	{
		#region Propriedades
		[Key, Identity, DataMember, JsonProperty("Id")]
		public int? Id { get; set; }

		[ForeignKey, DataMember, JsonProperty("Politica")]
		public int? Politica { get; set; }

		[DataMember, JsonProperty("Produto")]
		public int? Produto { get; set; }

		[DataLength(2147483647), MaxLength(2147483647), StringLength(2147483647), DataMember, JsonProperty("Parametros")]
		public string Parametros { get; set; }

		#endregion

		#region Metadados
		public static class METADADO
		{
			public static readonly TableReference tabelaNAME = "PoliticaParametroProduto";
			public static readonly FieldReference Id = "PoliticaParametroProduto.Id";
			public static readonly FieldReference Politica = "PoliticaParametroProduto.Politica";
			public static readonly FieldReference Produto = "PoliticaParametroProduto.Produto";
			public static readonly FieldReference Parametros = "PoliticaParametroProduto.Parametros";
		}
		#endregion
	}
}
