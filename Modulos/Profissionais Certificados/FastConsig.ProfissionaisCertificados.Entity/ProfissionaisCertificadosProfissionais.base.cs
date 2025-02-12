
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
	public partial class ProfissionaisCertificadosProfissionais : EntityBase
	{
		#region Propriedades
		[Key]
		public long? Id { get; set; }

		[Key, ForeignKey]
		public int? Certificadora { get; set; }

		[Key, ForeignKey]
		public int? TipoCertificado { get; set; }

		public long? Cpf { get; set; }

		[DataLength(100)]
		public string Nome { get; set; }

		[Key]
		public DateTime? DataAprovacao { get; set; }

		public DateTime? DataValidade { get; set; }

		[Key, DataLength(40)]
		public string NumeroCertificado { get; set; }

		#endregion

		#region Metadados
		public static class METADADO
		{
			public static readonly TableReference tabelaNAME = "ProfissionaisCertificadosProfissionais";
			public static readonly FieldReference Id = "ProfissionaisCertificadosProfissionais.Id";
			public static readonly FieldReference Certificadora = "ProfissionaisCertificadosProfissionais.Certificadora";
			public static readonly FieldReference TipoCertificado = "ProfissionaisCertificadosProfissionais.TipoCertificado";
			public static readonly FieldReference Cpf = "ProfissionaisCertificadosProfissionais.Cpf";
			public static readonly FieldReference Nome = "ProfissionaisCertificadosProfissionais.Nome";
			public static readonly FieldReference DataAprovacao = "ProfissionaisCertificadosProfissionais.DataAprovacao";
			public static readonly FieldReference DataValidade = "ProfissionaisCertificadosProfissionais.DataValidade";
			public static readonly FieldReference NumeroCertificado = "ProfissionaisCertificadosProfissionais.NumeroCertificado";
		}
		#endregion
	}
}
