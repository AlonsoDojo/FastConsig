
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
	public partial class CTC928Data : DataBase
	{
		
		#region Listar
		public List<CTC928> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CTC928.METADADO.Id)
				.Field(CTC928.METADADO.DataReferencia)
				.Field(CTC928.METADADO.Arquivo)
				.Table(CTC928.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				List<CTC928> result = base.MapReaderToEntitySet<CTC928>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(CTC928 obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(CTC928.METADADO.DataReferencia, obj.DataReferencia)
				.FieldValue(CTC928.METADADO.Arquivo, obj.Arquivo)
				.Table(CTC928.METADADO.tabelaNAME);

			update.Where
				.Add(CTC928.METADADO.Id, Filter.Equal, obj.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, update.ToString());
				update.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

		#region Inserir
		public void Incluir(CTC928 obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(CTC928.METADADO.tabelaNAME)
				.FieldValue(CTC928.METADADO.DataReferencia, obj.DataReferencia)
				.FieldValue(CTC928.METADADO.Arquivo, obj.Arquivo)
				.SetIdentityField(CTC928.METADADO.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, insert.ToString());
				insert.SetParameters(cmd);

				obj.Id = base.ExecuteScalar<int?>(cmd);
			}
		}
		#endregion

		#region Obtem
		public CTC928 Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CTC928.METADADO.Id)
				.Field(CTC928.METADADO.DataReferencia)
				.Field(CTC928.METADADO.Arquivo)
				.Table(CTC928.METADADO.tabelaNAME);

			query.Where
				.Add(CTC928.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				CTC928 result = base.MapReaderToEntity<CTC928>(cmd);
				return result;
			}
		}
		#endregion

		#region Excluir por FKs
		public void ExcluirPor_Arquivo(int? Arquivo)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(CTC928.METADADO.tabelaNAME);
			delete.Where
				.Add(CTC928.METADADO.Arquivo, Filter.Equal, Arquivo);

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
				delete.Table(CTC928.METADADO.tabelaNAME);
			delete.Where
				.Add(CTC928.METADADO.Id, Filter.Equal, Id);

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
