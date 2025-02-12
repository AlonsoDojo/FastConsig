
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
	public partial class TipoDocumentoData : DataBase
	{
		
		#region Listar
		public List<TipoDocumento> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(TipoDocumento.METADADO.Id)
				.Field(TipoDocumento.METADADO.Descricao)
				.Field(TipoDocumento.METADADO.Selecionavel)
				.Table(TipoDocumento.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				cmd.CommandTimeout = 600;
				query.SetParameters(cmd);

				List<TipoDocumento> result = base.MapReaderToEntitySet<TipoDocumento>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(TipoDocumento obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(TipoDocumento.METADADO.Descricao, obj.Descricao)
				.FieldValue(TipoDocumento.METADADO.Selecionavel, obj.Selecionavel)
				.Table(TipoDocumento.METADADO.tabelaNAME);

			update.Where
				.Add(TipoDocumento.METADADO.Id, Filter.Equal, obj.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, update.ToString());
				cmd.CommandTimeout = 600;
				update.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

		#region Inserir
		public void Incluir(TipoDocumento obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(TipoDocumento.METADADO.tabelaNAME)
				.FieldValue(TipoDocumento.METADADO.Descricao, obj.Descricao)
				.FieldValue(TipoDocumento.METADADO.Selecionavel, obj.Selecionavel)
				.SetIdentityField(TipoDocumento.METADADO.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, insert.ToString());
				cmd.CommandTimeout = 600;
				insert.SetParameters(cmd);

				obj.Id = base.ExecuteScalar<int?>(cmd);
			}
		}
		#endregion

		#region Obtem
		public TipoDocumento Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(TipoDocumento.METADADO.Id)
				.Field(TipoDocumento.METADADO.Descricao)
				.Field(TipoDocumento.METADADO.Selecionavel)
				.Table(TipoDocumento.METADADO.tabelaNAME);

			query.Where
				.Add(TipoDocumento.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				cmd.CommandTimeout = 600;
				query.SetParameters(cmd);

				TipoDocumento result = base.MapReaderToEntity<TipoDocumento>(cmd);
				return result;
			}
		}
		#endregion

		#region Excluir por FKs
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(TipoDocumento.METADADO.tabelaNAME);
			delete.Where
				.Add(TipoDocumento.METADADO.Id, Filter.Equal, Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, delete.ToString());
				cmd.CommandTimeout = 600;
				delete.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

	}
}
