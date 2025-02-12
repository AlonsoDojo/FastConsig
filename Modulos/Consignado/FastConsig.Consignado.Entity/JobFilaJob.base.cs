
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
	public partial class JobFilaJob : EntityBase
	{
		#region Propriedades
		[Key, Identity]
		public long? Id { get; set; }

		[ForeignKey]
		public long? IdFila { get; set; }

		[ForeignKey]
		public int? IdJob { get; set; }

		public long? IdJobTentativa { get; set; }

		[DataLength(20)]
		public string Status { get; set; }

		[DataLength(2147483647)]
		public string Content { get; set; }

		public int? Predecessor { get; set; }

		#endregion

		#region Metadados
		public static class METADADO
		{
			public static readonly TableReference tabelaNAME = "JobFilaJob";
			public static readonly FieldReference Id = "JobFilaJob.Id";
			public static readonly FieldReference IdFila = "JobFilaJob.IdFila";
			public static readonly FieldReference IdJob = "JobFilaJob.IdJob";
			public static readonly FieldReference IdJobTentativa = "JobFilaJob.IdJobTentativa";
			public static readonly FieldReference Status = "JobFilaJob.Status";
			public static readonly FieldReference Content = "JobFilaJob.Content";
			public static readonly FieldReference Predecessor = "JobFilaJob.Predecessor";
		}
		#endregion
	}
}
