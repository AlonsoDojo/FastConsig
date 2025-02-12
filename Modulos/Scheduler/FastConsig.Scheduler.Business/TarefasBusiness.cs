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
   public partial class TarefasBusiness : BusinessBase
   {

      #region Listar todos
      public virtual List<Tarefa> Listar(WhereBuilder filtro)
      {
         TarefasData objTarefasData = new TarefasData();

         #region Regras de negócio
         #endregion

         return objTarefasData.Listar(filtro);
      }
      #endregion

      #region Alterar
      public void Alterar(Tarefa obj)
      {
         TarefasData objTarefasData = new TarefasData();

         #region Regras de negócio
         #endregion

         objTarefasData.Alterar(obj);
      }
      #endregion

      #region Inserir
      public void Incluir(Tarefa obj)
      {
         TarefasData objTarefasData = new TarefasData();

         #region Regras de negócio
         #endregion

         objTarefasData.Incluir(obj);
      }
      #endregion

      #region Obtem
      public virtual Tarefa Obtem(int? Id)
      {
         TarefasData objTarefasData = new TarefasData();

         #region Regras de negócio
         #endregion

         return objTarefasData.Obtem(Id);
      }
      #endregion

      #region Excluir por FKs
      public void ExcluirPor_TipoTarefa(int? TipoTarefa)
      {
         TarefasData objTarefasData = new TarefasData();

         #region Regras de negócio
         #endregion

         objTarefasData.ExcluirPor_TipoTarefa(TipoTarefa);
      }
      public void ExcluirPor_TipoAgenda(int? TipoAgenda)
      {
         TarefasData objTarefasData = new TarefasData();

         #region Regras de negócio
         #endregion

         objTarefasData.ExcluirPor_TipoAgenda(TipoAgenda);
      }
      public void ExcluirPor_Fila(int? Fila)
      {
         TarefasData objTarefasData = new TarefasData();

         #region Regras de negócio
         #endregion

         objTarefasData.ExcluirPor_Fila(Fila);
      }
      #endregion

      #region Excluir por PK
      public void Excluir(int? Id)
      {
         TarefasData objTarefasData = new TarefasData();

         #region Regras de negócio
         #endregion

         objTarefasData.Excluir(Id);
      }
      #endregion

   }
}
