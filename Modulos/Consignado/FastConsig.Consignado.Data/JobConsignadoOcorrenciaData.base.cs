
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
	public partial class JobConsignadoOcorrenciaData : DataBase
	{
		
		#region Listar
		public List<JobConsignadoOcorrencia> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(JobConsignadoOcorrencia.METADADO.Id)
				.Field(JobConsignadoOcorrencia.METADADO.JobId)
				.Field(JobConsignadoOcorrencia.METADADO.ConsignadoOcorrenciaId)
				.Field(JobConsignadoOcorrencia.METADADO.Acao)
				.Field(JobConsignadoOcorrencia.METADADO.Ocorrencia)
				.Table(JobConsignadoOcorrencia.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				List<JobConsignadoOcorrencia> result = base.MapReaderToEntitySet<JobConsignadoOcorrencia>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(JobConsignadoOcorrencia obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(JobConsignadoOcorrencia.METADADO.JobId, obj.JobId)
				.FieldValue(JobConsignadoOcorrencia.METADADO.ConsignadoOcorrenciaId, obj.ConsignadoOcorrenciaId)
				.FieldValue(JobConsignadoOcorrencia.METADADO.Acao, obj.Acao)
				.FieldValue(JobConsignadoOcorrencia.METADADO.Ocorrencia, obj.Ocorrencia)
				.Table(JobConsignadoOcorrencia.METADADO.tabelaNAME);

			update.Where
				.Add(JobConsignadoOcorrencia.METADADO.Id, Filter.Equal, obj.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, update.ToString());
				update.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

		#region Inserir
		public void Incluir(JobConsignadoOcorrencia obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(JobConsignadoOcorrencia.METADADO.tabelaNAME)
				.FieldValue(JobConsignadoOcorrencia.METADADO.JobId, obj.JobId)
				.FieldValue(JobConsignadoOcorrencia.METADADO.ConsignadoOcorrenciaId, obj.ConsignadoOcorrenciaId)
				.FieldValue(JobConsignadoOcorrencia.METADADO.Acao, obj.Acao)
				.FieldValue(JobConsignadoOcorrencia.METADADO.Ocorrencia, obj.Ocorrencia)
				.SetIdentityField(JobConsignadoOcorrencia.METADADO.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, insert.ToString());
				insert.SetParameters(cmd);

				obj.Id = base.ExecuteScalar<int?>(cmd);
			}
		}
		#endregion

		#region Obtem
		public JobConsignadoOcorrencia Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(JobConsignadoOcorrencia.METADADO.Id)
				.Field(JobConsignadoOcorrencia.METADADO.JobId)
				.Field(JobConsignadoOcorrencia.METADADO.ConsignadoOcorrenciaId)
				.Field(JobConsignadoOcorrencia.METADADO.Acao)
				.Field(JobConsignadoOcorrencia.METADADO.Ocorrencia)
				.Table(JobConsignadoOcorrencia.METADADO.tabelaNAME);

			query.Where
				.Add(JobConsignadoOcorrencia.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				JobConsignadoOcorrencia result = base.MapReaderToEntity<JobConsignadoOcorrencia>(cmd);
				return result;
			}
		}
		#endregion

		#region Excluir por FKs
		public void ExcluirPor_JobId(int? JobId)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(JobConsignadoOcorrencia.METADADO.tabelaNAME);
			delete.Where
				.Add(JobConsignadoOcorrencia.METADADO.JobId, Filter.Equal, JobId);

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
				delete.Table(JobConsignadoOcorrencia.METADADO.tabelaNAME);
			delete.Where
				.Add(JobConsignadoOcorrencia.METADADO.Id, Filter.Equal, Id);

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
