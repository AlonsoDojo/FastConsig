
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
	public partial class Cep : EntityBase
	{
		#region Propriedades
		[DataLength(2)]
		public string UF { get; set; }

		[DataLength(100)]
		public string Localidade { get; set; }

		[DataLength(100)]
		public string Bairro { get; set; }

		[DataLength(200)]
		public string Logradouro { get; set; }

		[DataLength(8)]
		public string CEP { get; set; }

		[DataLength(50)]
		public string Complemento { get; set; }

		[DataLength(100)]
		public string Nome { get; set; }

		[DataLength(150)]
		public string LogradouroAbreviado { get; set; }

		[DataLength(7)]
		public string CodigoIBGE { get; set; }

		#endregion

		#region Metadados
		public static class METADADO
		{
			public static readonly TableReference tabelaNAME = "Cep";
			public static readonly FieldReference UF = "Cep.UF";
			public static readonly FieldReference Localidade = "Cep.Localidade";
			public static readonly FieldReference Bairro = "Cep.Bairro";
			public static readonly FieldReference Logradouro = "Cep.Logradouro";
			public static readonly FieldReference CEP = "Cep.CEP";
			public static readonly FieldReference Complemento = "Cep.Complemento";
			public static readonly FieldReference Nome = "Cep.Nome";
			public static readonly FieldReference LogradouroAbreviado = "Cep.LogradouroAbreviado";
			public static readonly FieldReference CodigoIBGE = "Cep.CodigoIBGE";
		}
		#endregion
	}
}
