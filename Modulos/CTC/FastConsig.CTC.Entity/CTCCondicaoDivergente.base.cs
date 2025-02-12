
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
	public partial class CTCCondicaoDivergente : EntityBase
	{
		#region Propriedades
		[Key, Identity]
		public int? Id { get; set; }

		[DataLength(3)]
		public string Codigo { get; set; }

		[DataLength(50)]
		public string Descricao { get; set; }

		#endregion

		#region Metadados
		public static class METADADO
		{
			public static readonly TableReference tabelaNAME = "CTCCondicaoDivergente";
			public static readonly FieldReference Id = "CTCCondicaoDivergente.Id";
			public static readonly FieldReference Codigo = "CTCCondicaoDivergente.Codigo";
			public static readonly FieldReference Descricao = "CTCCondicaoDivergente.Descricao";
		}
		#endregion
	}
}
