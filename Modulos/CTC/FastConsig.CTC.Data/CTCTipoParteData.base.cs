
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
	public partial class CTCTipoParteData : DataBase
	{
		
		#region Listar
		public List<CTCTipoParte> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CTCTipoParte.METADADO.Id)
				.Field(CTCTipoParte.METADADO.Descricao)
				.Field(CTCTipoParte.METADADO.ISPB)
				.Table(CTCTipoParte.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				List<CTCTipoParte> result = base.MapReaderToEntitySet<CTCTipoParte>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(CTCTipoParte obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(CTCTipoParte.METADADO.Descricao, obj.Descricao)
				.FieldValue(CTCTipoParte.METADADO.ISPB, obj.ISPB)
				.Table(CTCTipoParte.METADADO.tabelaNAME);

			update.Where
				.Add(CTCTipoParte.METADADO.Id, Filter.Equal, obj.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, update.ToString());
				update.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

		#region Inserir
		public void Incluir(CTCTipoParte obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(CTCTipoParte.METADADO.tabelaNAME)
				.FieldValue(CTCTipoParte.METADADO.Descricao, obj.Descricao)
				.FieldValue(CTCTipoParte.METADADO.ISPB, obj.ISPB)
				.SetIdentityField(CTCTipoParte.METADADO.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, insert.ToString());
				insert.SetParameters(cmd);

				obj.Id = base.ExecuteScalar<int?>(cmd);
			}
		}
		#endregion

		#region Obtem
		public CTCTipoParte Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CTCTipoParte.METADADO.Id)
				.Field(CTCTipoParte.METADADO.Descricao)
				.Field(CTCTipoParte.METADADO.ISPB)
				.Table(CTCTipoParte.METADADO.tabelaNAME);

			query.Where
				.Add(CTCTipoParte.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				CTCTipoParte result = base.MapReaderToEntity<CTCTipoParte>(cmd);
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
				delete.Table(CTCTipoParte.METADADO.tabelaNAME);
			delete.Where
				.Add(CTCTipoParte.METADADO.Id, Filter.Equal, Id);

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
