
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
	public partial class JobDetalhe : EntityBase
	{
		#region Propriedades
		[Key, ForeignKey]
		public int? IdJob { get; set; }

		[DataLength(2147483647)]
		public string Type { get; set; }

		[DataLength(255)]
		public string ConnectionString { get; set; }

		public bool Debug { get; set; }

		[DataLength(255)]
		public string LoggingType { get; set; }

		[DataLength(255)]
		public string LoggingLocation { get; set; }

		public long? LoggingMaximumSize { get; set; }

		#endregion

		#region Metadados
		public static class METADADO
		{
			public static readonly TableReference tabelaNAME = "JobDetalhe";
			public static readonly FieldReference IdJob = "JobDetalhe.IdJob";
			public static readonly FieldReference Type = "JobDetalhe.Type";
			public static readonly FieldReference ConnectionString = "JobDetalhe.ConnectionString";
			public static readonly FieldReference Debug = "JobDetalhe.Debug";
			public static readonly FieldReference LoggingType = "JobDetalhe.LoggingType";
			public static readonly FieldReference LoggingLocation = "JobDetalhe.LoggingLocation";
			public static readonly FieldReference LoggingMaximumSize = "JobDetalhe.LoggingMaximumSize";
		}
		#endregion
	}
}
