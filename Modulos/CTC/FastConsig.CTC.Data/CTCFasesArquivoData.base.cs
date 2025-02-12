
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
	public partial class CTCFasesArquivoData : DataBase
	{
		
		#region Listar
		public List<CTCFasesArquivo> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CTCFasesArquivo.METADADO.Id)
				.Field(CTCFasesArquivo.METADADO.Arquivo)
				.Field(CTCFasesArquivo.METADADO.Fase)
				.Field(CTCFasesArquivo.METADADO.Ordem)
				.Table(CTCFasesArquivo.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				List<CTCFasesArquivo> result = base.MapReaderToEntitySet<CTCFasesArquivo>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(CTCFasesArquivo obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(CTCFasesArquivo.METADADO.Arquivo, obj.Arquivo)
				.FieldValue(CTCFasesArquivo.METADADO.Fase, obj.Fase)
				.FieldValue(CTCFasesArquivo.METADADO.Ordem, obj.Ordem)
				.Table(CTCFasesArquivo.METADADO.tabelaNAME);

			update.Where
				.Add(CTCFasesArquivo.METADADO.Id, Filter.Equal, obj.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, update.ToString());
				update.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

		#region Inserir
		public void Incluir(CTCFasesArquivo obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(CTCFasesArquivo.METADADO.tabelaNAME)
				.FieldValue(CTCFasesArquivo.METADADO.Arquivo, obj.Arquivo)
				.FieldValue(CTCFasesArquivo.METADADO.Fase, obj.Fase)
				.FieldValue(CTCFasesArquivo.METADADO.Ordem, obj.Ordem)
				.SetIdentityField(CTCFasesArquivo.METADADO.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, insert.ToString());
				insert.SetParameters(cmd);

				obj.Id = base.ExecuteScalar<int?>(cmd);
			}
		}
		#endregion

		#region Obtem
		public CTCFasesArquivo Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CTCFasesArquivo.METADADO.Id)
				.Field(CTCFasesArquivo.METADADO.Arquivo)
				.Field(CTCFasesArquivo.METADADO.Fase)
				.Field(CTCFasesArquivo.METADADO.Ordem)
				.Table(CTCFasesArquivo.METADADO.tabelaNAME);

			query.Where
				.Add(CTCFasesArquivo.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				CTCFasesArquivo result = base.MapReaderToEntity<CTCFasesArquivo>(cmd);
				return result;
			}
		}
		#endregion

		#region Excluir por FKs
		public void ExcluirPor_Arquivo(int? Arquivo)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(CTCFasesArquivo.METADADO.tabelaNAME);
			delete.Where
				.Add(CTCFasesArquivo.METADADO.Arquivo, Filter.Equal, Arquivo);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, delete.ToString());
				delete.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		public void ExcluirPor_Fase(int? Fase)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(CTCFasesArquivo.METADADO.tabelaNAME);
			delete.Where
				.Add(CTCFasesArquivo.METADADO.Fase, Filter.Equal, Fase);

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
				delete.Table(CTCFasesArquivo.METADADO.tabelaNAME);
			delete.Where
				.Add(CTCFasesArquivo.METADADO.Id, Filter.Equal, Id);

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
