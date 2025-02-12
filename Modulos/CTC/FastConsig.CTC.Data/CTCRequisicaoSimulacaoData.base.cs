
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
	public partial class CTCRequisicaoSimulacaoData : DataBase
	{
		
		#region Listar
		public List<CTCRequisicaoSimulacao> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CTCRequisicaoSimulacao.METADADO.Id)
				.Field(CTCRequisicaoSimulacao.METADADO.Requisicao)
				.Field(CTCRequisicaoSimulacao.METADADO.Simulacao)
				.Field(CTCRequisicaoSimulacao.METADADO.DataReferencia)
				.Field(CTCRequisicaoSimulacao.METADADO.SaldoDevedor)
				.Field(CTCRequisicaoSimulacao.METADADO.Taxa)
				.Field(CTCRequisicaoSimulacao.METADADO.CET)
				.Field(CTCRequisicaoSimulacao.METADADO.Parcelas)
				.Field(CTCRequisicaoSimulacao.METADADO.ValorParcela)
				.Field(CTCRequisicaoSimulacao.METADADO.PrimeiroVencimento)
				.Field(CTCRequisicaoSimulacao.METADADO.UltimoVencimento)
				.Field(CTCRequisicaoSimulacao.METADADO.Tipo)
				.Field(CTCRequisicaoSimulacao.METADADO.Tabela)
				.Table(CTCRequisicaoSimulacao.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				List<CTCRequisicaoSimulacao> result = base.MapReaderToEntitySet<CTCRequisicaoSimulacao>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(CTCRequisicaoSimulacao obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(CTCRequisicaoSimulacao.METADADO.Requisicao, obj.Requisicao)
				.FieldValue(CTCRequisicaoSimulacao.METADADO.Simulacao, obj.Simulacao)
				.FieldValue(CTCRequisicaoSimulacao.METADADO.DataReferencia, obj.DataReferencia)
				.FieldValue(CTCRequisicaoSimulacao.METADADO.SaldoDevedor, obj.SaldoDevedor)
				.FieldValue(CTCRequisicaoSimulacao.METADADO.Taxa, obj.Taxa)
				.FieldValue(CTCRequisicaoSimulacao.METADADO.CET, obj.CET)
				.FieldValue(CTCRequisicaoSimulacao.METADADO.Parcelas, obj.Parcelas)
				.FieldValue(CTCRequisicaoSimulacao.METADADO.ValorParcela, obj.ValorParcela)
				.FieldValue(CTCRequisicaoSimulacao.METADADO.PrimeiroVencimento, obj.PrimeiroVencimento)
				.FieldValue(CTCRequisicaoSimulacao.METADADO.UltimoVencimento, obj.UltimoVencimento)
				.FieldValue(CTCRequisicaoSimulacao.METADADO.Tipo, obj.Tipo)
				.FieldValue(CTCRequisicaoSimulacao.METADADO.Tabela, obj.Tabela)
				.Table(CTCRequisicaoSimulacao.METADADO.tabelaNAME);

			update.Where
				.Add(CTCRequisicaoSimulacao.METADADO.Id, Filter.Equal, obj.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, update.ToString());
				update.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

		#region Inserir
		public void Incluir(CTCRequisicaoSimulacao obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(CTCRequisicaoSimulacao.METADADO.tabelaNAME)
				.FieldValue(CTCRequisicaoSimulacao.METADADO.Requisicao, obj.Requisicao)
				.FieldValue(CTCRequisicaoSimulacao.METADADO.Simulacao, obj.Simulacao)
				.FieldValue(CTCRequisicaoSimulacao.METADADO.DataReferencia, obj.DataReferencia)
				.FieldValue(CTCRequisicaoSimulacao.METADADO.SaldoDevedor, obj.SaldoDevedor)
				.FieldValue(CTCRequisicaoSimulacao.METADADO.Taxa, obj.Taxa)
				.FieldValue(CTCRequisicaoSimulacao.METADADO.CET, obj.CET)
				.FieldValue(CTCRequisicaoSimulacao.METADADO.Parcelas, obj.Parcelas)
				.FieldValue(CTCRequisicaoSimulacao.METADADO.ValorParcela, obj.ValorParcela)
				.FieldValue(CTCRequisicaoSimulacao.METADADO.PrimeiroVencimento, obj.PrimeiroVencimento)
				.FieldValue(CTCRequisicaoSimulacao.METADADO.UltimoVencimento, obj.UltimoVencimento)
				.FieldValue(CTCRequisicaoSimulacao.METADADO.Tipo, obj.Tipo)
				.FieldValue(CTCRequisicaoSimulacao.METADADO.Tabela, obj.Tabela)
				.SetIdentityField(CTCRequisicaoSimulacao.METADADO.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, insert.ToString());
				insert.SetParameters(cmd);

				obj.Id = base.ExecuteScalar<int?>(cmd);
			}
		}
		#endregion

		#region Obtem
		public CTCRequisicaoSimulacao Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CTCRequisicaoSimulacao.METADADO.Id)
				.Field(CTCRequisicaoSimulacao.METADADO.Requisicao)
				.Field(CTCRequisicaoSimulacao.METADADO.Simulacao)
				.Field(CTCRequisicaoSimulacao.METADADO.DataReferencia)
				.Field(CTCRequisicaoSimulacao.METADADO.SaldoDevedor)
				.Field(CTCRequisicaoSimulacao.METADADO.Taxa)
				.Field(CTCRequisicaoSimulacao.METADADO.CET)
				.Field(CTCRequisicaoSimulacao.METADADO.Parcelas)
				.Field(CTCRequisicaoSimulacao.METADADO.ValorParcela)
				.Field(CTCRequisicaoSimulacao.METADADO.PrimeiroVencimento)
				.Field(CTCRequisicaoSimulacao.METADADO.UltimoVencimento)
				.Field(CTCRequisicaoSimulacao.METADADO.Tipo)
				.Field(CTCRequisicaoSimulacao.METADADO.Tabela)
				.Table(CTCRequisicaoSimulacao.METADADO.tabelaNAME);

			query.Where
				.Add(CTCRequisicaoSimulacao.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				CTCRequisicaoSimulacao result = base.MapReaderToEntity<CTCRequisicaoSimulacao>(cmd);
				return result;
			}
		}
		#endregion

		#region Excluir por FKs
		public void ExcluirPor_Requisicao(int? Requisicao)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(CTCRequisicaoSimulacao.METADADO.tabelaNAME);
			delete.Where
				.Add(CTCRequisicaoSimulacao.METADADO.Requisicao, Filter.Equal, Requisicao);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, delete.ToString());
				delete.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		public void ExcluirPor_Tipo(int? Tipo)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(CTCRequisicaoSimulacao.METADADO.tabelaNAME);
			delete.Where
				.Add(CTCRequisicaoSimulacao.METADADO.Tipo, Filter.Equal, Tipo);

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
				delete.Table(CTCRequisicaoSimulacao.METADADO.tabelaNAME);
			delete.Where
				.Add(CTCRequisicaoSimulacao.METADADO.Id, Filter.Equal, Id);

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
