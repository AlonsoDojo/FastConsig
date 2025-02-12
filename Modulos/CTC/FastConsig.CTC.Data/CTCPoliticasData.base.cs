
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
	public partial class CTCPoliticasData : DataBase
	{
		
		#region Listar
		public List<CTCPoliticas> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CTCPoliticas.METADADO.Id)
				.Field(CTCPoliticas.METADADO.Descricao)
				.Field(CTCPoliticas.METADADO.Metodo)
				.Field(CTCPoliticas.METADADO.TipoPolitica)
				.Field(CTCPoliticas.METADADO.Async)
				.Field(CTCPoliticas.METADADO.Parametros)
				.Table(CTCPoliticas.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				List<CTCPoliticas> result = base.MapReaderToEntitySet<CTCPoliticas>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(CTCPoliticas obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(CTCPoliticas.METADADO.Descricao, obj.Descricao)
				.FieldValue(CTCPoliticas.METADADO.Metodo, obj.Metodo)
				.FieldValue(CTCPoliticas.METADADO.TipoPolitica, obj.TipoPolitica)
				.FieldValue(CTCPoliticas.METADADO.Async, obj.Async)
				.FieldValue(CTCPoliticas.METADADO.Parametros, obj.Parametros)
				.Table(CTCPoliticas.METADADO.tabelaNAME);

			update.Where
				.Add(CTCPoliticas.METADADO.Id, Filter.Equal, obj.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, update.ToString());
				update.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

		#region Inserir
		public void Incluir(CTCPoliticas obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(CTCPoliticas.METADADO.tabelaNAME)
				.FieldValue(CTCPoliticas.METADADO.Descricao, obj.Descricao)
				.FieldValue(CTCPoliticas.METADADO.Metodo, obj.Metodo)
				.FieldValue(CTCPoliticas.METADADO.TipoPolitica, obj.TipoPolitica)
				.FieldValue(CTCPoliticas.METADADO.Async, obj.Async)
				.FieldValue(CTCPoliticas.METADADO.Parametros, obj.Parametros)
				.SetIdentityField(CTCPoliticas.METADADO.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, insert.ToString());
				insert.SetParameters(cmd);

				obj.Id = base.ExecuteScalar<int?>(cmd);
			}
		}
		#endregion

		#region Obtem
		public CTCPoliticas Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CTCPoliticas.METADADO.Id)
				.Field(CTCPoliticas.METADADO.Descricao)
				.Field(CTCPoliticas.METADADO.Metodo)
				.Field(CTCPoliticas.METADADO.TipoPolitica)
				.Field(CTCPoliticas.METADADO.Async)
				.Field(CTCPoliticas.METADADO.Parametros)
				.Table(CTCPoliticas.METADADO.tabelaNAME);

			query.Where
				.Add(CTCPoliticas.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				CTCPoliticas result = base.MapReaderToEntity<CTCPoliticas>(cmd);
				return result;
			}
		}
		#endregion

		#region Excluir por FKs
		public void ExcluirPor_TipoPolitica(int? TipoPolitica)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(CTCPoliticas.METADADO.tabelaNAME);
			delete.Where
				.Add(CTCPoliticas.METADADO.TipoPolitica, Filter.Equal, TipoPolitica);

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
				delete.Table(CTCPoliticas.METADADO.tabelaNAME);
			delete.Where
				.Add(CTCPoliticas.METADADO.Id, Filter.Equal, Id);

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
