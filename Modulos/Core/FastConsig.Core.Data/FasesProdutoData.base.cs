
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
	public partial class FasesProdutoData : DataBase
	{
		
		#region Listar
		public List<FasesProduto> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(FasesProduto.METADADO.Id)
				.Field(FasesProduto.METADADO.Produto)
				.Field(FasesProduto.METADADO.Fase)
				.Field(FasesProduto.METADADO.Ordem)
				.Table(FasesProduto.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				cmd.CommandTimeout = 600;
				query.SetParameters(cmd);

				List<FasesProduto> result = base.MapReaderToEntitySet<FasesProduto>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(FasesProduto obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(FasesProduto.METADADO.Produto, obj.Produto)
				.FieldValue(FasesProduto.METADADO.Fase, obj.Fase)
				.FieldValue(FasesProduto.METADADO.Ordem, obj.Ordem)
				.Table(FasesProduto.METADADO.tabelaNAME);

			update.Where
				.Add(FasesProduto.METADADO.Id, Filter.Equal, obj.Id);

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
		public void Incluir(FasesProduto obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(FasesProduto.METADADO.tabelaNAME)
				.FieldValue(FasesProduto.METADADO.Produto, obj.Produto)
				.FieldValue(FasesProduto.METADADO.Fase, obj.Fase)
				.FieldValue(FasesProduto.METADADO.Ordem, obj.Ordem)
				.SetIdentityField(FasesProduto.METADADO.Id);

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
		public FasesProduto Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(FasesProduto.METADADO.Id)
				.Field(FasesProduto.METADADO.Produto)
				.Field(FasesProduto.METADADO.Fase)
				.Field(FasesProduto.METADADO.Ordem)
				.Table(FasesProduto.METADADO.tabelaNAME);

			query.Where
				.Add(FasesProduto.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				cmd.CommandTimeout = 600;
				query.SetParameters(cmd);

				FasesProduto result = base.MapReaderToEntity<FasesProduto>(cmd);
				return result;
			}
		}
		#endregion

		#region Excluir por FKs
		public void ExcluirPor_Produto(int? Produto)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(FasesProduto.METADADO.tabelaNAME);
			delete.Where
				.Add(FasesProduto.METADADO.Produto, Filter.Equal, Produto);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, delete.ToString());
				cmd.CommandTimeout = 600;
				delete.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		public void ExcluirPor_Fase(int? Fase)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(FasesProduto.METADADO.tabelaNAME);
			delete.Where
				.Add(FasesProduto.METADADO.Fase, Filter.Equal, Fase);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, delete.ToString());
				cmd.CommandTimeout = 600;
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
				delete.Table(FasesProduto.METADADO.tabelaNAME);
			delete.Where
				.Add(FasesProduto.METADADO.Id, Filter.Equal, Id);

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
