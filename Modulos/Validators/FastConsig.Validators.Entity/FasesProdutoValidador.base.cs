
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
	public partial class FasesProdutoValidador : EntityBase
	{
		#region Propriedades
		[Key, Identity]
		public int? Id { get; set; }

		[ForeignKey]
		public int? FaseProduto { get; set; }

		[ForeignKey]
		public int? Validador { get; set; }

		public bool Ativo { get; set; }

		#endregion

		#region Metadados
		public static class METADADO
		{
			public static readonly TableReference tabelaNAME = "FasesProdutoValidador";
			public static readonly FieldReference Id = "FasesProdutoValidador.Id";
			public static readonly FieldReference FaseProduto = "FasesProdutoValidador.FaseProduto";
			public static readonly FieldReference Validador = "FasesProdutoValidador.Validador";
			public static readonly FieldReference Ativo = "FasesProdutoValidador.Ativo";
		}
		#endregion
	}
}
