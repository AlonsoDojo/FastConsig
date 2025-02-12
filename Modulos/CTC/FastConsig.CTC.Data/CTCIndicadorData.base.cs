
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
	public partial class CTCIndicadorData : DataBase
	{
		
		#region Listar
		public List<CTCIndicador> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CTCIndicador.METADADO.Id)
				.Field(CTCIndicador.METADADO.Codigo)
				.Field(CTCIndicador.METADADO.Descricao)
				.Table(CTCIndicador.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				List<CTCIndicador> result = base.MapReaderToEntitySet<CTCIndicador>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(CTCIndicador obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(CTCIndicador.METADADO.Codigo, obj.Codigo)
				.FieldValue(CTCIndicador.METADADO.Descricao, obj.Descricao)
				.Table(CTCIndicador.METADADO.tabelaNAME);

			update.Where
				.Add(CTCIndicador.METADADO.Id, Filter.Equal, obj.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, update.ToString());
				update.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

		#region Inserir
		public void Incluir(CTCIndicador obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(CTCIndicador.METADADO.tabelaNAME)
				.FieldValue(CTCIndicador.METADADO.Codigo, obj.Codigo)
				.FieldValue(CTCIndicador.METADADO.Descricao, obj.Descricao)
				.SetIdentityField(CTCIndicador.METADADO.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, insert.ToString());
				insert.SetParameters(cmd);

				obj.Id = base.ExecuteScalar<int?>(cmd);
			}
		}
		#endregion

		#region Obtem
		public CTCIndicador Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CTCIndicador.METADADO.Id)
				.Field(CTCIndicador.METADADO.Codigo)
				.Field(CTCIndicador.METADADO.Descricao)
				.Table(CTCIndicador.METADADO.tabelaNAME);

			query.Where
				.Add(CTCIndicador.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				CTCIndicador result = base.MapReaderToEntity<CTCIndicador>(cmd);
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
				delete.Table(CTCIndicador.METADADO.tabelaNAME);
			delete.Where
				.Add(CTCIndicador.METADADO.Id, Filter.Equal, Id);

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
