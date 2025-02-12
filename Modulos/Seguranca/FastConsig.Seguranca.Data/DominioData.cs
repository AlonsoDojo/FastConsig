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
   public partial class DominioData : DataBase
   {
      public DominioData()
      {
         this.CustomizeQuery += new CustomizeQueryDelegate(Handle_CustomizeQuery);
      }

      void Handle_CustomizeQuery(QueryBuilder query)
      {
         query.Join(Dominio.METADADO.TipoAutenticacao, Join.Inner, TipoAutenticacao.METADADO.Id)
              .Field(TipoAutenticacao.METADADO.Descricao, "TipoAutenticacaoDescricao");
      }

      #region Listar
      public List<Dominio> Listar(WhereBuilder filtro)
      {
         #region QueryBuilder

         QueryBuilder query = QueryBuilder.Create(this)
            .Field(Dominio.METADADO.Id)
            .Field(Dominio.METADADO.URL)
            .Field(Dominio.METADADO.Descricao)
            .Field(Dominio.METADADO.TipoAutenticacao)
            .Field(Dominio.METADADO.Ativo)
            .Table(Dominio.METADADO.tabelaNAME);

         query.Where = filtro;

         #endregion

         HandleCustomizedQuery(query);

         using (IDbConnection connection = base.CreateConnection())
         {
            IDbCommand cmd = base.CreateCommand(connection, query.ToString());
            query.SetParameters(cmd);

            List<Dominio> result = base.MapReaderToEntitySet<Dominio>(cmd);
            return result;
         }
      }
      #endregion

      #region Alterar
      public void Alterar(Dominio obj)
      {
         #region UpdateBuilder

         UpdateBuilder update = UpdateBuilder.Create(this)
            .FieldValue(Dominio.METADADO.URL, obj.URL)
            .FieldValue(Dominio.METADADO.Descricao, obj.Descricao)
            .FieldValue(Dominio.METADADO.TipoAutenticacao, obj.TipoAutenticacao)
            .FieldValue(Dominio.METADADO.Ativo, obj.Ativo)
            .Table(Dominio.METADADO.tabelaNAME);

         update.Where
            .Add(Dominio.METADADO.Id, Filter.Equal, obj.Id);

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
      public void Incluir(Dominio obj)
      {
         #region InsertBuilder

         InsertBuilder insert = InsertBuilder.Create(this)
            .Table(Dominio.METADADO.tabelaNAME)
            .FieldValue(Dominio.METADADO.URL, obj.URL)
            .FieldValue(Dominio.METADADO.Descricao, obj.Descricao)
            .FieldValue(Dominio.METADADO.TipoAutenticacao, obj.TipoAutenticacao)
            .FieldValue(Dominio.METADADO.Ativo, obj.Ativo)
            .SetIdentityField(Dominio.METADADO.Id);

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
      public Dominio Obtem(int? Id)
      {
         #region QueryBuilder

         QueryBuilder query = QueryBuilder.Create(this)
            .Field(Dominio.METADADO.Id)
            .Field(Dominio.METADADO.URL)
            .Field(Dominio.METADADO.Descricao)
            .Field(Dominio.METADADO.TipoAutenticacao)
            .Field(Dominio.METADADO.Ativo)
            .Table(Dominio.METADADO.tabelaNAME);

         query.Where
            .Add(Dominio.METADADO.Id, Filter.Equal, Id);

         HandleCustomizedQuery(query);

         #endregion

         using (IDbConnection connection = base.CreateConnection())
         {
            IDbCommand cmd = base.CreateCommand(connection, query.ToString());
            query.SetParameters(cmd);

            Dominio result = base.MapReaderToEntity<Dominio>(cmd);
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
         delete.Table(Dominio.METADADO.tabelaNAME);
         delete.Where
            .Add(Dominio.METADADO.Id, Filter.Equal, Id);

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
