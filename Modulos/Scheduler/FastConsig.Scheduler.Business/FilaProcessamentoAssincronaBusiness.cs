using FastConsig.Scheduler.Entity;
using Framework.Data;
using Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FastConsig.Scheduler.Data;

namespace FastConsig.Scheduler.Business
{
   public partial class FilaProcessamentoAssincronaBusiness : BusinessBase
   {

      #region Listar todos
      public virtual List<FilaProcessamentoAssincrona> Listar(WhereBuilder filtro)
      {
         FilaProcessamentoAssincronaData objFilaProcessamentoAssincronaData = new FilaProcessamentoAssincronaData();

         #region Regras de negócio
         #endregion

         return objFilaProcessamentoAssincronaData.Listar(filtro);
      }
      #endregion

      #region Alterar
      public void Alterar(FilaProcessamentoAssincrona obj)
      {
         FilaProcessamentoAssincronaData objFilaProcessamentoAssincronaData = new FilaProcessamentoAssincronaData();

         #region Regras de negócio
         #endregion

         objFilaProcessamentoAssincronaData.Alterar(obj);
      }
      #endregion

      #region Inserir
      public void Incluir(FilaProcessamentoAssincrona obj)
      {
         FilaProcessamentoAssincronaData objFilaProcessamentoAssincronaData = new FilaProcessamentoAssincronaData();

         #region Regras de negócio
         #endregion

         objFilaProcessamentoAssincronaData.Incluir(obj);
      }
      #endregion

      #region Obtem
      public virtual FilaProcessamentoAssincrona Obtem(int? Id)
      {
         FilaProcessamentoAssincronaData objFilaProcessamentoAssincronaData = new FilaProcessamentoAssincronaData();

         #region Regras de negócio
         #endregion

         return objFilaProcessamentoAssincronaData.Obtem(Id);
      }
      #endregion

      #region Excluir por FKs
      public void ExcluirPor_Fila(int? Fila)
      {
         FilaProcessamentoAssincronaData objFilaProcessamentoAssincronaData = new FilaProcessamentoAssincronaData();

         #region Regras de negócio
         #endregion

         objFilaProcessamentoAssincronaData.ExcluirPor_Fila(Fila);
      }
      #endregion

      #region Excluir por PK
      public void Excluir(int? Id)
      {
         FilaProcessamentoAssincronaData objFilaProcessamentoAssincronaData = new FilaProcessamentoAssincronaData();

         #region Regras de negócio
         #endregion

         objFilaProcessamentoAssincronaData.Excluir(Id);
      }
      #endregion

   }
}
