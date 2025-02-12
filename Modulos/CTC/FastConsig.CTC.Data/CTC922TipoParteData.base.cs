
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
	public partial class CTC922TipoParteData : DataBase
	{
		
		#region Listar
		public List<CTC922TipoParte> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CTC922TipoParte.METADADO.Id)
				.Field(CTC922TipoParte.METADADO.Descricao)
				.Table(CTC922TipoParte.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				List<CTC922TipoParte> result = base.MapReaderToEntitySet<CTC922TipoParte>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(CTC922TipoParte obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(CTC922TipoParte.METADADO.Descricao, obj.Descricao)
				.Table(CTC922TipoParte.METADADO.tabelaNAME);

			update.Where
				.Add(CTC922TipoParte.METADADO.Id, Filter.Equal, obj.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, update.ToString());
				update.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

		#region Inserir
		public void Incluir(CTC922TipoParte obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(CTC922TipoParte.METADADO.tabelaNAME)
				.FieldValue(CTC922TipoParte.METADADO.Descricao, obj.Descricao)
				.SetIdentityField(CTC922TipoParte.METADADO.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, insert.ToString());
				insert.SetParameters(cmd);

				obj.Id = base.ExecuteScalar<int?>(cmd);
			}
		}
		#endregion

		#region Obtem
		public CTC922TipoParte Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CTC922TipoParte.METADADO.Id)
				.Field(CTC922TipoParte.METADADO.Descricao)
				.Table(CTC922TipoParte.METADADO.tabelaNAME);

			query.Where
				.Add(CTC922TipoParte.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				CTC922TipoParte result = base.MapReaderToEntity<CTC922TipoParte>(cmd);
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
				delete.Table(CTC922TipoParte.METADADO.tabelaNAME);
			delete.Where
				.Add(CTC922TipoParte.METADADO.Id, Filter.Equal, Id);

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
