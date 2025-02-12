
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
	public partial class CTCSituacaoProcessamentoData : DataBase
	{
		
		#region Listar
		public List<CTCSituacaoProcessamento> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CTCSituacaoProcessamento.METADADO.Id)
				.Field(CTCSituacaoProcessamento.METADADO.Codigo)
				.Field(CTCSituacaoProcessamento.METADADO.Descricao)
				.Table(CTCSituacaoProcessamento.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				List<CTCSituacaoProcessamento> result = base.MapReaderToEntitySet<CTCSituacaoProcessamento>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(CTCSituacaoProcessamento obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(CTCSituacaoProcessamento.METADADO.Codigo, obj.Codigo)
				.FieldValue(CTCSituacaoProcessamento.METADADO.Descricao, obj.Descricao)
				.Table(CTCSituacaoProcessamento.METADADO.tabelaNAME);

			update.Where
				.Add(CTCSituacaoProcessamento.METADADO.Id, Filter.Equal, obj.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, update.ToString());
				update.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

		#region Inserir
		public void Incluir(CTCSituacaoProcessamento obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(CTCSituacaoProcessamento.METADADO.tabelaNAME)
				.FieldValue(CTCSituacaoProcessamento.METADADO.Codigo, obj.Codigo)
				.FieldValue(CTCSituacaoProcessamento.METADADO.Descricao, obj.Descricao)
				.SetIdentityField(CTCSituacaoProcessamento.METADADO.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, insert.ToString());
				insert.SetParameters(cmd);

				obj.Id = base.ExecuteScalar<int?>(cmd);
			}
		}
		#endregion

		#region Obtem
		public CTCSituacaoProcessamento Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CTCSituacaoProcessamento.METADADO.Id)
				.Field(CTCSituacaoProcessamento.METADADO.Codigo)
				.Field(CTCSituacaoProcessamento.METADADO.Descricao)
				.Table(CTCSituacaoProcessamento.METADADO.tabelaNAME);

			query.Where
				.Add(CTCSituacaoProcessamento.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				CTCSituacaoProcessamento result = base.MapReaderToEntity<CTCSituacaoProcessamento>(cmd);
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
				delete.Table(CTCSituacaoProcessamento.METADADO.tabelaNAME);
			delete.Where
				.Add(CTCSituacaoProcessamento.METADADO.Id, Filter.Equal, Id);

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
