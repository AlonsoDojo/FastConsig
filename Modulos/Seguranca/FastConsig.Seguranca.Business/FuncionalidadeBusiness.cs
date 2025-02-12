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
   public partial class FuncionalidadeBusiness : BusinessBase
   {

      #region Listar todos
      public virtual List<Funcionalidade> Listar(WhereBuilder filtro)
      {
         FuncionalidadeData objFuncionalidadeData = new FuncionalidadeData();

         #region Regras de negócio
         #endregion

         return objFuncionalidadeData.Listar(filtro);
      }
      #endregion

      #region Alterar
      public void Alterar(Funcionalidade obj)
      {
         FuncionalidadeData objFuncionalidadeData = new FuncionalidadeData();

         #region Regras de negócio
         #endregion

         objFuncionalidadeData.Alterar(obj);
      }
      #endregion

      #region Inserir
      public void Incluir(Funcionalidade obj)
      {
         FuncionalidadeData objFuncionalidadeData = new FuncionalidadeData();

         #region Regras de negócio
         #endregion

         objFuncionalidadeData.Incluir(obj);
      }
      #endregion

      #region Obtem
      public virtual Funcionalidade Obtem(int? Id)
      {
         FuncionalidadeData objFuncionalidadeData = new FuncionalidadeData();

         #region Regras de negócio
         #endregion

         return objFuncionalidadeData.Obtem(Id);
      }
      #endregion

      #region Excluir por FKs
      public void ExcluirPor_IdGrupoFuncionalidade(int? IdGrupoFuncionalidade)
      {
         FuncionalidadeData objFuncionalidadeData = new FuncionalidadeData();

         #region Regras de negócio
         #endregion

         objFuncionalidadeData.ExcluirPor_IdGrupoFuncionalidade(IdGrupoFuncionalidade);
      }
      #endregion

      #region Excluir por PK
      public void Excluir(int? Id)
      {
         FuncionalidadeData objFuncionalidadeData = new FuncionalidadeData();

         #region Regras de negócio
         #endregion

         objFuncionalidadeData.Excluir(Id);
      }
      #endregion

   }
}
