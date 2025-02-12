
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
	public partial class ValidadorCamposData : DataBase
	{
		
		#region Listar
		public List<ValidadorCampos> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(ValidadorCampos.METADADO.Id)
				.Field(ValidadorCampos.METADADO.Validador)
				.Field(ValidadorCampos.METADADO.Modelo)
				.Field(ValidadorCampos.METADADO.CampoModelo)
				.Field(ValidadorCampos.METADADO.Rule)
				.Field(ValidadorCampos.METADADO.Parametro1)
				.Field(ValidadorCampos.METADADO.Parametro2)
				.Field(ValidadorCampos.METADADO.Parametro3)
				.Table(ValidadorCampos.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				List<ValidadorCampos> result = base.MapReaderToEntitySet<ValidadorCampos>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(ValidadorCampos obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(ValidadorCampos.METADADO.Validador, obj.Validador)
				.FieldValue(ValidadorCampos.METADADO.Modelo, obj.Modelo)
				.FieldValue(ValidadorCampos.METADADO.CampoModelo, obj.CampoModelo)
				.FieldValue(ValidadorCampos.METADADO.Rule, obj.Rule)
				.FieldValue(ValidadorCampos.METADADO.Parametro1, obj.Parametro1)
				.FieldValue(ValidadorCampos.METADADO.Parametro2, obj.Parametro2)
				.FieldValue(ValidadorCampos.METADADO.Parametro3, obj.Parametro3)
				.Table(ValidadorCampos.METADADO.tabelaNAME);

			update.Where
				.Add(ValidadorCampos.METADADO.Id, Filter.Equal, obj.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, update.ToString());
				update.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

		#region Inserir
		public void Incluir(ValidadorCampos obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(ValidadorCampos.METADADO.tabelaNAME)
				.FieldValue(ValidadorCampos.METADADO.Validador, obj.Validador)
				.FieldValue(ValidadorCampos.METADADO.Modelo, obj.Modelo)
				.FieldValue(ValidadorCampos.METADADO.CampoModelo, obj.CampoModelo)
				.FieldValue(ValidadorCampos.METADADO.Rule, obj.Rule)
				.FieldValue(ValidadorCampos.METADADO.Parametro1, obj.Parametro1)
				.FieldValue(ValidadorCampos.METADADO.Parametro2, obj.Parametro2)
				.FieldValue(ValidadorCampos.METADADO.Parametro3, obj.Parametro3)
				.SetIdentityField(ValidadorCampos.METADADO.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, insert.ToString());
				insert.SetParameters(cmd);

				obj.Id = base.ExecuteScalar<int?>(cmd);
			}
		}
		#endregion

		#region Obtem
		public ValidadorCampos Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(ValidadorCampos.METADADO.Id)
				.Field(ValidadorCampos.METADADO.Validador)
				.Field(ValidadorCampos.METADADO.Modelo)
				.Field(ValidadorCampos.METADADO.CampoModelo)
				.Field(ValidadorCampos.METADADO.Rule)
				.Field(ValidadorCampos.METADADO.Parametro1)
				.Field(ValidadorCampos.METADADO.Parametro2)
				.Field(ValidadorCampos.METADADO.Parametro3)
				.Table(ValidadorCampos.METADADO.tabelaNAME);

			query.Where
				.Add(ValidadorCampos.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				ValidadorCampos result = base.MapReaderToEntity<ValidadorCampos>(cmd);
				return result;
			}
		}
		#endregion

		#region Excluir por FKs
		public void ExcluirPor_Validador(int? Validador)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(ValidadorCampos.METADADO.tabelaNAME);
			delete.Where
				.Add(ValidadorCampos.METADADO.Validador, Filter.Equal, Validador);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, delete.ToString());
				delete.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		public void ExcluirPor_Modelo(int? Modelo)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(ValidadorCampos.METADADO.tabelaNAME);
			delete.Where
				.Add(ValidadorCampos.METADADO.Modelo, Filter.Equal, Modelo);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, delete.ToString());
				delete.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		public void ExcluirPor_CampoModelo(int? CampoModelo)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(ValidadorCampos.METADADO.tabelaNAME);
			delete.Where
				.Add(ValidadorCampos.METADADO.CampoModelo, Filter.Equal, CampoModelo);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, delete.ToString());
				delete.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		public void ExcluirPor_Rule(int? Rule)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(ValidadorCampos.METADADO.tabelaNAME);
			delete.Where
				.Add(ValidadorCampos.METADADO.Rule, Filter.Equal, Rule);

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
				delete.Table(ValidadorCampos.METADADO.tabelaNAME);
			delete.Where
				.Add(ValidadorCampos.METADADO.Id, Filter.Equal, Id);

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
