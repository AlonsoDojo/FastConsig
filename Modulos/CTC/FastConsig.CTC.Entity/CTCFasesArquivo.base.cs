
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
	public partial class CTCFasesArquivo : EntityBase
	{
		#region Propriedades
		[Key, Identity]
		public int? Id { get; set; }

		[ForeignKey]
		public int? Arquivo { get; set; }

		[ForeignKey]
		public int? Fase { get; set; }

		public int? Ordem { get; set; }

		#endregion

		#region Metadados
		public static class METADADO
		{
			public static readonly TableReference tabelaNAME = "CTCFasesArquivo";
			public static readonly FieldReference Id = "CTCFasesArquivo.Id";
			public static readonly FieldReference Arquivo = "CTCFasesArquivo.Arquivo";
			public static readonly FieldReference Fase = "CTCFasesArquivo.Fase";
			public static readonly FieldReference Ordem = "CTCFasesArquivo.Ordem";
		}
		#endregion
	}
}
