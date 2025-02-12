
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
	public partial class CTCRCO : EntityBase
	{
		#region Propriedades
		[Key, Identity]
		public int? Id { get; set; }

		[DataLength(6)]
		public string AnoMes { get; set; }

		[DataLength(1)]
		public string Tipo { get; set; }

		[DataLength(8)]
		public string IdentidadeParticipanteAdministrado { get; set; }

		[DataLength(8)]
		public string ISPBContraParte { get; set; }

		[ForeignKey, DataLength(4)]
		public string TipoContrato { get; set; }

		[ForeignKey, DataLength(2)]
		public string EnteConsignante { get; set; }

		[DataLength(40)]
		public string Contrato { get; set; }

		[DataLength(21)]
		public string NUPortabilidade { get; set; }

		public DateTime? DataContrato { get; set; }

		public DateTime? DataVencimentoUltimaParcela { get; set; }

		public DateTime? DataReferenciaSaldoDevedor { get; set; }

		[DataLength(18,2)]
		public decimal? ValorSaldoDevedor { get; set; }

		[DataLength(18,2)]
		public decimal? ValorSaldoDevedorAD { get; set; }

		[DataLength(18,2)]
		public decimal? BaseCalculoRCO { get; set; }

		public DateTime? DataMovimentoLiquidacaoSTR { get; set; }

		[DataLength(18,2)]
		public decimal? ValorSTRLiquidacaoPortabilidade { get; set; }

		[DataLength(18,2)]
		public decimal? ValorRCO { get; set; }

		[DataLength(8)]
		public string ISPBBancoPagamento { get; set; }

		[DataLength(3)]
		public string CodigoBancoPagamento { get; set; }

		[DataLength(4)]
		public string AgenciaPagamento { get; set; }

		[DataLength(13)]
		public string ContaPagamento { get; set; }

		[ForeignKey]
		public int? Arquivo { get; set; }

		#endregion

		#region Metadados
		public static class METADADO
		{
			public static readonly TableReference tabelaNAME = "CTCRCO";
			public static readonly FieldReference Id = "CTCRCO.Id";
			public static readonly FieldReference AnoMes = "CTCRCO.AnoMes";
			public static readonly FieldReference Tipo = "CTCRCO.Tipo";
			public static readonly FieldReference IdentidadeParticipanteAdministrado = "CTCRCO.IdentidadeParticipanteAdministrado";
			public static readonly FieldReference ISPBContraParte = "CTCRCO.ISPBContraParte";
			public static readonly FieldReference TipoContrato = "CTCRCO.TipoContrato";
			public static readonly FieldReference EnteConsignante = "CTCRCO.EnteConsignante";
			public static readonly FieldReference Contrato = "CTCRCO.Contrato";
			public static readonly FieldReference NUPortabilidade = "CTCRCO.NUPortabilidade";
			public static readonly FieldReference DataContrato = "CTCRCO.DataContrato";
			public static readonly FieldReference DataVencimentoUltimaParcela = "CTCRCO.DataVencimentoUltimaParcela";
			public static readonly FieldReference DataReferenciaSaldoDevedor = "CTCRCO.DataReferenciaSaldoDevedor";
			public static readonly FieldReference ValorSaldoDevedor = "CTCRCO.ValorSaldoDevedor";
			public static readonly FieldReference ValorSaldoDevedorAD = "CTCRCO.ValorSaldoDevedorAD";
			public static readonly FieldReference BaseCalculoRCO = "CTCRCO.BaseCalculoRCO";
			public static readonly FieldReference DataMovimentoLiquidacaoSTR = "CTCRCO.DataMovimentoLiquidacaoSTR";
			public static readonly FieldReference ValorSTRLiquidacaoPortabilidade = "CTCRCO.ValorSTRLiquidacaoPortabilidade";
			public static readonly FieldReference ValorRCO = "CTCRCO.ValorRCO";
			public static readonly FieldReference ISPBBancoPagamento = "CTCRCO.ISPBBancoPagamento";
			public static readonly FieldReference CodigoBancoPagamento = "CTCRCO.CodigoBancoPagamento";
			public static readonly FieldReference AgenciaPagamento = "CTCRCO.AgenciaPagamento";
			public static readonly FieldReference ContaPagamento = "CTCRCO.ContaPagamento";
			public static readonly FieldReference Arquivo = "CTCRCO.Arquivo";
		}
		#endregion
	}
}
