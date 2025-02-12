
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
	public partial class CTC928ClienteProdutoData : DataBase
	{
		
		#region Listar
		public List<CTC928ClienteProduto> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CTC928ClienteProduto.METADADO.Id)
				.Field(CTC928ClienteProduto.METADADO.Cliente)
				.Field(CTC928ClienteProduto.METADADO.Produto)
				.Table(CTC928ClienteProduto.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				List<CTC928ClienteProduto> result = base.MapReaderToEntitySet<CTC928ClienteProduto>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(CTC928ClienteProduto obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(CTC928ClienteProduto.METADADO.Cliente, obj.Cliente)
				.FieldValue(CTC928ClienteProduto.METADADO.Produto, obj.Produto)
				.Table(CTC928ClienteProduto.METADADO.tabelaNAME);

			update.Where
				.Add(CTC928ClienteProduto.METADADO.Id, Filter.Equal, obj.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, update.ToString());
				update.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

		#region Inserir
		public void Incluir(CTC928ClienteProduto obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(CTC928ClienteProduto.METADADO.tabelaNAME)
				.FieldValue(CTC928ClienteProduto.METADADO.Cliente, obj.Cliente)
				.FieldValue(CTC928ClienteProduto.METADADO.Produto, obj.Produto)
				.SetIdentityField(CTC928ClienteProduto.METADADO.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, insert.ToString());
				insert.SetParameters(cmd);

				obj.Id = base.ExecuteScalar<int?>(cmd);
			}
		}
		#endregion

		#region Obtem
		public CTC928ClienteProduto Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CTC928ClienteProduto.METADADO.Id)
				.Field(CTC928ClienteProduto.METADADO.Cliente)
				.Field(CTC928ClienteProduto.METADADO.Produto)
				.Table(CTC928ClienteProduto.METADADO.tabelaNAME);

			query.Where
				.Add(CTC928ClienteProduto.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				CTC928ClienteProduto result = base.MapReaderToEntity<CTC928ClienteProduto>(cmd);
				return result;
			}
		}
		#endregion

		#region Excluir por FKs
		public void ExcluirPor_Cliente(int? Cliente)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(CTC928ClienteProduto.METADADO.tabelaNAME);
			delete.Where
				.Add(CTC928ClienteProduto.METADADO.Cliente, Filter.Equal, Cliente);

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
				delete.Table(CTC928ClienteProduto.METADADO.tabelaNAME);
			delete.Where
				.Add(CTC928ClienteProduto.METADADO.Id, Filter.Equal, Id);

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
