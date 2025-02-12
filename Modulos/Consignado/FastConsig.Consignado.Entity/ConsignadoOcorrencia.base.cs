
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
	public partial class ConsignadoOcorrencia : EntityBase
	{
		#region Propriedades
		[Key, Identity]
		public int? Id { get; set; }

		[DataLength(5)]
		public string Codigo { get; set; }

		[DataLength(255)]
		public string Descricao { get; set; }

		public int? Acao { get; set; }

		[ForeignKey]
		public int? Ocorrencia { get; set; }

		[DataLength(1)]
		public string TipoConsignado { get; set; }

		#endregion

		#region Metadados
		public static class METADADO
		{
			public static readonly TableReference tabelaNAME = "ConsignadoOcorrencia";
			public static readonly FieldReference Id = "ConsignadoOcorrencia.Id";
			public static readonly FieldReference Codigo = "ConsignadoOcorrencia.Codigo";
			public static readonly FieldReference Descricao = "ConsignadoOcorrencia.Descricao";
			public static readonly FieldReference Acao = "ConsignadoOcorrencia.Acao";
			public static readonly FieldReference Ocorrencia = "ConsignadoOcorrencia.Ocorrencia";
			public static readonly FieldReference TipoConsignado = "ConsignadoOcorrencia.TipoConsignado";
		}
		#endregion
	}
}
