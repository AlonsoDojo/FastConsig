
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
	public partial class CheckListItens : EntityBase
	{
		#region Propriedades
		[Key, Identity]
		public int? Id { get; set; }

		[ForeignKey]
		public int? CheckList { get; set; }

		[DataLength(200)]
		public string Descricao { get; set; }

		public bool Obrigatorio { get; set; }

		[ForeignKey]
		public int? TipoDocumento { get; set; }

		#endregion

		#region Metadados
		public static class METADADO
		{
			public static readonly TableReference tabelaNAME = "CheckListItens";
			public static readonly FieldReference Id = "CheckListItens.Id";
			public static readonly FieldReference CheckList = "CheckListItens.CheckList";
			public static readonly FieldReference Descricao = "CheckListItens.Descricao";
			public static readonly FieldReference Obrigatorio = "CheckListItens.Obrigatorio";
			public static readonly FieldReference TipoDocumento = "CheckListItens.TipoDocumento";
		}
		#endregion
	}
}
