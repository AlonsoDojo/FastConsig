
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
	public partial class TipoPessoaData : DataBase
	{
		
		#region Listar
		public List<TipoPessoa> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(TipoPessoa.METADADO.Id)
				.Field(TipoPessoa.METADADO.Codigo)
				.Field(TipoPessoa.METADADO.Descricao)
				.Table(TipoPessoa.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				cmd.CommandTimeout = 600;
				query.SetParameters(cmd);

				List<TipoPessoa> result = base.MapReaderToEntitySet<TipoPessoa>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(TipoPessoa obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(TipoPessoa.METADADO.Codigo, obj.Codigo)
				.FieldValue(TipoPessoa.METADADO.Descricao, obj.Descricao)
				.Table(TipoPessoa.METADADO.tabelaNAME);

			update.Where
				.Add(TipoPessoa.METADADO.Id, Filter.Equal, obj.Id);

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
		public void Incluir(TipoPessoa obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(TipoPessoa.METADADO.tabelaNAME)
				.FieldValue(TipoPessoa.METADADO.Codigo, obj.Codigo)
				.FieldValue(TipoPessoa.METADADO.Descricao, obj.Descricao)
				.SetIdentityField(TipoPessoa.METADADO.Id);

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
		public TipoPessoa Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(TipoPessoa.METADADO.Id)
				.Field(TipoPessoa.METADADO.Codigo)
				.Field(TipoPessoa.METADADO.Descricao)
				.Table(TipoPessoa.METADADO.tabelaNAME);

			query.Where
				.Add(TipoPessoa.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				cmd.CommandTimeout = 600;
				query.SetParameters(cmd);

				TipoPessoa result = base.MapReaderToEntity<TipoPessoa>(cmd);
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
				delete.Table(TipoPessoa.METADADO.tabelaNAME);
			delete.Where
				.Add(TipoPessoa.METADADO.Id, Filter.Equal, Id);

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
