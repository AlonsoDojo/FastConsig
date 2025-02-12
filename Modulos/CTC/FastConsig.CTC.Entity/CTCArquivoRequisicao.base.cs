
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
	public partial class CTCArquivoRequisicao : EntityBase
	{
		#region Propriedades
		[Key, Identity]
		public int? Id { get; set; }

		[ForeignKey]
		public int? Requisicao { get; set; }

		[ForeignKey]
		public int? Arquivo { get; set; }

		#endregion

		#region Metadados
		public static class METADADO
		{
			public static readonly TableReference tabelaNAME = "CTCArquivoRequisicao";
			public static readonly FieldReference Id = "CTCArquivoRequisicao.Id";
			public static readonly FieldReference Requisicao = "CTCArquivoRequisicao.Requisicao";
			public static readonly FieldReference Arquivo = "CTCArquivoRequisicao.Arquivo";
		}
		#endregion
	}
}
