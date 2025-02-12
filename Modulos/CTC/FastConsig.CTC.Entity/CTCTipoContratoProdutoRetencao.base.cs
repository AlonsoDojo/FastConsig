
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
	public partial class CTCTipoContratoProdutoRetencao : EntityBase
	{
		#region Propriedades
		[Key, Identity]
		public int? Id { get; set; }

		[ForeignKey, DataLength(4)]
		public string TipoContrato { get; set; }

		[ForeignKey, DataLength(2)]
		public string EnteConsignante { get; set; }

		[DataLength(6)]
		public string ProdutoOrigem { get; set; }

		[ForeignKey]
		public int? ProdutoRetencao { get; set; }

		[ForeignKey]
		public int? ContaPagamento { get; set; }

		#endregion

		#region Metadados
		public static class METADADO
		{
			public static readonly TableReference tabelaNAME = "CTCTipoContratoProdutoRetencao";
			public static readonly FieldReference Id = "CTCTipoContratoProdutoRetencao.Id";
			public static readonly FieldReference TipoContrato = "CTCTipoContratoProdutoRetencao.TipoContrato";
			public static readonly FieldReference EnteConsignante = "CTCTipoContratoProdutoRetencao.EnteConsignante";
			public static readonly FieldReference ProdutoOrigem = "CTCTipoContratoProdutoRetencao.ProdutoOrigem";
			public static readonly FieldReference ProdutoRetencao = "CTCTipoContratoProdutoRetencao.ProdutoRetencao";
			public static readonly FieldReference ContaPagamento = "CTCTipoContratoProdutoRetencao.ContaPagamento";
		}
		#endregion
	}
}
