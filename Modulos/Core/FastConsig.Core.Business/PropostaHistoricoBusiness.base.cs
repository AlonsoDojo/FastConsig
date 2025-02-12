
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
	public partial class PropostaHistoricoBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<PropostaHistorico> Listar(WhereBuilder filtro)
		{
			PropostaHistoricoData objPropostaHistoricoData = new PropostaHistoricoData();

			#region Regras de negócio
			#endregion

			return objPropostaHistoricoData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(PropostaHistorico obj)
		{
			PropostaHistoricoData objPropostaHistoricoData = new PropostaHistoricoData();

			#region Regras de negócio
			#endregion

			objPropostaHistoricoData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(PropostaHistorico obj)
		{
			PropostaHistoricoData objPropostaHistoricoData = new PropostaHistoricoData();

			#region Regras de negócio
			#endregion

			objPropostaHistoricoData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual PropostaHistorico Obtem(int? Id)
		{
			PropostaHistoricoData objPropostaHistoricoData = new PropostaHistoricoData();

			#region Regras de negócio
			#endregion

			return objPropostaHistoricoData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		public void ExcluirPor_Proposta(int? Proposta)
		{
			PropostaHistoricoData objPropostaHistoricoData = new PropostaHistoricoData();

			#region Regras de negócio
			#endregion

			objPropostaHistoricoData.ExcluirPor_Proposta(Proposta);
		}
		public void ExcluirPor_Simulacao(int? Simulacao)
		{
			PropostaHistoricoData objPropostaHistoricoData = new PropostaHistoricoData();

			#region Regras de negócio
			#endregion

			objPropostaHistoricoData.ExcluirPor_Simulacao(Simulacao);
		}
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			PropostaHistoricoData objPropostaHistoricoData = new PropostaHistoricoData();

			#region Regras de negócio
			#endregion

			objPropostaHistoricoData.Excluir(Id);
		}
		#endregion

	}
}
