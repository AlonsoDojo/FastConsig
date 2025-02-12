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
   public partial class UsuarioBloqueioBusiness : BusinessBase
   {

      #region Listar todos
      public virtual List<UsuarioBloqueio> Listar(WhereBuilder filtro)
      {
         UsuarioBloqueioData objUsuarioBloqueioData = new UsuarioBloqueioData();

         #region Regras de negócio
         #endregion

         return objUsuarioBloqueioData.Listar(filtro);
      }
      #endregion

      #region Alterar
      public void Alterar(UsuarioBloqueio obj)
      {
         UsuarioBloqueioData objUsuarioBloqueioData = new UsuarioBloqueioData();

         #region Regras de negócio
         #endregion

         objUsuarioBloqueioData.Alterar(obj);
      }
      #endregion

      #region Inserir
      public void Incluir(UsuarioBloqueio obj)
      {
         UsuarioBloqueioData objUsuarioBloqueioData = new UsuarioBloqueioData();

         #region Regras de negócio
         #endregion

         objUsuarioBloqueioData.Incluir(obj);
      }
      #endregion

      #region Obtem
      public virtual UsuarioBloqueio Obtem(int? Id)
      {
         UsuarioBloqueioData objUsuarioBloqueioData = new UsuarioBloqueioData();

         #region Regras de negócio
         #endregion

         return objUsuarioBloqueioData.Obtem(Id);
      }
      #endregion

      #region Excluir por FKs
      public void ExcluirPor_MotivoBloqueio(int? MotivoBloqueio)
      {
         UsuarioBloqueioData objUsuarioBloqueioData = new UsuarioBloqueioData();

         #region Regras de negócio
         #endregion

         objUsuarioBloqueioData.ExcluirPor_MotivoBloqueio(MotivoBloqueio);
      }
      public void ExcluirPor_OrigemBloqueio(int? OrigemBloqueio)
      {
         UsuarioBloqueioData objUsuarioBloqueioData = new UsuarioBloqueioData();

         #region Regras de negócio
         #endregion

         objUsuarioBloqueioData.ExcluirPor_OrigemBloqueio(OrigemBloqueio);
      }
      #endregion

      #region Excluir por PK
      public void Excluir(int? Id)
      {
         UsuarioBloqueioData objUsuarioBloqueioData = new UsuarioBloqueioData();

         #region Regras de negócio
         #endregion

         objUsuarioBloqueioData.Excluir(Id);
      }
      #endregion

   }
}
