
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
	public partial class JobFilaJobTentativaData : DataBase
	{
		
		#region Listar
		public List<JobFilaJobTentativa> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(JobFilaJobTentativa.METADADO.Id)
				.Field(JobFilaJobTentativa.METADADO.IdFilaJob)
				.Field(JobFilaJobTentativa.METADADO.IdJobTentativa)
				.Table(JobFilaJobTentativa.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				List<JobFilaJobTentativa> result = base.MapReaderToEntitySet<JobFilaJobTentativa>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(JobFilaJobTentativa obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(JobFilaJobTentativa.METADADO.IdFilaJob, obj.IdFilaJob)
				.FieldValue(JobFilaJobTentativa.METADADO.IdJobTentativa, obj.IdJobTentativa)
				.Table(JobFilaJobTentativa.METADADO.tabelaNAME);

			update.Where
				.Add(JobFilaJobTentativa.METADADO.Id, Filter.Equal, obj.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, update.ToString());
				update.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

		#region Inserir
		public void Incluir(JobFilaJobTentativa obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(JobFilaJobTentativa.METADADO.tabelaNAME)
				.FieldValue(JobFilaJobTentativa.METADADO.IdFilaJob, obj.IdFilaJob)
				.FieldValue(JobFilaJobTentativa.METADADO.IdJobTentativa, obj.IdJobTentativa)
				.SetIdentityField(JobFilaJobTentativa.METADADO.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, insert.ToString());
				insert.SetParameters(cmd);

				obj.Id = base.ExecuteScalar<long?>(cmd);
			}
		}
		#endregion

		#region Obtem
		public JobFilaJobTentativa Obtem(long? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(JobFilaJobTentativa.METADADO.Id)
				.Field(JobFilaJobTentativa.METADADO.IdFilaJob)
				.Field(JobFilaJobTentativa.METADADO.IdJobTentativa)
				.Table(JobFilaJobTentativa.METADADO.tabelaNAME);

			query.Where
				.Add(JobFilaJobTentativa.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				JobFilaJobTentativa result = base.MapReaderToEntity<JobFilaJobTentativa>(cmd);
				return result;
			}
		}
		#endregion

		#region Excluir por FKs
		public void ExcluirPor_IdFilaJob(long? IdFilaJob)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(JobFilaJobTentativa.METADADO.tabelaNAME);
			delete.Where
				.Add(JobFilaJobTentativa.METADADO.IdFilaJob, Filter.Equal, IdFilaJob);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, delete.ToString());
				delete.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		public void ExcluirPor_IdJobTentativa(long? IdJobTentativa)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(JobFilaJobTentativa.METADADO.tabelaNAME);
			delete.Where
				.Add(JobFilaJobTentativa.METADADO.IdJobTentativa, Filter.Equal, IdJobTentativa);

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
				delete.Table(JobFilaJobTentativa.METADADO.tabelaNAME);
			delete.Where
				.Add(JobFilaJobTentativa.METADADO.Id, Filter.Equal, Id);

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
