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
   public partial class PerfilEventoFuncionalidadeBusiness : BusinessBase
   {

      #region Listar todos
      public virtual List<PerfilEventoFuncionalidade> Listar(WhereBuilder filtro)
      {
         PerfilEventoFuncionalidadeData objPerfilEventoFuncionalidadeData = new PerfilEventoFuncionalidadeData();

         #region Regras de negócio
         #endregion

         return objPerfilEventoFuncionalidadeData.Listar(filtro);
      }
      #endregion

      #region Alterar
      public void Alterar(PerfilEventoFuncionalidade obj)
      {
         PerfilEventoFuncionalidadeData objPerfilEventoFuncionalidadeData = new PerfilEventoFuncionalidadeData();

         #region Regras de negócio
         #endregion

         objPerfilEventoFuncionalidadeData.Alterar(obj);
      }
      #endregion

      #region Inserir
      public void Incluir(PerfilEventoFuncionalidade obj)
      {
         PerfilEventoFuncionalidadeData objPerfilEventoFuncionalidadeData = new PerfilEventoFuncionalidadeData();

         #region Regras de negócio
         #endregion

         objPerfilEventoFuncionalidadeData.Incluir(obj);
      }
      #endregion

      #region Obtem
      public virtual PerfilEventoFuncionalidade Obtem(int? Id)
      {
         PerfilEventoFuncionalidadeData objPerfilEventoFuncionalidadeData = new PerfilEventoFuncionalidadeData();

         #region Regras de negócio
         #endregion

         return objPerfilEventoFuncionalidadeData.Obtem(Id);
      }
      #endregion

      #region Excluir por FKs
      public void ExcluirPor_IdPerfil(int? IdPerfil)
      {
         PerfilEventoFuncionalidadeData objPerfilEventoFuncionalidadeData = new PerfilEventoFuncionalidadeData();

         #region Regras de negócio
         #endregion

         objPerfilEventoFuncionalidadeData.ExcluirPor_IdPerfil(IdPerfil);
      }
      public void ExcluirPor_IdEventoFuncionalidade(int? IdEventoFuncionalidade)
      {
         PerfilEventoFuncionalidadeData objPerfilEventoFuncionalidadeData = new PerfilEventoFuncionalidadeData();

         #region Regras de negócio
         #endregion

         objPerfilEventoFuncionalidadeData.ExcluirPor_IdEventoFuncionalidade(IdEventoFuncionalidade);
      }
      #endregion

      #region Excluir por PK
      public void Excluir(int? Id)
      {
         PerfilEventoFuncionalidadeData objPerfilEventoFuncionalidadeData = new PerfilEventoFuncionalidadeData();

         #region Regras de negócio
         #endregion

         objPerfilEventoFuncionalidadeData.Excluir(Id);
      }
      #endregion

   }
}
