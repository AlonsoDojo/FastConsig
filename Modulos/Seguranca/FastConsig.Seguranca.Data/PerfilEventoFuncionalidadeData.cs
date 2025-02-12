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
   public partial class PerfilEventoFuncionalidadeData : DataBase
   {
      public PerfilEventoFuncionalidadeData()
      {
         this.CustomizeQuery += new CustomizeQueryDelegate(Handle_CustomizeQuery);
      }

      void Handle_CustomizeQuery(QueryBuilder query)
      {

      }

      #region Listar
      public List<PerfilEventoFuncionalidade> Listar(WhereBuilder filtro)
      {
         #region QueryBuilder

         QueryBuilder query = QueryBuilder.Create(this)
            .Field(PerfilEventoFuncionalidade.METADADO.Id)
            .Field(PerfilEventoFuncionalidade.METADADO.Habilitado)
            .Field(PerfilEventoFuncionalidade.METADADO.IdPerfil)
            .Field(PerfilEventoFuncionalidade.METADADO.IdEventoFuncionalidade)
            .Table(PerfilEventoFuncionalidade.METADADO.tabelaNAME);

         query.Where = filtro;

         #endregion

         HandleCustomizedQuery(query);

         using (IDbConnection connection = base.CreateConnection())
         {
            IDbCommand cmd = base.CreateCommand(connection, query.ToString());
            query.SetParameters(cmd);

            List<PerfilEventoFuncionalidade> result = base.MapReaderToEntitySet<PerfilEventoFuncionalidade>(cmd);
            return result;
         }
      }
      #endregion

      #region Alterar
      public void Alterar(PerfilEventoFuncionalidade obj)
      {
         #region UpdateBuilder

         UpdateBuilder update = UpdateBuilder.Create(this)
            .FieldValue(PerfilEventoFuncionalidade.METADADO.Habilitado, obj.Habilitado).FieldValue(PerfilEventoFuncionalidade.METADADO.IdPerfil, obj.IdPerfil).FieldValue(PerfilEventoFuncionalidade.METADADO.IdEventoFuncionalidade, obj.IdEventoFuncionalidade).Table(PerfilEventoFuncionalidade.METADADO.tabelaNAME);

         update.Where
            .Add(PerfilEventoFuncionalidade.METADADO.Id, Filter.Equal, obj.Id);

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
      public void Incluir(PerfilEventoFuncionalidade obj)
      {
         #region InsertBuilder

         InsertBuilder insert = InsertBuilder.Create(this)
            .Table(PerfilEventoFuncionalidade.METADADO.tabelaNAME)
            .FieldValue(PerfilEventoFuncionalidade.METADADO.Habilitado, obj.Habilitado)
            .FieldValue(PerfilEventoFuncionalidade.METADADO.IdPerfil, obj.IdPerfil)
            .FieldValue(PerfilEventoFuncionalidade.METADADO.IdEventoFuncionalidade, obj.IdEventoFuncionalidade)
            .SetIdentityField(PerfilEventoFuncionalidade.METADADO.Id);

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
      public PerfilEventoFuncionalidade Obtem(int? Id)
      {
         #region QueryBuilder

         QueryBuilder query = QueryBuilder.Create(this)
            .Field(PerfilEventoFuncionalidade.METADADO.Id)
            .Field(PerfilEventoFuncionalidade.METADADO.Habilitado)
            .Field(PerfilEventoFuncionalidade.METADADO.IdPerfil)
            .Field(PerfilEventoFuncionalidade.METADADO.IdEventoFuncionalidade)
            .Table(PerfilEventoFuncionalidade.METADADO.tabelaNAME);

         query.Where
            .Add(PerfilEventoFuncionalidade.METADADO.Id, Filter.Equal, Id);

         HandleCustomizedQuery(query);

         #endregion

         using (IDbConnection connection = base.CreateConnection())
         {
            IDbCommand cmd = base.CreateCommand(connection, query.ToString());
            query.SetParameters(cmd);

            PerfilEventoFuncionalidade result = base.MapReaderToEntity<PerfilEventoFuncionalidade>(cmd);
            return result;
         }
      }
      #endregion

      #region Excluir por FKs
      public void ExcluirPor_IdPerfil(int? IdPerfil)
      {
         #region DeleteBuilder

         DeleteBuilder delete = DeleteBuilder.Create(this);
         delete.Table(PerfilEventoFuncionalidade.METADADO.tabelaNAME);
         delete.Where
            .Add(PerfilEventoFuncionalidade.METADADO.IdPerfil, Filter.Equal, IdPerfil);

         #endregion

         using (IDbConnection connection = base.CreateConnection())
         {
            IDbCommand cmd = base.CreateCommand(connection, delete.ToString());
            delete.SetParameters(cmd);

            base.ExecuteNonQuery(cmd);
         }
      }
      public void ExcluirPor_IdEventoFuncionalidade(int? IdEventoFuncionalidade)
      {
         #region DeleteBuilder

         DeleteBuilder delete = DeleteBuilder.Create(this);
         delete.Table(PerfilEventoFuncionalidade.METADADO.tabelaNAME);
         delete.Where
            .Add(PerfilEventoFuncionalidade.METADADO.IdEventoFuncionalidade, Filter.Equal, IdEventoFuncionalidade);

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
         delete.Table(PerfilEventoFuncionalidade.METADADO.tabelaNAME);
         delete.Where
            .Add(PerfilEventoFuncionalidade.METADADO.Id, Filter.Equal, Id);

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
