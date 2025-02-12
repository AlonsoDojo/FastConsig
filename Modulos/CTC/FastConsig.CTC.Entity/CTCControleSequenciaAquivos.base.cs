
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
	public partial class CTCControleSequenciaAquivos : EntityBase
	{
		#region Propriedades
		[Key, Identity]
		public int? Id { get; set; }

		public int? Arquivo { get; set; }

		public DateTime? DataReferencia { get; set; }

		public int? Sequencia { get; set; }

		#endregion

		#region Metadados
		public static class METADADO
		{
			public static readonly TableReference tabelaNAME = "CTCControleSequenciaAquivos";
			public static readonly FieldReference Id = "CTCControleSequenciaAquivos.Id";
			public static readonly FieldReference Arquivo = "CTCControleSequenciaAquivos.Arquivo";
			public static readonly FieldReference DataReferencia = "CTCControleSequenciaAquivos.DataReferencia";
			public static readonly FieldReference Sequencia = "CTCControleSequenciaAquivos.Sequencia";
		}
		#endregion
	}
}
