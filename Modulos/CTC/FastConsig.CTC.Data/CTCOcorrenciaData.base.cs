
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
	public partial class CTCOcorrenciaData : DataBase
	{
		
		#region Listar
		public List<CTCOcorrencia> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CTCOcorrencia.METADADO.Id)
				.Field(CTCOcorrencia.METADADO.Descricao)
				.Field(CTCOcorrencia.METADADO.Visivel)
				.Field(CTCOcorrencia.METADADO.Sistema)
				.Table(CTCOcorrencia.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				List<CTCOcorrencia> result = base.MapReaderToEntitySet<CTCOcorrencia>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(CTCOcorrencia obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(CTCOcorrencia.METADADO.Descricao, obj.Descricao)
				.FieldValue(CTCOcorrencia.METADADO.Visivel, obj.Visivel)
				.FieldValue(CTCOcorrencia.METADADO.Sistema, obj.Sistema)
				.Table(CTCOcorrencia.METADADO.tabelaNAME);

			update.Where
				.Add(CTCOcorrencia.METADADO.Id, Filter.Equal, obj.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, update.ToString());
				update.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

		#region Inserir
		public void Incluir(CTCOcorrencia obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(CTCOcorrencia.METADADO.tabelaNAME)
				.FieldValue(CTCOcorrencia.METADADO.Descricao, obj.Descricao)
				.FieldValue(CTCOcorrencia.METADADO.Visivel, obj.Visivel)
				.FieldValue(CTCOcorrencia.METADADO.Sistema, obj.Sistema)
				.SetIdentityField(CTCOcorrencia.METADADO.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, insert.ToString());
				insert.SetParameters(cmd);

				obj.Id = base.ExecuteScalar<int?>(cmd);
			}
		}
		#endregion

		#region Obtem
		public CTCOcorrencia Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CTCOcorrencia.METADADO.Id)
				.Field(CTCOcorrencia.METADADO.Descricao)
				.Field(CTCOcorrencia.METADADO.Visivel)
				.Field(CTCOcorrencia.METADADO.Sistema)
				.Table(CTCOcorrencia.METADADO.tabelaNAME);

			query.Where
				.Add(CTCOcorrencia.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				CTCOcorrencia result = base.MapReaderToEntity<CTCOcorrencia>(cmd);
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
				delete.Table(CTCOcorrencia.METADADO.tabelaNAME);
			delete.Where
				.Add(CTCOcorrencia.METADADO.Id, Filter.Equal, Id);

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
