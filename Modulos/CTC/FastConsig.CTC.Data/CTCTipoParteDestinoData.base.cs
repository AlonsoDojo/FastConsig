
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
	public partial class CTCTipoParteDestinoData : DataBase
	{
		
		#region Listar
		public List<CTCTipoParteDestino> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CTCTipoParteDestino.METADADO.Id)
				.Field(CTCTipoParteDestino.METADADO.Descricao)
				.Field(CTCTipoParteDestino.METADADO.ISPB)
				.Table(CTCTipoParteDestino.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				List<CTCTipoParteDestino> result = base.MapReaderToEntitySet<CTCTipoParteDestino>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(CTCTipoParteDestino obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(CTCTipoParteDestino.METADADO.Descricao, obj.Descricao)
				.FieldValue(CTCTipoParteDestino.METADADO.ISPB, obj.ISPB)
				.Table(CTCTipoParteDestino.METADADO.tabelaNAME);

			update.Where
				.Add(CTCTipoParteDestino.METADADO.Id, Filter.Equal, obj.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, update.ToString());
				update.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

		#region Inserir
		public void Incluir(CTCTipoParteDestino obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(CTCTipoParteDestino.METADADO.tabelaNAME)
				.FieldValue(CTCTipoParteDestino.METADADO.Descricao, obj.Descricao)
				.FieldValue(CTCTipoParteDestino.METADADO.ISPB, obj.ISPB)
				.SetIdentityField(CTCTipoParteDestino.METADADO.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, insert.ToString());
				insert.SetParameters(cmd);

				obj.Id = base.ExecuteScalar<int?>(cmd);
			}
		}
		#endregion

		#region Obtem
		public CTCTipoParteDestino Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CTCTipoParteDestino.METADADO.Id)
				.Field(CTCTipoParteDestino.METADADO.Descricao)
				.Field(CTCTipoParteDestino.METADADO.ISPB)
				.Table(CTCTipoParteDestino.METADADO.tabelaNAME);

			query.Where
				.Add(CTCTipoParteDestino.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				CTCTipoParteDestino result = base.MapReaderToEntity<CTCTipoParteDestino>(cmd);
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
				delete.Table(CTCTipoParteDestino.METADADO.tabelaNAME);
			delete.Where
				.Add(CTCTipoParteDestino.METADADO.Id, Filter.Equal, Id);

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
