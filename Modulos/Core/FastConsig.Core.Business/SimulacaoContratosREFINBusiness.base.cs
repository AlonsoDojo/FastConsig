
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
	public partial class SimulacaoContratosREFINBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<SimulacaoContratosREFIN> Listar(WhereBuilder filtro)
		{
			SimulacaoContratosREFINData objSimulacaoContratosREFINData = new SimulacaoContratosREFINData();

			#region Regras de negócio
			#endregion

			return objSimulacaoContratosREFINData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(SimulacaoContratosREFIN obj)
		{
			SimulacaoContratosREFINData objSimulacaoContratosREFINData = new SimulacaoContratosREFINData();

			#region Regras de negócio
			#endregion

			objSimulacaoContratosREFINData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(SimulacaoContratosREFIN obj)
		{
			SimulacaoContratosREFINData objSimulacaoContratosREFINData = new SimulacaoContratosREFINData();

			#region Regras de negócio
			#endregion

			objSimulacaoContratosREFINData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual SimulacaoContratosREFIN Obtem(int? Id)
		{
			SimulacaoContratosREFINData objSimulacaoContratosREFINData = new SimulacaoContratosREFINData();

			#region Regras de negócio
			#endregion

			return objSimulacaoContratosREFINData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			SimulacaoContratosREFINData objSimulacaoContratosREFINData = new SimulacaoContratosREFINData();

			#region Regras de negócio
			#endregion

			objSimulacaoContratosREFINData.Excluir(Id);
		}
		#endregion

	}
}
