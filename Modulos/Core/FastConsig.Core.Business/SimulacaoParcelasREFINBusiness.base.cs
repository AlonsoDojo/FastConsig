
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
	public partial class SimulacaoParcelasREFINBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<SimulacaoParcelasREFIN> Listar(WhereBuilder filtro)
		{
			SimulacaoParcelasREFINData objSimulacaoParcelasREFINData = new SimulacaoParcelasREFINData();

			#region Regras de negócio
			#endregion

			return objSimulacaoParcelasREFINData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(SimulacaoParcelasREFIN obj)
		{
			SimulacaoParcelasREFINData objSimulacaoParcelasREFINData = new SimulacaoParcelasREFINData();

			#region Regras de negócio
			#endregion

			objSimulacaoParcelasREFINData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(SimulacaoParcelasREFIN obj)
		{
			SimulacaoParcelasREFINData objSimulacaoParcelasREFINData = new SimulacaoParcelasREFINData();

			#region Regras de negócio
			#endregion

			objSimulacaoParcelasREFINData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual SimulacaoParcelasREFIN Obtem(int? Id)
		{
			SimulacaoParcelasREFINData objSimulacaoParcelasREFINData = new SimulacaoParcelasREFINData();

			#region Regras de negócio
			#endregion

			return objSimulacaoParcelasREFINData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			SimulacaoParcelasREFINData objSimulacaoParcelasREFINData = new SimulacaoParcelasREFINData();

			#region Regras de negócio
			#endregion

			objSimulacaoParcelasREFINData.Excluir(Id);
		}
		#endregion

	}
}
