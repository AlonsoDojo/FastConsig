
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
	public partial class CTCMotivoCancelamentoPortabilidadeData : DataBase
	{
		
		#region Listar
		public List<CTCMotivoCancelamentoPortabilidade> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CTCMotivoCancelamentoPortabilidade.METADADO.Id)
				.Field(CTCMotivoCancelamentoPortabilidade.METADADO.Codigo)
				.Field(CTCMotivoCancelamentoPortabilidade.METADADO.Descricao)
				.Field(CTCMotivoCancelamentoPortabilidade.METADADO.Consignado)
				.Field(CTCMotivoCancelamentoPortabilidade.METADADO.CreditoImobiliario)
				.Field(CTCMotivoCancelamentoPortabilidade.METADADO.CreditoPessoal)
				.Field(CTCMotivoCancelamentoPortabilidade.METADADO.FinancimentoVeiculo)
				.Field(CTCMotivoCancelamentoPortabilidade.METADADO.OutrosCreditos)
				.Field(CTCMotivoCancelamentoPortabilidade.METADADO.ChequeEspecial)
				.Field(CTCMotivoCancelamentoPortabilidade.METADADO.AdiantamentoDepositante)
				.Field(CTCMotivoCancelamentoPortabilidade.METADADO.CapitalGiro)
				.Field(CTCMotivoCancelamentoPortabilidade.METADADO.Pronampe)
				.Table(CTCMotivoCancelamentoPortabilidade.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				List<CTCMotivoCancelamentoPortabilidade> result = base.MapReaderToEntitySet<CTCMotivoCancelamentoPortabilidade>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(CTCMotivoCancelamentoPortabilidade obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(CTCMotivoCancelamentoPortabilidade.METADADO.Codigo, obj.Codigo)
				.FieldValue(CTCMotivoCancelamentoPortabilidade.METADADO.Descricao, obj.Descricao)
				.FieldValue(CTCMotivoCancelamentoPortabilidade.METADADO.Consignado, obj.Consignado)
				.FieldValue(CTCMotivoCancelamentoPortabilidade.METADADO.CreditoImobiliario, obj.CreditoImobiliario)
				.FieldValue(CTCMotivoCancelamentoPortabilidade.METADADO.CreditoPessoal, obj.CreditoPessoal)
				.FieldValue(CTCMotivoCancelamentoPortabilidade.METADADO.FinancimentoVeiculo, obj.FinancimentoVeiculo)
				.FieldValue(CTCMotivoCancelamentoPortabilidade.METADADO.OutrosCreditos, obj.OutrosCreditos)
				.FieldValue(CTCMotivoCancelamentoPortabilidade.METADADO.ChequeEspecial, obj.ChequeEspecial)
				.FieldValue(CTCMotivoCancelamentoPortabilidade.METADADO.AdiantamentoDepositante, obj.AdiantamentoDepositante)
				.FieldValue(CTCMotivoCancelamentoPortabilidade.METADADO.CapitalGiro, obj.CapitalGiro)
				.FieldValue(CTCMotivoCancelamentoPortabilidade.METADADO.Pronampe, obj.Pronampe)
				.Table(CTCMotivoCancelamentoPortabilidade.METADADO.tabelaNAME);

			update.Where
				.Add(CTCMotivoCancelamentoPortabilidade.METADADO.Id, Filter.Equal, obj.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, update.ToString());
				update.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

		#region Inserir
		public void Incluir(CTCMotivoCancelamentoPortabilidade obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(CTCMotivoCancelamentoPortabilidade.METADADO.tabelaNAME)
				.FieldValue(CTCMotivoCancelamentoPortabilidade.METADADO.Codigo, obj.Codigo)
				.FieldValue(CTCMotivoCancelamentoPortabilidade.METADADO.Descricao, obj.Descricao)
				.FieldValue(CTCMotivoCancelamentoPortabilidade.METADADO.Consignado, obj.Consignado)
				.FieldValue(CTCMotivoCancelamentoPortabilidade.METADADO.CreditoImobiliario, obj.CreditoImobiliario)
				.FieldValue(CTCMotivoCancelamentoPortabilidade.METADADO.CreditoPessoal, obj.CreditoPessoal)
				.FieldValue(CTCMotivoCancelamentoPortabilidade.METADADO.FinancimentoVeiculo, obj.FinancimentoVeiculo)
				.FieldValue(CTCMotivoCancelamentoPortabilidade.METADADO.OutrosCreditos, obj.OutrosCreditos)
				.FieldValue(CTCMotivoCancelamentoPortabilidade.METADADO.ChequeEspecial, obj.ChequeEspecial)
				.FieldValue(CTCMotivoCancelamentoPortabilidade.METADADO.AdiantamentoDepositante, obj.AdiantamentoDepositante)
				.FieldValue(CTCMotivoCancelamentoPortabilidade.METADADO.CapitalGiro, obj.CapitalGiro)
				.FieldValue(CTCMotivoCancelamentoPortabilidade.METADADO.Pronampe, obj.Pronampe)
				.SetIdentityField(CTCMotivoCancelamentoPortabilidade.METADADO.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, insert.ToString());
				insert.SetParameters(cmd);

				obj.Id = base.ExecuteScalar<int?>(cmd);
			}
		}
		#endregion

		#region Obtem
		public CTCMotivoCancelamentoPortabilidade Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CTCMotivoCancelamentoPortabilidade.METADADO.Id)
				.Field(CTCMotivoCancelamentoPortabilidade.METADADO.Codigo)
				.Field(CTCMotivoCancelamentoPortabilidade.METADADO.Descricao)
				.Field(CTCMotivoCancelamentoPortabilidade.METADADO.Consignado)
				.Field(CTCMotivoCancelamentoPortabilidade.METADADO.CreditoImobiliario)
				.Field(CTCMotivoCancelamentoPortabilidade.METADADO.CreditoPessoal)
				.Field(CTCMotivoCancelamentoPortabilidade.METADADO.FinancimentoVeiculo)
				.Field(CTCMotivoCancelamentoPortabilidade.METADADO.OutrosCreditos)
				.Field(CTCMotivoCancelamentoPortabilidade.METADADO.ChequeEspecial)
				.Field(CTCMotivoCancelamentoPortabilidade.METADADO.AdiantamentoDepositante)
				.Field(CTCMotivoCancelamentoPortabilidade.METADADO.CapitalGiro)
				.Field(CTCMotivoCancelamentoPortabilidade.METADADO.Pronampe)
				.Table(CTCMotivoCancelamentoPortabilidade.METADADO.tabelaNAME);

			query.Where
				.Add(CTCMotivoCancelamentoPortabilidade.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				CTCMotivoCancelamentoPortabilidade result = base.MapReaderToEntity<CTCMotivoCancelamentoPortabilidade>(cmd);
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
				delete.Table(CTCMotivoCancelamentoPortabilidade.METADADO.tabelaNAME);
			delete.Where
				.Add(CTCMotivoCancelamentoPortabilidade.METADADO.Id, Filter.Equal, Id);

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
