
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
	public partial class AuditTableData : DataBase
	{
		
		#region Listar
		public List<AuditTable> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(AuditTable.METADADO.ID)
				.Field(AuditTable.METADADO.KeyFieldID)
				.Field(AuditTable.METADADO.AuditActionTypeENUM)
				.Field(AuditTable.METADADO.DateTimeStamp)
				.Field(AuditTable.METADADO.DataModel)
				.Field(AuditTable.METADADO.Changes)
				.Field(AuditTable.METADADO.ValueBefore)
				.Field(AuditTable.METADADO.ValueAfter)
				.Field(AuditTable.METADADO.Usuario)
				.Table(AuditTable.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				cmd.CommandTimeout = 600;
				query.SetParameters(cmd);

				List<AuditTable> result = base.MapReaderToEntitySet<AuditTable>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(AuditTable obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(AuditTable.METADADO.KeyFieldID, obj.KeyFieldID)
				.FieldValue(AuditTable.METADADO.AuditActionTypeENUM, obj.AuditActionTypeENUM)
				.FieldValue(AuditTable.METADADO.DateTimeStamp, obj.DateTimeStamp)
				.FieldValue(AuditTable.METADADO.DataModel, obj.DataModel)
				.FieldValue(AuditTable.METADADO.Changes, obj.Changes)
				.FieldValue(AuditTable.METADADO.ValueBefore, obj.ValueBefore)
				.FieldValue(AuditTable.METADADO.ValueAfter, obj.ValueAfter)
				.FieldValue(AuditTable.METADADO.Usuario, obj.Usuario)
				.Table(AuditTable.METADADO.tabelaNAME);

			update.Where
				.Add(AuditTable.METADADO.ID, Filter.Equal, obj.ID);

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
		public void Incluir(AuditTable obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(AuditTable.METADADO.tabelaNAME)
				.FieldValue(AuditTable.METADADO.KeyFieldID, obj.KeyFieldID)
				.FieldValue(AuditTable.METADADO.AuditActionTypeENUM, obj.AuditActionTypeENUM)
				.FieldValue(AuditTable.METADADO.DateTimeStamp, obj.DateTimeStamp)
				.FieldValue(AuditTable.METADADO.DataModel, obj.DataModel)
				.FieldValue(AuditTable.METADADO.Changes, obj.Changes)
				.FieldValue(AuditTable.METADADO.ValueBefore, obj.ValueBefore)
				.FieldValue(AuditTable.METADADO.ValueAfter, obj.ValueAfter)
				.FieldValue(AuditTable.METADADO.Usuario, obj.Usuario)
				.SetIdentityField(AuditTable.METADADO.ID);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, insert.ToString());
				cmd.CommandTimeout = 600;
				insert.SetParameters(cmd);

				obj.ID = base.ExecuteScalar<int?>(cmd);
			}
		}
		#endregion

		#region Obtem
		public AuditTable Obtem(int? ID)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(AuditTable.METADADO.ID)
				.Field(AuditTable.METADADO.KeyFieldID)
				.Field(AuditTable.METADADO.AuditActionTypeENUM)
				.Field(AuditTable.METADADO.DateTimeStamp)
				.Field(AuditTable.METADADO.DataModel)
				.Field(AuditTable.METADADO.Changes)
				.Field(AuditTable.METADADO.ValueBefore)
				.Field(AuditTable.METADADO.ValueAfter)
				.Field(AuditTable.METADADO.Usuario)
				.Table(AuditTable.METADADO.tabelaNAME);

			query.Where
				.Add(AuditTable.METADADO.ID, Filter.Equal, ID);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				cmd.CommandTimeout = 600;
				query.SetParameters(cmd);

				AuditTable result = base.MapReaderToEntity<AuditTable>(cmd);
				return result;
			}
		}
		#endregion

		#region Excluir por FKs
		#endregion

		#region Excluir por PK
		public void Excluir(int? ID)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(AuditTable.METADADO.tabelaNAME);
			delete.Where
				.Add(AuditTable.METADADO.ID, Filter.Equal, ID);

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
