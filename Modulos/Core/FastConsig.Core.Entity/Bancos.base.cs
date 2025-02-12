
#region Usings
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Framework;
using Framework.Data;
using System.Runtime.Serialization;
#endregion

namespace FastConsig.Core.Entity
{
	[Serializable]
	[DataContract]
	public partial class Bancos : EntityBase
	{
		#region Propriedades
		[Identity]
		[DataMember]
		public int? Id { get; set; }

		[Key, DataLength(3)]
      [DataMember]
      public string Banco { get; set; }

		[DataLength(1)]
      [DataMember]
      public string Digito { get; set; }

		[DataLength(150)]
      [DataMember]
      public string Nome { get; set; }

		[DataLength(14)]
      [DataMember]
      public string Cnpj { get; set; }

      [DataMember]
      public bool Ativo { get; set; }

		[DataLength(8)]
      [DataMember]
      public string ISPB { get; set; }

		[DataLength(3)]
      [DataMember]
      public string CBCDataPrev { get; set; }

		#endregion

		#region Metadados
		public static class METADADO
		{
			public static readonly TableReference tabelaNAME = "Bancos";
			public static readonly FieldReference Id = "Bancos.Id";
			public static readonly FieldReference Banco = "Bancos.Banco";
			public static readonly FieldReference Digito = "Bancos.Digito";
			public static readonly FieldReference Nome = "Bancos.Nome";
			public static readonly FieldReference Cnpj = "Bancos.Cnpj";
			public static readonly FieldReference Ativo = "Bancos.Ativo";
			public static readonly FieldReference ISPB = "Bancos.ISPB";
			public static readonly FieldReference CBCDataPrev = "Bancos.CBCDataPrev";
		}
		#endregion
	}
}
