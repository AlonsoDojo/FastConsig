
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
	public partial class CTCTipoContratoPropostaData : DataBase
	{
		
		#region Listar
		public List<CTCTipoContratoProposta> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CTCTipoContratoProposta.METADADO.Id)
				.Field(CTCTipoContratoProposta.METADADO.Codigo)
				.Field(CTCTipoContratoProposta.METADADO.Descricao)
				.Table(CTCTipoContratoProposta.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				List<CTCTipoContratoProposta> result = base.MapReaderToEntitySet<CTCTipoContratoProposta>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(CTCTipoContratoProposta obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(CTCTipoContratoProposta.METADADO.Codigo, obj.Codigo)
				.FieldValue(CTCTipoContratoProposta.METADADO.Descricao, obj.Descricao)
				.Table(CTCTipoContratoProposta.METADADO.tabelaNAME);

			update.Where
				.Add(CTCTipoContratoProposta.METADADO.Id, Filter.Equal, obj.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, update.ToString());
				update.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

		#region Inserir
		public void Incluir(CTCTipoContratoProposta obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(CTCTipoContratoProposta.METADADO.tabelaNAME)
				.FieldValue(CTCTipoContratoProposta.METADADO.Codigo, obj.Codigo)
				.FieldValue(CTCTipoContratoProposta.METADADO.Descricao, obj.Descricao)
				.SetIdentityField(CTCTipoContratoProposta.METADADO.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, insert.ToString());
				insert.SetParameters(cmd);

				obj.Id = base.ExecuteScalar<int?>(cmd);
			}
		}
		#endregion

		#region Obtem
		public CTCTipoContratoProposta Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CTCTipoContratoProposta.METADADO.Id)
				.Field(CTCTipoContratoProposta.METADADO.Codigo)
				.Field(CTCTipoContratoProposta.METADADO.Descricao)
				.Table(CTCTipoContratoProposta.METADADO.tabelaNAME);

			query.Where
				.Add(CTCTipoContratoProposta.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				CTCTipoContratoProposta result = base.MapReaderToEntity<CTCTipoContratoProposta>(cmd);
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
				delete.Table(CTCTipoContratoProposta.METADADO.tabelaNAME);
			delete.Where
				.Add(CTCTipoContratoProposta.METADADO.Id, Filter.Equal, Id);

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
