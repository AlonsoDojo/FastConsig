
#region Usings
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Framework;
using Framework.Data;
using FastConsig.Scheduler.Entity;
#endregion

namespace FastConsig.Scheduler.Data
{
	public partial class TipoTarefaData : DataBase
	{
		
		#region Listar
		public List<TipoTarefa> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(TipoTarefa.METADADO.Id)
				.Field(TipoTarefa.METADADO.Descricao)
				.Table(TipoTarefa.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				List<TipoTarefa> result = base.MapReaderToEntitySet<TipoTarefa>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(TipoTarefa obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(TipoTarefa.METADADO.Descricao, obj.Descricao)
				.Table(TipoTarefa.METADADO.tabelaNAME);

			update.Where
				.Add(TipoTarefa.METADADO.Id, Filter.Equal, obj.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, update.ToString());
				update.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

		#region Inserir
		public void Incluir(TipoTarefa obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(TipoTarefa.METADADO.tabelaNAME)
				.FieldValue(TipoTarefa.METADADO.Descricao, obj.Descricao)
				.SetIdentityField(TipoTarefa.METADADO.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, insert.ToString());
				insert.SetParameters(cmd);

				obj.Id = base.ExecuteScalar<int?>(cmd);
			}
		}
		#endregion

		#region Obtem
		public TipoTarefa Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(TipoTarefa.METADADO.Id)
				.Field(TipoTarefa.METADADO.Descricao)
				.Table(TipoTarefa.METADADO.tabelaNAME);

			query.Where
				.Add(TipoTarefa.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				TipoTarefa result = base.MapReaderToEntity<TipoTarefa>(cmd);
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
				delete.Table(TipoTarefa.METADADO.tabelaNAME);
			delete.Where
				.Add(TipoTarefa.METADADO.Id, Filter.Equal, Id);

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
