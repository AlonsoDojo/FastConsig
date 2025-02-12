
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
	public partial class PropostaArquivosBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<PropostaArquivos> Listar(WhereBuilder filtro)
		{
			PropostaArquivosData objPropostaArquivosData = new PropostaArquivosData();

			#region Regras de negócio
			#endregion

			return objPropostaArquivosData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(PropostaArquivos obj)
		{
			PropostaArquivosData objPropostaArquivosData = new PropostaArquivosData();

			#region Regras de negócio
			#endregion

			objPropostaArquivosData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(PropostaArquivos obj)
		{
			PropostaArquivosData objPropostaArquivosData = new PropostaArquivosData();

			#region Regras de negócio
			#endregion

			objPropostaArquivosData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual PropostaArquivos Obtem(int? Id)
		{
			PropostaArquivosData objPropostaArquivosData = new PropostaArquivosData();

			#region Regras de negócio
			#endregion

			return objPropostaArquivosData.Obtem(Id);
		}
      #endregion

      #region Excluir por FKs
      public void ExcluirPorChave(long? proposta, string chave)
      {
         PropostaArquivosData objArquivoPropostaData = new PropostaArquivosData();

         #region Regras de negócio
         #endregion

         objArquivoPropostaData.ExcluirPorChave(proposta, chave);
      }
      #endregion

      #region Excluir por PK
      public void Excluir(int? Id)
		{
			PropostaArquivosData objPropostaArquivosData = new PropostaArquivosData();

			#region Regras de negócio
			#endregion

			objPropostaArquivosData.Excluir(Id);
		}
		#endregion

	}
}
