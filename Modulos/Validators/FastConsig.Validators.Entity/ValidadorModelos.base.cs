
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
	public partial class ValidadorModelos : EntityBase
	{
		#region Propriedades
		[Key, Identity]
		public int? Id { get; set; }

		[DataLength(250)]
		public string Modelo { get; set; }

		[DataLength(2147483647)]
		public string Descricao { get; set; }

		#endregion

		#region Metadados
		public static class METADADO
		{
			public static readonly TableReference tabelaNAME = "ValidadorModelos";
			public static readonly FieldReference Id = "ValidadorModelos.Id";
			public static readonly FieldReference Modelo = "ValidadorModelos.Modelo";
			public static readonly FieldReference Descricao = "ValidadorModelos.Descricao";
		}
		#endregion
	}
}
