
#region Usings
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Framework;
using Framework.Data;
#endregion

namespace FastConsig.Comunicado.Entity
{
	[Serializable]
	public partial class ComunicadosConfirmacaoLeitura : EntityBase
	{
		#region Propriedades
		[Key, Identity]
		public int? Id { get; set; }

		[ForeignKey]
		public int? Comunicado { get; set; }

		[ForeignKey, DataLength(50)]
		public string Usuario { get; set; }

		public DateTime? DataLeitura { get; set; }

		#endregion

		#region Metadados
		public static class METADADO
		{
			public static readonly TableReference tabelaNAME = "ComunicadosConfirmacaoLeitura";
			public static readonly FieldReference Id = "ComunicadosConfirmacaoLeitura.Id";
			public static readonly FieldReference Comunicado = "ComunicadosConfirmacaoLeitura.Comunicado";
			public static readonly FieldReference Usuario = "ComunicadosConfirmacaoLeitura.Usuario";
			public static readonly FieldReference DataLeitura = "ComunicadosConfirmacaoLeitura.DataLeitura";
		}
		#endregion
	}
}
