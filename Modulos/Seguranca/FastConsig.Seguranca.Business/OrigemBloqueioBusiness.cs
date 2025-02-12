using FastConsig.Seguranca.Data;
using FastConsig.Seguranca.Entity;
using Framework.Data;
using Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.Seguranca.Business
{
   public partial class OrigemBloqueioBusiness : BusinessBase
   {

      #region Listar todos
      public virtual List<OrigemBloqueio> Listar(WhereBuilder filtro)
      {
         OrigemBloqueioData objOrigemBloqueioData = new OrigemBloqueioData();

         #region Regras de negócio
         #endregion

         return objOrigemBloqueioData.Listar(filtro);
      }
      #endregion

      #region Alterar
      public void Alterar(OrigemBloqueio obj)
      {
         OrigemBloqueioData objOrigemBloqueioData = new OrigemBloqueioData();

         #region Regras de negócio
         #endregion

         objOrigemBloqueioData.Alterar(obj);
      }
      #endregion

      #region Inserir
      public void Incluir(OrigemBloqueio obj)
      {
         OrigemBloqueioData objOrigemBloqueioData = new OrigemBloqueioData();

         #region Regras de negócio
         #endregion

         objOrigemBloqueioData.Incluir(obj);
      }
      #endregion

      #region Obtem
      public virtual OrigemBloqueio Obtem(int? Id)
      {
         OrigemBloqueioData objOrigemBloqueioData = new OrigemBloqueioData();

         #region Regras de negócio
         #endregion

         return objOrigemBloqueioData.Obtem(Id);
      }
      #endregion

      #region Excluir por FKs
      #endregion

      #region Excluir por PK
      public void Excluir(int? Id)
      {
         OrigemBloqueioData objOrigemBloqueioData = new OrigemBloqueioData();

         #region Regras de negócio
         #endregion

         objOrigemBloqueioData.Excluir(Id);
      }
      #endregion

   }
}
