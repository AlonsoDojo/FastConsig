
#region Usings
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Framework;
using Framework.Data;
#endregion

namespace FastConsig.Comunicado.Entity
{
	[Serializable]
	public partial class ComunicadosStatus : EntityBase
	{
		#region Propriedades
		[Key, Identity]
		public int? Id { get; set; }

		[DataLength(50)]
		public string Descricao { get; set; }

		#endregion

		#region Metadados
		public static class METADADO
		{
			public static readonly TableReference tabelaNAME = "ComunicadosStatus";
			public static readonly FieldReference Id = "ComunicadosStatus.Id";
			public static readonly FieldReference Descricao = "ComunicadosStatus.Descricao";
		}
		#endregion
	}
}
