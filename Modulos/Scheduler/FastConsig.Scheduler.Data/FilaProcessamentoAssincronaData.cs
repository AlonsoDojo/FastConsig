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
   public partial class FilaProcessamentoAssincronaData : DataBase
   {
      public FilaProcessamentoAssincronaData()
      {
         this.CustomizeQuery += new CustomizeQueryDelegate(Handle_CustomizeQuery);
      }

      void Handle_CustomizeQuery(QueryBuilder query)
      {

      }
      #region Listar
      public List<FilaProcessamentoAssincrona> Listar(WhereBuilder filtro)
      {
         #region QueryBuilder

         QueryBuilder query = QueryBuilder.Create(this)
            .Field(FilaProcessamentoAssincrona.METADADO.Id)
            .Field(FilaProcessamentoAssincrona.METADADO.Descricao)
            .Field(FilaProcessamentoAssincrona.METADADO.AguardandoProcessamento)
            .Field(FilaProcessamentoAssincrona.METADADO.Processando)
            .Field(FilaProcessamentoAssincrona.METADADO.Finalizado)
            .Field(FilaProcessamentoAssincrona.METADADO.ComErro)
            .Field(FilaProcessamentoAssincrona.METADADO.MaximoTentativas)
            .Field(FilaProcessamentoAssincrona.METADADO.TentativasUtilizadas)
            .Field(FilaProcessamentoAssincrona.METADADO.DataInicioAgendada)
            .Field(FilaProcessamentoAssincrona.METADADO.DataInicio)
            .Field(FilaProcessamentoAssincrona.METADADO.DataFinalizacao)
            .Field(FilaProcessamentoAssincrona.METADADO.DataUltimoErro)
            .Field(FilaProcessamentoAssincrona.METADADO.Chave)
            .Field(FilaProcessamentoAssincrona.METADADO.Sistema)
            .Field(FilaProcessamentoAssincrona.METADADO.Notificar)
            .Field(FilaProcessamentoAssincrona.METADADO.NotificarParametros)
            .Field(FilaProcessamentoAssincrona.METADADO.Fila)
            .Table(FilaProcessamentoAssincrona.METADADO.tabelaNAME);

         query.Where = filtro;

         #endregion

         HandleCustomizedQuery(query);

         using (IDbConnection connection = base.CreateConnection())
         {
            IDbCommand cmd = base.CreateCommand(connection, query.ToString());
            cmd.CommandTimeout = 600;
            query.SetParameters(cmd);

            List<FilaProcessamentoAssincrona> result = base.MapReaderToEntitySet<FilaProcessamentoAssincrona>(cmd);
            return result;
         }
      }
      #endregion

      #region Alterar
      public void Alterar(FilaProcessamentoAssincrona obj)
      {
         #region UpdateBuilder

         UpdateBuilder update = UpdateBuilder.Create(this)
            .FieldValue(FilaProcessamentoAssincrona.METADADO.Descricao, obj.Descricao)
            .FieldValue(FilaProcessamentoAssincrona.METADADO.AguardandoProcessamento, obj.AguardandoProcessamento)
            .FieldValue(FilaProcessamentoAssincrona.METADADO.Processando, obj.Processando)
            .FieldValue(FilaProcessamentoAssincrona.METADADO.Finalizado, obj.Finalizado)
            .FieldValue(FilaProcessamentoAssincrona.METADADO.ComErro, obj.ComErro)
            .FieldValue(FilaProcessamentoAssincrona.METADADO.MaximoTentativas, obj.MaximoTentativas)
            .FieldValue(FilaProcessamentoAssincrona.METADADO.TentativasUtilizadas, obj.TentativasUtilizadas)
            .FieldValue(FilaProcessamentoAssincrona.METADADO.DataInicioAgendada, obj.DataInicioAgendada)
            .FieldValue(FilaProcessamentoAssincrona.METADADO.DataInicio, obj.DataInicio)
            .FieldValue(FilaProcessamentoAssincrona.METADADO.DataFinalizacao, obj.DataFinalizacao)
            .FieldValue(FilaProcessamentoAssincrona.METADADO.DataUltimoErro, obj.DataUltimoErro)
            .FieldValue(FilaProcessamentoAssincrona.METADADO.Chave, obj.Chave)
            .FieldValue(FilaProcessamentoAssincrona.METADADO.Sistema, obj.Sistema)
            .FieldValue(FilaProcessamentoAssincrona.METADADO.Notificar, obj.Notificar)
            .FieldValue(FilaProcessamentoAssincrona.METADADO.NotificarParametros, obj.NotificarParametros)
            .FieldValue(FilaProcessamentoAssincrona.METADADO.Fila, obj.Fila)
            .Table(FilaProcessamentoAssincrona.METADADO.tabelaNAME);

         update.Where
            .Add(FilaProcessamentoAssincrona.METADADO.Id, Filter.Equal, obj.Id);

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
      public void Incluir(FilaProcessamentoAssincrona obj)
      {
         #region InsertBuilder

         InsertBuilder insert = InsertBuilder.Create(this)
            .Table(FilaProcessamentoAssincrona.METADADO.tabelaNAME)
            .FieldValue(FilaProcessamentoAssincrona.METADADO.Descricao, obj.Descricao)
            .FieldValue(FilaProcessamentoAssincrona.METADADO.AguardandoProcessamento, obj.AguardandoProcessamento)
            .FieldValue(FilaProcessamentoAssincrona.METADADO.Processando, obj.Processando)
            .FieldValue(FilaProcessamentoAssincrona.METADADO.Finalizado, obj.Finalizado)
            .FieldValue(FilaProcessamentoAssincrona.METADADO.ComErro, obj.ComErro)
            .FieldValue(FilaProcessamentoAssincrona.METADADO.MaximoTentativas, obj.MaximoTentativas)
            .FieldValue(FilaProcessamentoAssincrona.METADADO.TentativasUtilizadas, obj.TentativasUtilizadas)
            .FieldValue(FilaProcessamentoAssincrona.METADADO.DataInicioAgendada, obj.DataInicioAgendada)
            .FieldValue(FilaProcessamentoAssincrona.METADADO.DataInicio, obj.DataInicio)
            .FieldValue(FilaProcessamentoAssincrona.METADADO.DataFinalizacao, obj.DataFinalizacao)
            .FieldValue(FilaProcessamentoAssincrona.METADADO.DataUltimoErro, obj.DataUltimoErro)
            .FieldValue(FilaProcessamentoAssincrona.METADADO.Chave, obj.Chave)
            .FieldValue(FilaProcessamentoAssincrona.METADADO.Sistema, obj.Sistema)
            .FieldValue(FilaProcessamentoAssincrona.METADADO.Notificar, obj.Notificar)
            .FieldValue(FilaProcessamentoAssincrona.METADADO.NotificarParametros, obj.NotificarParametros)
            .FieldValue(FilaProcessamentoAssincrona.METADADO.Fila, obj.Fila)
            .SetIdentityField(FilaProcessamentoAssincrona.METADADO.Id);

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
      public FilaProcessamentoAssincrona Obtem(int? Id)
      {
         #region QueryBuilder

         QueryBuilder query = QueryBuilder.Create(this)
            .Field(FilaProcessamentoAssincrona.METADADO.Id)
            .Field(FilaProcessamentoAssincrona.METADADO.Descricao)
            .Field(FilaProcessamentoAssincrona.METADADO.AguardandoProcessamento)
            .Field(FilaProcessamentoAssincrona.METADADO.Processando)
            .Field(FilaProcessamentoAssincrona.METADADO.Finalizado)
            .Field(FilaProcessamentoAssincrona.METADADO.ComErro)
            .Field(FilaProcessamentoAssincrona.METADADO.MaximoTentativas)
            .Field(FilaProcessamentoAssincrona.METADADO.TentativasUtilizadas)
            .Field(FilaProcessamentoAssincrona.METADADO.DataInicioAgendada)
            .Field(FilaProcessamentoAssincrona.METADADO.DataInicio)
            .Field(FilaProcessamentoAssincrona.METADADO.DataFinalizacao)
            .Field(FilaProcessamentoAssincrona.METADADO.DataUltimoErro)
            .Field(FilaProcessamentoAssincrona.METADADO.Chave)
            .Field(FilaProcessamentoAssincrona.METADADO.Sistema)
            .Field(FilaProcessamentoAssincrona.METADADO.Notificar)
            .Field(FilaProcessamentoAssincrona.METADADO.NotificarParametros)
            .Field(FilaProcessamentoAssincrona.METADADO.Fila)
            .Table(FilaProcessamentoAssincrona.METADADO.tabelaNAME);

         query.Where
            .Add(FilaProcessamentoAssincrona.METADADO.Id, Filter.Equal, Id);

         HandleCustomizedQuery(query);

         #endregion

         using (IDbConnection connection = base.CreateConnection())
         {
            IDbCommand cmd = base.CreateCommand(connection, query.ToString());
            cmd.CommandTimeout = 600;
            query.SetParameters(cmd);

            FilaProcessamentoAssincrona result = base.MapReaderToEntity<FilaProcessamentoAssincrona>(cmd);
            return result;
         }
      }
      #endregion

      #region Excluir por FKs
      public void ExcluirPor_Fila(int? Fila)
      {
         #region DeleteBuilder

         DeleteBuilder delete = DeleteBuilder.Create(this);
         delete.Table(FilaProcessamentoAssincrona.METADADO.tabelaNAME);
         delete.Where
            .Add(FilaProcessamentoAssincrona.METADADO.Fila, Filter.Equal, Fila);

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
         delete.Table(FilaProcessamentoAssincrona.METADADO.tabelaNAME);
         delete.Where
            .Add(FilaProcessamentoAssincrona.METADADO.Id, Filter.Equal, Id);

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
