
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
	public partial class CTCTipoContratoOriginalData : DataBase
	{
		
		#region Listar
		public List<CTCTipoContratoOriginal> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CTCTipoContratoOriginal.METADADO.Id)
				.Field(CTCTipoContratoOriginal.METADADO.Codigo)
				.Field(CTCTipoContratoOriginal.METADADO.Descricao)
				.Table(CTCTipoContratoOriginal.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				List<CTCTipoContratoOriginal> result = base.MapReaderToEntitySet<CTCTipoContratoOriginal>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(CTCTipoContratoOriginal obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(CTCTipoContratoOriginal.METADADO.Codigo, obj.Codigo)
				.FieldValue(CTCTipoContratoOriginal.METADADO.Descricao, obj.Descricao)
				.Table(CTCTipoContratoOriginal.METADADO.tabelaNAME);

			update.Where
				.Add(CTCTipoContratoOriginal.METADADO.Id, Filter.Equal, obj.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, update.ToString());
				update.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

		#region Inserir
		public void Incluir(CTCTipoContratoOriginal obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(CTCTipoContratoOriginal.METADADO.tabelaNAME)
				.FieldValue(CTCTipoContratoOriginal.METADADO.Codigo, obj.Codigo)
				.FieldValue(CTCTipoContratoOriginal.METADADO.Descricao, obj.Descricao)
				.SetIdentityField(CTCTipoContratoOriginal.METADADO.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, insert.ToString());
				insert.SetParameters(cmd);

				obj.Id = base.ExecuteScalar<int?>(cmd);
			}
		}
		#endregion

		#region Obtem
		public CTCTipoContratoOriginal Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CTCTipoContratoOriginal.METADADO.Id)
				.Field(CTCTipoContratoOriginal.METADADO.Codigo)
				.Field(CTCTipoContratoOriginal.METADADO.Descricao)
				.Table(CTCTipoContratoOriginal.METADADO.tabelaNAME);

			query.Where
				.Add(CTCTipoContratoOriginal.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				CTCTipoContratoOriginal result = base.MapReaderToEntity<CTCTipoContratoOriginal>(cmd);
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
				delete.Table(CTCTipoContratoOriginal.METADADO.tabelaNAME);
			delete.Where
				.Add(CTCTipoContratoOriginal.METADADO.Id, Filter.Equal, Id);

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
