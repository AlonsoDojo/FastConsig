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
   public partial class ViewPermissaoUsuarioData : DataBase
   {
      public ViewPermissaoUsuarioData()
      {
         this.CustomizeQuery += new CustomizeQueryDelegate(Handle_CustomizeQuery);
      }

      void Handle_CustomizeQuery(QueryBuilder query)
      {

      }

      #region Listar
      public List<ViewPermissaoUsuario> Listar(WhereBuilder filtro)
      {
         #region QueryBuilder

         QueryBuilder query = QueryBuilder.Create(this)
            .Field(ViewPermissaoUsuario.METADADO.IdUsuario)
            .Field(ViewPermissaoUsuario.METADADO.Login)
            .Field(ViewPermissaoUsuario.METADADO.IdGrupo)
            .Field(ViewPermissaoUsuario.METADADO.NomeGrupo)
            .Field(ViewPermissaoUsuario.METADADO.Ordem)
            .Field(ViewPermissaoUsuario.METADADO.IconeGrupo)
            .Field(ViewPermissaoUsuario.METADADO.IdFuncionalidade)
            .Field(ViewPermissaoUsuario.METADADO.Nome)
            .Field(ViewPermissaoUsuario.METADADO.Titulo)
            .Field(ViewPermissaoUsuario.METADADO.Descricao)
            .Field(ViewPermissaoUsuario.METADADO.Url)
            .Field(ViewPermissaoUsuario.METADADO.Sequencia)
            .Field(ViewPermissaoUsuario.METADADO.Visivel)
            .Field(ViewPermissaoUsuario.METADADO.IdPerfil)
            .Field(ViewPermissaoUsuario.METADADO.NomeAcao)
            .Field(ViewPermissaoUsuario.METADADO.Habilitado)
            .Table(ViewPermissaoUsuario.METADADO.tabelaNAME);

         query.Where = filtro;

         #endregion

         HandleCustomizedQuery(query);

         using (IDbConnection connection = base.CreateConnection())
         {
            IDbCommand cmd = base.CreateCommand(connection, query.ToString()); cmd.CommandTimeout = 600;
            query.SetParameters(cmd);

            List<ViewPermissaoUsuario> result = base.MapReaderToEntitySet<ViewPermissaoUsuario>(cmd);
            return result;
         }
      }
      #endregion

      #region Obtem
      public ViewPermissaoUsuario Obtem(string IdUsuario)
      {
         #region QueryBuilder

         QueryBuilder query = QueryBuilder.Create(this)
            .Field(ViewPermissaoUsuario.METADADO.IdUsuario)
            .Field(ViewPermissaoUsuario.METADADO.Login)
            .Field(ViewPermissaoUsuario.METADADO.IdGrupo)
            .Field(ViewPermissaoUsuario.METADADO.NomeGrupo)
            .Field(ViewPermissaoUsuario.METADADO.Ordem)
            .Field(ViewPermissaoUsuario.METADADO.IconeGrupo)
            .Field(ViewPermissaoUsuario.METADADO.IdFuncionalidade)
            .Field(ViewPermissaoUsuario.METADADO.Nome)
            .Field(ViewPermissaoUsuario.METADADO.Titulo)
            .Field(ViewPermissaoUsuario.METADADO.Descricao)
            .Field(ViewPermissaoUsuario.METADADO.Url)
            .Field(ViewPermissaoUsuario.METADADO.Sequencia)
            .Field(ViewPermissaoUsuario.METADADO.Visivel)
            .Field(ViewPermissaoUsuario.METADADO.IdPerfil)
            .Field(ViewPermissaoUsuario.METADADO.NomeAcao)
            .Field(ViewPermissaoUsuario.METADADO.Habilitado)
            .Table(ViewPermissaoUsuario.METADADO.tabelaNAME);

         query.Where
            .Add(ViewPermissaoUsuario.METADADO.IdUsuario, Filter.Equal, IdUsuario);

         HandleCustomizedQuery(query);

         #endregion

         using (IDbConnection connection = base.CreateConnection())
         {
            IDbCommand cmd = base.CreateCommand(connection, query.ToString()); cmd.CommandTimeout = 600;
            query.SetParameters(cmd);

            ViewPermissaoUsuario result = base.MapReaderToEntity<ViewPermissaoUsuario>(cmd);
            return result;
         }
      }
      #endregion
   }
}
