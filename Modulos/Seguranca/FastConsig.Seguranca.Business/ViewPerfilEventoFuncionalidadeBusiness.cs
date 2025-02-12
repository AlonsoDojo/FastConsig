using FastConsig.Seguranca.Entity;
using Framework.Data;
using Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FastConsig.Seguranca.Data;

namespace FastConsig.Seguranca.Business
{
   public partial class ViewPerfilEventoFuncionalidadeBusiness : BusinessBase
   {

      #region Listar todos
      public virtual List<ViewPerfilEventoFuncionalidade> Listar(WhereBuilder filtro)
      {
         ViewPerfilEventoFuncionalidadeData objViewPerfilEventoFuncionalidadeData = new ViewPerfilEventoFuncionalidadeData();

         #region Regras de negócio
         #endregion

         return objViewPerfilEventoFuncionalidadeData.Listar(filtro);
      }
      #endregion

      #region Obtem
      public virtual ViewPerfilEventoFuncionalidade Obtem(int? Id)
      {
         ViewPerfilEventoFuncionalidadeData objViewPerfilEventoFuncionalidadeData = new ViewPerfilEventoFuncionalidadeData();

         #region Regras de negócio
         #endregion

         return objViewPerfilEventoFuncionalidadeData.Obtem(Id);
      }
      #endregion

   }
}
