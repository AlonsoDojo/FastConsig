
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
	public partial class CTCArquivos : EntityBase
	{
		#region Propriedades
		[Key, Identity]
		public int? Id { get; set; }

		[DataLength(150)]
		public string NomeArquivo { get; set; }

		[DataLength(8)]
		public string ISPBEmissor { get; set; }

		[DataLength(8)]
		public string ISPBDestinatario { get; set; }

		public DateTime? DataReferencia { get; set; }

		[ForeignKey]
		public int? SituacaoArquivo { get; set; }

		[DataLength(2147483647)]
		public string Conteudo { get; set; }

		[ForeignKey]
		public int? DominioArquivo { get; set; }

		[DataLength(50)]
		public string Status { get; set; }

		public DateTime? DataHoraArquivo { get; set; }

		[DataLength(1)]
		public string FluxoArquivo { get; set; }

		[DataLength(2147483647)]
		public string Mensagem { get; set; }

		public DateTime? DataEntrada { get; set; }

		[DataLength(20)]
		public string NumeroControleEmissor { get; set; }

		[DataLength(20)]
		public string NumeroControleDestinatario { get; set; }

		public int? Identificador { get; set; }

		[DataLength(8)]
		public string CodigoErro { get; set; }

		#endregion

		#region Metadados
		public static class METADADO
		{
			public static readonly TableReference tabelaNAME = "CTCArquivos";
			public static readonly FieldReference Id = "CTCArquivos.Id";
			public static readonly FieldReference NomeArquivo = "CTCArquivos.NomeArquivo";
			public static readonly FieldReference ISPBEmissor = "CTCArquivos.ISPBEmissor";
			public static readonly FieldReference ISPBDestinatario = "CTCArquivos.ISPBDestinatario";
			public static readonly FieldReference DataReferencia = "CTCArquivos.DataReferencia";
			public static readonly FieldReference SituacaoArquivo = "CTCArquivos.SituacaoArquivo";
			public static readonly FieldReference Conteudo = "CTCArquivos.Conteudo";
			public static readonly FieldReference DominioArquivo = "CTCArquivos.DominioArquivo";
			public static readonly FieldReference Status = "CTCArquivos.Status";
			public static readonly FieldReference DataHoraArquivo = "CTCArquivos.DataHoraArquivo";
			public static readonly FieldReference FluxoArquivo = "CTCArquivos.FluxoArquivo";
			public static readonly FieldReference Mensagem = "CTCArquivos.Mensagem";
			public static readonly FieldReference DataEntrada = "CTCArquivos.DataEntrada";
			public static readonly FieldReference NumeroControleEmissor = "CTCArquivos.NumeroControleEmissor";
			public static readonly FieldReference NumeroControleDestinatario = "CTCArquivos.NumeroControleDestinatario";
			public static readonly FieldReference Identificador = "CTCArquivos.Identificador";
			public static readonly FieldReference CodigoErro = "CTCArquivos.CodigoErro";
		}
		#endregion
	}
}
