
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
	public partial class CTCEnteConsignanteData : DataBase
	{
		
		#region Listar
		public List<CTCEnteConsignante> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CTCEnteConsignante.METADADO.Id)
				.Field(CTCEnteConsignante.METADADO.Codigo)
				.Field(CTCEnteConsignante.METADADO.Descricao)
				.Table(CTCEnteConsignante.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				List<CTCEnteConsignante> result = base.MapReaderToEntitySet<CTCEnteConsignante>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(CTCEnteConsignante obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(CTCEnteConsignante.METADADO.Codigo, obj.Codigo)
				.FieldValue(CTCEnteConsignante.METADADO.Descricao, obj.Descricao)
				.Table(CTCEnteConsignante.METADADO.tabelaNAME);

			update.Where
				.Add(CTCEnteConsignante.METADADO.Id, Filter.Equal, obj.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, update.ToString());
				update.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

		#region Inserir
		public void Incluir(CTCEnteConsignante obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(CTCEnteConsignante.METADADO.tabelaNAME)
				.FieldValue(CTCEnteConsignante.METADADO.Codigo, obj.Codigo)
				.FieldValue(CTCEnteConsignante.METADADO.Descricao, obj.Descricao)
				.SetIdentityField(CTCEnteConsignante.METADADO.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, insert.ToString());
				insert.SetParameters(cmd);

				obj.Id = base.ExecuteScalar<int?>(cmd);
			}
		}
		#endregion

		#region Obtem
		public CTCEnteConsignante Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CTCEnteConsignante.METADADO.Id)
				.Field(CTCEnteConsignante.METADADO.Codigo)
				.Field(CTCEnteConsignante.METADADO.Descricao)
				.Table(CTCEnteConsignante.METADADO.tabelaNAME);

			query.Where
				.Add(CTCEnteConsignante.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				CTCEnteConsignante result = base.MapReaderToEntity<CTCEnteConsignante>(cmd);
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
				delete.Table(CTCEnteConsignante.METADADO.tabelaNAME);
			delete.Where
				.Add(CTCEnteConsignante.METADADO.Id, Filter.Equal, Id);

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
