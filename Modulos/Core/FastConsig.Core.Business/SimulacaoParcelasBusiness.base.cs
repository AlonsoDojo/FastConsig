
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
	public partial class SimulacaoParcelasBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<SimulacaoParcelas> Listar(WhereBuilder filtro)
		{
			SimulacaoParcelasData objSimulacaoParcelasData = new SimulacaoParcelasData();

			#region Regras de negócio
			#endregion

			return objSimulacaoParcelasData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(SimulacaoParcelas obj)
		{
			SimulacaoParcelasData objSimulacaoParcelasData = new SimulacaoParcelasData();

			#region Regras de negócio
			#endregion

			objSimulacaoParcelasData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(SimulacaoParcelas obj)
		{
			SimulacaoParcelasData objSimulacaoParcelasData = new SimulacaoParcelasData();

			#region Regras de negócio
			#endregion

			objSimulacaoParcelasData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual SimulacaoParcelas Obtem(int? Id)
		{
			SimulacaoParcelasData objSimulacaoParcelasData = new SimulacaoParcelasData();

			#region Regras de negócio
			#endregion

			return objSimulacaoParcelasData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		public void ExcluirPor_Simulacao(int? Simulacao)
		{
			SimulacaoParcelasData objSimulacaoParcelasData = new SimulacaoParcelasData();

			#region Regras de negócio
			#endregion

			objSimulacaoParcelasData.ExcluirPor_Simulacao(Simulacao);
		}
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			SimulacaoParcelasData objSimulacaoParcelasData = new SimulacaoParcelasData();

			#region Regras de negócio
			#endregion

			objSimulacaoParcelasData.Excluir(Id);
		}
		#endregion

	}
}
