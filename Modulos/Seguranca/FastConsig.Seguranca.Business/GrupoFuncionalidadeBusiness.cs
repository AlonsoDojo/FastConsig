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
   public partial class GrupoFuncionalidadeBusiness : BusinessBase
   {

      #region Listar todos
      public virtual List<GrupoFuncionalidade> Listar(WhereBuilder filtro)
      {
         GrupoFuncionalidadeData objGrupoFuncionalidadeData = new GrupoFuncionalidadeData();

         #region Regras de negócio
         #endregion

         return objGrupoFuncionalidadeData.Listar(filtro);
      }
      #endregion

      #region Alterar
      public void Alterar(GrupoFuncionalidade obj)
      {
         GrupoFuncionalidadeData objGrupoFuncionalidadeData = new GrupoFuncionalidadeData();

         #region Regras de negócio
         #endregion

         objGrupoFuncionalidadeData.Alterar(obj);
      }
      #endregion

      #region Inserir
      public void Incluir(GrupoFuncionalidade obj)
      {
         GrupoFuncionalidadeData objGrupoFuncionalidadeData = new GrupoFuncionalidadeData();

         #region Regras de negócio
         #endregion

         objGrupoFuncionalidadeData.Incluir(obj);
      }
      #endregion

      #region Obtem
      public virtual GrupoFuncionalidade Obtem(int? Id)
      {
         GrupoFuncionalidadeData objGrupoFuncionalidadeData = new GrupoFuncionalidadeData();

         #region Regras de negócio
         #endregion

         return objGrupoFuncionalidadeData.Obtem(Id);
      }
      #endregion

      #region Excluir por FKs
      public void ExcluirPor_SistemaId(string SistemaId)
      {
         GrupoFuncionalidadeData objGrupoFuncionalidadeData = new GrupoFuncionalidadeData();

         #region Regras de negócio
         #endregion

         objGrupoFuncionalidadeData.ExcluirPor_SistemaId(SistemaId);
      }
      #endregion

      #region Excluir por PK
      public void Excluir(int? Id)
      {
         GrupoFuncionalidadeData objGrupoFuncionalidadeData = new GrupoFuncionalidadeData();

         #region Regras de negócio
         #endregion

         objGrupoFuncionalidadeData.Excluir(Id);
      }
      #endregion

   }
}
