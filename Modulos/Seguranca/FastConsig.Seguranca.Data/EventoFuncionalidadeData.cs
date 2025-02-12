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
   public partial class EventoFuncionalidadeData : DataBase
   {
      public EventoFuncionalidadeData()
      {
         this.CustomizeQuery += new CustomizeQueryDelegate(Handle_CustomizeQuery);
      }

      void Handle_CustomizeQuery(QueryBuilder query)
      {

      }

      #region Listar
      public List<EventoFuncionalidade> Listar(WhereBuilder filtro)
      {
         #region QueryBuilder

         QueryBuilder query = QueryBuilder.Create(this)
            .Field(EventoFuncionalidade.METADADO.Id)
            .Field(EventoFuncionalidade.METADADO.Nome)
            .Field(EventoFuncionalidade.METADADO.IdFuncionalidade)
            .Table(EventoFuncionalidade.METADADO.tabelaNAME);

         query.Where = filtro;

         #endregion

         HandleCustomizedQuery(query);

         using (IDbConnection connection = base.CreateConnection())
         {
            IDbCommand cmd = base.CreateCommand(connection, query.ToString());
            query.SetParameters(cmd);

            List<EventoFuncionalidade> result = base.MapReaderToEntitySet<EventoFuncionalidade>(cmd);
            return result;
         }
      }
      #endregion

      #region Alterar
      public void Alterar(EventoFuncionalidade obj)
      {
         #region UpdateBuilder

         UpdateBuilder update = UpdateBuilder.Create(this)
            .FieldValue(EventoFuncionalidade.METADADO.Nome, obj.Nome).FieldValue(EventoFuncionalidade.METADADO.IdFuncionalidade, obj.IdFuncionalidade).Table(EventoFuncionalidade.METADADO.tabelaNAME);

         update.Where
            .Add(EventoFuncionalidade.METADADO.Id, Filter.Equal, obj.Id);

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
      public void Incluir(EventoFuncionalidade obj)
      {
         #region InsertBuilder

         InsertBuilder insert = InsertBuilder.Create(this)
            .Table(EventoFuncionalidade.METADADO.tabelaNAME)
            .FieldValue(EventoFuncionalidade.METADADO.Nome, obj.Nome)
            .FieldValue(EventoFuncionalidade.METADADO.IdFuncionalidade, obj.IdFuncionalidade)
            .SetIdentityField(EventoFuncionalidade.METADADO.Id);

         #endregion

         using (IDbConnection connection = base.CreateConnection())
         {
            IDbCommand cmd = base.CreateCommand(connection, insert.ToString());
            insert.SetParameters(cmd);

            obj.Id = base.ExecuteScalar<int?>(cmd);
         }
      }
      #endregion

      #region Obtem
      public EventoFuncionalidade Obtem(int? Id)
      {
         #region QueryBuilder

         QueryBuilder query = QueryBuilder.Create(this)
            .Field(EventoFuncionalidade.METADADO.Id)
            .Field(EventoFuncionalidade.METADADO.Nome)
            .Field(EventoFuncionalidade.METADADO.IdFuncionalidade)
            .Table(EventoFuncionalidade.METADADO.tabelaNAME);

         query.Where
            .Add(EventoFuncionalidade.METADADO.Id, Filter.Equal, Id);

         HandleCustomizedQuery(query);

         #endregion

         using (IDbConnection connection = base.CreateConnection())
         {
            IDbCommand cmd = base.CreateCommand(connection, query.ToString());
            query.SetParameters(cmd);

            EventoFuncionalidade result = base.MapReaderToEntity<EventoFuncionalidade>(cmd);
            return result;
         }
      }
      #endregion

      #region Excluir por FKs
      public void ExcluirPor_IdFuncionalidade(int? IdFuncionalidade)
      {
         #region DeleteBuilder

         DeleteBuilder delete = DeleteBuilder.Create(this);
         delete.Table(EventoFuncionalidade.METADADO.tabelaNAME);
         delete.Where
            .Add(EventoFuncionalidade.METADADO.IdFuncionalidade, Filter.Equal, IdFuncionalidade);

         #endregion

         using (IDbConnection connection = base.CreateConnection())
         {
            IDbCommand cmd = base.CreateCommand(connection, delete.ToString());
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
         delete.Table(EventoFuncionalidade.METADADO.tabelaNAME);
         delete.Where
            .Add(EventoFuncionalidade.METADADO.Id, Filter.Equal, Id);

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
