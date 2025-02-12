
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
	public partial class CTCVigenciaFaixasRCO : EntityBase
	{
		#region Propriedades
		[Key, Identity]
		public int? Id { get; set; }

		public DateTime? VigenciaInicial { get; set; }

		public DateTime? VigenciaFinal { get; set; }

		#endregion

		#region Metadados
		public static class METADADO
		{
			public static readonly TableReference tabelaNAME = "CTCVigenciaFaixasRCO";
			public static readonly FieldReference Id = "CTCVigenciaFaixasRCO.Id";
			public static readonly FieldReference VigenciaInicial = "CTCVigenciaFaixasRCO.VigenciaInicial";
			public static readonly FieldReference VigenciaFinal = "CTCVigenciaFaixasRCO.VigenciaFinal";
		}
		#endregion
	}
}
