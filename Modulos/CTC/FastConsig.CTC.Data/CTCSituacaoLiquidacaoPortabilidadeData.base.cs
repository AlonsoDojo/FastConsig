
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
	public partial class CTCSituacaoLiquidacaoPortabilidadeData : DataBase
	{
		
		#region Listar
		public List<CTCSituacaoLiquidacaoPortabilidade> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CTCSituacaoLiquidacaoPortabilidade.METADADO.Id)
				.Field(CTCSituacaoLiquidacaoPortabilidade.METADADO.Codigo)
				.Field(CTCSituacaoLiquidacaoPortabilidade.METADADO.Descricao)
				.Table(CTCSituacaoLiquidacaoPortabilidade.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				List<CTCSituacaoLiquidacaoPortabilidade> result = base.MapReaderToEntitySet<CTCSituacaoLiquidacaoPortabilidade>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(CTCSituacaoLiquidacaoPortabilidade obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(CTCSituacaoLiquidacaoPortabilidade.METADADO.Codigo, obj.Codigo)
				.FieldValue(CTCSituacaoLiquidacaoPortabilidade.METADADO.Descricao, obj.Descricao)
				.Table(CTCSituacaoLiquidacaoPortabilidade.METADADO.tabelaNAME);

			update.Where
				.Add(CTCSituacaoLiquidacaoPortabilidade.METADADO.Id, Filter.Equal, obj.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, update.ToString());
				update.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

		#region Inserir
		public void Incluir(CTCSituacaoLiquidacaoPortabilidade obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(CTCSituacaoLiquidacaoPortabilidade.METADADO.tabelaNAME)
				.FieldValue(CTCSituacaoLiquidacaoPortabilidade.METADADO.Codigo, obj.Codigo)
				.FieldValue(CTCSituacaoLiquidacaoPortabilidade.METADADO.Descricao, obj.Descricao)
				.SetIdentityField(CTCSituacaoLiquidacaoPortabilidade.METADADO.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, insert.ToString());
				insert.SetParameters(cmd);

				obj.Id = base.ExecuteScalar<int?>(cmd);
			}
		}
		#endregion

		#region Obtem
		public CTCSituacaoLiquidacaoPortabilidade Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CTCSituacaoLiquidacaoPortabilidade.METADADO.Id)
				.Field(CTCSituacaoLiquidacaoPortabilidade.METADADO.Codigo)
				.Field(CTCSituacaoLiquidacaoPortabilidade.METADADO.Descricao)
				.Table(CTCSituacaoLiquidacaoPortabilidade.METADADO.tabelaNAME);

			query.Where
				.Add(CTCSituacaoLiquidacaoPortabilidade.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				CTCSituacaoLiquidacaoPortabilidade result = base.MapReaderToEntity<CTCSituacaoLiquidacaoPortabilidade>(cmd);
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
				delete.Table(CTCSituacaoLiquidacaoPortabilidade.METADADO.tabelaNAME);
			delete.Where
				.Add(CTCSituacaoLiquidacaoPortabilidade.METADADO.Id, Filter.Equal, Id);

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
