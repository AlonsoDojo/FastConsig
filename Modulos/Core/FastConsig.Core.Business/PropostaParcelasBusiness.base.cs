
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
	public partial class PropostaParcelasBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<PropostaParcelas> Listar(WhereBuilder filtro)
		{
			PropostaParcelasData objPropostaParcelasData = new PropostaParcelasData();

			#region Regras de negócio
			#endregion

			return objPropostaParcelasData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(PropostaParcelas obj)
		{
			PropostaParcelasData objPropostaParcelasData = new PropostaParcelasData();

			#region Regras de negócio
			#endregion

			objPropostaParcelasData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(PropostaParcelas obj)
		{
			PropostaParcelasData objPropostaParcelasData = new PropostaParcelasData();

			#region Regras de negócio
			#endregion

			objPropostaParcelasData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual PropostaParcelas Obtem(int? Id)
		{
			PropostaParcelasData objPropostaParcelasData = new PropostaParcelasData();

			#region Regras de negócio
			#endregion

			return objPropostaParcelasData.Obtem(Id);
		}
      #endregion

      #region Excluir por FKs
      public void ExcluirPorProposta(int? proposta)
      {
         PropostaParcelasData objParcelasData = new PropostaParcelasData();

         #region Regras de negócio
         #endregion

         objParcelasData.ExcluirPorProposta(proposta);
      }
      #endregion

      #region Excluir por PK
      public void Excluir(int? Id)
		{
			PropostaParcelasData objPropostaParcelasData = new PropostaParcelasData();

			#region Regras de negócio
			#endregion

			objPropostaParcelasData.Excluir(Id);
		}
		#endregion

	}
}
