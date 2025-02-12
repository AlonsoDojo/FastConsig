
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
	public partial class CheckListItensData : DataBase
	{
		
		#region Listar
		public List<CheckListItens> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CheckListItens.METADADO.Id)
				.Field(CheckListItens.METADADO.CheckList)
				.Field(CheckListItens.METADADO.Descricao)
				.Field(CheckListItens.METADADO.Obrigatorio)
				.Field(CheckListItens.METADADO.TipoDocumento)
				.Table(CheckListItens.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				List<CheckListItens> result = base.MapReaderToEntitySet<CheckListItens>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(CheckListItens obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(CheckListItens.METADADO.CheckList, obj.CheckList)
				.FieldValue(CheckListItens.METADADO.Descricao, obj.Descricao)
				.FieldValue(CheckListItens.METADADO.Obrigatorio, obj.Obrigatorio)
				.FieldValue(CheckListItens.METADADO.TipoDocumento, obj.TipoDocumento)
				.Table(CheckListItens.METADADO.tabelaNAME);

			update.Where
				.Add(CheckListItens.METADADO.Id, Filter.Equal, obj.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, update.ToString());
				update.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

		#region Inserir
		public void Incluir(CheckListItens obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(CheckListItens.METADADO.tabelaNAME)
				.FieldValue(CheckListItens.METADADO.CheckList, obj.CheckList)
				.FieldValue(CheckListItens.METADADO.Descricao, obj.Descricao)
				.FieldValue(CheckListItens.METADADO.Obrigatorio, obj.Obrigatorio)
				.FieldValue(CheckListItens.METADADO.TipoDocumento, obj.TipoDocumento)
				.SetIdentityField(CheckListItens.METADADO.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, insert.ToString());
				insert.SetParameters(cmd);

				obj.Id = base.ExecuteScalar<int?>(cmd);
			}
		}
		#endregion

		#region Obtem
		public CheckListItens Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CheckListItens.METADADO.Id)
				.Field(CheckListItens.METADADO.CheckList)
				.Field(CheckListItens.METADADO.Descricao)
				.Field(CheckListItens.METADADO.Obrigatorio)
				.Field(CheckListItens.METADADO.TipoDocumento)
				.Table(CheckListItens.METADADO.tabelaNAME);

			query.Where
				.Add(CheckListItens.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				CheckListItens result = base.MapReaderToEntity<CheckListItens>(cmd);
				return result;
			}
		}
		#endregion

		#region Excluir por FKs
		public void ExcluirPor_CheckList(int? CheckList)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(CheckListItens.METADADO.tabelaNAME);
			delete.Where
				.Add(CheckListItens.METADADO.CheckList, Filter.Equal, CheckList);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, delete.ToString());
				delete.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		public void ExcluirPor_TipoDocumento(int? TipoDocumento)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(CheckListItens.METADADO.tabelaNAME);
			delete.Where
				.Add(CheckListItens.METADADO.TipoDocumento, Filter.Equal, TipoDocumento);

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
				delete.Table(CheckListItens.METADADO.tabelaNAME);
			delete.Where
				.Add(CheckListItens.METADADO.Id, Filter.Equal, Id);

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
