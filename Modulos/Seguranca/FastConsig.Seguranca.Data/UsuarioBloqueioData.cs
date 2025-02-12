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
   public partial class UsuarioBloqueioData : DataBase
   {
      public UsuarioBloqueioData()
      {
         this.CustomizeQuery += new CustomizeQueryDelegate(Handle_CustomizeQuery);
      }

      void Handle_CustomizeQuery(QueryBuilder query)
      {

      }

      #region Listar
      public List<UsuarioBloqueio> Listar(WhereBuilder filtro)
      {
         #region QueryBuilder

         QueryBuilder query = QueryBuilder.Create(this)
            .Field(UsuarioBloqueio.METADADO.Id)
            .Field(UsuarioBloqueio.METADADO.CpfCnpj)
            .Field(UsuarioBloqueio.METADADO.MotivoBloqueio)
            .Field(UsuarioBloqueio.METADADO.DataBloqueio)
            .Field(UsuarioBloqueio.METADADO.MesAnoReferencia)
            .Field(UsuarioBloqueio.METADADO.DataInicioBloqueio)
            .Field(UsuarioBloqueio.METADADO.DataFimBloqueio)
            .Field(UsuarioBloqueio.METADADO.OrigemBloqueio)
            .Table(UsuarioBloqueio.METADADO.tabelaNAME);

         query.Where = filtro;

         #endregion

         HandleCustomizedQuery(query);

         using (IDbConnection connection = base.CreateConnection())
         {
            IDbCommand cmd = base.CreateCommand(connection, query.ToString());
            cmd.CommandTimeout = 600;
            query.SetParameters(cmd);

            List<UsuarioBloqueio> result = base.MapReaderToEntitySet<UsuarioBloqueio>(cmd);
            return result;
         }
      }
      #endregion

      #region Alterar
      public void Alterar(UsuarioBloqueio obj)
      {
         #region UpdateBuilder

         UpdateBuilder update = UpdateBuilder.Create(this)
            .FieldValue(UsuarioBloqueio.METADADO.CpfCnpj, obj.CpfCnpj)
            .FieldValue(UsuarioBloqueio.METADADO.MotivoBloqueio, obj.MotivoBloqueio)
            .FieldValue(UsuarioBloqueio.METADADO.DataBloqueio, obj.DataBloqueio)
            .FieldValue(UsuarioBloqueio.METADADO.MesAnoReferencia, obj.MesAnoReferencia)
            .FieldValue(UsuarioBloqueio.METADADO.DataInicioBloqueio, obj.DataInicioBloqueio)
            .FieldValue(UsuarioBloqueio.METADADO.DataFimBloqueio, obj.DataFimBloqueio)
            .FieldValue(UsuarioBloqueio.METADADO.OrigemBloqueio, obj.OrigemBloqueio)
            .Table(UsuarioBloqueio.METADADO.tabelaNAME);

         update.Where
            .Add(UsuarioBloqueio.METADADO.Id, Filter.Equal, obj.Id);

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
      public void Incluir(UsuarioBloqueio obj)
      {
         #region InsertBuilder

         InsertBuilder insert = InsertBuilder.Create(this)
            .Table(UsuarioBloqueio.METADADO.tabelaNAME)
            .FieldValue(UsuarioBloqueio.METADADO.CpfCnpj, obj.CpfCnpj)
            .FieldValue(UsuarioBloqueio.METADADO.MotivoBloqueio, obj.MotivoBloqueio)
            .FieldValue(UsuarioBloqueio.METADADO.DataBloqueio, obj.DataBloqueio)
            .FieldValue(UsuarioBloqueio.METADADO.MesAnoReferencia, obj.MesAnoReferencia)
            .FieldValue(UsuarioBloqueio.METADADO.DataInicioBloqueio, obj.DataInicioBloqueio)
            .FieldValue(UsuarioBloqueio.METADADO.DataFimBloqueio, obj.DataFimBloqueio)
            .FieldValue(UsuarioBloqueio.METADADO.OrigemBloqueio, obj.OrigemBloqueio)
            .SetIdentityField(UsuarioBloqueio.METADADO.Id);

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
      public UsuarioBloqueio Obtem(int? Id)
      {
         #region QueryBuilder

         QueryBuilder query = QueryBuilder.Create(this)
            .Field(UsuarioBloqueio.METADADO.Id)
            .Field(UsuarioBloqueio.METADADO.CpfCnpj)
            .Field(UsuarioBloqueio.METADADO.MotivoBloqueio)
            .Field(UsuarioBloqueio.METADADO.DataBloqueio)
            .Field(UsuarioBloqueio.METADADO.MesAnoReferencia)
            .Field(UsuarioBloqueio.METADADO.DataInicioBloqueio)
            .Field(UsuarioBloqueio.METADADO.DataFimBloqueio)
            .Field(UsuarioBloqueio.METADADO.OrigemBloqueio)
            .Table(UsuarioBloqueio.METADADO.tabelaNAME);

         query.Where
            .Add(UsuarioBloqueio.METADADO.Id, Filter.Equal, Id);

         HandleCustomizedQuery(query);

         #endregion

         using (IDbConnection connection = base.CreateConnection())
         {
            IDbCommand cmd = base.CreateCommand(connection, query.ToString());
            cmd.CommandTimeout = 600;
            query.SetParameters(cmd);

            UsuarioBloqueio result = base.MapReaderToEntity<UsuarioBloqueio>(cmd);
            return result;
         }
      }
      #endregion

      #region Excluir por FKs
      public void ExcluirPor_MotivoBloqueio(int? MotivoBloqueio)
      {
         #region DeleteBuilder

         DeleteBuilder delete = DeleteBuilder.Create(this);
         delete.Table(UsuarioBloqueio.METADADO.tabelaNAME);
         delete.Where
            .Add(UsuarioBloqueio.METADADO.MotivoBloqueio, Filter.Equal, MotivoBloqueio);

         #endregion

         using (IDbConnection connection = base.CreateConnection())
         {
            IDbCommand cmd = base.CreateCommand(connection, delete.ToString());
            cmd.CommandTimeout = 600;
            delete.SetParameters(cmd);

            base.ExecuteNonQuery(cmd);
         }
      }
      public void ExcluirPor_OrigemBloqueio(int? OrigemBloqueio)
      {
         #region DeleteBuilder

         DeleteBuilder delete = DeleteBuilder.Create(this);
         delete.Table(UsuarioBloqueio.METADADO.tabelaNAME);
         delete.Where
            .Add(UsuarioBloqueio.METADADO.OrigemBloqueio, Filter.Equal, OrigemBloqueio);

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
         delete.Table(UsuarioBloqueio.METADADO.tabelaNAME);
         delete.Where
            .Add(UsuarioBloqueio.METADADO.Id, Filter.Equal, Id);

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
