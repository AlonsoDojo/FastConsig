
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
	public partial class CTCDominioArquivo : EntityBase
	{
		#region Propriedades
		[Key, Identity]
		public int? Id { get; set; }

		[DataLength(50)]
		public string NomeArquivo { get; set; }

		[DataLength(2147483647)]
		public string Classe { get; set; }

		public bool Monitorar { get; set; }

		public bool Entrada { get; set; }

		public bool Saida { get; set; }

		public DateTime? GradeHorariaInicial { get; set; }

		public DateTime? GradeHorariaFinal { get; set; }

		[DataLength(2147483647)]
		public string Parser { get; set; }

		[DataLength(2147483647)]
		public string Builder { get; set; }

		[DataLength(2147483647)]
		public string Process { get; set; }

		public bool Arquivo { get; set; }

		public bool Protocolo { get; set; }

		public bool Retorno { get; set; }

		public bool Erro { get; set; }

		[ForeignKey]
		public int? Emissor { get; set; }

		[ForeignKey]
		public int? Destinatario { get; set; }

		public bool Online { get; set; }

		public int? LimiteRegistros { get; set; }

		[DataLength(500)]
		public string Descricao { get; set; }

		[DataLength(2147483647)]
		public string Validator { get; set; }

		[DataLength(2147483647)]
		public string XSD { get; set; }

		public bool Domingo { get; set; }

		public bool Segunda { get; set; }

		public bool Terca { get; set; }

		public bool Quarta { get; set; }

		public bool Quinta { get; set; }

		public bool Sexta { get; set; }

		public bool Sabado { get; set; }

		public bool ValidaDiaUtil { get; set; }

		#endregion

		#region Metadados
		public static class METADADO
		{
			public static readonly TableReference tabelaNAME = "CTCDominioArquivo";
			public static readonly FieldReference Id = "CTCDominioArquivo.Id";
			public static readonly FieldReference NomeArquivo = "CTCDominioArquivo.NomeArquivo";
			public static readonly FieldReference Classe = "CTCDominioArquivo.Classe";
			public static readonly FieldReference Monitorar = "CTCDominioArquivo.Monitorar";
			public static readonly FieldReference Entrada = "CTCDominioArquivo.Entrada";
			public static readonly FieldReference Saida = "CTCDominioArquivo.Saida";
			public static readonly FieldReference GradeHorariaInicial = "CTCDominioArquivo.GradeHorariaInicial";
			public static readonly FieldReference GradeHorariaFinal = "CTCDominioArquivo.GradeHorariaFinal";
			public static readonly FieldReference Parser = "CTCDominioArquivo.Parser";
			public static readonly FieldReference Builder = "CTCDominioArquivo.Builder";
			public static readonly FieldReference Process = "CTCDominioArquivo.Process";
			public static readonly FieldReference Arquivo = "CTCDominioArquivo.Arquivo";
			public static readonly FieldReference Protocolo = "CTCDominioArquivo.Protocolo";
			public static readonly FieldReference Retorno = "CTCDominioArquivo.Retorno";
			public static readonly FieldReference Erro = "CTCDominioArquivo.Erro";
			public static readonly FieldReference Emissor = "CTCDominioArquivo.Emissor";
			public static readonly FieldReference Destinatario = "CTCDominioArquivo.Destinatario";
			public static readonly FieldReference Online = "CTCDominioArquivo.Online";
			public static readonly FieldReference LimiteRegistros = "CTCDominioArquivo.LimiteRegistros";
			public static readonly FieldReference Descricao = "CTCDominioArquivo.Descricao";
			public static readonly FieldReference Validator = "CTCDominioArquivo.Validator";
			public static readonly FieldReference XSD = "CTCDominioArquivo.XSD";
			public static readonly FieldReference Domingo = "CTCDominioArquivo.Domingo";
			public static readonly FieldReference Segunda = "CTCDominioArquivo.Segunda";
			public static readonly FieldReference Terca = "CTCDominioArquivo.Terca";
			public static readonly FieldReference Quarta = "CTCDominioArquivo.Quarta";
			public static readonly FieldReference Quinta = "CTCDominioArquivo.Quinta";
			public static readonly FieldReference Sexta = "CTCDominioArquivo.Sexta";
			public static readonly FieldReference Sabado = "CTCDominioArquivo.Sabado";
			public static readonly FieldReference ValidaDiaUtil = "CTCDominioArquivo.ValidaDiaUtil";
		}
		#endregion
	}
}
