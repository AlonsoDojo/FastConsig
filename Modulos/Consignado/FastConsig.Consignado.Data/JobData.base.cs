
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
	public partial class JobData : DataBase
	{
		
		#region Listar
		public List<Job> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(Job.METADADO.Id)
				.Field(Job.METADADO.Name)
				.Field(Job.METADADO.Codigo)
				.Field(Job.METADADO.Descricao)
				.Field(Job.METADADO.IdJobStatus)
				.Table(Job.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				List<Job> result = base.MapReaderToEntitySet<Job>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(Job obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(Job.METADADO.Name, obj.Name)
				.FieldValue(Job.METADADO.Codigo, obj.Codigo)
				.FieldValue(Job.METADADO.Descricao, obj.Descricao)
				.FieldValue(Job.METADADO.IdJobStatus, obj.IdJobStatus)
				.Table(Job.METADADO.tabelaNAME);

			update.Where
				.Add(Job.METADADO.Id, Filter.Equal, obj.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, update.ToString());
				update.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

		#region Inserir
		public void Incluir(Job obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(Job.METADADO.tabelaNAME)
				.FieldValue(Job.METADADO.Name, obj.Name)
				.FieldValue(Job.METADADO.Codigo, obj.Codigo)
				.FieldValue(Job.METADADO.Descricao, obj.Descricao)
				.FieldValue(Job.METADADO.IdJobStatus, obj.IdJobStatus)
				.SetIdentityField(Job.METADADO.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, insert.ToString());
				insert.SetParameters(cmd);

				obj.Id = base.ExecuteScalar<int?>(cmd);
			}
		}
		#endregion

		#region Obtem
		public Job Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(Job.METADADO.Id)
				.Field(Job.METADADO.Name)
				.Field(Job.METADADO.Codigo)
				.Field(Job.METADADO.Descricao)
				.Field(Job.METADADO.IdJobStatus)
				.Table(Job.METADADO.tabelaNAME);

			query.Where
				.Add(Job.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				Job result = base.MapReaderToEntity<Job>(cmd);
				return result;
			}
		}
		#endregion

		#region Excluir por FKs
		public void ExcluirPor_IdJobStatus(string IdJobStatus)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(Job.METADADO.tabelaNAME);
			delete.Where
				.Add(Job.METADADO.IdJobStatus, Filter.Equal, IdJobStatus);

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
				delete.Table(Job.METADADO.tabelaNAME);
			delete.Where
				.Add(Job.METADADO.Id, Filter.Equal, Id);

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
