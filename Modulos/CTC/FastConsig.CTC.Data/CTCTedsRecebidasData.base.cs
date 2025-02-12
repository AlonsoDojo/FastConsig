
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
	public partial class CTCTedsRecebidasData : DataBase
	{
		
		#region Listar
		public List<CTCTedsRecebidas> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CTCTedsRecebidas.METADADO.Id)
				.Field(CTCTedsRecebidas.METADADO.Evento)
				.Field(CTCTedsRecebidas.METADADO.DataReferencia)
				.Field(CTCTedsRecebidas.METADADO.Mensagem)
				.Field(CTCTedsRecebidas.METADADO.Processado)
				.Table(CTCTedsRecebidas.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				List<CTCTedsRecebidas> result = base.MapReaderToEntitySet<CTCTedsRecebidas>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(CTCTedsRecebidas obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(CTCTedsRecebidas.METADADO.Evento, obj.Evento)
				.FieldValue(CTCTedsRecebidas.METADADO.DataReferencia, obj.DataReferencia)
				.FieldValue(CTCTedsRecebidas.METADADO.Mensagem, obj.Mensagem)
				.FieldValue(CTCTedsRecebidas.METADADO.Processado, obj.Processado)
				.Table(CTCTedsRecebidas.METADADO.tabelaNAME);

			update.Where
				.Add(CTCTedsRecebidas.METADADO.Id, Filter.Equal, obj.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, update.ToString());
				update.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

		#region Inserir
		public void Incluir(CTCTedsRecebidas obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(CTCTedsRecebidas.METADADO.tabelaNAME)
				.FieldValue(CTCTedsRecebidas.METADADO.Evento, obj.Evento)
				.FieldValue(CTCTedsRecebidas.METADADO.DataReferencia, obj.DataReferencia)
				.FieldValue(CTCTedsRecebidas.METADADO.Mensagem, obj.Mensagem)
				.FieldValue(CTCTedsRecebidas.METADADO.Processado, obj.Processado)
				.SetIdentityField(CTCTedsRecebidas.METADADO.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, insert.ToString());
				insert.SetParameters(cmd);

				obj.Id = base.ExecuteScalar<int?>(cmd);
			}
		}
		#endregion

		#region Obtem
		public CTCTedsRecebidas Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CTCTedsRecebidas.METADADO.Id)
				.Field(CTCTedsRecebidas.METADADO.Evento)
				.Field(CTCTedsRecebidas.METADADO.DataReferencia)
				.Field(CTCTedsRecebidas.METADADO.Mensagem)
				.Field(CTCTedsRecebidas.METADADO.Processado)
				.Table(CTCTedsRecebidas.METADADO.tabelaNAME);

			query.Where
				.Add(CTCTedsRecebidas.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				CTCTedsRecebidas result = base.MapReaderToEntity<CTCTedsRecebidas>(cmd);
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
				delete.Table(CTCTedsRecebidas.METADADO.tabelaNAME);
			delete.Where
				.Add(CTCTedsRecebidas.METADADO.Id, Filter.Equal, Id);

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
