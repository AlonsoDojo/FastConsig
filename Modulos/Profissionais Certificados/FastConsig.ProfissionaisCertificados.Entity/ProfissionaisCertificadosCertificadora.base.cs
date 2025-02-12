
#region Usings
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Framework;
using Framework.Data;
#endregion

namespace FastConsig.ProfissionaisCertificados.Entity
{
	[Serializable]
	public partial class ProfissionaisCertificadosCertificadora : EntityBase
	{
		#region Propriedades
		[Key]
		public int? Id { get; set; }

		[DataLength(100)]
		public string Descricao { get; set; }

		#endregion

		#region Metadados
		public static class METADADO
		{
			public static readonly TableReference tabelaNAME = "ProfissionaisCertificadosCertificadora";
			public static readonly FieldReference Id = "ProfissionaisCertificadosCertificadora.Id";
			public static readonly FieldReference Descricao = "ProfissionaisCertificadosCertificadora.Descricao";
		}
		#endregion
	}
}
