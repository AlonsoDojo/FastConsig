
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
	public partial class PropostaContratosREFINBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<PropostaContratosREFIN> Listar(WhereBuilder filtro)
		{
			PropostaContratosREFINData objPropostaContratosREFINData = new PropostaContratosREFINData();

			#region Regras de negócio
			#endregion

			return objPropostaContratosREFINData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(PropostaContratosREFIN obj)
		{
			PropostaContratosREFINData objPropostaContratosREFINData = new PropostaContratosREFINData();

			#region Regras de negócio
			#endregion

			objPropostaContratosREFINData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(PropostaContratosREFIN obj)
		{
			PropostaContratosREFINData objPropostaContratosREFINData = new PropostaContratosREFINData();

			#region Regras de negócio
			#endregion

			objPropostaContratosREFINData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual PropostaContratosREFIN Obtem(int? Id)
		{
			PropostaContratosREFINData objPropostaContratosREFINData = new PropostaContratosREFINData();

			#region Regras de negócio
			#endregion

			return objPropostaContratosREFINData.Obtem(Id);
		}
      #endregion

      #region Excluir por FKs
      public void ExcluirPorProposta(long? Proposta)
      {
         PropostaContratosREFINData objContratosREFINData = new PropostaContratosREFINData();

         #region Regras de negócio
         #endregion

         objContratosREFINData.ExcluirPorProposta(Proposta);
      }
      #endregion

      #region Excluir por PK
      public void Excluir(int? Id)
		{
			PropostaContratosREFINData objPropostaContratosREFINData = new PropostaContratosREFINData();

			#region Regras de negócio
			#endregion

			objPropostaContratosREFINData.Excluir(Id);
		}
		#endregion

	}
}
