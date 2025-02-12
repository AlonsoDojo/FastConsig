
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
	public partial class JobTentativa : EntityBase
	{
		#region Propriedades
		[Key, Identity]
		public long? Id { get; set; }

		public int? IdJob { get; set; }

		[DataLength(1)]
		public string IdJobStatus { get; set; }

		public DateTime? DtProcessamento { get; set; }

		[DataLength(2147483647)]
		public string Retorno { get; set; }

		#endregion

		#region Metadados
		public static class METADADO
		{
			public static readonly TableReference tabelaNAME = "JobTentativa";
			public static readonly FieldReference Id = "JobTentativa.Id";
			public static readonly FieldReference IdJob = "JobTentativa.IdJob";
			public static readonly FieldReference IdJobStatus = "JobTentativa.IdJobStatus";
			public static readonly FieldReference DtProcessamento = "JobTentativa.DtProcessamento";
			public static readonly FieldReference Retorno = "JobTentativa.Retorno";
		}
		#endregion
	}
}
