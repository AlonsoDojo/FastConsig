
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
	public partial class JobFila : EntityBase
	{
		#region Propriedades
		[Key, Identity]
		public long? Id { get; set; }

		[DataLength(2147483647)]
		public string Mensagem { get; set; }

		[ForeignKey]
		public int? IdStatus { get; set; }

		#endregion

		#region Metadados
		public static class METADADO
		{
			public static readonly TableReference tabelaNAME = "JobFila";
			public static readonly FieldReference Id = "JobFila.Id";
			public static readonly FieldReference Mensagem = "JobFila.Mensagem";
			public static readonly FieldReference IdStatus = "JobFila.IdStatus";
		}
		#endregion
	}
}
