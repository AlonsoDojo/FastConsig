
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
	public partial class SimulacaoParcelasData : DataBase
	{
		
		#region Listar
		public List<SimulacaoParcelas> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(SimulacaoParcelas.METADADO.Id)
				.Field(SimulacaoParcelas.METADADO.Simulacao)
				.Field(SimulacaoParcelas.METADADO.DataVencimento)
				.Field(SimulacaoParcelas.METADADO.ValorLimite)
				.Field(SimulacaoParcelas.METADADO.ValorParcela)
				.Field(SimulacaoParcelas.METADADO.ValorRepasse)
				.Field(SimulacaoParcelas.METADADO.IofNormal)
				.Field(SimulacaoParcelas.METADADO.IofAdicional)
				.Field(SimulacaoParcelas.METADADO.Principal)
				.Field(SimulacaoParcelas.METADADO.Renda)
				.Field(SimulacaoParcelas.METADADO.Parcela)
				.Field(SimulacaoParcelas.METADADO.ValorTotal)
				.Field(SimulacaoParcelas.METADADO.ValorAmortizacaoSemIOF)
				.Field(SimulacaoParcelas.METADADO.ValorJuros)
				.Field(SimulacaoParcelas.METADADO.ValorJurosAcumulado)
				.Field(SimulacaoParcelas.METADADO.ValorSaldo)
				.Field(SimulacaoParcelas.METADADO.ValorSaldoRestante)
				.Field(SimulacaoParcelas.METADADO.ValorReforco)
				.Field(SimulacaoParcelas.METADADO.TipoParcela)
				.Field(SimulacaoParcelas.METADADO.Dias)
				.Field(SimulacaoParcelas.METADADO.IOFTotal)
				.Field(SimulacaoParcelas.METADADO.DiasIOF)
				.Field(SimulacaoParcelas.METADADO.ValorBaseIOF)
				.Field(SimulacaoParcelas.METADADO.ValorProjetado)
				.Table(SimulacaoParcelas.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				cmd.CommandTimeout = 600;
				query.SetParameters(cmd);

				List<SimulacaoParcelas> result = base.MapReaderToEntitySet<SimulacaoParcelas>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(SimulacaoParcelas obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(SimulacaoParcelas.METADADO.Simulacao, obj.Simulacao)
				.FieldValue(SimulacaoParcelas.METADADO.DataVencimento, obj.DataVencimento)
				.FieldValue(SimulacaoParcelas.METADADO.ValorLimite, obj.ValorLimite)
				.FieldValue(SimulacaoParcelas.METADADO.ValorParcela, obj.ValorParcela)
				.FieldValue(SimulacaoParcelas.METADADO.ValorRepasse, obj.ValorRepasse)
				.FieldValue(SimulacaoParcelas.METADADO.IofNormal, obj.IofNormal)
				.FieldValue(SimulacaoParcelas.METADADO.IofAdicional, obj.IofAdicional)
				.FieldValue(SimulacaoParcelas.METADADO.Principal, obj.Principal)
				.FieldValue(SimulacaoParcelas.METADADO.Renda, obj.Renda)
				.FieldValue(SimulacaoParcelas.METADADO.Parcela, obj.Parcela)
				.FieldValue(SimulacaoParcelas.METADADO.ValorTotal, obj.ValorTotal)
				.FieldValue(SimulacaoParcelas.METADADO.ValorAmortizacaoSemIOF, obj.ValorAmortizacaoSemIOF)
				.FieldValue(SimulacaoParcelas.METADADO.ValorJuros, obj.ValorJuros)
				.FieldValue(SimulacaoParcelas.METADADO.ValorJurosAcumulado, obj.ValorJurosAcumulado)
				.FieldValue(SimulacaoParcelas.METADADO.ValorSaldo, obj.ValorSaldo)
				.FieldValue(SimulacaoParcelas.METADADO.ValorSaldoRestante, obj.ValorSaldoRestante)
				.FieldValue(SimulacaoParcelas.METADADO.ValorReforco, obj.ValorReforco)
				.FieldValue(SimulacaoParcelas.METADADO.TipoParcela, obj.TipoParcela)
				.FieldValue(SimulacaoParcelas.METADADO.Dias, obj.Dias)
				.FieldValue(SimulacaoParcelas.METADADO.IOFTotal, obj.IOFTotal)
				.FieldValue(SimulacaoParcelas.METADADO.DiasIOF, obj.DiasIOF)
				.FieldValue(SimulacaoParcelas.METADADO.ValorBaseIOF, obj.ValorBaseIOF)
				.FieldValue(SimulacaoParcelas.METADADO.ValorProjetado, obj.ValorProjetado)
				.Table(SimulacaoParcelas.METADADO.tabelaNAME);

			update.Where
				.Add(SimulacaoParcelas.METADADO.Id, Filter.Equal, obj.Id);

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
		public void Incluir(SimulacaoParcelas obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(SimulacaoParcelas.METADADO.tabelaNAME)
				.FieldValue(SimulacaoParcelas.METADADO.Simulacao, obj.Simulacao)
				.FieldValue(SimulacaoParcelas.METADADO.DataVencimento, obj.DataVencimento)
				.FieldValue(SimulacaoParcelas.METADADO.ValorLimite, obj.ValorLimite)
				.FieldValue(SimulacaoParcelas.METADADO.ValorParcela, obj.ValorParcela)
				.FieldValue(SimulacaoParcelas.METADADO.ValorRepasse, obj.ValorRepasse)
				.FieldValue(SimulacaoParcelas.METADADO.IofNormal, obj.IofNormal)
				.FieldValue(SimulacaoParcelas.METADADO.IofAdicional, obj.IofAdicional)
				.FieldValue(SimulacaoParcelas.METADADO.Principal, obj.Principal)
				.FieldValue(SimulacaoParcelas.METADADO.Renda, obj.Renda)
				.FieldValue(SimulacaoParcelas.METADADO.Parcela, obj.Parcela)
				.FieldValue(SimulacaoParcelas.METADADO.ValorTotal, obj.ValorTotal)
				.FieldValue(SimulacaoParcelas.METADADO.ValorAmortizacaoSemIOF, obj.ValorAmortizacaoSemIOF)
				.FieldValue(SimulacaoParcelas.METADADO.ValorJuros, obj.ValorJuros)
				.FieldValue(SimulacaoParcelas.METADADO.ValorJurosAcumulado, obj.ValorJurosAcumulado)
				.FieldValue(SimulacaoParcelas.METADADO.ValorSaldo, obj.ValorSaldo)
				.FieldValue(SimulacaoParcelas.METADADO.ValorSaldoRestante, obj.ValorSaldoRestante)
				.FieldValue(SimulacaoParcelas.METADADO.ValorReforco, obj.ValorReforco)
				.FieldValue(SimulacaoParcelas.METADADO.TipoParcela, obj.TipoParcela)
				.FieldValue(SimulacaoParcelas.METADADO.Dias, obj.Dias)
				.FieldValue(SimulacaoParcelas.METADADO.IOFTotal, obj.IOFTotal)
				.FieldValue(SimulacaoParcelas.METADADO.DiasIOF, obj.DiasIOF)
				.FieldValue(SimulacaoParcelas.METADADO.ValorBaseIOF, obj.ValorBaseIOF)
				.FieldValue(SimulacaoParcelas.METADADO.ValorProjetado, obj.ValorProjetado)
				.SetIdentityField(SimulacaoParcelas.METADADO.Id);

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
		public SimulacaoParcelas Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(SimulacaoParcelas.METADADO.Id)
				.Field(SimulacaoParcelas.METADADO.Simulacao)
				.Field(SimulacaoParcelas.METADADO.DataVencimento)
				.Field(SimulacaoParcelas.METADADO.ValorLimite)
				.Field(SimulacaoParcelas.METADADO.ValorParcela)
				.Field(SimulacaoParcelas.METADADO.ValorRepasse)
				.Field(SimulacaoParcelas.METADADO.IofNormal)
				.Field(SimulacaoParcelas.METADADO.IofAdicional)
				.Field(SimulacaoParcelas.METADADO.Principal)
				.Field(SimulacaoParcelas.METADADO.Renda)
				.Field(SimulacaoParcelas.METADADO.Parcela)
				.Field(SimulacaoParcelas.METADADO.ValorTotal)
				.Field(SimulacaoParcelas.METADADO.ValorAmortizacaoSemIOF)
				.Field(SimulacaoParcelas.METADADO.ValorJuros)
				.Field(SimulacaoParcelas.METADADO.ValorJurosAcumulado)
				.Field(SimulacaoParcelas.METADADO.ValorSaldo)
				.Field(SimulacaoParcelas.METADADO.ValorSaldoRestante)
				.Field(SimulacaoParcelas.METADADO.ValorReforco)
				.Field(SimulacaoParcelas.METADADO.TipoParcela)
				.Field(SimulacaoParcelas.METADADO.Dias)
				.Field(SimulacaoParcelas.METADADO.IOFTotal)
				.Field(SimulacaoParcelas.METADADO.DiasIOF)
				.Field(SimulacaoParcelas.METADADO.ValorBaseIOF)
				.Field(SimulacaoParcelas.METADADO.ValorProjetado)
				.Table(SimulacaoParcelas.METADADO.tabelaNAME);

			query.Where
				.Add(SimulacaoParcelas.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				cmd.CommandTimeout = 600;
				query.SetParameters(cmd);

				SimulacaoParcelas result = base.MapReaderToEntity<SimulacaoParcelas>(cmd);
				return result;
			}
		}
		#endregion

		#region Excluir por FKs
		public void ExcluirPor_Simulacao(int? Simulacao)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(SimulacaoParcelas.METADADO.tabelaNAME);
			delete.Where
				.Add(SimulacaoParcelas.METADADO.Simulacao, Filter.Equal, Simulacao);

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
				delete.Table(SimulacaoParcelas.METADADO.tabelaNAME);
			delete.Where
				.Add(SimulacaoParcelas.METADADO.Id, Filter.Equal, Id);

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
