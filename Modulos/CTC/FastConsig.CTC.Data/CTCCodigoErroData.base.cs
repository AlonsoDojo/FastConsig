
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
	public partial class CTCCodigoErroData : DataBase
	{
		
		#region Listar
		public List<CTCCodigoErro> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CTCCodigoErro.METADADO.Id)
				.Field(CTCCodigoErro.METADADO.Codigo)
				.Field(CTCCodigoErro.METADADO.Descricao)
				.Table(CTCCodigoErro.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				List<CTCCodigoErro> result = base.MapReaderToEntitySet<CTCCodigoErro>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(CTCCodigoErro obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(CTCCodigoErro.METADADO.Codigo, obj.Codigo)
				.FieldValue(CTCCodigoErro.METADADO.Descricao, obj.Descricao)
				.Table(CTCCodigoErro.METADADO.tabelaNAME);

			update.Where
				.Add(CTCCodigoErro.METADADO.Id, Filter.Equal, obj.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, update.ToString());
				update.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

		#region Inserir
		public void Incluir(CTCCodigoErro obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(CTCCodigoErro.METADADO.tabelaNAME)
				.FieldValue(CTCCodigoErro.METADADO.Codigo, obj.Codigo)
				.FieldValue(CTCCodigoErro.METADADO.Descricao, obj.Descricao)
				.SetIdentityField(CTCCodigoErro.METADADO.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, insert.ToString());
				insert.SetParameters(cmd);

				obj.Id = base.ExecuteScalar<int?>(cmd);
			}
		}
		#endregion

		#region Obtem
		public CTCCodigoErro Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CTCCodigoErro.METADADO.Id)
				.Field(CTCCodigoErro.METADADO.Codigo)
				.Field(CTCCodigoErro.METADADO.Descricao)
				.Table(CTCCodigoErro.METADADO.tabelaNAME);

			query.Where
				.Add(CTCCodigoErro.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				CTCCodigoErro result = base.MapReaderToEntity<CTCCodigoErro>(cmd);
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
				delete.Table(CTCCodigoErro.METADADO.tabelaNAME);
			delete.Where
				.Add(CTCCodigoErro.METADADO.Id, Filter.Equal, Id);

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
