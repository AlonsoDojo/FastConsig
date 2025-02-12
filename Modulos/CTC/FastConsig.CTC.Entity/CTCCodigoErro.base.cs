
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
	public partial class CTCCodigoErro : EntityBase
	{
		#region Propriedades
		[Key, Identity]
		public int? Id { get; set; }

		[DataLength(8)]
		public string Codigo { get; set; }

		[DataLength(2147483647)]
		public string Descricao { get; set; }

		#endregion

		#region Metadados
		public static class METADADO
		{
			public static readonly TableReference tabelaNAME = "CTCCodigoErro";
			public static readonly FieldReference Id = "CTCCodigoErro.Id";
			public static readonly FieldReference Codigo = "CTCCodigoErro.Codigo";
			public static readonly FieldReference Descricao = "CTCCodigoErro.Descricao";
		}
		#endregion
	}
}
