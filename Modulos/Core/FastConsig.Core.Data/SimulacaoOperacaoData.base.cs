
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
	public partial class SimulacaoOperacaoData : DataBase
	{
		
		#region Listar
		public List<SimulacaoOperacao> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(SimulacaoOperacao.METADADO.Id)
				.Field(SimulacaoOperacao.METADADO.Simulacao)
				.Field(SimulacaoOperacao.METADADO.Produto)
				.Field(SimulacaoOperacao.METADADO.Prazo)
				.Field(SimulacaoOperacao.METADADO.ValorOperacao)
				.Field(SimulacaoOperacao.METADADO.Taxa)
				.Field(SimulacaoOperacao.METADADO.ValorEntrada)
				.Field(SimulacaoOperacao.METADADO.ValorParcela)
				.Field(SimulacaoOperacao.METADADO.ValorTAC)
				.Field(SimulacaoOperacao.METADADO.ValorTFC)
				.Field(SimulacaoOperacao.METADADO.ValorPST)
				.Field(SimulacaoOperacao.METADADO.ValorSeguro)
				.Field(SimulacaoOperacao.METADADO.ValorIOF)
				.Field(SimulacaoOperacao.METADADO.ValorIOFNormal)
				.Field(SimulacaoOperacao.METADADO.ValorIOFAdicional)
				.Field(SimulacaoOperacao.METADADO.ValorFinanciadoTotal)
				.Field(SimulacaoOperacao.METADADO.ValorLiberado)
				.Field(SimulacaoOperacao.METADADO.TaxaMes)
				.Field(SimulacaoOperacao.METADADO.TaxaAno)
				.Field(SimulacaoOperacao.METADADO.CETMes)
				.Field(SimulacaoOperacao.METADADO.CETAno)
				.Field(SimulacaoOperacao.METADADO.DataEmissao)
				.Field(SimulacaoOperacao.METADADO.DataPrimeiroVencimento)
				.Field(SimulacaoOperacao.METADADO.RedeLojas)
				.Field(SimulacaoOperacao.METADADO.Loja)
				.Field(SimulacaoOperacao.METADADO.Tabela)
				.Field(SimulacaoOperacao.METADADO.TacFinanciada)
				.Field(SimulacaoOperacao.METADADO.IOFFinaciado)
				.Field(SimulacaoOperacao.METADADO.ValorGarantia)
				.Field(SimulacaoOperacao.METADADO.MetodoAmortizacao)
				.Field(SimulacaoOperacao.METADADO.ValorIndexadorProjetado)
				.Field(SimulacaoOperacao.METADADO.ObjetivoEmprestimo)
				.Field(SimulacaoOperacao.METADADO.ValorMargem)
				.Field(SimulacaoOperacao.METADADO.ValorRenegociacaoTotal)
				.Table(SimulacaoOperacao.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				cmd.CommandTimeout = 600;
				query.SetParameters(cmd);

				List<SimulacaoOperacao> result = base.MapReaderToEntitySet<SimulacaoOperacao>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(SimulacaoOperacao obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(SimulacaoOperacao.METADADO.Simulacao, obj.Simulacao)
				.FieldValue(SimulacaoOperacao.METADADO.Produto, obj.Produto)
				.FieldValue(SimulacaoOperacao.METADADO.Prazo, obj.Prazo)
				.FieldValue(SimulacaoOperacao.METADADO.ValorOperacao, obj.ValorOperacao)
				.FieldValue(SimulacaoOperacao.METADADO.Taxa, obj.Taxa)
				.FieldValue(SimulacaoOperacao.METADADO.ValorEntrada, obj.ValorEntrada)
				.FieldValue(SimulacaoOperacao.METADADO.ValorParcela, obj.ValorParcela)
				.FieldValue(SimulacaoOperacao.METADADO.ValorTAC, obj.ValorTAC)
				.FieldValue(SimulacaoOperacao.METADADO.ValorTFC, obj.ValorTFC)
				.FieldValue(SimulacaoOperacao.METADADO.ValorPST, obj.ValorPST)
				.FieldValue(SimulacaoOperacao.METADADO.ValorSeguro, obj.ValorSeguro)
				.FieldValue(SimulacaoOperacao.METADADO.ValorIOF, obj.ValorIOF)
				.FieldValue(SimulacaoOperacao.METADADO.ValorIOFNormal, obj.ValorIOFNormal)
				.FieldValue(SimulacaoOperacao.METADADO.ValorIOFAdicional, obj.ValorIOFAdicional)
				.FieldValue(SimulacaoOperacao.METADADO.ValorFinanciadoTotal, obj.ValorFinanciadoTotal)
				.FieldValue(SimulacaoOperacao.METADADO.ValorLiberado, obj.ValorLiberado)
				.FieldValue(SimulacaoOperacao.METADADO.TaxaMes, obj.TaxaMes)
				.FieldValue(SimulacaoOperacao.METADADO.TaxaAno, obj.TaxaAno)
				.FieldValue(SimulacaoOperacao.METADADO.CETMes, obj.CETMes)
				.FieldValue(SimulacaoOperacao.METADADO.CETAno, obj.CETAno)
				.FieldValue(SimulacaoOperacao.METADADO.DataEmissao, obj.DataEmissao)
				.FieldValue(SimulacaoOperacao.METADADO.DataPrimeiroVencimento, obj.DataPrimeiroVencimento)
				.FieldValue(SimulacaoOperacao.METADADO.RedeLojas, obj.RedeLojas)
				.FieldValue(SimulacaoOperacao.METADADO.Loja, obj.Loja)
				.FieldValue(SimulacaoOperacao.METADADO.Tabela, obj.Tabela)
				.FieldValue(SimulacaoOperacao.METADADO.TacFinanciada, obj.TacFinanciada)
				.FieldValue(SimulacaoOperacao.METADADO.IOFFinaciado, obj.IOFFinaciado)
				.FieldValue(SimulacaoOperacao.METADADO.ValorGarantia, obj.ValorGarantia)
				.FieldValue(SimulacaoOperacao.METADADO.MetodoAmortizacao, obj.MetodoAmortizacao)
				.FieldValue(SimulacaoOperacao.METADADO.ValorIndexadorProjetado, obj.ValorIndexadorProjetado)
				.FieldValue(SimulacaoOperacao.METADADO.ObjetivoEmprestimo, obj.ObjetivoEmprestimo)
				.FieldValue(SimulacaoOperacao.METADADO.ValorMargem, obj.ValorMargem)
				.FieldValue(SimulacaoOperacao.METADADO.ValorRenegociacaoTotal, obj.ValorRenegociacaoTotal)
				.Table(SimulacaoOperacao.METADADO.tabelaNAME);

			update.Where
				.Add(SimulacaoOperacao.METADADO.Id, Filter.Equal, obj.Id);

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
		public void Incluir(SimulacaoOperacao obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(SimulacaoOperacao.METADADO.tabelaNAME)
				.FieldValue(SimulacaoOperacao.METADADO.Simulacao, obj.Simulacao)
				.FieldValue(SimulacaoOperacao.METADADO.Produto, obj.Produto)
				.FieldValue(SimulacaoOperacao.METADADO.Prazo, obj.Prazo)
				.FieldValue(SimulacaoOperacao.METADADO.ValorOperacao, obj.ValorOperacao)
				.FieldValue(SimulacaoOperacao.METADADO.Taxa, obj.Taxa)
				.FieldValue(SimulacaoOperacao.METADADO.ValorEntrada, obj.ValorEntrada)
				.FieldValue(SimulacaoOperacao.METADADO.ValorParcela, obj.ValorParcela)
				.FieldValue(SimulacaoOperacao.METADADO.ValorTAC, obj.ValorTAC)
				.FieldValue(SimulacaoOperacao.METADADO.ValorTFC, obj.ValorTFC)
				.FieldValue(SimulacaoOperacao.METADADO.ValorPST, obj.ValorPST)
				.FieldValue(SimulacaoOperacao.METADADO.ValorSeguro, obj.ValorSeguro)
				.FieldValue(SimulacaoOperacao.METADADO.ValorIOF, obj.ValorIOF)
				.FieldValue(SimulacaoOperacao.METADADO.ValorIOFNormal, obj.ValorIOFNormal)
				.FieldValue(SimulacaoOperacao.METADADO.ValorIOFAdicional, obj.ValorIOFAdicional)
				.FieldValue(SimulacaoOperacao.METADADO.ValorFinanciadoTotal, obj.ValorFinanciadoTotal)
				.FieldValue(SimulacaoOperacao.METADADO.ValorLiberado, obj.ValorLiberado)
				.FieldValue(SimulacaoOperacao.METADADO.TaxaMes, obj.TaxaMes)
				.FieldValue(SimulacaoOperacao.METADADO.TaxaAno, obj.TaxaAno)
				.FieldValue(SimulacaoOperacao.METADADO.CETMes, obj.CETMes)
				.FieldValue(SimulacaoOperacao.METADADO.CETAno, obj.CETAno)
				.FieldValue(SimulacaoOperacao.METADADO.DataEmissao, obj.DataEmissao)
				.FieldValue(SimulacaoOperacao.METADADO.DataPrimeiroVencimento, obj.DataPrimeiroVencimento)
				.FieldValue(SimulacaoOperacao.METADADO.RedeLojas, obj.RedeLojas)
				.FieldValue(SimulacaoOperacao.METADADO.Loja, obj.Loja)
				.FieldValue(SimulacaoOperacao.METADADO.Tabela, obj.Tabela)
				.FieldValue(SimulacaoOperacao.METADADO.TacFinanciada, obj.TacFinanciada)
				.FieldValue(SimulacaoOperacao.METADADO.IOFFinaciado, obj.IOFFinaciado)
				.FieldValue(SimulacaoOperacao.METADADO.ValorGarantia, obj.ValorGarantia)
				.FieldValue(SimulacaoOperacao.METADADO.MetodoAmortizacao, obj.MetodoAmortizacao)
				.FieldValue(SimulacaoOperacao.METADADO.ValorIndexadorProjetado, obj.ValorIndexadorProjetado)
				.FieldValue(SimulacaoOperacao.METADADO.ObjetivoEmprestimo, obj.ObjetivoEmprestimo)
				.FieldValue(SimulacaoOperacao.METADADO.ValorMargem, obj.ValorMargem)
				.FieldValue(SimulacaoOperacao.METADADO.ValorRenegociacaoTotal, obj.ValorRenegociacaoTotal)
				.SetIdentityField(SimulacaoOperacao.METADADO.Id);

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
		public SimulacaoOperacao Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(SimulacaoOperacao.METADADO.Id)
				.Field(SimulacaoOperacao.METADADO.Simulacao)
				.Field(SimulacaoOperacao.METADADO.Produto)
				.Field(SimulacaoOperacao.METADADO.Prazo)
				.Field(SimulacaoOperacao.METADADO.ValorOperacao)
				.Field(SimulacaoOperacao.METADADO.Taxa)
				.Field(SimulacaoOperacao.METADADO.ValorEntrada)
				.Field(SimulacaoOperacao.METADADO.ValorParcela)
				.Field(SimulacaoOperacao.METADADO.ValorTAC)
				.Field(SimulacaoOperacao.METADADO.ValorTFC)
				.Field(SimulacaoOperacao.METADADO.ValorPST)
				.Field(SimulacaoOperacao.METADADO.ValorSeguro)
				.Field(SimulacaoOperacao.METADADO.ValorIOF)
				.Field(SimulacaoOperacao.METADADO.ValorIOFNormal)
				.Field(SimulacaoOperacao.METADADO.ValorIOFAdicional)
				.Field(SimulacaoOperacao.METADADO.ValorFinanciadoTotal)
				.Field(SimulacaoOperacao.METADADO.ValorLiberado)
				.Field(SimulacaoOperacao.METADADO.TaxaMes)
				.Field(SimulacaoOperacao.METADADO.TaxaAno)
				.Field(SimulacaoOperacao.METADADO.CETMes)
				.Field(SimulacaoOperacao.METADADO.CETAno)
				.Field(SimulacaoOperacao.METADADO.DataEmissao)
				.Field(SimulacaoOperacao.METADADO.DataPrimeiroVencimento)
				.Field(SimulacaoOperacao.METADADO.RedeLojas)
				.Field(SimulacaoOperacao.METADADO.Loja)
				.Field(SimulacaoOperacao.METADADO.Tabela)
				.Field(SimulacaoOperacao.METADADO.TacFinanciada)
				.Field(SimulacaoOperacao.METADADO.IOFFinaciado)
				.Field(SimulacaoOperacao.METADADO.ValorGarantia)
				.Field(SimulacaoOperacao.METADADO.MetodoAmortizacao)
				.Field(SimulacaoOperacao.METADADO.ValorIndexadorProjetado)
				.Field(SimulacaoOperacao.METADADO.ObjetivoEmprestimo)
				.Field(SimulacaoOperacao.METADADO.ValorMargem)
				.Field(SimulacaoOperacao.METADADO.ValorRenegociacaoTotal)
				.Table(SimulacaoOperacao.METADADO.tabelaNAME);

			query.Where
				.Add(SimulacaoOperacao.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				cmd.CommandTimeout = 600;
				query.SetParameters(cmd);

				SimulacaoOperacao result = base.MapReaderToEntity<SimulacaoOperacao>(cmd);
				return result;
			}
		}
		#endregion

		#region Excluir por FKs
		public void ExcluirPor_Simulacao(int? Simulacao)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(SimulacaoOperacao.METADADO.tabelaNAME);
			delete.Where
				.Add(SimulacaoOperacao.METADADO.Simulacao, Filter.Equal, Simulacao);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, delete.ToString());
				cmd.CommandTimeout = 600;
				delete.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		public void ExcluirPor_Produto(int? Produto)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(SimulacaoOperacao.METADADO.tabelaNAME);
			delete.Where
				.Add(SimulacaoOperacao.METADADO.Produto, Filter.Equal, Produto);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, delete.ToString());
				cmd.CommandTimeout = 600;
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
				delete.Table(SimulacaoOperacao.METADADO.tabelaNAME);
			delete.Where
				.Add(SimulacaoOperacao.METADADO.Id, Filter.Equal, Id);

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
