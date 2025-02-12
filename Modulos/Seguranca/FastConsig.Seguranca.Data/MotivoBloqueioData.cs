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
   public partial class MotivoBloqueioData : DataBase
   {
      public MotivoBloqueioData()
      {
         this.CustomizeQuery += new CustomizeQueryDelegate(Handle_CustomizeQuery);
      }

      void Handle_CustomizeQuery(QueryBuilder query)
      {

      }

      #region Listar
      public List<MotivoBloqueio> Listar(WhereBuilder filtro)
      {
         #region QueryBuilder

         QueryBuilder query = QueryBuilder.Create(this)
            .Field(MotivoBloqueio.METADADO.Id)
            .Field(MotivoBloqueio.METADADO.Descricao)
            .Field(MotivoBloqueio.METADADO.Origem)
            .Table(MotivoBloqueio.METADADO.tabelaNAME);

         query.Where = filtro;

         #endregion

         HandleCustomizedQuery(query);

         using (IDbConnection connection = base.CreateConnection())
         {
            IDbCommand cmd = base.CreateCommand(connection, query.ToString());
            cmd.CommandTimeout = 600;
            query.SetParameters(cmd);

            List<MotivoBloqueio> result = base.MapReaderToEntitySet<MotivoBloqueio>(cmd);
            return result;
         }
      }
      #endregion

      #region Alterar
      public void Alterar(MotivoBloqueio obj)
      {
         #region UpdateBuilder

         UpdateBuilder update = UpdateBuilder.Create(this)
            .FieldValue(MotivoBloqueio.METADADO.Descricao, obj.Descricao)
            .FieldValue(MotivoBloqueio.METADADO.Origem, obj.Origem)
            .Table(MotivoBloqueio.METADADO.tabelaNAME);

         update.Where
            .Add(MotivoBloqueio.METADADO.Id, Filter.Equal, obj.Id);

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
      public void Incluir(MotivoBloqueio obj)
      {
         #region InsertBuilder

         InsertBuilder insert = InsertBuilder.Create(this)
            .Table(MotivoBloqueio.METADADO.tabelaNAME)
            .FieldValue(MotivoBloqueio.METADADO.Descricao, obj.Descricao)
            .FieldValue(MotivoBloqueio.METADADO.Origem, obj.Origem)
            .SetIdentityField(MotivoBloqueio.METADADO.Id);

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
      public MotivoBloqueio Obtem(int? Id)
      {
         #region QueryBuilder

         QueryBuilder query = QueryBuilder.Create(this)
            .Field(MotivoBloqueio.METADADO.Id)
            .Field(MotivoBloqueio.METADADO.Descricao)
            .Field(MotivoBloqueio.METADADO.Origem)
            .Table(MotivoBloqueio.METADADO.tabelaNAME);

         query.Where
            .Add(MotivoBloqueio.METADADO.Id, Filter.Equal, Id);

         HandleCustomizedQuery(query);

         #endregion

         using (IDbConnection connection = base.CreateConnection())
         {
            IDbCommand cmd = base.CreateCommand(connection, query.ToString());
            cmd.CommandTimeout = 600;
            query.SetParameters(cmd);

            MotivoBloqueio result = base.MapReaderToEntity<MotivoBloqueio>(cmd);
            return result;
         }
      }
      #endregion

      #region Excluir por FKs
      public void ExcluirPor_Origem(int? Origem)
      {
         #region DeleteBuilder

         DeleteBuilder delete = DeleteBuilder.Create(this);
         delete.Table(MotivoBloqueio.METADADO.tabelaNAME);
         delete.Where
            .Add(MotivoBloqueio.METADADO.Origem, Filter.Equal, Origem);

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

      #region Excluir por PK
      public void Excluir(int? Id)
      {
         #region DeleteBuilder

         DeleteBuilder delete = DeleteBuilder.Create(this);
         delete.Table(MotivoBloqueio.METADADO.tabelaNAME);
         delete.Where
            .Add(MotivoBloqueio.METADADO.Id, Filter.Equal, Id);

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
