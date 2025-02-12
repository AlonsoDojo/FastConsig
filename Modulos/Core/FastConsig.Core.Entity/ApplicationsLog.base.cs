
#region Usings
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Framework;
using Framework.Data;
#endregion

namespace FastConsig.Core.Entity
{
	[Serializable]
	public partial class ApplicationsLog : EntityBase
	{
		#region Propriedades
		[Identity]
		public int? Id { get; set; }

		[DataLength(255)]
		public string Application { get; set; }

		[DataLength(50)]
		public string ApplicationGuid { get; set; }

		[DataLength(3)]
		public string Environment { get; set; }

		[DataLength(50)]
		public string User { get; set; }

		[DataLength(200)]
		public string HostName { get; set; }

		[DataLength(200)]
		public string MethodName { get; set; }

		[DataLength(2147483647)]
		public string FilePath { get; set; }

		[DataLength(10)]
		public string LineNumber { get; set; }

		[DataLength(2147483647)]
		public string Parameters { get; set; }

		[DataLength(255)]
		public string Thread { get; set; }

		[DataLength(50)]
		public string Level { get; set; }

		[DataLength(255)]
		public string Logger { get; set; }

		[DataLength(10)]
		public string Context { get; set; }

		public DateTime? Date { get; set; }

		[DataLength(2147483647)]
		public string Message { get; set; }

		[DataLength(2147483647)]
		public string Exception { get; set; }

		[DataLength(2147483647)]
		public string InnerException { get; set; }

		#endregion

		#region Metadados
		public static class METADADO
		{
			public static readonly TableReference tabelaNAME = "ApplicationsLog";
			public static readonly FieldReference Id = "ApplicationsLog.Id";
			public static readonly FieldReference Application = "ApplicationsLog.Application";
			public static readonly FieldReference ApplicationGuid = "ApplicationsLog.ApplicationGuid";
			public static readonly FieldReference Environment = "ApplicationsLog.Environment";
			public static readonly FieldReference User = "ApplicationsLog.User";
			public static readonly FieldReference HostName = "ApplicationsLog.HostName";
			public static readonly FieldReference MethodName = "ApplicationsLog.MethodName";
			public static readonly FieldReference FilePath = "ApplicationsLog.FilePath";
			public static readonly FieldReference LineNumber = "ApplicationsLog.LineNumber";
			public static readonly FieldReference Parameters = "ApplicationsLog.Parameters";
			public static readonly FieldReference Thread = "ApplicationsLog.Thread";
			public static readonly FieldReference Level = "ApplicationsLog.Level";
			public static readonly FieldReference Logger = "ApplicationsLog.Logger";
			public static readonly FieldReference Context = "ApplicationsLog.Context";
			public static readonly FieldReference Date = "ApplicationsLog.Date";
			public static readonly FieldReference Message = "ApplicationsLog.Message";
			public static readonly FieldReference Exception = "ApplicationsLog.Exception";
			public static readonly FieldReference InnerException = "ApplicationsLog.InnerException";
		}
		#endregion
	}
}
