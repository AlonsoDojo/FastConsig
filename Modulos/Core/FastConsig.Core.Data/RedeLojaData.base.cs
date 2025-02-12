
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
	public partial class RedeLojaData : DataBase
	{
		
		#region Listar
		public List<RedeLoja> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(RedeLoja.METADADO.Id)
				.Field(RedeLoja.METADADO.Nome)
				.Field(RedeLoja.METADADO.Abreviatura)
				.Field(RedeLoja.METADADO.Endereco)
				.Field(RedeLoja.METADADO.Numero)
				.Field(RedeLoja.METADADO.Complemento)
				.Field(RedeLoja.METADADO.Cidade)
				.Field(RedeLoja.METADADO.Bairro)
				.Field(RedeLoja.METADADO.Estado)
				.Field(RedeLoja.METADADO.Cep)
				.Field(RedeLoja.METADADO.Cnpj)
				.Field(RedeLoja.METADADO.Promotora)
				.Table(RedeLoja.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				cmd.CommandTimeout = 600;
				query.SetParameters(cmd);

				List<RedeLoja> result = base.MapReaderToEntitySet<RedeLoja>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(RedeLoja obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(RedeLoja.METADADO.Nome, obj.Nome)
				.FieldValue(RedeLoja.METADADO.Abreviatura, obj.Abreviatura)
				.FieldValue(RedeLoja.METADADO.Endereco, obj.Endereco)
				.FieldValue(RedeLoja.METADADO.Numero, obj.Numero)
				.FieldValue(RedeLoja.METADADO.Complemento, obj.Complemento)
				.FieldValue(RedeLoja.METADADO.Cidade, obj.Cidade)
				.FieldValue(RedeLoja.METADADO.Bairro, obj.Bairro)
				.FieldValue(RedeLoja.METADADO.Estado, obj.Estado)
				.FieldValue(RedeLoja.METADADO.Cep, obj.Cep)
				.FieldValue(RedeLoja.METADADO.Cnpj, obj.Cnpj)
				.FieldValue(RedeLoja.METADADO.Promotora, obj.Promotora)
				.Table(RedeLoja.METADADO.tabelaNAME);

			update.Where
				.Add(RedeLoja.METADADO.Id, Filter.Equal, obj.Id);

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
		public void Incluir(RedeLoja obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(RedeLoja.METADADO.tabelaNAME)
				.FieldValue(RedeLoja.METADADO.Nome, obj.Nome)
				.FieldValue(RedeLoja.METADADO.Abreviatura, obj.Abreviatura)
				.FieldValue(RedeLoja.METADADO.Endereco, obj.Endereco)
				.FieldValue(RedeLoja.METADADO.Numero, obj.Numero)
				.FieldValue(RedeLoja.METADADO.Complemento, obj.Complemento)
				.FieldValue(RedeLoja.METADADO.Cidade, obj.Cidade)
				.FieldValue(RedeLoja.METADADO.Bairro, obj.Bairro)
				.FieldValue(RedeLoja.METADADO.Estado, obj.Estado)
				.FieldValue(RedeLoja.METADADO.Cep, obj.Cep)
				.FieldValue(RedeLoja.METADADO.Cnpj, obj.Cnpj)
				.FieldValue(RedeLoja.METADADO.Promotora, obj.Promotora)
				.SetIdentityField(RedeLoja.METADADO.Id);

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
		public RedeLoja Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(RedeLoja.METADADO.Id)
				.Field(RedeLoja.METADADO.Nome)
				.Field(RedeLoja.METADADO.Abreviatura)
				.Field(RedeLoja.METADADO.Endereco)
				.Field(RedeLoja.METADADO.Numero)
				.Field(RedeLoja.METADADO.Complemento)
				.Field(RedeLoja.METADADO.Cidade)
				.Field(RedeLoja.METADADO.Bairro)
				.Field(RedeLoja.METADADO.Estado)
				.Field(RedeLoja.METADADO.Cep)
				.Field(RedeLoja.METADADO.Cnpj)
				.Field(RedeLoja.METADADO.Promotora)
				.Table(RedeLoja.METADADO.tabelaNAME);

			query.Where
				.Add(RedeLoja.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				cmd.CommandTimeout = 600;
				query.SetParameters(cmd);

				RedeLoja result = base.MapReaderToEntity<RedeLoja>(cmd);
				return result;
			}
		}
		#endregion

		#region Excluir por FKs
		public void ExcluirPor_Promotora(int? Promotora)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(RedeLoja.METADADO.tabelaNAME);
			delete.Where
				.Add(RedeLoja.METADADO.Promotora, Filter.Equal, Promotora);

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
				delete.Table(RedeLoja.METADADO.tabelaNAME);
			delete.Where
				.Add(RedeLoja.METADADO.Id, Filter.Equal, Id);

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
