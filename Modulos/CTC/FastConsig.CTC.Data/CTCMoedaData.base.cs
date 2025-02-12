
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
	public partial class CTCMoedaData : DataBase
	{
		
		#region Listar
		public List<CTCMoeda> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CTCMoeda.METADADO.Id)
				.Field(CTCMoeda.METADADO.Codigo)
				.Field(CTCMoeda.METADADO.Descricao)
				.Table(CTCMoeda.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				List<CTCMoeda> result = base.MapReaderToEntitySet<CTCMoeda>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(CTCMoeda obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(CTCMoeda.METADADO.Descricao, obj.Descricao)
				.Table(CTCMoeda.METADADO.tabelaNAME);

			update.Where
				.Add(CTCMoeda.METADADO.Id, Filter.Equal, obj.Id)
				.Add(CTCMoeda.METADADO.Codigo, Filter.Equal, obj.Codigo);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, update.ToString());
				update.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

		#region Inserir
		public void Incluir(CTCMoeda obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.FieldValue(CTCMoeda.METADADO.Codigo, obj.Codigo)
				.Table(CTCMoeda.METADADO.tabelaNAME)
				.FieldValue(CTCMoeda.METADADO.Descricao, obj.Descricao)
				.SetIdentityField(CTCMoeda.METADADO.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, insert.ToString());
				insert.SetParameters(cmd);

				obj.Id = base.ExecuteScalar<int?>(cmd);
			}
		}
		#endregion

		#region Obtem
		public CTCMoeda Obtem(int? Id, string Codigo)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CTCMoeda.METADADO.Id)
				.Field(CTCMoeda.METADADO.Codigo)
				.Field(CTCMoeda.METADADO.Descricao)
				.Table(CTCMoeda.METADADO.tabelaNAME);

			query.Where
				.Add(CTCMoeda.METADADO.Id, Filter.Equal, Id)
				.Add(CTCMoeda.METADADO.Codigo, Filter.Equal, Codigo);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				CTCMoeda result = base.MapReaderToEntity<CTCMoeda>(cmd);
				return result;
			}
		}
		#endregion

		#region Excluir por FKs
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id, string Codigo)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(CTCMoeda.METADADO.tabelaNAME);
			delete.Where
				.Add(CTCMoeda.METADADO.Id, Filter.Equal, Id)
				.Add(CTCMoeda.METADADO.Codigo, Filter.Equal, Codigo);

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
