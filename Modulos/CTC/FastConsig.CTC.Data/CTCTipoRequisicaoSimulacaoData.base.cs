
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
	public partial class CTCTipoRequisicaoSimulacaoData : DataBase
	{
		
		#region Listar
		public List<CTCTipoRequisicaoSimulacao> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CTCTipoRequisicaoSimulacao.METADADO.Id)
				.Field(CTCTipoRequisicaoSimulacao.METADADO.Descricao)
				.Table(CTCTipoRequisicaoSimulacao.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				List<CTCTipoRequisicaoSimulacao> result = base.MapReaderToEntitySet<CTCTipoRequisicaoSimulacao>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(CTCTipoRequisicaoSimulacao obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(CTCTipoRequisicaoSimulacao.METADADO.Descricao, obj.Descricao)
				.Table(CTCTipoRequisicaoSimulacao.METADADO.tabelaNAME);

			update.Where
				.Add(CTCTipoRequisicaoSimulacao.METADADO.Id, Filter.Equal, obj.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, update.ToString());
				update.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

		#region Inserir
		public void Incluir(CTCTipoRequisicaoSimulacao obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(CTCTipoRequisicaoSimulacao.METADADO.tabelaNAME)
				.FieldValue(CTCTipoRequisicaoSimulacao.METADADO.Descricao, obj.Descricao)
				.SetIdentityField(CTCTipoRequisicaoSimulacao.METADADO.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, insert.ToString());
				insert.SetParameters(cmd);

				obj.Id = base.ExecuteScalar<int?>(cmd);
			}
		}
		#endregion

		#region Obtem
		public CTCTipoRequisicaoSimulacao Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CTCTipoRequisicaoSimulacao.METADADO.Id)
				.Field(CTCTipoRequisicaoSimulacao.METADADO.Descricao)
				.Table(CTCTipoRequisicaoSimulacao.METADADO.tabelaNAME);

			query.Where
				.Add(CTCTipoRequisicaoSimulacao.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				CTCTipoRequisicaoSimulacao result = base.MapReaderToEntity<CTCTipoRequisicaoSimulacao>(cmd);
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
				delete.Table(CTCTipoRequisicaoSimulacao.METADADO.tabelaNAME);
			delete.Where
				.Add(CTCTipoRequisicaoSimulacao.METADADO.Id, Filter.Equal, Id);

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
