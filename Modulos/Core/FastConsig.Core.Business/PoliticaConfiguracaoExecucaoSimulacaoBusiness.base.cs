
#region Usings
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;
using Framework.Data;
using FastConsig.Core.Entity;
using FastConsig.Core.Data;
#endregion

namespace FastConsig.Core.Business
{
	public partial class PoliticaConfiguracaoExecucaoSimulacaoBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<PoliticaConfiguracaoExecucaoSimulacao> Listar(WhereBuilder filtro)
		{
			PoliticaConfiguracaoExecucaoSimulacaoData objPoliticaConfiguracaoExecucaoSimulacaoData = new PoliticaConfiguracaoExecucaoSimulacaoData();

			#region Regras de negócio
			#endregion

			return objPoliticaConfiguracaoExecucaoSimulacaoData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(PoliticaConfiguracaoExecucaoSimulacao obj)
		{
			PoliticaConfiguracaoExecucaoSimulacaoData objPoliticaConfiguracaoExecucaoSimulacaoData = new PoliticaConfiguracaoExecucaoSimulacaoData();

			#region Regras de negócio
			#endregion

			objPoliticaConfiguracaoExecucaoSimulacaoData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(PoliticaConfiguracaoExecucaoSimulacao obj)
		{
			PoliticaConfiguracaoExecucaoSimulacaoData objPoliticaConfiguracaoExecucaoSimulacaoData = new PoliticaConfiguracaoExecucaoSimulacaoData();

			#region Regras de negócio
			#endregion

			objPoliticaConfiguracaoExecucaoSimulacaoData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual PoliticaConfiguracaoExecucaoSimulacao Obtem(int? Id)
		{
			PoliticaConfiguracaoExecucaoSimulacaoData objPoliticaConfiguracaoExecucaoSimulacaoData = new PoliticaConfiguracaoExecucaoSimulacaoData();

			#region Regras de negócio
			#endregion

			return objPoliticaConfiguracaoExecucaoSimulacaoData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		public void ExcluirPor_Produto(int? Produto)
		{
			PoliticaConfiguracaoExecucaoSimulacaoData objPoliticaConfiguracaoExecucaoSimulacaoData = new PoliticaConfiguracaoExecucaoSimulacaoData();

			#region Regras de negócio
			#endregion

			objPoliticaConfiguracaoExecucaoSimulacaoData.ExcluirPor_Produto(Produto);
		}
		public void ExcluirPor_TipoPessoa(int? TipoPessoa)
		{
			PoliticaConfiguracaoExecucaoSimulacaoData objPoliticaConfiguracaoExecucaoSimulacaoData = new PoliticaConfiguracaoExecucaoSimulacaoData();

			#region Regras de negócio
			#endregion

			objPoliticaConfiguracaoExecucaoSimulacaoData.ExcluirPor_TipoPessoa(TipoPessoa);
		}
		public void ExcluirPor_Politica(int? Politica)
		{
			PoliticaConfiguracaoExecucaoSimulacaoData objPoliticaConfiguracaoExecucaoSimulacaoData = new PoliticaConfiguracaoExecucaoSimulacaoData();

			#region Regras de negócio
			#endregion

			objPoliticaConfiguracaoExecucaoSimulacaoData.ExcluirPor_Politica(Politica);
		}
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			PoliticaConfiguracaoExecucaoSimulacaoData objPoliticaConfiguracaoExecucaoSimulacaoData = new PoliticaConfiguracaoExecucaoSimulacaoData();

			#region Regras de negócio
			#endregion

			objPoliticaConfiguracaoExecucaoSimulacaoData.Excluir(Id);
		}
		#endregion

	}
}
