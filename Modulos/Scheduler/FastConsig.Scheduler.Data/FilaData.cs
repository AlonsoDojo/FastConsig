using FastConsig.Scheduler.Entity;
using Framework.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.Scheduler.Data
{
   public partial class FilaData : DataBase
   {
      public FilaData()
      {
         this.CustomizeQuery += new CustomizeQueryDelegate(Handle_CustomizeQuery);
      }

      void Handle_CustomizeQuery(QueryBuilder query)
      {

      }
      #region Listar
      public List<Fila> Listar(WhereBuilder filtro)
      {
         #region QueryBuilder

         QueryBuilder query = QueryBuilder.Create(this)
            .Field(Fila.METADADO.Id)
            .Field(Fila.METADADO.Nome)
            .Table(Fila.METADADO.tabelaNAME);

         query.Where = filtro;

         #endregion

         HandleCustomizedQuery(query);

         using (IDbConnection connection = base.CreateConnection())
         {
            IDbCommand cmd = base.CreateCommand(connection, query.ToString()); cmd.CommandTimeout = 600;
            query.SetParameters(cmd);

            List<Fila> result = base.MapReaderToEntitySet<Fila>(cmd);
            return result;
         }
      }
      #endregion

      #region Alterar
      public void Alterar(Fila obj)
      {
         #region UpdateBuilder

         UpdateBuilder update = UpdateBuilder.Create(this)
            .FieldValue(Fila.METADADO.Nome, obj.Nome)
            .Table(Fila.METADADO.tabelaNAME);

         update.Where
            .Add(Fila.METADADO.Id, Filter.Equal, obj.Id);

         #endregion

         using (IDbConnection connection = base.CreateConnection())
         {
            IDbCommand cmd = base.CreateCommand(connection, update.ToString()); cmd.CommandTimeout = 600;
            update.SetParameters(cmd);

            base.ExecuteNonQuery(cmd);
         }
      }
      #endregion

      #region Inserir
      public void Incluir(Fila obj)
      {
         #region InsertBuilder

         InsertBuilder insert = InsertBuilder.Create(this)
            .Table(Fila.METADADO.tabelaNAME)
            .FieldValue(Fila.METADADO.Nome, obj.Nome)
            .SetIdentityField(Fila.METADADO.Id);

         #endregion

         using (IDbConnection connection = base.CreateConnection())
         {
            IDbCommand cmd = base.CreateCommand(connection, insert.ToString()); cmd.CommandTimeout = 600;
            insert.SetParameters(cmd);

            obj.Id = base.ExecuteScalar<int?>(cmd);
         }
      }
      #endregion

      #region Obtem
      public Fila Obtem(int? Id)
      {
         #region QueryBuilder

         QueryBuilder query = QueryBuilder.Create(this)
            .Field(Fila.METADADO.Id)
            .Field(Fila.METADADO.Nome)
            .Table(Fila.METADADO.tabelaNAME);

         query.Where
            .Add(Fila.METADADO.Id, Filter.Equal, Id);

         HandleCustomizedQuery(query);

         #endregion

         using (IDbConnection connection = base.CreateConnection())
         {
            IDbCommand cmd = base.CreateCommand(connection, query.ToString()); cmd.CommandTimeout = 600;
            query.SetParameters(cmd);

            Fila result = base.MapReaderToEntity<Fila>(cmd);
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
         delete.Table(Fila.METADADO.tabelaNAME);
         delete.Where
            .Add(Fila.METADADO.Id, Filter.Equal, Id);

         #endregion

         using (IDbConnection connection = base.CreateConnection())
         {
            IDbCommand cmd = base.CreateCommand(connection, delete.ToString()); cmd.CommandTimeout = 600;
            delete.SetParameters(cmd);

            base.ExecuteNonQuery(cmd);
         }
      }
      #endregion

   }
}
