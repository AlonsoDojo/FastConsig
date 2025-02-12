
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
	public partial class Validador : EntityBase
	{
		#region Propriedades
		[Key, Identity]
		public int? Id { get; set; }

		[DataLength(100)]
		public string Nome { get; set; }

		[DataLength(2147483647)]
		public string Descricao { get; set; }

		[ForeignKey]
		public int? Modelo { get; set; }

		[DataLength(2147483647)]
		public string Classe { get; set; }

		#endregion

		#region Metadados
		public static class METADADO
		{
			public static readonly TableReference tabelaNAME = "Validador";
			public static readonly FieldReference Id = "Validador.Id";
			public static readonly FieldReference Nome = "Validador.Nome";
			public static readonly FieldReference Descricao = "Validador.Descricao";
			public static readonly FieldReference Modelo = "Validador.Modelo";
			public static readonly FieldReference Classe = "Validador.Classe";
		}
		#endregion
	}
}
