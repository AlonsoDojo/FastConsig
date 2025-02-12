
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
	public partial class CTCOrigemRecursosData : DataBase
	{
		
		#region Listar
		public List<CTCOrigemRecursos> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CTCOrigemRecursos.METADADO.Id)
				.Field(CTCOrigemRecursos.METADADO.Codigo)
				.Field(CTCOrigemRecursos.METADADO.Descricao)
				.Table(CTCOrigemRecursos.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				List<CTCOrigemRecursos> result = base.MapReaderToEntitySet<CTCOrigemRecursos>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(CTCOrigemRecursos obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(CTCOrigemRecursos.METADADO.Codigo, obj.Codigo)
				.FieldValue(CTCOrigemRecursos.METADADO.Descricao, obj.Descricao)
				.Table(CTCOrigemRecursos.METADADO.tabelaNAME);

			update.Where
				.Add(CTCOrigemRecursos.METADADO.Id, Filter.Equal, obj.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, update.ToString());
				update.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

		#region Inserir
		public void Incluir(CTCOrigemRecursos obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(CTCOrigemRecursos.METADADO.tabelaNAME)
				.FieldValue(CTCOrigemRecursos.METADADO.Codigo, obj.Codigo)
				.FieldValue(CTCOrigemRecursos.METADADO.Descricao, obj.Descricao)
				.SetIdentityField(CTCOrigemRecursos.METADADO.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, insert.ToString());
				insert.SetParameters(cmd);

				obj.Id = base.ExecuteScalar<int?>(cmd);
			}
		}
		#endregion

		#region Obtem
		public CTCOrigemRecursos Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CTCOrigemRecursos.METADADO.Id)
				.Field(CTCOrigemRecursos.METADADO.Codigo)
				.Field(CTCOrigemRecursos.METADADO.Descricao)
				.Table(CTCOrigemRecursos.METADADO.tabelaNAME);

			query.Where
				.Add(CTCOrigemRecursos.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				CTCOrigemRecursos result = base.MapReaderToEntity<CTCOrigemRecursos>(cmd);
				return result;
			}
		}
		#endregion

		#region Excluir por FKs
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(CTCOrigemRecursos.METADADO.tabelaNAME);
			delete.Where
				.Add(CTCOrigemRecursos.METADADO.Id, Filter.Equal, Id);

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
