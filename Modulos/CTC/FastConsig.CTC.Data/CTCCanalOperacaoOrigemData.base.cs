
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
	public partial class CTCCanalOperacaoOrigemData : DataBase
	{
		
		#region Listar
		public List<CTCCanalOperacaoOrigem> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CTCCanalOperacaoOrigem.METADADO.Id)
				.Field(CTCCanalOperacaoOrigem.METADADO.Codigo)
				.Field(CTCCanalOperacaoOrigem.METADADO.Descricao)
				.Table(CTCCanalOperacaoOrigem.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				List<CTCCanalOperacaoOrigem> result = base.MapReaderToEntitySet<CTCCanalOperacaoOrigem>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(CTCCanalOperacaoOrigem obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(CTCCanalOperacaoOrigem.METADADO.Codigo, obj.Codigo)
				.FieldValue(CTCCanalOperacaoOrigem.METADADO.Descricao, obj.Descricao)
				.Table(CTCCanalOperacaoOrigem.METADADO.tabelaNAME);

			update.Where
				.Add(CTCCanalOperacaoOrigem.METADADO.Id, Filter.Equal, obj.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, update.ToString());
				update.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

		#region Inserir
		public void Incluir(CTCCanalOperacaoOrigem obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(CTCCanalOperacaoOrigem.METADADO.tabelaNAME)
				.FieldValue(CTCCanalOperacaoOrigem.METADADO.Codigo, obj.Codigo)
				.FieldValue(CTCCanalOperacaoOrigem.METADADO.Descricao, obj.Descricao)
				.SetIdentityField(CTCCanalOperacaoOrigem.METADADO.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, insert.ToString());
				insert.SetParameters(cmd);

				obj.Id = base.ExecuteScalar<int?>(cmd);
			}
		}
		#endregion

		#region Obtem
		public CTCCanalOperacaoOrigem Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CTCCanalOperacaoOrigem.METADADO.Id)
				.Field(CTCCanalOperacaoOrigem.METADADO.Codigo)
				.Field(CTCCanalOperacaoOrigem.METADADO.Descricao)
				.Table(CTCCanalOperacaoOrigem.METADADO.tabelaNAME);

			query.Where
				.Add(CTCCanalOperacaoOrigem.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				CTCCanalOperacaoOrigem result = base.MapReaderToEntity<CTCCanalOperacaoOrigem>(cmd);
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
				delete.Table(CTCCanalOperacaoOrigem.METADADO.tabelaNAME);
			delete.Where
				.Add(CTCCanalOperacaoOrigem.METADADO.Id, Filter.Equal, Id);

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
