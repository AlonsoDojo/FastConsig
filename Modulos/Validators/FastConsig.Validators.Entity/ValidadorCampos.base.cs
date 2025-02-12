
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
	public partial class ValidadorCampos : EntityBase
	{
		#region Propriedades
		[Key, Identity]
		public int? Id { get; set; }

		[ForeignKey]
		public int? Validador { get; set; }

		[ForeignKey]
		public int? Modelo { get; set; }

		[ForeignKey]
		public int? CampoModelo { get; set; }

		[ForeignKey]
		public int? Rule { get; set; }

		[DataLength(2147483647)]
		public string Parametro1 { get; set; }

		[DataLength(2147483647)]
		public string Parametro2 { get; set; }

		[DataLength(2147483647)]
		public string Parametro3 { get; set; }

		#endregion

		#region Metadados
		public static class METADADO
		{
			public static readonly TableReference tabelaNAME = "ValidadorCampos";
			public static readonly FieldReference Id = "ValidadorCampos.Id";
			public static readonly FieldReference Validador = "ValidadorCampos.Validador";
			public static readonly FieldReference Modelo = "ValidadorCampos.Modelo";
			public static readonly FieldReference CampoModelo = "ValidadorCampos.CampoModelo";
			public static readonly FieldReference Rule = "ValidadorCampos.Rule";
			public static readonly FieldReference Parametro1 = "ValidadorCampos.Parametro1";
			public static readonly FieldReference Parametro2 = "ValidadorCampos.Parametro2";
			public static readonly FieldReference Parametro3 = "ValidadorCampos.Parametro3";
		}
		#endregion
	}
}
