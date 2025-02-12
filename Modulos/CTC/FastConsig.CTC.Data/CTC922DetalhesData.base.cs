
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
	public partial class CTC922DetalhesData : DataBase
	{
		
		#region Listar
		public List<CTC922Detalhes> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CTC922Detalhes.METADADO.Id)
				.Field(CTC922Detalhes.METADADO.CTC922)
				.Field(CTC922Detalhes.METADADO.TipoParte)
				.Field(CTC922Detalhes.METADADO.MotivoRetencao)
				.Field(CTC922Detalhes.METADADO.QtdRetencao)
				.Field(CTC922Detalhes.METADADO.MotivoDecursoPrazo)
				.Field(CTC922Detalhes.METADADO.QtdDecursoPrazo)
				.Field(CTC922Detalhes.METADADO.MotivoCancelamento)
				.Field(CTC922Detalhes.METADADO.QtdCancelamento)
				.Field(CTC922Detalhes.METADADO.MotivoDevolucaoLiquidacao)
				.Field(CTC922Detalhes.METADADO.QtdDevolucaoLiquidacao)
				.Field(CTC922Detalhes.METADADO.TipoContrato)
				.Field(CTC922Detalhes.METADADO.EnteConsignante)
				.Field(CTC922Detalhes.METADADO.SituacaoPortabilidade)
				.Field(CTC922Detalhes.METADADO.QtdSituacaoPortabilidade)
				.Table(CTC922Detalhes.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				List<CTC922Detalhes> result = base.MapReaderToEntitySet<CTC922Detalhes>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(CTC922Detalhes obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(CTC922Detalhes.METADADO.CTC922, obj.CTC922)
				.FieldValue(CTC922Detalhes.METADADO.TipoParte, obj.TipoParte)
				.FieldValue(CTC922Detalhes.METADADO.MotivoRetencao, obj.MotivoRetencao)
				.FieldValue(CTC922Detalhes.METADADO.QtdRetencao, obj.QtdRetencao)
				.FieldValue(CTC922Detalhes.METADADO.MotivoDecursoPrazo, obj.MotivoDecursoPrazo)
				.FieldValue(CTC922Detalhes.METADADO.QtdDecursoPrazo, obj.QtdDecursoPrazo)
				.FieldValue(CTC922Detalhes.METADADO.MotivoCancelamento, obj.MotivoCancelamento)
				.FieldValue(CTC922Detalhes.METADADO.QtdCancelamento, obj.QtdCancelamento)
				.FieldValue(CTC922Detalhes.METADADO.MotivoDevolucaoLiquidacao, obj.MotivoDevolucaoLiquidacao)
				.FieldValue(CTC922Detalhes.METADADO.QtdDevolucaoLiquidacao, obj.QtdDevolucaoLiquidacao)
				.FieldValue(CTC922Detalhes.METADADO.TipoContrato, obj.TipoContrato)
				.FieldValue(CTC922Detalhes.METADADO.EnteConsignante, obj.EnteConsignante)
				.FieldValue(CTC922Detalhes.METADADO.SituacaoPortabilidade, obj.SituacaoPortabilidade)
				.FieldValue(CTC922Detalhes.METADADO.QtdSituacaoPortabilidade, obj.QtdSituacaoPortabilidade)
				.Table(CTC922Detalhes.METADADO.tabelaNAME);

			update.Where
				.Add(CTC922Detalhes.METADADO.Id, Filter.Equal, obj.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, update.ToString());
				update.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

		#region Inserir
		public void Incluir(CTC922Detalhes obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(CTC922Detalhes.METADADO.tabelaNAME)
				.FieldValue(CTC922Detalhes.METADADO.CTC922, obj.CTC922)
				.FieldValue(CTC922Detalhes.METADADO.TipoParte, obj.TipoParte)
				.FieldValue(CTC922Detalhes.METADADO.MotivoRetencao, obj.MotivoRetencao)
				.FieldValue(CTC922Detalhes.METADADO.QtdRetencao, obj.QtdRetencao)
				.FieldValue(CTC922Detalhes.METADADO.MotivoDecursoPrazo, obj.MotivoDecursoPrazo)
				.FieldValue(CTC922Detalhes.METADADO.QtdDecursoPrazo, obj.QtdDecursoPrazo)
				.FieldValue(CTC922Detalhes.METADADO.MotivoCancelamento, obj.MotivoCancelamento)
				.FieldValue(CTC922Detalhes.METADADO.QtdCancelamento, obj.QtdCancelamento)
				.FieldValue(CTC922Detalhes.METADADO.MotivoDevolucaoLiquidacao, obj.MotivoDevolucaoLiquidacao)
				.FieldValue(CTC922Detalhes.METADADO.QtdDevolucaoLiquidacao, obj.QtdDevolucaoLiquidacao)
				.FieldValue(CTC922Detalhes.METADADO.TipoContrato, obj.TipoContrato)
				.FieldValue(CTC922Detalhes.METADADO.EnteConsignante, obj.EnteConsignante)
				.FieldValue(CTC922Detalhes.METADADO.SituacaoPortabilidade, obj.SituacaoPortabilidade)
				.FieldValue(CTC922Detalhes.METADADO.QtdSituacaoPortabilidade, obj.QtdSituacaoPortabilidade)
				.SetIdentityField(CTC922Detalhes.METADADO.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, insert.ToString());
				insert.SetParameters(cmd);

				obj.Id = base.ExecuteScalar<int?>(cmd);
			}
		}
		#endregion

		#region Obtem
		public CTC922Detalhes Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CTC922Detalhes.METADADO.Id)
				.Field(CTC922Detalhes.METADADO.CTC922)
				.Field(CTC922Detalhes.METADADO.TipoParte)
				.Field(CTC922Detalhes.METADADO.MotivoRetencao)
				.Field(CTC922Detalhes.METADADO.QtdRetencao)
				.Field(CTC922Detalhes.METADADO.MotivoDecursoPrazo)
				.Field(CTC922Detalhes.METADADO.QtdDecursoPrazo)
				.Field(CTC922Detalhes.METADADO.MotivoCancelamento)
				.Field(CTC922Detalhes.METADADO.QtdCancelamento)
				.Field(CTC922Detalhes.METADADO.MotivoDevolucaoLiquidacao)
				.Field(CTC922Detalhes.METADADO.QtdDevolucaoLiquidacao)
				.Field(CTC922Detalhes.METADADO.TipoContrato)
				.Field(CTC922Detalhes.METADADO.EnteConsignante)
				.Field(CTC922Detalhes.METADADO.SituacaoPortabilidade)
				.Field(CTC922Detalhes.METADADO.QtdSituacaoPortabilidade)
				.Table(CTC922Detalhes.METADADO.tabelaNAME);

			query.Where
				.Add(CTC922Detalhes.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				CTC922Detalhes result = base.MapReaderToEntity<CTC922Detalhes>(cmd);
				return result;
			}
		}
		#endregion

		#region Excluir por FKs
		public void ExcluirPor_CTC922(int? CTC922)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(CTC922Detalhes.METADADO.tabelaNAME);
			delete.Where
				.Add(CTC922Detalhes.METADADO.CTC922, Filter.Equal, CTC922);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, delete.ToString());
				delete.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		public void ExcluirPor_TipoParte(int? TipoParte)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(CTC922Detalhes.METADADO.tabelaNAME);
			delete.Where
				.Add(CTC922Detalhes.METADADO.TipoParte, Filter.Equal, TipoParte);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, delete.ToString());
				delete.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		public void ExcluirPor_MotivoRetencao(string MotivoRetencao)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(CTC922Detalhes.METADADO.tabelaNAME);
			delete.Where
				.Add(CTC922Detalhes.METADADO.MotivoRetencao, Filter.Equal, MotivoRetencao);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, delete.ToString());
				delete.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		public void ExcluirPor_MotivoDecursoPrazo(string MotivoDecursoPrazo)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(CTC922Detalhes.METADADO.tabelaNAME);
			delete.Where
				.Add(CTC922Detalhes.METADADO.MotivoDecursoPrazo, Filter.Equal, MotivoDecursoPrazo);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, delete.ToString());
				delete.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		public void ExcluirPor_MotivoCancelamento(string MotivoCancelamento)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(CTC922Detalhes.METADADO.tabelaNAME);
			delete.Where
				.Add(CTC922Detalhes.METADADO.MotivoCancelamento, Filter.Equal, MotivoCancelamento);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, delete.ToString());
				delete.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		public void ExcluirPor_MotivoDevolucaoLiquidacao(string MotivoDevolucaoLiquidacao)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(CTC922Detalhes.METADADO.tabelaNAME);
			delete.Where
				.Add(CTC922Detalhes.METADADO.MotivoDevolucaoLiquidacao, Filter.Equal, MotivoDevolucaoLiquidacao);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, delete.ToString());
				delete.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		public void ExcluirPor_TipoContrato(string TipoContrato)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(CTC922Detalhes.METADADO.tabelaNAME);
			delete.Where
				.Add(CTC922Detalhes.METADADO.TipoContrato, Filter.Equal, TipoContrato);

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
				delete.Table(CTC922Detalhes.METADADO.tabelaNAME);
			delete.Where
				.Add(CTC922Detalhes.METADADO.EnteConsignante, Filter.Equal, EnteConsignante);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, delete.ToString());
				delete.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		public void ExcluirPor_SituacaoPortabilidade(string SituacaoPortabilidade)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(CTC922Detalhes.METADADO.tabelaNAME);
			delete.Where
				.Add(CTC922Detalhes.METADADO.SituacaoPortabilidade, Filter.Equal, SituacaoPortabilidade);

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
				delete.Table(CTC922Detalhes.METADADO.tabelaNAME);
			delete.Where
				.Add(CTC922Detalhes.METADADO.Id, Filter.Equal, Id);

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
