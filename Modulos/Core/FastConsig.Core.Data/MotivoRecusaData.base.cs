
#region Usings
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Framework;
using Framework.Data;
using FastConsig.Core.Entity;
#endregion

namespace FastConsig.Core.Data
{
	public partial class MotivoRecusaData : DataBase
	{
		
		#region Listar
		public List<MotivoRecusa> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(MotivoRecusa.METADADO.Id)
				.Field(MotivoRecusa.METADADO.Descricao)
				.Table(MotivoRecusa.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				List<MotivoRecusa> result = base.MapReaderToEntitySet<MotivoRecusa>(cmd);
				return result;
			}
		}
		#endregion

		#region Inserir
		public void Incluir(MotivoRecusa obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(MotivoRecusa.METADADO.tabelaNAME)
				.FieldValue(MotivoRecusa.METADADO.Descricao, obj.Descricao)
				.SetIdentityField(MotivoRecusa.METADADO.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, insert.ToString());
				insert.SetParameters(cmd);

				obj.Id = base.ExecuteScalar<int?>(cmd);
			}
		}
      #endregion

      #region Alterar
      public void Alterar(MotivoRecusa obj)
      {
         #region UpdateBuilder

         UpdateBuilder update = UpdateBuilder.Create(this)
            .FieldValue(MotivoRecusa.METADADO.Descricao, obj.Descricao)
            .Table(MotivoRecusa.METADADO.tabelaNAME);

         update.Where
            .Add(MotivoRecusa.METADADO.Id, Filter.Equal, obj.Id);

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

      #region Obtem
      public MotivoRecusa Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(MotivoRecusa.METADADO.Id)
				.Field(MotivoRecusa.METADADO.Descricao)
				.Table(MotivoRecusa.METADADO.tabelaNAME);

			query.Where
				.Add(MotivoRecusa.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				MotivoRecusa result = base.MapReaderToEntity<MotivoRecusa>(cmd);
				return result;
			}
		}
      #endregion

      #region Excluir por PK
      public void Excluir(int? Id)
      {
         #region DeleteBuilder

         DeleteBuilder delete = DeleteBuilder.Create(this);
         delete.Table(MotivoRecusa.METADADO.tabelaNAME);
         delete.Where
            .Add(MotivoRecusa.METADADO.Id, Filter.Equal, Id);

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
