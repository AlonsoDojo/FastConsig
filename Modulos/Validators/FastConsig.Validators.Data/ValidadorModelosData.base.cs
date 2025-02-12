
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
	public partial class ValidadorModelosData : DataBase
	{
		
		#region Listar
		public List<ValidadorModelos> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(ValidadorModelos.METADADO.Id)
				.Field(ValidadorModelos.METADADO.Modelo)
				.Field(ValidadorModelos.METADADO.Descricao)
				.Table(ValidadorModelos.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				List<ValidadorModelos> result = base.MapReaderToEntitySet<ValidadorModelos>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(ValidadorModelos obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(ValidadorModelos.METADADO.Modelo, obj.Modelo)
				.FieldValue(ValidadorModelos.METADADO.Descricao, obj.Descricao)
				.Table(ValidadorModelos.METADADO.tabelaNAME);

			update.Where
				.Add(ValidadorModelos.METADADO.Id, Filter.Equal, obj.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, update.ToString());
				update.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

		#region Inserir
		public void Incluir(ValidadorModelos obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(ValidadorModelos.METADADO.tabelaNAME)
				.FieldValue(ValidadorModelos.METADADO.Modelo, obj.Modelo)
				.FieldValue(ValidadorModelos.METADADO.Descricao, obj.Descricao)
				.SetIdentityField(ValidadorModelos.METADADO.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, insert.ToString());
				insert.SetParameters(cmd);

				obj.Id = base.ExecuteScalar<int?>(cmd);
			}
		}
		#endregion

		#region Obtem
		public ValidadorModelos Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(ValidadorModelos.METADADO.Id)
				.Field(ValidadorModelos.METADADO.Modelo)
				.Field(ValidadorModelos.METADADO.Descricao)
				.Table(ValidadorModelos.METADADO.tabelaNAME);

			query.Where
				.Add(ValidadorModelos.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				ValidadorModelos result = base.MapReaderToEntity<ValidadorModelos>(cmd);
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
				delete.Table(ValidadorModelos.METADADO.tabelaNAME);
			delete.Where
				.Add(ValidadorModelos.METADADO.Id, Filter.Equal, Id);

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
