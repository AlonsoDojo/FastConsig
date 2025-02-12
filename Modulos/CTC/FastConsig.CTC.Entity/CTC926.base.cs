
#region Usings
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Framework;
using Framework.Data;
#endregion

namespace FastConsig.CTC.Entity
{
	[Serializable]
	public partial class CTC926 : EntityBase
	{
		#region Propriedades
		[Key, Identity]
		public int? Id { get; set; }

		[ForeignKey]
		public int? Arquivo { get; set; }

		public DateTime? DataReferencia { get; set; }

		public DateTime? DataInicio { get; set; }

		public DateTime? DataFim { get; set; }

		#endregion

		#region Metadados
		public static class METADADO
		{
			public static readonly TableReference tabelaNAME = "CTC926";
			public static readonly FieldReference Id = "CTC926.Id";
			public static readonly FieldReference Arquivo = "CTC926.Arquivo";
			public static readonly FieldReference DataReferencia = "CTC926.DataReferencia";
			public static readonly FieldReference DataInicio = "CTC926.DataInicio";
			public static readonly FieldReference DataFim = "CTC926.DataFim";
		}
		#endregion
	}
}
