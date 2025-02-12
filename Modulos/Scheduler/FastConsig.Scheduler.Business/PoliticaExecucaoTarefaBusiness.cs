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
   public partial class PoliticaExecucaoTarefaBusiness : BusinessBase
   {

      #region Listar todos
      public virtual List<PoliticaExecucaoTarefa> Listar(WhereBuilder filtro)
      {
         PoliticaExecucaoTarefaData objPoliticaExecucaoTarefaData = new PoliticaExecucaoTarefaData();

         #region Regras de negócio
         #endregion

         return objPoliticaExecucaoTarefaData.Listar(filtro);
      }
      #endregion

      #region Alterar
      public void Alterar(PoliticaExecucaoTarefa obj)
      {
         PoliticaExecucaoTarefaData objPoliticaExecucaoTarefaData = new PoliticaExecucaoTarefaData();

         #region Regras de negócio
         #endregion

         objPoliticaExecucaoTarefaData.Alterar(obj);
      }
      #endregion

      #region Inserir
      public void Incluir(PoliticaExecucaoTarefa obj)
      {
         PoliticaExecucaoTarefaData objPoliticaExecucaoTarefaData = new PoliticaExecucaoTarefaData();

         #region Regras de negócio
         #endregion

         objPoliticaExecucaoTarefaData.Incluir(obj);
      }
      #endregion

      #region Obtem
      public virtual PoliticaExecucaoTarefa Obtem(int? Id)
      {
         PoliticaExecucaoTarefaData objPoliticaExecucaoTarefaData = new PoliticaExecucaoTarefaData();

         #region Regras de negócio
         #endregion

         return objPoliticaExecucaoTarefaData.Obtem(Id);
      }
      #endregion

      #region Excluir por FKs
      #endregion

      #region Excluir por PK
      public void Excluir(int? Id)
      {
         PoliticaExecucaoTarefaData objPoliticaExecucaoTarefaData = new PoliticaExecucaoTarefaData();

         #region Regras de negócio
         #endregion

         objPoliticaExecucaoTarefaData.Excluir(Id);
      }
      #endregion

   }
}
