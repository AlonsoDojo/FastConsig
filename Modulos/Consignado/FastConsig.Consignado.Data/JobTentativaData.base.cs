
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
	public partial class JobTentativaData : DataBase
	{
		
		#region Listar
		public List<JobTentativa> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(JobTentativa.METADADO.Id)
				.Field(JobTentativa.METADADO.IdJob)
				.Field(JobTentativa.METADADO.IdJobStatus)
				.Field(JobTentativa.METADADO.DtProcessamento)
				.Field(JobTentativa.METADADO.Retorno)
				.Table(JobTentativa.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				List<JobTentativa> result = base.MapReaderToEntitySet<JobTentativa>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(JobTentativa obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(JobTentativa.METADADO.IdJob, obj.IdJob)
				.FieldValue(JobTentativa.METADADO.IdJobStatus, obj.IdJobStatus)
				.FieldValue(JobTentativa.METADADO.DtProcessamento, obj.DtProcessamento)
				.FieldValue(JobTentativa.METADADO.Retorno, obj.Retorno)
				.Table(JobTentativa.METADADO.tabelaNAME);

			update.Where
				.Add(JobTentativa.METADADO.Id, Filter.Equal, obj.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, update.ToString());
				update.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

		#region Inserir
		public void Incluir(JobTentativa obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(JobTentativa.METADADO.tabelaNAME)
				.FieldValue(JobTentativa.METADADO.IdJob, obj.IdJob)
				.FieldValue(JobTentativa.METADADO.IdJobStatus, obj.IdJobStatus)
				.FieldValue(JobTentativa.METADADO.DtProcessamento, obj.DtProcessamento)
				.FieldValue(JobTentativa.METADADO.Retorno, obj.Retorno)
				.SetIdentityField(JobTentativa.METADADO.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, insert.ToString());
				insert.SetParameters(cmd);

				obj.Id = base.ExecuteScalar<long?>(cmd);
			}
		}
		#endregion

		#region Obtem
		public JobTentativa Obtem(long? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(JobTentativa.METADADO.Id)
				.Field(JobTentativa.METADADO.IdJob)
				.Field(JobTentativa.METADADO.IdJobStatus)
				.Field(JobTentativa.METADADO.DtProcessamento)
				.Field(JobTentativa.METADADO.Retorno)
				.Table(JobTentativa.METADADO.tabelaNAME);

			query.Where
				.Add(JobTentativa.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				JobTentativa result = base.MapReaderToEntity<JobTentativa>(cmd);
				return result;
			}
		}
		#endregion

		#region Excluir por FKs
		#endregion

		#region Excluir por PK
		public void Excluir(long? Id)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(JobTentativa.METADADO.tabelaNAME);
			delete.Where
				.Add(JobTentativa.METADADO.Id, Filter.Equal, Id);

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
