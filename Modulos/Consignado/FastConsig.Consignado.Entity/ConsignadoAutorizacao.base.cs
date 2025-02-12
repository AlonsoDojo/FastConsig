
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
	public partial class ConsignadoAutorizacao : EntityBase
	{
		#region Propriedades
		[Key, Identity]
		public int? Id { get; set; }

		public long? Cpf { get; set; }

		public long? CpfRepresentante { get; set; }

		public long? NsuAutorizacaoDigital { get; set; }

		public DateTime? DataHoraAutorizacaoDigital { get; set; }

		public int? CanalAutorizacaoDigital { get; set; }

		public int? TipoDocumentoIdentificacao { get; set; }

		public byte[] DocumentoIdentificacao { get; set; }

		public long? ChaveIdentificadora { get; set; }

		public byte[] TermoAutorizacaoBeneficiario { get; set; }

		public bool PossuiAssinaturaRogo { get; set; }

		[DataLength(255)]
		public string TituloTermo { get; set; }

		[DataLength(255)]
		public string AutorTermo { get; set; }

		[DataLength(255)]
		public string CidadeAssinaturaTermo { get; set; }

		public DateTime? DataHoraCriacaoTermo { get; set; }

		[DataLength(255)]
		public string TokenAutorizacao { get; set; }

		public DateTime? DataValidadeAutorizacao { get; set; }

		[DataLength(2147483647)]
		public string ConsignadoDetalhe { get; set; }

		public int? TipoConsignado { get; set; }

		public int? CodigoOrgao { get; set; }

		public int? CodigoMatricula { get; set; }

		#endregion

		#region Metadados
		public static class METADADO
		{
			public static readonly TableReference tabelaNAME = "ConsignadoAutorizacao";
			public static readonly FieldReference Id = "ConsignadoAutorizacao.Id";
			public static readonly FieldReference Cpf = "ConsignadoAutorizacao.Cpf";
			public static readonly FieldReference CpfRepresentante = "ConsignadoAutorizacao.CpfRepresentante";
			public static readonly FieldReference NsuAutorizacaoDigital = "ConsignadoAutorizacao.NsuAutorizacaoDigital";
			public static readonly FieldReference DataHoraAutorizacaoDigital = "ConsignadoAutorizacao.DataHoraAutorizacaoDigital";
			public static readonly FieldReference CanalAutorizacaoDigital = "ConsignadoAutorizacao.CanalAutorizacaoDigital";
			public static readonly FieldReference TipoDocumentoIdentificacao = "ConsignadoAutorizacao.TipoDocumentoIdentificacao";
			public static readonly FieldReference DocumentoIdentificacao = "ConsignadoAutorizacao.DocumentoIdentificacao";
			public static readonly FieldReference ChaveIdentificadora = "ConsignadoAutorizacao.ChaveIdentificadora";
			public static readonly FieldReference TermoAutorizacaoBeneficiario = "ConsignadoAutorizacao.TermoAutorizacaoBeneficiario";
			public static readonly FieldReference PossuiAssinaturaRogo = "ConsignadoAutorizacao.PossuiAssinaturaRogo";
			public static readonly FieldReference TituloTermo = "ConsignadoAutorizacao.TituloTermo";
			public static readonly FieldReference AutorTermo = "ConsignadoAutorizacao.AutorTermo";
			public static readonly FieldReference CidadeAssinaturaTermo = "ConsignadoAutorizacao.CidadeAssinaturaTermo";
			public static readonly FieldReference DataHoraCriacaoTermo = "ConsignadoAutorizacao.DataHoraCriacaoTermo";
			public static readonly FieldReference TokenAutorizacao = "ConsignadoAutorizacao.TokenAutorizacao";
			public static readonly FieldReference DataValidadeAutorizacao = "ConsignadoAutorizacao.DataValidadeAutorizacao";
			public static readonly FieldReference ConsignadoDetalhe = "ConsignadoAutorizacao.ConsignadoDetalhe";
			public static readonly FieldReference TipoConsignado = "ConsignadoAutorizacao.TipoConsignado";
			public static readonly FieldReference CodigoOrgao = "ConsignadoAutorizacao.CodigoOrgao";
			public static readonly FieldReference CodigoMatricula = "ConsignadoAutorizacao.CodigoMatricula";
		}
		#endregion
	}
}
