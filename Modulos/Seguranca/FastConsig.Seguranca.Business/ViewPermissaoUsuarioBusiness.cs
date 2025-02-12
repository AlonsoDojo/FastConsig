using Framework.Data;
using Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FastConsig.Seguranca.Data;
using FastConsig.Seguranca.Entity;

namespace FastConsig.Seguranca.Business
{
   public partial class ViewPermissaoUsuarioBusiness : BusinessBase
   {
      public List<ViewPermissaoUsuario> ObtemPermissao(string idUsuario)
      {
         var filtro = WhereBuilder.Create()
                         .Add(ViewPermissaoUsuario.METADADO.IdUsuario, Filter.Equal, idUsuario);

         return Listar(filtro);
      }

      public List<ViewPermissaoUsuario> JoinPermissions(List<ViewPermissaoUsuario> permissions)
      {
         if (permissions == null || permissions.Count == 0)
            return null;

         ViewPermissaoUsuario previous = null;
         var result = new List<ViewPermissaoUsuario>();

         permissions = permissions.OrderBy(p => p.IdFuncionalidade).ToList();
         for (int i = 0; i < permissions.Count; i++)
         {
            var current = permissions[i];
            if (previous != null && current.IdFuncionalidade == previous.IdFuncionalidade)
            {
               //A idéia é verificar as permissões da funcionalidade dentro dos vários perfis 
               //que o usuário pode ter. Deve-se utilizar a permissão MENOS RESTRITIVA, ou seja:
               // READONLY + FULL = FULL
               // FULL + FULL = FULL
               // READONLY + READONLY = READONLY
               //previous.ReadOnly &= current.ReadOnly;

               if (previous.Sequencia > current.Sequencia)
                  previous.Sequencia = current.Sequencia;
            }
            else
            {
               result.Add(current);
               previous = current;
            }
         }

         return result;
      }

      #region Listar todos
      public virtual List<ViewPermissaoUsuario> Listar(WhereBuilder filtro)
      {
         ViewPermissaoUsuarioData objViewPermissaoUsuarioData = new ViewPermissaoUsuarioData();

         #region Regras de negócio
         #endregion

         return objViewPermissaoUsuarioData.Listar(filtro);
      }
      #endregion

      #region Obtem
      public virtual ViewPermissaoUsuario Obtem(string IdUsuario)
      {
         ViewPermissaoUsuarioData objViewPermissaoUsuarioData = new ViewPermissaoUsuarioData();

         #region Regras de negócio
         #endregion

         return objViewPermissaoUsuarioData.Obtem(IdUsuario);
      }
      #endregion

   }
}
