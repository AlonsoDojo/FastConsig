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
   public partial class UsuarioBlacklistData : DataBase
   {
      public UsuarioBlacklistData()
      {
         this.CustomizeQuery += new CustomizeQueryDelegate(Handle_CustomizeQuery);
      }

      void Handle_CustomizeQuery(QueryBuilder query)
      {

      }

      #region Listar
      public List<UsuarioBlacklist> Listar(WhereBuilder filtro)
      {
         #region QueryBuilder

         QueryBuilder query = QueryBuilder.Create(this)
            .Field(UsuarioBlacklist.METADADO.CpfCnpj)
            .Table(UsuarioBlacklist.METADADO.tabelaNAME);

         query.Where = filtro;

         #endregion

         HandleCustomizedQuery(query);

         using (IDbConnection connection = base.CreateConnection())
         {
            IDbCommand cmd = base.CreateCommand(connection, query.ToString());
            query.SetParameters(cmd);

            List<UsuarioBlacklist> result = base.MapReaderToEntitySet<UsuarioBlacklist>(cmd);
            return result;
         }
      }
      #endregion

      #region Alterar
      public void Alterar(UsuarioBlacklist obj)
      {
         #region UpdateBuilder

         UpdateBuilder update = UpdateBuilder.Create(this)
            .Table(UsuarioBlacklist.METADADO.tabelaNAME);

         update.Where
            .Add(UsuarioBlacklist.METADADO.CpfCnpj, Filter.Equal, obj.CpfCnpj);

         #endregion

         using (IDbConnection connection = base.CreateConnection())
         {
            IDbCommand cmd = base.CreateCommand(connection, update.ToString());
            update.SetParameters(cmd);

            base.ExecuteNonQuery(cmd);
         }
      }
      #endregion

      #region Inserir
      public void Incluir(UsuarioBlacklist obj)
      {
         #region InsertBuilder

         InsertBuilder insert = InsertBuilder.Create(this)
            .Table(UsuarioBlacklist.METADADO.tabelaNAME)
            .FieldValue(UsuarioBlacklist.METADADO.CpfCnpj, obj.CpfCnpj);

         #endregion

         using (IDbConnection connection = base.CreateConnection())
         {
            IDbCommand cmd = base.CreateCommand(connection, insert.ToString());
            insert.SetParameters(cmd);

            base.ExecuteNonQuery(cmd);
         }
      }
      #endregion

      #region Obtem
      public UsuarioBlacklist Obtem(long? CpfCnpj)
      {
         #region QueryBuilder

         QueryBuilder query = QueryBuilder.Create(this)
            .Field(UsuarioBlacklist.METADADO.CpfCnpj)
            .Table(UsuarioBlacklist.METADADO.tabelaNAME);

         query.Where
            .Add(UsuarioBlacklist.METADADO.CpfCnpj, Filter.Equal, CpfCnpj);

         HandleCustomizedQuery(query);

         #endregion

         using (IDbConnection connection = base.CreateConnection())
         {
            IDbCommand cmd = base.CreateCommand(connection, query.ToString());
            query.SetParameters(cmd);

            UsuarioBlacklist result = base.MapReaderToEntity<UsuarioBlacklist>(cmd);
            return result;
         }
      }
      #endregion

      #region Excluir por FKs
      #endregion

      #region Excluir por PK
      public void Excluir(long? CpfCnpj)
      {
         #region DeleteBuilder

         DeleteBuilder delete = DeleteBuilder.Create(this);
         delete.Table(UsuarioBlacklist.METADADO.tabelaNAME);
         delete.Where
            .Add(UsuarioBlacklist.METADADO.CpfCnpj, Filter.Equal, CpfCnpj);

         #endregion

         using (IDbConnection connection = base.CreateConnection())
         {
            IDbCommand cmd = base.CreateCommand(connection, delete.ToString());
            delete.SetParameters(cmd);

            base.ExecuteNonQuery(cmd);
         }
      }
      #endregion

   }
}
