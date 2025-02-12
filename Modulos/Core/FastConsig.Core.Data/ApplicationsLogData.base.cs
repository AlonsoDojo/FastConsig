
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
	public partial class ApplicationsLogData : DataBase
	{
		
		#region Listar
		public List<ApplicationsLog> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(ApplicationsLog.METADADO.Id)
				.Field(ApplicationsLog.METADADO.Application)
				.Field(ApplicationsLog.METADADO.ApplicationGuid)
				.Field(ApplicationsLog.METADADO.Environment)
				.Field(ApplicationsLog.METADADO.User)
				.Field(ApplicationsLog.METADADO.HostName)
				.Field(ApplicationsLog.METADADO.MethodName)
				.Field(ApplicationsLog.METADADO.FilePath)
				.Field(ApplicationsLog.METADADO.LineNumber)
				.Field(ApplicationsLog.METADADO.Parameters)
				.Field(ApplicationsLog.METADADO.Thread)
				.Field(ApplicationsLog.METADADO.Level)
				.Field(ApplicationsLog.METADADO.Logger)
				.Field(ApplicationsLog.METADADO.Context)
				.Field(ApplicationsLog.METADADO.Date)
				.Field(ApplicationsLog.METADADO.Message)
				.Field(ApplicationsLog.METADADO.Exception)
				.Field(ApplicationsLog.METADADO.InnerException)
				.Table(ApplicationsLog.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				List<ApplicationsLog> result = base.MapReaderToEntitySet<ApplicationsLog>(cmd);
				return result;
			}
		}
		#endregion

		#region Inserir
		public void Incluir(ApplicationsLog obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(ApplicationsLog.METADADO.tabelaNAME)
				.FieldValue(ApplicationsLog.METADADO.Id, obj.Id)
				.FieldValue(ApplicationsLog.METADADO.Application, obj.Application)
				.FieldValue(ApplicationsLog.METADADO.ApplicationGuid, obj.ApplicationGuid)
				.FieldValue(ApplicationsLog.METADADO.Environment, obj.Environment)
				.FieldValue(ApplicationsLog.METADADO.User, obj.User)
				.FieldValue(ApplicationsLog.METADADO.HostName, obj.HostName)
				.FieldValue(ApplicationsLog.METADADO.MethodName, obj.MethodName)
				.FieldValue(ApplicationsLog.METADADO.FilePath, obj.FilePath)
				.FieldValue(ApplicationsLog.METADADO.LineNumber, obj.LineNumber)
				.FieldValue(ApplicationsLog.METADADO.Parameters, obj.Parameters)
				.FieldValue(ApplicationsLog.METADADO.Thread, obj.Thread)
				.FieldValue(ApplicationsLog.METADADO.Level, obj.Level)
				.FieldValue(ApplicationsLog.METADADO.Logger, obj.Logger)
				.FieldValue(ApplicationsLog.METADADO.Context, obj.Context)
				.FieldValue(ApplicationsLog.METADADO.Date, obj.Date)
				.FieldValue(ApplicationsLog.METADADO.Message, obj.Message)
				.FieldValue(ApplicationsLog.METADADO.Exception, obj.Exception)
				.FieldValue(ApplicationsLog.METADADO.InnerException, obj.InnerException);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, insert.ToString());
				insert.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

		#region Obtem
		#endregion

		#region Excluir por FKs
		#endregion

		#region Excluir por PK
		#endregion

	}
}
