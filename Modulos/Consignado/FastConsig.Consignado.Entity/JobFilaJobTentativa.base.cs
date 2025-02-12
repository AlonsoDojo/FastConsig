
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
	public partial class JobFilaJobTentativa : EntityBase
	{
		#region Propriedades
		[Key, Identity]
		public long? Id { get; set; }

		[ForeignKey]
		public long? IdFilaJob { get; set; }

		[ForeignKey]
		public long? IdJobTentativa { get; set; }

		#endregion

		#region Metadados
		public static class METADADO
		{
			public static readonly TableReference tabelaNAME = "JobFilaJobTentativa";
			public static readonly FieldReference Id = "JobFilaJobTentativa.Id";
			public static readonly FieldReference IdFilaJob = "JobFilaJobTentativa.IdFilaJob";
			public static readonly FieldReference IdJobTentativa = "JobFilaJobTentativa.IdJobTentativa";
		}
		#endregion
	}
}
