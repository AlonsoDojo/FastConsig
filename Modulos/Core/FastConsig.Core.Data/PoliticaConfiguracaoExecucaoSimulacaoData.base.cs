
#region Usings
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Framework;
using Framework.Data;
using FastConsig.Core.Entity;
#endregion

namespace FastConsig.Core.Data
{
	public partial class PoliticaConfiguracaoExecucaoSimulacaoData : DataBase
	{
		
		#region Listar
		public List<PoliticaConfiguracaoExecucaoSimulacao> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(PoliticaConfiguracaoExecucaoSimulacao.METADADO.Id)
				.Field(PoliticaConfiguracaoExecucaoSimulacao.METADADO.Produto)
				.Field(PoliticaConfiguracaoExecucaoSimulacao.METADADO.TipoPessoa)
				.Field(PoliticaConfiguracaoExecucaoSimulacao.METADADO.Politica)
				.Field(PoliticaConfiguracaoExecucaoSimulacao.METADADO.Peso)
				.Field(PoliticaConfiguracaoExecucaoSimulacao.METADADO.Entrada)
				.Field(PoliticaConfiguracaoExecucaoSimulacao.METADADO.Saida)
				.Table(PoliticaConfiguracaoExecucaoSimulacao.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				cmd.CommandTimeout = 600;
				query.SetParameters(cmd);

				List<PoliticaConfiguracaoExecucaoSimulacao> result = base.MapReaderToEntitySet<PoliticaConfiguracaoExecucaoSimulacao>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(PoliticaConfiguracaoExecucaoSimulacao obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(PoliticaConfiguracaoExecucaoSimulacao.METADADO.Produto, obj.Produto)
				.FieldValue(PoliticaConfiguracaoExecucaoSimulacao.METADADO.TipoPessoa, obj.TipoPessoa)
				.FieldValue(PoliticaConfiguracaoExecucaoSimulacao.METADADO.Politica, obj.Politica)
				.FieldValue(PoliticaConfiguracaoExecucaoSimulacao.METADADO.Peso, obj.Peso)
				.FieldValue(PoliticaConfiguracaoExecucaoSimulacao.METADADO.Entrada, obj.Entrada)
				.FieldValue(PoliticaConfiguracaoExecucaoSimulacao.METADADO.Saida, obj.Saida)
				.Table(PoliticaConfiguracaoExecucaoSimulacao.METADADO.tabelaNAME);

			update.Where
				.Add(PoliticaConfiguracaoExecucaoSimulacao.METADADO.Id, Filter.Equal, obj.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, update.ToString());
				cmd.CommandTimeout = 600;
				update.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

		#region Inserir
		public void Incluir(PoliticaConfiguracaoExecucaoSimulacao obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(PoliticaConfiguracaoExecucaoSimulacao.METADADO.tabelaNAME)
				.FieldValue(PoliticaConfiguracaoExecucaoSimulacao.METADADO.Produto, obj.Produto)
				.FieldValue(PoliticaConfiguracaoExecucaoSimulacao.METADADO.TipoPessoa, obj.TipoPessoa)
				.FieldValue(PoliticaConfiguracaoExecucaoSimulacao.METADADO.Politica, obj.Politica)
				.FieldValue(PoliticaConfiguracaoExecucaoSimulacao.METADADO.Peso, obj.Peso)
				.FieldValue(PoliticaConfiguracaoExecucaoSimulacao.METADADO.Entrada, obj.Entrada)
				.FieldValue(PoliticaConfiguracaoExecucaoSimulacao.METADADO.Saida, obj.Saida)
				.SetIdentityField(PoliticaConfiguracaoExecucaoSimulacao.METADADO.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, insert.ToString());
				cmd.CommandTimeout = 600;
				insert.SetParameters(cmd);

				obj.Id = base.ExecuteScalar<int?>(cmd);
			}
		}
		#endregion

		#region Obtem
		public PoliticaConfiguracaoExecucaoSimulacao Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(PoliticaConfiguracaoExecucaoSimulacao.METADADO.Id)
				.Field(PoliticaConfiguracaoExecucaoSimulacao.METADADO.Produto)
				.Field(PoliticaConfiguracaoExecucaoSimulacao.METADADO.TipoPessoa)
				.Field(PoliticaConfiguracaoExecucaoSimulacao.METADADO.Politica)
				.Field(PoliticaConfiguracaoExecucaoSimulacao.METADADO.Peso)
				.Field(PoliticaConfiguracaoExecucaoSimulacao.METADADO.Entrada)
				.Field(PoliticaConfiguracaoExecucaoSimulacao.METADADO.Saida)
				.Table(PoliticaConfiguracaoExecucaoSimulacao.METADADO.tabelaNAME);

			query.Where
				.Add(PoliticaConfiguracaoExecucaoSimulacao.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				cmd.CommandTimeout = 600;
				query.SetParameters(cmd);

				PoliticaConfiguracaoExecucaoSimulacao result = base.MapReaderToEntity<PoliticaConfiguracaoExecucaoSimulacao>(cmd);
				return result;
			}
		}
		#endregion

		#region Excluir por FKs
		public void ExcluirPor_Produto(int? Produto)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(PoliticaConfiguracaoExecucaoSimulacao.METADADO.tabelaNAME);
			delete.Where
				.Add(PoliticaConfiguracaoExecucaoSimulacao.METADADO.Produto, Filter.Equal, Produto);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, delete.ToString());
				cmd.CommandTimeout = 600;
				delete.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		public void ExcluirPor_TipoPessoa(int? TipoPessoa)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(PoliticaConfiguracaoExecucaoSimulacao.METADADO.tabelaNAME);
			delete.Where
				.Add(PoliticaConfiguracaoExecucaoSimulacao.METADADO.TipoPessoa, Filter.Equal, TipoPessoa);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, delete.ToString());
				cmd.CommandTimeout = 600;
				delete.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		public void ExcluirPor_Politica(int? Politica)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(PoliticaConfiguracaoExecucaoSimulacao.METADADO.tabelaNAME);
			delete.Where
				.Add(PoliticaConfiguracaoExecucaoSimulacao.METADADO.Politica, Filter.Equal, Politica);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, delete.ToString());
				cmd.CommandTimeout = 600;
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
				delete.Table(PoliticaConfiguracaoExecucaoSimulacao.METADADO.tabelaNAME);
			delete.Where
				.Add(PoliticaConfiguracaoExecucaoSimulacao.METADADO.Id, Filter.Equal, Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, delete.ToString());
				cmd.CommandTimeout = 600;
				delete.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

	}
}
