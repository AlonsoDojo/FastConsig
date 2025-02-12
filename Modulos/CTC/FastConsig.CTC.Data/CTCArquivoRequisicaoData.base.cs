
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
	public partial class CTCArquivoRequisicaoData : DataBase
	{
		
		#region Listar
		public List<CTCArquivoRequisicao> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CTCArquivoRequisicao.METADADO.Id)
				.Field(CTCArquivoRequisicao.METADADO.Requisicao)
				.Field(CTCArquivoRequisicao.METADADO.Arquivo)
				.Table(CTCArquivoRequisicao.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				List<CTCArquivoRequisicao> result = base.MapReaderToEntitySet<CTCArquivoRequisicao>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(CTCArquivoRequisicao obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(CTCArquivoRequisicao.METADADO.Requisicao, obj.Requisicao)
				.FieldValue(CTCArquivoRequisicao.METADADO.Arquivo, obj.Arquivo)
				.Table(CTCArquivoRequisicao.METADADO.tabelaNAME);

			update.Where
				.Add(CTCArquivoRequisicao.METADADO.Id, Filter.Equal, obj.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, update.ToString());
				update.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

		#region Inserir
		public void Incluir(CTCArquivoRequisicao obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(CTCArquivoRequisicao.METADADO.tabelaNAME)
				.FieldValue(CTCArquivoRequisicao.METADADO.Requisicao, obj.Requisicao)
				.FieldValue(CTCArquivoRequisicao.METADADO.Arquivo, obj.Arquivo)
				.SetIdentityField(CTCArquivoRequisicao.METADADO.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, insert.ToString());
				insert.SetParameters(cmd);

				obj.Id = base.ExecuteScalar<int?>(cmd);
			}
		}
		#endregion

		#region Obtem
		public CTCArquivoRequisicao Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CTCArquivoRequisicao.METADADO.Id)
				.Field(CTCArquivoRequisicao.METADADO.Requisicao)
				.Field(CTCArquivoRequisicao.METADADO.Arquivo)
				.Table(CTCArquivoRequisicao.METADADO.tabelaNAME);

			query.Where
				.Add(CTCArquivoRequisicao.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				CTCArquivoRequisicao result = base.MapReaderToEntity<CTCArquivoRequisicao>(cmd);
				return result;
			}
		}
		#endregion

		#region Excluir por FKs
		public void ExcluirPor_Requisicao(int? Requisicao)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(CTCArquivoRequisicao.METADADO.tabelaNAME);
			delete.Where
				.Add(CTCArquivoRequisicao.METADADO.Requisicao, Filter.Equal, Requisicao);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, delete.ToString());
				delete.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		public void ExcluirPor_Arquivo(int? Arquivo)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(CTCArquivoRequisicao.METADADO.tabelaNAME);
			delete.Where
				.Add(CTCArquivoRequisicao.METADADO.Arquivo, Filter.Equal, Arquivo);

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
				delete.Table(CTCArquivoRequisicao.METADADO.tabelaNAME);
			delete.Where
				.Add(CTCArquivoRequisicao.METADADO.Id, Filter.Equal, Id);

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
