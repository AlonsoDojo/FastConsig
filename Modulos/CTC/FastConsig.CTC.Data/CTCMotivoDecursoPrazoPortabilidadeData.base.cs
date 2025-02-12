
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
	public partial class CTCMotivoDecursoPrazoPortabilidadeData : DataBase
	{
		
		#region Listar
		public List<CTCMotivoDecursoPrazoPortabilidade> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CTCMotivoDecursoPrazoPortabilidade.METADADO.Id)
				.Field(CTCMotivoDecursoPrazoPortabilidade.METADADO.Codigo)
				.Field(CTCMotivoDecursoPrazoPortabilidade.METADADO.Descricao)
				.Table(CTCMotivoDecursoPrazoPortabilidade.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				List<CTCMotivoDecursoPrazoPortabilidade> result = base.MapReaderToEntitySet<CTCMotivoDecursoPrazoPortabilidade>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(CTCMotivoDecursoPrazoPortabilidade obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(CTCMotivoDecursoPrazoPortabilidade.METADADO.Codigo, obj.Codigo)
				.FieldValue(CTCMotivoDecursoPrazoPortabilidade.METADADO.Descricao, obj.Descricao)
				.Table(CTCMotivoDecursoPrazoPortabilidade.METADADO.tabelaNAME);

			update.Where
				.Add(CTCMotivoDecursoPrazoPortabilidade.METADADO.Id, Filter.Equal, obj.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, update.ToString());
				update.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

		#region Inserir
		public void Incluir(CTCMotivoDecursoPrazoPortabilidade obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(CTCMotivoDecursoPrazoPortabilidade.METADADO.tabelaNAME)
				.FieldValue(CTCMotivoDecursoPrazoPortabilidade.METADADO.Codigo, obj.Codigo)
				.FieldValue(CTCMotivoDecursoPrazoPortabilidade.METADADO.Descricao, obj.Descricao)
				.SetIdentityField(CTCMotivoDecursoPrazoPortabilidade.METADADO.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, insert.ToString());
				insert.SetParameters(cmd);

				obj.Id = base.ExecuteScalar<int?>(cmd);
			}
		}
		#endregion

		#region Obtem
		public CTCMotivoDecursoPrazoPortabilidade Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CTCMotivoDecursoPrazoPortabilidade.METADADO.Id)
				.Field(CTCMotivoDecursoPrazoPortabilidade.METADADO.Codigo)
				.Field(CTCMotivoDecursoPrazoPortabilidade.METADADO.Descricao)
				.Table(CTCMotivoDecursoPrazoPortabilidade.METADADO.tabelaNAME);

			query.Where
				.Add(CTCMotivoDecursoPrazoPortabilidade.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				CTCMotivoDecursoPrazoPortabilidade result = base.MapReaderToEntity<CTCMotivoDecursoPrazoPortabilidade>(cmd);
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
				delete.Table(CTCMotivoDecursoPrazoPortabilidade.METADADO.tabelaNAME);
			delete.Where
				.Add(CTCMotivoDecursoPrazoPortabilidade.METADADO.Id, Filter.Equal, Id);

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
