
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
	public partial class PropostaParcelasData : DataBase
	{
		
		#region Listar
		public List<PropostaParcelas> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(PropostaParcelas.METADADO.Id)
				.Field(PropostaParcelas.METADADO.Proposta)
				.Field(PropostaParcelas.METADADO.Operacao)
				.Field(PropostaParcelas.METADADO.DataVencimento)
				.Field(PropostaParcelas.METADADO.ValorLimite)
				.Field(PropostaParcelas.METADADO.ValorParcela)
				.Field(PropostaParcelas.METADADO.ValorRepasse)
				.Field(PropostaParcelas.METADADO.IofNormal)
				.Field(PropostaParcelas.METADADO.IofAdicional)
				.Field(PropostaParcelas.METADADO.Principal)
				.Field(PropostaParcelas.METADADO.Renda)
				.Field(PropostaParcelas.METADADO.Parcela)
				.Field(PropostaParcelas.METADADO.ValorTotal)
				.Field(PropostaParcelas.METADADO.ValorAmortizacaoSemIOF)
				.Field(PropostaParcelas.METADADO.ValorJuros)
				.Field(PropostaParcelas.METADADO.ValorJurosAcumulado)
				.Field(PropostaParcelas.METADADO.ValorSaldo)
				.Field(PropostaParcelas.METADADO.ValorSaldoRestante)
				.Field(PropostaParcelas.METADADO.ValorReforco)
				.Field(PropostaParcelas.METADADO.TipoParcela)
				.Field(PropostaParcelas.METADADO.Dias)
				.Field(PropostaParcelas.METADADO.IOFTotal)
				.Field(PropostaParcelas.METADADO.DiasIOF)
				.Field(PropostaParcelas.METADADO.ValorBaseIOF)
				.Field(PropostaParcelas.METADADO.ValorProjetado)
				.Field(PropostaParcelas.METADADO.DataPagamento)
				.Field(PropostaParcelas.METADADO.ValorPago)
				.Field(PropostaParcelas.METADADO.NU)
				.Table(PropostaParcelas.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				cmd.CommandTimeout = 600;
				query.SetParameters(cmd);

				List<PropostaParcelas> result = base.MapReaderToEntitySet<PropostaParcelas>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(PropostaParcelas obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(PropostaParcelas.METADADO.Proposta, obj.Proposta)
				.FieldValue(PropostaParcelas.METADADO.Operacao, obj.Operacao)
				.FieldValue(PropostaParcelas.METADADO.DataVencimento, obj.DataVencimento)
				.FieldValue(PropostaParcelas.METADADO.ValorLimite, obj.ValorLimite)
				.FieldValue(PropostaParcelas.METADADO.ValorParcela, obj.ValorParcela)
				.FieldValue(PropostaParcelas.METADADO.ValorRepasse, obj.ValorRepasse)
				.FieldValue(PropostaParcelas.METADADO.IofNormal, obj.IofNormal)
				.FieldValue(PropostaParcelas.METADADO.IofAdicional, obj.IofAdicional)
				.FieldValue(PropostaParcelas.METADADO.Principal, obj.Principal)
				.FieldValue(PropostaParcelas.METADADO.Renda, obj.Renda)
				.FieldValue(PropostaParcelas.METADADO.Parcela, obj.Parcela)
				.FieldValue(PropostaParcelas.METADADO.ValorTotal, obj.ValorTotal)
				.FieldValue(PropostaParcelas.METADADO.ValorAmortizacaoSemIOF, obj.ValorAmortizacaoSemIOF)
				.FieldValue(PropostaParcelas.METADADO.ValorJuros, obj.ValorJuros)
				.FieldValue(PropostaParcelas.METADADO.ValorJurosAcumulado, obj.ValorJurosAcumulado)
				.FieldValue(PropostaParcelas.METADADO.ValorSaldo, obj.ValorSaldo)
				.FieldValue(PropostaParcelas.METADADO.ValorSaldoRestante, obj.ValorSaldoRestante)
				.FieldValue(PropostaParcelas.METADADO.ValorReforco, obj.ValorReforco)
				.FieldValue(PropostaParcelas.METADADO.TipoParcela, obj.TipoParcela)
				.FieldValue(PropostaParcelas.METADADO.Dias, obj.Dias)
				.FieldValue(PropostaParcelas.METADADO.IOFTotal, obj.IOFTotal)
				.FieldValue(PropostaParcelas.METADADO.DiasIOF, obj.DiasIOF)
				.FieldValue(PropostaParcelas.METADADO.ValorBaseIOF, obj.ValorBaseIOF)
				.FieldValue(PropostaParcelas.METADADO.ValorProjetado, obj.ValorProjetado)
				.FieldValue(PropostaParcelas.METADADO.DataPagamento, obj.DataPagamento)
				.FieldValue(PropostaParcelas.METADADO.ValorPago, obj.ValorPago)
				.FieldValue(PropostaParcelas.METADADO.NU, obj.NU)
				.Table(PropostaParcelas.METADADO.tabelaNAME);

			update.Where
				.Add(PropostaParcelas.METADADO.Id, Filter.Equal, obj.Id);

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
		public void Incluir(PropostaParcelas obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(PropostaParcelas.METADADO.tabelaNAME)
				.FieldValue(PropostaParcelas.METADADO.Proposta, obj.Proposta)
				.FieldValue(PropostaParcelas.METADADO.Operacao, obj.Operacao)
				.FieldValue(PropostaParcelas.METADADO.DataVencimento, obj.DataVencimento)
				.FieldValue(PropostaParcelas.METADADO.ValorLimite, obj.ValorLimite)
				.FieldValue(PropostaParcelas.METADADO.ValorParcela, obj.ValorParcela)
				.FieldValue(PropostaParcelas.METADADO.ValorRepasse, obj.ValorRepasse)
				.FieldValue(PropostaParcelas.METADADO.IofNormal, obj.IofNormal)
				.FieldValue(PropostaParcelas.METADADO.IofAdicional, obj.IofAdicional)
				.FieldValue(PropostaParcelas.METADADO.Principal, obj.Principal)
				.FieldValue(PropostaParcelas.METADADO.Renda, obj.Renda)
				.FieldValue(PropostaParcelas.METADADO.Parcela, obj.Parcela)
				.FieldValue(PropostaParcelas.METADADO.ValorTotal, obj.ValorTotal)
				.FieldValue(PropostaParcelas.METADADO.ValorAmortizacaoSemIOF, obj.ValorAmortizacaoSemIOF)
				.FieldValue(PropostaParcelas.METADADO.ValorJuros, obj.ValorJuros)
				.FieldValue(PropostaParcelas.METADADO.ValorJurosAcumulado, obj.ValorJurosAcumulado)
				.FieldValue(PropostaParcelas.METADADO.ValorSaldo, obj.ValorSaldo)
				.FieldValue(PropostaParcelas.METADADO.ValorSaldoRestante, obj.ValorSaldoRestante)
				.FieldValue(PropostaParcelas.METADADO.ValorReforco, obj.ValorReforco)
				.FieldValue(PropostaParcelas.METADADO.TipoParcela, obj.TipoParcela)
				.FieldValue(PropostaParcelas.METADADO.Dias, obj.Dias)
				.FieldValue(PropostaParcelas.METADADO.IOFTotal, obj.IOFTotal)
				.FieldValue(PropostaParcelas.METADADO.DiasIOF, obj.DiasIOF)
				.FieldValue(PropostaParcelas.METADADO.ValorBaseIOF, obj.ValorBaseIOF)
				.FieldValue(PropostaParcelas.METADADO.ValorProjetado, obj.ValorProjetado)
				.FieldValue(PropostaParcelas.METADADO.DataPagamento, obj.DataPagamento)
				.FieldValue(PropostaParcelas.METADADO.ValorPago, obj.ValorPago)
				.FieldValue(PropostaParcelas.METADADO.NU, obj.NU)
				.SetIdentityField(PropostaParcelas.METADADO.Id);

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
		public PropostaParcelas Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(PropostaParcelas.METADADO.Id)
				.Field(PropostaParcelas.METADADO.Proposta)
				.Field(PropostaParcelas.METADADO.Operacao)
				.Field(PropostaParcelas.METADADO.DataVencimento)
				.Field(PropostaParcelas.METADADO.ValorLimite)
				.Field(PropostaParcelas.METADADO.ValorParcela)
				.Field(PropostaParcelas.METADADO.ValorRepasse)
				.Field(PropostaParcelas.METADADO.IofNormal)
				.Field(PropostaParcelas.METADADO.IofAdicional)
				.Field(PropostaParcelas.METADADO.Principal)
				.Field(PropostaParcelas.METADADO.Renda)
				.Field(PropostaParcelas.METADADO.Parcela)
				.Field(PropostaParcelas.METADADO.ValorTotal)
				.Field(PropostaParcelas.METADADO.ValorAmortizacaoSemIOF)
				.Field(PropostaParcelas.METADADO.ValorJuros)
				.Field(PropostaParcelas.METADADO.ValorJurosAcumulado)
				.Field(PropostaParcelas.METADADO.ValorSaldo)
				.Field(PropostaParcelas.METADADO.ValorSaldoRestante)
				.Field(PropostaParcelas.METADADO.ValorReforco)
				.Field(PropostaParcelas.METADADO.TipoParcela)
				.Field(PropostaParcelas.METADADO.Dias)
				.Field(PropostaParcelas.METADADO.IOFTotal)
				.Field(PropostaParcelas.METADADO.DiasIOF)
				.Field(PropostaParcelas.METADADO.ValorBaseIOF)
				.Field(PropostaParcelas.METADADO.ValorProjetado)
				.Field(PropostaParcelas.METADADO.DataPagamento)
				.Field(PropostaParcelas.METADADO.ValorPago)
				.Field(PropostaParcelas.METADADO.NU)
				.Table(PropostaParcelas.METADADO.tabelaNAME);

			query.Where
				.Add(PropostaParcelas.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				cmd.CommandTimeout = 600;
				query.SetParameters(cmd);

				PropostaParcelas result = base.MapReaderToEntity<PropostaParcelas>(cmd);
				return result;
			}
		}
      #endregion

      #region Excluir por FKs
      public void ExcluirPorProposta(int? proposta)
      {
         #region DeleteBuilder

         DeleteBuilder delete = DeleteBuilder.Create(this);
         delete.Table(PropostaParcelas.METADADO.tabelaNAME);
         delete.Where
            .Add(PropostaParcelas.METADADO.Proposta, Filter.Equal, proposta);

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
      public void Excluir(int? Id)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(PropostaParcelas.METADADO.tabelaNAME);
			delete.Where
				.Add(PropostaParcelas.METADADO.Id, Filter.Equal, Id);

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
