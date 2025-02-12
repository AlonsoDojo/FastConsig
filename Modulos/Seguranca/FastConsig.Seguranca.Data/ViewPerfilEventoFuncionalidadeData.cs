using FastConsig.Seguranca.Entity;
using Framework.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.Seguranca.Data
{
   public partial class ViewPerfilEventoFuncionalidadeData : DataBase
   {

      #region Listar
      public List<ViewPerfilEventoFuncionalidade> Listar(WhereBuilder filtro)
      {
         #region QueryBuilder

         QueryBuilder query = QueryBuilder.Create(this)
            .Field(ViewPerfilEventoFuncionalidade.METADADO.Id)
            .Field(ViewPerfilEventoFuncionalidade.METADADO.Nome)
            .Field(ViewPerfilEventoFuncionalidade.METADADO.PerfilEventoFuncionalidadeId)
            .Field(ViewPerfilEventoFuncionalidade.METADADO.Habilitado)
            .Field(ViewPerfilEventoFuncionalidade.METADADO.IdPerfilFuncionalidade)
            .Field(ViewPerfilEventoFuncionalidade.METADADO.IdFuncionalidade)
            .Field(ViewPerfilEventoFuncionalidade.METADADO.IdPerfil)
            .Table(ViewPerfilEventoFuncionalidade.METADADO.tabelaNAME);

         query.Where = filtro;

         #endregion

         HandleCustomizedQuery(query);

         using (IDbConnection connection = base.CreateConnection())
         {
            IDbCommand cmd = base.CreateCommand(connection, query.ToString());
            query.SetParameters(cmd);

            List<ViewPerfilEventoFuncionalidade> result = base.MapReaderToEntitySet<ViewPerfilEventoFuncionalidade>(cmd);
            return result;
         }
      }
      #endregion

      #region Obtem
      public ViewPerfilEventoFuncionalidade Obtem(int? Id)
      {
         #region QueryBuilder

         QueryBuilder query = QueryBuilder.Create(this)
            .Field(ViewPerfilEventoFuncionalidade.METADADO.Id)
            .Field(ViewPerfilEventoFuncionalidade.METADADO.Nome)
            .Field(ViewPerfilEventoFuncionalidade.METADADO.PerfilEventoFuncionalidadeId)
            .Field(ViewPerfilEventoFuncionalidade.METADADO.Habilitado)
            .Field(ViewPerfilEventoFuncionalidade.METADADO.IdPerfilFuncionalidade)
            .Field(ViewPerfilEventoFuncionalidade.METADADO.IdFuncionalidade)
            .Field(ViewPerfilEventoFuncionalidade.METADADO.IdPerfil)
            .Table(ViewPerfilEventoFuncionalidade.METADADO.tabelaNAME);

         query.Where
            .Add(ViewPerfilEventoFuncionalidade.METADADO.Id, Filter.Equal, Id);

         HandleCustomizedQuery(query);

         #endregion

         using (IDbConnection connection = base.CreateConnection())
         {
            IDbCommand cmd = base.CreateCommand(connection, query.ToString());
            query.SetParameters(cmd);

            ViewPerfilEventoFuncionalidade result = base.MapReaderToEntity<ViewPerfilEventoFuncionalidade>(cmd);
            return result;
         }
      }
      #endregion

   }
}
