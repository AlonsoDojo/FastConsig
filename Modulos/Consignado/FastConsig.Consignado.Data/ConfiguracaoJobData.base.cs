
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
	public partial class ConfiguracaoJobData : DataBase
	{
		
		#region Listar
		public List<ConfiguracaoJob> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(ConfiguracaoJob.METADADO.Id)
				.Field(ConfiguracaoJob.METADADO.IdJob)
				.Field(ConfiguracaoJob.METADADO.HorarioExecucao)
				.Field(ConfiguracaoJob.METADADO.ParametrosExtras)
				.Field(ConfiguracaoJob.METADADO.Dom)
				.Field(ConfiguracaoJob.METADADO.Seg)
				.Field(ConfiguracaoJob.METADADO.Ter)
				.Field(ConfiguracaoJob.METADADO.Qua)
				.Field(ConfiguracaoJob.METADADO.Qui)
				.Field(ConfiguracaoJob.METADADO.Sex)
				.Field(ConfiguracaoJob.METADADO.Sab)
				.Field(ConfiguracaoJob.METADADO.Habilitado)
				.Field(ConfiguracaoJob.METADADO.EmailAvisoConclusao)
				.Field(ConfiguracaoJob.METADADO.EmailAvisoErro)
				.Field(ConfiguracaoJob.METADADO.TentativasExecucao)
				.Field(ConfiguracaoJob.METADADO.DelayExecucao)
				.Table(ConfiguracaoJob.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				List<ConfiguracaoJob> result = base.MapReaderToEntitySet<ConfiguracaoJob>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(ConfiguracaoJob obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(ConfiguracaoJob.METADADO.IdJob, obj.IdJob)
				.FieldValue(ConfiguracaoJob.METADADO.HorarioExecucao, obj.HorarioExecucao)
				.FieldValue(ConfiguracaoJob.METADADO.ParametrosExtras, obj.ParametrosExtras)
				.FieldValue(ConfiguracaoJob.METADADO.Dom, obj.Dom)
				.FieldValue(ConfiguracaoJob.METADADO.Seg, obj.Seg)
				.FieldValue(ConfiguracaoJob.METADADO.Ter, obj.Ter)
				.FieldValue(ConfiguracaoJob.METADADO.Qua, obj.Qua)
				.FieldValue(ConfiguracaoJob.METADADO.Qui, obj.Qui)
				.FieldValue(ConfiguracaoJob.METADADO.Sex, obj.Sex)
				.FieldValue(ConfiguracaoJob.METADADO.Sab, obj.Sab)
				.FieldValue(ConfiguracaoJob.METADADO.Habilitado, obj.Habilitado)
				.FieldValue(ConfiguracaoJob.METADADO.EmailAvisoConclusao, obj.EmailAvisoConclusao)
				.FieldValue(ConfiguracaoJob.METADADO.EmailAvisoErro, obj.EmailAvisoErro)
				.FieldValue(ConfiguracaoJob.METADADO.TentativasExecucao, obj.TentativasExecucao)
				.FieldValue(ConfiguracaoJob.METADADO.DelayExecucao, obj.DelayExecucao)
				.Table(ConfiguracaoJob.METADADO.tabelaNAME);

			update.Where
				.Add(ConfiguracaoJob.METADADO.Id, Filter.Equal, obj.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, update.ToString());
				update.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

		#region Inserir
		public void Incluir(ConfiguracaoJob obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(ConfiguracaoJob.METADADO.tabelaNAME)
				.FieldValue(ConfiguracaoJob.METADADO.IdJob, obj.IdJob)
				.FieldValue(ConfiguracaoJob.METADADO.HorarioExecucao, obj.HorarioExecucao)
				.FieldValue(ConfiguracaoJob.METADADO.ParametrosExtras, obj.ParametrosExtras)
				.FieldValue(ConfiguracaoJob.METADADO.Dom, obj.Dom)
				.FieldValue(ConfiguracaoJob.METADADO.Seg, obj.Seg)
				.FieldValue(ConfiguracaoJob.METADADO.Ter, obj.Ter)
				.FieldValue(ConfiguracaoJob.METADADO.Qua, obj.Qua)
				.FieldValue(ConfiguracaoJob.METADADO.Qui, obj.Qui)
				.FieldValue(ConfiguracaoJob.METADADO.Sex, obj.Sex)
				.FieldValue(ConfiguracaoJob.METADADO.Sab, obj.Sab)
				.FieldValue(ConfiguracaoJob.METADADO.Habilitado, obj.Habilitado)
				.FieldValue(ConfiguracaoJob.METADADO.EmailAvisoConclusao, obj.EmailAvisoConclusao)
				.FieldValue(ConfiguracaoJob.METADADO.EmailAvisoErro, obj.EmailAvisoErro)
				.FieldValue(ConfiguracaoJob.METADADO.TentativasExecucao, obj.TentativasExecucao)
				.FieldValue(ConfiguracaoJob.METADADO.DelayExecucao, obj.DelayExecucao)
				.SetIdentityField(ConfiguracaoJob.METADADO.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, insert.ToString());
				insert.SetParameters(cmd);

				obj.Id = base.ExecuteScalar<int?>(cmd);
			}
		}
		#endregion

		#region Obtem
		public ConfiguracaoJob Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(ConfiguracaoJob.METADADO.Id)
				.Field(ConfiguracaoJob.METADADO.IdJob)
				.Field(ConfiguracaoJob.METADADO.HorarioExecucao)
				.Field(ConfiguracaoJob.METADADO.ParametrosExtras)
				.Field(ConfiguracaoJob.METADADO.Dom)
				.Field(ConfiguracaoJob.METADADO.Seg)
				.Field(ConfiguracaoJob.METADADO.Ter)
				.Field(ConfiguracaoJob.METADADO.Qua)
				.Field(ConfiguracaoJob.METADADO.Qui)
				.Field(ConfiguracaoJob.METADADO.Sex)
				.Field(ConfiguracaoJob.METADADO.Sab)
				.Field(ConfiguracaoJob.METADADO.Habilitado)
				.Field(ConfiguracaoJob.METADADO.EmailAvisoConclusao)
				.Field(ConfiguracaoJob.METADADO.EmailAvisoErro)
				.Field(ConfiguracaoJob.METADADO.TentativasExecucao)
				.Field(ConfiguracaoJob.METADADO.DelayExecucao)
				.Table(ConfiguracaoJob.METADADO.tabelaNAME);

			query.Where
				.Add(ConfiguracaoJob.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				ConfiguracaoJob result = base.MapReaderToEntity<ConfiguracaoJob>(cmd);
				return result;
			}
		}
		#endregion

		#region Excluir por FKs
		public void ExcluirPor_IdJob(int? IdJob)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(ConfiguracaoJob.METADADO.tabelaNAME);
			delete.Where
				.Add(ConfiguracaoJob.METADADO.IdJob, Filter.Equal, IdJob);

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
				delete.Table(ConfiguracaoJob.METADADO.tabelaNAME);
			delete.Where
				.Add(ConfiguracaoJob.METADADO.Id, Filter.Equal, Id);

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
