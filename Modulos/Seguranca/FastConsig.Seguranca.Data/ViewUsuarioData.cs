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
   public partial class ViewUsuarioData : DataBase
   {
      public ViewUsuarioData()
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
      public List<ViewUsuario> Listar(WhereBuilder filtro)
      {
         #region QueryBuilder

         QueryBuilder query = QueryBuilder.Create(this)
            .Field(ViewUsuario.METADADO.Id)
            .Field(ViewUsuario.METADADO.Login)
            .Field(ViewUsuario.METADADO.Nome)
            .Field(ViewUsuario.METADADO.Bloqueado)
            .Field(ViewUsuario.METADADO.Habilitado)
            .Field(ViewUsuario.METADADO.Email)
            .Field(ViewUsuario.METADADO.DataUltimoLogin)
            .Field(ViewUsuario.METADADO.DataRegistro)
            .Field(ViewUsuario.METADADO.UsuarioRegistro)
            .Field(ViewUsuario.METADADO.Departamento)
            .Field(ViewUsuario.METADADO.cpfcnpj)
            .Field(ViewUsuario.METADADO.Promotora)
            .Field(ViewUsuario.METADADO.Senha)
            .Field(ViewUsuario.METADADO.DataUltimaTrocaSenha)
            .Field(ViewUsuario.METADADO.Celular)
            .Field(ViewUsuario.METADADO.Dominio)
            .Field(ViewUsuario.METADADO.PreferenciaUsuario)
            .Field(ViewUsuario.METADADO.RedeLojas)
            .Field(ViewUsuario.METADADO.Loja)
            .Table(ViewUsuario.METADADO.tabelaNAME);

         query.Where = filtro;

         #endregion

         HandleCustomizedQuery(query);

         using (IDbConnection connection = base.CreateConnection())
         {
            IDbCommand cmd = base.CreateCommand(connection, query.ToString());
            cmd.CommandTimeout = 600;
            query.SetParameters(cmd);

            List<ViewUsuario> result = base.MapReaderToEntitySet<ViewUsuario>(cmd);
            return result;
         }
      }
      #endregion

      #region Obtem
      public ViewUsuario Obtem(string Id)
      {
         #region QueryBuilder

         QueryBuilder query = QueryBuilder.Create(this)
            .Field(ViewUsuario.METADADO.Id)
            .Field(ViewUsuario.METADADO.Login)
            .Field(ViewUsuario.METADADO.Nome)
            .Field(ViewUsuario.METADADO.Bloqueado)
            .Field(ViewUsuario.METADADO.Habilitado)
            .Field(ViewUsuario.METADADO.Email)
            .Field(ViewUsuario.METADADO.DataUltimoLogin)
            .Field(ViewUsuario.METADADO.DataRegistro)
            .Field(ViewUsuario.METADADO.UsuarioRegistro)
            .Field(ViewUsuario.METADADO.Departamento)
            .Field(ViewUsuario.METADADO.cpfcnpj)
            .Field(ViewUsuario.METADADO.Promotora)
            .Field(ViewUsuario.METADADO.Senha)
            .Field(ViewUsuario.METADADO.DataUltimaTrocaSenha)
            .Field(ViewUsuario.METADADO.Celular)
            .Field(ViewUsuario.METADADO.Dominio)
            .Field(ViewUsuario.METADADO.PreferenciaUsuario)
            .Field(ViewUsuario.METADADO.RedeLojas)
            .Field(ViewUsuario.METADADO.Loja)
            .Table(ViewUsuario.METADADO.tabelaNAME);

         query.Where
            .Add(ViewUsuario.METADADO.Id, Filter.Equal, Id);

         HandleCustomizedQuery(query);

         #endregion

         using (IDbConnection connection = base.CreateConnection())
         {
            IDbCommand cmd = base.CreateCommand(connection, query.ToString());
            cmd.CommandTimeout = 600;
            query.SetParameters(cmd);

            ViewUsuario result = base.MapReaderToEntity<ViewUsuario>(cmd);
            return result;
         }
      }
      #endregion

   }
}
