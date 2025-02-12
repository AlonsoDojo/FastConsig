
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
	public partial class CTCContas : EntityBase
	{
		#region Propriedades
		[Key, Identity]
		public int? Id { get; set; }

		[DataLength(8)]
		public string ISPB { get; set; }

		[DataLength(250)]
		public string Descricao { get; set; }

		[DataLength(14)]
		public string CNPJ { get; set; }

		[ForeignKey, DataLength(3)]
		public string Banco { get; set; }

		[DataLength(4)]
		public string Agencia { get; set; }

		[DataLength(13)]
		public string Conta { get; set; }

		public bool Ativo { get; set; }

		#endregion

		#region Metadados
		public static class METADADO
		{
			public static readonly TableReference tabelaNAME = "CTCContas";
			public static readonly FieldReference Id = "CTCContas.Id";
			public static readonly FieldReference ISPB = "CTCContas.ISPB";
			public static readonly FieldReference Descricao = "CTCContas.Descricao";
			public static readonly FieldReference CNPJ = "CTCContas.CNPJ";
			public static readonly FieldReference Banco = "CTCContas.Banco";
			public static readonly FieldReference Agencia = "CTCContas.Agencia";
			public static readonly FieldReference Conta = "CTCContas.Conta";
			public static readonly FieldReference Ativo = "CTCContas.Ativo";
		}
		#endregion
	}
}
