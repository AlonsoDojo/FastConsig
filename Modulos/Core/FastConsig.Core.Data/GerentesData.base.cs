
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
	public partial class GerentesData : DataBase
	{
		
		#region Listar
		public List<Gerentes> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(Gerentes.METADADO.Id)
				.Field(Gerentes.METADADO.Nome)
				.Field(Gerentes.METADADO.Cpf)
				.Table(Gerentes.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				cmd.CommandTimeout = 600;
				query.SetParameters(cmd);

				List<Gerentes> result = base.MapReaderToEntitySet<Gerentes>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(Gerentes obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(Gerentes.METADADO.Nome, obj.Nome)
				.FieldValue(Gerentes.METADADO.Cpf, obj.Cpf)
				.Table(Gerentes.METADADO.tabelaNAME);

			update.Where
				.Add(Gerentes.METADADO.Id, Filter.Equal, obj.Id);

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
		public void Incluir(Gerentes obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(Gerentes.METADADO.tabelaNAME)
				.FieldValue(Gerentes.METADADO.Nome, obj.Nome)
				.FieldValue(Gerentes.METADADO.Cpf, obj.Cpf)
				.SetIdentityField(Gerentes.METADADO.Id);

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
		public Gerentes Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(Gerentes.METADADO.Id)
				.Field(Gerentes.METADADO.Nome)
				.Field(Gerentes.METADADO.Cpf)
				.Table(Gerentes.METADADO.tabelaNAME);

			query.Where
				.Add(Gerentes.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				cmd.CommandTimeout = 600;
				query.SetParameters(cmd);

				Gerentes result = base.MapReaderToEntity<Gerentes>(cmd);
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
				delete.Table(Gerentes.METADADO.tabelaNAME);
			delete.Where
				.Add(Gerentes.METADADO.Id, Filter.Equal, Id);

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
