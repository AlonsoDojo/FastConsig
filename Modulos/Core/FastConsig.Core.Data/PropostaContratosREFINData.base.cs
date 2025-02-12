
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
	public partial class PropostaContratosREFINData : DataBase
	{
		
		#region Listar
		public List<PropostaContratosREFIN> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(PropostaContratosREFIN.METADADO.Id)
				.Field(PropostaContratosREFIN.METADADO.Proposta)
				.Field(PropostaContratosREFIN.METADADO.Empresa)
				.Field(PropostaContratosREFIN.METADADO.Agencia)
				.Field(PropostaContratosREFIN.METADADO.Contrato)
				.Field(PropostaContratosREFIN.METADADO.CpfCnpj)
				.Field(PropostaContratosREFIN.METADADO.DataSituacao)
				.Field(PropostaContratosREFIN.METADADO.Emissao)
				.Field(PropostaContratosREFIN.METADADO.Vencimento)
				.Field(PropostaContratosREFIN.METADADO.Prazo)
				.Field(PropostaContratosREFIN.METADADO.Produto)
				.Field(PropostaContratosREFIN.METADADO.DiasAtraso)
				.Field(PropostaContratosREFIN.METADADO.Principal)
				.Field(PropostaContratosREFIN.METADADO.ValorContrato)
				.Field(PropostaContratosREFIN.METADADO.ValorTotalAPagar)
				.Field(PropostaContratosREFIN.METADADO.Tac)
				.Field(PropostaContratosREFIN.METADADO.Seguro)
				.Field(PropostaContratosREFIN.METADADO.TaxaMensal)
				.Field(PropostaContratosREFIN.METADADO.TaxaAnual)
				.Field(PropostaContratosREFIN.METADADO.SaldoDevedor)
				.Field(PropostaContratosREFIN.METADADO.DataSaldoDevedor)
				.Field(PropostaContratosREFIN.METADADO.SaldoAtual)
				.Field(PropostaContratosREFIN.METADADO.IofAtraso)
				.Field(PropostaContratosREFIN.METADADO.SaldoPrincipalEmAberto)
				.Field(PropostaContratosREFIN.METADADO.Matricula)
				.Field(PropostaContratosREFIN.METADADO.TipoBeneficio)
				.Field(PropostaContratosREFIN.METADADO.UfBeneficio)
				.Field(PropostaContratosREFIN.METADADO.Titularidade)
				.Field(PropostaContratosREFIN.METADADO.MeioRecebimentoBeneficio)
				.Field(PropostaContratosREFIN.METADADO.Utilizado)
				.Field(PropostaContratosREFIN.METADADO.ValorParcela)
				.Field(PropostaContratosREFIN.METADADO.ParcelasEmAberto)
				.Table(PropostaContratosREFIN.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				cmd.CommandTimeout = 600;
				query.SetParameters(cmd);

				List<PropostaContratosREFIN> result = base.MapReaderToEntitySet<PropostaContratosREFIN>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(PropostaContratosREFIN obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(PropostaContratosREFIN.METADADO.Proposta, obj.Proposta)
				.FieldValue(PropostaContratosREFIN.METADADO.Empresa, obj.Empresa)
				.FieldValue(PropostaContratosREFIN.METADADO.Agencia, obj.Agencia)
				.FieldValue(PropostaContratosREFIN.METADADO.Contrato, obj.Contrato)
				.FieldValue(PropostaContratosREFIN.METADADO.CpfCnpj, obj.CpfCnpj)
				.FieldValue(PropostaContratosREFIN.METADADO.DataSituacao, obj.DataSituacao)
				.FieldValue(PropostaContratosREFIN.METADADO.Emissao, obj.Emissao)
				.FieldValue(PropostaContratosREFIN.METADADO.Vencimento, obj.Vencimento)
				.FieldValue(PropostaContratosREFIN.METADADO.Prazo, obj.Prazo)
				.FieldValue(PropostaContratosREFIN.METADADO.Produto, obj.Produto)
				.FieldValue(PropostaContratosREFIN.METADADO.DiasAtraso, obj.DiasAtraso)
				.FieldValue(PropostaContratosREFIN.METADADO.Principal, obj.Principal)
				.FieldValue(PropostaContratosREFIN.METADADO.ValorContrato, obj.ValorContrato)
				.FieldValue(PropostaContratosREFIN.METADADO.ValorTotalAPagar, obj.ValorTotalAPagar)
				.FieldValue(PropostaContratosREFIN.METADADO.Tac, obj.Tac)
				.FieldValue(PropostaContratosREFIN.METADADO.Seguro, obj.Seguro)
				.FieldValue(PropostaContratosREFIN.METADADO.TaxaMensal, obj.TaxaMensal)
				.FieldValue(PropostaContratosREFIN.METADADO.TaxaAnual, obj.TaxaAnual)
				.FieldValue(PropostaContratosREFIN.METADADO.SaldoDevedor, obj.SaldoDevedor)
				.FieldValue(PropostaContratosREFIN.METADADO.DataSaldoDevedor, obj.DataSaldoDevedor)
				.FieldValue(PropostaContratosREFIN.METADADO.SaldoAtual, obj.SaldoAtual)
				.FieldValue(PropostaContratosREFIN.METADADO.IofAtraso, obj.IofAtraso)
				.FieldValue(PropostaContratosREFIN.METADADO.SaldoPrincipalEmAberto, obj.SaldoPrincipalEmAberto)
				.FieldValue(PropostaContratosREFIN.METADADO.Matricula, obj.Matricula)
				.FieldValue(PropostaContratosREFIN.METADADO.TipoBeneficio, obj.TipoBeneficio)
				.FieldValue(PropostaContratosREFIN.METADADO.UfBeneficio, obj.UfBeneficio)
				.FieldValue(PropostaContratosREFIN.METADADO.Titularidade, obj.Titularidade)
				.FieldValue(PropostaContratosREFIN.METADADO.MeioRecebimentoBeneficio, obj.MeioRecebimentoBeneficio)
				.FieldValue(PropostaContratosREFIN.METADADO.Utilizado, obj.Utilizado)
				.FieldValue(PropostaContratosREFIN.METADADO.ValorParcela, obj.ValorParcela)
				.FieldValue(PropostaContratosREFIN.METADADO.ParcelasEmAberto, obj.ParcelasEmAberto)
				.Table(PropostaContratosREFIN.METADADO.tabelaNAME);

			update.Where
				.Add(PropostaContratosREFIN.METADADO.Id, Filter.Equal, obj.Id);

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
		public void Incluir(PropostaContratosREFIN obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(PropostaContratosREFIN.METADADO.tabelaNAME)
				.FieldValue(PropostaContratosREFIN.METADADO.Proposta, obj.Proposta)
				.FieldValue(PropostaContratosREFIN.METADADO.Empresa, obj.Empresa)
				.FieldValue(PropostaContratosREFIN.METADADO.Agencia, obj.Agencia)
				.FieldValue(PropostaContratosREFIN.METADADO.Contrato, obj.Contrato)
				.FieldValue(PropostaContratosREFIN.METADADO.CpfCnpj, obj.CpfCnpj)
				.FieldValue(PropostaContratosREFIN.METADADO.DataSituacao, obj.DataSituacao)
				.FieldValue(PropostaContratosREFIN.METADADO.Emissao, obj.Emissao)
				.FieldValue(PropostaContratosREFIN.METADADO.Vencimento, obj.Vencimento)
				.FieldValue(PropostaContratosREFIN.METADADO.Prazo, obj.Prazo)
				.FieldValue(PropostaContratosREFIN.METADADO.Produto, obj.Produto)
				.FieldValue(PropostaContratosREFIN.METADADO.DiasAtraso, obj.DiasAtraso)
				.FieldValue(PropostaContratosREFIN.METADADO.Principal, obj.Principal)
				.FieldValue(PropostaContratosREFIN.METADADO.ValorContrato, obj.ValorContrato)
				.FieldValue(PropostaContratosREFIN.METADADO.ValorTotalAPagar, obj.ValorTotalAPagar)
				.FieldValue(PropostaContratosREFIN.METADADO.Tac, obj.Tac)
				.FieldValue(PropostaContratosREFIN.METADADO.Seguro, obj.Seguro)
				.FieldValue(PropostaContratosREFIN.METADADO.TaxaMensal, obj.TaxaMensal)
				.FieldValue(PropostaContratosREFIN.METADADO.TaxaAnual, obj.TaxaAnual)
				.FieldValue(PropostaContratosREFIN.METADADO.SaldoDevedor, obj.SaldoDevedor)
				.FieldValue(PropostaContratosREFIN.METADADO.DataSaldoDevedor, obj.DataSaldoDevedor)
				.FieldValue(PropostaContratosREFIN.METADADO.SaldoAtual, obj.SaldoAtual)
				.FieldValue(PropostaContratosREFIN.METADADO.IofAtraso, obj.IofAtraso)
				.FieldValue(PropostaContratosREFIN.METADADO.SaldoPrincipalEmAberto, obj.SaldoPrincipalEmAberto)
				.FieldValue(PropostaContratosREFIN.METADADO.Matricula, obj.Matricula)
				.FieldValue(PropostaContratosREFIN.METADADO.TipoBeneficio, obj.TipoBeneficio)
				.FieldValue(PropostaContratosREFIN.METADADO.UfBeneficio, obj.UfBeneficio)
				.FieldValue(PropostaContratosREFIN.METADADO.Titularidade, obj.Titularidade)
				.FieldValue(PropostaContratosREFIN.METADADO.MeioRecebimentoBeneficio, obj.MeioRecebimentoBeneficio)
				.FieldValue(PropostaContratosREFIN.METADADO.Utilizado, obj.Utilizado)
				.FieldValue(PropostaContratosREFIN.METADADO.ValorParcela, obj.ValorParcela)
				.FieldValue(PropostaContratosREFIN.METADADO.ParcelasEmAberto, obj.ParcelasEmAberto)
				.SetIdentityField(PropostaContratosREFIN.METADADO.Id);

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
		public PropostaContratosREFIN Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(PropostaContratosREFIN.METADADO.Id)
				.Field(PropostaContratosREFIN.METADADO.Proposta)
				.Field(PropostaContratosREFIN.METADADO.Empresa)
				.Field(PropostaContratosREFIN.METADADO.Agencia)
				.Field(PropostaContratosREFIN.METADADO.Contrato)
				.Field(PropostaContratosREFIN.METADADO.CpfCnpj)
				.Field(PropostaContratosREFIN.METADADO.DataSituacao)
				.Field(PropostaContratosREFIN.METADADO.Emissao)
				.Field(PropostaContratosREFIN.METADADO.Vencimento)
				.Field(PropostaContratosREFIN.METADADO.Prazo)
				.Field(PropostaContratosREFIN.METADADO.Produto)
				.Field(PropostaContratosREFIN.METADADO.DiasAtraso)
				.Field(PropostaContratosREFIN.METADADO.Principal)
				.Field(PropostaContratosREFIN.METADADO.ValorContrato)
				.Field(PropostaContratosREFIN.METADADO.ValorTotalAPagar)
				.Field(PropostaContratosREFIN.METADADO.Tac)
				.Field(PropostaContratosREFIN.METADADO.Seguro)
				.Field(PropostaContratosREFIN.METADADO.TaxaMensal)
				.Field(PropostaContratosREFIN.METADADO.TaxaAnual)
				.Field(PropostaContratosREFIN.METADADO.SaldoDevedor)
				.Field(PropostaContratosREFIN.METADADO.DataSaldoDevedor)
				.Field(PropostaContratosREFIN.METADADO.SaldoAtual)
				.Field(PropostaContratosREFIN.METADADO.IofAtraso)
				.Field(PropostaContratosREFIN.METADADO.SaldoPrincipalEmAberto)
				.Field(PropostaContratosREFIN.METADADO.Matricula)
				.Field(PropostaContratosREFIN.METADADO.TipoBeneficio)
				.Field(PropostaContratosREFIN.METADADO.UfBeneficio)
				.Field(PropostaContratosREFIN.METADADO.Titularidade)
				.Field(PropostaContratosREFIN.METADADO.MeioRecebimentoBeneficio)
				.Field(PropostaContratosREFIN.METADADO.Utilizado)
				.Field(PropostaContratosREFIN.METADADO.ValorParcela)
				.Field(PropostaContratosREFIN.METADADO.ParcelasEmAberto)
				.Table(PropostaContratosREFIN.METADADO.tabelaNAME);

			query.Where
				.Add(PropostaContratosREFIN.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				cmd.CommandTimeout = 600;
				query.SetParameters(cmd);

				PropostaContratosREFIN result = base.MapReaderToEntity<PropostaContratosREFIN>(cmd);
				return result;
			}
		}
      #endregion

      #region Excluir por FKs
      public void ExcluirPorProposta(long? Proposta)
      {
         #region DeleteBuilder

         DeleteBuilder delete = DeleteBuilder.Create(this);
         delete.Table(PropostaContratosREFIN.METADADO.tabelaNAME);
         delete.Where
            .Add(PropostaContratosREFIN.METADADO.Proposta, Filter.Equal, Proposta);

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
				delete.Table(PropostaContratosREFIN.METADADO.tabelaNAME);
			delete.Where
				.Add(PropostaContratosREFIN.METADADO.Id, Filter.Equal, Id);

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
