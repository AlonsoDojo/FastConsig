
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
	public partial class ValidadorModelosCampos : EntityBase
	{
		#region Propriedades
		[Key, Identity]
		public int? Id { get; set; }

		[ForeignKey]
		public int? Modelo { get; set; }

		[DataLength(500)]
		public string NomePropriedade { get; set; }

		[DataLength(2147483647)]
		public string Descricao { get; set; }

		[ForeignKey]
		public int? TipoDado { get; set; }

		public bool IsList { get; set; }

		#endregion

		#region Metadados
		public static class METADADO
		{
			public static readonly TableReference tabelaNAME = "ValidadorModelosCampos";
			public static readonly FieldReference Id = "ValidadorModelosCampos.Id";
			public static readonly FieldReference Modelo = "ValidadorModelosCampos.Modelo";
			public static readonly FieldReference NomePropriedade = "ValidadorModelosCampos.NomePropriedade";
			public static readonly FieldReference Descricao = "ValidadorModelosCampos.Descricao";
			public static readonly FieldReference TipoDado = "ValidadorModelosCampos.TipoDado";
			public static readonly FieldReference IsList = "ValidadorModelosCampos.IsList";
		}
		#endregion
	}
}
