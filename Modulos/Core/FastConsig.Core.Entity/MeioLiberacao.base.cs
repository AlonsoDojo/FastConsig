
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
	public partial class MeioLiberacao : EntityBase
	{
		#region Propriedades
		[Key, Identity]
		public int? Id { get; set; }

		[DataLength(50)]
		public string Descricao { get; set; }

		public bool Banco { get; set; }

		public bool Agencia { get; set; }

		public bool Conta { get; set; }

		public bool Chave { get; set; }

		public bool Ativo { get; set; }

		#endregion

		#region Metadados
		public static class METADADO
		{
			public static readonly TableReference tabelaNAME = "MeioLiberacao";
			public static readonly FieldReference Id = "MeioLiberacao.Id";
			public static readonly FieldReference Descricao = "MeioLiberacao.Descricao";
			public static readonly FieldReference Banco = "MeioLiberacao.Banco";
			public static readonly FieldReference Agencia = "MeioLiberacao.Agencia";
			public static readonly FieldReference Conta = "MeioLiberacao.Conta";
			public static readonly FieldReference Chave = "MeioLiberacao.Chave";
			public static readonly FieldReference Ativo = "MeioLiberacao.Ativo";
		}
		#endregion
	}
}
