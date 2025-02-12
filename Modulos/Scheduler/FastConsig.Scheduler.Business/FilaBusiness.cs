using FastConsig.Scheduler.Data;
using FastConsig.Scheduler.Entity;
using Framework;
using Framework.Data;
using System.Collections.Generic;

namespace FastConsig.Scheduler.Business
{
   public partial class FilaBusiness : BusinessBase
   {

      #region Listar todos
      public virtual List<Fila> Listar(WhereBuilder filtro)
      {
         FilaData objFilaData = new FilaData();

         #region Regras de negócio
         #endregion

         return objFilaData.Listar(filtro);
      }
      #endregion

      #region Alterar
      public void Alterar(Fila obj)
      {
         FilaData objFilaData = new FilaData();

         #region Regras de negócio
         #endregion

         objFilaData.Alterar(obj);
      }
      #endregion

      #region Inserir
      public void Incluir(Fila obj)
      {
         FilaData objFilaData = new FilaData();

         #region Regras de negócio
         #endregion

         objFilaData.Incluir(obj);
      }
      #endregion

      #region Obtem
      public virtual Fila Obtem(int? Id)
      {
         FilaData objFilaData = new FilaData();

         #region Regras de negócio
         #endregion

         return objFilaData.Obtem(Id);
      }
      #endregion

      #region Excluir por FKs
      #endregion

      #region Excluir por PK
      public void Excluir(int? Id)
      {
         FilaData objFilaData = new FilaData();

         #region Regras de negócio
         #endregion

         objFilaData.Excluir(Id);
      }
      #endregion

   }
}
