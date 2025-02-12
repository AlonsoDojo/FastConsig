using FastConsig.Seguranca.Data;
using FastConsig.Seguranca.Entity;
using Framework;
using Framework.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.Seguranca.Business
{
   public partial class ViewPerfilUsuarioBusiness : BusinessBase
   {
      public virtual List<ViewPerfilUsuario> Listar(string idUsuario)
      {
         var filtro = WhereBuilder.Create()
                                  .Add(ViewPerfilUsuario.METADADO.IdUsuario, Filter.Equal, idUsuario);

         return Listar(filtro);
      }

      #region Listar todos
      public virtual List<ViewPerfilUsuario> Listar(WhereBuilder filtro)
      {
         ViewPerfilUsuarioData objViewPerfilUsuarioData = new ViewPerfilUsuarioData();

         #region Regras de negócio
         #endregion

         return objViewPerfilUsuarioData.Listar(filtro);
      }
      #endregion

      #region Obtem
      public virtual ViewPerfilUsuario Obtem(int? Id)
      {
         ViewPerfilUsuarioData objViewPerfilUsuarioData = new ViewPerfilUsuarioData();

         #region Regras de negócio
         #endregion

         return objViewPerfilUsuarioData.Obtem(Id);
      }
      #endregion

   }
}
