
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
	public partial class CTCSituacaoArquivoData : DataBase
	{
		
		#region Listar
		public List<CTCSituacaoArquivo> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CTCSituacaoArquivo.METADADO.Id)
				.Field(CTCSituacaoArquivo.METADADO.Descricao)
				.Table(CTCSituacaoArquivo.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				List<CTCSituacaoArquivo> result = base.MapReaderToEntitySet<CTCSituacaoArquivo>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(CTCSituacaoArquivo obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(CTCSituacaoArquivo.METADADO.Descricao, obj.Descricao)
				.Table(CTCSituacaoArquivo.METADADO.tabelaNAME);

			update.Where
				.Add(CTCSituacaoArquivo.METADADO.Id, Filter.Equal, obj.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, update.ToString());
				update.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

		#region Inserir
		public void Incluir(CTCSituacaoArquivo obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(CTCSituacaoArquivo.METADADO.tabelaNAME)
				.FieldValue(CTCSituacaoArquivo.METADADO.Descricao, obj.Descricao)
				.SetIdentityField(CTCSituacaoArquivo.METADADO.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, insert.ToString());
				insert.SetParameters(cmd);

				obj.Id = base.ExecuteScalar<int?>(cmd);
			}
		}
		#endregion

		#region Obtem
		public CTCSituacaoArquivo Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CTCSituacaoArquivo.METADADO.Id)
				.Field(CTCSituacaoArquivo.METADADO.Descricao)
				.Table(CTCSituacaoArquivo.METADADO.tabelaNAME);

			query.Where
				.Add(CTCSituacaoArquivo.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				CTCSituacaoArquivo result = base.MapReaderToEntity<CTCSituacaoArquivo>(cmd);
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
				delete.Table(CTCSituacaoArquivo.METADADO.tabelaNAME);
			delete.Where
				.Add(CTCSituacaoArquivo.METADADO.Id, Filter.Equal, Id);

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
