
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
	public partial class ProfissionaisCertificadosTipoCertificado : EntityBase
	{
		#region Propriedades
		[Key]
		public int? Id { get; set; }

		[DataLength(100)]
		public string Descricao { get; set; }

		[DataLength(6)]
		public string Codigo { get; set; }

		#endregion

		#region Metadados
		public static class METADADO
		{
			public static readonly TableReference tabelaNAME = "ProfissionaisCertificadosTipoCertificado";
			public static readonly FieldReference Id = "ProfissionaisCertificadosTipoCertificado.Id";
			public static readonly FieldReference Descricao = "ProfissionaisCertificadosTipoCertificado.Descricao";
			public static readonly FieldReference Codigo = "ProfissionaisCertificadosTipoCertificado.Codigo";
		}
		#endregion
	}
}
