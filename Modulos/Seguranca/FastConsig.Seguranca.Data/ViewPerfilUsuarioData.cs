using Framework.Data;
using Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FastConsig.Seguranca.Entity;
using System.Data;

namespace FastConsig.Seguranca.Data
{
   public partial class ViewPerfilUsuarioData : DataBase
   {
      public ViewPerfilUsuarioData()
      {
         this.CustomizeQuery += new CustomizeQueryDelegate(Handle_CustomizeQuery);
      }

      void Handle_CustomizeQuery(QueryBuilder query)
      {

      }

      #region Listar
      public List<ViewPerfilUsuario> Listar(WhereBuilder filtro)
      {
         #region QueryBuilder

         QueryBuilder query = QueryBuilder.Create(this)
            .Field(ViewPerfilUsuario.METADADO.Id)
            .Field(ViewPerfilUsuario.METADADO.IdPerfil)
            .Field(ViewPerfilUsuario.METADADO.NomePerfil)
            .Field(ViewPerfilUsuario.METADADO.IdUsuario)
            .Field(ViewPerfilUsuario.METADADO.Login)
            .Table(ViewPerfilUsuario.METADADO.tabelaNAME);

         query.Where = filtro;

         #endregion

         HandleCustomizedQuery(query);

         using (IDbConnection connection = base.CreateConnection())
         {
            IDbCommand cmd = base.CreateCommand(connection, query.ToString()); cmd.CommandTimeout = 600;
            query.SetParameters(cmd);

            List<ViewPerfilUsuario> result = base.MapReaderToEntitySet<ViewPerfilUsuario>(cmd);
            return result;
         }
      }
      #endregion

      #region Obtem
      public ViewPerfilUsuario Obtem(int? Id)
      {
         #region QueryBuilder

         QueryBuilder query = QueryBuilder.Create(this)
            .Field(ViewPerfilUsuario.METADADO.Id)
            .Field(ViewPerfilUsuario.METADADO.IdPerfil)
            .Field(ViewPerfilUsuario.METADADO.NomePerfil)
            .Field(ViewPerfilUsuario.METADADO.IdUsuario)
            .Field(ViewPerfilUsuario.METADADO.Login)
            .Table(ViewPerfilUsuario.METADADO.tabelaNAME);

         query.Where
            .Add(ViewPerfilUsuario.METADADO.Id, Filter.Equal, Id);

         HandleCustomizedQuery(query);

         #endregion

         using (IDbConnection connection = base.CreateConnection())
         {
            IDbCommand cmd = base.CreateCommand(connection, query.ToString()); cmd.CommandTimeout = 600;
            query.SetParameters(cmd);

            ViewPerfilUsuario result = base.MapReaderToEntity<ViewPerfilUsuario>(cmd);
            return result;
         }
      }
      #endregion

   }
}
