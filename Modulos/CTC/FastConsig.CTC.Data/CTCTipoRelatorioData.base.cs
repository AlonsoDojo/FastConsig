
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
	public partial class CTCTipoRelatorioData : DataBase
	{
		
		#region Listar
		public List<CTCTipoRelatorio> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CTCTipoRelatorio.METADADO.Id)
				.Field(CTCTipoRelatorio.METADADO.Codigo)
				.Field(CTCTipoRelatorio.METADADO.Descricao)
				.Table(CTCTipoRelatorio.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				List<CTCTipoRelatorio> result = base.MapReaderToEntitySet<CTCTipoRelatorio>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(CTCTipoRelatorio obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(CTCTipoRelatorio.METADADO.Codigo, obj.Codigo)
				.FieldValue(CTCTipoRelatorio.METADADO.Descricao, obj.Descricao)
				.Table(CTCTipoRelatorio.METADADO.tabelaNAME);

			update.Where
				.Add(CTCTipoRelatorio.METADADO.Id, Filter.Equal, obj.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, update.ToString());
				update.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

		#region Inserir
		public void Incluir(CTCTipoRelatorio obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(CTCTipoRelatorio.METADADO.tabelaNAME)
				.FieldValue(CTCTipoRelatorio.METADADO.Codigo, obj.Codigo)
				.FieldValue(CTCTipoRelatorio.METADADO.Descricao, obj.Descricao)
				.SetIdentityField(CTCTipoRelatorio.METADADO.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, insert.ToString());
				insert.SetParameters(cmd);

				obj.Id = base.ExecuteScalar<int?>(cmd);
			}
		}
		#endregion

		#region Obtem
		public CTCTipoRelatorio Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CTCTipoRelatorio.METADADO.Id)
				.Field(CTCTipoRelatorio.METADADO.Codigo)
				.Field(CTCTipoRelatorio.METADADO.Descricao)
				.Table(CTCTipoRelatorio.METADADO.tabelaNAME);

			query.Where
				.Add(CTCTipoRelatorio.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				CTCTipoRelatorio result = base.MapReaderToEntity<CTCTipoRelatorio>(cmd);
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
				delete.Table(CTCTipoRelatorio.METADADO.tabelaNAME);
			delete.Where
				.Add(CTCTipoRelatorio.METADADO.Id, Filter.Equal, Id);

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
