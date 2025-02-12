
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
	public partial class CTC926Detalhes : EntityBase
	{
		#region Propriedades
		[Key, Identity]
		public int? Id { get; set; }

		[ForeignKey]
		public int? CTC926 { get; set; }

		public DateTime? DataReferencia { get; set; }

		public DateTime? DataProcessamentoArquivo { get; set; }

		[DataLength(50)]
		public string NomeArquivo { get; set; }

		[ForeignKey, DataLength(1)]
		public string TipoArquivo { get; set; }

		[DataLength(8)]
		public string ISPBEmissor { get; set; }

		[DataLength(8)]
		public string ISPBDestinatario { get; set; }

		#endregion

		#region Metadados
		public static class METADADO
		{
			public static readonly TableReference tabelaNAME = "CTC926Detalhes";
			public static readonly FieldReference Id = "CTC926Detalhes.Id";
			public static readonly FieldReference CTC926 = "CTC926Detalhes.CTC926";
			public static readonly FieldReference DataReferencia = "CTC926Detalhes.DataReferencia";
			public static readonly FieldReference DataProcessamentoArquivo = "CTC926Detalhes.DataProcessamentoArquivo";
			public static readonly FieldReference NomeArquivo = "CTC926Detalhes.NomeArquivo";
			public static readonly FieldReference TipoArquivo = "CTC926Detalhes.TipoArquivo";
			public static readonly FieldReference ISPBEmissor = "CTC926Detalhes.ISPBEmissor";
			public static readonly FieldReference ISPBDestinatario = "CTC926Detalhes.ISPBDestinatario";
		}
		#endregion
	}
}
