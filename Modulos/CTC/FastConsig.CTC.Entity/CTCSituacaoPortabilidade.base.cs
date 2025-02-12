
#region Usings
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Framework;
using Framework.Data;
#endregion

namespace FastConsig.CTC.Entity
{
	[Serializable]
	public partial class CTCSituacaoPortabilidade : EntityBase
	{
		#region Propriedades
		[Key, Identity]
		public int? Id { get; set; }

		[DataLength(2)]
		public string Codigo { get; set; }

		[DataLength(150)]
		public string Descricao { get; set; }

		#endregion

		#region Metadados
		public static class METADADO
		{
			public static readonly TableReference tabelaNAME = "CTCSituacaoPortabilidade";
			public static readonly FieldReference Id = "CTCSituacaoPortabilidade.Id";
			public static readonly FieldReference Codigo = "CTCSituacaoPortabilidade.Codigo";
			public static readonly FieldReference Descricao = "CTCSituacaoPortabilidade.Descricao";
		}
		#endregion
	}
}
