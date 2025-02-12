
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
	public partial class ValidadorModelosCamposData : DataBase
	{
		
		#region Listar
		public List<ValidadorModelosCampos> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(ValidadorModelosCampos.METADADO.Id)
				.Field(ValidadorModelosCampos.METADADO.Modelo)
				.Field(ValidadorModelosCampos.METADADO.NomePropriedade)
				.Field(ValidadorModelosCampos.METADADO.Descricao)
				.Field(ValidadorModelosCampos.METADADO.TipoDado)
				.Field(ValidadorModelosCampos.METADADO.IsList)
				.Table(ValidadorModelosCampos.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				List<ValidadorModelosCampos> result = base.MapReaderToEntitySet<ValidadorModelosCampos>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(ValidadorModelosCampos obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(ValidadorModelosCampos.METADADO.Modelo, obj.Modelo)
				.FieldValue(ValidadorModelosCampos.METADADO.NomePropriedade, obj.NomePropriedade)
				.FieldValue(ValidadorModelosCampos.METADADO.Descricao, obj.Descricao)
				.FieldValue(ValidadorModelosCampos.METADADO.TipoDado, obj.TipoDado)
				.FieldValue(ValidadorModelosCampos.METADADO.IsList, obj.IsList)
				.Table(ValidadorModelosCampos.METADADO.tabelaNAME);

			update.Where
				.Add(ValidadorModelosCampos.METADADO.Id, Filter.Equal, obj.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, update.ToString());
				update.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

		#region Inserir
		public void Incluir(ValidadorModelosCampos obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(ValidadorModelosCampos.METADADO.tabelaNAME)
				.FieldValue(ValidadorModelosCampos.METADADO.Modelo, obj.Modelo)
				.FieldValue(ValidadorModelosCampos.METADADO.NomePropriedade, obj.NomePropriedade)
				.FieldValue(ValidadorModelosCampos.METADADO.Descricao, obj.Descricao)
				.FieldValue(ValidadorModelosCampos.METADADO.TipoDado, obj.TipoDado)
				.FieldValue(ValidadorModelosCampos.METADADO.IsList, obj.IsList)
				.SetIdentityField(ValidadorModelosCampos.METADADO.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, insert.ToString());
				insert.SetParameters(cmd);

				obj.Id = base.ExecuteScalar<int?>(cmd);
			}
		}
		#endregion

		#region Obtem
		public ValidadorModelosCampos Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(ValidadorModelosCampos.METADADO.Id)
				.Field(ValidadorModelosCampos.METADADO.Modelo)
				.Field(ValidadorModelosCampos.METADADO.NomePropriedade)
				.Field(ValidadorModelosCampos.METADADO.Descricao)
				.Field(ValidadorModelosCampos.METADADO.TipoDado)
				.Field(ValidadorModelosCampos.METADADO.IsList)
				.Table(ValidadorModelosCampos.METADADO.tabelaNAME);

			query.Where
				.Add(ValidadorModelosCampos.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				ValidadorModelosCampos result = base.MapReaderToEntity<ValidadorModelosCampos>(cmd);
				return result;
			}
		}
		#endregion

		#region Excluir por FKs
		public void ExcluirPor_Modelo(int? Modelo)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(ValidadorModelosCampos.METADADO.tabelaNAME);
			delete.Where
				.Add(ValidadorModelosCampos.METADADO.Modelo, Filter.Equal, Modelo);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, delete.ToString());
				delete.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		public void ExcluirPor_TipoDado(int? TipoDado)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(ValidadorModelosCampos.METADADO.tabelaNAME);
			delete.Where
				.Add(ValidadorModelosCampos.METADADO.TipoDado, Filter.Equal, TipoDado);

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
				delete.Table(ValidadorModelosCampos.METADADO.tabelaNAME);
			delete.Where
				.Add(ValidadorModelosCampos.METADADO.Id, Filter.Equal, Id);

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
