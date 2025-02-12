using FastConsig.Seguranca.Data;
using FastConsig.Seguranca.Entity;
using Framework;
using Framework.Data;
using System.Collections.Generic;

namespace FastConsig.Seguranca.Business
{
   public partial class DominioBusiness : BusinessBase
   {

      #region Listar todos
      public virtual List<Dominio> Listar(WhereBuilder filtro)
      {
         DominioData objDominioData = new DominioData();

         #region Regras de negócio
         #endregion

         return objDominioData.Listar(filtro);
      }
      #endregion

      #region Alterar
      public void Alterar(Dominio obj)
      {
         DominioData objDominioData = new DominioData();

         #region Regras de negócio
         #endregion

         objDominioData.Alterar(obj);
      }
      #endregion

      #region Inserir
      public void Incluir(Dominio obj)
      {
         DominioData objDominioData = new DominioData();

         #region Regras de negócio
         #endregion

         objDominioData.Incluir(obj);
      }
      #endregion

      #region Obtem
      public virtual Dominio Obtem(int? Id)
      {
         DominioData objDominioData = new DominioData();

         #region Regras de negócio
         #endregion

         return objDominioData.Obtem(Id);
      }
      #endregion

      #region Excluir por FKs
      #endregion

      #region Excluir por PK
      public void Excluir(int? Id)
      {
         DominioData objDominioData = new DominioData();

         #region Regras de negócio
         #endregion

         objDominioData.Excluir(Id);
      }
      #endregion

   }
}
