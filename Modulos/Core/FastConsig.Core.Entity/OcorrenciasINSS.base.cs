
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
	public partial class OcorrenciasINSS : EntityBase
	{
		#region Propriedades
		[Key, Identity]
		public int? Id { get; set; }

		[DataLength(5)]
		public string Codigo { get; set; }

		[DataLength(255)]
		public string Descricao { get; set; }

		[ForeignKey]
		public int? Acao { get; set; }

		[ForeignKey]
		public int? Ocorrencia { get; set; }

		#endregion

		#region Metadados
		public static class METADADO
		{
			public static readonly TableReference tabelaNAME = "OcorrenciasINSS";
			public static readonly FieldReference Id = "OcorrenciasINSS.Id";
			public static readonly FieldReference Codigo = "OcorrenciasINSS.Codigo";
			public static readonly FieldReference Descricao = "OcorrenciasINSS.Descricao";
			public static readonly FieldReference Acao = "OcorrenciasINSS.Acao";
			public static readonly FieldReference Ocorrencia = "OcorrenciasINSS.Ocorrencia";
		}
		#endregion
	}
}
