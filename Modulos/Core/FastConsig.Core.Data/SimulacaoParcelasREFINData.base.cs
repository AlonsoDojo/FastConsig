
#region Usings
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Framework;
using Framework.Data;
using FastConsig.Core.Entity;
#endregion

namespace FastConsig.Core.Data
{
	public partial class SimulacaoParcelasREFINData : DataBase
	{
		
		#region Listar
		public List<SimulacaoParcelasREFIN> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(SimulacaoParcelasREFIN.METADADO.Id)
				.Field(SimulacaoParcelasREFIN.METADADO.Simulacao)
				.Field(SimulacaoParcelasREFIN.METADADO.Empresa)
				.Field(SimulacaoParcelasREFIN.METADADO.Agencia)
				.Field(SimulacaoParcelasREFIN.METADADO.Contrato)
				.Field(SimulacaoParcelasREFIN.METADADO.Parcela)
				.Field(SimulacaoParcelasREFIN.METADADO.Vencimento)
				.Field(SimulacaoParcelasREFIN.METADADO.ValorPrestacao)
				.Field(SimulacaoParcelasREFIN.METADADO.SaldoDevedor)
				.Field(SimulacaoParcelasREFIN.METADADO.Situacao)
				.Field(SimulacaoParcelasREFIN.METADADO.DataPagamento)
				.Field(SimulacaoParcelasREFIN.METADADO.PrincipalEmAberto)
				.Field(SimulacaoParcelasREFIN.METADADO.DiasAtraso)
				.Field(SimulacaoParcelasREFIN.METADADO.Utilizado)
				.Table(SimulacaoParcelasREFIN.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				cmd.CommandTimeout = 600;
				query.SetParameters(cmd);

				List<SimulacaoParcelasREFIN> result = base.MapReaderToEntitySet<SimulacaoParcelasREFIN>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(SimulacaoParcelasREFIN obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(SimulacaoParcelasREFIN.METADADO.Simulacao, obj.Simulacao)
				.FieldValue(SimulacaoParcelasREFIN.METADADO.Empresa, obj.Empresa)
				.FieldValue(SimulacaoParcelasREFIN.METADADO.Agencia, obj.Agencia)
				.FieldValue(SimulacaoParcelasREFIN.METADADO.Contrato, obj.Contrato)
				.FieldValue(SimulacaoParcelasREFIN.METADADO.Parcela, obj.Parcela)
				.FieldValue(SimulacaoParcelasREFIN.METADADO.Vencimento, obj.Vencimento)
				.FieldValue(SimulacaoParcelasREFIN.METADADO.ValorPrestacao, obj.ValorPrestacao)
				.FieldValue(SimulacaoParcelasREFIN.METADADO.SaldoDevedor, obj.SaldoDevedor)
				.FieldValue(SimulacaoParcelasREFIN.METADADO.Situacao, obj.Situacao)
				.FieldValue(SimulacaoParcelasREFIN.METADADO.DataPagamento, obj.DataPagamento)
				.FieldValue(SimulacaoParcelasREFIN.METADADO.PrincipalEmAberto, obj.PrincipalEmAberto)
				.FieldValue(SimulacaoParcelasREFIN.METADADO.DiasAtraso, obj.DiasAtraso)
				.FieldValue(SimulacaoParcelasREFIN.METADADO.Utilizado, obj.Utilizado)
				.Table(SimulacaoParcelasREFIN.METADADO.tabelaNAME);

			update.Where
				.Add(SimulacaoParcelasREFIN.METADADO.Id, Filter.Equal, obj.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, update.ToString());
				cmd.CommandTimeout = 600;
				update.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

		#region Inserir
		public void Incluir(SimulacaoParcelasREFIN obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(SimulacaoParcelasREFIN.METADADO.tabelaNAME)
				.FieldValue(SimulacaoParcelasREFIN.METADADO.Simulacao, obj.Simulacao)
				.FieldValue(SimulacaoParcelasREFIN.METADADO.Empresa, obj.Empresa)
				.FieldValue(SimulacaoParcelasREFIN.METADADO.Agencia, obj.Agencia)
				.FieldValue(SimulacaoParcelasREFIN.METADADO.Contrato, obj.Contrato)
				.FieldValue(SimulacaoParcelasREFIN.METADADO.Parcela, obj.Parcela)
				.FieldValue(SimulacaoParcelasREFIN.METADADO.Vencimento, obj.Vencimento)
				.FieldValue(SimulacaoParcelasREFIN.METADADO.ValorPrestacao, obj.ValorPrestacao)
				.FieldValue(SimulacaoParcelasREFIN.METADADO.SaldoDevedor, obj.SaldoDevedor)
				.FieldValue(SimulacaoParcelasREFIN.METADADO.Situacao, obj.Situacao)
				.FieldValue(SimulacaoParcelasREFIN.METADADO.DataPagamento, obj.DataPagamento)
				.FieldValue(SimulacaoParcelasREFIN.METADADO.PrincipalEmAberto, obj.PrincipalEmAberto)
				.FieldValue(SimulacaoParcelasREFIN.METADADO.DiasAtraso, obj.DiasAtraso)
				.FieldValue(SimulacaoParcelasREFIN.METADADO.Utilizado, obj.Utilizado)
				.SetIdentityField(SimulacaoParcelasREFIN.METADADO.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, insert.ToString());
				cmd.CommandTimeout = 600;
				insert.SetParameters(cmd);

				obj.Id = base.ExecuteScalar<int?>(cmd);
			}
		}
		#endregion

		#region Obtem
		public SimulacaoParcelasREFIN Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(SimulacaoParcelasREFIN.METADADO.Id)
				.Field(SimulacaoParcelasREFIN.METADADO.Simulacao)
				.Field(SimulacaoParcelasREFIN.METADADO.Empresa)
				.Field(SimulacaoParcelasREFIN.METADADO.Agencia)
				.Field(SimulacaoParcelasREFIN.METADADO.Contrato)
				.Field(SimulacaoParcelasREFIN.METADADO.Parcela)
				.Field(SimulacaoParcelasREFIN.METADADO.Vencimento)
				.Field(SimulacaoParcelasREFIN.METADADO.ValorPrestacao)
				.Field(SimulacaoParcelasREFIN.METADADO.SaldoDevedor)
				.Field(SimulacaoParcelasREFIN.METADADO.Situacao)
				.Field(SimulacaoParcelasREFIN.METADADO.DataPagamento)
				.Field(SimulacaoParcelasREFIN.METADADO.PrincipalEmAberto)
				.Field(SimulacaoParcelasREFIN.METADADO.DiasAtraso)
				.Field(SimulacaoParcelasREFIN.METADADO.Utilizado)
				.Table(SimulacaoParcelasREFIN.METADADO.tabelaNAME);

			query.Where
				.Add(SimulacaoParcelasREFIN.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				cmd.CommandTimeout = 600;
				query.SetParameters(cmd);

				SimulacaoParcelasREFIN result = base.MapReaderToEntity<SimulacaoParcelasREFIN>(cmd);
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
				delete.Table(SimulacaoParcelasREFIN.METADADO.tabelaNAME);
			delete.Where
				.Add(SimulacaoParcelasREFIN.METADADO.Id, Filter.Equal, Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, delete.ToString());
				cmd.CommandTimeout = 600;
				delete.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

	}
}
