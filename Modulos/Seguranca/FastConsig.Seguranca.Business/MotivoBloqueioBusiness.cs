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
   public partial class MotivoBloqueioBusiness : BusinessBase
   {

      #region Listar todos
      public virtual List<MotivoBloqueio> Listar(WhereBuilder filtro)
      {
         MotivoBloqueioData objMotivoBloqueioData = new MotivoBloqueioData();

         #region Regras de negócio
         #endregion

         return objMotivoBloqueioData.Listar(filtro);
      }
      #endregion

      #region Alterar
      public void Alterar(MotivoBloqueio obj)
      {
         MotivoBloqueioData objMotivoBloqueioData = new MotivoBloqueioData();

         #region Regras de negócio
         #endregion

         objMotivoBloqueioData.Alterar(obj);
      }
      #endregion

      #region Inserir
      public void Incluir(MotivoBloqueio obj)
      {
         MotivoBloqueioData objMotivoBloqueioData = new MotivoBloqueioData();

         #region Regras de negócio
         #endregion

         objMotivoBloqueioData.Incluir(obj);
      }
      #endregion

      #region Obtem
      public virtual MotivoBloqueio Obtem(int? Id)
      {
         MotivoBloqueioData objMotivoBloqueioData = new MotivoBloqueioData();

         #region Regras de negócio
         #endregion

         return objMotivoBloqueioData.Obtem(Id);
      }
      #endregion

      #region Excluir por FKs
      public void ExcluirPor_Origem(int? Origem)
      {
         MotivoBloqueioData objMotivoBloqueioData = new MotivoBloqueioData();

         #region Regras de negócio
         #endregion

         objMotivoBloqueioData.ExcluirPor_Origem(Origem);
      }
      #endregion

      #region Excluir por PK
      public void Excluir(int? Id)
      {
         MotivoBloqueioData objMotivoBloqueioData = new MotivoBloqueioData();

         #region Regras de negócio
         #endregion

         objMotivoBloqueioData.Excluir(Id);
      }
      #endregion

   }
}
