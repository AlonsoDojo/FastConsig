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
   public partial class TarefasData : DataBase
   {

      #region Listar
      public List<Tarefa> Listar(WhereBuilder filtro)
      {
         #region QueryBuilder

         QueryBuilder query = QueryBuilder.Create(this)
            .Field(Tarefa.METADADO.Id)
            .Field(Tarefa.METADADO.TipoTarefa)
            .Field(Tarefa.METADADO.TipoAgenda)
            .Field(Tarefa.METADADO.Fila)
            .Field(Tarefa.METADADO.Agenda)
            .Field(Tarefa.METADADO.Assembly)
            .Field(Tarefa.METADADO.ClassName)
            .Field(Tarefa.METADADO.Nome)
            .Field(Tarefa.METADADO.Parametros)
            .Field(Tarefa.METADADO.Ativo)
            .Table(Tarefa.METADADO.tabelaNAME);

         query.Where = filtro;

         #endregion

         HandleCustomizedQuery(query);

         using (IDbConnection connection = base.CreateConnection())
         {
            IDbCommand cmd = base.CreateCommand(connection, query.ToString()); cmd.CommandTimeout = 600;
            query.SetParameters(cmd);

            List<Tarefa> result = base.MapReaderToEntitySet<Tarefa>(cmd);
            return result;
         }
      }
      #endregion

      #region Alterar
      public void Alterar(Tarefa obj)
      {
         #region UpdateBuilder

         UpdateBuilder update = UpdateBuilder.Create(this)
            .FieldValue(Tarefa.METADADO.TipoTarefa, obj.TipoTarefa)
            .FieldValue(Tarefa.METADADO.TipoAgenda, obj.TipoAgenda)
            .FieldValue(Tarefa.METADADO.Fila, obj.Fila)
            .FieldValue(Tarefa.METADADO.Agenda, obj.Agenda)
            .FieldValue(Tarefa.METADADO.Assembly, obj.Assembly)
            .FieldValue(Tarefa.METADADO.ClassName, obj.ClassName)
            .FieldValue(Tarefa.METADADO.Nome, obj.Nome)
            .FieldValue(Tarefa.METADADO.Parametros, obj.Parametros)
            .FieldValue(Tarefa.METADADO.Ativo, obj.Ativo)
            .Table(Tarefa.METADADO.tabelaNAME);

         update.Where
            .Add(Tarefa.METADADO.Id, Filter.Equal, obj.Id);

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
      public void Incluir(Tarefa obj)
      {
         #region InsertBuilder

         InsertBuilder insert = InsertBuilder.Create(this)
            .Table(Tarefa.METADADO.tabelaNAME)
            .FieldValue(Tarefa.METADADO.TipoTarefa, obj.TipoTarefa)
            .FieldValue(Tarefa.METADADO.TipoAgenda, obj.TipoAgenda)
            .FieldValue(Tarefa.METADADO.Fila, obj.Fila)
            .FieldValue(Tarefa.METADADO.Agenda, obj.Agenda)
            .FieldValue(Tarefa.METADADO.Assembly, obj.Assembly)
            .FieldValue(Tarefa.METADADO.ClassName, obj.ClassName)
            .FieldValue(Tarefa.METADADO.Nome, obj.Nome)
            .FieldValue(Tarefa.METADADO.Parametros, obj.Parametros)
            .FieldValue(Tarefa.METADADO.Ativo, obj.Ativo)
            .SetIdentityField(Tarefa.METADADO.Id);

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
      public Tarefa Obtem(int? Id)
      {
         #region QueryBuilder

         QueryBuilder query = QueryBuilder.Create(this)
            .Field(Tarefa.METADADO.Id)
            .Field(Tarefa.METADADO.TipoTarefa)
            .Field(Tarefa.METADADO.TipoAgenda)
            .Field(Tarefa.METADADO.Fila)
            .Field(Tarefa.METADADO.Agenda)
            .Field(Tarefa.METADADO.Assembly)
            .Field(Tarefa.METADADO.ClassName)
            .Field(Tarefa.METADADO.Nome)
            .Field(Tarefa.METADADO.Parametros)
            .Field(Tarefa.METADADO.Ativo)
            .Table(Tarefa.METADADO.tabelaNAME);

         query.Where
            .Add(Tarefa.METADADO.Id, Filter.Equal, Id);

         HandleCustomizedQuery(query);

         #endregion

         using (IDbConnection connection = base.CreateConnection())
         {
            IDbCommand cmd = base.CreateCommand(connection, query.ToString()); cmd.CommandTimeout = 600;
            query.SetParameters(cmd);

            Tarefa result = base.MapReaderToEntity<Tarefa>(cmd);
            return result;
         }
      }
      #endregion

      #region Excluir por FKs
      public void ExcluirPor_TipoTarefa(int? TipoTarefa)
      {
         #region DeleteBuilder

         DeleteBuilder delete = DeleteBuilder.Create(this);
         delete.Table(Tarefa.METADADO.tabelaNAME);
         delete.Where
            .Add(Tarefa.METADADO.TipoTarefa, Filter.Equal, TipoTarefa);

         #endregion

         using (IDbConnection connection = base.CreateConnection())
         {
            IDbCommand cmd = base.CreateCommand(connection, delete.ToString()); cmd.CommandTimeout = 600;
            delete.SetParameters(cmd);

            base.ExecuteNonQuery(cmd);
         }
      }
      public void ExcluirPor_TipoAgenda(int? TipoAgenda)
      {
         #region DeleteBuilder

         DeleteBuilder delete = DeleteBuilder.Create(this);
         delete.Table(Tarefa.METADADO.tabelaNAME);
         delete.Where
            .Add(Tarefa.METADADO.TipoAgenda, Filter.Equal, TipoAgenda);

         #endregion

         using (IDbConnection connection = base.CreateConnection())
         {
            IDbCommand cmd = base.CreateCommand(connection, delete.ToString()); cmd.CommandTimeout = 600;
            delete.SetParameters(cmd);

            base.ExecuteNonQuery(cmd);
         }
      }
      public void ExcluirPor_Fila(int? Fila)
      {
         #region DeleteBuilder

         DeleteBuilder delete = DeleteBuilder.Create(this);
         delete.Table(Tarefa.METADADO.tabelaNAME);
         delete.Where
            .Add(Tarefa.METADADO.Fila, Filter.Equal, Fila);

         #endregion

         using (IDbConnection connection = base.CreateConnection())
         {
            IDbCommand cmd = base.CreateCommand(connection, delete.ToString()); cmd.CommandTimeout = 600;
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
         delete.Table(Tarefa.METADADO.tabelaNAME);
         delete.Where
            .Add(Tarefa.METADADO.Id, Filter.Equal, Id);

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
