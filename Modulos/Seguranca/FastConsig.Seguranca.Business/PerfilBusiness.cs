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
   public partial class PerfilBusiness : BusinessBase
   {

      #region Listar todos
      public virtual List<Perfil> Listar(WhereBuilder filtro)
      {
         PerfilData objPerfilData = new PerfilData();

         #region Regras de negócio
         #endregion

         return objPerfilData.Listar(filtro);
      }
      #endregion

      #region Alterar
      public void Alterar(Perfil obj)
      {
         PerfilData objPerfilData = new PerfilData();

         #region Regras de negócio
         #endregion

         objPerfilData.Alterar(obj);
      }
      #endregion

      #region Inserir
      public void Incluir(Perfil obj)
      {
         PerfilData objPerfilData = new PerfilData();

         #region Regras de negócio
         #endregion

         objPerfilData.Incluir(obj);
      }
      #endregion

      #region Obtem
      public virtual Perfil Obtem(int? Id)
      {
         PerfilData objPerfilData = new PerfilData();

         #region Regras de negócio
         #endregion

         return objPerfilData.Obtem(Id);
      }
      #endregion

      #region Excluir por PK
      public void Excluir(int? Id)
      {
         PerfilData objPerfilData = new PerfilData();

         #region Regras de negócio
         #endregion

         objPerfilData.Excluir(Id);
      }
      #endregion

   }
}
