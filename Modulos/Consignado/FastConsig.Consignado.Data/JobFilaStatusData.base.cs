
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
	public partial class JobFilaStatusData : DataBase
	{
		
		#region Listar
		public List<JobFilaStatus> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(JobFilaStatus.METADADO.Id)
				.Field(JobFilaStatus.METADADO.Descricao)
				.Table(JobFilaStatus.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				List<JobFilaStatus> result = base.MapReaderToEntitySet<JobFilaStatus>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(JobFilaStatus obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(JobFilaStatus.METADADO.Descricao, obj.Descricao)
				.Table(JobFilaStatus.METADADO.tabelaNAME);

			update.Where
				.Add(JobFilaStatus.METADADO.Id, Filter.Equal, obj.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, update.ToString());
				update.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

		#region Inserir
		public void Incluir(JobFilaStatus obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(JobFilaStatus.METADADO.tabelaNAME)
				.FieldValue(JobFilaStatus.METADADO.Descricao, obj.Descricao)
				.SetIdentityField(JobFilaStatus.METADADO.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, insert.ToString());
				insert.SetParameters(cmd);

				obj.Id = base.ExecuteScalar<int?>(cmd);
			}
		}
		#endregion

		#region Obtem
		public JobFilaStatus Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(JobFilaStatus.METADADO.Id)
				.Field(JobFilaStatus.METADADO.Descricao)
				.Table(JobFilaStatus.METADADO.tabelaNAME);

			query.Where
				.Add(JobFilaStatus.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				JobFilaStatus result = base.MapReaderToEntity<JobFilaStatus>(cmd);
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
				delete.Table(JobFilaStatus.METADADO.tabelaNAME);
			delete.Where
				.Add(JobFilaStatus.METADADO.Id, Filter.Equal, Id);

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
