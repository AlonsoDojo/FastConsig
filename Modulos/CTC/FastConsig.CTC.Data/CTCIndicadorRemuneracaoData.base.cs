
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
	public partial class CTCIndicadorRemuneracaoData : DataBase
	{
		
		#region Listar
		public List<CTCIndicadorRemuneracao> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CTCIndicadorRemuneracao.METADADO.Id)
				.Field(CTCIndicadorRemuneracao.METADADO.Codigo)
				.Field(CTCIndicadorRemuneracao.METADADO.Descricao)
				.Table(CTCIndicadorRemuneracao.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				List<CTCIndicadorRemuneracao> result = base.MapReaderToEntitySet<CTCIndicadorRemuneracao>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(CTCIndicadorRemuneracao obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(CTCIndicadorRemuneracao.METADADO.Codigo, obj.Codigo)
				.FieldValue(CTCIndicadorRemuneracao.METADADO.Descricao, obj.Descricao)
				.Table(CTCIndicadorRemuneracao.METADADO.tabelaNAME);

			update.Where
				.Add(CTCIndicadorRemuneracao.METADADO.Id, Filter.Equal, obj.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, update.ToString());
				update.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

		#region Inserir
		public void Incluir(CTCIndicadorRemuneracao obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(CTCIndicadorRemuneracao.METADADO.tabelaNAME)
				.FieldValue(CTCIndicadorRemuneracao.METADADO.Codigo, obj.Codigo)
				.FieldValue(CTCIndicadorRemuneracao.METADADO.Descricao, obj.Descricao)
				.SetIdentityField(CTCIndicadorRemuneracao.METADADO.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, insert.ToString());
				insert.SetParameters(cmd);

				obj.Id = base.ExecuteScalar<int?>(cmd);
			}
		}
		#endregion

		#region Obtem
		public CTCIndicadorRemuneracao Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CTCIndicadorRemuneracao.METADADO.Id)
				.Field(CTCIndicadorRemuneracao.METADADO.Codigo)
				.Field(CTCIndicadorRemuneracao.METADADO.Descricao)
				.Table(CTCIndicadorRemuneracao.METADADO.tabelaNAME);

			query.Where
				.Add(CTCIndicadorRemuneracao.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				CTCIndicadorRemuneracao result = base.MapReaderToEntity<CTCIndicadorRemuneracao>(cmd);
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
				delete.Table(CTCIndicadorRemuneracao.METADADO.tabelaNAME);
			delete.Where
				.Add(CTCIndicadorRemuneracao.METADADO.Id, Filter.Equal, Id);

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
