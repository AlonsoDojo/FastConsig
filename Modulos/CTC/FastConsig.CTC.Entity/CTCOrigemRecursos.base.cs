
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
	public partial class CTCOrigemRecursos : EntityBase
	{
		#region Propriedades
		[Key, Identity]
		public int? Id { get; set; }

		[DataLength(4)]
		public string Codigo { get; set; }

		[DataLength(150)]
		public string Descricao { get; set; }

		#endregion

		#region Metadados
		public static class METADADO
		{
			public static readonly TableReference tabelaNAME = "CTCOrigemRecursos";
			public static readonly FieldReference Id = "CTCOrigemRecursos.Id";
			public static readonly FieldReference Codigo = "CTCOrigemRecursos.Codigo";
			public static readonly FieldReference Descricao = "CTCOrigemRecursos.Descricao";
		}
		#endregion
	}
}
