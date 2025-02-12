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
   public partial class TipoAutenticacaoData : DataBase
   {
      public TipoAutenticacaoData()
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
      public List<TipoAutenticacao> Listar(WhereBuilder filtro)
      {
         #region QueryBuilder

         QueryBuilder query = QueryBuilder.Create(this)
            .Field(TipoAutenticacao.METADADO.Id)
            .Field(TipoAutenticacao.METADADO.Descricao)
            .Table(TipoAutenticacao.METADADO.tabelaNAME);

         query.Where = filtro;

         #endregion

         HandleCustomizedQuery(query);

         using (IDbConnection connection = base.CreateConnection())
         {
            IDbCommand cmd = base.CreateCommand(connection, query.ToString());
            query.SetParameters(cmd);

            List<TipoAutenticacao> result = base.MapReaderToEntitySet<TipoAutenticacao>(cmd);
            return result;
         }
      }
      #endregion

      #region Alterar
      public void Alterar(TipoAutenticacao obj)
      {
         #region UpdateBuilder

         UpdateBuilder update = UpdateBuilder.Create(this)
            .FieldValue(TipoAutenticacao.METADADO.Descricao, obj.Descricao)
            .Table(TipoAutenticacao.METADADO.tabelaNAME);

         update.Where
            .Add(TipoAutenticacao.METADADO.Id, Filter.Equal, obj.Id);

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
      public void Incluir(TipoAutenticacao obj)
      {
         #region InsertBuilder

         InsertBuilder insert = InsertBuilder.Create(this)
            .Table(TipoAutenticacao.METADADO.tabelaNAME)
            .FieldValue(TipoAutenticacao.METADADO.Descricao, obj.Descricao)
            .SetIdentityField(TipoAutenticacao.METADADO.Id);

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
      public TipoAutenticacao Obtem(int? Id)
      {
         #region QueryBuilder

         QueryBuilder query = QueryBuilder.Create(this)
            .Field(TipoAutenticacao.METADADO.Id)
            .Field(TipoAutenticacao.METADADO.Descricao)
            .Table(TipoAutenticacao.METADADO.tabelaNAME);

         query.Where
            .Add(TipoAutenticacao.METADADO.Id, Filter.Equal, Id);

         HandleCustomizedQuery(query);

         #endregion

         using (IDbConnection connection = base.CreateConnection())
         {
            IDbCommand cmd = base.CreateCommand(connection, query.ToString());
            query.SetParameters(cmd);

            TipoAutenticacao result = base.MapReaderToEntity<TipoAutenticacao>(cmd);
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
         delete.Table(TipoAutenticacao.METADADO.tabelaNAME);
         delete.Where
            .Add(TipoAutenticacao.METADADO.Id, Filter.Equal, Id);

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
