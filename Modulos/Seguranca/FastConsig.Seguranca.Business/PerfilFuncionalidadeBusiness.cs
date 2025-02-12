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
   public partial class PerfilFuncionalidadeBusiness : BusinessBase
   {

      #region Listar todos
      public virtual List<PerfilFuncionalidade> Listar(WhereBuilder filtro)
      {
         PerfilFuncionalidadeData objPerfilFuncionalidadeData = new PerfilFuncionalidadeData();

         #region Regras de negócio
         #endregion

         return objPerfilFuncionalidadeData.Listar(filtro);
      }
      #endregion

      #region Alterar
      public void Alterar(PerfilFuncionalidade obj)
      {
         PerfilFuncionalidadeData objPerfilFuncionalidadeData = new PerfilFuncionalidadeData();

         #region Regras de negócio
         #endregion

         objPerfilFuncionalidadeData.Alterar(obj);
      }
      #endregion

      #region Inserir
      public void Incluir(PerfilFuncionalidade obj)
      {
         PerfilFuncionalidadeData objPerfilFuncionalidadeData = new PerfilFuncionalidadeData();

         #region Regras de negócio
         #endregion

         objPerfilFuncionalidadeData.Incluir(obj);
      }
      #endregion

      #region Obtem
      public virtual PerfilFuncionalidade Obtem(int? Id)
      {
         PerfilFuncionalidadeData objPerfilFuncionalidadeData = new PerfilFuncionalidadeData();

         #region Regras de negócio
         #endregion

         return objPerfilFuncionalidadeData.Obtem(Id);
      }
      #endregion

      #region Excluir por FKs
      public void ExcluirPor_IdPerfil(int? IdPerfil)
      {
         PerfilFuncionalidadeData objPerfilFuncionalidadeData = new PerfilFuncionalidadeData();

         #region Regras de negócio
         #endregion

         objPerfilFuncionalidadeData.ExcluirPor_IdPerfil(IdPerfil);
      }
      public void ExcluirPor_IdFuncionalidade(int? IdFuncionalidade)
      {
         PerfilFuncionalidadeData objPerfilFuncionalidadeData = new PerfilFuncionalidadeData();

         #region Regras de negócio
         #endregion

         objPerfilFuncionalidadeData.ExcluirPor_IdFuncionalidade(IdFuncionalidade);
      }
      #endregion

      #region Excluir por PK
      public void Excluir(int? Id)
      {
         PerfilFuncionalidadeData objPerfilFuncionalidadeData = new PerfilFuncionalidadeData();

         #region Regras de negócio
         #endregion

         objPerfilFuncionalidadeData.Excluir(Id);
      }
      #endregion

   }
}
