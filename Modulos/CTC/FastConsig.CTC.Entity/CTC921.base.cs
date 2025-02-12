
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
	public partial class CTC921 : EntityBase
	{
		#region Propriedades
		[Key, Identity]
		public int? Id { get; set; }

		public DateTime? DataReferenciaArquivo { get; set; }

		[ForeignKey, DataLength(1)]
		public string TipoRelatorio { get; set; }

		[DataLength(6)]
		public string MesAno { get; set; }

		public DateTime? DataInicio { get; set; }

		public DateTime? DataFim { get; set; }

		[ForeignKey, DataLength(1)]
		public string SituacaoProcessamento { get; set; }

		[ForeignKey]
		public int? Arquivo { get; set; }

		#endregion

		#region Metadados
		public static class METADADO
		{
			public static readonly TableReference tabelaNAME = "CTC921";
			public static readonly FieldReference Id = "CTC921.Id";
			public static readonly FieldReference DataReferenciaArquivo = "CTC921.DataReferenciaArquivo";
			public static readonly FieldReference TipoRelatorio = "CTC921.TipoRelatorio";
			public static readonly FieldReference MesAno = "CTC921.MesAno";
			public static readonly FieldReference DataInicio = "CTC921.DataInicio";
			public static readonly FieldReference DataFim = "CTC921.DataFim";
			public static readonly FieldReference SituacaoProcessamento = "CTC921.SituacaoProcessamento";
			public static readonly FieldReference Arquivo = "CTC921.Arquivo";
		}
		#endregion
	}
}
