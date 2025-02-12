
#region Usings
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Framework;
using Framework.Data;
#endregion

namespace FastConsig.Validators.Entity
{
	[Serializable]
	public partial class ValidadorRules : EntityBase
	{
		#region Propriedades
		[Key, Identity]
		public int? Id { get; set; }

		[DataLength(100)]
		public string RuleName { get; set; }

		public bool IsList { get; set; }

		public bool IsCustom { get; set; }

		[DataLength(2147483647)]
		public string Descricao { get; set; }

		#endregion

		#region Metadados
		public static class METADADO
		{
			public static readonly TableReference tabelaNAME = "ValidadorRules";
			public static readonly FieldReference Id = "ValidadorRules.Id";
			public static readonly FieldReference RuleName = "ValidadorRules.RuleName";
			public static readonly FieldReference IsList = "ValidadorRules.IsList";
			public static readonly FieldReference IsCustom = "ValidadorRules.IsCustom";
			public static readonly FieldReference Descricao = "ValidadorRules.Descricao";
		}
		#endregion
	}
}
