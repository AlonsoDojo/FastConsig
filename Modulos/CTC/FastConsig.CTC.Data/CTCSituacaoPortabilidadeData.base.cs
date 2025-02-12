
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
	public partial class CTCSituacaoPortabilidadeData : DataBase
	{
		
		#region Listar
		public List<CTCSituacaoPortabilidade> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CTCSituacaoPortabilidade.METADADO.Id)
				.Field(CTCSituacaoPortabilidade.METADADO.Codigo)
				.Field(CTCSituacaoPortabilidade.METADADO.Descricao)
				.Table(CTCSituacaoPortabilidade.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				List<CTCSituacaoPortabilidade> result = base.MapReaderToEntitySet<CTCSituacaoPortabilidade>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(CTCSituacaoPortabilidade obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(CTCSituacaoPortabilidade.METADADO.Codigo, obj.Codigo)
				.FieldValue(CTCSituacaoPortabilidade.METADADO.Descricao, obj.Descricao)
				.Table(CTCSituacaoPortabilidade.METADADO.tabelaNAME);

			update.Where
				.Add(CTCSituacaoPortabilidade.METADADO.Id, Filter.Equal, obj.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, update.ToString());
				update.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

		#region Inserir
		public void Incluir(CTCSituacaoPortabilidade obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(CTCSituacaoPortabilidade.METADADO.tabelaNAME)
				.FieldValue(CTCSituacaoPortabilidade.METADADO.Codigo, obj.Codigo)
				.FieldValue(CTCSituacaoPortabilidade.METADADO.Descricao, obj.Descricao)
				.SetIdentityField(CTCSituacaoPortabilidade.METADADO.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, insert.ToString());
				insert.SetParameters(cmd);

				obj.Id = base.ExecuteScalar<int?>(cmd);
			}
		}
		#endregion

		#region Obtem
		public CTCSituacaoPortabilidade Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CTCSituacaoPortabilidade.METADADO.Id)
				.Field(CTCSituacaoPortabilidade.METADADO.Codigo)
				.Field(CTCSituacaoPortabilidade.METADADO.Descricao)
				.Table(CTCSituacaoPortabilidade.METADADO.tabelaNAME);

			query.Where
				.Add(CTCSituacaoPortabilidade.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				CTCSituacaoPortabilidade result = base.MapReaderToEntity<CTCSituacaoPortabilidade>(cmd);
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
				delete.Table(CTCSituacaoPortabilidade.METADADO.tabelaNAME);
			delete.Where
				.Add(CTCSituacaoPortabilidade.METADADO.Id, Filter.Equal, Id);

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
