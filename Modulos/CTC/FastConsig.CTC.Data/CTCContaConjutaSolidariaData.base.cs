
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
	public partial class CTCContaConjutaSolidariaData : DataBase
	{
		
		#region Listar
		public List<CTCContaConjutaSolidaria> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CTCContaConjutaSolidaria.METADADO.Id)
				.Field(CTCContaConjutaSolidaria.METADADO.Codigo)
				.Field(CTCContaConjutaSolidaria.METADADO.Descricao)
				.Table(CTCContaConjutaSolidaria.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				List<CTCContaConjutaSolidaria> result = base.MapReaderToEntitySet<CTCContaConjutaSolidaria>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(CTCContaConjutaSolidaria obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(CTCContaConjutaSolidaria.METADADO.Codigo, obj.Codigo)
				.FieldValue(CTCContaConjutaSolidaria.METADADO.Descricao, obj.Descricao)
				.Table(CTCContaConjutaSolidaria.METADADO.tabelaNAME);

			update.Where
				.Add(CTCContaConjutaSolidaria.METADADO.Id, Filter.Equal, obj.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, update.ToString());
				update.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

		#region Inserir
		public void Incluir(CTCContaConjutaSolidaria obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(CTCContaConjutaSolidaria.METADADO.tabelaNAME)
				.FieldValue(CTCContaConjutaSolidaria.METADADO.Codigo, obj.Codigo)
				.FieldValue(CTCContaConjutaSolidaria.METADADO.Descricao, obj.Descricao)
				.SetIdentityField(CTCContaConjutaSolidaria.METADADO.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, insert.ToString());
				insert.SetParameters(cmd);

				obj.Id = base.ExecuteScalar<int?>(cmd);
			}
		}
		#endregion

		#region Obtem
		public CTCContaConjutaSolidaria Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CTCContaConjutaSolidaria.METADADO.Id)
				.Field(CTCContaConjutaSolidaria.METADADO.Codigo)
				.Field(CTCContaConjutaSolidaria.METADADO.Descricao)
				.Table(CTCContaConjutaSolidaria.METADADO.tabelaNAME);

			query.Where
				.Add(CTCContaConjutaSolidaria.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				CTCContaConjutaSolidaria result = base.MapReaderToEntity<CTCContaConjutaSolidaria>(cmd);
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
				delete.Table(CTCContaConjutaSolidaria.METADADO.tabelaNAME);
			delete.Where
				.Add(CTCContaConjutaSolidaria.METADADO.Id, Filter.Equal, Id);

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
