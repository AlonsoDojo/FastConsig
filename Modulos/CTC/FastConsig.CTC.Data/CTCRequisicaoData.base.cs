
#region Usings
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Framework;
using Framework.Data;
using FastConsig.CTC.Entity;
#endregion

namespace FastConsig.CTC.Data
{
	public partial class CTCRequisicaoData : DataBase
	{
		
		#region Listar
		public List<CTCRequisicao> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CTCRequisicao.METADADO.Id)
				.Field(CTCRequisicao.METADADO.IdentificacaoParticipanteAdministrado)
				.Field(CTCRequisicao.METADADO.NUPortabilidade)
				.Field(CTCRequisicao.METADADO.IFProponente)
				.Field(CTCRequisicao.METADADO.Contrato)
				.Field(CTCRequisicao.METADADO.CNPJBaseIFOriginadora)
				.Field(CTCRequisicao.METADADO.TipoContrato)
				.Field(CTCRequisicao.METADADO.EnteConsignante)
				.Field(CTCRequisicao.METADADO.CNPJCorrespondenteBancario)
				.Field(CTCRequisicao.METADADO.TipoPessoa)
				.Field(CTCRequisicao.METADADO.CpfCnpjCliente)
				.Field(CTCRequisicao.METADADO.NomeCliente)
				.Field(CTCRequisicao.METADADO.Telefone)
				.Field(CTCRequisicao.METADADO.Email)
				.Field(CTCRequisicao.METADADO.Endereco)
				.Field(CTCRequisicao.METADADO.Numero)
				.Field(CTCRequisicao.METADADO.Complemento)
				.Field(CTCRequisicao.METADADO.Cidade)
				.Field(CTCRequisicao.METADADO.UF)
				.Field(CTCRequisicao.METADADO.Cep)
				.Field(CTCRequisicao.METADADO.DataReferenciaSaldo)
				.Field(CTCRequisicao.METADADO.SaldoDevedor)
				.Field(CTCRequisicao.METADADO.JurosNominal)
				.Field(CTCRequisicao.METADADO.JurosEfetivo)
				.Field(CTCRequisicao.METADADO.Cet)
				.Field(CTCRequisicao.METADADO.Moeda)
				.Field(CTCRequisicao.METADADO.IndiceRemuneracao)
				.Field(CTCRequisicao.METADADO.RegimeAmortizacao)
				.Field(CTCRequisicao.METADADO.DataContrato)
				.Field(CTCRequisicao.METADADO.QtdParcelasContrato)
				.Field(CTCRequisicao.METADADO.ValorFaceParcela)
				.Field(CTCRequisicao.METADADO.DataVencimentoPrimeiraParcela)
				.Field(CTCRequisicao.METADADO.DataVencimentoUltimaParcela)
				.Field(CTCRequisicao.METADADO.EnderecoCartaPortabilidade)
				.Field(CTCRequisicao.METADADO.NumeroCartaPortabilidade)
				.Field(CTCRequisicao.METADADO.ComplementoCartaPortabilidade)
				.Field(CTCRequisicao.METADADO.CidadeCartaPortabilidade)
				.Field(CTCRequisicao.METADADO.UFCartaPortabilidade)
				.Field(CTCRequisicao.METADADO.CepCartaPortabilidade)
				.Field(CTCRequisicao.METADADO.SituacaoPortabilidade)
				.Field(CTCRequisicao.METADADO.DataReferencia)
				.Field(CTCRequisicao.METADADO.DataVencimentoRetencao)
				.Field(CTCRequisicao.METADADO.DataVencimentoAceite)
				.Field(CTCRequisicao.METADADO.Arquivo)
				.Field(CTCRequisicao.METADADO.Fase)
				.Field(CTCRequisicao.METADADO.TipoArquivo)
				.Field(CTCRequisicao.METADADO.Status)
				.Field(CTCRequisicao.METADADO.Mensagem)
				.Field(CTCRequisicao.METADADO.TipoFluxo)
				.Field(CTCRequisicao.METADADO.NumeroBeneficio)
				.Field(CTCRequisicao.METADADO.EspecieBeneficio)
				.Field(CTCRequisicao.METADADO.DataNascimento)
				.Field(CTCRequisicao.METADADO.UFBeneficio)
				.Field(CTCRequisicao.METADADO.ProdutoOrigem)
				.Field(CTCRequisicao.METADADO.MotivoRetencao)
				.Field(CTCRequisicao.METADADO.MotivoCancelamento)
				.Field(CTCRequisicao.METADADO.MotivoDecursoPrazo)
				.Field(CTCRequisicao.METADADO.MotivoDevolucaoLiquidacao)
				.Field(CTCRequisicao.METADADO.DataRespostaSaldo)
				.Field(CTCRequisicao.METADADO.DataRetencao)
				.Field(CTCRequisicao.METADADO.DataCancelamento)
				.Field(CTCRequisicao.METADADO.DataDecursoPrazo)
				.Field(CTCRequisicao.METADADO.DataDevolucaoLiquidacao)
				.Field(CTCRequisicao.METADADO.ObservacaoAceite)
				.Field(CTCRequisicao.METADADO.ObservacaoRetencao)
				.Field(CTCRequisicao.METADADO.ObservacaoCancelamento)
				.Field(CTCRequisicao.METADADO.ObservacaoDecursodePrazo)
				.Field(CTCRequisicao.METADADO.ObservacaoDevolucaoLiquidacao)
				.Field(CTCRequisicao.METADADO.DataReferenciaSaldoResposta)
				.Field(CTCRequisicao.METADADO.UsuarioAceite)
				.Field(CTCRequisicao.METADADO.SaldoAceiteInformado)
				.Field(CTCRequisicao.METADADO.DataReferenciaRetencao)
				.Field(CTCRequisicao.METADADO.UsuarioRetencao)
				.Field(CTCRequisicao.METADADO.DataPagamento)
				.Field(CTCRequisicao.METADADO.UsuarioPagamento)
				.Field(CTCRequisicao.METADADO.ValorPago)
				.Field(CTCRequisicao.METADADO.UsuarioCancelamento)
				.Field(CTCRequisicao.METADADO.ValorRCOCalculado)
				.Field(CTCRequisicao.METADADO.ValorRCOApurado)
				.Table(CTCRequisicao.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				List<CTCRequisicao> result = base.MapReaderToEntitySet<CTCRequisicao>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(CTCRequisicao obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(CTCRequisicao.METADADO.IdentificacaoParticipanteAdministrado, obj.IdentificacaoParticipanteAdministrado)
				.FieldValue(CTCRequisicao.METADADO.NUPortabilidade, obj.NUPortabilidade)
				.FieldValue(CTCRequisicao.METADADO.IFProponente, obj.IFProponente)
				.FieldValue(CTCRequisicao.METADADO.Contrato, obj.Contrato)
				.FieldValue(CTCRequisicao.METADADO.CNPJBaseIFOriginadora, obj.CNPJBaseIFOriginadora)
				.FieldValue(CTCRequisicao.METADADO.TipoContrato, obj.TipoContrato)
				.FieldValue(CTCRequisicao.METADADO.EnteConsignante, obj.EnteConsignante)
				.FieldValue(CTCRequisicao.METADADO.CNPJCorrespondenteBancario, obj.CNPJCorrespondenteBancario)
				.FieldValue(CTCRequisicao.METADADO.TipoPessoa, obj.TipoPessoa)
				.FieldValue(CTCRequisicao.METADADO.CpfCnpjCliente, obj.CpfCnpjCliente)
				.FieldValue(CTCRequisicao.METADADO.NomeCliente, obj.NomeCliente)
				.FieldValue(CTCRequisicao.METADADO.Telefone, obj.Telefone)
				.FieldValue(CTCRequisicao.METADADO.Email, obj.Email)
				.FieldValue(CTCRequisicao.METADADO.Endereco, obj.Endereco)
				.FieldValue(CTCRequisicao.METADADO.Numero, obj.Numero)
				.FieldValue(CTCRequisicao.METADADO.Complemento, obj.Complemento)
				.FieldValue(CTCRequisicao.METADADO.Cidade, obj.Cidade)
				.FieldValue(CTCRequisicao.METADADO.UF, obj.UF)
				.FieldValue(CTCRequisicao.METADADO.Cep, obj.Cep)
				.FieldValue(CTCRequisicao.METADADO.DataReferenciaSaldo, obj.DataReferenciaSaldo)
				.FieldValue(CTCRequisicao.METADADO.SaldoDevedor, obj.SaldoDevedor)
				.FieldValue(CTCRequisicao.METADADO.JurosNominal, obj.JurosNominal)
				.FieldValue(CTCRequisicao.METADADO.JurosEfetivo, obj.JurosEfetivo)
				.FieldValue(CTCRequisicao.METADADO.Cet, obj.Cet)
				.FieldValue(CTCRequisicao.METADADO.Moeda, obj.Moeda)
				.FieldValue(CTCRequisicao.METADADO.IndiceRemuneracao, obj.IndiceRemuneracao)
				.FieldValue(CTCRequisicao.METADADO.RegimeAmortizacao, obj.RegimeAmortizacao)
				.FieldValue(CTCRequisicao.METADADO.DataContrato, obj.DataContrato)
				.FieldValue(CTCRequisicao.METADADO.QtdParcelasContrato, obj.QtdParcelasContrato)
				.FieldValue(CTCRequisicao.METADADO.ValorFaceParcela, obj.ValorFaceParcela)
				.FieldValue(CTCRequisicao.METADADO.DataVencimentoPrimeiraParcela, obj.DataVencimentoPrimeiraParcela)
				.FieldValue(CTCRequisicao.METADADO.DataVencimentoUltimaParcela, obj.DataVencimentoUltimaParcela)
				.FieldValue(CTCRequisicao.METADADO.EnderecoCartaPortabilidade, obj.EnderecoCartaPortabilidade)
				.FieldValue(CTCRequisicao.METADADO.NumeroCartaPortabilidade, obj.NumeroCartaPortabilidade)
				.FieldValue(CTCRequisicao.METADADO.ComplementoCartaPortabilidade, obj.ComplementoCartaPortabilidade)
				.FieldValue(CTCRequisicao.METADADO.CidadeCartaPortabilidade, obj.CidadeCartaPortabilidade)
				.FieldValue(CTCRequisicao.METADADO.UFCartaPortabilidade, obj.UFCartaPortabilidade)
				.FieldValue(CTCRequisicao.METADADO.CepCartaPortabilidade, obj.CepCartaPortabilidade)
				.FieldValue(CTCRequisicao.METADADO.SituacaoPortabilidade, obj.SituacaoPortabilidade)
				.FieldValue(CTCRequisicao.METADADO.DataReferencia, obj.DataReferencia)
				.FieldValue(CTCRequisicao.METADADO.DataVencimentoRetencao, obj.DataVencimentoRetencao)
				.FieldValue(CTCRequisicao.METADADO.DataVencimentoAceite, obj.DataVencimentoAceite)
				.FieldValue(CTCRequisicao.METADADO.Arquivo, obj.Arquivo)
				.FieldValue(CTCRequisicao.METADADO.Fase, obj.Fase)
				.FieldValue(CTCRequisicao.METADADO.TipoArquivo, obj.TipoArquivo)
				.FieldValue(CTCRequisicao.METADADO.Status, obj.Status)
				.FieldValue(CTCRequisicao.METADADO.Mensagem, obj.Mensagem)
				.FieldValue(CTCRequisicao.METADADO.TipoFluxo, obj.TipoFluxo)
				.FieldValue(CTCRequisicao.METADADO.NumeroBeneficio, obj.NumeroBeneficio)
				.FieldValue(CTCRequisicao.METADADO.EspecieBeneficio, obj.EspecieBeneficio)
				.FieldValue(CTCRequisicao.METADADO.DataNascimento, obj.DataNascimento)
				.FieldValue(CTCRequisicao.METADADO.UFBeneficio, obj.UFBeneficio)
				.FieldValue(CTCRequisicao.METADADO.ProdutoOrigem, obj.ProdutoOrigem)
				.FieldValue(CTCRequisicao.METADADO.MotivoRetencao, obj.MotivoRetencao)
				.FieldValue(CTCRequisicao.METADADO.MotivoCancelamento, obj.MotivoCancelamento)
				.FieldValue(CTCRequisicao.METADADO.MotivoDecursoPrazo, obj.MotivoDecursoPrazo)
				.FieldValue(CTCRequisicao.METADADO.MotivoDevolucaoLiquidacao, obj.MotivoDevolucaoLiquidacao)
				.FieldValue(CTCRequisicao.METADADO.DataRespostaSaldo, obj.DataRespostaSaldo)
				.FieldValue(CTCRequisicao.METADADO.DataRetencao, obj.DataRetencao)
				.FieldValue(CTCRequisicao.METADADO.DataCancelamento, obj.DataCancelamento)
				.FieldValue(CTCRequisicao.METADADO.DataDecursoPrazo, obj.DataDecursoPrazo)
				.FieldValue(CTCRequisicao.METADADO.DataDevolucaoLiquidacao, obj.DataDevolucaoLiquidacao)
				.FieldValue(CTCRequisicao.METADADO.ObservacaoAceite, obj.ObservacaoAceite)
				.FieldValue(CTCRequisicao.METADADO.ObservacaoRetencao, obj.ObservacaoRetencao)
				.FieldValue(CTCRequisicao.METADADO.ObservacaoCancelamento, obj.ObservacaoCancelamento)
				.FieldValue(CTCRequisicao.METADADO.ObservacaoDecursodePrazo, obj.ObservacaoDecursodePrazo)
				.FieldValue(CTCRequisicao.METADADO.ObservacaoDevolucaoLiquidacao, obj.ObservacaoDevolucaoLiquidacao)
				.FieldValue(CTCRequisicao.METADADO.DataReferenciaSaldoResposta, obj.DataReferenciaSaldoResposta)
				.FieldValue(CTCRequisicao.METADADO.UsuarioAceite, obj.UsuarioAceite)
				.FieldValue(CTCRequisicao.METADADO.SaldoAceiteInformado, obj.SaldoAceiteInformado)
				.FieldValue(CTCRequisicao.METADADO.DataReferenciaRetencao, obj.DataReferenciaRetencao)
				.FieldValue(CTCRequisicao.METADADO.UsuarioRetencao, obj.UsuarioRetencao)
				.FieldValue(CTCRequisicao.METADADO.DataPagamento, obj.DataPagamento)
				.FieldValue(CTCRequisicao.METADADO.UsuarioPagamento, obj.UsuarioPagamento)
				.FieldValue(CTCRequisicao.METADADO.ValorPago, obj.ValorPago)
				.FieldValue(CTCRequisicao.METADADO.UsuarioCancelamento, obj.UsuarioCancelamento)
				.FieldValue(CTCRequisicao.METADADO.ValorRCOCalculado, obj.ValorRCOCalculado)
				.FieldValue(CTCRequisicao.METADADO.ValorRCOApurado, obj.ValorRCOApurado)
				.Table(CTCRequisicao.METADADO.tabelaNAME);

			update.Where
				.Add(CTCRequisicao.METADADO.Id, Filter.Equal, obj.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, update.ToString());
				update.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

		#region Inserir
		public void Incluir(CTCRequisicao obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(CTCRequisicao.METADADO.tabelaNAME)
				.FieldValue(CTCRequisicao.METADADO.IdentificacaoParticipanteAdministrado, obj.IdentificacaoParticipanteAdministrado)
				.FieldValue(CTCRequisicao.METADADO.NUPortabilidade, obj.NUPortabilidade)
				.FieldValue(CTCRequisicao.METADADO.IFProponente, obj.IFProponente)
				.FieldValue(CTCRequisicao.METADADO.Contrato, obj.Contrato)
				.FieldValue(CTCRequisicao.METADADO.CNPJBaseIFOriginadora, obj.CNPJBaseIFOriginadora)
				.FieldValue(CTCRequisicao.METADADO.TipoContrato, obj.TipoContrato)
				.FieldValue(CTCRequisicao.METADADO.EnteConsignante, obj.EnteConsignante)
				.FieldValue(CTCRequisicao.METADADO.CNPJCorrespondenteBancario, obj.CNPJCorrespondenteBancario)
				.FieldValue(CTCRequisicao.METADADO.TipoPessoa, obj.TipoPessoa)
				.FieldValue(CTCRequisicao.METADADO.CpfCnpjCliente, obj.CpfCnpjCliente)
				.FieldValue(CTCRequisicao.METADADO.NomeCliente, obj.NomeCliente)
				.FieldValue(CTCRequisicao.METADADO.Telefone, obj.Telefone)
				.FieldValue(CTCRequisicao.METADADO.Email, obj.Email)
				.FieldValue(CTCRequisicao.METADADO.Endereco, obj.Endereco)
				.FieldValue(CTCRequisicao.METADADO.Numero, obj.Numero)
				.FieldValue(CTCRequisicao.METADADO.Complemento, obj.Complemento)
				.FieldValue(CTCRequisicao.METADADO.Cidade, obj.Cidade)
				.FieldValue(CTCRequisicao.METADADO.UF, obj.UF)
				.FieldValue(CTCRequisicao.METADADO.Cep, obj.Cep)
				.FieldValue(CTCRequisicao.METADADO.DataReferenciaSaldo, obj.DataReferenciaSaldo)
				.FieldValue(CTCRequisicao.METADADO.SaldoDevedor, obj.SaldoDevedor)
				.FieldValue(CTCRequisicao.METADADO.JurosNominal, obj.JurosNominal)
				.FieldValue(CTCRequisicao.METADADO.JurosEfetivo, obj.JurosEfetivo)
				.FieldValue(CTCRequisicao.METADADO.Cet, obj.Cet)
				.FieldValue(CTCRequisicao.METADADO.Moeda, obj.Moeda)
				.FieldValue(CTCRequisicao.METADADO.IndiceRemuneracao, obj.IndiceRemuneracao)
				.FieldValue(CTCRequisicao.METADADO.RegimeAmortizacao, obj.RegimeAmortizacao)
				.FieldValue(CTCRequisicao.METADADO.DataContrato, obj.DataContrato)
				.FieldValue(CTCRequisicao.METADADO.QtdParcelasContrato, obj.QtdParcelasContrato)
				.FieldValue(CTCRequisicao.METADADO.ValorFaceParcela, obj.ValorFaceParcela)
				.FieldValue(CTCRequisicao.METADADO.DataVencimentoPrimeiraParcela, obj.DataVencimentoPrimeiraParcela)
				.FieldValue(CTCRequisicao.METADADO.DataVencimentoUltimaParcela, obj.DataVencimentoUltimaParcela)
				.FieldValue(CTCRequisicao.METADADO.EnderecoCartaPortabilidade, obj.EnderecoCartaPortabilidade)
				.FieldValue(CTCRequisicao.METADADO.NumeroCartaPortabilidade, obj.NumeroCartaPortabilidade)
				.FieldValue(CTCRequisicao.METADADO.ComplementoCartaPortabilidade, obj.ComplementoCartaPortabilidade)
				.FieldValue(CTCRequisicao.METADADO.CidadeCartaPortabilidade, obj.CidadeCartaPortabilidade)
				.FieldValue(CTCRequisicao.METADADO.UFCartaPortabilidade, obj.UFCartaPortabilidade)
				.FieldValue(CTCRequisicao.METADADO.CepCartaPortabilidade, obj.CepCartaPortabilidade)
				.FieldValue(CTCRequisicao.METADADO.SituacaoPortabilidade, obj.SituacaoPortabilidade)
				.FieldValue(CTCRequisicao.METADADO.DataReferencia, obj.DataReferencia)
				.FieldValue(CTCRequisicao.METADADO.DataVencimentoRetencao, obj.DataVencimentoRetencao)
				.FieldValue(CTCRequisicao.METADADO.DataVencimentoAceite, obj.DataVencimentoAceite)
				.FieldValue(CTCRequisicao.METADADO.Arquivo, obj.Arquivo)
				.FieldValue(CTCRequisicao.METADADO.Fase, obj.Fase)
				.FieldValue(CTCRequisicao.METADADO.TipoArquivo, obj.TipoArquivo)
				.FieldValue(CTCRequisicao.METADADO.Status, obj.Status)
				.FieldValue(CTCRequisicao.METADADO.Mensagem, obj.Mensagem)
				.FieldValue(CTCRequisicao.METADADO.TipoFluxo, obj.TipoFluxo)
				.FieldValue(CTCRequisicao.METADADO.NumeroBeneficio, obj.NumeroBeneficio)
				.FieldValue(CTCRequisicao.METADADO.EspecieBeneficio, obj.EspecieBeneficio)
				.FieldValue(CTCRequisicao.METADADO.DataNascimento, obj.DataNascimento)
				.FieldValue(CTCRequisicao.METADADO.UFBeneficio, obj.UFBeneficio)
				.FieldValue(CTCRequisicao.METADADO.ProdutoOrigem, obj.ProdutoOrigem)
				.FieldValue(CTCRequisicao.METADADO.MotivoRetencao, obj.MotivoRetencao)
				.FieldValue(CTCRequisicao.METADADO.MotivoCancelamento, obj.MotivoCancelamento)
				.FieldValue(CTCRequisicao.METADADO.MotivoDecursoPrazo, obj.MotivoDecursoPrazo)
				.FieldValue(CTCRequisicao.METADADO.MotivoDevolucaoLiquidacao, obj.MotivoDevolucaoLiquidacao)
				.FieldValue(CTCRequisicao.METADADO.DataRespostaSaldo, obj.DataRespostaSaldo)
				.FieldValue(CTCRequisicao.METADADO.DataRetencao, obj.DataRetencao)
				.FieldValue(CTCRequisicao.METADADO.DataCancelamento, obj.DataCancelamento)
				.FieldValue(CTCRequisicao.METADADO.DataDecursoPrazo, obj.DataDecursoPrazo)
				.FieldValue(CTCRequisicao.METADADO.DataDevolucaoLiquidacao, obj.DataDevolucaoLiquidacao)
				.FieldValue(CTCRequisicao.METADADO.ObservacaoAceite, obj.ObservacaoAceite)
				.FieldValue(CTCRequisicao.METADADO.ObservacaoRetencao, obj.ObservacaoRetencao)
				.FieldValue(CTCRequisicao.METADADO.ObservacaoCancelamento, obj.ObservacaoCancelamento)
				.FieldValue(CTCRequisicao.METADADO.ObservacaoDecursodePrazo, obj.ObservacaoDecursodePrazo)
				.FieldValue(CTCRequisicao.METADADO.ObservacaoDevolucaoLiquidacao, obj.ObservacaoDevolucaoLiquidacao)
				.FieldValue(CTCRequisicao.METADADO.DataReferenciaSaldoResposta, obj.DataReferenciaSaldoResposta)
				.FieldValue(CTCRequisicao.METADADO.UsuarioAceite, obj.UsuarioAceite)
				.FieldValue(CTCRequisicao.METADADO.SaldoAceiteInformado, obj.SaldoAceiteInformado)
				.FieldValue(CTCRequisicao.METADADO.DataReferenciaRetencao, obj.DataReferenciaRetencao)
				.FieldValue(CTCRequisicao.METADADO.UsuarioRetencao, obj.UsuarioRetencao)
				.FieldValue(CTCRequisicao.METADADO.DataPagamento, obj.DataPagamento)
				.FieldValue(CTCRequisicao.METADADO.UsuarioPagamento, obj.UsuarioPagamento)
				.FieldValue(CTCRequisicao.METADADO.ValorPago, obj.ValorPago)
				.FieldValue(CTCRequisicao.METADADO.UsuarioCancelamento, obj.UsuarioCancelamento)
				.FieldValue(CTCRequisicao.METADADO.ValorRCOCalculado, obj.ValorRCOCalculado)
				.FieldValue(CTCRequisicao.METADADO.ValorRCOApurado, obj.ValorRCOApurado)
				.SetIdentityField(CTCRequisicao.METADADO.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, insert.ToString());
				insert.SetParameters(cmd);

				obj.Id = base.ExecuteScalar<int?>(cmd);
			}
		}
		#endregion

		#region Obtem
		public CTCRequisicao Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CTCRequisicao.METADADO.Id)
				.Field(CTCRequisicao.METADADO.IdentificacaoParticipanteAdministrado)
				.Field(CTCRequisicao.METADADO.NUPortabilidade)
				.Field(CTCRequisicao.METADADO.IFProponente)
				.Field(CTCRequisicao.METADADO.Contrato)
				.Field(CTCRequisicao.METADADO.CNPJBaseIFOriginadora)
				.Field(CTCRequisicao.METADADO.TipoContrato)
				.Field(CTCRequisicao.METADADO.EnteConsignante)
				.Field(CTCRequisicao.METADADO.CNPJCorrespondenteBancario)
				.Field(CTCRequisicao.METADADO.TipoPessoa)
				.Field(CTCRequisicao.METADADO.CpfCnpjCliente)
				.Field(CTCRequisicao.METADADO.NomeCliente)
				.Field(CTCRequisicao.METADADO.Telefone)
				.Field(CTCRequisicao.METADADO.Email)
				.Field(CTCRequisicao.METADADO.Endereco)
				.Field(CTCRequisicao.METADADO.Numero)
				.Field(CTCRequisicao.METADADO.Complemento)
				.Field(CTCRequisicao.METADADO.Cidade)
				.Field(CTCRequisicao.METADADO.UF)
				.Field(CTCRequisicao.METADADO.Cep)
				.Field(CTCRequisicao.METADADO.DataReferenciaSaldo)
				.Field(CTCRequisicao.METADADO.SaldoDevedor)
				.Field(CTCRequisicao.METADADO.JurosNominal)
				.Field(CTCRequisicao.METADADO.JurosEfetivo)
				.Field(CTCRequisicao.METADADO.Cet)
				.Field(CTCRequisicao.METADADO.Moeda)
				.Field(CTCRequisicao.METADADO.IndiceRemuneracao)
				.Field(CTCRequisicao.METADADO.RegimeAmortizacao)
				.Field(CTCRequisicao.METADADO.DataContrato)
				.Field(CTCRequisicao.METADADO.QtdParcelasContrato)
				.Field(CTCRequisicao.METADADO.ValorFaceParcela)
				.Field(CTCRequisicao.METADADO.DataVencimentoPrimeiraParcela)
				.Field(CTCRequisicao.METADADO.DataVencimentoUltimaParcela)
				.Field(CTCRequisicao.METADADO.EnderecoCartaPortabilidade)
				.Field(CTCRequisicao.METADADO.NumeroCartaPortabilidade)
				.Field(CTCRequisicao.METADADO.ComplementoCartaPortabilidade)
				.Field(CTCRequisicao.METADADO.CidadeCartaPortabilidade)
				.Field(CTCRequisicao.METADADO.UFCartaPortabilidade)
				.Field(CTCRequisicao.METADADO.CepCartaPortabilidade)
				.Field(CTCRequisicao.METADADO.SituacaoPortabilidade)
				.Field(CTCRequisicao.METADADO.DataReferencia)
				.Field(CTCRequisicao.METADADO.DataVencimentoRetencao)
				.Field(CTCRequisicao.METADADO.DataVencimentoAceite)
				.Field(CTCRequisicao.METADADO.Arquivo)
				.Field(CTCRequisicao.METADADO.Fase)
				.Field(CTCRequisicao.METADADO.TipoArquivo)
				.Field(CTCRequisicao.METADADO.Status)
				.Field(CTCRequisicao.METADADO.Mensagem)
				.Field(CTCRequisicao.METADADO.TipoFluxo)
				.Field(CTCRequisicao.METADADO.NumeroBeneficio)
				.Field(CTCRequisicao.METADADO.EspecieBeneficio)
				.Field(CTCRequisicao.METADADO.DataNascimento)
				.Field(CTCRequisicao.METADADO.UFBeneficio)
				.Field(CTCRequisicao.METADADO.ProdutoOrigem)
				.Field(CTCRequisicao.METADADO.MotivoRetencao)
				.Field(CTCRequisicao.METADADO.MotivoCancelamento)
				.Field(CTCRequisicao.METADADO.MotivoDecursoPrazo)
				.Field(CTCRequisicao.METADADO.MotivoDevolucaoLiquidacao)
				.Field(CTCRequisicao.METADADO.DataRespostaSaldo)
				.Field(CTCRequisicao.METADADO.DataRetencao)
				.Field(CTCRequisicao.METADADO.DataCancelamento)
				.Field(CTCRequisicao.METADADO.DataDecursoPrazo)
				.Field(CTCRequisicao.METADADO.DataDevolucaoLiquidacao)
				.Field(CTCRequisicao.METADADO.ObservacaoAceite)
				.Field(CTCRequisicao.METADADO.ObservacaoRetencao)
				.Field(CTCRequisicao.METADADO.ObservacaoCancelamento)
				.Field(CTCRequisicao.METADADO.ObservacaoDecursodePrazo)
				.Field(CTCRequisicao.METADADO.ObservacaoDevolucaoLiquidacao)
				.Field(CTCRequisicao.METADADO.DataReferenciaSaldoResposta)
				.Field(CTCRequisicao.METADADO.UsuarioAceite)
				.Field(CTCRequisicao.METADADO.SaldoAceiteInformado)
				.Field(CTCRequisicao.METADADO.DataReferenciaRetencao)
				.Field(CTCRequisicao.METADADO.UsuarioRetencao)
				.Field(CTCRequisicao.METADADO.DataPagamento)
				.Field(CTCRequisicao.METADADO.UsuarioPagamento)
				.Field(CTCRequisicao.METADADO.ValorPago)
				.Field(CTCRequisicao.METADADO.UsuarioCancelamento)
				.Field(CTCRequisicao.METADADO.ValorRCOCalculado)
				.Field(CTCRequisicao.METADADO.ValorRCOApurado)
				.Table(CTCRequisicao.METADADO.tabelaNAME);

			query.Where
				.Add(CTCRequisicao.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				CTCRequisicao result = base.MapReaderToEntity<CTCRequisicao>(cmd);
				return result;
			}
		}
		#endregion

		#region Excluir por FKs
		public void ExcluirPor_TipoContrato(string TipoContrato)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(CTCRequisicao.METADADO.tabelaNAME);
			delete.Where
				.Add(CTCRequisicao.METADADO.TipoContrato, Filter.Equal, TipoContrato);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, delete.ToString());
				delete.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		public void ExcluirPor_EnteConsignante(string EnteConsignante)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(CTCRequisicao.METADADO.tabelaNAME);
			delete.Where
				.Add(CTCRequisicao.METADADO.EnteConsignante, Filter.Equal, EnteConsignante);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, delete.ToString());
				delete.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		public void ExcluirPor_Moeda(string Moeda)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(CTCRequisicao.METADADO.tabelaNAME);
			delete.Where
				.Add(CTCRequisicao.METADADO.Moeda, Filter.Equal, Moeda);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, delete.ToString());
				delete.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		public void ExcluirPor_IndiceRemuneracao(string IndiceRemuneracao)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(CTCRequisicao.METADADO.tabelaNAME);
			delete.Where
				.Add(CTCRequisicao.METADADO.IndiceRemuneracao, Filter.Equal, IndiceRemuneracao);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, delete.ToString());
				delete.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		public void ExcluirPor_RegimeAmortizacao(string RegimeAmortizacao)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(CTCRequisicao.METADADO.tabelaNAME);
			delete.Where
				.Add(CTCRequisicao.METADADO.RegimeAmortizacao, Filter.Equal, RegimeAmortizacao);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, delete.ToString());
				delete.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		public void ExcluirPor_SituacaoPortabilidade(string SituacaoPortabilidade)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(CTCRequisicao.METADADO.tabelaNAME);
			delete.Where
				.Add(CTCRequisicao.METADADO.SituacaoPortabilidade, Filter.Equal, SituacaoPortabilidade);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, delete.ToString());
				delete.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		public void ExcluirPor_Arquivo(int? Arquivo)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(CTCRequisicao.METADADO.tabelaNAME);
			delete.Where
				.Add(CTCRequisicao.METADADO.Arquivo, Filter.Equal, Arquivo);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, delete.ToString());
				delete.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		public void ExcluirPor_Fase(int? Fase)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(CTCRequisicao.METADADO.tabelaNAME);
			delete.Where
				.Add(CTCRequisicao.METADADO.Fase, Filter.Equal, Fase);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, delete.ToString());
				delete.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		public void ExcluirPor_TipoArquivo(int? TipoArquivo)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(CTCRequisicao.METADADO.tabelaNAME);
			delete.Where
				.Add(CTCRequisicao.METADADO.TipoArquivo, Filter.Equal, TipoArquivo);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, delete.ToString());
				delete.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		public void ExcluirPor_TipoFluxo(int? TipoFluxo)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(CTCRequisicao.METADADO.tabelaNAME);
			delete.Where
				.Add(CTCRequisicao.METADADO.TipoFluxo, Filter.Equal, TipoFluxo);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, delete.ToString());
				delete.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		public void ExcluirPor_MotivoRetencao(string MotivoRetencao)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(CTCRequisicao.METADADO.tabelaNAME);
			delete.Where
				.Add(CTCRequisicao.METADADO.MotivoRetencao, Filter.Equal, MotivoRetencao);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, delete.ToString());
				delete.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		public void ExcluirPor_MotivoCancelamento(string MotivoCancelamento)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(CTCRequisicao.METADADO.tabelaNAME);
			delete.Where
				.Add(CTCRequisicao.METADADO.MotivoCancelamento, Filter.Equal, MotivoCancelamento);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, delete.ToString());
				delete.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		public void ExcluirPor_MotivoDecursoPrazo(string MotivoDecursoPrazo)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(CTCRequisicao.METADADO.tabelaNAME);
			delete.Where
				.Add(CTCRequisicao.METADADO.MotivoDecursoPrazo, Filter.Equal, MotivoDecursoPrazo);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, delete.ToString());
				delete.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		public void ExcluirPor_MotivoDevolucaoLiquidacao(string MotivoDevolucaoLiquidacao)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(CTCRequisicao.METADADO.tabelaNAME);
			delete.Where
				.Add(CTCRequisicao.METADADO.MotivoDevolucaoLiquidacao, Filter.Equal, MotivoDevolucaoLiquidacao);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, delete.ToString());
				delete.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(CTCRequisicao.METADADO.tabelaNAME);
			delete.Where
				.Add(CTCRequisicao.METADADO.Id, Filter.Equal, Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, delete.ToString());
				delete.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

	}
}
