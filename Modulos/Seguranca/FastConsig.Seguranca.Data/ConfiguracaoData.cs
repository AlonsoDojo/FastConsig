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
   public partial class ConfiguracaoData : DataBase
   {

      #region Listar
      public List<Configuracao> Listar(WhereBuilder filtro)
      {
         #region QueryBuilder

         QueryBuilder query = QueryBuilder.Create(this)
            .Field(Configuracao.METADADO.Chave)
            .Field(Configuracao.METADADO.Conteudo)
            .Table(Configuracao.METADADO.tabelaNAME);

         query.Where = filtro;

         #endregion

         HandleCustomizedQuery(query);

         using (IDbConnection connection = base.CreateConnection())
         {
            IDbCommand cmd = base.CreateCommand(connection, query.ToString());
            cmd.CommandTimeout = 600;
            query.SetParameters(cmd);

            List<Configuracao> result = base.MapReaderToEntitySet<Configuracao>(cmd);
            return result;
         }
      }
      #endregion

      #region Alterar
      public void Alterar(Configuracao obj)
      {
         #region UpdateBuilder

         UpdateBuilder update = UpdateBuilder.Create(this)
            .FieldValue(Configuracao.METADADO.Conteudo, obj.Conteudo).Table(Configuracao.METADADO.tabelaNAME);

         update.Where
            .Add(Configuracao.METADADO.Chave, Filter.Equal, obj.Chave);

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
      public void Incluir(Configuracao obj)
      {
         #region InsertBuilder

         InsertBuilder insert = InsertBuilder.Create(this)
            .FieldValue(Configuracao.METADADO.Chave, obj.Chave)
            .Table(Configuracao.METADADO.tabelaNAME)
            .FieldValue(Configuracao.METADADO.Conteudo, obj.Conteudo);

         #endregion

         using (IDbConnection connection = base.CreateConnection())
         {
            IDbCommand cmd = base.CreateCommand(connection, insert.ToString()); cmd.CommandTimeout = 600;
            insert.SetParameters(cmd);

            base.ExecuteNonQuery(cmd);
         }
      }
      #endregion

      #region Obtem
      public Configuracao Obtem(string Chave)
      {
         #region QueryBuilder

         QueryBuilder query = QueryBuilder.Create(this)
            .Field(Configuracao.METADADO.Chave)
            .Field(Configuracao.METADADO.Conteudo)
            .Table(Configuracao.METADADO.tabelaNAME);

         query.Where
            .Add(Configuracao.METADADO.Chave, Filter.Equal, Chave);

         HandleCustomizedQuery(query);

         #endregion

         using (IDbConnection connection = base.CreateConnection())
         {
            IDbCommand cmd = base.CreateCommand(connection, query.ToString()); cmd.CommandTimeout = 600;
            query.SetParameters(cmd);

            Configuracao result = base.MapReaderToEntity<Configuracao>(cmd);
            return result;
         }
      }
      #endregion

      #region Excluir por FKs
      #endregion

      #region Excluir por PK
      public void Excluir(string Chave)
      {
         #region DeleteBuilder

         DeleteBuilder delete = DeleteBuilder.Create(this);
         delete.Table(Configuracao.METADADO.tabelaNAME);
         delete.Where
            .Add(Configuracao.METADADO.Chave, Filter.Equal, Chave);

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
