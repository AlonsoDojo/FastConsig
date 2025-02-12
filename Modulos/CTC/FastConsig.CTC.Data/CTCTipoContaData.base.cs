
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
	public partial class CTCTipoContaData : DataBase
	{
		
		#region Listar
		public List<CTCTipoConta> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CTCTipoConta.METADADO.Id)
				.Field(CTCTipoConta.METADADO.Codigo)
				.Field(CTCTipoConta.METADADO.Descricao)
				.Table(CTCTipoConta.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				List<CTCTipoConta> result = base.MapReaderToEntitySet<CTCTipoConta>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(CTCTipoConta obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(CTCTipoConta.METADADO.Codigo, obj.Codigo)
				.FieldValue(CTCTipoConta.METADADO.Descricao, obj.Descricao)
				.Table(CTCTipoConta.METADADO.tabelaNAME);

			update.Where
				.Add(CTCTipoConta.METADADO.Id, Filter.Equal, obj.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, update.ToString());
				update.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

		#region Inserir
		public void Incluir(CTCTipoConta obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(CTCTipoConta.METADADO.tabelaNAME)
				.FieldValue(CTCTipoConta.METADADO.Codigo, obj.Codigo)
				.FieldValue(CTCTipoConta.METADADO.Descricao, obj.Descricao)
				.SetIdentityField(CTCTipoConta.METADADO.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, insert.ToString());
				insert.SetParameters(cmd);

				obj.Id = base.ExecuteScalar<int?>(cmd);
			}
		}
		#endregion

		#region Obtem
		public CTCTipoConta Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CTCTipoConta.METADADO.Id)
				.Field(CTCTipoConta.METADADO.Codigo)
				.Field(CTCTipoConta.METADADO.Descricao)
				.Table(CTCTipoConta.METADADO.tabelaNAME);

			query.Where
				.Add(CTCTipoConta.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				CTCTipoConta result = base.MapReaderToEntity<CTCTipoConta>(cmd);
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
				delete.Table(CTCTipoConta.METADADO.tabelaNAME);
			delete.Where
				.Add(CTCTipoConta.METADADO.Id, Filter.Equal, Id);

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
