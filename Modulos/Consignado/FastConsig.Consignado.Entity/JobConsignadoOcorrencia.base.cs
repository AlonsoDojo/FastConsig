
#region Usings
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Framework;
using Framework.Data;
#endregion

namespace FastConsig.Consignado.Entity
{
	[Serializable]
	public partial class JobConsignadoOcorrencia : EntityBase
	{
		#region Propriedades
		[Key, Identity]
		public int? Id { get; set; }

		[ForeignKey]
		public int? JobId { get; set; }

		public int? ConsignadoOcorrenciaId { get; set; }

		public int? Acao { get; set; }

		public int? Ocorrencia { get; set; }

		#endregion

		#region Metadados
		public static class METADADO
		{
			public static readonly TableReference tabelaNAME = "JobConsignadoOcorrencia";
			public static readonly FieldReference Id = "JobConsignadoOcorrencia.Id";
			public static readonly FieldReference JobId = "JobConsignadoOcorrencia.JobId";
			public static readonly FieldReference ConsignadoOcorrenciaId = "JobConsignadoOcorrencia.ConsignadoOcorrenciaId";
			public static readonly FieldReference Acao = "JobConsignadoOcorrencia.Acao";
			public static readonly FieldReference Ocorrencia = "JobConsignadoOcorrencia.Ocorrencia";
		}
		#endregion
	}
}
