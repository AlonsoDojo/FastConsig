
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
	public partial class CTCRCOData : DataBase
	{
		
		#region Listar
		public List<CTCRCO> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CTCRCO.METADADO.Id)
				.Field(CTCRCO.METADADO.AnoMes)
				.Field(CTCRCO.METADADO.Tipo)
				.Field(CTCRCO.METADADO.IdentidadeParticipanteAdministrado)
				.Field(CTCRCO.METADADO.ISPBContraParte)
				.Field(CTCRCO.METADADO.TipoContrato)
				.Field(CTCRCO.METADADO.EnteConsignante)
				.Field(CTCRCO.METADADO.Contrato)
				.Field(CTCRCO.METADADO.NUPortabilidade)
				.Field(CTCRCO.METADADO.DataContrato)
				.Field(CTCRCO.METADADO.DataVencimentoUltimaParcela)
				.Field(CTCRCO.METADADO.DataReferenciaSaldoDevedor)
				.Field(CTCRCO.METADADO.ValorSaldoDevedor)
				.Field(CTCRCO.METADADO.ValorSaldoDevedorAD)
				.Field(CTCRCO.METADADO.BaseCalculoRCO)
				.Field(CTCRCO.METADADO.DataMovimentoLiquidacaoSTR)
				.Field(CTCRCO.METADADO.ValorSTRLiquidacaoPortabilidade)
				.Field(CTCRCO.METADADO.ValorRCO)
				.Field(CTCRCO.METADADO.ISPBBancoPagamento)
				.Field(CTCRCO.METADADO.CodigoBancoPagamento)
				.Field(CTCRCO.METADADO.AgenciaPagamento)
				.Field(CTCRCO.METADADO.ContaPagamento)
				.Field(CTCRCO.METADADO.Arquivo)
				.Table(CTCRCO.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				List<CTCRCO> result = base.MapReaderToEntitySet<CTCRCO>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(CTCRCO obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(CTCRCO.METADADO.AnoMes, obj.AnoMes)
				.FieldValue(CTCRCO.METADADO.Tipo, obj.Tipo)
				.FieldValue(CTCRCO.METADADO.IdentidadeParticipanteAdministrado, obj.IdentidadeParticipanteAdministrado)
				.FieldValue(CTCRCO.METADADO.ISPBContraParte, obj.ISPBContraParte)
				.FieldValue(CTCRCO.METADADO.TipoContrato, obj.TipoContrato)
				.FieldValue(CTCRCO.METADADO.EnteConsignante, obj.EnteConsignante)
				.FieldValue(CTCRCO.METADADO.Contrato, obj.Contrato)
				.FieldValue(CTCRCO.METADADO.NUPortabilidade, obj.NUPortabilidade)
				.FieldValue(CTCRCO.METADADO.DataContrato, obj.DataContrato)
				.FieldValue(CTCRCO.METADADO.DataVencimentoUltimaParcela, obj.DataVencimentoUltimaParcela)
				.FieldValue(CTCRCO.METADADO.DataReferenciaSaldoDevedor, obj.DataReferenciaSaldoDevedor)
				.FieldValue(CTCRCO.METADADO.ValorSaldoDevedor, obj.ValorSaldoDevedor)
				.FieldValue(CTCRCO.METADADO.ValorSaldoDevedorAD, obj.ValorSaldoDevedorAD)
				.FieldValue(CTCRCO.METADADO.BaseCalculoRCO, obj.BaseCalculoRCO)
				.FieldValue(CTCRCO.METADADO.DataMovimentoLiquidacaoSTR, obj.DataMovimentoLiquidacaoSTR)
				.FieldValue(CTCRCO.METADADO.ValorSTRLiquidacaoPortabilidade, obj.ValorSTRLiquidacaoPortabilidade)
				.FieldValue(CTCRCO.METADADO.ValorRCO, obj.ValorRCO)
				.FieldValue(CTCRCO.METADADO.ISPBBancoPagamento, obj.ISPBBancoPagamento)
				.FieldValue(CTCRCO.METADADO.CodigoBancoPagamento, obj.CodigoBancoPagamento)
				.FieldValue(CTCRCO.METADADO.AgenciaPagamento, obj.AgenciaPagamento)
				.FieldValue(CTCRCO.METADADO.ContaPagamento, obj.ContaPagamento)
				.FieldValue(CTCRCO.METADADO.Arquivo, obj.Arquivo)
				.Table(CTCRCO.METADADO.tabelaNAME);

			update.Where
				.Add(CTCRCO.METADADO.Id, Filter.Equal, obj.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, update.ToString());
				update.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

		#region Inserir
		public void Incluir(CTCRCO obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(CTCRCO.METADADO.tabelaNAME)
				.FieldValue(CTCRCO.METADADO.AnoMes, obj.AnoMes)
				.FieldValue(CTCRCO.METADADO.Tipo, obj.Tipo)
				.FieldValue(CTCRCO.METADADO.IdentidadeParticipanteAdministrado, obj.IdentidadeParticipanteAdministrado)
				.FieldValue(CTCRCO.METADADO.ISPBContraParte, obj.ISPBContraParte)
				.FieldValue(CTCRCO.METADADO.TipoContrato, obj.TipoContrato)
				.FieldValue(CTCRCO.METADADO.EnteConsignante, obj.EnteConsignante)
				.FieldValue(CTCRCO.METADADO.Contrato, obj.Contrato)
				.FieldValue(CTCRCO.METADADO.NUPortabilidade, obj.NUPortabilidade)
				.FieldValue(CTCRCO.METADADO.DataContrato, obj.DataContrato)
				.FieldValue(CTCRCO.METADADO.DataVencimentoUltimaParcela, obj.DataVencimentoUltimaParcela)
				.FieldValue(CTCRCO.METADADO.DataReferenciaSaldoDevedor, obj.DataReferenciaSaldoDevedor)
				.FieldValue(CTCRCO.METADADO.ValorSaldoDevedor, obj.ValorSaldoDevedor)
				.FieldValue(CTCRCO.METADADO.ValorSaldoDevedorAD, obj.ValorSaldoDevedorAD)
				.FieldValue(CTCRCO.METADADO.BaseCalculoRCO, obj.BaseCalculoRCO)
				.FieldValue(CTCRCO.METADADO.DataMovimentoLiquidacaoSTR, obj.DataMovimentoLiquidacaoSTR)
				.FieldValue(CTCRCO.METADADO.ValorSTRLiquidacaoPortabilidade, obj.ValorSTRLiquidacaoPortabilidade)
				.FieldValue(CTCRCO.METADADO.ValorRCO, obj.ValorRCO)
				.FieldValue(CTCRCO.METADADO.ISPBBancoPagamento, obj.ISPBBancoPagamento)
				.FieldValue(CTCRCO.METADADO.CodigoBancoPagamento, obj.CodigoBancoPagamento)
				.FieldValue(CTCRCO.METADADO.AgenciaPagamento, obj.AgenciaPagamento)
				.FieldValue(CTCRCO.METADADO.ContaPagamento, obj.ContaPagamento)
				.FieldValue(CTCRCO.METADADO.Arquivo, obj.Arquivo)
				.SetIdentityField(CTCRCO.METADADO.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, insert.ToString());
				insert.SetParameters(cmd);

				obj.Id = base.ExecuteScalar<int?>(cmd);
			}
		}
		#endregion

		#region Obtem
		public CTCRCO Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CTCRCO.METADADO.Id)
				.Field(CTCRCO.METADADO.AnoMes)
				.Field(CTCRCO.METADADO.Tipo)
				.Field(CTCRCO.METADADO.IdentidadeParticipanteAdministrado)
				.Field(CTCRCO.METADADO.ISPBContraParte)
				.Field(CTCRCO.METADADO.TipoContrato)
				.Field(CTCRCO.METADADO.EnteConsignante)
				.Field(CTCRCO.METADADO.Contrato)
				.Field(CTCRCO.METADADO.NUPortabilidade)
				.Field(CTCRCO.METADADO.DataContrato)
				.Field(CTCRCO.METADADO.DataVencimentoUltimaParcela)
				.Field(CTCRCO.METADADO.DataReferenciaSaldoDevedor)
				.Field(CTCRCO.METADADO.ValorSaldoDevedor)
				.Field(CTCRCO.METADADO.ValorSaldoDevedorAD)
				.Field(CTCRCO.METADADO.BaseCalculoRCO)
				.Field(CTCRCO.METADADO.DataMovimentoLiquidacaoSTR)
				.Field(CTCRCO.METADADO.ValorSTRLiquidacaoPortabilidade)
				.Field(CTCRCO.METADADO.ValorRCO)
				.Field(CTCRCO.METADADO.ISPBBancoPagamento)
				.Field(CTCRCO.METADADO.CodigoBancoPagamento)
				.Field(CTCRCO.METADADO.AgenciaPagamento)
				.Field(CTCRCO.METADADO.ContaPagamento)
				.Field(CTCRCO.METADADO.Arquivo)
				.Table(CTCRCO.METADADO.tabelaNAME);

			query.Where
				.Add(CTCRCO.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				CTCRCO result = base.MapReaderToEntity<CTCRCO>(cmd);
				return result;
			}
		}
		#endregion

		#region Excluir por FKs
		public void ExcluirPor_TipoContrato(string TipoContrato)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(CTCRCO.METADADO.tabelaNAME);
			delete.Where
				.Add(CTCRCO.METADADO.TipoContrato, Filter.Equal, TipoContrato);

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
				delete.Table(CTCRCO.METADADO.tabelaNAME);
			delete.Where
				.Add(CTCRCO.METADADO.EnteConsignante, Filter.Equal, EnteConsignante);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, delete.ToString());
				delete.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		public void ExcluirPor_Arquivo(int? Arquivo)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(CTCRCO.METADADO.tabelaNAME);
			delete.Where
				.Add(CTCRCO.METADADO.Arquivo, Filter.Equal, Arquivo);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, delete.ToString());
				delete.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
      public void ExcluirPor_Competencia(string competencia)
      {
         #region DeleteBuilder

         DeleteBuilder delete = DeleteBuilder.Create(this);
         delete.Table(CTCRCO.METADADO.tabelaNAME);
         delete.Where
            .Add(CTCRCO.METADADO.AnoMes, Filter.Equal, competencia);

         #endregion

         using (IDbConnection connection = base.CreateConnection())
         {
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
				delete.Table(CTCRCO.METADADO.tabelaNAME);
			delete.Where
				.Add(CTCRCO.METADADO.Id, Filter.Equal, Id);

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
