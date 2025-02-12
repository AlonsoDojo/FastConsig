
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
	public partial class FasesProduto : EntityBase
	{
		#region Propriedades
		[Key, Identity, DataMember, JsonProperty("Id")]
		public int? Id { get; set; }

		[ForeignKey, DataMember, JsonProperty("Produto")]
		public int? Produto { get; set; }

		[ForeignKey, DataMember, JsonProperty("Fase")]
		public int? Fase { get; set; }

		[DataMember, JsonProperty("Ordem")]
		public int? Ordem { get; set; }

		#endregion

		#region Metadados
		public static class METADADO
		{
			public static readonly TableReference tabelaNAME = "FasesProduto";
			public static readonly FieldReference Id = "FasesProduto.Id";
			public static readonly FieldReference Produto = "FasesProduto.Produto";
			public static readonly FieldReference Fase = "FasesProduto.Fase";
			public static readonly FieldReference Ordem = "FasesProduto.Ordem";
		}
		#endregion
	}
}
