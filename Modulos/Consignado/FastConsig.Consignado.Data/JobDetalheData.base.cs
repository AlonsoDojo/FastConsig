
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
	public partial class JobDetalheData : DataBase
	{
		
		#region Listar
		public List<JobDetalhe> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(JobDetalhe.METADADO.IdJob)
				.Field(JobDetalhe.METADADO.Type)
				.Field(JobDetalhe.METADADO.ConnectionString)
				.Field(JobDetalhe.METADADO.Debug)
				.Field(JobDetalhe.METADADO.LoggingType)
				.Field(JobDetalhe.METADADO.LoggingLocation)
				.Field(JobDetalhe.METADADO.LoggingMaximumSize)
				.Table(JobDetalhe.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				List<JobDetalhe> result = base.MapReaderToEntitySet<JobDetalhe>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(JobDetalhe obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(JobDetalhe.METADADO.Type, obj.Type)
				.FieldValue(JobDetalhe.METADADO.ConnectionString, obj.ConnectionString)
				.FieldValue(JobDetalhe.METADADO.Debug, obj.Debug)
				.FieldValue(JobDetalhe.METADADO.LoggingType, obj.LoggingType)
				.FieldValue(JobDetalhe.METADADO.LoggingLocation, obj.LoggingLocation)
				.FieldValue(JobDetalhe.METADADO.LoggingMaximumSize, obj.LoggingMaximumSize)
				.Table(JobDetalhe.METADADO.tabelaNAME);

			update.Where
				.Add(JobDetalhe.METADADO.IdJob, Filter.Equal, obj.IdJob);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, update.ToString());
				update.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

		#region Inserir
		public void Incluir(JobDetalhe obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.FieldValue(JobDetalhe.METADADO.IdJob, obj.IdJob)
				.Table(JobDetalhe.METADADO.tabelaNAME)
				.FieldValue(JobDetalhe.METADADO.Type, obj.Type)
				.FieldValue(JobDetalhe.METADADO.ConnectionString, obj.ConnectionString)
				.FieldValue(JobDetalhe.METADADO.Debug, obj.Debug)
				.FieldValue(JobDetalhe.METADADO.LoggingType, obj.LoggingType)
				.FieldValue(JobDetalhe.METADADO.LoggingLocation, obj.LoggingLocation)
				.FieldValue(JobDetalhe.METADADO.LoggingMaximumSize, obj.LoggingMaximumSize);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, insert.ToString());
				insert.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

		#region Obtem
		public JobDetalhe Obtem(int? IdJob)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(JobDetalhe.METADADO.IdJob)
				.Field(JobDetalhe.METADADO.Type)
				.Field(JobDetalhe.METADADO.ConnectionString)
				.Field(JobDetalhe.METADADO.Debug)
				.Field(JobDetalhe.METADADO.LoggingType)
				.Field(JobDetalhe.METADADO.LoggingLocation)
				.Field(JobDetalhe.METADADO.LoggingMaximumSize)
				.Table(JobDetalhe.METADADO.tabelaNAME);

			query.Where
				.Add(JobDetalhe.METADADO.IdJob, Filter.Equal, IdJob);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				JobDetalhe result = base.MapReaderToEntity<JobDetalhe>(cmd);
				return result;
			}
		}
		#endregion

		#region Excluir por FKs
		public void ExcluirPor_IdJob(int? IdJob)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(JobDetalhe.METADADO.tabelaNAME);
			delete.Where
				.Add(JobDetalhe.METADADO.IdJob, Filter.Equal, IdJob);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, delete.ToString());
				delete.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

		#region Excluir por PK
		public void Excluir(int? IdJob)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(JobDetalhe.METADADO.tabelaNAME);
			delete.Where
				.Add(JobDetalhe.METADADO.IdJob, Filter.Equal, IdJob);

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
