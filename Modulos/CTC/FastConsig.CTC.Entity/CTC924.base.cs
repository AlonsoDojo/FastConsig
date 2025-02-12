
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
	public partial class CTC924 : EntityBase
	{
		#region Propriedades
		[Key, Identity]
		public int? Id { get; set; }

		[ForeignKey]
		public int? Arquivo { get; set; }

		public DateTime? DataReferencia { get; set; }

		public DateTime? PeriodoInicial { get; set; }

		public DateTime? PeriodoFinal { get; set; }

		#endregion

		#region Metadados
		public static class METADADO
		{
			public static readonly TableReference tabelaNAME = "CTC924";
			public static readonly FieldReference Id = "CTC924.Id";
			public static readonly FieldReference Arquivo = "CTC924.Arquivo";
			public static readonly FieldReference DataReferencia = "CTC924.DataReferencia";
			public static readonly FieldReference PeriodoInicial = "CTC924.PeriodoInicial";
			public static readonly FieldReference PeriodoFinal = "CTC924.PeriodoFinal";
		}
		#endregion
	}
}
