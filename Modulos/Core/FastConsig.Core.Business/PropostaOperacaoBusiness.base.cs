
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
	public partial class PropostaOperacaoBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<PropostaOperacao> Listar(WhereBuilder filtro)
		{
			PropostaOperacaoData objPropostaOperacaoData = new PropostaOperacaoData();

			#region Regras de negócio
			#endregion

			return objPropostaOperacaoData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(PropostaOperacao obj)
		{
			PropostaOperacaoData objPropostaOperacaoData = new PropostaOperacaoData();

			#region Regras de negócio
			#endregion

			objPropostaOperacaoData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(PropostaOperacao obj)
		{
			PropostaOperacaoData objPropostaOperacaoData = new PropostaOperacaoData();

			#region Regras de negócio
			#endregion

			objPropostaOperacaoData.Incluir(obj);
		}
      #endregion

      #region Obtem
      #endregion

      #region Excluir por FKs
      public void Excluir(long? Proposta)
      {
         PropostaOperacaoData objOperacoes = new PropostaOperacaoData();

         #region Regras de negócio
         #endregion

         objOperacoes.ExcluirPor_Proposta(Proposta);
      }
      #endregion

      #region Excluir por PK
      #endregion

   }
}
