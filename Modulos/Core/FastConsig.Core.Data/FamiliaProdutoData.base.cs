
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
	public partial class FamiliaProdutoData : DataBase
	{
		
		#region Listar
		public List<FamiliaProduto> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(FamiliaProduto.METADADO.Id)
				.Field(FamiliaProduto.METADADO.Descricao)
				.Table(FamiliaProduto.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				cmd.CommandTimeout = 600;
				query.SetParameters(cmd);

				List<FamiliaProduto> result = base.MapReaderToEntitySet<FamiliaProduto>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(FamiliaProduto obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(FamiliaProduto.METADADO.Descricao, obj.Descricao)
				.Table(FamiliaProduto.METADADO.tabelaNAME);

			update.Where
				.Add(FamiliaProduto.METADADO.Id, Filter.Equal, obj.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, update.ToString());
				cmd.CommandTimeout = 600;
				update.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

		#region Inserir
		public void Incluir(FamiliaProduto obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(FamiliaProduto.METADADO.tabelaNAME)
				.FieldValue(FamiliaProduto.METADADO.Descricao, obj.Descricao)
				.SetIdentityField(FamiliaProduto.METADADO.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, insert.ToString());
				cmd.CommandTimeout = 600;
				insert.SetParameters(cmd);

				obj.Id = base.ExecuteScalar<int?>(cmd);
			}
		}
		#endregion

		#region Obtem
		public FamiliaProduto Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(FamiliaProduto.METADADO.Id)
				.Field(FamiliaProduto.METADADO.Descricao)
				.Table(FamiliaProduto.METADADO.tabelaNAME);

			query.Where
				.Add(FamiliaProduto.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				cmd.CommandTimeout = 600;
				query.SetParameters(cmd);

				FamiliaProduto result = base.MapReaderToEntity<FamiliaProduto>(cmd);
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
				delete.Table(FamiliaProduto.METADADO.tabelaNAME);
			delete.Where
				.Add(FamiliaProduto.METADADO.Id, Filter.Equal, Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, delete.ToString());
				cmd.CommandTimeout = 600;
				delete.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

	}
}
