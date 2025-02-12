
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
	public partial class CTCTipoArquivoEnviadoData : DataBase
	{
		
		#region Listar
		public List<CTCTipoArquivoEnviado> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CTCTipoArquivoEnviado.METADADO.Id)
				.Field(CTCTipoArquivoEnviado.METADADO.Codigo)
				.Field(CTCTipoArquivoEnviado.METADADO.Descricao)
				.Table(CTCTipoArquivoEnviado.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				List<CTCTipoArquivoEnviado> result = base.MapReaderToEntitySet<CTCTipoArquivoEnviado>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(CTCTipoArquivoEnviado obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(CTCTipoArquivoEnviado.METADADO.Codigo, obj.Codigo)
				.FieldValue(CTCTipoArquivoEnviado.METADADO.Descricao, obj.Descricao)
				.Table(CTCTipoArquivoEnviado.METADADO.tabelaNAME);

			update.Where
				.Add(CTCTipoArquivoEnviado.METADADO.Id, Filter.Equal, obj.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, update.ToString());
				update.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

		#region Inserir
		public void Incluir(CTCTipoArquivoEnviado obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(CTCTipoArquivoEnviado.METADADO.tabelaNAME)
				.FieldValue(CTCTipoArquivoEnviado.METADADO.Codigo, obj.Codigo)
				.FieldValue(CTCTipoArquivoEnviado.METADADO.Descricao, obj.Descricao)
				.SetIdentityField(CTCTipoArquivoEnviado.METADADO.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, insert.ToString());
				insert.SetParameters(cmd);

				obj.Id = base.ExecuteScalar<int?>(cmd);
			}
		}
		#endregion

		#region Obtem
		public CTCTipoArquivoEnviado Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CTCTipoArquivoEnviado.METADADO.Id)
				.Field(CTCTipoArquivoEnviado.METADADO.Codigo)
				.Field(CTCTipoArquivoEnviado.METADADO.Descricao)
				.Table(CTCTipoArquivoEnviado.METADADO.tabelaNAME);

			query.Where
				.Add(CTCTipoArquivoEnviado.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				CTCTipoArquivoEnviado result = base.MapReaderToEntity<CTCTipoArquivoEnviado>(cmd);
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
				delete.Table(CTCTipoArquivoEnviado.METADADO.tabelaNAME);
			delete.Where
				.Add(CTCTipoArquivoEnviado.METADADO.Id, Filter.Equal, Id);

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
