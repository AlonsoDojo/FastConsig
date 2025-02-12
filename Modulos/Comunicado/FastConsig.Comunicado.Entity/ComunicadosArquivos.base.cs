
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
	public partial class ComunicadosArquivos : EntityBase
	{
		#region Propriedades
		[Key, Identity]
		public int? Id { get; set; }

		[ForeignKey]
		public int? Comunicado { get; set; }

		[DataLength(255)]
		public string NomeArquivo { get; set; }

		public byte[] Conteudo { get; set; }

		#endregion

		#region Metadados
		public static class METADADO
		{
			public static readonly TableReference tabelaNAME = "ComunicadosArquivos";
			public static readonly FieldReference Id = "ComunicadosArquivos.Id";
			public static readonly FieldReference Comunicado = "ComunicadosArquivos.Comunicado";
			public static readonly FieldReference NomeArquivo = "ComunicadosArquivos.NomeArquivo";
			public static readonly FieldReference Conteudo = "ComunicadosArquivos.Conteudo";
		}
		#endregion
	}
}
