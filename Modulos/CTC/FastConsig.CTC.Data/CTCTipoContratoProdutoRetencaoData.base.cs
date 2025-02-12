
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
	public partial class CTCTipoContratoProdutoRetencaoData : DataBase
	{
		
		#region Listar
		public List<CTCTipoContratoProdutoRetencao> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CTCTipoContratoProdutoRetencao.METADADO.Id)
				.Field(CTCTipoContratoProdutoRetencao.METADADO.TipoContrato)
				.Field(CTCTipoContratoProdutoRetencao.METADADO.EnteConsignante)
				.Field(CTCTipoContratoProdutoRetencao.METADADO.ProdutoOrigem)
				.Field(CTCTipoContratoProdutoRetencao.METADADO.ProdutoRetencao)
				.Field(CTCTipoContratoProdutoRetencao.METADADO.ContaPagamento)
				.Table(CTCTipoContratoProdutoRetencao.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				List<CTCTipoContratoProdutoRetencao> result = base.MapReaderToEntitySet<CTCTipoContratoProdutoRetencao>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(CTCTipoContratoProdutoRetencao obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(CTCTipoContratoProdutoRetencao.METADADO.TipoContrato, obj.TipoContrato)
				.FieldValue(CTCTipoContratoProdutoRetencao.METADADO.EnteConsignante, obj.EnteConsignante)
				.FieldValue(CTCTipoContratoProdutoRetencao.METADADO.ProdutoOrigem, obj.ProdutoOrigem)
				.FieldValue(CTCTipoContratoProdutoRetencao.METADADO.ProdutoRetencao, obj.ProdutoRetencao)
				.FieldValue(CTCTipoContratoProdutoRetencao.METADADO.ContaPagamento, obj.ContaPagamento)
				.Table(CTCTipoContratoProdutoRetencao.METADADO.tabelaNAME);

			update.Where
				.Add(CTCTipoContratoProdutoRetencao.METADADO.Id, Filter.Equal, obj.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, update.ToString());
				update.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

		#region Inserir
		public void Incluir(CTCTipoContratoProdutoRetencao obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(CTCTipoContratoProdutoRetencao.METADADO.tabelaNAME)
				.FieldValue(CTCTipoContratoProdutoRetencao.METADADO.TipoContrato, obj.TipoContrato)
				.FieldValue(CTCTipoContratoProdutoRetencao.METADADO.EnteConsignante, obj.EnteConsignante)
				.FieldValue(CTCTipoContratoProdutoRetencao.METADADO.ProdutoOrigem, obj.ProdutoOrigem)
				.FieldValue(CTCTipoContratoProdutoRetencao.METADADO.ProdutoRetencao, obj.ProdutoRetencao)
				.FieldValue(CTCTipoContratoProdutoRetencao.METADADO.ContaPagamento, obj.ContaPagamento)
				.SetIdentityField(CTCTipoContratoProdutoRetencao.METADADO.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, insert.ToString());
				insert.SetParameters(cmd);

				obj.Id = base.ExecuteScalar<int?>(cmd);
			}
		}
		#endregion

		#region Obtem
		public CTCTipoContratoProdutoRetencao Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CTCTipoContratoProdutoRetencao.METADADO.Id)
				.Field(CTCTipoContratoProdutoRetencao.METADADO.TipoContrato)
				.Field(CTCTipoContratoProdutoRetencao.METADADO.EnteConsignante)
				.Field(CTCTipoContratoProdutoRetencao.METADADO.ProdutoOrigem)
				.Field(CTCTipoContratoProdutoRetencao.METADADO.ProdutoRetencao)
				.Field(CTCTipoContratoProdutoRetencao.METADADO.ContaPagamento)
				.Table(CTCTipoContratoProdutoRetencao.METADADO.tabelaNAME);

			query.Where
				.Add(CTCTipoContratoProdutoRetencao.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				CTCTipoContratoProdutoRetencao result = base.MapReaderToEntity<CTCTipoContratoProdutoRetencao>(cmd);
				return result;
			}
		}
		#endregion

		#region Excluir por FKs
		public void ExcluirPor_TipoContrato(string TipoContrato)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(CTCTipoContratoProdutoRetencao.METADADO.tabelaNAME);
			delete.Where
				.Add(CTCTipoContratoProdutoRetencao.METADADO.TipoContrato, Filter.Equal, TipoContrato);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, delete.ToString());
				delete.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		public void ExcluirPor_EnteConsignante(string EnteConsignante)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(CTCTipoContratoProdutoRetencao.METADADO.tabelaNAME);
			delete.Where
				.Add(CTCTipoContratoProdutoRetencao.METADADO.EnteConsignante, Filter.Equal, EnteConsignante);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, delete.ToString());
				delete.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		public void ExcluirPor_ProdutoRetencao(int? ProdutoRetencao)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(CTCTipoContratoProdutoRetencao.METADADO.tabelaNAME);
			delete.Where
				.Add(CTCTipoContratoProdutoRetencao.METADADO.ProdutoRetencao, Filter.Equal, ProdutoRetencao);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, delete.ToString());
				delete.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		public void ExcluirPor_ContaPagamento(int? ContaPagamento)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(CTCTipoContratoProdutoRetencao.METADADO.tabelaNAME);
			delete.Where
				.Add(CTCTipoContratoProdutoRetencao.METADADO.ContaPagamento, Filter.Equal, ContaPagamento);

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
				delete.Table(CTCTipoContratoProdutoRetencao.METADADO.tabelaNAME);
			delete.Where
				.Add(CTCTipoContratoProdutoRetencao.METADADO.Id, Filter.Equal, Id);

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
