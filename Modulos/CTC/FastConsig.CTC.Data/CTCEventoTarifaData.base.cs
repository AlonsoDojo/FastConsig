
#region Usings
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Framework;
using Framework.Data;
using FastConsig.CTC.Entity;
#endregion

namespace FastConsig.CTC.Data
{
	public partial class CTCEventoTarifaData : DataBase
	{
		
		#region Listar
		public List<CTCEventoTarifa> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CTCEventoTarifa.METADADO.Id)
				.Field(CTCEventoTarifa.METADADO.Codigo)
				.Field(CTCEventoTarifa.METADADO.Descricao)
				.Table(CTCEventoTarifa.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				List<CTCEventoTarifa> result = base.MapReaderToEntitySet<CTCEventoTarifa>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(CTCEventoTarifa obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(CTCEventoTarifa.METADADO.Codigo, obj.Codigo)
				.FieldValue(CTCEventoTarifa.METADADO.Descricao, obj.Descricao)
				.Table(CTCEventoTarifa.METADADO.tabelaNAME);

			update.Where
				.Add(CTCEventoTarifa.METADADO.Id, Filter.Equal, obj.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, update.ToString());
				update.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

		#region Inserir
		public void Incluir(CTCEventoTarifa obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(CTCEventoTarifa.METADADO.tabelaNAME)
				.FieldValue(CTCEventoTarifa.METADADO.Codigo, obj.Codigo)
				.FieldValue(CTCEventoTarifa.METADADO.Descricao, obj.Descricao)
				.SetIdentityField(CTCEventoTarifa.METADADO.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, insert.ToString());
				insert.SetParameters(cmd);

				obj.Id = base.ExecuteScalar<int?>(cmd);
			}
		}
		#endregion

		#region Obtem
		public CTCEventoTarifa Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CTCEventoTarifa.METADADO.Id)
				.Field(CTCEventoTarifa.METADADO.Codigo)
				.Field(CTCEventoTarifa.METADADO.Descricao)
				.Table(CTCEventoTarifa.METADADO.tabelaNAME);

			query.Where
				.Add(CTCEventoTarifa.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				CTCEventoTarifa result = base.MapReaderToEntity<CTCEventoTarifa>(cmd);
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
				delete.Table(CTCEventoTarifa.METADADO.tabelaNAME);
			delete.Where
				.Add(CTCEventoTarifa.METADADO.Id, Filter.Equal, Id);

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
