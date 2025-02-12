
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
	public partial class SimulacaoOperacaoBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<SimulacaoOperacao> Listar(WhereBuilder filtro)
		{
			SimulacaoOperacaoData objSimulacaoOperacaoData = new SimulacaoOperacaoData();

			#region Regras de negócio
			#endregion

			return objSimulacaoOperacaoData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(SimulacaoOperacao obj)
		{
			SimulacaoOperacaoData objSimulacaoOperacaoData = new SimulacaoOperacaoData();

			#region Regras de negócio
			#endregion

			objSimulacaoOperacaoData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(SimulacaoOperacao obj)
		{
			SimulacaoOperacaoData objSimulacaoOperacaoData = new SimulacaoOperacaoData();

			#region Regras de negócio
			#endregion

			objSimulacaoOperacaoData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual SimulacaoOperacao Obtem(int? Id)
		{
			SimulacaoOperacaoData objSimulacaoOperacaoData = new SimulacaoOperacaoData();

			#region Regras de negócio
			#endregion

			return objSimulacaoOperacaoData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		public void ExcluirPor_Simulacao(int? Simulacao)
		{
			SimulacaoOperacaoData objSimulacaoOperacaoData = new SimulacaoOperacaoData();

			#region Regras de negócio
			#endregion

			objSimulacaoOperacaoData.ExcluirPor_Simulacao(Simulacao);
		}
		public void ExcluirPor_Produto(int? Produto)
		{
			SimulacaoOperacaoData objSimulacaoOperacaoData = new SimulacaoOperacaoData();

			#region Regras de negócio
			#endregion

			objSimulacaoOperacaoData.ExcluirPor_Produto(Produto);
		}
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			SimulacaoOperacaoData objSimulacaoOperacaoData = new SimulacaoOperacaoData();

			#region Regras de negócio
			#endregion

			objSimulacaoOperacaoData.Excluir(Id);
		}
		#endregion

	}
}
