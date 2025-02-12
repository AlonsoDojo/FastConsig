
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
	public partial class SimulacaoPropostaBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<SimulacaoProposta> Listar(WhereBuilder filtro)
		{
			SimulacaoPropostaData objSimulacaoPropostaData = new SimulacaoPropostaData();

			#region Regras de negócio
			#endregion

			return objSimulacaoPropostaData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(SimulacaoProposta obj)
		{
			SimulacaoPropostaData objSimulacaoPropostaData = new SimulacaoPropostaData();

			#region Regras de negócio
			#endregion

			objSimulacaoPropostaData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(SimulacaoProposta obj)
		{
			SimulacaoPropostaData objSimulacaoPropostaData = new SimulacaoPropostaData();

			#region Regras de negócio
			#endregion

			objSimulacaoPropostaData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual SimulacaoProposta Obtem(int? Id)
		{
			SimulacaoPropostaData objSimulacaoPropostaData = new SimulacaoPropostaData();

			#region Regras de negócio
			#endregion

			return objSimulacaoPropostaData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		public void ExcluirPor_Promotora(int? Promotora)
		{
			SimulacaoPropostaData objSimulacaoPropostaData = new SimulacaoPropostaData();

			#region Regras de negócio
			#endregion

			objSimulacaoPropostaData.ExcluirPor_Promotora(Promotora);
		}
		public void ExcluirPor_Pessoa(int? Pessoa)
		{
			SimulacaoPropostaData objSimulacaoPropostaData = new SimulacaoPropostaData();

			#region Regras de negócio
			#endregion

			objSimulacaoPropostaData.ExcluirPor_Pessoa(Pessoa);
		}
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			SimulacaoPropostaData objSimulacaoPropostaData = new SimulacaoPropostaData();

			#region Regras de negócio
			#endregion

			objSimulacaoPropostaData.Excluir(Id);
		}
		#endregion

	}
}
