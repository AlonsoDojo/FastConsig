
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
	public partial class TipoDado : EntityBase
	{
		#region Propriedades
		[Key, Identity]
		public int? Id { get; set; }

		[DataLength(50)]
		public string Descricao { get; set; }

		[DataLength(2147483647)]
		public string Mapper { get; set; }

		#endregion

		#region Metadados
		public static class METADADO
		{
			public static readonly TableReference tabelaNAME = "TipoDado";
			public static readonly FieldReference Id = "TipoDado.Id";
			public static readonly FieldReference Descricao = "TipoDado.Descricao";
			public static readonly FieldReference Mapper = "TipoDado.Mapper";
		}
		#endregion
	}
}
