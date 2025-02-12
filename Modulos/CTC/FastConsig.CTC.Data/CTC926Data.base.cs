
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
	public partial class CTC926Data : DataBase
	{
		
		#region Listar
		public List<CTC926> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CTC926.METADADO.Id)
				.Field(CTC926.METADADO.Arquivo)
				.Field(CTC926.METADADO.DataReferencia)
				.Field(CTC926.METADADO.DataInicio)
				.Field(CTC926.METADADO.DataFim)
				.Table(CTC926.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				List<CTC926> result = base.MapReaderToEntitySet<CTC926>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(CTC926 obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(CTC926.METADADO.Arquivo, obj.Arquivo)
				.FieldValue(CTC926.METADADO.DataReferencia, obj.DataReferencia)
				.FieldValue(CTC926.METADADO.DataInicio, obj.DataInicio)
				.FieldValue(CTC926.METADADO.DataFim, obj.DataFim)
				.Table(CTC926.METADADO.tabelaNAME);

			update.Where
				.Add(CTC926.METADADO.Id, Filter.Equal, obj.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, update.ToString());
				update.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

		#region Inserir
		public void Incluir(CTC926 obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(CTC926.METADADO.tabelaNAME)
				.FieldValue(CTC926.METADADO.Arquivo, obj.Arquivo)
				.FieldValue(CTC926.METADADO.DataReferencia, obj.DataReferencia)
				.FieldValue(CTC926.METADADO.DataInicio, obj.DataInicio)
				.FieldValue(CTC926.METADADO.DataFim, obj.DataFim)
				.SetIdentityField(CTC926.METADADO.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, insert.ToString());
				insert.SetParameters(cmd);

				obj.Id = base.ExecuteScalar<int?>(cmd);
			}
		}
		#endregion

		#region Obtem
		public CTC926 Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CTC926.METADADO.Id)
				.Field(CTC926.METADADO.Arquivo)
				.Field(CTC926.METADADO.DataReferencia)
				.Field(CTC926.METADADO.DataInicio)
				.Field(CTC926.METADADO.DataFim)
				.Table(CTC926.METADADO.tabelaNAME);

			query.Where
				.Add(CTC926.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				CTC926 result = base.MapReaderToEntity<CTC926>(cmd);
				return result;
			}
		}
		#endregion

		#region Excluir por FKs
		public void ExcluirPor_Arquivo(int? Arquivo)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(CTC926.METADADO.tabelaNAME);
			delete.Where
				.Add(CTC926.METADADO.Arquivo, Filter.Equal, Arquivo);

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
				delete.Table(CTC926.METADADO.tabelaNAME);
			delete.Where
				.Add(CTC926.METADADO.Id, Filter.Equal, Id);

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
