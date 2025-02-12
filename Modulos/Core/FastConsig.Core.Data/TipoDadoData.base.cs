
#region Usings
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Framework;
using Framework.Data;
using FastConsig.Core.Entity;
#endregion

namespace FastConsig.Core.Data
{
	public partial class TipoDadoData : DataBase
	{
		
		#region Listar
		public List<TipoDado> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(TipoDado.METADADO.Id)
				.Field(TipoDado.METADADO.Descricao)
				.Field(TipoDado.METADADO.Mapper)
				.Table(TipoDado.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				List<TipoDado> result = base.MapReaderToEntitySet<TipoDado>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(TipoDado obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(TipoDado.METADADO.Descricao, obj.Descricao)
				.FieldValue(TipoDado.METADADO.Mapper, obj.Mapper)
				.Table(TipoDado.METADADO.tabelaNAME);

			update.Where
				.Add(TipoDado.METADADO.Id, Filter.Equal, obj.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, update.ToString());
				update.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

		#region Inserir
		public void Incluir(TipoDado obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(TipoDado.METADADO.tabelaNAME)
				.FieldValue(TipoDado.METADADO.Descricao, obj.Descricao)
				.FieldValue(TipoDado.METADADO.Mapper, obj.Mapper)
				.SetIdentityField(TipoDado.METADADO.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, insert.ToString());
				insert.SetParameters(cmd);

				obj.Id = base.ExecuteScalar<int?>(cmd);
			}
		}
		#endregion

		#region Obtem
		public TipoDado Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(TipoDado.METADADO.Id)
				.Field(TipoDado.METADADO.Descricao)
				.Field(TipoDado.METADADO.Mapper)
				.Table(TipoDado.METADADO.tabelaNAME);

			query.Where
				.Add(TipoDado.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				TipoDado result = base.MapReaderToEntity<TipoDado>(cmd);
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
				delete.Table(TipoDado.METADADO.tabelaNAME);
			delete.Where
				.Add(TipoDado.METADADO.Id, Filter.Equal, Id);

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
