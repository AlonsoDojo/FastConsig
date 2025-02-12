
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
	public partial class CTC922Data : DataBase
	{
		
		#region Listar
		public List<CTC922> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CTC922.METADADO.Id)
				.Field(CTC922.METADADO.Arquivo)
				.Field(CTC922.METADADO.DataReferencia)
				.Table(CTC922.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				List<CTC922> result = base.MapReaderToEntitySet<CTC922>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(CTC922 obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(CTC922.METADADO.Arquivo, obj.Arquivo)
				.FieldValue(CTC922.METADADO.DataReferencia, obj.DataReferencia)
				.Table(CTC922.METADADO.tabelaNAME);

			update.Where
				.Add(CTC922.METADADO.Id, Filter.Equal, obj.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, update.ToString());
				update.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

		#region Inserir
		public void Incluir(CTC922 obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(CTC922.METADADO.tabelaNAME)
				.FieldValue(CTC922.METADADO.Arquivo, obj.Arquivo)
				.FieldValue(CTC922.METADADO.DataReferencia, obj.DataReferencia)
				.SetIdentityField(CTC922.METADADO.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, insert.ToString());
				insert.SetParameters(cmd);

				obj.Id = base.ExecuteScalar<int?>(cmd);
			}
		}
		#endregion

		#region Obtem
		public CTC922 Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CTC922.METADADO.Id)
				.Field(CTC922.METADADO.Arquivo)
				.Field(CTC922.METADADO.DataReferencia)
				.Table(CTC922.METADADO.tabelaNAME);

			query.Where
				.Add(CTC922.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				CTC922 result = base.MapReaderToEntity<CTC922>(cmd);
				return result;
			}
		}
		#endregion

		#region Excluir por FKs
		public void ExcluirPor_Arquivo(int? Arquivo)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(CTC922.METADADO.tabelaNAME);
			delete.Where
				.Add(CTC922.METADADO.Arquivo, Filter.Equal, Arquivo);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, delete.ToString());
				delete.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(CTC922.METADADO.tabelaNAME);
			delete.Where
				.Add(CTC922.METADADO.Id, Filter.Equal, Id);

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
