
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
	public partial class TipoAgendaData : DataBase
	{
		
		#region Listar
		public List<TipoAgenda> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(TipoAgenda.METADADO.Id)
				.Field(TipoAgenda.METADADO.Descricao)
				.Table(TipoAgenda.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				List<TipoAgenda> result = base.MapReaderToEntitySet<TipoAgenda>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(TipoAgenda obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(TipoAgenda.METADADO.Descricao, obj.Descricao)
				.Table(TipoAgenda.METADADO.tabelaNAME);

			update.Where
				.Add(TipoAgenda.METADADO.Id, Filter.Equal, obj.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, update.ToString());
				update.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

		#region Inserir
		public void Incluir(TipoAgenda obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(TipoAgenda.METADADO.tabelaNAME)
				.FieldValue(TipoAgenda.METADADO.Descricao, obj.Descricao)
				.SetIdentityField(TipoAgenda.METADADO.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, insert.ToString());
				insert.SetParameters(cmd);

				obj.Id = base.ExecuteScalar<int?>(cmd);
			}
		}
		#endregion

		#region Obtem
		public TipoAgenda Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(TipoAgenda.METADADO.Id)
				.Field(TipoAgenda.METADADO.Descricao)
				.Table(TipoAgenda.METADADO.tabelaNAME);

			query.Where
				.Add(TipoAgenda.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				TipoAgenda result = base.MapReaderToEntity<TipoAgenda>(cmd);
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
				delete.Table(TipoAgenda.METADADO.tabelaNAME);
			delete.Where
				.Add(TipoAgenda.METADADO.Id, Filter.Equal, Id);

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
