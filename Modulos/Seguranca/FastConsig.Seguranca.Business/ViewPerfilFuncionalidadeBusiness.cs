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
   public partial class ViewPerfilFuncionalidadeBusiness : BusinessBase
   {

      #region Listar todos
      public virtual List<ViewPerfilFuncionalidade> Listar(WhereBuilder filtro)
      {
         ViewPerfilFuncionalidadeData objViewPerfilFuncionalidadeData = new ViewPerfilFuncionalidadeData();

         #region Regras de negócio
         #endregion

         return objViewPerfilFuncionalidadeData.Listar(filtro);
      }
      #endregion

      #region Obtem
      public virtual ViewPerfilFuncionalidade Obtem(int? IdFuncionalidade)
      {
         ViewPerfilFuncionalidadeData objViewPerfilFuncionalidadeData = new ViewPerfilFuncionalidadeData();

         #region Regras de negócio
         #endregion

         return objViewPerfilFuncionalidadeData.Obtem(IdFuncionalidade);
      }
      #endregion

      public List<ViewPerfilFuncionalidade> Listar(int idPerfil)
      {
         var filtro = WhereBuilder.Create()
                             .Add(ViewPerfilFuncionalidade.METADADO.IdPerfil, Filter.Equal, idPerfil);

         return Listar(filtro);
      }

   }
}
