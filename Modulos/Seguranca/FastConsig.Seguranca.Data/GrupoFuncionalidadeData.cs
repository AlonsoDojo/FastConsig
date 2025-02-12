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
   public partial class GrupoFuncionalidadeData : DataBase
   {
      public GrupoFuncionalidadeData()
      {
         this.CustomizeQuery += new CustomizeQueryDelegate(Handle_CustomizeQuery);
      }

      void Handle_CustomizeQuery(QueryBuilder query)
      {

      }

      #region Listar
      public List<GrupoFuncionalidade> Listar(WhereBuilder filtro)
      {
         #region QueryBuilder

         QueryBuilder query = QueryBuilder.Create(this)
            .Field(GrupoFuncionalidade.METADADO.Id)
            .Field(GrupoFuncionalidade.METADADO.Nome)
            .Field(GrupoFuncionalidade.METADADO.Ordem)
            .Field(GrupoFuncionalidade.METADADO.Icone)
            .Field(GrupoFuncionalidade.METADADO.Habilitado)
            .Field(GrupoFuncionalidade.METADADO.SistemaId)
            .Table(GrupoFuncionalidade.METADADO.tabelaNAME)
            .OrderBy(GrupoFuncionalidade.METADADO.Ordem, true);

         query.Where = filtro;

         #endregion

         HandleCustomizedQuery(query);

         using (IDbConnection connection = base.CreateConnection())
         {
            IDbCommand cmd = base.CreateCommand(connection, query.ToString());
            query.SetParameters(cmd);

            List<GrupoFuncionalidade> result = base.MapReaderToEntitySet<GrupoFuncionalidade>(cmd);
            return result;
         }
      }
      #endregion

      #region Alterar
      public void Alterar(GrupoFuncionalidade obj)
      {
         #region UpdateBuilder

         UpdateBuilder update = UpdateBuilder.Create(this)
            .FieldValue(GrupoFuncionalidade.METADADO.Nome, obj.Nome).FieldValue(GrupoFuncionalidade.METADADO.Icone, obj.Icone).FieldValue(GrupoFuncionalidade.METADADO.Ordem, obj.Ordem).FieldValue(GrupoFuncionalidade.METADADO.Habilitado, obj.Habilitado).FieldValue(GrupoFuncionalidade.METADADO.SistemaId, obj.SistemaId).Table(GrupoFuncionalidade.METADADO.tabelaNAME);

         update.Where
            .Add(GrupoFuncionalidade.METADADO.Id, Filter.Equal, obj.Id);

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
      public void Incluir(GrupoFuncionalidade obj)
      {
         #region InsertBuilder

         InsertBuilder insert = InsertBuilder.Create(this)
            .Table(GrupoFuncionalidade.METADADO.tabelaNAME)
            .FieldValue(GrupoFuncionalidade.METADADO.Nome, obj.Nome)
            .FieldValue(GrupoFuncionalidade.METADADO.Icone, obj.Icone)
            .FieldValue(GrupoFuncionalidade.METADADO.Ordem, obj.Ordem)
            .FieldValue(GrupoFuncionalidade.METADADO.Habilitado, obj.Habilitado)
            .FieldValue(GrupoFuncionalidade.METADADO.SistemaId, obj.SistemaId)
            .SetIdentityField(GrupoFuncionalidade.METADADO.Id);

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
      public GrupoFuncionalidade Obtem(int? Id)
      {
         #region QueryBuilder

         QueryBuilder query = QueryBuilder.Create(this)
            .Field(GrupoFuncionalidade.METADADO.Id)
            .Field(GrupoFuncionalidade.METADADO.Nome)
            .Field(GrupoFuncionalidade.METADADO.Icone)
            .Field(GrupoFuncionalidade.METADADO.Ordem)
            .Field(GrupoFuncionalidade.METADADO.Habilitado)
            .Field(GrupoFuncionalidade.METADADO.SistemaId)
            .Table(GrupoFuncionalidade.METADADO.tabelaNAME);

         query.Where
            .Add(GrupoFuncionalidade.METADADO.Id, Filter.Equal, Id);

         HandleCustomizedQuery(query);

         #endregion

         using (IDbConnection connection = base.CreateConnection())
         {
            IDbCommand cmd = base.CreateCommand(connection, query.ToString());
            query.SetParameters(cmd);

            GrupoFuncionalidade result = base.MapReaderToEntity<GrupoFuncionalidade>(cmd);
            return result;
         }
      }
      #endregion

      #region Excluir por FKs
      public void ExcluirPor_SistemaId(string SistemaId)
      {
         #region DeleteBuilder

         DeleteBuilder delete = DeleteBuilder.Create(this);
         delete.Table(GrupoFuncionalidade.METADADO.tabelaNAME);
         delete.Where
            .Add(GrupoFuncionalidade.METADADO.SistemaId, Filter.Equal, SistemaId);

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
         delete.Table(GrupoFuncionalidade.METADADO.tabelaNAME);
         delete.Where
            .Add(GrupoFuncionalidade.METADADO.Id, Filter.Equal, Id);

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
