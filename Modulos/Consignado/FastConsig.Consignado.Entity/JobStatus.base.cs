
#region Usings
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Framework;
using Framework.Data;
#endregion

namespace FastConsig.Consignado.Entity
{
	[Serializable]
	public partial class JobStatus : EntityBase
	{
		#region Propriedades
		[Key, DataLength(1)]
		public string Id { get; set; }

		[DataLength(50)]
		public string Descricao { get; set; }

		#endregion

		#region Metadados
		public static class METADADO
		{
			public static readonly TableReference tabelaNAME = "JobStatus";
			public static readonly FieldReference Id = "JobStatus.Id";
			public static readonly FieldReference Descricao = "JobStatus.Descricao";
		}
		#endregion
	}
}
