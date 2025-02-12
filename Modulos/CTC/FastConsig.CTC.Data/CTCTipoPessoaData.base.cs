
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
	public partial class CTCTipoPessoaData : DataBase
	{
		
		#region Listar
		public List<CTCTipoPessoa> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CTCTipoPessoa.METADADO.Id)
				.Field(CTCTipoPessoa.METADADO.Codigo)
				.Field(CTCTipoPessoa.METADADO.Descricao)
				.Table(CTCTipoPessoa.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				List<CTCTipoPessoa> result = base.MapReaderToEntitySet<CTCTipoPessoa>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(CTCTipoPessoa obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(CTCTipoPessoa.METADADO.Codigo, obj.Codigo)
				.FieldValue(CTCTipoPessoa.METADADO.Descricao, obj.Descricao)
				.Table(CTCTipoPessoa.METADADO.tabelaNAME);

			update.Where
				.Add(CTCTipoPessoa.METADADO.Id, Filter.Equal, obj.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, update.ToString());
				update.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

		#region Inserir
		public void Incluir(CTCTipoPessoa obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(CTCTipoPessoa.METADADO.tabelaNAME)
				.FieldValue(CTCTipoPessoa.METADADO.Codigo, obj.Codigo)
				.FieldValue(CTCTipoPessoa.METADADO.Descricao, obj.Descricao)
				.SetIdentityField(CTCTipoPessoa.METADADO.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, insert.ToString());
				insert.SetParameters(cmd);

				obj.Id = base.ExecuteScalar<int?>(cmd);
			}
		}
		#endregion

		#region Obtem
		public CTCTipoPessoa Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CTCTipoPessoa.METADADO.Id)
				.Field(CTCTipoPessoa.METADADO.Codigo)
				.Field(CTCTipoPessoa.METADADO.Descricao)
				.Table(CTCTipoPessoa.METADADO.tabelaNAME);

			query.Where
				.Add(CTCTipoPessoa.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				CTCTipoPessoa result = base.MapReaderToEntity<CTCTipoPessoa>(cmd);
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
				delete.Table(CTCTipoPessoa.METADADO.tabelaNAME);
			delete.Where
				.Add(CTCTipoPessoa.METADADO.Id, Filter.Equal, Id);

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
