
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
	public partial class CTCTipoEnteConsignanteData : DataBase
	{
		
		#region Listar
		public List<CTCTipoEnteConsignante> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CTCTipoEnteConsignante.METADADO.Id)
				.Field(CTCTipoEnteConsignante.METADADO.Codigo)
				.Field(CTCTipoEnteConsignante.METADADO.Descricao)
				.Table(CTCTipoEnteConsignante.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				List<CTCTipoEnteConsignante> result = base.MapReaderToEntitySet<CTCTipoEnteConsignante>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(CTCTipoEnteConsignante obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(CTCTipoEnteConsignante.METADADO.Codigo, obj.Codigo)
				.FieldValue(CTCTipoEnteConsignante.METADADO.Descricao, obj.Descricao)
				.Table(CTCTipoEnteConsignante.METADADO.tabelaNAME);

			update.Where
				.Add(CTCTipoEnteConsignante.METADADO.Id, Filter.Equal, obj.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, update.ToString());
				update.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

		#region Inserir
		public void Incluir(CTCTipoEnteConsignante obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(CTCTipoEnteConsignante.METADADO.tabelaNAME)
				.FieldValue(CTCTipoEnteConsignante.METADADO.Codigo, obj.Codigo)
				.FieldValue(CTCTipoEnteConsignante.METADADO.Descricao, obj.Descricao)
				.SetIdentityField(CTCTipoEnteConsignante.METADADO.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, insert.ToString());
				insert.SetParameters(cmd);

				obj.Id = base.ExecuteScalar<int?>(cmd);
			}
		}
		#endregion

		#region Obtem
		public CTCTipoEnteConsignante Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CTCTipoEnteConsignante.METADADO.Id)
				.Field(CTCTipoEnteConsignante.METADADO.Codigo)
				.Field(CTCTipoEnteConsignante.METADADO.Descricao)
				.Table(CTCTipoEnteConsignante.METADADO.tabelaNAME);

			query.Where
				.Add(CTCTipoEnteConsignante.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				CTCTipoEnteConsignante result = base.MapReaderToEntity<CTCTipoEnteConsignante>(cmd);
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
				delete.Table(CTCTipoEnteConsignante.METADADO.tabelaNAME);
			delete.Where
				.Add(CTCTipoEnteConsignante.METADADO.Id, Filter.Equal, Id);

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
