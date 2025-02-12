
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
	public partial class CTCRegimeAmortizacaoData : DataBase
	{
		
		#region Listar
		public List<CTCRegimeAmortizacao> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CTCRegimeAmortizacao.METADADO.Id)
				.Field(CTCRegimeAmortizacao.METADADO.Codigo)
				.Field(CTCRegimeAmortizacao.METADADO.Descricao)
				.Table(CTCRegimeAmortizacao.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				List<CTCRegimeAmortizacao> result = base.MapReaderToEntitySet<CTCRegimeAmortizacao>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(CTCRegimeAmortizacao obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(CTCRegimeAmortizacao.METADADO.Codigo, obj.Codigo)
				.FieldValue(CTCRegimeAmortizacao.METADADO.Descricao, obj.Descricao)
				.Table(CTCRegimeAmortizacao.METADADO.tabelaNAME);

			update.Where
				.Add(CTCRegimeAmortizacao.METADADO.Id, Filter.Equal, obj.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, update.ToString());
				update.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

		#region Inserir
		public void Incluir(CTCRegimeAmortizacao obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(CTCRegimeAmortizacao.METADADO.tabelaNAME)
				.FieldValue(CTCRegimeAmortizacao.METADADO.Codigo, obj.Codigo)
				.FieldValue(CTCRegimeAmortizacao.METADADO.Descricao, obj.Descricao)
				.SetIdentityField(CTCRegimeAmortizacao.METADADO.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, insert.ToString());
				insert.SetParameters(cmd);

				obj.Id = base.ExecuteScalar<int?>(cmd);
			}
		}
		#endregion

		#region Obtem
		public CTCRegimeAmortizacao Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CTCRegimeAmortizacao.METADADO.Id)
				.Field(CTCRegimeAmortizacao.METADADO.Codigo)
				.Field(CTCRegimeAmortizacao.METADADO.Descricao)
				.Table(CTCRegimeAmortizacao.METADADO.tabelaNAME);

			query.Where
				.Add(CTCRegimeAmortizacao.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				CTCRegimeAmortizacao result = base.MapReaderToEntity<CTCRegimeAmortizacao>(cmd);
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
				delete.Table(CTCRegimeAmortizacao.METADADO.tabelaNAME);
			delete.Where
				.Add(CTCRegimeAmortizacao.METADADO.Id, Filter.Equal, Id);

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
