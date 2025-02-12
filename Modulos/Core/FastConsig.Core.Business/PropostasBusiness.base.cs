
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
	public partial class PropostasBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<Propostas> Listar(WhereBuilder filtro)
		{
			PropostasData objPropostasData = new PropostasData();

			#region Regras de negócio
			#endregion

			return objPropostasData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(Propostas obj)
		{
			PropostasData objPropostasData = new PropostasData();

			#region Regras de negócio
			#endregion

			objPropostasData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(Propostas obj)
		{
			PropostasData objPropostasData = new PropostasData();

			#region Regras de negócio
			#endregion

			objPropostasData.Incluir(obj);
		}
      #endregion

      #region Desbloquear
      public void Desbloquear(Propostas obj)
      {
         PropostasData objPropostaData = new PropostasData();

         #region Regras de negócio
         #endregion

         objPropostaData.Desbloquear(obj);
      }
      #endregion

      #region Bloquear
      public void Bloquear(Propostas obj)
      {
         PropostasData objPropostaData = new PropostasData();

         #region Regras de negócio
         #endregion

         objPropostaData.Bloquear(obj);
      }
      #endregion

      #region Obtem
      public virtual Propostas Obtem(int? Id)
		{
			PropostasData objPropostasData = new PropostasData();

			#region Regras de negócio
			#endregion

			return objPropostasData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		public void ExcluirPor_TipoFormalizacao(int? TipoFormalizacao)
		{
			PropostasData objPropostasData = new PropostasData();

			#region Regras de negócio
			#endregion

			objPropostasData.ExcluirPor_TipoFormalizacao(TipoFormalizacao);
		}
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			PropostasData objPropostasData = new PropostasData();

			#region Regras de negócio
			#endregion

			objPropostasData.Excluir(Id);
		}
		#endregion

	}
}
