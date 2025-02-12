
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
	public partial class CTCRequisicaoHistoricoData : DataBase
	{
		
		#region Listar
		public List<CTCRequisicaoHistorico> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CTCRequisicaoHistorico.METADADO.Id)
				.Field(CTCRequisicaoHistorico.METADADO.Requisicao)
				.Field(CTCRequisicaoHistorico.METADADO.Ocorrencia)
				.Field(CTCRequisicaoHistorico.METADADO.DataOcorrencia)
				.Field(CTCRequisicaoHistorico.METADADO.Usuario)
				.Field(CTCRequisicaoHistorico.METADADO.Complemento)
				.Table(CTCRequisicaoHistorico.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				List<CTCRequisicaoHistorico> result = base.MapReaderToEntitySet<CTCRequisicaoHistorico>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(CTCRequisicaoHistorico obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(CTCRequisicaoHistorico.METADADO.Requisicao, obj.Requisicao)
				.FieldValue(CTCRequisicaoHistorico.METADADO.Ocorrencia, obj.Ocorrencia)
				.FieldValue(CTCRequisicaoHistorico.METADADO.DataOcorrencia, obj.DataOcorrencia)
				.FieldValue(CTCRequisicaoHistorico.METADADO.Usuario, obj.Usuario)
				.FieldValue(CTCRequisicaoHistorico.METADADO.Complemento, obj.Complemento)
				.Table(CTCRequisicaoHistorico.METADADO.tabelaNAME);

			update.Where
				.Add(CTCRequisicaoHistorico.METADADO.Id, Filter.Equal, obj.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, update.ToString());
				update.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

		#region Inserir
		public void Incluir(CTCRequisicaoHistorico obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(CTCRequisicaoHistorico.METADADO.tabelaNAME)
				.FieldValue(CTCRequisicaoHistorico.METADADO.Requisicao, obj.Requisicao)
				.FieldValue(CTCRequisicaoHistorico.METADADO.Ocorrencia, obj.Ocorrencia)
				.FieldValue(CTCRequisicaoHistorico.METADADO.DataOcorrencia, obj.DataOcorrencia)
				.FieldValue(CTCRequisicaoHistorico.METADADO.Usuario, obj.Usuario)
				.FieldValue(CTCRequisicaoHistorico.METADADO.Complemento, obj.Complemento)
				.SetIdentityField(CTCRequisicaoHistorico.METADADO.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, insert.ToString());
				insert.SetParameters(cmd);

				obj.Id = base.ExecuteScalar<int?>(cmd);
			}
		}
		#endregion

		#region Obtem
		public CTCRequisicaoHistorico Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CTCRequisicaoHistorico.METADADO.Id)
				.Field(CTCRequisicaoHistorico.METADADO.Requisicao)
				.Field(CTCRequisicaoHistorico.METADADO.Ocorrencia)
				.Field(CTCRequisicaoHistorico.METADADO.DataOcorrencia)
				.Field(CTCRequisicaoHistorico.METADADO.Usuario)
				.Field(CTCRequisicaoHistorico.METADADO.Complemento)
				.Table(CTCRequisicaoHistorico.METADADO.tabelaNAME);

			query.Where
				.Add(CTCRequisicaoHistorico.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				CTCRequisicaoHistorico result = base.MapReaderToEntity<CTCRequisicaoHistorico>(cmd);
				return result;
			}
		}
		#endregion

		#region Excluir por FKs
		public void ExcluirPor_Requisicao(int? Requisicao)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(CTCRequisicaoHistorico.METADADO.tabelaNAME);
			delete.Where
				.Add(CTCRequisicaoHistorico.METADADO.Requisicao, Filter.Equal, Requisicao);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, delete.ToString());
				delete.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		public void ExcluirPor_Ocorrencia(int? Ocorrencia)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(CTCRequisicaoHistorico.METADADO.tabelaNAME);
			delete.Where
				.Add(CTCRequisicaoHistorico.METADADO.Ocorrencia, Filter.Equal, Ocorrencia);

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
				delete.Table(CTCRequisicaoHistorico.METADADO.tabelaNAME);
			delete.Where
				.Add(CTCRequisicaoHistorico.METADADO.Id, Filter.Equal, Id);

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
