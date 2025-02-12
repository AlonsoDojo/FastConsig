
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
	public partial class CTC928Clientes : EntityBase
	{
		#region Propriedades
		[Key, Identity]
		public int? Id { get; set; }

		[ForeignKey]
		public int? Arquivo { get; set; }

		[DataLength(150)]
		public string NomeCliente { get; set; }

		[DataLength(14)]
		public string Cnpj { get; set; }

		[DataLength(8)]
		public string ISPB { get; set; }

		#endregion

		#region Metadados
		public static class METADADO
		{
			public static readonly TableReference tabelaNAME = "CTC928Clientes";
			public static readonly FieldReference Id = "CTC928Clientes.Id";
			public static readonly FieldReference Arquivo = "CTC928Clientes.Arquivo";
			public static readonly FieldReference NomeCliente = "CTC928Clientes.NomeCliente";
			public static readonly FieldReference Cnpj = "CTC928Clientes.Cnpj";
			public static readonly FieldReference ISPB = "CTC928Clientes.ISPB";
		}
		#endregion
	}
}
