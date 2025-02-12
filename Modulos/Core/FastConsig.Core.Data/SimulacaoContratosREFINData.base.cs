
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
	public partial class SimulacaoContratosREFINData : DataBase
	{
		
		#region Listar
		public List<SimulacaoContratosREFIN> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(SimulacaoContratosREFIN.METADADO.Id)
				.Field(SimulacaoContratosREFIN.METADADO.Simulacao)
				.Field(SimulacaoContratosREFIN.METADADO.Empresa)
				.Field(SimulacaoContratosREFIN.METADADO.Agencia)
				.Field(SimulacaoContratosREFIN.METADADO.Contrato)
				.Field(SimulacaoContratosREFIN.METADADO.CpfCnpj)
				.Field(SimulacaoContratosREFIN.METADADO.DataSituacao)
				.Field(SimulacaoContratosREFIN.METADADO.Emissao)
				.Field(SimulacaoContratosREFIN.METADADO.Vencimento)
				.Field(SimulacaoContratosREFIN.METADADO.Prazo)
				.Field(SimulacaoContratosREFIN.METADADO.Produto)
				.Field(SimulacaoContratosREFIN.METADADO.DiasAtraso)
				.Field(SimulacaoContratosREFIN.METADADO.Principal)
				.Field(SimulacaoContratosREFIN.METADADO.ValorContrato)
				.Field(SimulacaoContratosREFIN.METADADO.ValorTotalAPagar)
				.Field(SimulacaoContratosREFIN.METADADO.Tac)
				.Field(SimulacaoContratosREFIN.METADADO.Seguro)
				.Field(SimulacaoContratosREFIN.METADADO.TaxaMensal)
				.Field(SimulacaoContratosREFIN.METADADO.TaxaAnual)
				.Field(SimulacaoContratosREFIN.METADADO.SaldoDevedor)
				.Field(SimulacaoContratosREFIN.METADADO.DataSaldoDevedor)
				.Field(SimulacaoContratosREFIN.METADADO.SaldoAtual)
				.Field(SimulacaoContratosREFIN.METADADO.IofAtraso)
				.Field(SimulacaoContratosREFIN.METADADO.SaldoPrincipalEmAberto)
				.Field(SimulacaoContratosREFIN.METADADO.Matricula)
				.Field(SimulacaoContratosREFIN.METADADO.TipoBeneficio)
				.Field(SimulacaoContratosREFIN.METADADO.UfBeneficio)
				.Field(SimulacaoContratosREFIN.METADADO.Titularidade)
				.Field(SimulacaoContratosREFIN.METADADO.MeioRecebimentoBeneficio)
				.Field(SimulacaoContratosREFIN.METADADO.Utilizado)
				.Field(SimulacaoContratosREFIN.METADADO.ValorParcela)
				.Field(SimulacaoContratosREFIN.METADADO.ParcelasEmAberto)
				.Table(SimulacaoContratosREFIN.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				cmd.CommandTimeout = 600;
				query.SetParameters(cmd);

				List<SimulacaoContratosREFIN> result = base.MapReaderToEntitySet<SimulacaoContratosREFIN>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(SimulacaoContratosREFIN obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(SimulacaoContratosREFIN.METADADO.Simulacao, obj.Simulacao)
				.FieldValue(SimulacaoContratosREFIN.METADADO.Empresa, obj.Empresa)
				.FieldValue(SimulacaoContratosREFIN.METADADO.Agencia, obj.Agencia)
				.FieldValue(SimulacaoContratosREFIN.METADADO.Contrato, obj.Contrato)
				.FieldValue(SimulacaoContratosREFIN.METADADO.CpfCnpj, obj.CpfCnpj)
				.FieldValue(SimulacaoContratosREFIN.METADADO.DataSituacao, obj.DataSituacao)
				.FieldValue(SimulacaoContratosREFIN.METADADO.Emissao, obj.Emissao)
				.FieldValue(SimulacaoContratosREFIN.METADADO.Vencimento, obj.Vencimento)
				.FieldValue(SimulacaoContratosREFIN.METADADO.Prazo, obj.Prazo)
				.FieldValue(SimulacaoContratosREFIN.METADADO.Produto, obj.Produto)
				.FieldValue(SimulacaoContratosREFIN.METADADO.DiasAtraso, obj.DiasAtraso)
				.FieldValue(SimulacaoContratosREFIN.METADADO.Principal, obj.Principal)
				.FieldValue(SimulacaoContratosREFIN.METADADO.ValorContrato, obj.ValorContrato)
				.FieldValue(SimulacaoContratosREFIN.METADADO.ValorTotalAPagar, obj.ValorTotalAPagar)
				.FieldValue(SimulacaoContratosREFIN.METADADO.Tac, obj.Tac)
				.FieldValue(SimulacaoContratosREFIN.METADADO.Seguro, obj.Seguro)
				.FieldValue(SimulacaoContratosREFIN.METADADO.TaxaMensal, obj.TaxaMensal)
				.FieldValue(SimulacaoContratosREFIN.METADADO.TaxaAnual, obj.TaxaAnual)
				.FieldValue(SimulacaoContratosREFIN.METADADO.SaldoDevedor, obj.SaldoDevedor)
				.FieldValue(SimulacaoContratosREFIN.METADADO.DataSaldoDevedor, obj.DataSaldoDevedor)
				.FieldValue(SimulacaoContratosREFIN.METADADO.SaldoAtual, obj.SaldoAtual)
				.FieldValue(SimulacaoContratosREFIN.METADADO.IofAtraso, obj.IofAtraso)
				.FieldValue(SimulacaoContratosREFIN.METADADO.SaldoPrincipalEmAberto, obj.SaldoPrincipalEmAberto)
				.FieldValue(SimulacaoContratosREFIN.METADADO.Matricula, obj.Matricula)
				.FieldValue(SimulacaoContratosREFIN.METADADO.TipoBeneficio, obj.TipoBeneficio)
				.FieldValue(SimulacaoContratosREFIN.METADADO.UfBeneficio, obj.UfBeneficio)
				.FieldValue(SimulacaoContratosREFIN.METADADO.Titularidade, obj.Titularidade)
				.FieldValue(SimulacaoContratosREFIN.METADADO.MeioRecebimentoBeneficio, obj.MeioRecebimentoBeneficio)
				.FieldValue(SimulacaoContratosREFIN.METADADO.Utilizado, obj.Utilizado)
				.FieldValue(SimulacaoContratosREFIN.METADADO.ValorParcela, obj.ValorParcela)
				.FieldValue(SimulacaoContratosREFIN.METADADO.ParcelasEmAberto, obj.ParcelasEmAberto)
				.Table(SimulacaoContratosREFIN.METADADO.tabelaNAME);

			update.Where
				.Add(SimulacaoContratosREFIN.METADADO.Id, Filter.Equal, obj.Id);

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
		public void Incluir(SimulacaoContratosREFIN obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(SimulacaoContratosREFIN.METADADO.tabelaNAME)
				.FieldValue(SimulacaoContratosREFIN.METADADO.Simulacao, obj.Simulacao)
				.FieldValue(SimulacaoContratosREFIN.METADADO.Empresa, obj.Empresa)
				.FieldValue(SimulacaoContratosREFIN.METADADO.Agencia, obj.Agencia)
				.FieldValue(SimulacaoContratosREFIN.METADADO.Contrato, obj.Contrato)
				.FieldValue(SimulacaoContratosREFIN.METADADO.CpfCnpj, obj.CpfCnpj)
				.FieldValue(SimulacaoContratosREFIN.METADADO.DataSituacao, obj.DataSituacao)
				.FieldValue(SimulacaoContratosREFIN.METADADO.Emissao, obj.Emissao)
				.FieldValue(SimulacaoContratosREFIN.METADADO.Vencimento, obj.Vencimento)
				.FieldValue(SimulacaoContratosREFIN.METADADO.Prazo, obj.Prazo)
				.FieldValue(SimulacaoContratosREFIN.METADADO.Produto, obj.Produto)
				.FieldValue(SimulacaoContratosREFIN.METADADO.DiasAtraso, obj.DiasAtraso)
				.FieldValue(SimulacaoContratosREFIN.METADADO.Principal, obj.Principal)
				.FieldValue(SimulacaoContratosREFIN.METADADO.ValorContrato, obj.ValorContrato)
				.FieldValue(SimulacaoContratosREFIN.METADADO.ValorTotalAPagar, obj.ValorTotalAPagar)
				.FieldValue(SimulacaoContratosREFIN.METADADO.Tac, obj.Tac)
				.FieldValue(SimulacaoContratosREFIN.METADADO.Seguro, obj.Seguro)
				.FieldValue(SimulacaoContratosREFIN.METADADO.TaxaMensal, obj.TaxaMensal)
				.FieldValue(SimulacaoContratosREFIN.METADADO.TaxaAnual, obj.TaxaAnual)
				.FieldValue(SimulacaoContratosREFIN.METADADO.SaldoDevedor, obj.SaldoDevedor)
				.FieldValue(SimulacaoContratosREFIN.METADADO.DataSaldoDevedor, obj.DataSaldoDevedor)
				.FieldValue(SimulacaoContratosREFIN.METADADO.SaldoAtual, obj.SaldoAtual)
				.FieldValue(SimulacaoContratosREFIN.METADADO.IofAtraso, obj.IofAtraso)
				.FieldValue(SimulacaoContratosREFIN.METADADO.SaldoPrincipalEmAberto, obj.SaldoPrincipalEmAberto)
				.FieldValue(SimulacaoContratosREFIN.METADADO.Matricula, obj.Matricula)
				.FieldValue(SimulacaoContratosREFIN.METADADO.TipoBeneficio, obj.TipoBeneficio)
				.FieldValue(SimulacaoContratosREFIN.METADADO.UfBeneficio, obj.UfBeneficio)
				.FieldValue(SimulacaoContratosREFIN.METADADO.Titularidade, obj.Titularidade)
				.FieldValue(SimulacaoContratosREFIN.METADADO.MeioRecebimentoBeneficio, obj.MeioRecebimentoBeneficio)
				.FieldValue(SimulacaoContratosREFIN.METADADO.Utilizado, obj.Utilizado)
				.FieldValue(SimulacaoContratosREFIN.METADADO.ValorParcela, obj.ValorParcela)
				.FieldValue(SimulacaoContratosREFIN.METADADO.ParcelasEmAberto, obj.ParcelasEmAberto)
				.SetIdentityField(SimulacaoContratosREFIN.METADADO.Id);

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
		public SimulacaoContratosREFIN Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(SimulacaoContratosREFIN.METADADO.Id)
				.Field(SimulacaoContratosREFIN.METADADO.Simulacao)
				.Field(SimulacaoContratosREFIN.METADADO.Empresa)
				.Field(SimulacaoContratosREFIN.METADADO.Agencia)
				.Field(SimulacaoContratosREFIN.METADADO.Contrato)
				.Field(SimulacaoContratosREFIN.METADADO.CpfCnpj)
				.Field(SimulacaoContratosREFIN.METADADO.DataSituacao)
				.Field(SimulacaoContratosREFIN.METADADO.Emissao)
				.Field(SimulacaoContratosREFIN.METADADO.Vencimento)
				.Field(SimulacaoContratosREFIN.METADADO.Prazo)
				.Field(SimulacaoContratosREFIN.METADADO.Produto)
				.Field(SimulacaoContratosREFIN.METADADO.DiasAtraso)
				.Field(SimulacaoContratosREFIN.METADADO.Principal)
				.Field(SimulacaoContratosREFIN.METADADO.ValorContrato)
				.Field(SimulacaoContratosREFIN.METADADO.ValorTotalAPagar)
				.Field(SimulacaoContratosREFIN.METADADO.Tac)
				.Field(SimulacaoContratosREFIN.METADADO.Seguro)
				.Field(SimulacaoContratosREFIN.METADADO.TaxaMensal)
				.Field(SimulacaoContratosREFIN.METADADO.TaxaAnual)
				.Field(SimulacaoContratosREFIN.METADADO.SaldoDevedor)
				.Field(SimulacaoContratosREFIN.METADADO.DataSaldoDevedor)
				.Field(SimulacaoContratosREFIN.METADADO.SaldoAtual)
				.Field(SimulacaoContratosREFIN.METADADO.IofAtraso)
				.Field(SimulacaoContratosREFIN.METADADO.SaldoPrincipalEmAberto)
				.Field(SimulacaoContratosREFIN.METADADO.Matricula)
				.Field(SimulacaoContratosREFIN.METADADO.TipoBeneficio)
				.Field(SimulacaoContratosREFIN.METADADO.UfBeneficio)
				.Field(SimulacaoContratosREFIN.METADADO.Titularidade)
				.Field(SimulacaoContratosREFIN.METADADO.MeioRecebimentoBeneficio)
				.Field(SimulacaoContratosREFIN.METADADO.Utilizado)
				.Field(SimulacaoContratosREFIN.METADADO.ValorParcela)
				.Field(SimulacaoContratosREFIN.METADADO.ParcelasEmAberto)
				.Table(SimulacaoContratosREFIN.METADADO.tabelaNAME);

			query.Where
				.Add(SimulacaoContratosREFIN.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				cmd.CommandTimeout = 600;
				query.SetParameters(cmd);

				SimulacaoContratosREFIN result = base.MapReaderToEntity<SimulacaoContratosREFIN>(cmd);
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
				delete.Table(SimulacaoContratosREFIN.METADADO.tabelaNAME);
			delete.Where
				.Add(SimulacaoContratosREFIN.METADADO.Id, Filter.Equal, Id);

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
