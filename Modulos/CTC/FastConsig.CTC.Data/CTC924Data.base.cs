
#region Usings
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Framework;
using Framework.Data;
using FastConsig.CTC.Entity;
#endregion

namespace FastConsig.CTC.Data
{
	public partial class CTC924Data : DataBase
	{
		
		#region Listar
		public List<CTC924> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CTC924.METADADO.Id)
				.Field(CTC924.METADADO.Arquivo)
				.Field(CTC924.METADADO.DataReferencia)
				.Field(CTC924.METADADO.PeriodoInicial)
				.Field(CTC924.METADADO.PeriodoFinal)
				.Table(CTC924.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				List<CTC924> result = base.MapReaderToEntitySet<CTC924>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(CTC924 obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(CTC924.METADADO.Arquivo, obj.Arquivo)
				.FieldValue(CTC924.METADADO.DataReferencia, obj.DataReferencia)
				.FieldValue(CTC924.METADADO.PeriodoInicial, obj.PeriodoInicial)
				.FieldValue(CTC924.METADADO.PeriodoFinal, obj.PeriodoFinal)
				.Table(CTC924.METADADO.tabelaNAME);

			update.Where
				.Add(CTC924.METADADO.Id, Filter.Equal, obj.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, update.ToString());
				update.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

		#region Inserir
		public void Incluir(CTC924 obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(CTC924.METADADO.tabelaNAME)
				.FieldValue(CTC924.METADADO.Arquivo, obj.Arquivo)
				.FieldValue(CTC924.METADADO.DataReferencia, obj.DataReferencia)
				.FieldValue(CTC924.METADADO.PeriodoInicial, obj.PeriodoInicial)
				.FieldValue(CTC924.METADADO.PeriodoFinal, obj.PeriodoFinal)
				.SetIdentityField(CTC924.METADADO.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, insert.ToString());
				insert.SetParameters(cmd);

				obj.Id = base.ExecuteScalar<int?>(cmd);
			}
		}
		#endregion

		#region Obtem
		public CTC924 Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CTC924.METADADO.Id)
				.Field(CTC924.METADADO.Arquivo)
				.Field(CTC924.METADADO.DataReferencia)
				.Field(CTC924.METADADO.PeriodoInicial)
				.Field(CTC924.METADADO.PeriodoFinal)
				.Table(CTC924.METADADO.tabelaNAME);

			query.Where
				.Add(CTC924.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				CTC924 result = base.MapReaderToEntity<CTC924>(cmd);
				return result;
			}
		}
		#endregion

		#region Excluir por FKs
		public void ExcluirPor_Arquivo(int? Arquivo)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(CTC924.METADADO.tabelaNAME);
			delete.Where
				.Add(CTC924.METADADO.Arquivo, Filter.Equal, Arquivo);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
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
				delete.Table(CTC924.METADADO.tabelaNAME);
			delete.Where
				.Add(CTC924.METADADO.Id, Filter.Equal, Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, delete.ToString());
				delete.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

	}
}
