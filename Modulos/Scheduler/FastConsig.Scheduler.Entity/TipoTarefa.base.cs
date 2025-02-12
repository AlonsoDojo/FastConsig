
#region Usings
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Framework;
using Framework.Data;
#endregion

namespace FastConsig.Scheduler.Entity
{
	[Serializable]
	public partial class TipoTarefa : EntityBase
	{
		#region Propriedades
		[Key, Identity]
		public int? Id { get; set; }

		[DataLength(100)]
		public string Descricao { get; set; }

		#endregion

		#region Metadados
		public static class METADADO
		{
			public static readonly TableReference tabelaNAME = "TipoTarefa";
			public static readonly FieldReference Id = "TipoTarefa.Id";
			public static readonly FieldReference Descricao = "TipoTarefa.Descricao";
		}
		#endregion
	}
}
