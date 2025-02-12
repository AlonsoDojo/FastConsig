
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
	public partial class CTCMotivoCancelamentoPortabilidade : EntityBase
	{
		#region Propriedades
		[Key, Identity]
		public int? Id { get; set; }

		[DataLength(3)]
		public string Codigo { get; set; }

		[DataLength(150)]
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
			public static readonly TableReference tabelaNAME = "CTCMotivoCancelamentoPortabilidade";
			public static readonly FieldReference Id = "CTCMotivoCancelamentoPortabilidade.Id";
			public static readonly FieldReference Codigo = "CTCMotivoCancelamentoPortabilidade.Codigo";
			public static readonly FieldReference Descricao = "CTCMotivoCancelamentoPortabilidade.Descricao";
			public static readonly FieldReference Consignado = "CTCMotivoCancelamentoPortabilidade.Consignado";
			public static readonly FieldReference CreditoImobiliario = "CTCMotivoCancelamentoPortabilidade.CreditoImobiliario";
			public static readonly FieldReference CreditoPessoal = "CTCMotivoCancelamentoPortabilidade.CreditoPessoal";
			public static readonly FieldReference FinancimentoVeiculo = "CTCMotivoCancelamentoPortabilidade.FinancimentoVeiculo";
			public static readonly FieldReference OutrosCreditos = "CTCMotivoCancelamentoPortabilidade.OutrosCreditos";
			public static readonly FieldReference ChequeEspecial = "CTCMotivoCancelamentoPortabilidade.ChequeEspecial";
			public static readonly FieldReference AdiantamentoDepositante = "CTCMotivoCancelamentoPortabilidade.AdiantamentoDepositante";
			public static readonly FieldReference CapitalGiro = "CTCMotivoCancelamentoPortabilidade.CapitalGiro";
			public static readonly FieldReference Pronampe = "CTCMotivoCancelamentoPortabilidade.Pronampe";
		}
		#endregion
	}
}
