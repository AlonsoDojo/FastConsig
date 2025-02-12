
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
	public partial class PropostaOperacaoData : DataBase
	{
		
		#region Listar
		public List<PropostaOperacao> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(PropostaOperacao.METADADO.Proposta)
				.Field(PropostaOperacao.METADADO.Operacao)
				.Field(PropostaOperacao.METADADO.Produto)
				.Field(PropostaOperacao.METADADO.Prazo)
				.Field(PropostaOperacao.METADADO.ValorOperacao)
				.Field(PropostaOperacao.METADADO.Taxa)
				.Field(PropostaOperacao.METADADO.ValorEntrada)
				.Field(PropostaOperacao.METADADO.ValorParcela)
				.Field(PropostaOperacao.METADADO.ValorTAC)
				.Field(PropostaOperacao.METADADO.ValorTFC)
				.Field(PropostaOperacao.METADADO.ValorPST)
				.Field(PropostaOperacao.METADADO.ValorSeguro)
				.Field(PropostaOperacao.METADADO.ValorIOF)
				.Field(PropostaOperacao.METADADO.ValorIOFNormal)
				.Field(PropostaOperacao.METADADO.ValorIOFAdicional)
				.Field(PropostaOperacao.METADADO.ValorFinanciadoTotal)
				.Field(PropostaOperacao.METADADO.ValorLiberado)
				.Field(PropostaOperacao.METADADO.TaxaMes)
				.Field(PropostaOperacao.METADADO.TaxaAno)
				.Field(PropostaOperacao.METADADO.CETMes)
				.Field(PropostaOperacao.METADADO.CETAno)
				.Field(PropostaOperacao.METADADO.DataEmissao)
				.Field(PropostaOperacao.METADADO.DataPrimeiroVencimento)
				.Field(PropostaOperacao.METADADO.Simulacao)
				.Field(PropostaOperacao.METADADO.MeioLiberacao)
				.Field(PropostaOperacao.METADADO.Banco)
				.Field(PropostaOperacao.METADADO.Agencia)
				.Field(PropostaOperacao.METADADO.Conta)
				.Field(PropostaOperacao.METADADO.PropostaLegado)
				.Field(PropostaOperacao.METADADO.ContratoLegado)
				.Field(PropostaOperacao.METADADO.RedeLojas)
				.Field(PropostaOperacao.METADADO.Loja)
				.Field(PropostaOperacao.METADADO.Tabela)
				.Field(PropostaOperacao.METADADO.TacFinanciada)
				.Field(PropostaOperacao.METADADO.IOFFinaciado)
				.Field(PropostaOperacao.METADADO.EspecieBeneficio)
				.Field(PropostaOperacao.METADADO.ComprometimentoRenda)
				.Field(PropostaOperacao.METADADO.Autorizacao)
				.Field(PropostaOperacao.METADADO.ValorMargem)
				.Field(PropostaOperacao.METADADO.ValorRenegociacaoTotal)
				.Field(PropostaOperacao.METADADO.MeioLiquidacao)
				.Field(PropostaOperacao.METADADO.BancoLiquidacao)
				.Field(PropostaOperacao.METADADO.AgenciaLiquidacao)
				.Field(PropostaOperacao.METADADO.ContaLiquidacao)
            .Field(PropostaOperacao.METADADO.ChavePIX)
            .Table(PropostaOperacao.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				cmd.CommandTimeout = 600;
				query.SetParameters(cmd);

				List<PropostaOperacao> result = base.MapReaderToEntitySet<PropostaOperacao>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(PropostaOperacao obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(PropostaOperacao.METADADO.Proposta, obj.Proposta)
				.FieldValue(PropostaOperacao.METADADO.Operacao, obj.Operacao)
				.FieldValue(PropostaOperacao.METADADO.Produto, obj.Produto)
				.FieldValue(PropostaOperacao.METADADO.Prazo, obj.Prazo)
				.FieldValue(PropostaOperacao.METADADO.ValorOperacao, obj.ValorOperacao)
				.FieldValue(PropostaOperacao.METADADO.Taxa, obj.Taxa)
				.FieldValue(PropostaOperacao.METADADO.ValorEntrada, obj.ValorEntrada)
				.FieldValue(PropostaOperacao.METADADO.ValorParcela, obj.ValorParcela)
				.FieldValue(PropostaOperacao.METADADO.ValorTAC, obj.ValorTAC)
				.FieldValue(PropostaOperacao.METADADO.ValorTFC, obj.ValorTFC)
				.FieldValue(PropostaOperacao.METADADO.ValorPST, obj.ValorPST)
				.FieldValue(PropostaOperacao.METADADO.ValorSeguro, obj.ValorSeguro)
				.FieldValue(PropostaOperacao.METADADO.ValorIOF, obj.ValorIOF)
				.FieldValue(PropostaOperacao.METADADO.ValorIOFNormal, obj.ValorIOFNormal)
				.FieldValue(PropostaOperacao.METADADO.ValorIOFAdicional, obj.ValorIOFAdicional)
				.FieldValue(PropostaOperacao.METADADO.ValorFinanciadoTotal, obj.ValorFinanciadoTotal)
				.FieldValue(PropostaOperacao.METADADO.ValorLiberado, obj.ValorLiberado)
				.FieldValue(PropostaOperacao.METADADO.TaxaMes, obj.TaxaMes)
				.FieldValue(PropostaOperacao.METADADO.TaxaAno, obj.TaxaAno)
				.FieldValue(PropostaOperacao.METADADO.CETMes, obj.CETMes)
				.FieldValue(PropostaOperacao.METADADO.CETAno, obj.CETAno)
				.FieldValue(PropostaOperacao.METADADO.DataEmissao, obj.DataEmissao)
				.FieldValue(PropostaOperacao.METADADO.DataPrimeiroVencimento, obj.DataPrimeiroVencimento)
				.FieldValue(PropostaOperacao.METADADO.Simulacao, obj.Simulacao)
				.FieldValue(PropostaOperacao.METADADO.MeioLiberacao, obj.MeioLiberacao)
				.FieldValue(PropostaOperacao.METADADO.Banco, obj.Banco)
				.FieldValue(PropostaOperacao.METADADO.Agencia, obj.Agencia)
				.FieldValue(PropostaOperacao.METADADO.Conta, obj.Conta)
				.FieldValue(PropostaOperacao.METADADO.PropostaLegado, obj.PropostaLegado)
				.FieldValue(PropostaOperacao.METADADO.ContratoLegado, obj.ContratoLegado)
				.FieldValue(PropostaOperacao.METADADO.RedeLojas, obj.RedeLojas)
				.FieldValue(PropostaOperacao.METADADO.Loja, obj.Loja)
				.FieldValue(PropostaOperacao.METADADO.Tabela, obj.Tabela)
				.FieldValue(PropostaOperacao.METADADO.TacFinanciada, obj.TacFinanciada)
				.FieldValue(PropostaOperacao.METADADO.IOFFinaciado, obj.IOFFinaciado)
				.FieldValue(PropostaOperacao.METADADO.EspecieBeneficio, obj.EspecieBeneficio)
				.FieldValue(PropostaOperacao.METADADO.ComprometimentoRenda, obj.ComprometimentoRenda)
				.FieldValue(PropostaOperacao.METADADO.Autorizacao, obj.Autorizacao)
				.FieldValue(PropostaOperacao.METADADO.ValorMargem, obj.ValorMargem)
				.FieldValue(PropostaOperacao.METADADO.ValorRenegociacaoTotal, obj.ValorRenegociacaoTotal)
				.FieldValue(PropostaOperacao.METADADO.MeioLiquidacao, obj.MeioLiquidacao)
				.FieldValue(PropostaOperacao.METADADO.BancoLiquidacao, obj.BancoLiquidacao)
				.FieldValue(PropostaOperacao.METADADO.AgenciaLiquidacao, obj.AgenciaLiquidacao)
				.FieldValue(PropostaOperacao.METADADO.ContaLiquidacao, obj.ContaLiquidacao)
            .FieldValue(PropostaOperacao.METADADO.ChavePIX, obj.ChavePIX)
            .Table(PropostaOperacao.METADADO.tabelaNAME);

			update.Where
				.Add(PropostaOperacao.METADADO.Operacao, Filter.Equal, obj.Operacao);

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
		public void Incluir(PropostaOperacao obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(PropostaOperacao.METADADO.tabelaNAME)
				.FieldValue(PropostaOperacao.METADADO.Proposta, obj.Proposta)
				.FieldValue(PropostaOperacao.METADADO.Produto, obj.Produto)
				.FieldValue(PropostaOperacao.METADADO.Prazo, obj.Prazo)
				.FieldValue(PropostaOperacao.METADADO.ValorOperacao, obj.ValorOperacao)
				.FieldValue(PropostaOperacao.METADADO.Taxa, obj.Taxa)
				.FieldValue(PropostaOperacao.METADADO.ValorEntrada, obj.ValorEntrada)
				.FieldValue(PropostaOperacao.METADADO.ValorParcela, obj.ValorParcela)
				.FieldValue(PropostaOperacao.METADADO.ValorTAC, obj.ValorTAC)
				.FieldValue(PropostaOperacao.METADADO.ValorTFC, obj.ValorTFC)
				.FieldValue(PropostaOperacao.METADADO.ValorPST, obj.ValorPST)
				.FieldValue(PropostaOperacao.METADADO.ValorSeguro, obj.ValorSeguro)
				.FieldValue(PropostaOperacao.METADADO.ValorIOF, obj.ValorIOF)
				.FieldValue(PropostaOperacao.METADADO.ValorIOFNormal, obj.ValorIOFNormal)
				.FieldValue(PropostaOperacao.METADADO.ValorIOFAdicional, obj.ValorIOFAdicional)
				.FieldValue(PropostaOperacao.METADADO.ValorFinanciadoTotal, obj.ValorFinanciadoTotal)
				.FieldValue(PropostaOperacao.METADADO.ValorLiberado, obj.ValorLiberado)
				.FieldValue(PropostaOperacao.METADADO.TaxaMes, obj.TaxaMes)
				.FieldValue(PropostaOperacao.METADADO.TaxaAno, obj.TaxaAno)
				.FieldValue(PropostaOperacao.METADADO.CETMes, obj.CETMes)
				.FieldValue(PropostaOperacao.METADADO.CETAno, obj.CETAno)
				.FieldValue(PropostaOperacao.METADADO.DataEmissao, obj.DataEmissao)
				.FieldValue(PropostaOperacao.METADADO.DataPrimeiroVencimento, obj.DataPrimeiroVencimento)
				.FieldValue(PropostaOperacao.METADADO.Simulacao, obj.Simulacao)
				.FieldValue(PropostaOperacao.METADADO.MeioLiberacao, obj.MeioLiberacao)
				.FieldValue(PropostaOperacao.METADADO.Banco, obj.Banco)
				.FieldValue(PropostaOperacao.METADADO.Agencia, obj.Agencia)
				.FieldValue(PropostaOperacao.METADADO.Conta, obj.Conta)
				.FieldValue(PropostaOperacao.METADADO.PropostaLegado, obj.PropostaLegado)
				.FieldValue(PropostaOperacao.METADADO.ContratoLegado, obj.ContratoLegado)
				.FieldValue(PropostaOperacao.METADADO.RedeLojas, obj.RedeLojas)
				.FieldValue(PropostaOperacao.METADADO.Loja, obj.Loja)
				.FieldValue(PropostaOperacao.METADADO.Tabela, obj.Tabela)
				.FieldValue(PropostaOperacao.METADADO.TacFinanciada, obj.TacFinanciada)
				.FieldValue(PropostaOperacao.METADADO.IOFFinaciado, obj.IOFFinaciado)
				.FieldValue(PropostaOperacao.METADADO.EspecieBeneficio, obj.EspecieBeneficio)
				.FieldValue(PropostaOperacao.METADADO.ComprometimentoRenda, obj.ComprometimentoRenda)
				.FieldValue(PropostaOperacao.METADADO.Autorizacao, obj.Autorizacao)
				.FieldValue(PropostaOperacao.METADADO.ValorMargem, obj.ValorMargem)
				.FieldValue(PropostaOperacao.METADADO.ValorRenegociacaoTotal, obj.ValorRenegociacaoTotal)
				.FieldValue(PropostaOperacao.METADADO.MeioLiquidacao, obj.MeioLiquidacao)
				.FieldValue(PropostaOperacao.METADADO.BancoLiquidacao, obj.BancoLiquidacao)
				.FieldValue(PropostaOperacao.METADADO.AgenciaLiquidacao, obj.AgenciaLiquidacao)
				.FieldValue(PropostaOperacao.METADADO.ChavePIX, obj.ChavePIX)
				.SetIdentityField(PropostaOperacao.METADADO.Operacao)
            .FieldValue(PropostaOperacao.METADADO.ContaLiquidacao, obj.ContaLiquidacao);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, insert.ToString());
				cmd.CommandTimeout = 600;
				insert.SetParameters(cmd);

            obj.Operacao = base.ExecuteScalar<int?>(cmd);
         }
		}
      #endregion

      #region Obtem
      #endregion

      #region Excluir por FKs
      public void ExcluirPor_Proposta(long? Proposta)
      {
         #region DeleteBuilder

         DeleteBuilder delete = DeleteBuilder.Create(this);
         delete.Table(PropostaOperacao.METADADO.tabelaNAME);
         delete.Where
            .Add(PropostaOperacao.METADADO.Proposta, Filter.Equal, Proposta);

         #endregion

         using (IDbConnection connection = base.CreateConnection())
         {
            IDbCommand cmd = base.CreateCommand(connection, delete.ToString()); cmd.CommandTimeout = 600;
            delete.SetParameters(cmd);

            base.ExecuteNonQuery(cmd);
         }
      }
      #endregion

      #region Excluir por PK
      #endregion

   }
}

