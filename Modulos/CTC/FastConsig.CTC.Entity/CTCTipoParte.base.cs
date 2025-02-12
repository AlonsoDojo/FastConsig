
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
	public partial class CTCTipoParte : EntityBase
	{
		#region Propriedades
		[Key, Identity]
		public int? Id { get; set; }

		[DataLength(50)]
		public string Descricao { get; set; }

		[DataLength(8)]
		public string ISPB { get; set; }

		#endregion

		#region Metadados
		public static class METADADO
		{
			public static readonly TableReference tabelaNAME = "CTCTipoParte";
			public static readonly FieldReference Id = "CTCTipoParte.Id";
			public static readonly FieldReference Descricao = "CTCTipoParte.Descricao";
			public static readonly FieldReference ISPB = "CTCTipoParte.ISPB";
		}
		#endregion
	}
}
