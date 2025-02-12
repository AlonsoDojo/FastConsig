
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
	public partial class CTCRequisicaoSimulacao : EntityBase
	{
		#region Propriedades
		[Key, Identity]
		public int? Id { get; set; }

		[ForeignKey]
		public int? Requisicao { get; set; }

		public int? Simulacao { get; set; }

		public DateTime? DataReferencia { get; set; }

		[DataLength(18,2)]
		public decimal? SaldoDevedor { get; set; }

		[DataLength(18,6)]
		public decimal? Taxa { get; set; }

		[DataLength(18,6)]
		public decimal? CET { get; set; }

		public int? Parcelas { get; set; }

		[DataLength(18,2)]
		public decimal? ValorParcela { get; set; }

		public DateTime? PrimeiroVencimento { get; set; }

		public DateTime? UltimoVencimento { get; set; }

		[ForeignKey]
		public int? Tipo { get; set; }

		[DataLength(4)]
		public string Tabela { get; set; }

		#endregion

		#region Metadados
		public static class METADADO
		{
			public static readonly TableReference tabelaNAME = "CTCRequisicaoSimulacao";
			public static readonly FieldReference Id = "CTCRequisicaoSimulacao.Id";
			public static readonly FieldReference Requisicao = "CTCRequisicaoSimulacao.Requisicao";
			public static readonly FieldReference Simulacao = "CTCRequisicaoSimulacao.Simulacao";
			public static readonly FieldReference DataReferencia = "CTCRequisicaoSimulacao.DataReferencia";
			public static readonly FieldReference SaldoDevedor = "CTCRequisicaoSimulacao.SaldoDevedor";
			public static readonly FieldReference Taxa = "CTCRequisicaoSimulacao.Taxa";
			public static readonly FieldReference CET = "CTCRequisicaoSimulacao.CET";
			public static readonly FieldReference Parcelas = "CTCRequisicaoSimulacao.Parcelas";
			public static readonly FieldReference ValorParcela = "CTCRequisicaoSimulacao.ValorParcela";
			public static readonly FieldReference PrimeiroVencimento = "CTCRequisicaoSimulacao.PrimeiroVencimento";
			public static readonly FieldReference UltimoVencimento = "CTCRequisicaoSimulacao.UltimoVencimento";
			public static readonly FieldReference Tipo = "CTCRequisicaoSimulacao.Tipo";
			public static readonly FieldReference Tabela = "CTCRequisicaoSimulacao.Tabela";
		}
		#endregion
	}
}
