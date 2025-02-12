using FastConsig.Seguranca.Entity;
using Framework.Data;
using System.Collections.Generic;
using System.Data;

namespace FastConsig.Seguranca.Data
{
   public partial class UsuarioData : DataBase
   {
      public UsuarioData()
      {
         this.CustomizeQuery += new CustomizeQueryDelegate(Handle_CustomizeQuery);
      }

      void Handle_CustomizeQuery(QueryBuilder query)
      {
         //*************************************************************************
         //*** OBS: Nao esqueca de criar as propriedades na Entity customized!!! ***
         //*************************************************************************
         query.Join(Usuario.METADADO.Dominio, Join.Left, Dominio.METADADO.Id)
              .Field(Dominio.METADADO.URL, "URLDominio")
              .Field(Dominio.METADADO.TipoAutenticacao, "TipoAutenticacao");

      }

      #region Listar
      public List<Usuario> Listar(WhereBuilder filtro)
      {
         #region QueryBuilder

         QueryBuilder query = QueryBuilder.Create(this)
            .Field(Usuario.METADADO.Id)
            .Field(Usuario.METADADO.Login)
            .Field(Usuario.METADADO.Nome)
            .Field(Usuario.METADADO.Bloqueado)
            .Field(Usuario.METADADO.Habilitado)
            .Field(Usuario.METADADO.Email)
            .Field(Usuario.METADADO.DataUltimoLogin)
            .Field(Usuario.METADADO.DataRegistro)
            .Field(Usuario.METADADO.UsuarioRegistro)
            .Field(Usuario.METADADO.Departamento)
            .Field(Usuario.METADADO.CpfCnpj)
            .Field(Usuario.METADADO.Promotora)
            .Field(Usuario.METADADO.PreferenciaUsuario)
            .Field(Usuario.METADADO.Senha)
            .Field(Usuario.METADADO.DataUltimaTrocaSenha)
            .Field(Usuario.METADADO.Celular)
            .Field(Usuario.METADADO.Dominio)
            .Field(Usuario.METADADO.RedeLojas)
            .Field(Usuario.METADADO.Loja)
            .Table(Usuario.METADADO.tabelaNAME);

         query.Where = filtro;

         #endregion

         HandleCustomizedQuery(query);

         using (IDbConnection connection = base.CreateConnection())
         {
            IDbCommand cmd = base.CreateCommand(connection, query.ToString());
            query.SetParameters(cmd);

            List<Usuario> result = base.MapReaderToEntitySet<Usuario>(cmd);
            return result;
         }
      }
      #endregion

      #region Listar
      public List<Usuario> ListarMonitor(WhereBuilder filtro)
      {
         #region QueryBuilder

         QueryBuilder query = QueryBuilder.Create(this)
            .Field(Usuario.METADADO.Id)
            .Field(Usuario.METADADO.Login)
            .Field(Usuario.METADADO.Nome)
            .Field(Usuario.METADADO.Bloqueado)
            .Field(Usuario.METADADO.Habilitado)
            .Field(Usuario.METADADO.Email)
            .Field(Usuario.METADADO.CpfCnpj)
            .Field(Usuario.METADADO.Promotora)
            .Field(Usuario.METADADO.Celular)
            .Field(Usuario.METADADO.Dominio)
            .Field(Usuario.METADADO.RedeLojas)
            .Field(Usuario.METADADO.Loja)
            .Table(Usuario.METADADO.tabelaNAME);

         query.Where = filtro;

         #endregion

         HandleCustomizedQuery(query);

         using (IDbConnection connection = base.CreateConnection())
         {
            IDbCommand cmd = base.CreateCommand(connection, query.ToString());
            query.SetParameters(cmd);

            List<Usuario> result = base.MapReaderToEntitySet<Usuario>(cmd);
            return result;
         }
      }
      #endregion

      #region Alterar
      public void Alterar(Usuario obj)
      {
         #region UpdateBuilder

         UpdateBuilder update = UpdateBuilder.Create(this)
            .FieldValue(Usuario.METADADO.Login, obj.Login)
            .FieldValue(Usuario.METADADO.Nome, obj.Nome)
            .FieldValue(Usuario.METADADO.Bloqueado, obj.Bloqueado)
            .FieldValue(Usuario.METADADO.Habilitado, obj.Habilitado)
            .FieldValue(Usuario.METADADO.Email, obj.Email)
            .FieldValue(Usuario.METADADO.DataUltimoLogin, obj.DataUltimoLogin)
            .FieldValue(Usuario.METADADO.DataRegistro, obj.DataRegistro)
            .FieldValue(Usuario.METADADO.UsuarioRegistro, obj.UsuarioRegistro)
            .FieldValue(Usuario.METADADO.Departamento, obj.Departamento)
            .FieldValue(Usuario.METADADO.CpfCnpj, obj.CpfCnpj)
            .FieldValue(Usuario.METADADO.Promotora, obj.Promotora)
            .FieldValue(Usuario.METADADO.PreferenciaUsuario, obj.PreferenciaUsuario)
            .FieldValue(Usuario.METADADO.Senha, obj.Senha)
            .FieldValue(Usuario.METADADO.DataUltimaTrocaSenha, obj.DataUltimaTrocaSenha)
            .FieldValue(Usuario.METADADO.Celular, obj.Celular)
            .FieldValue(Usuario.METADADO.Dominio, obj.Dominio)
            .FieldValue(Usuario.METADADO.RedeLojas, obj.RedeLojas)
            .FieldValue(Usuario.METADADO.Loja, obj.Loja)
            .Table(Usuario.METADADO.tabelaNAME);

         update.Where
            .Add(Usuario.METADADO.Id, Filter.Equal, obj.Id);

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
      public void Incluir(Usuario obj)
      {
         #region InsertBuilder

         InsertBuilder insert = InsertBuilder.Create(this)
            .FieldValue(Usuario.METADADO.Id, obj.Id)
            .Table(Usuario.METADADO.tabelaNAME)
            .FieldValue(Usuario.METADADO.Login, obj.Login)
            .FieldValue(Usuario.METADADO.Nome, obj.Nome)
            .FieldValue(Usuario.METADADO.Bloqueado, obj.Bloqueado)
            .FieldValue(Usuario.METADADO.Habilitado, obj.Habilitado)
            .FieldValue(Usuario.METADADO.Email, obj.Email)
            .FieldValue(Usuario.METADADO.DataUltimoLogin, obj.DataUltimoLogin)
            .FieldValue(Usuario.METADADO.DataRegistro, obj.DataRegistro)
            .FieldValue(Usuario.METADADO.Departamento, obj.Departamento)
            .FieldValue(Usuario.METADADO.CpfCnpj, obj.CpfCnpj)
            .FieldValue(Usuario.METADADO.Promotora, obj.Promotora)
            .FieldValue(Usuario.METADADO.PreferenciaUsuario, obj.PreferenciaUsuario)
            .FieldValue(Usuario.METADADO.Senha, obj.Senha)
            .FieldValue(Usuario.METADADO.DataUltimaTrocaSenha, obj.DataUltimaTrocaSenha)
            .FieldValue(Usuario.METADADO.Celular, obj.Celular)
            .FieldValue(Usuario.METADADO.Dominio, obj.Dominio)
            .FieldValue(Usuario.METADADO.RedeLojas, obj.RedeLojas)
            .FieldValue(Usuario.METADADO.Loja, obj.Loja)
            .FieldValue(Usuario.METADADO.UsuarioRegistro, obj.UsuarioRegistro);

         #endregion

         using (IDbConnection connection = base.CreateConnection())
         {
            IDbCommand cmd = base.CreateCommand(connection, insert.ToString());
            insert.SetParameters(cmd);

            base.ExecuteNonQuery(cmd);
         }
      }
      #endregion

      #region Obtem
      public Usuario Obtem(string Id)
      {
         #region QueryBuilder

         QueryBuilder query = QueryBuilder.Create(this)
            .Field(Usuario.METADADO.Id)
            .Field(Usuario.METADADO.Login)
            .Field(Usuario.METADADO.Nome)
            .Field(Usuario.METADADO.Bloqueado)
            .Field(Usuario.METADADO.Habilitado)
            .Field(Usuario.METADADO.Email)
            .Field(Usuario.METADADO.DataUltimoLogin)
            .Field(Usuario.METADADO.DataRegistro)
            .Field(Usuario.METADADO.UsuarioRegistro)
            .Field(Usuario.METADADO.Departamento)
            .Field(Usuario.METADADO.CpfCnpj)
            .Field(Usuario.METADADO.Promotora)
            .Field(Usuario.METADADO.PreferenciaUsuario)
            .Field(Usuario.METADADO.Senha)
            .Field(Usuario.METADADO.DataUltimaTrocaSenha)
            .Field(Usuario.METADADO.Celular)
            .Field(Usuario.METADADO.Dominio)
            .Field(Usuario.METADADO.RedeLojas)
            .Field(Usuario.METADADO.Loja)
            .Table(Usuario.METADADO.tabelaNAME);

         query.Where
            .Add(Usuario.METADADO.Id, Filter.Equal, Id);

         HandleCustomizedQuery(query);

         #endregion

         using (IDbConnection connection = base.CreateConnection())
         {
            IDbCommand cmd = base.CreateCommand(connection, query.ToString());
            query.SetParameters(cmd);

            Usuario result = base.MapReaderToEntity<Usuario>(cmd);
            return result;
         }
      }
      #endregion

      #region Excluir por FKs
      #endregion

      #region Excluir por PK
      public void Excluir(string Id)
      {
         #region DeleteBuilder

         DeleteBuilder delete = DeleteBuilder.Create(this);
         delete.Table(Usuario.METADADO.tabelaNAME);
         delete.Where
            .Add(Usuario.METADADO.Id, Filter.Equal, Id);

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
