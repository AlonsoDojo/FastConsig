
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
	public partial class OcorrenciaProdutoFaseData : DataBase
	{
		
		#region Listar
		public List<OcorrenciaProdutoFase> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(OcorrenciaProdutoFase.METADADO.Id)
				.Field(OcorrenciaProdutoFase.METADADO.Ocorrencia)
				.Field(OcorrenciaProdutoFase.METADADO.Produto)
				.Field(OcorrenciaProdutoFase.METADADO.Fase)
				.Field(OcorrenciaProdutoFase.METADADO.Severidade)
				.Field(OcorrenciaProdutoFase.METADADO.FaseDestino)
				.Field(OcorrenciaProdutoFase.METADADO.Validacoes)
				.Table(OcorrenciaProdutoFase.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				cmd.CommandTimeout = 600;
				query.SetParameters(cmd);

				List<OcorrenciaProdutoFase> result = base.MapReaderToEntitySet<OcorrenciaProdutoFase>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(OcorrenciaProdutoFase obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(OcorrenciaProdutoFase.METADADO.Ocorrencia, obj.Ocorrencia)
				.FieldValue(OcorrenciaProdutoFase.METADADO.Produto, obj.Produto)
				.FieldValue(OcorrenciaProdutoFase.METADADO.Fase, obj.Fase)
				.FieldValue(OcorrenciaProdutoFase.METADADO.Severidade, obj.Severidade)
				.FieldValue(OcorrenciaProdutoFase.METADADO.FaseDestino, obj.FaseDestino)
				.FieldValue(OcorrenciaProdutoFase.METADADO.Validacoes, obj.Validacoes)
				.Table(OcorrenciaProdutoFase.METADADO.tabelaNAME);

			update.Where
				.Add(OcorrenciaProdutoFase.METADADO.Id, Filter.Equal, obj.Id);

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
		public void Incluir(OcorrenciaProdutoFase obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(OcorrenciaProdutoFase.METADADO.tabelaNAME)
				.FieldValue(OcorrenciaProdutoFase.METADADO.Ocorrencia, obj.Ocorrencia)
				.FieldValue(OcorrenciaProdutoFase.METADADO.Produto, obj.Produto)
				.FieldValue(OcorrenciaProdutoFase.METADADO.Fase, obj.Fase)
				.FieldValue(OcorrenciaProdutoFase.METADADO.Severidade, obj.Severidade)
				.FieldValue(OcorrenciaProdutoFase.METADADO.FaseDestino, obj.FaseDestino)
				.FieldValue(OcorrenciaProdutoFase.METADADO.Validacoes, obj.Validacoes)
				.SetIdentityField(OcorrenciaProdutoFase.METADADO.Id);

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
		public OcorrenciaProdutoFase Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(OcorrenciaProdutoFase.METADADO.Id)
				.Field(OcorrenciaProdutoFase.METADADO.Ocorrencia)
				.Field(OcorrenciaProdutoFase.METADADO.Produto)
				.Field(OcorrenciaProdutoFase.METADADO.Fase)
				.Field(OcorrenciaProdutoFase.METADADO.Severidade)
				.Field(OcorrenciaProdutoFase.METADADO.FaseDestino)
				.Field(OcorrenciaProdutoFase.METADADO.Validacoes)
				.Table(OcorrenciaProdutoFase.METADADO.tabelaNAME);

			query.Where
				.Add(OcorrenciaProdutoFase.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				cmd.CommandTimeout = 600;
				query.SetParameters(cmd);

				OcorrenciaProdutoFase result = base.MapReaderToEntity<OcorrenciaProdutoFase>(cmd);
				return result;
			}
		}
		#endregion

		#region Excluir por FKs
		public void ExcluirPor_Ocorrencia(int? Ocorrencia)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(OcorrenciaProdutoFase.METADADO.tabelaNAME);
			delete.Where
				.Add(OcorrenciaProdutoFase.METADADO.Ocorrencia, Filter.Equal, Ocorrencia);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, delete.ToString());
				cmd.CommandTimeout = 600;
				delete.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		public void ExcluirPor_Produto(int? Produto)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(OcorrenciaProdutoFase.METADADO.tabelaNAME);
			delete.Where
				.Add(OcorrenciaProdutoFase.METADADO.Produto, Filter.Equal, Produto);

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
				delete.Table(OcorrenciaProdutoFase.METADADO.tabelaNAME);
			delete.Where
				.Add(OcorrenciaProdutoFase.METADADO.Fase, Filter.Equal, Fase);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, delete.ToString());
				cmd.CommandTimeout = 600;
				delete.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		public void ExcluirPor_FaseDestino(int? FaseDestino)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(OcorrenciaProdutoFase.METADADO.tabelaNAME);
			delete.Where
				.Add(OcorrenciaProdutoFase.METADADO.FaseDestino, Filter.Equal, FaseDestino);

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
				delete.Table(OcorrenciaProdutoFase.METADADO.tabelaNAME);
			delete.Where
				.Add(OcorrenciaProdutoFase.METADADO.Id, Filter.Equal, Id);

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
