
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
	public partial class CTCTedsRecebidas : EntityBase
	{
		#region Propriedades
		[Key, Identity]
		public int? Id { get; set; }

		public int? Evento { get; set; }

		public DateTime? DataReferencia { get; set; }

		[DataLength(2147483647)]
		public string Mensagem { get; set; }

		public bool Processado { get; set; }

		#endregion

		#region Metadados
		public static class METADADO
		{
			public static readonly TableReference tabelaNAME = "CTCTedsRecebidas";
			public static readonly FieldReference Id = "CTCTedsRecebidas.Id";
			public static readonly FieldReference Evento = "CTCTedsRecebidas.Evento";
			public static readonly FieldReference DataReferencia = "CTCTedsRecebidas.DataReferencia";
			public static readonly FieldReference Mensagem = "CTCTedsRecebidas.Mensagem";
			public static readonly FieldReference Processado = "CTCTedsRecebidas.Processado";
		}
		#endregion
	}
}
