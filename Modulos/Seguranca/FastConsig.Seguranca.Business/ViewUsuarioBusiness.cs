using FastConsig.Seguranca.Data;
using FastConsig.Seguranca.Entity;
using Framework.Data;
using Framework;
using System.Collections.Generic;

namespace FastConsig.Seguranca.Business
{
   public partial class ViewUsuarioBusiness : BusinessBase
   {

      #region Listar todos
      public virtual List<ViewUsuario> Listar(WhereBuilder filtro)
      {
         ViewUsuarioData objViewUsuarioData = new ViewUsuarioData();

         #region Regras de negócio
         #endregion

         return objViewUsuarioData.Listar(filtro);
      }
      #endregion

      #region Obtem
      public virtual ViewUsuario Obtem(string Id)
      {
         ViewUsuarioData objViewUsuarioData = new ViewUsuarioData();

         #region Regras de negócio
         #endregion

         return objViewUsuarioData.Obtem(Id);
      }
      #endregion

   }
}
