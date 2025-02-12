
#region Usings
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;
using Framework.Data;
using FastConsig.CTC.Entity;
using FastConsig.CTC.Data;
#endregion

namespace FastConsig.CTC.Business
{
	public partial class CTCPoliticaConfiguracaoExecucaoBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<CTCPoliticaConfiguracaoExecucao> Listar(WhereBuilder filtro)
		{
			CTCPoliticaConfiguracaoExecucaoData objCTCPoliticaConfiguracaoExecucaoData = new CTCPoliticaConfiguracaoExecucaoData();

			#region Regras de negócio
			#endregion

			return objCTCPoliticaConfiguracaoExecucaoData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(CTCPoliticaConfiguracaoExecucao obj)
		{
			CTCPoliticaConfiguracaoExecucaoData objCTCPoliticaConfiguracaoExecucaoData = new CTCPoliticaConfiguracaoExecucaoData();

			#region Regras de negócio
			#endregion

			objCTCPoliticaConfiguracaoExecucaoData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(CTCPoliticaConfiguracaoExecucao obj)
		{
			CTCPoliticaConfiguracaoExecucaoData objCTCPoliticaConfiguracaoExecucaoData = new CTCPoliticaConfiguracaoExecucaoData();

			#region Regras de negócio
			#endregion

			objCTCPoliticaConfiguracaoExecucaoData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual CTCPoliticaConfiguracaoExecucao Obtem(int? Id)
		{
			CTCPoliticaConfiguracaoExecucaoData objCTCPoliticaConfiguracaoExecucaoData = new CTCPoliticaConfiguracaoExecucaoData();

			#region Regras de negócio
			#endregion

			return objCTCPoliticaConfiguracaoExecucaoData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		public void ExcluirPor_TipoArquivo(int? TipoArquivo)
		{
			CTCPoliticaConfiguracaoExecucaoData objCTCPoliticaConfiguracaoExecucaoData = new CTCPoliticaConfiguracaoExecucaoData();

			#region Regras de negócio
			#endregion

			objCTCPoliticaConfiguracaoExecucaoData.ExcluirPor_TipoArquivo(TipoArquivo);
		}
		public void ExcluirPor_TipoPessoa(int? TipoPessoa)
		{
			CTCPoliticaConfiguracaoExecucaoData objCTCPoliticaConfiguracaoExecucaoData = new CTCPoliticaConfiguracaoExecucaoData();

			#region Regras de negócio
			#endregion

			objCTCPoliticaConfiguracaoExecucaoData.ExcluirPor_TipoPessoa(TipoPessoa);
		}
		public void ExcluirPor_Fase(int? Fase)
		{
			CTCPoliticaConfiguracaoExecucaoData objCTCPoliticaConfiguracaoExecucaoData = new CTCPoliticaConfiguracaoExecucaoData();

			#region Regras de negócio
			#endregion

			objCTCPoliticaConfiguracaoExecucaoData.ExcluirPor_Fase(Fase);
		}
		public void ExcluirPor_Politica(int? Politica)
		{
			CTCPoliticaConfiguracaoExecucaoData objCTCPoliticaConfiguracaoExecucaoData = new CTCPoliticaConfiguracaoExecucaoData();

			#region Regras de negócio
			#endregion

			objCTCPoliticaConfiguracaoExecucaoData.ExcluirPor_Politica(Politica);
		}
		public void ExcluirPor_TipoFluxo(int? TipoFluxo)
		{
			CTCPoliticaConfiguracaoExecucaoData objCTCPoliticaConfiguracaoExecucaoData = new CTCPoliticaConfiguracaoExecucaoData();

			#region Regras de negócio
			#endregion

			objCTCPoliticaConfiguracaoExecucaoData.ExcluirPor_TipoFluxo(TipoFluxo);
		}
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			CTCPoliticaConfiguracaoExecucaoData objCTCPoliticaConfiguracaoExecucaoData = new CTCPoliticaConfiguracaoExecucaoData();

			#region Regras de negócio
			#endregion

			objCTCPoliticaConfiguracaoExecucaoData.Excluir(Id);
		}
		#endregion

	}
}
