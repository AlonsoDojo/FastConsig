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
   public partial class OrigemBloqueioData : DataBase
   {
      public OrigemBloqueioData()
      {
         this.CustomizeQuery += new CustomizeQueryDelegate(Handle_CustomizeQuery);
      }

      void Handle_CustomizeQuery(QueryBuilder query)
      {

      }

      #region Listar
      public List<OrigemBloqueio> Listar(WhereBuilder filtro)
      {
         #region QueryBuilder

         QueryBuilder query = QueryBuilder.Create(this)
            .Field(OrigemBloqueio.METADADO.Id)
            .Field(OrigemBloqueio.METADADO.Descricao)
            .Table(OrigemBloqueio.METADADO.tabelaNAME);

         query.Where = filtro;

         #endregion

         HandleCustomizedQuery(query);

         using (IDbConnection connection = base.CreateConnection())
         {
            IDbCommand cmd = base.CreateCommand(connection, query.ToString());
            cmd.CommandTimeout = 600;
            query.SetParameters(cmd);

            List<OrigemBloqueio> result = base.MapReaderToEntitySet<OrigemBloqueio>(cmd);
            return result;
         }
      }
      #endregion

      #region Alterar
      public void Alterar(OrigemBloqueio obj)
      {
         #region UpdateBuilder

         UpdateBuilder update = UpdateBuilder.Create(this)
            .FieldValue(OrigemBloqueio.METADADO.Descricao, obj.Descricao)
            .Table(OrigemBloqueio.METADADO.tabelaNAME);

         update.Where
            .Add(OrigemBloqueio.METADADO.Id, Filter.Equal, obj.Id);

         #endregion

         using (IDbConnection connection = base.CreateConnection())
         {
            IDbCommand cmd = base.CreateCommand(connection, update.ToString());
            cmd.CommandTimeout = 600;
            update.SetParameters(cmd);

            base.ExecuteNonQuery(cmd);
         }
      }
      #endregion

      #region Inserir
      public void Incluir(OrigemBloqueio obj)
      {
         #region InsertBuilder

         InsertBuilder insert = InsertBuilder.Create(this)
            .Table(OrigemBloqueio.METADADO.tabelaNAME)
            .FieldValue(OrigemBloqueio.METADADO.Descricao, obj.Descricao)
            .SetIdentityField(OrigemBloqueio.METADADO.Id);

         #endregion

         using (IDbConnection connection = base.CreateConnection())
         {
            IDbCommand cmd = base.CreateCommand(connection, insert.ToString());
            cmd.CommandTimeout = 600;
            insert.SetParameters(cmd);

            obj.Id = base.ExecuteScalar<int?>(cmd);
         }
      }
      #endregion

      #region Obtem
      public OrigemBloqueio Obtem(int? Id)
      {
         #region QueryBuilder

         QueryBuilder query = QueryBuilder.Create(this)
            .Field(OrigemBloqueio.METADADO.Id)
            .Field(OrigemBloqueio.METADADO.Descricao)
            .Table(OrigemBloqueio.METADADO.tabelaNAME);

         query.Where
            .Add(OrigemBloqueio.METADADO.Id, Filter.Equal, Id);

         HandleCustomizedQuery(query);

         #endregion

         using (IDbConnection connection = base.CreateConnection())
         {
            IDbCommand cmd = base.CreateCommand(connection, query.ToString());
            cmd.CommandTimeout = 600;
            query.SetParameters(cmd);

            OrigemBloqueio result = base.MapReaderToEntity<OrigemBloqueio>(cmd);
            return result;
         }
      }
      #endregion

      #region Excluir por FKs
      #endregion

      #region Excluir por PK
      public void Excluir(int? Id)
      {
         #region DeleteBuilder

         DeleteBuilder delete = DeleteBuilder.Create(this);
         delete.Table(OrigemBloqueio.METADADO.tabelaNAME);
         delete.Where
            .Add(OrigemBloqueio.METADADO.Id, Filter.Equal, Id);

         #endregion

         using (IDbConnection connection = base.CreateConnection())
         {
            IDbCommand cmd = base.CreateCommand(connection, delete.ToString());
            cmd.CommandTimeout = 600;
            delete.SetParameters(cmd);

            base.ExecuteNonQuery(cmd);
         }
      }
      #endregion

   }
}
