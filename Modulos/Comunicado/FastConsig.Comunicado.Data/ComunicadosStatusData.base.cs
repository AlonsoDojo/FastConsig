
#region Usings
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Framework;
using Framework.Data;
using FastConsig.Comunicado.Entity;
#endregion

namespace FastConsig.Comunicado.Data
{
	public partial class ComunicadosStatusData : DataBase
	{
		
		#region Listar
		public List<ComunicadosStatus> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(ComunicadosStatus.METADADO.Id)
				.Field(ComunicadosStatus.METADADO.Descricao)
				.Table(ComunicadosStatus.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				List<ComunicadosStatus> result = base.MapReaderToEntitySet<ComunicadosStatus>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(ComunicadosStatus obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(ComunicadosStatus.METADADO.Descricao, obj.Descricao)
				.Table(ComunicadosStatus.METADADO.tabelaNAME);

			update.Where
				.Add(ComunicadosStatus.METADADO.Id, Filter.Equal, obj.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, update.ToString());
				update.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

		#region Inserir
		public void Incluir(ComunicadosStatus obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(ComunicadosStatus.METADADO.tabelaNAME)
				.FieldValue(ComunicadosStatus.METADADO.Descricao, obj.Descricao)
				.SetIdentityField(ComunicadosStatus.METADADO.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, insert.ToString());
				insert.SetParameters(cmd);

				obj.Id = base.ExecuteScalar<int?>(cmd);
			}
		}
		#endregion

		#region Obtem
		public ComunicadosStatus Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(ComunicadosStatus.METADADO.Id)
				.Field(ComunicadosStatus.METADADO.Descricao)
				.Table(ComunicadosStatus.METADADO.tabelaNAME);

			query.Where
				.Add(ComunicadosStatus.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				ComunicadosStatus result = base.MapReaderToEntity<ComunicadosStatus>(cmd);
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
				delete.Table(ComunicadosStatus.METADADO.tabelaNAME);
			delete.Where
				.Add(ComunicadosStatus.METADADO.Id, Filter.Equal, Id);

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
