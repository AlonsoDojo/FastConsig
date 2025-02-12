
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
	public partial class CTCPoliticas : EntityBase
	{
		#region Propriedades
		[Key, Identity]
		public int? Id { get; set; }

		[DataLength(255)]
		public string Descricao { get; set; }

		[DataLength(2147483647)]
		public string Metodo { get; set; }

		[ForeignKey]
		public int? TipoPolitica { get; set; }

		public bool Async { get; set; }

		[DataLength(2147483647)]
		public string Parametros { get; set; }

		#endregion

		#region Metadados
		public static class METADADO
		{
			public static readonly TableReference tabelaNAME = "CTCPoliticas";
			public static readonly FieldReference Id = "CTCPoliticas.Id";
			public static readonly FieldReference Descricao = "CTCPoliticas.Descricao";
			public static readonly FieldReference Metodo = "CTCPoliticas.Metodo";
			public static readonly FieldReference TipoPolitica = "CTCPoliticas.TipoPolitica";
			public static readonly FieldReference Async = "CTCPoliticas.Async";
			public static readonly FieldReference Parametros = "CTCPoliticas.Parametros";
		}
		#endregion
	}
}
