
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
	public partial class CTCMotivoRecusaPreReservaGarantiaFGO : EntityBase
	{
		#region Propriedades
		[Key, Identity]
		public int? Id { get; set; }

		[DataLength(3)]
		public string Codigo { get; set; }

		[DataLength(100)]
		public string Descricao { get; set; }

		#endregion

		#region Metadados
		public static class METADADO
		{
			public static readonly TableReference tabelaNAME = "CTCMotivoRecusaPreReservaGarantiaFGO";
			public static readonly FieldReference Id = "CTCMotivoRecusaPreReservaGarantiaFGO.Id";
			public static readonly FieldReference Codigo = "CTCMotivoRecusaPreReservaGarantiaFGO.Codigo";
			public static readonly FieldReference Descricao = "CTCMotivoRecusaPreReservaGarantiaFGO.Descricao";
		}
		#endregion
	}
}
