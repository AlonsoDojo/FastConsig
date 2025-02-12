
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
	public partial class CTCRequisicao : EntityBase
	{
		#region Propriedades
		[Key, Identity]
		public int? Id { get; set; }

		[DataLength(8)]
		public string IdentificacaoParticipanteAdministrado { get; set; }

		[DataLength(21)]
		public string NUPortabilidade { get; set; }

		[DataLength(8)]
		public string IFProponente { get; set; }

		[DataLength(40)]
		public string Contrato { get; set; }

		[DataLength(8)]
		public string CNPJBaseIFOriginadora { get; set; }

		[ForeignKey, DataLength(4)]
		public string TipoContrato { get; set; }

		[ForeignKey, DataLength(2)]
		public string EnteConsignante { get; set; }

		[DataLength(14)]
		public string CNPJCorrespondenteBancario { get; set; }

		[DataLength(1)]
		public string TipoPessoa { get; set; }

		[DataLength(14)]
		public string CpfCnpjCliente { get; set; }

		[DataLength(150)]
		public string NomeCliente { get; set; }

		[DataLength(15)]
		public string Telefone { get; set; }

		[DataLength(150)]
		public string Email { get; set; }

		[DataLength(150)]
		public string Endereco { get; set; }

		[DataLength(15)]
		public string Numero { get; set; }

		[DataLength(50)]
		public string Complemento { get; set; }

		[DataLength(50)]
		public string Cidade { get; set; }

		[DataLength(2)]
		public string UF { get; set; }

		[DataLength(8)]
		public string Cep { get; set; }

		public DateTime? DataReferenciaSaldo { get; set; }

		[DataLength(18,2)]
		public decimal? SaldoDevedor { get; set; }

		[DataLength(12,6)]
		public decimal? JurosNominal { get; set; }

		[DataLength(12,6)]
		public decimal? JurosEfetivo { get; set; }

		[DataLength(12,6)]
		public decimal? Cet { get; set; }

		[ForeignKey, DataLength(2)]
		public string Moeda { get; set; }

		[ForeignKey, DataLength(2)]
		public string IndiceRemuneracao { get; set; }

		[ForeignKey, DataLength(2)]
		public string RegimeAmortizacao { get; set; }

		public DateTime? DataContrato { get; set; }

		public int? QtdParcelasContrato { get; set; }

		[DataLength(18,2)]
		public decimal? ValorFaceParcela { get; set; }

		public DateTime? DataVencimentoPrimeiraParcela { get; set; }

		public DateTime? DataVencimentoUltimaParcela { get; set; }

		[DataLength(150)]
		public string EnderecoCartaPortabilidade { get; set; }

		[DataLength(15)]
		public string NumeroCartaPortabilidade { get; set; }

		[DataLength(50)]
		public string ComplementoCartaPortabilidade { get; set; }

		[DataLength(50)]
		public string CidadeCartaPortabilidade { get; set; }

		[DataLength(2)]
		public string UFCartaPortabilidade { get; set; }

		[DataLength(8)]
		public string CepCartaPortabilidade { get; set; }

		[ForeignKey, DataLength(2)]
		public string SituacaoPortabilidade { get; set; }

		public DateTime? DataReferencia { get; set; }

		public DateTime? DataVencimentoRetencao { get; set; }

		public DateTime? DataVencimentoAceite { get; set; }

		[ForeignKey]
		public int? Arquivo { get; set; }

		[ForeignKey]
		public int? Fase { get; set; }

		[ForeignKey]
		public int? TipoArquivo { get; set; }

		[DataLength(50)]
		public string Status { get; set; }

		[DataLength(2147483647)]
		public string Mensagem { get; set; }

		[ForeignKey]
		public int? TipoFluxo { get; set; }

		[DataLength(50)]
		public string NumeroBeneficio { get; set; }

		public int? EspecieBeneficio { get; set; }

		public DateTime? DataNascimento { get; set; }

		[DataLength(2)]
		public string UFBeneficio { get; set; }

		[DataLength(6)]
		public string ProdutoOrigem { get; set; }

		[ForeignKey, DataLength(3)]
		public string MotivoRetencao { get; set; }

		[ForeignKey, DataLength(3)]
		public string MotivoCancelamento { get; set; }

		[ForeignKey, DataLength(3)]
		public string MotivoDecursoPrazo { get; set; }

		[ForeignKey, DataLength(2)]
		public string MotivoDevolucaoLiquidacao { get; set; }

		public DateTime? DataRespostaSaldo { get; set; }

		public DateTime? DataRetencao { get; set; }

		public DateTime? DataCancelamento { get; set; }

		public DateTime? DataDecursoPrazo { get; set; }

		public DateTime? DataDevolucaoLiquidacao { get; set; }

		[DataLength(2147483647)]
		public string ObservacaoAceite { get; set; }

		[DataLength(2147483647)]
		public string ObservacaoRetencao { get; set; }

		[DataLength(2147483647)]
		public string ObservacaoCancelamento { get; set; }

		[DataLength(2147483647)]
		public string ObservacaoDecursodePrazo { get; set; }

		[DataLength(2147483647)]
		public string ObservacaoDevolucaoLiquidacao { get; set; }

		public DateTime? DataReferenciaSaldoResposta { get; set; }

		[DataLength(50)]
		public string UsuarioAceite { get; set; }

		[DataLength(12,6)]
		public decimal? SaldoAceiteInformado { get; set; }

		public DateTime? DataReferenciaRetencao { get; set; }

		[DataLength(50)]
		public string UsuarioRetencao { get; set; }

		public DateTime? DataPagamento { get; set; }

		[DataLength(50)]
		public string UsuarioPagamento { get; set; }

		[DataLength(12,6)]
		public decimal? ValorPago { get; set; }

		[DataLength(50)]
		public string UsuarioCancelamento { get; set; }

		[DataLength(18,2)]
		public decimal? ValorRCOCalculado { get; set; }

		[DataLength(18,2)]
		public decimal? ValorRCOApurado { get; set; }

		#endregion

		#region Metadados
		public static class METADADO
		{
			public static readonly TableReference tabelaNAME = "CTCRequisicao";
			public static readonly FieldReference Id = "CTCRequisicao.Id";
			public static readonly FieldReference IdentificacaoParticipanteAdministrado = "CTCRequisicao.IdentificacaoParticipanteAdministrado";
			public static readonly FieldReference NUPortabilidade = "CTCRequisicao.NUPortabilidade";
			public static readonly FieldReference IFProponente = "CTCRequisicao.IFProponente";
			public static readonly FieldReference Contrato = "CTCRequisicao.Contrato";
			public static readonly FieldReference CNPJBaseIFOriginadora = "CTCRequisicao.CNPJBaseIFOriginadora";
			public static readonly FieldReference TipoContrato = "CTCRequisicao.TipoContrato";
			public static readonly FieldReference EnteConsignante = "CTCRequisicao.EnteConsignante";
			public static readonly FieldReference CNPJCorrespondenteBancario = "CTCRequisicao.CNPJCorrespondenteBancario";
			public static readonly FieldReference TipoPessoa = "CTCRequisicao.TipoPessoa";
			public static readonly FieldReference CpfCnpjCliente = "CTCRequisicao.CpfCnpjCliente";
			public static readonly FieldReference NomeCliente = "CTCRequisicao.NomeCliente";
			public static readonly FieldReference Telefone = "CTCRequisicao.Telefone";
			public static readonly FieldReference Email = "CTCRequisicao.Email";
			public static readonly FieldReference Endereco = "CTCRequisicao.Endereco";
			public static readonly FieldReference Numero = "CTCRequisicao.Numero";
			public static readonly FieldReference Complemento = "CTCRequisicao.Complemento";
			public static readonly FieldReference Cidade = "CTCRequisicao.Cidade";
			public static readonly FieldReference UF = "CTCRequisicao.UF";
			public static readonly FieldReference Cep = "CTCRequisicao.Cep";
			public static readonly FieldReference DataReferenciaSaldo = "CTCRequisicao.DataReferenciaSaldo";
			public static readonly FieldReference SaldoDevedor = "CTCRequisicao.SaldoDevedor";
			public static readonly FieldReference JurosNominal = "CTCRequisicao.JurosNominal";
			public static readonly FieldReference JurosEfetivo = "CTCRequisicao.JurosEfetivo";
			public static readonly FieldReference Cet = "CTCRequisicao.Cet";
			public static readonly FieldReference Moeda = "CTCRequisicao.Moeda";
			public static readonly FieldReference IndiceRemuneracao = "CTCRequisicao.IndiceRemuneracao";
			public static readonly FieldReference RegimeAmortizacao = "CTCRequisicao.RegimeAmortizacao";
			public static readonly FieldReference DataContrato = "CTCRequisicao.DataContrato";
			public static readonly FieldReference QtdParcelasContrato = "CTCRequisicao.QtdParcelasContrato";
			public static readonly FieldReference ValorFaceParcela = "CTCRequisicao.ValorFaceParcela";
			public static readonly FieldReference DataVencimentoPrimeiraParcela = "CTCRequisicao.DataVencimentoPrimeiraParcela";
			public static readonly FieldReference DataVencimentoUltimaParcela = "CTCRequisicao.DataVencimentoUltimaParcela";
			public static readonly FieldReference EnderecoCartaPortabilidade = "CTCRequisicao.EnderecoCartaPortabilidade";
			public static readonly FieldReference NumeroCartaPortabilidade = "CTCRequisicao.NumeroCartaPortabilidade";
			public static readonly FieldReference ComplementoCartaPortabilidade = "CTCRequisicao.ComplementoCartaPortabilidade";
			public static readonly FieldReference CidadeCartaPortabilidade = "CTCRequisicao.CidadeCartaPortabilidade";
			public static readonly FieldReference UFCartaPortabilidade = "CTCRequisicao.UFCartaPortabilidade";
			public static readonly FieldReference CepCartaPortabilidade = "CTCRequisicao.CepCartaPortabilidade";
			public static readonly FieldReference SituacaoPortabilidade = "CTCRequisicao.SituacaoPortabilidade";
			public static readonly FieldReference DataReferencia = "CTCRequisicao.DataReferencia";
			public static readonly FieldReference DataVencimentoRetencao = "CTCRequisicao.DataVencimentoRetencao";
			public static readonly FieldReference DataVencimentoAceite = "CTCRequisicao.DataVencimentoAceite";
			public static readonly FieldReference Arquivo = "CTCRequisicao.Arquivo";
			public static readonly FieldReference Fase = "CTCRequisicao.Fase";
			public static readonly FieldReference TipoArquivo = "CTCRequisicao.TipoArquivo";
			public static readonly FieldReference Status = "CTCRequisicao.Status";
			public static readonly FieldReference Mensagem = "CTCRequisicao.Mensagem";
			public static readonly FieldReference TipoFluxo = "CTCRequisicao.TipoFluxo";
			public static readonly FieldReference NumeroBeneficio = "CTCRequisicao.NumeroBeneficio";
			public static readonly FieldReference EspecieBeneficio = "CTCRequisicao.EspecieBeneficio";
			public static readonly FieldReference DataNascimento = "CTCRequisicao.DataNascimento";
			public static readonly FieldReference UFBeneficio = "CTCRequisicao.UFBeneficio";
			public static readonly FieldReference ProdutoOrigem = "CTCRequisicao.ProdutoOrigem";
			public static readonly FieldReference MotivoRetencao = "CTCRequisicao.MotivoRetencao";
			public static readonly FieldReference MotivoCancelamento = "CTCRequisicao.MotivoCancelamento";
			public static readonly FieldReference MotivoDecursoPrazo = "CTCRequisicao.MotivoDecursoPrazo";
			public static readonly FieldReference MotivoDevolucaoLiquidacao = "CTCRequisicao.MotivoDevolucaoLiquidacao";
			public static readonly FieldReference DataRespostaSaldo = "CTCRequisicao.DataRespostaSaldo";
			public static readonly FieldReference DataRetencao = "CTCRequisicao.DataRetencao";
			public static readonly FieldReference DataCancelamento = "CTCRequisicao.DataCancelamento";
			public static readonly FieldReference DataDecursoPrazo = "CTCRequisicao.DataDecursoPrazo";
			public static readonly FieldReference DataDevolucaoLiquidacao = "CTCRequisicao.DataDevolucaoLiquidacao";
			public static readonly FieldReference ObservacaoAceite = "CTCRequisicao.ObservacaoAceite";
			public static readonly FieldReference ObservacaoRetencao = "CTCRequisicao.ObservacaoRetencao";
			public static readonly FieldReference ObservacaoCancelamento = "CTCRequisicao.ObservacaoCancelamento";
			public static readonly FieldReference ObservacaoDecursodePrazo = "CTCRequisicao.ObservacaoDecursodePrazo";
			public static readonly FieldReference ObservacaoDevolucaoLiquidacao = "CTCRequisicao.ObservacaoDevolucaoLiquidacao";
			public static readonly FieldReference DataReferenciaSaldoResposta = "CTCRequisicao.DataReferenciaSaldoResposta";
			public static readonly FieldReference UsuarioAceite = "CTCRequisicao.UsuarioAceite";
			public static readonly FieldReference SaldoAceiteInformado = "CTCRequisicao.SaldoAceiteInformado";
			public static readonly FieldReference DataReferenciaRetencao = "CTCRequisicao.DataReferenciaRetencao";
			public static readonly FieldReference UsuarioRetencao = "CTCRequisicao.UsuarioRetencao";
			public static readonly FieldReference DataPagamento = "CTCRequisicao.DataPagamento";
			public static readonly FieldReference UsuarioPagamento = "CTCRequisicao.UsuarioPagamento";
			public static readonly FieldReference ValorPago = "CTCRequisicao.ValorPago";
			public static readonly FieldReference UsuarioCancelamento = "CTCRequisicao.UsuarioCancelamento";
			public static readonly FieldReference ValorRCOCalculado = "CTCRequisicao.ValorRCOCalculado";
			public static readonly FieldReference ValorRCOApurado = "CTCRequisicao.ValorRCOApurado";
		}
		#endregion
	}
}
