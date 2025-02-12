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
   public partial class PerfilData : DataBase
   {
      public PerfilData()
      {
         this.CustomizeQuery += new CustomizeQueryDelegate(Handle_CustomizeQuery);
      }

      void Handle_CustomizeQuery(QueryBuilder query)
      {

      }

      #region Listar
      public List<Perfil> Listar(WhereBuilder filtro)
      {
         #region QueryBuilder

         QueryBuilder query = QueryBuilder.Create(this)
            .Field(Perfil.METADADO.Id)
            .Field(Perfil.METADADO.Nome)
            .Field(Perfil.METADADO.Habilitado)
            .Field(Perfil.METADADO.Externo)
            .Table(Perfil.METADADO.tabelaNAME);

         query.Where = filtro;

         #endregion

         HandleCustomizedQuery(query);

         using (IDbConnection connection = base.CreateConnection())
         {
            IDbCommand cmd = base.CreateCommand(connection, query.ToString());
            query.SetParameters(cmd);

            List<Perfil> result = base.MapReaderToEntitySet<Perfil>(cmd);
            return result;
         }
      }
      #endregion

      #region Alterar
      public void Alterar(Perfil obj)
      {
         #region UpdateBuilder

         UpdateBuilder update = UpdateBuilder.Create(this)
            .FieldValue(Perfil.METADADO.Nome, obj.Nome)
            .FieldValue(Perfil.METADADO.Habilitado, obj.Habilitado)
            .FieldValue(Perfil.METADADO.Externo, obj.Externo)
            .Table(Perfil.METADADO.tabelaNAME);

         update.Where
            .Add(Perfil.METADADO.Id, Filter.Equal, obj.Id);

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
      public void Incluir(Perfil obj)
      {
         #region InsertBuilder

         InsertBuilder insert = InsertBuilder.Create(this)
            .Table(Perfil.METADADO.tabelaNAME)
            .FieldValue(Perfil.METADADO.Nome, obj.Nome)
            .FieldValue(Perfil.METADADO.Habilitado, obj.Habilitado)
            .FieldValue(Perfil.METADADO.Externo, obj.Externo)
            .SetIdentityField(Perfil.METADADO.Id);

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
      public Perfil Obtem(int? Id)
      {
         #region QueryBuilder

         QueryBuilder query = QueryBuilder.Create(this)
            .Field(Perfil.METADADO.Id)
            .Field(Perfil.METADADO.Nome)
            .Field(Perfil.METADADO.Habilitado)
            .Field(Perfil.METADADO.Externo)
            .Table(Perfil.METADADO.tabelaNAME);

         query.Where
            .Add(Perfil.METADADO.Id, Filter.Equal, Id);

         HandleCustomizedQuery(query);

         #endregion

         using (IDbConnection connection = base.CreateConnection())
         {
            IDbCommand cmd = base.CreateCommand(connection, query.ToString());
            query.SetParameters(cmd);

            Perfil result = base.MapReaderToEntity<Perfil>(cmd);
            return result;
         }
      }
      #endregion

      #region Excluir por PK
      public void Excluir(int? Id)
      {
         #region DeleteBuilder

         DeleteBuilder delete = DeleteBuilder.Create(this);
         delete.Table(Perfil.METADADO.tabelaNAME);
         delete.Where
            .Add(Perfil.METADADO.Id, Filter.Equal, Id);

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
