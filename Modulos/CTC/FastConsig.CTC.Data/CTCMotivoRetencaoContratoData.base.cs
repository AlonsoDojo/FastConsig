
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
	public partial class CTCMotivoRetencaoContratoData : DataBase
	{
		
		#region Listar
		public List<CTCMotivoRetencaoContrato> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CTCMotivoRetencaoContrato.METADADO.Id)
				.Field(CTCMotivoRetencaoContrato.METADADO.Codigo)
				.Field(CTCMotivoRetencaoContrato.METADADO.Descricao)
				.Field(CTCMotivoRetencaoContrato.METADADO.Consignado)
				.Field(CTCMotivoRetencaoContrato.METADADO.CreditoImobiliario)
				.Field(CTCMotivoRetencaoContrato.METADADO.CreditoPessoal)
				.Field(CTCMotivoRetencaoContrato.METADADO.FinancimentoVeiculo)
				.Field(CTCMotivoRetencaoContrato.METADADO.OutrosCreditos)
				.Field(CTCMotivoRetencaoContrato.METADADO.ChequeEspecial)
				.Field(CTCMotivoRetencaoContrato.METADADO.AdiantamentoDepositante)
				.Field(CTCMotivoRetencaoContrato.METADADO.CapitalGiro)
				.Field(CTCMotivoRetencaoContrato.METADADO.Pronampe)
				.Table(CTCMotivoRetencaoContrato.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				List<CTCMotivoRetencaoContrato> result = base.MapReaderToEntitySet<CTCMotivoRetencaoContrato>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(CTCMotivoRetencaoContrato obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(CTCMotivoRetencaoContrato.METADADO.Codigo, obj.Codigo)
				.FieldValue(CTCMotivoRetencaoContrato.METADADO.Descricao, obj.Descricao)
				.FieldValue(CTCMotivoRetencaoContrato.METADADO.Consignado, obj.Consignado)
				.FieldValue(CTCMotivoRetencaoContrato.METADADO.CreditoImobiliario, obj.CreditoImobiliario)
				.FieldValue(CTCMotivoRetencaoContrato.METADADO.CreditoPessoal, obj.CreditoPessoal)
				.FieldValue(CTCMotivoRetencaoContrato.METADADO.FinancimentoVeiculo, obj.FinancimentoVeiculo)
				.FieldValue(CTCMotivoRetencaoContrato.METADADO.OutrosCreditos, obj.OutrosCreditos)
				.FieldValue(CTCMotivoRetencaoContrato.METADADO.ChequeEspecial, obj.ChequeEspecial)
				.FieldValue(CTCMotivoRetencaoContrato.METADADO.AdiantamentoDepositante, obj.AdiantamentoDepositante)
				.FieldValue(CTCMotivoRetencaoContrato.METADADO.CapitalGiro, obj.CapitalGiro)
				.FieldValue(CTCMotivoRetencaoContrato.METADADO.Pronampe, obj.Pronampe)
				.Table(CTCMotivoRetencaoContrato.METADADO.tabelaNAME);

			update.Where
				.Add(CTCMotivoRetencaoContrato.METADADO.Id, Filter.Equal, obj.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, update.ToString());
				update.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

		#region Inserir
		public void Incluir(CTCMotivoRetencaoContrato obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(CTCMotivoRetencaoContrato.METADADO.tabelaNAME)
				.FieldValue(CTCMotivoRetencaoContrato.METADADO.Codigo, obj.Codigo)
				.FieldValue(CTCMotivoRetencaoContrato.METADADO.Descricao, obj.Descricao)
				.FieldValue(CTCMotivoRetencaoContrato.METADADO.Consignado, obj.Consignado)
				.FieldValue(CTCMotivoRetencaoContrato.METADADO.CreditoImobiliario, obj.CreditoImobiliario)
				.FieldValue(CTCMotivoRetencaoContrato.METADADO.CreditoPessoal, obj.CreditoPessoal)
				.FieldValue(CTCMotivoRetencaoContrato.METADADO.FinancimentoVeiculo, obj.FinancimentoVeiculo)
				.FieldValue(CTCMotivoRetencaoContrato.METADADO.OutrosCreditos, obj.OutrosCreditos)
				.FieldValue(CTCMotivoRetencaoContrato.METADADO.ChequeEspecial, obj.ChequeEspecial)
				.FieldValue(CTCMotivoRetencaoContrato.METADADO.AdiantamentoDepositante, obj.AdiantamentoDepositante)
				.FieldValue(CTCMotivoRetencaoContrato.METADADO.CapitalGiro, obj.CapitalGiro)
				.FieldValue(CTCMotivoRetencaoContrato.METADADO.Pronampe, obj.Pronampe)
				.SetIdentityField(CTCMotivoRetencaoContrato.METADADO.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, insert.ToString());
				insert.SetParameters(cmd);

				obj.Id = base.ExecuteScalar<int?>(cmd);
			}
		}
		#endregion

		#region Obtem
		public CTCMotivoRetencaoContrato Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CTCMotivoRetencaoContrato.METADADO.Id)
				.Field(CTCMotivoRetencaoContrato.METADADO.Codigo)
				.Field(CTCMotivoRetencaoContrato.METADADO.Descricao)
				.Field(CTCMotivoRetencaoContrato.METADADO.Consignado)
				.Field(CTCMotivoRetencaoContrato.METADADO.CreditoImobiliario)
				.Field(CTCMotivoRetencaoContrato.METADADO.CreditoPessoal)
				.Field(CTCMotivoRetencaoContrato.METADADO.FinancimentoVeiculo)
				.Field(CTCMotivoRetencaoContrato.METADADO.OutrosCreditos)
				.Field(CTCMotivoRetencaoContrato.METADADO.ChequeEspecial)
				.Field(CTCMotivoRetencaoContrato.METADADO.AdiantamentoDepositante)
				.Field(CTCMotivoRetencaoContrato.METADADO.CapitalGiro)
				.Field(CTCMotivoRetencaoContrato.METADADO.Pronampe)
				.Table(CTCMotivoRetencaoContrato.METADADO.tabelaNAME);

			query.Where
				.Add(CTCMotivoRetencaoContrato.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				CTCMotivoRetencaoContrato result = base.MapReaderToEntity<CTCMotivoRetencaoContrato>(cmd);
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
				delete.Table(CTCMotivoRetencaoContrato.METADADO.tabelaNAME);
			delete.Where
				.Add(CTCMotivoRetencaoContrato.METADADO.Id, Filter.Equal, Id);

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
