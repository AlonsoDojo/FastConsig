
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
	public partial class CTCTipoArquivoEnviado : EntityBase
	{
		#region Propriedades
		[Key, Identity]
		public int? Id { get; set; }

		[DataLength(1)]
		public string Codigo { get; set; }

		[DataLength(50)]
		public string Descricao { get; set; }

		#endregion

		#region Metadados
		public static class METADADO
		{
			public static readonly TableReference tabelaNAME = "CTCTipoArquivoEnviado";
			public static readonly FieldReference Id = "CTCTipoArquivoEnviado.Id";
			public static readonly FieldReference Codigo = "CTCTipoArquivoEnviado.Codigo";
			public static readonly FieldReference Descricao = "CTCTipoArquivoEnviado.Descricao";
		}
		#endregion
	}
}
