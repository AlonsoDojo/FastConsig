
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
	public partial class ViewComunicados : EntityBase
	{
		#region Propriedades
		[Key]
		public int? Comunicado { get; set; }

		[DataLength(50)]
		public string Usuario { get; set; }

		public DateTime? DataLeitura { get; set; }

		public DateTime? DataVigenciaInicial { get; set; }

		public DateTime? DataVigenciaFinal { get; set; }

		[DataLength(200)]
		public string Titulo { get; set; }

		public bool ConfirmacaoLeitura { get; set; }

		#endregion

		#region Metadados
		public static class METADADO
		{
			public static readonly TableReference tabelaNAME = "ViewComunicados";
			public static readonly FieldReference Comunicado = "ViewComunicados.Comunicado";
			public static readonly FieldReference Usuario = "ViewComunicados.Usuario";
			public static readonly FieldReference DataLeitura = "ViewComunicados.DataLeitura";
			public static readonly FieldReference DataVigenciaInicial = "ViewComunicados.DataVigenciaInicial";
			public static readonly FieldReference DataVigenciaFinal = "ViewComunicados.DataVigenciaFinal";
			public static readonly FieldReference Titulo = "ViewComunicados.Titulo";
			public static readonly FieldReference ConfirmacaoLeitura = "ViewComunicados.ConfirmacaoLeitura";
		}
		#endregion
	}
}
