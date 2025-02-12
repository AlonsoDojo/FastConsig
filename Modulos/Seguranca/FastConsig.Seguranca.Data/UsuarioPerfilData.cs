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
   public partial class UsuarioPerfilData : DataBase
   {
      public UsuarioPerfilData()
      {
         this.CustomizeQuery += new CustomizeQueryDelegate(Handle_CustomizeQuery);
      }

      void Handle_CustomizeQuery(QueryBuilder query)
      {

      }

      #region Listar
      public List<UsuarioPerfil> Listar(WhereBuilder filtro)
      {
         #region QueryBuilder

         QueryBuilder query = QueryBuilder.Create(this)
            .Field(UsuarioPerfil.METADADO.Id)
            .Field(UsuarioPerfil.METADADO.IdUsuario)
            .Field(UsuarioPerfil.METADADO.IdPerfil)
            .Table(UsuarioPerfil.METADADO.tabelaNAME);

         query.Where = filtro;

         #endregion

         HandleCustomizedQuery(query);

         using (IDbConnection connection = base.CreateConnection())
         {
            IDbCommand cmd = base.CreateCommand(connection, query.ToString());
            query.SetParameters(cmd);

            List<UsuarioPerfil> result = base.MapReaderToEntitySet<UsuarioPerfil>(cmd);
            return result;
         }
      }
      #endregion

      #region Alterar
      public void Alterar(UsuarioPerfil obj)
      {
         #region UpdateBuilder

         UpdateBuilder update = UpdateBuilder.Create(this)
            .FieldValue(UsuarioPerfil.METADADO.IdUsuario, obj.IdUsuario).FieldValue(UsuarioPerfil.METADADO.IdPerfil, obj.IdPerfil).Table(UsuarioPerfil.METADADO.tabelaNAME);

         update.Where
            .Add(UsuarioPerfil.METADADO.Id, Filter.Equal, obj.Id);

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
      public void Incluir(UsuarioPerfil obj)
      {
         #region InsertBuilder

         InsertBuilder insert = InsertBuilder.Create(this)
            .Table(UsuarioPerfil.METADADO.tabelaNAME)
            .FieldValue(UsuarioPerfil.METADADO.IdUsuario, obj.IdUsuario)
            .FieldValue(UsuarioPerfil.METADADO.IdPerfil, obj.IdPerfil)
            .SetIdentityField(UsuarioPerfil.METADADO.Id);

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
      public UsuarioPerfil Obtem(int? Id)
      {
         #region QueryBuilder

         QueryBuilder query = QueryBuilder.Create(this)
            .Field(UsuarioPerfil.METADADO.Id)
            .Field(UsuarioPerfil.METADADO.IdUsuario)
            .Field(UsuarioPerfil.METADADO.IdPerfil)
            .Table(UsuarioPerfil.METADADO.tabelaNAME);

         query.Where
            .Add(UsuarioPerfil.METADADO.Id, Filter.Equal, Id);

         HandleCustomizedQuery(query);

         #endregion

         using (IDbConnection connection = base.CreateConnection())
         {
            IDbCommand cmd = base.CreateCommand(connection, query.ToString());
            query.SetParameters(cmd);

            UsuarioPerfil result = base.MapReaderToEntity<UsuarioPerfil>(cmd);
            return result;
         }
      }
      #endregion

      #region Excluir por FKs
      public void ExcluirPor_IdUsuario(string IdUsuario)
      {
         #region DeleteBuilder

         DeleteBuilder delete = DeleteBuilder.Create(this);
         delete.Table(UsuarioPerfil.METADADO.tabelaNAME);
         delete.Where
            .Add(UsuarioPerfil.METADADO.IdUsuario, Filter.Equal, IdUsuario);

         #endregion

         using (IDbConnection connection = base.CreateConnection())
         {
            IDbCommand cmd = base.CreateCommand(connection, delete.ToString());
            delete.SetParameters(cmd);

            base.ExecuteNonQuery(cmd);
         }
      }
      public void ExcluirPor_IdPerfil(int? IdPerfil)
      {
         #region DeleteBuilder

         DeleteBuilder delete = DeleteBuilder.Create(this);
         delete.Table(UsuarioPerfil.METADADO.tabelaNAME);
         delete.Where
            .Add(UsuarioPerfil.METADADO.IdPerfil, Filter.Equal, IdPerfil);

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
         delete.Table(UsuarioPerfil.METADADO.tabelaNAME);
         delete.Where
            .Add(UsuarioPerfil.METADADO.Id, Filter.Equal, Id);

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
