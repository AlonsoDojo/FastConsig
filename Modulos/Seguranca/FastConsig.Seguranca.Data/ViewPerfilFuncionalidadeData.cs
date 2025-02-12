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
   public partial class ViewPerfilFuncionalidadeData : DataBase
   {

      #region Listar
      public List<ViewPerfilFuncionalidade> Listar(WhereBuilder filtro)
      {
         #region QueryBuilder

         QueryBuilder query = QueryBuilder.Create(this)
            .Field(ViewPerfilFuncionalidade.METADADO.IdFuncionalidade)
            .Field(ViewPerfilFuncionalidade.METADADO.IdGrupoFuncionalidade)
            .Field(ViewPerfilFuncionalidade.METADADO.IdPerfil)
            .Field(ViewPerfilFuncionalidade.METADADO.NomeGrupo)
            .Field(ViewPerfilFuncionalidade.METADADO.Sequencia)
            .Field(ViewPerfilFuncionalidade.METADADO.Nome)
            .Field(ViewPerfilFuncionalidade.METADADO.Url)
            .Field(ViewPerfilFuncionalidade.METADADO.Habilitado)
            .Table(ViewPerfilFuncionalidade.METADADO.tabelaNAME);

         query.Where = filtro;

         #endregion

         HandleCustomizedQuery(query);

         using (IDbConnection connection = base.CreateConnection())
         {
            IDbCommand cmd = base.CreateCommand(connection, query.ToString());
            query.SetParameters(cmd);

            List<ViewPerfilFuncionalidade> result = base.MapReaderToEntitySet<ViewPerfilFuncionalidade>(cmd);
            return result;
         }
      }
      #endregion

      #region Obtem
      public ViewPerfilFuncionalidade Obtem(int? IdFuncionalidade)
      {
         #region QueryBuilder

         QueryBuilder query = QueryBuilder.Create(this)
            .Field(ViewPerfilFuncionalidade.METADADO.IdFuncionalidade)
            .Field(ViewPerfilFuncionalidade.METADADO.IdGrupoFuncionalidade)
            .Field(ViewPerfilFuncionalidade.METADADO.IdPerfil)
            .Field(ViewPerfilFuncionalidade.METADADO.NomeGrupo)
            .Field(ViewPerfilFuncionalidade.METADADO.Sequencia)
            .Field(ViewPerfilFuncionalidade.METADADO.Nome)
            .Field(ViewPerfilFuncionalidade.METADADO.Url)
            .Field(ViewPerfilFuncionalidade.METADADO.Habilitado)
            .Table(ViewPerfilFuncionalidade.METADADO.tabelaNAME);

         query.Where
            .Add(ViewPerfilFuncionalidade.METADADO.IdFuncionalidade, Filter.Equal, IdFuncionalidade);

         HandleCustomizedQuery(query);

         #endregion

         using (IDbConnection connection = base.CreateConnection())
         {
            IDbCommand cmd = base.CreateCommand(connection, query.ToString());
            query.SetParameters(cmd);

            ViewPerfilFuncionalidade result = base.MapReaderToEntity<ViewPerfilFuncionalidade>(cmd);
            return result;
         }
      }
      #endregion

   }
}
