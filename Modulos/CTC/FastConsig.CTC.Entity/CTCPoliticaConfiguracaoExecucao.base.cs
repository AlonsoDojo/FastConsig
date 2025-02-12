
#region Usings
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Framework;
using Framework.Data;
#endregion

namespace FastConsig.CTC.Entity
{
	[Serializable]
	public partial class CTCPoliticaConfiguracaoExecucao : EntityBase
	{
		#region Propriedades
		[Key, Identity]
		public int? Id { get; set; }

		[ForeignKey]
		public int? TipoArquivo { get; set; }

		[ForeignKey]
		public int? TipoPessoa { get; set; }

		[ForeignKey]
		public int? Fase { get; set; }

		[ForeignKey]
		public int? Politica { get; set; }

		public int? Peso { get; set; }

		public bool Entrada { get; set; }

		public bool Saida { get; set; }

		[ForeignKey]
		public int? TipoFluxo { get; set; }

		#endregion

		#region Metadados
		public static class METADADO
		{
			public static readonly TableReference tabelaNAME = "CTCPoliticaConfiguracaoExecucao";
			public static readonly FieldReference Id = "CTCPoliticaConfiguracaoExecucao.Id";
			public static readonly FieldReference TipoArquivo = "CTCPoliticaConfiguracaoExecucao.TipoArquivo";
			public static readonly FieldReference TipoPessoa = "CTCPoliticaConfiguracaoExecucao.TipoPessoa";
			public static readonly FieldReference Fase = "CTCPoliticaConfiguracaoExecucao.Fase";
			public static readonly FieldReference Politica = "CTCPoliticaConfiguracaoExecucao.Politica";
			public static readonly FieldReference Peso = "CTCPoliticaConfiguracaoExecucao.Peso";
			public static readonly FieldReference Entrada = "CTCPoliticaConfiguracaoExecucao.Entrada";
			public static readonly FieldReference Saida = "CTCPoliticaConfiguracaoExecucao.Saida";
			public static readonly FieldReference TipoFluxo = "CTCPoliticaConfiguracaoExecucao.TipoFluxo";
		}
		#endregion
	}
}
