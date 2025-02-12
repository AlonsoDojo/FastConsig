
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
	public partial class CTCTipoTaxaData : DataBase
	{
		
		#region Listar
		public List<CTCTipoTaxa> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CTCTipoTaxa.METADADO.Id)
				.Field(CTCTipoTaxa.METADADO.Codigo)
				.Field(CTCTipoTaxa.METADADO.Descricao)
				.Table(CTCTipoTaxa.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				List<CTCTipoTaxa> result = base.MapReaderToEntitySet<CTCTipoTaxa>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(CTCTipoTaxa obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(CTCTipoTaxa.METADADO.Codigo, obj.Codigo)
				.FieldValue(CTCTipoTaxa.METADADO.Descricao, obj.Descricao)
				.Table(CTCTipoTaxa.METADADO.tabelaNAME);

			update.Where
				.Add(CTCTipoTaxa.METADADO.Id, Filter.Equal, obj.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, update.ToString());
				update.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

		#region Inserir
		public void Incluir(CTCTipoTaxa obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(CTCTipoTaxa.METADADO.tabelaNAME)
				.FieldValue(CTCTipoTaxa.METADADO.Codigo, obj.Codigo)
				.FieldValue(CTCTipoTaxa.METADADO.Descricao, obj.Descricao)
				.SetIdentityField(CTCTipoTaxa.METADADO.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, insert.ToString());
				insert.SetParameters(cmd);

				obj.Id = base.ExecuteScalar<int?>(cmd);
			}
		}
		#endregion

		#region Obtem
		public CTCTipoTaxa Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CTCTipoTaxa.METADADO.Id)
				.Field(CTCTipoTaxa.METADADO.Codigo)
				.Field(CTCTipoTaxa.METADADO.Descricao)
				.Table(CTCTipoTaxa.METADADO.tabelaNAME);

			query.Where
				.Add(CTCTipoTaxa.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				CTCTipoTaxa result = base.MapReaderToEntity<CTCTipoTaxa>(cmd);
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
				delete.Table(CTCTipoTaxa.METADADO.tabelaNAME);
			delete.Where
				.Add(CTCTipoTaxa.METADADO.Id, Filter.Equal, Id);

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
