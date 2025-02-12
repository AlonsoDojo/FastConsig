
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
	public partial class CTC924DetalhesData : DataBase
	{
		
		#region Listar
		public List<CTC924Detalhes> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CTC924Detalhes.METADADO.Id)
				.Field(CTC924Detalhes.METADADO.CTC924)
				.Field(CTC924Detalhes.METADADO.DataSolicitacao)
				.Field(CTC924Detalhes.METADADO.NUPortabilidade)
				.Field(CTC924Detalhes.METADADO.SituacaoPortabilidadeCTC)
				.Field(CTC924Detalhes.METADADO.ISPBProponente)
				.Field(CTC924Detalhes.METADADO.DataReferenciaSaldoDevedorProponente)
				.Field(CTC924Detalhes.METADADO.ValorSaldoDevedorProponente)
				.Field(CTC924Detalhes.METADADO.DataReferenciaSaldoDevedorOriginal)
				.Field(CTC924Detalhes.METADADO.ValorSaldoDevedorOriginal)
				.Field(CTC924Detalhes.METADADO.Contrato)
				.Field(CTC924Detalhes.METADADO.CNPJBaseIFOriginal)
				.Field(CTC924Detalhes.METADADO.TipoContrato)
				.Field(CTC924Detalhes.METADADO.EnteConsignante)
				.Field(CTC924Detalhes.METADADO.CNPJCorrespondenteBancario)
				.Field(CTC924Detalhes.METADADO.TipoCliente)
				.Field(CTC924Detalhes.METADADO.CpfCnpjCliente)
				.Field(CTC924Detalhes.METADADO.NomeCliente)
				.Field(CTC924Detalhes.METADADO.TelefoneCliente)
				.Field(CTC924Detalhes.METADADO.EmailCliente)
				.Field(CTC924Detalhes.METADADO.LogradouroEnderecoCliente)
				.Field(CTC924Detalhes.METADADO.NumeroEnderecoCliente)
				.Field(CTC924Detalhes.METADADO.CidadeEnderecoCliente)
				.Field(CTC924Detalhes.METADADO.UFEnderecoCliente)
				.Field(CTC924Detalhes.METADADO.CEPEnderecoCliente)
				.Field(CTC924Detalhes.METADADO.DataDecursoPrazo)
				.Field(CTC924Detalhes.METADADO.MotivoDecursoPrazo)
				.Field(CTC924Detalhes.METADADO.DataCancelamento)
				.Field(CTC924Detalhes.METADADO.MotivoCancelamento)
				.Field(CTC924Detalhes.METADADO.ISPBSolicitanteCancelamento)
				.Field(CTC924Detalhes.METADADO.DataRetencao)
				.Field(CTC924Detalhes.METADADO.MotivoRetencaoContrato)
				.Field(CTC924Detalhes.METADADO.DataLiquidacao)
				.Field(CTC924Detalhes.METADADO.SituacaoLiquidacao)
				.Field(CTC924Detalhes.METADADO.ValorLiquidacaoPortabilidade)
				.Field(CTC924Detalhes.METADADO.DataDevolucaoLiquidacao)
				.Field(CTC924Detalhes.METADADO.SituacaoDevolucaoLiquidacao)
				.Field(CTC924Detalhes.METADADO.MotivoDevolucaoLiquidacao)
				.Field(CTC924Detalhes.METADADO.ValorDevolucaoLiquidacao)
				.Field(CTC924Detalhes.METADADO.DataEfetivacaoPortabilidade)
				.Field(CTC924Detalhes.METADADO.SituacaoEfetivacaoPortabilidade)
				.Field(CTC924Detalhes.METADADO.ValorRCO)
				.Table(CTC924Detalhes.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				List<CTC924Detalhes> result = base.MapReaderToEntitySet<CTC924Detalhes>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(CTC924Detalhes obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(CTC924Detalhes.METADADO.CTC924, obj.CTC924)
				.FieldValue(CTC924Detalhes.METADADO.DataSolicitacao, obj.DataSolicitacao)
				.FieldValue(CTC924Detalhes.METADADO.NUPortabilidade, obj.NUPortabilidade)
				.FieldValue(CTC924Detalhes.METADADO.SituacaoPortabilidadeCTC, obj.SituacaoPortabilidadeCTC)
				.FieldValue(CTC924Detalhes.METADADO.ISPBProponente, obj.ISPBProponente)
				.FieldValue(CTC924Detalhes.METADADO.DataReferenciaSaldoDevedorProponente, obj.DataReferenciaSaldoDevedorProponente)
				.FieldValue(CTC924Detalhes.METADADO.ValorSaldoDevedorProponente, obj.ValorSaldoDevedorProponente)
				.FieldValue(CTC924Detalhes.METADADO.DataReferenciaSaldoDevedorOriginal, obj.DataReferenciaSaldoDevedorOriginal)
				.FieldValue(CTC924Detalhes.METADADO.ValorSaldoDevedorOriginal, obj.ValorSaldoDevedorOriginal)
				.FieldValue(CTC924Detalhes.METADADO.Contrato, obj.Contrato)
				.FieldValue(CTC924Detalhes.METADADO.CNPJBaseIFOriginal, obj.CNPJBaseIFOriginal)
				.FieldValue(CTC924Detalhes.METADADO.TipoContrato, obj.TipoContrato)
				.FieldValue(CTC924Detalhes.METADADO.EnteConsignante, obj.EnteConsignante)
				.FieldValue(CTC924Detalhes.METADADO.CNPJCorrespondenteBancario, obj.CNPJCorrespondenteBancario)
				.FieldValue(CTC924Detalhes.METADADO.TipoCliente, obj.TipoCliente)
				.FieldValue(CTC924Detalhes.METADADO.CpfCnpjCliente, obj.CpfCnpjCliente)
				.FieldValue(CTC924Detalhes.METADADO.NomeCliente, obj.NomeCliente)
				.FieldValue(CTC924Detalhes.METADADO.TelefoneCliente, obj.TelefoneCliente)
				.FieldValue(CTC924Detalhes.METADADO.EmailCliente, obj.EmailCliente)
				.FieldValue(CTC924Detalhes.METADADO.LogradouroEnderecoCliente, obj.LogradouroEnderecoCliente)
				.FieldValue(CTC924Detalhes.METADADO.NumeroEnderecoCliente, obj.NumeroEnderecoCliente)
				.FieldValue(CTC924Detalhes.METADADO.CidadeEnderecoCliente, obj.CidadeEnderecoCliente)
				.FieldValue(CTC924Detalhes.METADADO.UFEnderecoCliente, obj.UFEnderecoCliente)
				.FieldValue(CTC924Detalhes.METADADO.CEPEnderecoCliente, obj.CEPEnderecoCliente)
				.FieldValue(CTC924Detalhes.METADADO.DataDecursoPrazo, obj.DataDecursoPrazo)
				.FieldValue(CTC924Detalhes.METADADO.MotivoDecursoPrazo, obj.MotivoDecursoPrazo)
				.FieldValue(CTC924Detalhes.METADADO.DataCancelamento, obj.DataCancelamento)
				.FieldValue(CTC924Detalhes.METADADO.MotivoCancelamento, obj.MotivoCancelamento)
				.FieldValue(CTC924Detalhes.METADADO.ISPBSolicitanteCancelamento, obj.ISPBSolicitanteCancelamento)
				.FieldValue(CTC924Detalhes.METADADO.DataRetencao, obj.DataRetencao)
				.FieldValue(CTC924Detalhes.METADADO.MotivoRetencaoContrato, obj.MotivoRetencaoContrato)
				.FieldValue(CTC924Detalhes.METADADO.DataLiquidacao, obj.DataLiquidacao)
				.FieldValue(CTC924Detalhes.METADADO.SituacaoLiquidacao, obj.SituacaoLiquidacao)
				.FieldValue(CTC924Detalhes.METADADO.ValorLiquidacaoPortabilidade, obj.ValorLiquidacaoPortabilidade)
				.FieldValue(CTC924Detalhes.METADADO.DataDevolucaoLiquidacao, obj.DataDevolucaoLiquidacao)
				.FieldValue(CTC924Detalhes.METADADO.SituacaoDevolucaoLiquidacao, obj.SituacaoDevolucaoLiquidacao)
				.FieldValue(CTC924Detalhes.METADADO.MotivoDevolucaoLiquidacao, obj.MotivoDevolucaoLiquidacao)
				.FieldValue(CTC924Detalhes.METADADO.ValorDevolucaoLiquidacao, obj.ValorDevolucaoLiquidacao)
				.FieldValue(CTC924Detalhes.METADADO.DataEfetivacaoPortabilidade, obj.DataEfetivacaoPortabilidade)
				.FieldValue(CTC924Detalhes.METADADO.SituacaoEfetivacaoPortabilidade, obj.SituacaoEfetivacaoPortabilidade)
				.FieldValue(CTC924Detalhes.METADADO.ValorRCO, obj.ValorRCO)
				.Table(CTC924Detalhes.METADADO.tabelaNAME);

			update.Where
				.Add(CTC924Detalhes.METADADO.Id, Filter.Equal, obj.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, update.ToString());
				update.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

		#region Inserir
		public void Incluir(CTC924Detalhes obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(CTC924Detalhes.METADADO.tabelaNAME)
				.FieldValue(CTC924Detalhes.METADADO.CTC924, obj.CTC924)
				.FieldValue(CTC924Detalhes.METADADO.DataSolicitacao, obj.DataSolicitacao)
				.FieldValue(CTC924Detalhes.METADADO.NUPortabilidade, obj.NUPortabilidade)
				.FieldValue(CTC924Detalhes.METADADO.SituacaoPortabilidadeCTC, obj.SituacaoPortabilidadeCTC)
				.FieldValue(CTC924Detalhes.METADADO.ISPBProponente, obj.ISPBProponente)
				.FieldValue(CTC924Detalhes.METADADO.DataReferenciaSaldoDevedorProponente, obj.DataReferenciaSaldoDevedorProponente)
				.FieldValue(CTC924Detalhes.METADADO.ValorSaldoDevedorProponente, obj.ValorSaldoDevedorProponente)
				.FieldValue(CTC924Detalhes.METADADO.DataReferenciaSaldoDevedorOriginal, obj.DataReferenciaSaldoDevedorOriginal)
				.FieldValue(CTC924Detalhes.METADADO.ValorSaldoDevedorOriginal, obj.ValorSaldoDevedorOriginal)
				.FieldValue(CTC924Detalhes.METADADO.Contrato, obj.Contrato)
				.FieldValue(CTC924Detalhes.METADADO.CNPJBaseIFOriginal, obj.CNPJBaseIFOriginal)
				.FieldValue(CTC924Detalhes.METADADO.TipoContrato, obj.TipoContrato)
				.FieldValue(CTC924Detalhes.METADADO.EnteConsignante, obj.EnteConsignante)
				.FieldValue(CTC924Detalhes.METADADO.CNPJCorrespondenteBancario, obj.CNPJCorrespondenteBancario)
				.FieldValue(CTC924Detalhes.METADADO.TipoCliente, obj.TipoCliente)
				.FieldValue(CTC924Detalhes.METADADO.CpfCnpjCliente, obj.CpfCnpjCliente)
				.FieldValue(CTC924Detalhes.METADADO.NomeCliente, obj.NomeCliente)
				.FieldValue(CTC924Detalhes.METADADO.TelefoneCliente, obj.TelefoneCliente)
				.FieldValue(CTC924Detalhes.METADADO.EmailCliente, obj.EmailCliente)
				.FieldValue(CTC924Detalhes.METADADO.LogradouroEnderecoCliente, obj.LogradouroEnderecoCliente)
				.FieldValue(CTC924Detalhes.METADADO.NumeroEnderecoCliente, obj.NumeroEnderecoCliente)
				.FieldValue(CTC924Detalhes.METADADO.CidadeEnderecoCliente, obj.CidadeEnderecoCliente)
				.FieldValue(CTC924Detalhes.METADADO.UFEnderecoCliente, obj.UFEnderecoCliente)
				.FieldValue(CTC924Detalhes.METADADO.CEPEnderecoCliente, obj.CEPEnderecoCliente)
				.FieldValue(CTC924Detalhes.METADADO.DataDecursoPrazo, obj.DataDecursoPrazo)
				.FieldValue(CTC924Detalhes.METADADO.MotivoDecursoPrazo, obj.MotivoDecursoPrazo)
				.FieldValue(CTC924Detalhes.METADADO.DataCancelamento, obj.DataCancelamento)
				.FieldValue(CTC924Detalhes.METADADO.MotivoCancelamento, obj.MotivoCancelamento)
				.FieldValue(CTC924Detalhes.METADADO.ISPBSolicitanteCancelamento, obj.ISPBSolicitanteCancelamento)
				.FieldValue(CTC924Detalhes.METADADO.DataRetencao, obj.DataRetencao)
				.FieldValue(CTC924Detalhes.METADADO.MotivoRetencaoContrato, obj.MotivoRetencaoContrato)
				.FieldValue(CTC924Detalhes.METADADO.DataLiquidacao, obj.DataLiquidacao)
				.FieldValue(CTC924Detalhes.METADADO.SituacaoLiquidacao, obj.SituacaoLiquidacao)
				.FieldValue(CTC924Detalhes.METADADO.ValorLiquidacaoPortabilidade, obj.ValorLiquidacaoPortabilidade)
				.FieldValue(CTC924Detalhes.METADADO.DataDevolucaoLiquidacao, obj.DataDevolucaoLiquidacao)
				.FieldValue(CTC924Detalhes.METADADO.SituacaoDevolucaoLiquidacao, obj.SituacaoDevolucaoLiquidacao)
				.FieldValue(CTC924Detalhes.METADADO.MotivoDevolucaoLiquidacao, obj.MotivoDevolucaoLiquidacao)
				.FieldValue(CTC924Detalhes.METADADO.ValorDevolucaoLiquidacao, obj.ValorDevolucaoLiquidacao)
				.FieldValue(CTC924Detalhes.METADADO.DataEfetivacaoPortabilidade, obj.DataEfetivacaoPortabilidade)
				.FieldValue(CTC924Detalhes.METADADO.SituacaoEfetivacaoPortabilidade, obj.SituacaoEfetivacaoPortabilidade)
				.FieldValue(CTC924Detalhes.METADADO.ValorRCO, obj.ValorRCO)
				.SetIdentityField(CTC924Detalhes.METADADO.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, insert.ToString());
				insert.SetParameters(cmd);

				obj.Id = base.ExecuteScalar<int?>(cmd);
			}
		}
		#endregion

		#region Obtem
		public CTC924Detalhes Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CTC924Detalhes.METADADO.Id)
				.Field(CTC924Detalhes.METADADO.CTC924)
				.Field(CTC924Detalhes.METADADO.DataSolicitacao)
				.Field(CTC924Detalhes.METADADO.NUPortabilidade)
				.Field(CTC924Detalhes.METADADO.SituacaoPortabilidadeCTC)
				.Field(CTC924Detalhes.METADADO.ISPBProponente)
				.Field(CTC924Detalhes.METADADO.DataReferenciaSaldoDevedorProponente)
				.Field(CTC924Detalhes.METADADO.ValorSaldoDevedorProponente)
				.Field(CTC924Detalhes.METADADO.DataReferenciaSaldoDevedorOriginal)
				.Field(CTC924Detalhes.METADADO.ValorSaldoDevedorOriginal)
				.Field(CTC924Detalhes.METADADO.Contrato)
				.Field(CTC924Detalhes.METADADO.CNPJBaseIFOriginal)
				.Field(CTC924Detalhes.METADADO.TipoContrato)
				.Field(CTC924Detalhes.METADADO.EnteConsignante)
				.Field(CTC924Detalhes.METADADO.CNPJCorrespondenteBancario)
				.Field(CTC924Detalhes.METADADO.TipoCliente)
				.Field(CTC924Detalhes.METADADO.CpfCnpjCliente)
				.Field(CTC924Detalhes.METADADO.NomeCliente)
				.Field(CTC924Detalhes.METADADO.TelefoneCliente)
				.Field(CTC924Detalhes.METADADO.EmailCliente)
				.Field(CTC924Detalhes.METADADO.LogradouroEnderecoCliente)
				.Field(CTC924Detalhes.METADADO.NumeroEnderecoCliente)
				.Field(CTC924Detalhes.METADADO.CidadeEnderecoCliente)
				.Field(CTC924Detalhes.METADADO.UFEnderecoCliente)
				.Field(CTC924Detalhes.METADADO.CEPEnderecoCliente)
				.Field(CTC924Detalhes.METADADO.DataDecursoPrazo)
				.Field(CTC924Detalhes.METADADO.MotivoDecursoPrazo)
				.Field(CTC924Detalhes.METADADO.DataCancelamento)
				.Field(CTC924Detalhes.METADADO.MotivoCancelamento)
				.Field(CTC924Detalhes.METADADO.ISPBSolicitanteCancelamento)
				.Field(CTC924Detalhes.METADADO.DataRetencao)
				.Field(CTC924Detalhes.METADADO.MotivoRetencaoContrato)
				.Field(CTC924Detalhes.METADADO.DataLiquidacao)
				.Field(CTC924Detalhes.METADADO.SituacaoLiquidacao)
				.Field(CTC924Detalhes.METADADO.ValorLiquidacaoPortabilidade)
				.Field(CTC924Detalhes.METADADO.DataDevolucaoLiquidacao)
				.Field(CTC924Detalhes.METADADO.SituacaoDevolucaoLiquidacao)
				.Field(CTC924Detalhes.METADADO.MotivoDevolucaoLiquidacao)
				.Field(CTC924Detalhes.METADADO.ValorDevolucaoLiquidacao)
				.Field(CTC924Detalhes.METADADO.DataEfetivacaoPortabilidade)
				.Field(CTC924Detalhes.METADADO.SituacaoEfetivacaoPortabilidade)
				.Field(CTC924Detalhes.METADADO.ValorRCO)
				.Table(CTC924Detalhes.METADADO.tabelaNAME);

			query.Where
				.Add(CTC924Detalhes.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				CTC924Detalhes result = base.MapReaderToEntity<CTC924Detalhes>(cmd);
				return result;
			}
		}
		#endregion

		#region Excluir por FKs
		public void ExcluirPor_CTC924(int? CTC924)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(CTC924Detalhes.METADADO.tabelaNAME);
			delete.Where
				.Add(CTC924Detalhes.METADADO.CTC924, Filter.Equal, CTC924);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, delete.ToString());
				delete.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		public void ExcluirPor_SituacaoPortabilidadeCTC(string SituacaoPortabilidadeCTC)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(CTC924Detalhes.METADADO.tabelaNAME);
			delete.Where
				.Add(CTC924Detalhes.METADADO.SituacaoPortabilidadeCTC, Filter.Equal, SituacaoPortabilidadeCTC);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, delete.ToString());
				delete.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		public void ExcluirPor_TipoContrato(string TipoContrato)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(CTC924Detalhes.METADADO.tabelaNAME);
			delete.Where
				.Add(CTC924Detalhes.METADADO.TipoContrato, Filter.Equal, TipoContrato);

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
				delete.Table(CTC924Detalhes.METADADO.tabelaNAME);
			delete.Where
				.Add(CTC924Detalhes.METADADO.EnteConsignante, Filter.Equal, EnteConsignante);

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
				delete.Table(CTC924Detalhes.METADADO.tabelaNAME);
			delete.Where
				.Add(CTC924Detalhes.METADADO.MotivoDecursoPrazo, Filter.Equal, MotivoDecursoPrazo);

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
				delete.Table(CTC924Detalhes.METADADO.tabelaNAME);
			delete.Where
				.Add(CTC924Detalhes.METADADO.MotivoCancelamento, Filter.Equal, MotivoCancelamento);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, delete.ToString());
				delete.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		public void ExcluirPor_MotivoRetencaoContrato(string MotivoRetencaoContrato)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(CTC924Detalhes.METADADO.tabelaNAME);
			delete.Where
				.Add(CTC924Detalhes.METADADO.MotivoRetencaoContrato, Filter.Equal, MotivoRetencaoContrato);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, delete.ToString());
				delete.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		public void ExcluirPor_SituacaoLiquidacao(string SituacaoLiquidacao)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(CTC924Detalhes.METADADO.tabelaNAME);
			delete.Where
				.Add(CTC924Detalhes.METADADO.SituacaoLiquidacao, Filter.Equal, SituacaoLiquidacao);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, delete.ToString());
				delete.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		public void ExcluirPor_SituacaoDevolucaoLiquidacao(string SituacaoDevolucaoLiquidacao)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(CTC924Detalhes.METADADO.tabelaNAME);
			delete.Where
				.Add(CTC924Detalhes.METADADO.SituacaoDevolucaoLiquidacao, Filter.Equal, SituacaoDevolucaoLiquidacao);

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
				delete.Table(CTC924Detalhes.METADADO.tabelaNAME);
			delete.Where
				.Add(CTC924Detalhes.METADADO.MotivoDevolucaoLiquidacao, Filter.Equal, MotivoDevolucaoLiquidacao);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, delete.ToString());
				delete.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		public void ExcluirPor_SituacaoEfetivacaoPortabilidade(string SituacaoEfetivacaoPortabilidade)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(CTC924Detalhes.METADADO.tabelaNAME);
			delete.Where
				.Add(CTC924Detalhes.METADADO.SituacaoEfetivacaoPortabilidade, Filter.Equal, SituacaoEfetivacaoPortabilidade);

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
				delete.Table(CTC924Detalhes.METADADO.tabelaNAME);
			delete.Where
				.Add(CTC924Detalhes.METADADO.Id, Filter.Equal, Id);

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
