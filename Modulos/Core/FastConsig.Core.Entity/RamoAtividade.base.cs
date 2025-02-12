
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
	public partial class RamoAtividade : EntityBase
	{
		#region Propriedades
		[Key]
		public int? Id { get; set; }

		[DataLength(500)]
		public string Descricao { get; set; }

		[DataLength(1)]
		public string TipoPessoa { get; set; }

		#endregion

		#region Metadados
		public static class METADADO
		{
			public static readonly TableReference tabelaNAME = "RamoAtividade";
			public static readonly FieldReference Id = "RamoAtividade.Id";
			public static readonly FieldReference Descricao = "RamoAtividade.Descricao";
			public static readonly FieldReference TipoPessoa = "RamoAtividade.TipoPessoa";
		}
		#endregion
	}
}
