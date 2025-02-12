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
   public partial class FuncionalidadeData : DataBase
   {
      public FuncionalidadeData()
      {
         this.CustomizeQuery += new CustomizeQueryDelegate(Handle_CustomizeQuery);
      }

      void Handle_CustomizeQuery(QueryBuilder query)
      {
         //*************************************************************************
         //*** OBS: Nao esqueca de criar as propriedades na Entity customized!!! ***
         //*************************************************************************
         query.Join(Funcionalidade.METADADO.IdGrupoFuncionalidade, Join.Left, GrupoFuncionalidade.METADADO.Id)
              .Field(GrupoFuncionalidade.METADADO.Nome, "NomeGrupo");
      }

      #region Listar
      public List<Funcionalidade> Listar(WhereBuilder filtro)
      {
         #region QueryBuilder

         QueryBuilder query = QueryBuilder.Create(this)
            .Field(Funcionalidade.METADADO.Id)
            .Field(Funcionalidade.METADADO.IdGrupoFuncionalidade)
            .Field(Funcionalidade.METADADO.Nome)
            .Field(Funcionalidade.METADADO.Titulo)
            .Field(Funcionalidade.METADADO.Descricao)
            .Field(Funcionalidade.METADADO.Url)
            .Field(Funcionalidade.METADADO.Habilitado)
            .Field(Funcionalidade.METADADO.Sequencia)
                .Field(Funcionalidade.METADADO.Visivel)
                .Table(Funcionalidade.METADADO.tabelaNAME);

         query.Where = filtro;

         #endregion

         HandleCustomizedQuery(query);

         using (IDbConnection connection = base.CreateConnection())
         {
            IDbCommand cmd = base.CreateCommand(connection, query.ToString());
            query.SetParameters(cmd);

            List<Funcionalidade> result = base.MapReaderToEntitySet<Funcionalidade>(cmd);
            return result;
         }
      }
      #endregion

      #region Alterar
      public void Alterar(Funcionalidade obj)
      {
         #region UpdateBuilder

         UpdateBuilder update = UpdateBuilder.Create(this)
            .FieldValue(Funcionalidade.METADADO.IdGrupoFuncionalidade, obj.IdGrupoFuncionalidade)
                .FieldValue(Funcionalidade.METADADO.Nome, obj.Nome)
                .FieldValue(Funcionalidade.METADADO.Titulo, obj.Titulo)
                .FieldValue(Funcionalidade.METADADO.Descricao, obj.Descricao)
                .FieldValue(Funcionalidade.METADADO.Url, obj.Url)
                .FieldValue(Funcionalidade.METADADO.Habilitado, obj.Habilitado)
                .FieldValue(Funcionalidade.METADADO.Sequencia, obj.Sequencia)
                .FieldValue(Funcionalidade.METADADO.Visivel, obj.Visivel)
                .Table(Funcionalidade.METADADO.tabelaNAME);

         update.Where
            .Add(Funcionalidade.METADADO.Id, Filter.Equal, obj.Id);

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
      public void Incluir(Funcionalidade obj)
      {
         #region InsertBuilder

         InsertBuilder insert = InsertBuilder.Create(this)
            .Table(Funcionalidade.METADADO.tabelaNAME)
            .FieldValue(Funcionalidade.METADADO.IdGrupoFuncionalidade, obj.IdGrupoFuncionalidade)
            .FieldValue(Funcionalidade.METADADO.Nome, obj.Nome)
            .FieldValue(Funcionalidade.METADADO.Titulo, obj.Titulo)
            .FieldValue(Funcionalidade.METADADO.Descricao, obj.Descricao)
            .FieldValue(Funcionalidade.METADADO.Url, obj.Url)
            .FieldValue(Funcionalidade.METADADO.Habilitado, obj.Habilitado)
            .FieldValue(Funcionalidade.METADADO.Sequencia, obj.Sequencia)
                .FieldValue(Funcionalidade.METADADO.Visivel, obj.Visivel)
                .SetIdentityField(Funcionalidade.METADADO.Id);

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
      public Funcionalidade Obtem(int? Id)
      {
         #region QueryBuilder

         QueryBuilder query = QueryBuilder.Create(this)
            .Field(Funcionalidade.METADADO.Id)
            .Field(Funcionalidade.METADADO.IdGrupoFuncionalidade)
            .Field(Funcionalidade.METADADO.Nome)
            .Field(Funcionalidade.METADADO.Titulo)
            .Field(Funcionalidade.METADADO.Descricao)
            .Field(Funcionalidade.METADADO.Url)
            .Field(Funcionalidade.METADADO.Habilitado)
            .Field(Funcionalidade.METADADO.Sequencia)
                .Field(Funcionalidade.METADADO.Visivel)
            .Table(Funcionalidade.METADADO.tabelaNAME);

         query.Where
            .Add(Funcionalidade.METADADO.Id, Filter.Equal, Id);

         HandleCustomizedQuery(query);

         #endregion

         using (IDbConnection connection = base.CreateConnection())
         {
            IDbCommand cmd = base.CreateCommand(connection, query.ToString());
            query.SetParameters(cmd);

            Funcionalidade result = base.MapReaderToEntity<Funcionalidade>(cmd);
            return result;
         }
      }
      #endregion

      #region Excluir por FKs
      public void ExcluirPor_IdGrupoFuncionalidade(int? IdGrupoFuncionalidade)
      {
         #region DeleteBuilder

         DeleteBuilder delete = DeleteBuilder.Create(this);
         delete.Table(Funcionalidade.METADADO.tabelaNAME);
         delete.Where
            .Add(Funcionalidade.METADADO.IdGrupoFuncionalidade, Filter.Equal, IdGrupoFuncionalidade);

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
         delete.Table(Funcionalidade.METADADO.tabelaNAME);
         delete.Where
            .Add(Funcionalidade.METADADO.Id, Filter.Equal, Id);

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
