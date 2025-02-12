
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
	public partial class CTC928 : EntityBase
	{
		#region Propriedades
		[Key, Identity]
		public int? Id { get; set; }

		public DateTime? DataReferencia { get; set; }

		[ForeignKey]
		public int? Arquivo { get; set; }

		#endregion

		#region Metadados
		public static class METADADO
		{
			public static readonly TableReference tabelaNAME = "CTC928";
			public static readonly FieldReference Id = "CTC928.Id";
			public static readonly FieldReference DataReferencia = "CTC928.DataReferencia";
			public static readonly FieldReference Arquivo = "CTC928.Arquivo";
		}
		#endregion
	}
}
