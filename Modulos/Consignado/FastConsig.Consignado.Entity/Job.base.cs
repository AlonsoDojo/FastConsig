
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
	public partial class Job : EntityBase
	{
		#region Propriedades
		[Key, Identity]
		public int? Id { get; set; }

		[DataLength(50)]
		public string Name { get; set; }

		[DataLength(50)]
		public string Codigo { get; set; }

		[DataLength(150)]
		public string Descricao { get; set; }

		[ForeignKey, DataLength(1)]
		public string IdJobStatus { get; set; }

		#endregion

		#region Metadados
		public static class METADADO
		{
			public static readonly TableReference tabelaNAME = "Job";
			public static readonly FieldReference Id = "Job.Id";
			public static readonly FieldReference Name = "Job.Name";
			public static readonly FieldReference Codigo = "Job.Codigo";
			public static readonly FieldReference Descricao = "Job.Descricao";
			public static readonly FieldReference IdJobStatus = "Job.IdJobStatus";
		}
		#endregion
	}
}
