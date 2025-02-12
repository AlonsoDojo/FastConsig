
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
	public partial class CTCMotivoRetencaoContrato : EntityBase
	{
		#region Propriedades
		[Key, Identity]
		public int? Id { get; set; }

		[DataLength(3)]
		public string Codigo { get; set; }

		[DataLength(100)]
		public string Descricao { get; set; }

		public bool Consignado { get; set; }

		public bool CreditoImobiliario { get; set; }

		public bool CreditoPessoal { get; set; }

		public bool FinancimentoVeiculo { get; set; }

		public bool OutrosCreditos { get; set; }

		public bool ChequeEspecial { get; set; }

		public bool AdiantamentoDepositante { get; set; }

		public bool CapitalGiro { get; set; }

		public bool Pronampe { get; set; }

		#endregion

		#region Metadados
		public static class METADADO
		{
			public static readonly TableReference tabelaNAME = "CTCMotivoRetencaoContrato";
			public static readonly FieldReference Id = "CTCMotivoRetencaoContrato.Id";
			public static readonly FieldReference Codigo = "CTCMotivoRetencaoContrato.Codigo";
			public static readonly FieldReference Descricao = "CTCMotivoRetencaoContrato.Descricao";
			public static readonly FieldReference Consignado = "CTCMotivoRetencaoContrato.Consignado";
			public static readonly FieldReference CreditoImobiliario = "CTCMotivoRetencaoContrato.CreditoImobiliario";
			public static readonly FieldReference CreditoPessoal = "CTCMotivoRetencaoContrato.CreditoPessoal";
			public static readonly FieldReference FinancimentoVeiculo = "CTCMotivoRetencaoContrato.FinancimentoVeiculo";
			public static readonly FieldReference OutrosCreditos = "CTCMotivoRetencaoContrato.OutrosCreditos";
			public static readonly FieldReference ChequeEspecial = "CTCMotivoRetencaoContrato.ChequeEspecial";
			public static readonly FieldReference AdiantamentoDepositante = "CTCMotivoRetencaoContrato.AdiantamentoDepositante";
			public static readonly FieldReference CapitalGiro = "CTCMotivoRetencaoContrato.CapitalGiro";
			public static readonly FieldReference Pronampe = "CTCMotivoRetencaoContrato.Pronampe";
		}
		#endregion
	}
}
