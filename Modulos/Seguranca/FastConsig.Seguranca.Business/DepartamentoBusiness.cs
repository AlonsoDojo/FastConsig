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
   public partial class DepartamentoBusiness : BusinessBase
   {

      #region Listar todos
      public virtual List<Departamento> Listar(WhereBuilder filtro)
      {
         DepartamentoData objDepartamentoData = new DepartamentoData();

         #region Regras de negócio
         #endregion

         return objDepartamentoData.Listar(filtro);
      }
      #endregion

      #region Alterar
      public void Alterar(Departamento obj)
      {
         DepartamentoData objDepartamentoData = new DepartamentoData();

         #region Regras de negócio
         #endregion

         objDepartamentoData.Alterar(obj);
      }
      #endregion

      #region Inserir
      public void Incluir(Departamento obj)
      {
         DepartamentoData objDepartamentoData = new DepartamentoData();

         #region Regras de negócio
         #endregion

         objDepartamentoData.Incluir(obj);
      }
      #endregion

      #region Obtem
      public virtual Departamento Obtem(int? id)
      {
         DepartamentoData objDepartamentoData = new DepartamentoData();

         #region Regras de negócio
         #endregion

         return objDepartamentoData.Obtem(id);
      }
      #endregion

      #region Excluir por FKs
      #endregion

      #region Excluir por PK
      public void Excluir(int? id)
      {
         DepartamentoData objDepartamentoData = new DepartamentoData();

         #region Regras de negócio
         #endregion

         objDepartamentoData.Excluir(id);
      }
      #endregion

   }
}
