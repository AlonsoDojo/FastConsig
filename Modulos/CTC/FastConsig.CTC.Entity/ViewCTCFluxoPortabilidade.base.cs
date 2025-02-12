
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
	public partial class ViewCTCFluxoPortabilidade : EntityBase
	{
		#region Propriedades
		[Key]
		public int? Id { get; set; }

		public int? TipoArquivo { get; set; }

		[DataLength(500)]
		public string DescricaoArquivo { get; set; }

		public int? Fase { get; set; }

		[DataLength(50)]
		public string DescricaoFase { get; set; }

		public int? Peso { get; set; }

		[DataLength(255)]
		public string DescricaoPolitica { get; set; }

		[DataLength(2147483647)]
		public string Metodo { get; set; }

		public bool Entrada { get; set; }

		public bool Saida { get; set; }

		public int? TipoFluxo { get; set; }

		[DataLength(50)]
		public string DescricaoFluxo { get; set; }

		#endregion

		#region Metadados
		public static class METADADO
		{
			public static readonly TableReference tabelaNAME = "ViewCTCFluxoPortabilidade";
			public static readonly FieldReference Id = "ViewCTCFluxoPortabilidade.Id";
			public static readonly FieldReference TipoArquivo = "ViewCTCFluxoPortabilidade.TipoArquivo";
			public static readonly FieldReference DescricaoArquivo = "ViewCTCFluxoPortabilidade.DescricaoArquivo";
			public static readonly FieldReference Fase = "ViewCTCFluxoPortabilidade.Fase";
			public static readonly FieldReference DescricaoFase = "ViewCTCFluxoPortabilidade.DescricaoFase";
			public static readonly FieldReference Peso = "ViewCTCFluxoPortabilidade.Peso";
			public static readonly FieldReference DescricaoPolitica = "ViewCTCFluxoPortabilidade.DescricaoPolitica";
			public static readonly FieldReference Metodo = "ViewCTCFluxoPortabilidade.Metodo";
			public static readonly FieldReference Entrada = "ViewCTCFluxoPortabilidade.Entrada";
			public static readonly FieldReference Saida = "ViewCTCFluxoPortabilidade.Saida";
			public static readonly FieldReference TipoFluxo = "ViewCTCFluxoPortabilidade.TipoFluxo";
			public static readonly FieldReference DescricaoFluxo = "ViewCTCFluxoPortabilidade.DescricaoFluxo";
		}
		#endregion
	}
}
