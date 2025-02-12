
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
	public partial class PoliticaParametroProdutoData : DataBase
	{
		
		#region Listar
		public List<PoliticaParametroProduto> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(PoliticaParametroProduto.METADADO.Id)
				.Field(PoliticaParametroProduto.METADADO.Politica)
				.Field(PoliticaParametroProduto.METADADO.Produto)
				.Field(PoliticaParametroProduto.METADADO.Parametros)
				.Table(PoliticaParametroProduto.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				cmd.CommandTimeout = 600;
				query.SetParameters(cmd);

				List<PoliticaParametroProduto> result = base.MapReaderToEntitySet<PoliticaParametroProduto>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(PoliticaParametroProduto obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(PoliticaParametroProduto.METADADO.Politica, obj.Politica)
				.FieldValue(PoliticaParametroProduto.METADADO.Produto, obj.Produto)
				.FieldValue(PoliticaParametroProduto.METADADO.Parametros, obj.Parametros)
				.Table(PoliticaParametroProduto.METADADO.tabelaNAME);

			update.Where
				.Add(PoliticaParametroProduto.METADADO.Id, Filter.Equal, obj.Id);

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
		public void Incluir(PoliticaParametroProduto obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(PoliticaParametroProduto.METADADO.tabelaNAME)
				.FieldValue(PoliticaParametroProduto.METADADO.Politica, obj.Politica)
				.FieldValue(PoliticaParametroProduto.METADADO.Produto, obj.Produto)
				.FieldValue(PoliticaParametroProduto.METADADO.Parametros, obj.Parametros)
				.SetIdentityField(PoliticaParametroProduto.METADADO.Id);

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
		public PoliticaParametroProduto Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(PoliticaParametroProduto.METADADO.Id)
				.Field(PoliticaParametroProduto.METADADO.Politica)
				.Field(PoliticaParametroProduto.METADADO.Produto)
				.Field(PoliticaParametroProduto.METADADO.Parametros)
				.Table(PoliticaParametroProduto.METADADO.tabelaNAME);

			query.Where
				.Add(PoliticaParametroProduto.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				cmd.CommandTimeout = 600;
				query.SetParameters(cmd);

				PoliticaParametroProduto result = base.MapReaderToEntity<PoliticaParametroProduto>(cmd);
				return result;
			}
		}
		#endregion

		#region Excluir por FKs
		public void ExcluirPor_Politica(int? Politica)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(PoliticaParametroProduto.METADADO.tabelaNAME);
			delete.Where
				.Add(PoliticaParametroProduto.METADADO.Politica, Filter.Equal, Politica);

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
				delete.Table(PoliticaParametroProduto.METADADO.tabelaNAME);
			delete.Where
				.Add(PoliticaParametroProduto.METADADO.Id, Filter.Equal, Id);

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
