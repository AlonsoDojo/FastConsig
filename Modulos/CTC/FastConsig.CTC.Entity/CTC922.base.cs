
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
	public partial class CTC922 : EntityBase
	{
		#region Propriedades
		[Key, Identity]
		public int? Id { get; set; }

		[ForeignKey]
		public int? Arquivo { get; set; }

		public DateTime? DataReferencia { get; set; }

		#endregion

		#region Metadados
		public static class METADADO
		{
			public static readonly TableReference tabelaNAME = "CTC922";
			public static readonly FieldReference Id = "CTC922.Id";
			public static readonly FieldReference Arquivo = "CTC922.Arquivo";
			public static readonly FieldReference DataReferencia = "CTC922.DataReferencia";
		}
		#endregion
	}
}
