
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
	public partial class CTC928ClienteProduto : EntityBase
	{
		#region Propriedades
		[Key, Identity]
		public int? Id { get; set; }

		[ForeignKey]
		public int? Cliente { get; set; }

		[DataLength(250)]
		public string Produto { get; set; }

		#endregion

		#region Metadados
		public static class METADADO
		{
			public static readonly TableReference tabelaNAME = "CTC928ClienteProduto";
			public static readonly FieldReference Id = "CTC928ClienteProduto.Id";
			public static readonly FieldReference Cliente = "CTC928ClienteProduto.Cliente";
			public static readonly FieldReference Produto = "CTC928ClienteProduto.Produto";
		}
		#endregion
	}
}
