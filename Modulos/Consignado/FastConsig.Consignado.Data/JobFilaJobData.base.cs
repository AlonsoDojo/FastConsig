
#region Usings
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Framework;
using Framework.Data;
using FastConsig.Consignado.Entity;
#endregion

namespace FastConsig.Consignado.Data
{
	public partial class JobFilaJobData : DataBase
	{
		
		#region Listar
		public List<JobFilaJob> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(JobFilaJob.METADADO.Id)
				.Field(JobFilaJob.METADADO.IdFila)
				.Field(JobFilaJob.METADADO.IdJob)
				.Field(JobFilaJob.METADADO.IdJobTentativa)
				.Field(JobFilaJob.METADADO.Status)
				.Field(JobFilaJob.METADADO.Content)
				.Field(JobFilaJob.METADADO.Predecessor)
				.Table(JobFilaJob.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				List<JobFilaJob> result = base.MapReaderToEntitySet<JobFilaJob>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(JobFilaJob obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(JobFilaJob.METADADO.IdFila, obj.IdFila)
				.FieldValue(JobFilaJob.METADADO.IdJob, obj.IdJob)
				.FieldValue(JobFilaJob.METADADO.IdJobTentativa, obj.IdJobTentativa)
				.FieldValue(JobFilaJob.METADADO.Status, obj.Status)
				.FieldValue(JobFilaJob.METADADO.Content, obj.Content)
				.FieldValue(JobFilaJob.METADADO.Predecessor, obj.Predecessor)
				.Table(JobFilaJob.METADADO.tabelaNAME);

			update.Where
				.Add(JobFilaJob.METADADO.Id, Filter.Equal, obj.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, update.ToString());
				update.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

		#region Inserir
		public void Incluir(JobFilaJob obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(JobFilaJob.METADADO.tabelaNAME)
				.FieldValue(JobFilaJob.METADADO.IdFila, obj.IdFila)
				.FieldValue(JobFilaJob.METADADO.IdJob, obj.IdJob)
				.FieldValue(JobFilaJob.METADADO.IdJobTentativa, obj.IdJobTentativa)
				.FieldValue(JobFilaJob.METADADO.Status, obj.Status)
				.FieldValue(JobFilaJob.METADADO.Content, obj.Content)
				.FieldValue(JobFilaJob.METADADO.Predecessor, obj.Predecessor)
				.SetIdentityField(JobFilaJob.METADADO.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, insert.ToString());
				insert.SetParameters(cmd);

				obj.Id = base.ExecuteScalar<long?>(cmd);
			}
		}
		#endregion

		#region Obtem
		public JobFilaJob Obtem(long? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(JobFilaJob.METADADO.Id)
				.Field(JobFilaJob.METADADO.IdFila)
				.Field(JobFilaJob.METADADO.IdJob)
				.Field(JobFilaJob.METADADO.IdJobTentativa)
				.Field(JobFilaJob.METADADO.Status)
				.Field(JobFilaJob.METADADO.Content)
				.Field(JobFilaJob.METADADO.Predecessor)
				.Table(JobFilaJob.METADADO.tabelaNAME);

			query.Where
				.Add(JobFilaJob.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				JobFilaJob result = base.MapReaderToEntity<JobFilaJob>(cmd);
				return result;
			}
		}
		#endregion

		#region Excluir por FKs
		public void ExcluirPor_IdFila(long? IdFila)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(JobFilaJob.METADADO.tabelaNAME);
			delete.Where
				.Add(JobFilaJob.METADADO.IdFila, Filter.Equal, IdFila);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, delete.ToString());
				delete.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		public void ExcluirPor_IdJob(int? IdJob)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(JobFilaJob.METADADO.tabelaNAME);
			delete.Where
				.Add(JobFilaJob.METADADO.IdJob, Filter.Equal, IdJob);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, delete.ToString());
				delete.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

		#region Excluir por PK
		public void Excluir(long? Id)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(JobFilaJob.METADADO.tabelaNAME);
			delete.Where
				.Add(JobFilaJob.METADADO.Id, Filter.Equal, Id);

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
