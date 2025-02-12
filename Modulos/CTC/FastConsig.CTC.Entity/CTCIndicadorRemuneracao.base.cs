
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
	public partial class CTCIndicadorRemuneracao : EntityBase
	{
		#region Propriedades
		[Key, Identity]
		public int? Id { get; set; }

		[DataLength(2)]
		public string Codigo { get; set; }

		[DataLength(50)]
		public string Descricao { get; set; }

		#endregion

		#region Metadados
		public static class METADADO
		{
			public static readonly TableReference tabelaNAME = "CTCIndicadorRemuneracao";
			public static readonly FieldReference Id = "CTCIndicadorRemuneracao.Id";
			public static readonly FieldReference Codigo = "CTCIndicadorRemuneracao.Codigo";
			public static readonly FieldReference Descricao = "CTCIndicadorRemuneracao.Descricao";
		}
		#endregion
	}
}
