
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
	public partial class CTC924Detalhes : EntityBase
	{
		#region Propriedades
		[Key, Identity]
		public int? Id { get; set; }

		[ForeignKey]
		public int? CTC924 { get; set; }

		public DateTime? DataSolicitacao { get; set; }

		[DataLength(21)]
		public string NUPortabilidade { get; set; }

		[ForeignKey, DataLength(2)]
		public string SituacaoPortabilidadeCTC { get; set; }

		[DataLength(8)]
		public string ISPBProponente { get; set; }

		public DateTime? DataReferenciaSaldoDevedorProponente { get; set; }

		[DataLength(18,2)]
		public decimal? ValorSaldoDevedorProponente { get; set; }

		public DateTime? DataReferenciaSaldoDevedorOriginal { get; set; }

		[DataLength(18,2)]
		public decimal? ValorSaldoDevedorOriginal { get; set; }

		[DataLength(40)]
		public string Contrato { get; set; }

		[DataLength(8)]
		public string CNPJBaseIFOriginal { get; set; }

		[ForeignKey, DataLength(4)]
		public string TipoContrato { get; set; }

		[ForeignKey, DataLength(2)]
		public string EnteConsignante { get; set; }

		[DataLength(14)]
		public string CNPJCorrespondenteBancario { get; set; }

		[DataLength(1)]
		public string TipoCliente { get; set; }

		[DataLength(14)]
		public string CpfCnpjCliente { get; set; }

		[DataLength(150)]
		public string NomeCliente { get; set; }

		[DataLength(20)]
		public string TelefoneCliente { get; set; }

		[DataLength(150)]
		public string EmailCliente { get; set; }

		[DataLength(150)]
		public string LogradouroEnderecoCliente { get; set; }

		[DataLength(20)]
		public string NumeroEnderecoCliente { get; set; }

		[DataLength(50)]
		public string CidadeEnderecoCliente { get; set; }

		[DataLength(2)]
		public string UFEnderecoCliente { get; set; }

		[DataLength(8)]
		public string CEPEnderecoCliente { get; set; }

		public DateTime? DataDecursoPrazo { get; set; }

		[ForeignKey, DataLength(3)]
		public string MotivoDecursoPrazo { get; set; }

		public DateTime? DataCancelamento { get; set; }

		[ForeignKey, DataLength(3)]
		public string MotivoCancelamento { get; set; }

		[DataLength(8)]
		public string ISPBSolicitanteCancelamento { get; set; }

		public DateTime? DataRetencao { get; set; }

		[ForeignKey, DataLength(3)]
		public string MotivoRetencaoContrato { get; set; }

		public DateTime? DataLiquidacao { get; set; }

		[ForeignKey, DataLength(3)]
		public string SituacaoLiquidacao { get; set; }

		[DataLength(18,2)]
		public decimal? ValorLiquidacaoPortabilidade { get; set; }

		public DateTime? DataDevolucaoLiquidacao { get; set; }

		[ForeignKey, DataLength(3)]
		public string SituacaoDevolucaoLiquidacao { get; set; }

		[ForeignKey, DataLength(2)]
		public string MotivoDevolucaoLiquidacao { get; set; }

		[DataLength(18,2)]
		public decimal? ValorDevolucaoLiquidacao { get; set; }

		public DateTime? DataEfetivacaoPortabilidade { get; set; }

		[ForeignKey, DataLength(3)]
		public string SituacaoEfetivacaoPortabilidade { get; set; }

		[DataLength(18,2)]
		public decimal? ValorRCO { get; set; }

		#endregion

		#region Metadados
		public static class METADADO
		{
			public static readonly TableReference tabelaNAME = "CTC924Detalhes";
			public static readonly FieldReference Id = "CTC924Detalhes.Id";
			public static readonly FieldReference CTC924 = "CTC924Detalhes.CTC924";
			public static readonly FieldReference DataSolicitacao = "CTC924Detalhes.DataSolicitacao";
			public static readonly FieldReference NUPortabilidade = "CTC924Detalhes.NUPortabilidade";
			public static readonly FieldReference SituacaoPortabilidadeCTC = "CTC924Detalhes.SituacaoPortabilidadeCTC";
			public static readonly FieldReference ISPBProponente = "CTC924Detalhes.ISPBProponente";
			public static readonly FieldReference DataReferenciaSaldoDevedorProponente = "CTC924Detalhes.DataReferenciaSaldoDevedorProponente";
			public static readonly FieldReference ValorSaldoDevedorProponente = "CTC924Detalhes.ValorSaldoDevedorProponente";
			public static readonly FieldReference DataReferenciaSaldoDevedorOriginal = "CTC924Detalhes.DataReferenciaSaldoDevedorOriginal";
			public static readonly FieldReference ValorSaldoDevedorOriginal = "CTC924Detalhes.ValorSaldoDevedorOriginal";
			public static readonly FieldReference Contrato = "CTC924Detalhes.Contrato";
			public static readonly FieldReference CNPJBaseIFOriginal = "CTC924Detalhes.CNPJBaseIFOriginal";
			public static readonly FieldReference TipoContrato = "CTC924Detalhes.TipoContrato";
			public static readonly FieldReference EnteConsignante = "CTC924Detalhes.EnteConsignante";
			public static readonly FieldReference CNPJCorrespondenteBancario = "CTC924Detalhes.CNPJCorrespondenteBancario";
			public static readonly FieldReference TipoCliente = "CTC924Detalhes.TipoCliente";
			public static readonly FieldReference CpfCnpjCliente = "CTC924Detalhes.CpfCnpjCliente";
			public static readonly FieldReference NomeCliente = "CTC924Detalhes.NomeCliente";
			public static readonly FieldReference TelefoneCliente = "CTC924Detalhes.TelefoneCliente";
			public static readonly FieldReference EmailCliente = "CTC924Detalhes.EmailCliente";
			public static readonly FieldReference LogradouroEnderecoCliente = "CTC924Detalhes.LogradouroEnderecoCliente";
			public static readonly FieldReference NumeroEnderecoCliente = "CTC924Detalhes.NumeroEnderecoCliente";
			public static readonly FieldReference CidadeEnderecoCliente = "CTC924Detalhes.CidadeEnderecoCliente";
			public static readonly FieldReference UFEnderecoCliente = "CTC924Detalhes.UFEnderecoCliente";
			public static readonly FieldReference CEPEnderecoCliente = "CTC924Detalhes.CEPEnderecoCliente";
			public static readonly FieldReference DataDecursoPrazo = "CTC924Detalhes.DataDecursoPrazo";
			public static readonly FieldReference MotivoDecursoPrazo = "CTC924Detalhes.MotivoDecursoPrazo";
			public static readonly FieldReference DataCancelamento = "CTC924Detalhes.DataCancelamento";
			public static readonly FieldReference MotivoCancelamento = "CTC924Detalhes.MotivoCancelamento";
			public static readonly FieldReference ISPBSolicitanteCancelamento = "CTC924Detalhes.ISPBSolicitanteCancelamento";
			public static readonly FieldReference DataRetencao = "CTC924Detalhes.DataRetencao";
			public static readonly FieldReference MotivoRetencaoContrato = "CTC924Detalhes.MotivoRetencaoContrato";
			public static readonly FieldReference DataLiquidacao = "CTC924Detalhes.DataLiquidacao";
			public static readonly FieldReference SituacaoLiquidacao = "CTC924Detalhes.SituacaoLiquidacao";
			public static readonly FieldReference ValorLiquidacaoPortabilidade = "CTC924Detalhes.ValorLiquidacaoPortabilidade";
			public static readonly FieldReference DataDevolucaoLiquidacao = "CTC924Detalhes.DataDevolucaoLiquidacao";
			public static readonly FieldReference SituacaoDevolucaoLiquidacao = "CTC924Detalhes.SituacaoDevolucaoLiquidacao";
			public static readonly FieldReference MotivoDevolucaoLiquidacao = "CTC924Detalhes.MotivoDevolucaoLiquidacao";
			public static readonly FieldReference ValorDevolucaoLiquidacao = "CTC924Detalhes.ValorDevolucaoLiquidacao";
			public static readonly FieldReference DataEfetivacaoPortabilidade = "CTC924Detalhes.DataEfetivacaoPortabilidade";
			public static readonly FieldReference SituacaoEfetivacaoPortabilidade = "CTC924Detalhes.SituacaoEfetivacaoPortabilidade";
			public static readonly FieldReference ValorRCO = "CTC924Detalhes.ValorRCO";
		}
		#endregion
	}
}
