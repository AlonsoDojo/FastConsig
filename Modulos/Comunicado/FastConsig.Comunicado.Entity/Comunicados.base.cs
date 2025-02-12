
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
	public partial class Comunicados : EntityBase
	{
		#region Propriedades
		[Key, Identity]
		public int? Id { get; set; }

		[ForeignKey, DataLength(50)]
		public string Usuario { get; set; }

		public DateTime? DataCriacao { get; set; }

		public DateTime? DataVigenciaInicial { get; set; }

		public DateTime? DataVigenciaFinal { get; set; }

		[ForeignKey]
		public int? Status { get; set; }

		[DataLength(200)]
		public string Titulo { get; set; }

		public bool ConfirmacaoLeitura { get; set; }

		[DataLength(1)]
		public string PaginaPrincipal { get; set; }

		[DataLength(2147483647)]
		public string Conteudo { get; set; }

		public bool Publicado { get; set; }

		[ForeignKey, DataLength(50)]
		public string UsuarioAlteracao { get; set; }

		public DateTime? DataAlteracao { get; set; }

		public DateTime? DataPublicacao { get; set; }

		[ForeignKey, DataLength(50)]
		public string UsuarioPublicador { get; set; }

		public DateTime? DataDesativacao { get; set; }

		[ForeignKey, DataLength(50)]
		public string UsuarioDesativacao { get; set; }

		#endregion

		#region Metadados
		public static class METADADO
		{
			public static readonly TableReference tabelaNAME = "Comunicados";
			public static readonly FieldReference Id = "Comunicados.Id";
			public static readonly FieldReference Usuario = "Comunicados.Usuario";
			public static readonly FieldReference DataCriacao = "Comunicados.DataCriacao";
			public static readonly FieldReference DataVigenciaInicial = "Comunicados.DataVigenciaInicial";
			public static readonly FieldReference DataVigenciaFinal = "Comunicados.DataVigenciaFinal";
			public static readonly FieldReference Status = "Comunicados.Status";
			public static readonly FieldReference Titulo = "Comunicados.Titulo";
			public static readonly FieldReference ConfirmacaoLeitura = "Comunicados.ConfirmacaoLeitura";
			public static readonly FieldReference PaginaPrincipal = "Comunicados.PaginaPrincipal";
			public static readonly FieldReference Conteudo = "Comunicados.Conteudo";
			public static readonly FieldReference Publicado = "Comunicados.Publicado";
			public static readonly FieldReference UsuarioAlteracao = "Comunicados.UsuarioAlteracao";
			public static readonly FieldReference DataAlteracao = "Comunicados.DataAlteracao";
			public static readonly FieldReference DataPublicacao = "Comunicados.DataPublicacao";
			public static readonly FieldReference UsuarioPublicador = "Comunicados.UsuarioPublicador";
			public static readonly FieldReference DataDesativacao = "Comunicados.DataDesativacao";
			public static readonly FieldReference UsuarioDesativacao = "Comunicados.UsuarioDesativacao";
		}
		#endregion
	}
}
