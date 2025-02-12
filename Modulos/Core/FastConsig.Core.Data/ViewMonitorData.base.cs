
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
	public partial class ViewMonitorData : DataBase
	{
		
		#region Listar
		public List<ViewMonitor> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(ViewMonitor.METADADO.Proposta)
				.Field(ViewMonitor.METADADO.DataCriacao)
				.Field(ViewMonitor.METADADO.CPFCNPJ)
				.Field(ViewMonitor.METADADO.TipoPessoa)
				.Field(ViewMonitor.METADADO.NomeProponente)
				.Field(ViewMonitor.METADADO.NumeroBeneficio)
				.Field(ViewMonitor.METADADO.EspecieBeneficio)
				.Field(ViewMonitor.METADADO.DDDCelular)
				.Field(ViewMonitor.METADADO.Celular)
				.Field(ViewMonitor.METADADO.Fase)
				.Field(ViewMonitor.METADADO.Status)
				.Field(ViewMonitor.METADADO.DescricaoFase)
				.Field(ViewMonitor.METADADO.DescricaoStatus)
				.Field(ViewMonitor.METADADO.Gerente)
				.Field(ViewMonitor.METADADO.Usuario)
				.Field(ViewMonitor.METADADO.Promotora)
				.Field(ViewMonitor.METADADO.ProfissionalCertificado)
				.Field(ViewMonitor.METADADO.MotivoRecusa)
				.Field(ViewMonitor.METADADO.Produto)
				.Field(ViewMonitor.METADADO.ValorOperacao)
				.Field(ViewMonitor.METADADO.ValorFinanciado)
				.Field(ViewMonitor.METADADO.Prazo)
				.Field(ViewMonitor.METADADO.DataPrimeiroVencimento)
				.Field(ViewMonitor.METADADO.Tabela)
				.Field(ViewMonitor.METADADO.ContratoLegado)
				.Field(ViewMonitor.METADADO.PropostaLegado)
				.Field(ViewMonitor.METADADO.RedeLojas)
				.Field(ViewMonitor.METADADO.Loja)
				.Field(ViewMonitor.METADADO.BancoLiquidacao)
				.Field(ViewMonitor.METADADO.AgenciaLiquidacao)
				.Field(ViewMonitor.METADADO.ContaLiquidacao)
				.Field(ViewMonitor.METADADO.ValorLiberado)
				.Field(ViewMonitor.METADADO.DataAtualizacao)
				.Field(ViewMonitor.METADADO.UsuarioProposta)
				.Field(ViewMonitor.METADADO.ValorParcela)
				.Field(ViewMonitor.METADADO.NomeLoja)
				.Field(ViewMonitor.METADADO.NomeUsuarioProposta)
				.Field(ViewMonitor.METADADO.FamiliaProduto)
				.Field(ViewMonitor.METADADO.ComissaoNMP)
				.Field(ViewMonitor.METADADO.MensagemPendencia)
				.Field(ViewMonitor.METADADO.AguardandoLiberacao)
				.Field(ViewMonitor.METADADO.DataIntegracao)
				.Table(ViewMonitor.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				List<ViewMonitor> result = base.MapReaderToEntitySet<ViewMonitor>(cmd);
				return result;
			}
		}
		#endregion

		#region Obtem
		public ViewMonitor Obtem(int? Proposta)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(ViewMonitor.METADADO.Proposta)
				.Field(ViewMonitor.METADADO.DataCriacao)
				.Field(ViewMonitor.METADADO.CPFCNPJ)
				.Field(ViewMonitor.METADADO.TipoPessoa)
				.Field(ViewMonitor.METADADO.NomeProponente)
				.Field(ViewMonitor.METADADO.NumeroBeneficio)
				.Field(ViewMonitor.METADADO.EspecieBeneficio)
				.Field(ViewMonitor.METADADO.DDDCelular)
				.Field(ViewMonitor.METADADO.Celular)
				.Field(ViewMonitor.METADADO.Fase)
				.Field(ViewMonitor.METADADO.Status)
				.Field(ViewMonitor.METADADO.DescricaoFase)
				.Field(ViewMonitor.METADADO.DescricaoStatus)
				.Field(ViewMonitor.METADADO.Gerente)
				.Field(ViewMonitor.METADADO.Usuario)
				.Field(ViewMonitor.METADADO.Promotora)
				.Field(ViewMonitor.METADADO.ProfissionalCertificado)
				.Field(ViewMonitor.METADADO.MotivoRecusa)
				.Field(ViewMonitor.METADADO.Produto)
				.Field(ViewMonitor.METADADO.ValorOperacao)
				.Field(ViewMonitor.METADADO.ValorFinanciado)
				.Field(ViewMonitor.METADADO.Prazo)
				.Field(ViewMonitor.METADADO.DataPrimeiroVencimento)
				.Field(ViewMonitor.METADADO.Tabela)
				.Field(ViewMonitor.METADADO.ContratoLegado)
				.Field(ViewMonitor.METADADO.PropostaLegado)
				.Field(ViewMonitor.METADADO.RedeLojas)
				.Field(ViewMonitor.METADADO.Loja)
				.Field(ViewMonitor.METADADO.BancoLiquidacao)
				.Field(ViewMonitor.METADADO.AgenciaLiquidacao)
				.Field(ViewMonitor.METADADO.ContaLiquidacao)
				.Field(ViewMonitor.METADADO.ValorLiberado)
				.Field(ViewMonitor.METADADO.DataAtualizacao)
				.Field(ViewMonitor.METADADO.UsuarioProposta)
				.Field(ViewMonitor.METADADO.ValorParcela)
				.Field(ViewMonitor.METADADO.NomeLoja)
				.Field(ViewMonitor.METADADO.NomeUsuarioProposta)
				.Field(ViewMonitor.METADADO.FamiliaProduto)
				.Field(ViewMonitor.METADADO.ComissaoNMP)
				.Field(ViewMonitor.METADADO.MensagemPendencia)
				.Field(ViewMonitor.METADADO.AguardandoLiberacao)
				.Field(ViewMonitor.METADADO.DataIntegracao)
				.Table(ViewMonitor.METADADO.tabelaNAME);

			query.Where
				.Add(ViewMonitor.METADADO.Proposta, Filter.Equal, Proposta);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				ViewMonitor result = base.MapReaderToEntity<ViewMonitor>(cmd);
				return result;
			}
		}
		#endregion

	}
}
