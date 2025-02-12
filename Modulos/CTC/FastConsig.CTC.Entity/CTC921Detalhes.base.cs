
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
	public partial class CTC921Detalhes : EntityBase
	{
		#region Propriedades
		[Key, Identity]
		public int? Id { get; set; }

		public int? CTC921 { get; set; }

		[ForeignKey, DataLength(4)]
		public string TipoContrato { get; set; }

		[ForeignKey, DataLength(4)]
		public string EventoTarifa { get; set; }

		public DateTime? DataTarifa { get; set; }

		[DataLength(21)]
		public string NUPortabilidade { get; set; }

		[DataLength(8)]
		public string ISPBProponente { get; set; }

		[DataLength(40)]
		public string Contrato { get; set; }

		[DataLength(8)]
		public string CNPJIFOriginadoraContrato { get; set; }

		[ForeignKey, DataLength(2)]
		public string EnteConsignante { get; set; }

		[ForeignKey, DataLength(1)]
		public string TipoCliente { get; set; }

		[DataLength(14)]
		public string CpfCnpjCliente { get; set; }

		[DataLength(150)]
		public string NomeCliente { get; set; }

		[DataLength(15)]
		public string TelefoneCliente { get; set; }

		[DataLength(150)]
		public string EmailCliente { get; set; }

		#endregion

		#region Metadados
		public static class METADADO
		{
			public static readonly TableReference tabelaNAME = "CTC921Detalhes";
			public static readonly FieldReference Id = "CTC921Detalhes.Id";
			public static readonly FieldReference CTC921 = "CTC921Detalhes.CTC921";
			public static readonly FieldReference TipoContrato = "CTC921Detalhes.TipoContrato";
			public static readonly FieldReference EventoTarifa = "CTC921Detalhes.EventoTarifa";
			public static readonly FieldReference DataTarifa = "CTC921Detalhes.DataTarifa";
			public static readonly FieldReference NUPortabilidade = "CTC921Detalhes.NUPortabilidade";
			public static readonly FieldReference ISPBProponente = "CTC921Detalhes.ISPBProponente";
			public static readonly FieldReference Contrato = "CTC921Detalhes.Contrato";
			public static readonly FieldReference CNPJIFOriginadoraContrato = "CTC921Detalhes.CNPJIFOriginadoraContrato";
			public static readonly FieldReference EnteConsignante = "CTC921Detalhes.EnteConsignante";
			public static readonly FieldReference TipoCliente = "CTC921Detalhes.TipoCliente";
			public static readonly FieldReference CpfCnpjCliente = "CTC921Detalhes.CpfCnpjCliente";
			public static readonly FieldReference NomeCliente = "CTC921Detalhes.NomeCliente";
			public static readonly FieldReference TelefoneCliente = "CTC921Detalhes.TelefoneCliente";
			public static readonly FieldReference EmailCliente = "CTC921Detalhes.EmailCliente";
		}
		#endregion
	}
}
