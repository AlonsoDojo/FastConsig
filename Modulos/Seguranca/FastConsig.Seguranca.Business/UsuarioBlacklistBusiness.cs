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
   public partial class UsuarioBlacklistBusiness : BusinessBase
   {

      #region Listar todos
      public virtual List<UsuarioBlacklist> Listar(WhereBuilder filtro)
      {
         UsuarioBlacklistData objUsuarioBlacklistData = new UsuarioBlacklistData();

         #region Regras de negócio
         #endregion

         return objUsuarioBlacklistData.Listar(filtro);
      }
      #endregion

      #region Alterar
      public void Alterar(UsuarioBlacklist obj)
      {
         UsuarioBlacklistData objUsuarioBlacklistData = new UsuarioBlacklistData();

         #region Regras de negócio
         #endregion

         objUsuarioBlacklistData.Alterar(obj);
      }
      #endregion

      #region Inserir
      public void Incluir(UsuarioBlacklist obj)
      {
         UsuarioBlacklistData objUsuarioBlacklistData = new UsuarioBlacklistData();

         #region Regras de negócio
         #endregion

         objUsuarioBlacklistData.Incluir(obj);
      }
      #endregion

      #region Obtem
      public virtual UsuarioBlacklist Obtem(long? CpfCnpj)
      {
         UsuarioBlacklistData objUsuarioBlacklistData = new UsuarioBlacklistData();

         #region Regras de negócio
         #endregion

         return objUsuarioBlacklistData.Obtem(CpfCnpj);
      }
      #endregion

      #region Excluir por FKs
      #endregion

      #region Excluir por PK
      public void Excluir(long? CpfCnpj)
      {
         UsuarioBlacklistData objUsuarioBlacklistData = new UsuarioBlacklistData();

         #region Regras de negócio
         #endregion

         objUsuarioBlacklistData.Excluir(CpfCnpj);
      }
      #endregion

   }
}
