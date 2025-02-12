
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
	public partial class CTCTipoArquivoData : DataBase
	{
		
		#region Listar
		public List<CTCTipoArquivo> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CTCTipoArquivo.METADADO.Id)
				.Field(CTCTipoArquivo.METADADO.Codigo)
				.Field(CTCTipoArquivo.METADADO.Descricao)
				.Table(CTCTipoArquivo.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				List<CTCTipoArquivo> result = base.MapReaderToEntitySet<CTCTipoArquivo>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(CTCTipoArquivo obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(CTCTipoArquivo.METADADO.Codigo, obj.Codigo)
				.FieldValue(CTCTipoArquivo.METADADO.Descricao, obj.Descricao)
				.Table(CTCTipoArquivo.METADADO.tabelaNAME);

			update.Where
				.Add(CTCTipoArquivo.METADADO.Id, Filter.Equal, obj.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, update.ToString());
				update.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

		#region Inserir
		public void Incluir(CTCTipoArquivo obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(CTCTipoArquivo.METADADO.tabelaNAME)
				.FieldValue(CTCTipoArquivo.METADADO.Codigo, obj.Codigo)
				.FieldValue(CTCTipoArquivo.METADADO.Descricao, obj.Descricao)
				.SetIdentityField(CTCTipoArquivo.METADADO.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, insert.ToString());
				insert.SetParameters(cmd);

				obj.Id = base.ExecuteScalar<int?>(cmd);
			}
		}
		#endregion

		#region Obtem
		public CTCTipoArquivo Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CTCTipoArquivo.METADADO.Id)
				.Field(CTCTipoArquivo.METADADO.Codigo)
				.Field(CTCTipoArquivo.METADADO.Descricao)
				.Table(CTCTipoArquivo.METADADO.tabelaNAME);

			query.Where
				.Add(CTCTipoArquivo.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				CTCTipoArquivo result = base.MapReaderToEntity<CTCTipoArquivo>(cmd);
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
				delete.Table(CTCTipoArquivo.METADADO.tabelaNAME);
			delete.Where
				.Add(CTCTipoArquivo.METADADO.Id, Filter.Equal, Id);

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
