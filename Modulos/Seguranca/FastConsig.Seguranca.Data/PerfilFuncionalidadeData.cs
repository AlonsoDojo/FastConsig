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
   public partial class PerfilFuncionalidadeData : DataBase
   {
      public PerfilFuncionalidadeData()
      {
         this.CustomizeQuery += new CustomizeQueryDelegate(Handle_CustomizeQuery);
      }

      void Handle_CustomizeQuery(QueryBuilder query)
      {

      }

      #region Listar
      public List<PerfilFuncionalidade> Listar(WhereBuilder filtro)
      {
         #region QueryBuilder

         QueryBuilder query = QueryBuilder.Create(this)
            .Field(PerfilFuncionalidade.METADADO.Id)
            .Field(PerfilFuncionalidade.METADADO.IdPerfil)
            .Field(PerfilFuncionalidade.METADADO.IdFuncionalidade)
            .Table(PerfilFuncionalidade.METADADO.tabelaNAME);

         query.Where = filtro;

         #endregion

         HandleCustomizedQuery(query);

         using (IDbConnection connection = base.CreateConnection())
         {
            IDbCommand cmd = base.CreateCommand(connection, query.ToString());
            query.SetParameters(cmd);

            List<PerfilFuncionalidade> result = base.MapReaderToEntitySet<PerfilFuncionalidade>(cmd);
            return result;
         }
      }
      #endregion

      #region Alterar
      public void Alterar(PerfilFuncionalidade obj)
      {
         #region UpdateBuilder

         UpdateBuilder update = UpdateBuilder.Create(this)
            .FieldValue(PerfilFuncionalidade.METADADO.IdPerfil, obj.IdPerfil).FieldValue(PerfilFuncionalidade.METADADO.IdFuncionalidade, obj.IdFuncionalidade).Table(PerfilFuncionalidade.METADADO.tabelaNAME);

         update.Where
            .Add(PerfilFuncionalidade.METADADO.Id, Filter.Equal, obj.Id);

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
      public void Incluir(PerfilFuncionalidade obj)
      {
         #region InsertBuilder

         InsertBuilder insert = InsertBuilder.Create(this)
            .Table(PerfilFuncionalidade.METADADO.tabelaNAME)
            .FieldValue(PerfilFuncionalidade.METADADO.IdPerfil, obj.IdPerfil)
            .FieldValue(PerfilFuncionalidade.METADADO.IdFuncionalidade, obj.IdFuncionalidade)
            .SetIdentityField(PerfilFuncionalidade.METADADO.Id);

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
      public PerfilFuncionalidade Obtem(int? Id)
      {
         #region QueryBuilder

         QueryBuilder query = QueryBuilder.Create(this)
            .Field(PerfilFuncionalidade.METADADO.Id)
            .Field(PerfilFuncionalidade.METADADO.IdPerfil)
            .Field(PerfilFuncionalidade.METADADO.IdFuncionalidade)
            .Table(PerfilFuncionalidade.METADADO.tabelaNAME);

         query.Where
            .Add(PerfilFuncionalidade.METADADO.Id, Filter.Equal, Id);

         HandleCustomizedQuery(query);

         #endregion

         using (IDbConnection connection = base.CreateConnection())
         {
            IDbCommand cmd = base.CreateCommand(connection, query.ToString());
            query.SetParameters(cmd);

            PerfilFuncionalidade result = base.MapReaderToEntity<PerfilFuncionalidade>(cmd);
            return result;
         }
      }
      #endregion

      #region Excluir por FKs
      public void ExcluirPor_IdPerfil(int? IdPerfil)
      {
         #region DeleteBuilder

         DeleteBuilder delete = DeleteBuilder.Create(this);
         delete.Table(PerfilFuncionalidade.METADADO.tabelaNAME);
         delete.Where
            .Add(PerfilFuncionalidade.METADADO.IdPerfil, Filter.Equal, IdPerfil);

         #endregion

         using (IDbConnection connection = base.CreateConnection())
         {
            IDbCommand cmd = base.CreateCommand(connection, delete.ToString());
            delete.SetParameters(cmd);

            base.ExecuteNonQuery(cmd);
         }
      }
      public void ExcluirPor_IdFuncionalidade(int? IdFuncionalidade)
      {
         #region DeleteBuilder

         DeleteBuilder delete = DeleteBuilder.Create(this);
         delete.Table(PerfilFuncionalidade.METADADO.tabelaNAME);
         delete.Where
            .Add(PerfilFuncionalidade.METADADO.IdFuncionalidade, Filter.Equal, IdFuncionalidade);

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
         delete.Table(PerfilFuncionalidade.METADADO.tabelaNAME);
         delete.Where
            .Add(PerfilFuncionalidade.METADADO.Id, Filter.Equal, Id);

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
