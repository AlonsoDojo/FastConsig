using FastConsig.Scheduler.Entity;
using Framework.Data;
using System.Collections.Generic;
using System.Data;

namespace FastConsig.Scheduler.Data
{
   public partial class PoliticaExecucaoTarefaData : DataBase
   {
      public PoliticaExecucaoTarefaData()
      {
         this.CustomizeQuery += new CustomizeQueryDelegate(Handle_CustomizeQuery);
      }

      void Handle_CustomizeQuery(QueryBuilder query)
      {
         //*************************************************************************
         //*** OBS: Nao esqueca de criar as propriedades na Entity customized!!! ***
         //*************************************************************************


      }
      #region Listar
      public List<PoliticaExecucaoTarefa> Listar(WhereBuilder filtro)
      {
         #region QueryBuilder

         QueryBuilder query = QueryBuilder.Create(this)
            .Field(PoliticaExecucaoTarefa.METADADO.Id)
            .Field(PoliticaExecucaoTarefa.METADADO.TipoTarefa)
            .Field(PoliticaExecucaoTarefa.METADADO.Politica)
            .Field(PoliticaExecucaoTarefa.METADADO.Peso)
            .Field(PoliticaExecucaoTarefa.METADADO.Validacao)
            .Field(PoliticaExecucaoTarefa.METADADO.Execucao)
            .Field(PoliticaExecucaoTarefa.METADADO.Erro)
            .Field(PoliticaExecucaoTarefa.METADADO.Exito)
            .Table(PoliticaExecucaoTarefa.METADADO.tabelaNAME);

         query.Where = filtro;

         #endregion

         HandleCustomizedQuery(query);

         using (IDbConnection connection = base.CreateConnection())
         {
            IDbCommand cmd = base.CreateCommand(connection, query.ToString()); cmd.CommandTimeout = 600;
            query.SetParameters(cmd);

            List<PoliticaExecucaoTarefa> result = base.MapReaderToEntitySet<PoliticaExecucaoTarefa>(cmd);
            return result;
         }
      }
      #endregion

      #region Alterar
      public void Alterar(PoliticaExecucaoTarefa obj)
      {
         #region UpdateBuilder

         UpdateBuilder update = UpdateBuilder.Create(this)
            .FieldValue(PoliticaExecucaoTarefa.METADADO.TipoTarefa, obj.TipoTarefa)
            .FieldValue(PoliticaExecucaoTarefa.METADADO.Politica, obj.Politica)
            .FieldValue(PoliticaExecucaoTarefa.METADADO.Peso, obj.Peso)
            .FieldValue(PoliticaExecucaoTarefa.METADADO.Validacao, obj.Validacao)
            .FieldValue(PoliticaExecucaoTarefa.METADADO.Execucao, obj.Execucao)
            .FieldValue(PoliticaExecucaoTarefa.METADADO.Erro, obj.Erro)
            .FieldValue(PoliticaExecucaoTarefa.METADADO.Exito, obj.Exito)
            .Table(PoliticaExecucaoTarefa.METADADO.tabelaNAME);

         update.Where
            .Add(PoliticaExecucaoTarefa.METADADO.Id, Filter.Equal, obj.Id);

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
      public void Incluir(PoliticaExecucaoTarefa obj)
      {
         #region InsertBuilder

         InsertBuilder insert = InsertBuilder.Create(this)
            .Table(PoliticaExecucaoTarefa.METADADO.tabelaNAME)
            .FieldValue(PoliticaExecucaoTarefa.METADADO.TipoTarefa, obj.TipoTarefa)
            .FieldValue(PoliticaExecucaoTarefa.METADADO.Politica, obj.Politica)
            .FieldValue(PoliticaExecucaoTarefa.METADADO.Peso, obj.Peso)
            .FieldValue(PoliticaExecucaoTarefa.METADADO.Validacao, obj.Validacao)
            .FieldValue(PoliticaExecucaoTarefa.METADADO.Execucao, obj.Execucao)
            .FieldValue(PoliticaExecucaoTarefa.METADADO.Erro, obj.Erro)
            .FieldValue(PoliticaExecucaoTarefa.METADADO.Exito, obj.Exito)
            .SetIdentityField(PoliticaExecucaoTarefa.METADADO.Id);

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
      public PoliticaExecucaoTarefa Obtem(int? Id)
      {
         #region QueryBuilder

         QueryBuilder query = QueryBuilder.Create(this)
            .Field(PoliticaExecucaoTarefa.METADADO.Id)
            .Field(PoliticaExecucaoTarefa.METADADO.TipoTarefa)
            .Field(PoliticaExecucaoTarefa.METADADO.Politica)
            .Field(PoliticaExecucaoTarefa.METADADO.Peso)
            .Field(PoliticaExecucaoTarefa.METADADO.Validacao)
            .Field(PoliticaExecucaoTarefa.METADADO.Execucao)
            .Field(PoliticaExecucaoTarefa.METADADO.Erro)
            .Field(PoliticaExecucaoTarefa.METADADO.Exito)
            .Table(PoliticaExecucaoTarefa.METADADO.tabelaNAME);

         query.Where
            .Add(PoliticaExecucaoTarefa.METADADO.Id, Filter.Equal, Id);

         HandleCustomizedQuery(query);

         #endregion

         using (IDbConnection connection = base.CreateConnection())
         {
            IDbCommand cmd = base.CreateCommand(connection, query.ToString()); cmd.CommandTimeout = 600;
            query.SetParameters(cmd);

            PoliticaExecucaoTarefa result = base.MapReaderToEntity<PoliticaExecucaoTarefa>(cmd);
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
         delete.Table(PoliticaExecucaoTarefa.METADADO.tabelaNAME);
         delete.Where
            .Add(PoliticaExecucaoTarefa.METADADO.Id, Filter.Equal, Id);

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
