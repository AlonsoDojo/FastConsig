
#region Usings
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Framework;
using Framework.Data;
using FastConsig.Validators.Entity;
#endregion

namespace FastConsig.Validators.Data
{
	public partial class FasesProdutoValidadorData : DataBase
	{
		
		#region Listar
		public List<FasesProdutoValidador> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(FasesProdutoValidador.METADADO.Id)
				.Field(FasesProdutoValidador.METADADO.FaseProduto)
				.Field(FasesProdutoValidador.METADADO.Validador)
				.Field(FasesProdutoValidador.METADADO.Ativo)
				.Table(FasesProdutoValidador.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				List<FasesProdutoValidador> result = base.MapReaderToEntitySet<FasesProdutoValidador>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(FasesProdutoValidador obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(FasesProdutoValidador.METADADO.FaseProduto, obj.FaseProduto)
				.FieldValue(FasesProdutoValidador.METADADO.Validador, obj.Validador)
				.FieldValue(FasesProdutoValidador.METADADO.Ativo, obj.Ativo)
				.Table(FasesProdutoValidador.METADADO.tabelaNAME);

			update.Where
				.Add(FasesProdutoValidador.METADADO.Id, Filter.Equal, obj.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, update.ToString());
				update.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

		#region Inserir
		public void Incluir(FasesProdutoValidador obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(FasesProdutoValidador.METADADO.tabelaNAME)
				.FieldValue(FasesProdutoValidador.METADADO.FaseProduto, obj.FaseProduto)
				.FieldValue(FasesProdutoValidador.METADADO.Validador, obj.Validador)
				.FieldValue(FasesProdutoValidador.METADADO.Ativo, obj.Ativo)
				.SetIdentityField(FasesProdutoValidador.METADADO.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, insert.ToString());
				insert.SetParameters(cmd);

				obj.Id = base.ExecuteScalar<int?>(cmd);
			}
		}
		#endregion

		#region Obtem
		public FasesProdutoValidador Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(FasesProdutoValidador.METADADO.Id)
				.Field(FasesProdutoValidador.METADADO.FaseProduto)
				.Field(FasesProdutoValidador.METADADO.Validador)
				.Field(FasesProdutoValidador.METADADO.Ativo)
				.Table(FasesProdutoValidador.METADADO.tabelaNAME);

			query.Where
				.Add(FasesProdutoValidador.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				FasesProdutoValidador result = base.MapReaderToEntity<FasesProdutoValidador>(cmd);
				return result;
			}
		}
		#endregion

		#region Excluir por FKs
		public void ExcluirPor_FaseProduto(int? FaseProduto)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(FasesProdutoValidador.METADADO.tabelaNAME);
			delete.Where
				.Add(FasesProdutoValidador.METADADO.FaseProduto, Filter.Equal, FaseProduto);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, delete.ToString());
				delete.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		public void ExcluirPor_Validador(int? Validador)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(FasesProdutoValidador.METADADO.tabelaNAME);
			delete.Where
				.Add(FasesProdutoValidador.METADADO.Validador, Filter.Equal, Validador);

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
				delete.Table(FasesProdutoValidador.METADADO.tabelaNAME);
			delete.Where
				.Add(FasesProdutoValidador.METADADO.Id, Filter.Equal, Id);

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
