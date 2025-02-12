
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
	public partial class ValidadorRulesData : DataBase
	{
		
		#region Listar
		public List<ValidadorRules> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(ValidadorRules.METADADO.Id)
				.Field(ValidadorRules.METADADO.RuleName)
				.Field(ValidadorRules.METADADO.IsList)
				.Field(ValidadorRules.METADADO.IsCustom)
				.Field(ValidadorRules.METADADO.Descricao)
				.Table(ValidadorRules.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				List<ValidadorRules> result = base.MapReaderToEntitySet<ValidadorRules>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(ValidadorRules obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(ValidadorRules.METADADO.RuleName, obj.RuleName)
				.FieldValue(ValidadorRules.METADADO.IsList, obj.IsList)
				.FieldValue(ValidadorRules.METADADO.IsCustom, obj.IsCustom)
				.FieldValue(ValidadorRules.METADADO.Descricao, obj.Descricao)
				.Table(ValidadorRules.METADADO.tabelaNAME);

			update.Where
				.Add(ValidadorRules.METADADO.Id, Filter.Equal, obj.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, update.ToString());
				update.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

		#region Inserir
		public void Incluir(ValidadorRules obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(ValidadorRules.METADADO.tabelaNAME)
				.FieldValue(ValidadorRules.METADADO.RuleName, obj.RuleName)
				.FieldValue(ValidadorRules.METADADO.IsList, obj.IsList)
				.FieldValue(ValidadorRules.METADADO.IsCustom, obj.IsCustom)
				.FieldValue(ValidadorRules.METADADO.Descricao, obj.Descricao)
				.SetIdentityField(ValidadorRules.METADADO.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, insert.ToString());
				insert.SetParameters(cmd);

				obj.Id = base.ExecuteScalar<int?>(cmd);
			}
		}
		#endregion

		#region Obtem
		public ValidadorRules Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(ValidadorRules.METADADO.Id)
				.Field(ValidadorRules.METADADO.RuleName)
				.Field(ValidadorRules.METADADO.IsList)
				.Field(ValidadorRules.METADADO.IsCustom)
				.Field(ValidadorRules.METADADO.Descricao)
				.Table(ValidadorRules.METADADO.tabelaNAME);

			query.Where
				.Add(ValidadorRules.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				ValidadorRules result = base.MapReaderToEntity<ValidadorRules>(cmd);
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
				delete.Table(ValidadorRules.METADADO.tabelaNAME);
			delete.Where
				.Add(ValidadorRules.METADADO.Id, Filter.Equal, Id);

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
