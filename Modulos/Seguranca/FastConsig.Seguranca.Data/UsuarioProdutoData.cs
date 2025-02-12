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
   public partial class UsuarioProdutoData : DataBase
   {
      public UsuarioProdutoData()
      {
         this.CustomizeQuery += new CustomizeQueryDelegate(Handle_CustomizeQuery);
      }

      void Handle_CustomizeQuery(QueryBuilder query)
      {

      }

      #region Listar
      public List<UsuarioProduto> Listar(WhereBuilder filtro)
      {
         #region QueryBuilder

         QueryBuilder query = QueryBuilder.Create(this)
            .Field(UsuarioProduto.METADADO.Id)
            .Field(UsuarioProduto.METADADO.Usuario)
            .Field(UsuarioProduto.METADADO.Produto)
            .Table(UsuarioProduto.METADADO.tabelaNAME);

         query.Where = filtro;

         #endregion

         HandleCustomizedQuery(query);

         using (IDbConnection connection = base.CreateConnection())
         {
            IDbCommand cmd = base.CreateCommand(connection, query.ToString());
            query.SetParameters(cmd);

            List<UsuarioProduto> result = base.MapReaderToEntitySet<UsuarioProduto>(cmd);
            return result;
         }
      }
      #endregion

      #region Alterar
      public void Alterar(UsuarioProduto obj)
      {
         #region UpdateBuilder

         UpdateBuilder update = UpdateBuilder.Create(this)
            .FieldValue(UsuarioProduto.METADADO.Usuario, obj.Usuario)
            .FieldValue(UsuarioProduto.METADADO.Produto, obj.Produto)
            .Table(UsuarioProduto.METADADO.tabelaNAME);

         update.Where
            .Add(UsuarioProduto.METADADO.Id, Filter.Equal, obj.Id);

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
      public void Incluir(UsuarioProduto obj)
      {
         #region InsertBuilder

         InsertBuilder insert = InsertBuilder.Create(this)
            .Table(UsuarioProduto.METADADO.tabelaNAME)
            .FieldValue(UsuarioProduto.METADADO.Usuario, obj.Usuario)
            .FieldValue(UsuarioProduto.METADADO.Produto, obj.Produto)
            .SetIdentityField(UsuarioProduto.METADADO.Id);

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
      public UsuarioProduto Obtem(int? Id)
      {
         #region QueryBuilder

         QueryBuilder query = QueryBuilder.Create(this)
            .Field(UsuarioProduto.METADADO.Id)
            .Field(UsuarioProduto.METADADO.Usuario)
            .Field(UsuarioProduto.METADADO.Produto)
            .Table(UsuarioProduto.METADADO.tabelaNAME);

         query.Where
            .Add(UsuarioProduto.METADADO.Id, Filter.Equal, Id);

         HandleCustomizedQuery(query);

         #endregion

         using (IDbConnection connection = base.CreateConnection())
         {
            IDbCommand cmd = base.CreateCommand(connection, query.ToString());
            query.SetParameters(cmd);

            UsuarioProduto result = base.MapReaderToEntity<UsuarioProduto>(cmd);
            return result;
         }
      }
      #endregion

      #region Excluir por FKs
      public void ExcluirPor_Usuario(string Usuario)
      {
         #region DeleteBuilder

         DeleteBuilder delete = DeleteBuilder.Create(this);
         delete.Table(UsuarioProduto.METADADO.tabelaNAME);
         delete.Where
            .Add(UsuarioProduto.METADADO.Usuario, Filter.Equal, Usuario);

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
         delete.Table(UsuarioProduto.METADADO.tabelaNAME);
         delete.Where
            .Add(UsuarioProduto.METADADO.Id, Filter.Equal, Id);

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
