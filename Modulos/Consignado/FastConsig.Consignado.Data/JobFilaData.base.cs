
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
	public partial class JobFilaData : DataBase
	{
		
		#region Listar
		public List<JobFila> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(JobFila.METADADO.Id)
				.Field(JobFila.METADADO.Mensagem)
				.Field(JobFila.METADADO.IdStatus)
				.Table(JobFila.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				List<JobFila> result = base.MapReaderToEntitySet<JobFila>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(JobFila obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(JobFila.METADADO.Mensagem, obj.Mensagem)
				.FieldValue(JobFila.METADADO.IdStatus, obj.IdStatus)
				.Table(JobFila.METADADO.tabelaNAME);

			update.Where
				.Add(JobFila.METADADO.Id, Filter.Equal, obj.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, update.ToString());
				update.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

		#region Inserir
		public void Incluir(JobFila obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(JobFila.METADADO.tabelaNAME)
				.FieldValue(JobFila.METADADO.Mensagem, obj.Mensagem)
				.FieldValue(JobFila.METADADO.IdStatus, obj.IdStatus)
				.SetIdentityField(JobFila.METADADO.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, insert.ToString());
				insert.SetParameters(cmd);

				obj.Id = base.ExecuteScalar<long?>(cmd);
			}
		}
		#endregion

		#region Obtem
		public JobFila Obtem(long? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(JobFila.METADADO.Id)
				.Field(JobFila.METADADO.Mensagem)
				.Field(JobFila.METADADO.IdStatus)
				.Table(JobFila.METADADO.tabelaNAME);

			query.Where
				.Add(JobFila.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				JobFila result = base.MapReaderToEntity<JobFila>(cmd);
				return result;
			}
		}
		#endregion

		#region Excluir por FKs
		public void ExcluirPor_IdStatus(int? IdStatus)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(JobFila.METADADO.tabelaNAME);
			delete.Where
				.Add(JobFila.METADADO.IdStatus, Filter.Equal, IdStatus);

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
				delete.Table(JobFila.METADADO.tabelaNAME);
			delete.Where
				.Add(JobFila.METADADO.Id, Filter.Equal, Id);

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
