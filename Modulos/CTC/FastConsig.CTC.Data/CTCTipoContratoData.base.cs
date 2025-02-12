
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
	public partial class CTCTipoContratoData : DataBase
	{
		
		#region Listar
		public List<CTCTipoContrato> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CTCTipoContrato.METADADO.Id)
				.Field(CTCTipoContrato.METADADO.Codigo)
				.Field(CTCTipoContrato.METADADO.Descricao)
				.Table(CTCTipoContrato.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				List<CTCTipoContrato> result = base.MapReaderToEntitySet<CTCTipoContrato>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(CTCTipoContrato obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(CTCTipoContrato.METADADO.Codigo, obj.Codigo)
				.FieldValue(CTCTipoContrato.METADADO.Descricao, obj.Descricao)
				.Table(CTCTipoContrato.METADADO.tabelaNAME);

			update.Where
				.Add(CTCTipoContrato.METADADO.Id, Filter.Equal, obj.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, update.ToString());
				update.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

		#region Inserir
		public void Incluir(CTCTipoContrato obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(CTCTipoContrato.METADADO.tabelaNAME)
				.FieldValue(CTCTipoContrato.METADADO.Codigo, obj.Codigo)
				.FieldValue(CTCTipoContrato.METADADO.Descricao, obj.Descricao)
				.SetIdentityField(CTCTipoContrato.METADADO.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, insert.ToString());
				insert.SetParameters(cmd);

				obj.Id = base.ExecuteScalar<int?>(cmd);
			}
		}
		#endregion

		#region Obtem
		public CTCTipoContrato Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CTCTipoContrato.METADADO.Id)
				.Field(CTCTipoContrato.METADADO.Codigo)
				.Field(CTCTipoContrato.METADADO.Descricao)
				.Table(CTCTipoContrato.METADADO.tabelaNAME);

			query.Where
				.Add(CTCTipoContrato.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				CTCTipoContrato result = base.MapReaderToEntity<CTCTipoContrato>(cmd);
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
				delete.Table(CTCTipoContrato.METADADO.tabelaNAME);
			delete.Where
				.Add(CTCTipoContrato.METADADO.Id, Filter.Equal, Id);

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
