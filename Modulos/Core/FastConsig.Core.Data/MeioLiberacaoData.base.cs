
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
	public partial class MeioLiberacaoData : DataBase
	{
		
		#region Listar
		public List<MeioLiberacao> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(MeioLiberacao.METADADO.Id)
				.Field(MeioLiberacao.METADADO.Descricao)
				.Field(MeioLiberacao.METADADO.Banco)
				.Field(MeioLiberacao.METADADO.Agencia)
				.Field(MeioLiberacao.METADADO.Conta)
				.Field(MeioLiberacao.METADADO.Chave)
				.Field(MeioLiberacao.METADADO.Ativo)
				.Table(MeioLiberacao.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				List<MeioLiberacao> result = base.MapReaderToEntitySet<MeioLiberacao>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(MeioLiberacao obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(MeioLiberacao.METADADO.Descricao, obj.Descricao)
				.FieldValue(MeioLiberacao.METADADO.Banco, obj.Banco)
				.FieldValue(MeioLiberacao.METADADO.Agencia, obj.Agencia)
				.FieldValue(MeioLiberacao.METADADO.Conta, obj.Conta)
				.FieldValue(MeioLiberacao.METADADO.Chave, obj.Chave)
				.FieldValue(MeioLiberacao.METADADO.Ativo, obj.Ativo)
				.Table(MeioLiberacao.METADADO.tabelaNAME);

			update.Where
				.Add(MeioLiberacao.METADADO.Id, Filter.Equal, obj.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, update.ToString());
				update.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

		#region Inserir
		public void Incluir(MeioLiberacao obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(MeioLiberacao.METADADO.tabelaNAME)
				.FieldValue(MeioLiberacao.METADADO.Descricao, obj.Descricao)
				.FieldValue(MeioLiberacao.METADADO.Banco, obj.Banco)
				.FieldValue(MeioLiberacao.METADADO.Agencia, obj.Agencia)
				.FieldValue(MeioLiberacao.METADADO.Conta, obj.Conta)
				.FieldValue(MeioLiberacao.METADADO.Chave, obj.Chave)
				.FieldValue(MeioLiberacao.METADADO.Ativo, obj.Ativo)
				.SetIdentityField(MeioLiberacao.METADADO.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, insert.ToString());
				insert.SetParameters(cmd);

				obj.Id = base.ExecuteScalar<int?>(cmd);
			}
		}
		#endregion

		#region Obtem
		public MeioLiberacao Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(MeioLiberacao.METADADO.Id)
				.Field(MeioLiberacao.METADADO.Descricao)
				.Field(MeioLiberacao.METADADO.Banco)
				.Field(MeioLiberacao.METADADO.Agencia)
				.Field(MeioLiberacao.METADADO.Conta)
				.Field(MeioLiberacao.METADADO.Chave)
				.Field(MeioLiberacao.METADADO.Ativo)
				.Table(MeioLiberacao.METADADO.tabelaNAME);

			query.Where
				.Add(MeioLiberacao.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				MeioLiberacao result = base.MapReaderToEntity<MeioLiberacao>(cmd);
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
				delete.Table(MeioLiberacao.METADADO.tabelaNAME);
			delete.Where
				.Add(MeioLiberacao.METADADO.Id, Filter.Equal, Id);

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
