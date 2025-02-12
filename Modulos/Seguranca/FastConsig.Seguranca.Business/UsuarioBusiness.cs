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
   public partial class UsuarioBusiness : BusinessBase
   {

      #region Listar todos
      public virtual List<Usuario> Listar(WhereBuilder filtro)
      {
         UsuarioData objUsuarioData = new UsuarioData();

         #region Regras de negócio
         #endregion

         return objUsuarioData.Listar(filtro);
      }
      #endregion

      #region Listar Monitor
      public virtual List<Usuario> ListarMonitor(WhereBuilder filtro)
      {
         UsuarioData objUsuarioData = new UsuarioData();

         #region Regras de negócio
         #endregion

         return objUsuarioData.ListarMonitor(filtro);
      }
      #endregion

      #region Alterar
      public void Alterar(Usuario obj)
      {
         UsuarioData objUsuarioData = new UsuarioData();

         #region Regras de negócio
         #endregion

         objUsuarioData.Alterar(obj);
      }
      #endregion

      #region Inserir
      public void Incluir(Usuario obj)
      {
         UsuarioData objUsuarioData = new UsuarioData();

         #region Regras de negócio
         #endregion

         objUsuarioData.Incluir(obj);
      }
      #endregion

      #region Obtem
      public virtual Usuario Obtem(string Id)
      {
         UsuarioData objUsuarioData = new UsuarioData();

         #region Regras de negócio
         #endregion

         return objUsuarioData.Obtem(Id);
      }
      #endregion

      #region Excluir por FKs
      #endregion

      #region Excluir por PK
      public void Excluir(string Id)
      {
         UsuarioData objUsuarioData = new UsuarioData();

         #region Regras de negócio
         #endregion

         objUsuarioData.Excluir(Id);
      }
      #endregion

   }
}
