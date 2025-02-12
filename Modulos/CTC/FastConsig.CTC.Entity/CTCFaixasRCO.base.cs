
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
	public partial class CTCFaixasRCO : EntityBase
	{
		#region Propriedades
		[Key, Identity]
		public int? Id { get; set; }

		[ForeignKey]
		public int? Vigencia { get; set; }

		[ForeignKey, DataLength(4)]
		public string TipoContrato { get; set; }

		[DataLength(18,2)]
		public decimal? ValorInicial { get; set; }

		[DataLength(18,2)]
		public decimal? ValorFinal { get; set; }

		[DataLength(18,2)]
		public decimal? Valor { get; set; }

		[ForeignKey, DataLength(2)]
		public string EnteConsignante { get; set; }

		#endregion

		#region Metadados
		public static class METADADO
		{
			public static readonly TableReference tabelaNAME = "CTCFaixasRCO";
			public static readonly FieldReference Id = "CTCFaixasRCO.Id";
			public static readonly FieldReference Vigencia = "CTCFaixasRCO.Vigencia";
			public static readonly FieldReference TipoContrato = "CTCFaixasRCO.TipoContrato";
			public static readonly FieldReference ValorInicial = "CTCFaixasRCO.ValorInicial";
			public static readonly FieldReference ValorFinal = "CTCFaixasRCO.ValorFinal";
			public static readonly FieldReference Valor = "CTCFaixasRCO.Valor";
			public static readonly FieldReference EnteConsignante = "CTCFaixasRCO.EnteConsignante";
		}
		#endregion
	}
}
