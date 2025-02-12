
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
	public partial class CTCContasData : DataBase
	{
		
		#region Listar
		public List<CTCContas> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CTCContas.METADADO.Id)
				.Field(CTCContas.METADADO.ISPB)
				.Field(CTCContas.METADADO.Descricao)
				.Field(CTCContas.METADADO.CNPJ)
				.Field(CTCContas.METADADO.Banco)
				.Field(CTCContas.METADADO.Agencia)
				.Field(CTCContas.METADADO.Conta)
				.Field(CTCContas.METADADO.Ativo)
				.Table(CTCContas.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				List<CTCContas> result = base.MapReaderToEntitySet<CTCContas>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(CTCContas obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(CTCContas.METADADO.ISPB, obj.ISPB)
				.FieldValue(CTCContas.METADADO.Descricao, obj.Descricao)
				.FieldValue(CTCContas.METADADO.CNPJ, obj.CNPJ)
				.FieldValue(CTCContas.METADADO.Banco, obj.Banco)
				.FieldValue(CTCContas.METADADO.Agencia, obj.Agencia)
				.FieldValue(CTCContas.METADADO.Conta, obj.Conta)
				.FieldValue(CTCContas.METADADO.Ativo, obj.Ativo)
				.Table(CTCContas.METADADO.tabelaNAME);

			update.Where
				.Add(CTCContas.METADADO.Id, Filter.Equal, obj.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, update.ToString());
				update.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

		#region Inserir
		public void Incluir(CTCContas obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(CTCContas.METADADO.tabelaNAME)
				.FieldValue(CTCContas.METADADO.ISPB, obj.ISPB)
				.FieldValue(CTCContas.METADADO.Descricao, obj.Descricao)
				.FieldValue(CTCContas.METADADO.CNPJ, obj.CNPJ)
				.FieldValue(CTCContas.METADADO.Banco, obj.Banco)
				.FieldValue(CTCContas.METADADO.Agencia, obj.Agencia)
				.FieldValue(CTCContas.METADADO.Conta, obj.Conta)
				.FieldValue(CTCContas.METADADO.Ativo, obj.Ativo)
				.SetIdentityField(CTCContas.METADADO.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, insert.ToString());
				insert.SetParameters(cmd);

				obj.Id = base.ExecuteScalar<int?>(cmd);
			}
		}
		#endregion

		#region Obtem
		public CTCContas Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CTCContas.METADADO.Id)
				.Field(CTCContas.METADADO.ISPB)
				.Field(CTCContas.METADADO.Descricao)
				.Field(CTCContas.METADADO.CNPJ)
				.Field(CTCContas.METADADO.Banco)
				.Field(CTCContas.METADADO.Agencia)
				.Field(CTCContas.METADADO.Conta)
				.Field(CTCContas.METADADO.Ativo)
				.Table(CTCContas.METADADO.tabelaNAME);

			query.Where
				.Add(CTCContas.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				CTCContas result = base.MapReaderToEntity<CTCContas>(cmd);
				return result;
			}
		}
		#endregion

		#region Excluir por FKs
		public void ExcluirPor_Banco(string Banco)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(CTCContas.METADADO.tabelaNAME);
			delete.Where
				.Add(CTCContas.METADADO.Banco, Filter.Equal, Banco);

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
				delete.Table(CTCContas.METADADO.tabelaNAME);
			delete.Where
				.Add(CTCContas.METADADO.Id, Filter.Equal, Id);

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
