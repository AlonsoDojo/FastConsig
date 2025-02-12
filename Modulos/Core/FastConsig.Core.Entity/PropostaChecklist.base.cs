
#region Usings
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Framework;
using Framework.Data;
#endregion

namespace FastConsig.Core.Entity
{
	[Serializable]
	public partial class PropostaChecklist : EntityBase
	{
		#region Propriedades
		[Key, Identity]
		public int? Id { get; set; }

		public int? Proposta { get; set; }

		public int? Checklist { get; set; }

		public int? Item { get; set; }

		public bool Obrigatorio { get; set; }

		public int? TipoDocumento { get; set; }

		public int? Pessoa { get; set; }

		#endregion

		#region Metadados
		public static class METADADO
		{
			public static readonly TableReference tabelaNAME = "PropostaChecklist";
			public static readonly FieldReference Id = "PropostaChecklist.Id";
			public static readonly FieldReference Proposta = "PropostaChecklist.Proposta";
			public static readonly FieldReference Checklist = "PropostaChecklist.Checklist";
			public static readonly FieldReference Item = "PropostaChecklist.Item";
			public static readonly FieldReference Obrigatorio = "PropostaChecklist.Obrigatorio";
			public static readonly FieldReference TipoDocumento = "PropostaChecklist.TipoDocumento";
			public static readonly FieldReference Pessoa = "PropostaChecklist.Pessoa";
		}
		#endregion
	}
}
