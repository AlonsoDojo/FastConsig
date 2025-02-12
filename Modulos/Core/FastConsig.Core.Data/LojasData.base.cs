
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
	public partial class LojasData : DataBase
	{
		
		#region Listar
		public List<Lojas> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(Lojas.METADADO.Id)
				.Field(Lojas.METADADO.RedeLoja)
				.Field(Lojas.METADADO.Loja)
				.Field(Lojas.METADADO.Nome)
				.Field(Lojas.METADADO.Abreviatura)
				.Field(Lojas.METADADO.Endereco)
				.Field(Lojas.METADADO.Numero)
				.Field(Lojas.METADADO.Complemento)
				.Field(Lojas.METADADO.Bairro)
				.Field(Lojas.METADADO.Cidade)
				.Field(Lojas.METADADO.Estado)
				.Field(Lojas.METADADO.Cep)
				.Field(Lojas.METADADO.Cnpj)
				.Table(Lojas.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				cmd.CommandTimeout = 600;
				query.SetParameters(cmd);

				List<Lojas> result = base.MapReaderToEntitySet<Lojas>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(Lojas obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(Lojas.METADADO.RedeLoja, obj.RedeLoja)
				.FieldValue(Lojas.METADADO.Loja, obj.Loja)
				.FieldValue(Lojas.METADADO.Nome, obj.Nome)
				.FieldValue(Lojas.METADADO.Abreviatura, obj.Abreviatura)
				.FieldValue(Lojas.METADADO.Endereco, obj.Endereco)
				.FieldValue(Lojas.METADADO.Numero, obj.Numero)
				.FieldValue(Lojas.METADADO.Complemento, obj.Complemento)
				.FieldValue(Lojas.METADADO.Bairro, obj.Bairro)
				.FieldValue(Lojas.METADADO.Cidade, obj.Cidade)
				.FieldValue(Lojas.METADADO.Estado, obj.Estado)
				.FieldValue(Lojas.METADADO.Cep, obj.Cep)
				.FieldValue(Lojas.METADADO.Cnpj, obj.Cnpj)
				.Table(Lojas.METADADO.tabelaNAME);

			update.Where
				.Add(Lojas.METADADO.Id, Filter.Equal, obj.Id);

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
		public void Incluir(Lojas obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(Lojas.METADADO.tabelaNAME)
				.FieldValue(Lojas.METADADO.RedeLoja, obj.RedeLoja)
				.FieldValue(Lojas.METADADO.Loja, obj.Loja)
				.FieldValue(Lojas.METADADO.Nome, obj.Nome)
				.FieldValue(Lojas.METADADO.Abreviatura, obj.Abreviatura)
				.FieldValue(Lojas.METADADO.Endereco, obj.Endereco)
				.FieldValue(Lojas.METADADO.Numero, obj.Numero)
				.FieldValue(Lojas.METADADO.Complemento, obj.Complemento)
				.FieldValue(Lojas.METADADO.Bairro, obj.Bairro)
				.FieldValue(Lojas.METADADO.Cidade, obj.Cidade)
				.FieldValue(Lojas.METADADO.Estado, obj.Estado)
				.FieldValue(Lojas.METADADO.Cep, obj.Cep)
				.FieldValue(Lojas.METADADO.Cnpj, obj.Cnpj)
				.SetIdentityField(Lojas.METADADO.Id);

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
		public Lojas Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(Lojas.METADADO.Id)
				.Field(Lojas.METADADO.RedeLoja)
				.Field(Lojas.METADADO.Loja)
				.Field(Lojas.METADADO.Nome)
				.Field(Lojas.METADADO.Abreviatura)
				.Field(Lojas.METADADO.Endereco)
				.Field(Lojas.METADADO.Numero)
				.Field(Lojas.METADADO.Complemento)
				.Field(Lojas.METADADO.Bairro)
				.Field(Lojas.METADADO.Cidade)
				.Field(Lojas.METADADO.Estado)
				.Field(Lojas.METADADO.Cep)
				.Field(Lojas.METADADO.Cnpj)
				.Table(Lojas.METADADO.tabelaNAME);

			query.Where
				.Add(Lojas.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				cmd.CommandTimeout = 600;
				query.SetParameters(cmd);

				Lojas result = base.MapReaderToEntity<Lojas>(cmd);
				return result;
			}
		}
		#endregion

		#region Excluir por FKs
		public void ExcluirPor_RedeLoja(int? RedeLoja)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(Lojas.METADADO.tabelaNAME);
			delete.Where
				.Add(Lojas.METADADO.RedeLoja, Filter.Equal, RedeLoja);

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
				delete.Table(Lojas.METADADO.tabelaNAME);
			delete.Where
				.Add(Lojas.METADADO.Id, Filter.Equal, Id);

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
