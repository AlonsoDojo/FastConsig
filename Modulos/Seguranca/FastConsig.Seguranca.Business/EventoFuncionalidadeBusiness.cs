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
   public partial class EventoFuncionalidadeBusiness : BusinessBase
   {

      #region Listar todos
      public virtual List<EventoFuncionalidade> Listar(WhereBuilder filtro)
      {
         EventoFuncionalidadeData objEventoFuncionalidadeData = new EventoFuncionalidadeData();

         #region Regras de negócio
         #endregion

         return objEventoFuncionalidadeData.Listar(filtro);
      }
      #endregion

      #region Alterar
      public void Alterar(EventoFuncionalidade obj)
      {
         EventoFuncionalidadeData objEventoFuncionalidadeData = new EventoFuncionalidadeData();

         #region Regras de negócio
         #endregion

         objEventoFuncionalidadeData.Alterar(obj);
      }
      #endregion

      #region Inserir
      public void Incluir(EventoFuncionalidade obj)
      {
         EventoFuncionalidadeData objEventoFuncionalidadeData = new EventoFuncionalidadeData();

         #region Regras de negócio
         #endregion

         objEventoFuncionalidadeData.Incluir(obj);
      }
      #endregion

      #region Obtem
      public virtual EventoFuncionalidade Obtem(int? Id)
      {
         EventoFuncionalidadeData objEventoFuncionalidadeData = new EventoFuncionalidadeData();

         #region Regras de negócio
         #endregion

         return objEventoFuncionalidadeData.Obtem(Id);
      }
      #endregion

      #region Excluir por FKs
      public void ExcluirPor_IdFuncionalidade(int? IdFuncionalidade)
      {
         EventoFuncionalidadeData objEventoFuncionalidadeData = new EventoFuncionalidadeData();

         #region Regras de negócio
         #endregion

         objEventoFuncionalidadeData.ExcluirPor_IdFuncionalidade(IdFuncionalidade);
      }
      #endregion

      #region Excluir por PK
      public void Excluir(int? Id)
      {
         EventoFuncionalidadeData objEventoFuncionalidadeData = new EventoFuncionalidadeData();

         #region Regras de negócio
         #endregion

         objEventoFuncionalidadeData.Excluir(Id);
      }
      #endregion

   }
}
