
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
	public partial class SimulacaoPessoaBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<SimulacaoPessoa> Listar(WhereBuilder filtro)
		{
			SimulacaoPessoaData objSimulacaoPessoaData = new SimulacaoPessoaData();

			#region Regras de negócio
			#endregion

			return objSimulacaoPessoaData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(SimulacaoPessoa obj)
		{
			SimulacaoPessoaData objSimulacaoPessoaData = new SimulacaoPessoaData();

			#region Regras de negócio
			#endregion

			objSimulacaoPessoaData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(SimulacaoPessoa obj)
		{
			SimulacaoPessoaData objSimulacaoPessoaData = new SimulacaoPessoaData();

			#region Regras de negócio
			#endregion

			objSimulacaoPessoaData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual SimulacaoPessoa Obtem(int? Id)
		{
			SimulacaoPessoaData objSimulacaoPessoaData = new SimulacaoPessoaData();

			#region Regras de negócio
			#endregion

			return objSimulacaoPessoaData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			SimulacaoPessoaData objSimulacaoPessoaData = new SimulacaoPessoaData();

			#region Regras de negócio
			#endregion

			objSimulacaoPessoaData.Excluir(Id);
		}
		#endregion

	}
}
