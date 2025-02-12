
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
	public partial class ViewPropostaCheckList : EntityBase
	{
		#region Propriedades
		[Key]
		public int? Id { get; set; }

		public int? Proposta { get; set; }

		public int? IdItem { get; set; }

		[DataLength(200)]
		public string Descricao { get; set; }

		public bool Obrigatorio { get; set; }

		public int? TipoDocumento { get; set; }

		[DataLength(100)]
		public string DocumentoNecessario { get; set; }

		public int? Cumprido { get; set; }

		#endregion

		#region Metadados
		public static class METADADO
		{
			public static readonly TableReference tabelaNAME = "ViewPropostaCheckList";
			public static readonly FieldReference Id = "ViewPropostaCheckList.Id";
			public static readonly FieldReference Proposta = "ViewPropostaCheckList.Proposta";
			public static readonly FieldReference IdItem = "ViewPropostaCheckList.IdItem";
			public static readonly FieldReference Descricao = "ViewPropostaCheckList.Descricao";
			public static readonly FieldReference Obrigatorio = "ViewPropostaCheckList.Obrigatorio";
			public static readonly FieldReference TipoDocumento = "ViewPropostaCheckList.TipoDocumento";
			public static readonly FieldReference DocumentoNecessario = "ViewPropostaCheckList.DocumentoNecessario";
			public static readonly FieldReference Cumprido = "ViewPropostaCheckList.Cumprido";
		}
		#endregion
	}
}
