
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
	public partial class CTC922Detalhes : EntityBase
	{
		#region Propriedades
		[Key, Identity]
		public int? Id { get; set; }

		[ForeignKey]
		public int? CTC922 { get; set; }

		[ForeignKey]
		public int? TipoParte { get; set; }

		[ForeignKey, DataLength(3)]
		public string MotivoRetencao { get; set; }

		public int? QtdRetencao { get; set; }

		[ForeignKey, DataLength(3)]
		public string MotivoDecursoPrazo { get; set; }

		public int? QtdDecursoPrazo { get; set; }

		[ForeignKey, DataLength(3)]
		public string MotivoCancelamento { get; set; }

		public int? QtdCancelamento { get; set; }

		[ForeignKey, DataLength(2)]
		public string MotivoDevolucaoLiquidacao { get; set; }

		public int? QtdDevolucaoLiquidacao { get; set; }

		[ForeignKey, DataLength(4)]
		public string TipoContrato { get; set; }

		[ForeignKey, DataLength(2)]
		public string EnteConsignante { get; set; }

		[ForeignKey, DataLength(2)]
		public string SituacaoPortabilidade { get; set; }

		public int? QtdSituacaoPortabilidade { get; set; }

		#endregion

		#region Metadados
		public static class METADADO
		{
			public static readonly TableReference tabelaNAME = "CTC922Detalhes";
			public static readonly FieldReference Id = "CTC922Detalhes.Id";
			public static readonly FieldReference CTC922 = "CTC922Detalhes.CTC922";
			public static readonly FieldReference TipoParte = "CTC922Detalhes.TipoParte";
			public static readonly FieldReference MotivoRetencao = "CTC922Detalhes.MotivoRetencao";
			public static readonly FieldReference QtdRetencao = "CTC922Detalhes.QtdRetencao";
			public static readonly FieldReference MotivoDecursoPrazo = "CTC922Detalhes.MotivoDecursoPrazo";
			public static readonly FieldReference QtdDecursoPrazo = "CTC922Detalhes.QtdDecursoPrazo";
			public static readonly FieldReference MotivoCancelamento = "CTC922Detalhes.MotivoCancelamento";
			public static readonly FieldReference QtdCancelamento = "CTC922Detalhes.QtdCancelamento";
			public static readonly FieldReference MotivoDevolucaoLiquidacao = "CTC922Detalhes.MotivoDevolucaoLiquidacao";
			public static readonly FieldReference QtdDevolucaoLiquidacao = "CTC922Detalhes.QtdDevolucaoLiquidacao";
			public static readonly FieldReference TipoContrato = "CTC922Detalhes.TipoContrato";
			public static readonly FieldReference EnteConsignante = "CTC922Detalhes.EnteConsignante";
			public static readonly FieldReference SituacaoPortabilidade = "CTC922Detalhes.SituacaoPortabilidade";
			public static readonly FieldReference QtdSituacaoPortabilidade = "CTC922Detalhes.QtdSituacaoPortabilidade";
		}
		#endregion
	}
}
