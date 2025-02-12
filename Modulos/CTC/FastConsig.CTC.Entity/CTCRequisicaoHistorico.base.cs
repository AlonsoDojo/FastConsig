
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
	public partial class CTCRequisicaoHistorico : EntityBase
	{
		#region Propriedades
		[Key, Identity]
		public int? Id { get; set; }

		[ForeignKey]
		public int? Requisicao { get; set; }

		[ForeignKey]
		public int? Ocorrencia { get; set; }

		public DateTime? DataOcorrencia { get; set; }

		[DataLength(50)]
		public string Usuario { get; set; }

		[DataLength(2147483647)]
		public string Complemento { get; set; }

		#endregion

		#region Metadados
		public static class METADADO
		{
			public static readonly TableReference tabelaNAME = "CTCRequisicaoHistorico";
			public static readonly FieldReference Id = "CTCRequisicaoHistorico.Id";
			public static readonly FieldReference Requisicao = "CTCRequisicaoHistorico.Requisicao";
			public static readonly FieldReference Ocorrencia = "CTCRequisicaoHistorico.Ocorrencia";
			public static readonly FieldReference DataOcorrencia = "CTCRequisicaoHistorico.DataOcorrencia";
			public static readonly FieldReference Usuario = "CTCRequisicaoHistorico.Usuario";
			public static readonly FieldReference Complemento = "CTCRequisicaoHistorico.Complemento";
		}
		#endregion
	}
}
