
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
	public partial class CTCFasesFluxo : EntityBase
	{
		#region Propriedades
		[Key]
		public int? Id { get; set; }

		[ForeignKey]
		public int? TipoArquivo { get; set; }

		[ForeignKey]
		public int? TipoFluxo { get; set; }

		[ForeignKey]
		public int? Fase { get; set; }

		[DataLength(50)]
		public string Status { get; set; }

		public int? Ordem { get; set; }

		#endregion

		#region Metadados
		public static class METADADO
		{
			public static readonly TableReference tabelaNAME = "CTCFasesFluxo";
			public static readonly FieldReference Id = "CTCFasesFluxo.Id";
			public static readonly FieldReference TipoArquivo = "CTCFasesFluxo.TipoArquivo";
			public static readonly FieldReference TipoFluxo = "CTCFasesFluxo.TipoFluxo";
			public static readonly FieldReference Fase = "CTCFasesFluxo.Fase";
			public static readonly FieldReference Status = "CTCFasesFluxo.Status";
			public static readonly FieldReference Ordem = "CTCFasesFluxo.Ordem";
		}
		#endregion
	}
}
