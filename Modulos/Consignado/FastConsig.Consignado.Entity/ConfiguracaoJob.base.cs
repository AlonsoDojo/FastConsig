
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
	public partial class ConfiguracaoJob : EntityBase
	{
		#region Propriedades
		[Key, Identity]
		public int? Id { get; set; }

		[ForeignKey]
		public int? IdJob { get; set; }

		[DataLength(100)]
		public string HorarioExecucao { get; set; }

		[DataLength(2147483647)]
		public string ParametrosExtras { get; set; }

		public bool Dom { get; set; }

		public bool Seg { get; set; }

		public bool Ter { get; set; }

		public bool Qua { get; set; }

		public bool Qui { get; set; }

		public bool Sex { get; set; }

		public bool Sab { get; set; }

		public bool Habilitado { get; set; }

		[DataLength(2147483647)]
		public string EmailAvisoConclusao { get; set; }

		[DataLength(2147483647)]
		public string EmailAvisoErro { get; set; }

		public int? TentativasExecucao { get; set; }

		public int? DelayExecucao { get; set; }

		#endregion

		#region Metadados
		public static class METADADO
		{
			public static readonly TableReference tabelaNAME = "ConfiguracaoJob";
			public static readonly FieldReference Id = "ConfiguracaoJob.Id";
			public static readonly FieldReference IdJob = "ConfiguracaoJob.IdJob";
			public static readonly FieldReference HorarioExecucao = "ConfiguracaoJob.HorarioExecucao";
			public static readonly FieldReference ParametrosExtras = "ConfiguracaoJob.ParametrosExtras";
			public static readonly FieldReference Dom = "ConfiguracaoJob.Dom";
			public static readonly FieldReference Seg = "ConfiguracaoJob.Seg";
			public static readonly FieldReference Ter = "ConfiguracaoJob.Ter";
			public static readonly FieldReference Qua = "ConfiguracaoJob.Qua";
			public static readonly FieldReference Qui = "ConfiguracaoJob.Qui";
			public static readonly FieldReference Sex = "ConfiguracaoJob.Sex";
			public static readonly FieldReference Sab = "ConfiguracaoJob.Sab";
			public static readonly FieldReference Habilitado = "ConfiguracaoJob.Habilitado";
			public static readonly FieldReference EmailAvisoConclusao = "ConfiguracaoJob.EmailAvisoConclusao";
			public static readonly FieldReference EmailAvisoErro = "ConfiguracaoJob.EmailAvisoErro";
			public static readonly FieldReference TentativasExecucao = "ConfiguracaoJob.TentativasExecucao";
			public static readonly FieldReference DelayExecucao = "ConfiguracaoJob.DelayExecucao";
		}
		#endregion
	}
}
