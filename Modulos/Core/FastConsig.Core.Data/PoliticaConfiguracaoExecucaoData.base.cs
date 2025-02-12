
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
	public partial class PoliticaConfiguracaoExecucaoData : DataBase
	{
		
		#region Listar
		public List<PoliticaConfiguracaoExecucao> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(PoliticaConfiguracaoExecucao.METADADO.Id)
				.Field(PoliticaConfiguracaoExecucao.METADADO.Produto)
				.Field(PoliticaConfiguracaoExecucao.METADADO.TipoPessoa)
				.Field(PoliticaConfiguracaoExecucao.METADADO.Fase)
				.Field(PoliticaConfiguracaoExecucao.METADADO.Politica)
				.Field(PoliticaConfiguracaoExecucao.METADADO.Peso)
				.Field(PoliticaConfiguracaoExecucao.METADADO.Entrada)
				.Field(PoliticaConfiguracaoExecucao.METADADO.Saida)
				.Table(PoliticaConfiguracaoExecucao.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				cmd.CommandTimeout = 600;
				query.SetParameters(cmd);

				List<PoliticaConfiguracaoExecucao> result = base.MapReaderToEntitySet<PoliticaConfiguracaoExecucao>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(PoliticaConfiguracaoExecucao obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(PoliticaConfiguracaoExecucao.METADADO.Produto, obj.Produto)
				.FieldValue(PoliticaConfiguracaoExecucao.METADADO.TipoPessoa, obj.TipoPessoa)
				.FieldValue(PoliticaConfiguracaoExecucao.METADADO.Fase, obj.Fase)
				.FieldValue(PoliticaConfiguracaoExecucao.METADADO.Politica, obj.Politica)
				.FieldValue(PoliticaConfiguracaoExecucao.METADADO.Peso, obj.Peso)
				.FieldValue(PoliticaConfiguracaoExecucao.METADADO.Entrada, obj.Entrada)
				.FieldValue(PoliticaConfiguracaoExecucao.METADADO.Saida, obj.Saida)
				.Table(PoliticaConfiguracaoExecucao.METADADO.tabelaNAME);

			update.Where
				.Add(PoliticaConfiguracaoExecucao.METADADO.Id, Filter.Equal, obj.Id);

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
		public void Incluir(PoliticaConfiguracaoExecucao obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(PoliticaConfiguracaoExecucao.METADADO.tabelaNAME)
				.FieldValue(PoliticaConfiguracaoExecucao.METADADO.Produto, obj.Produto)
				.FieldValue(PoliticaConfiguracaoExecucao.METADADO.TipoPessoa, obj.TipoPessoa)
				.FieldValue(PoliticaConfiguracaoExecucao.METADADO.Fase, obj.Fase)
				.FieldValue(PoliticaConfiguracaoExecucao.METADADO.Politica, obj.Politica)
				.FieldValue(PoliticaConfiguracaoExecucao.METADADO.Peso, obj.Peso)
				.FieldValue(PoliticaConfiguracaoExecucao.METADADO.Entrada, obj.Entrada)
				.FieldValue(PoliticaConfiguracaoExecucao.METADADO.Saida, obj.Saida)
				.SetIdentityField(PoliticaConfiguracaoExecucao.METADADO.Id);

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
		public PoliticaConfiguracaoExecucao Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(PoliticaConfiguracaoExecucao.METADADO.Id)
				.Field(PoliticaConfiguracaoExecucao.METADADO.Produto)
				.Field(PoliticaConfiguracaoExecucao.METADADO.TipoPessoa)
				.Field(PoliticaConfiguracaoExecucao.METADADO.Fase)
				.Field(PoliticaConfiguracaoExecucao.METADADO.Politica)
				.Field(PoliticaConfiguracaoExecucao.METADADO.Peso)
				.Field(PoliticaConfiguracaoExecucao.METADADO.Entrada)
				.Field(PoliticaConfiguracaoExecucao.METADADO.Saida)
				.Table(PoliticaConfiguracaoExecucao.METADADO.tabelaNAME);

			query.Where
				.Add(PoliticaConfiguracaoExecucao.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				cmd.CommandTimeout = 600;
				query.SetParameters(cmd);

				PoliticaConfiguracaoExecucao result = base.MapReaderToEntity<PoliticaConfiguracaoExecucao>(cmd);
				return result;
			}
		}
		#endregion

		#region Excluir por FKs
		public void ExcluirPor_Produto(int? Produto)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(PoliticaConfiguracaoExecucao.METADADO.tabelaNAME);
			delete.Where
				.Add(PoliticaConfiguracaoExecucao.METADADO.Produto, Filter.Equal, Produto);

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
				delete.Table(PoliticaConfiguracaoExecucao.METADADO.tabelaNAME);
			delete.Where
				.Add(PoliticaConfiguracaoExecucao.METADADO.TipoPessoa, Filter.Equal, TipoPessoa);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, delete.ToString());
				cmd.CommandTimeout = 600;
				delete.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		public void ExcluirPor_Fase(int? Fase)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(PoliticaConfiguracaoExecucao.METADADO.tabelaNAME);
			delete.Where
				.Add(PoliticaConfiguracaoExecucao.METADADO.Fase, Filter.Equal, Fase);

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
				delete.Table(PoliticaConfiguracaoExecucao.METADADO.tabelaNAME);
			delete.Where
				.Add(PoliticaConfiguracaoExecucao.METADADO.Politica, Filter.Equal, Politica);

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
				delete.Table(PoliticaConfiguracaoExecucao.METADADO.tabelaNAME);
			delete.Where
				.Add(PoliticaConfiguracaoExecucao.METADADO.Id, Filter.Equal, Id);

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
