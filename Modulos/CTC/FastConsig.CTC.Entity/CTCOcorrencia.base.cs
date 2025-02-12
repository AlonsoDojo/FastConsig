
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
	public partial class CTCOcorrencia : EntityBase
	{
		#region Propriedades
		[Key, Identity]
		public int? Id { get; set; }

		[DataLength(250)]
		public string Descricao { get; set; }

		public bool Visivel { get; set; }

		public bool Sistema { get; set; }

		#endregion

		#region Metadados
		public static class METADADO
		{
			public static readonly TableReference tabelaNAME = "CTCOcorrencia";
			public static readonly FieldReference Id = "CTCOcorrencia.Id";
			public static readonly FieldReference Descricao = "CTCOcorrencia.Descricao";
			public static readonly FieldReference Visivel = "CTCOcorrencia.Visivel";
			public static readonly FieldReference Sistema = "CTCOcorrencia.Sistema";
		}
		#endregion
	}
}
