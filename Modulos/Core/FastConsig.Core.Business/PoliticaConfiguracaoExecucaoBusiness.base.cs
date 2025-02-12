
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
	public partial class PoliticaConfiguracaoExecucaoBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<PoliticaConfiguracaoExecucao> Listar(WhereBuilder filtro)
		{
			PoliticaConfiguracaoExecucaoData objPoliticaConfiguracaoExecucaoData = new PoliticaConfiguracaoExecucaoData();

			#region Regras de negócio
			#endregion

			return objPoliticaConfiguracaoExecucaoData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(PoliticaConfiguracaoExecucao obj)
		{
			PoliticaConfiguracaoExecucaoData objPoliticaConfiguracaoExecucaoData = new PoliticaConfiguracaoExecucaoData();

			#region Regras de negócio
			#endregion

			objPoliticaConfiguracaoExecucaoData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(PoliticaConfiguracaoExecucao obj)
		{
			PoliticaConfiguracaoExecucaoData objPoliticaConfiguracaoExecucaoData = new PoliticaConfiguracaoExecucaoData();

			#region Regras de negócio
			#endregion

			objPoliticaConfiguracaoExecucaoData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual PoliticaConfiguracaoExecucao Obtem(int? Id)
		{
			PoliticaConfiguracaoExecucaoData objPoliticaConfiguracaoExecucaoData = new PoliticaConfiguracaoExecucaoData();

			#region Regras de negócio
			#endregion

			return objPoliticaConfiguracaoExecucaoData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		public void ExcluirPor_Produto(int? Produto)
		{
			PoliticaConfiguracaoExecucaoData objPoliticaConfiguracaoExecucaoData = new PoliticaConfiguracaoExecucaoData();

			#region Regras de negócio
			#endregion

			objPoliticaConfiguracaoExecucaoData.ExcluirPor_Produto(Produto);
		}
		public void ExcluirPor_TipoPessoa(int? TipoPessoa)
		{
			PoliticaConfiguracaoExecucaoData objPoliticaConfiguracaoExecucaoData = new PoliticaConfiguracaoExecucaoData();

			#region Regras de negócio
			#endregion

			objPoliticaConfiguracaoExecucaoData.ExcluirPor_TipoPessoa(TipoPessoa);
		}
		public void ExcluirPor_Fase(int? Fase)
		{
			PoliticaConfiguracaoExecucaoData objPoliticaConfiguracaoExecucaoData = new PoliticaConfiguracaoExecucaoData();

			#region Regras de negócio
			#endregion

			objPoliticaConfiguracaoExecucaoData.ExcluirPor_Fase(Fase);
		}
		public void ExcluirPor_Politica(int? Politica)
		{
			PoliticaConfiguracaoExecucaoData objPoliticaConfiguracaoExecucaoData = new PoliticaConfiguracaoExecucaoData();

			#region Regras de negócio
			#endregion

			objPoliticaConfiguracaoExecucaoData.ExcluirPor_Politica(Politica);
		}
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			PoliticaConfiguracaoExecucaoData objPoliticaConfiguracaoExecucaoData = new PoliticaConfiguracaoExecucaoData();

			#region Regras de negócio
			#endregion

			objPoliticaConfiguracaoExecucaoData.Excluir(Id);
		}
		#endregion

	}
}
