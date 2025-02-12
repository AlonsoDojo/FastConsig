
#region Usings
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Framework;
using Framework.Data;
using System.Runtime.Serialization;
using Newtonsoft.Json;
#endregion

namespace FastConsig.Core.Entity
{
	[Serializable]
	[DataContract]
	public partial class PropostaArquivos : EntityBase
	{
		#region Propriedades
		[Key, Identity, DataMember, JsonProperty("Id")]
		public int? Id { get; set; }

		[DataMember, JsonProperty("Proposta")]
		public int? Proposta { get; set; }

		[DataLength(2147483647), MaxLength(2147483647), StringLength(2147483647), DataMember, JsonProperty("NomeArquivo")]
		public string NomeArquivo { get; set; }

		[DataLength(2147483647), MaxLength(2147483647), StringLength(2147483647), DataMember, JsonProperty("ChaveArquivo")]
		public string ChaveArquivo { get; set; }

		[DataMember, JsonProperty("TipoDocumento")]
		public int? TipoDocumento { get; set; }

		[DataMember, JsonProperty("Pessoa")]
		public int? Pessoa { get; set; }

		[DataLength(1), MaxLength(1), StringLength(1), DataMember, JsonProperty("Conteudo")]
		public byte[] Conteudo { get; set; }

		#endregion

		#region Metadados
		public static class METADADO
		{
			public static readonly TableReference tabelaNAME = "PropostaArquivos";
			public static readonly FieldReference Id = "PropostaArquivos.Id";
			public static readonly FieldReference Proposta = "PropostaArquivos.Proposta";
			public static readonly FieldReference NomeArquivo = "PropostaArquivos.NomeArquivo";
			public static readonly FieldReference ChaveArquivo = "PropostaArquivos.ChaveArquivo";
			public static readonly FieldReference TipoDocumento = "PropostaArquivos.TipoDocumento";
			public static readonly FieldReference Pessoa = "PropostaArquivos.Pessoa";
			public static readonly FieldReference Conteudo = "PropostaArquivos.Conteudo";
		}
		#endregion
	}
}
