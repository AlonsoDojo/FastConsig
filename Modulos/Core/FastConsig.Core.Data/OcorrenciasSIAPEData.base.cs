
#region Usings
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Framework;
using Framework.Data;
using FastConsig.Core.Entity;
#endregion

namespace FastConsig.Core.Data
{
	public partial class OcorrenciasSIAPEData : DataBase
	{
		
		#region Listar
		public List<OcorrenciasSIAPE> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(OcorrenciasSIAPE.METADADO.Id)
				.Field(OcorrenciasSIAPE.METADADO.Codigo)
				.Field(OcorrenciasSIAPE.METADADO.Descricao)
				.Field(OcorrenciasSIAPE.METADADO.Acao)
				.Field(OcorrenciasSIAPE.METADADO.Ocorrencia)
				.Table(OcorrenciasSIAPE.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				List<OcorrenciasSIAPE> result = base.MapReaderToEntitySet<OcorrenciasSIAPE>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(OcorrenciasSIAPE obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(OcorrenciasSIAPE.METADADO.Codigo, obj.Codigo)
				.FieldValue(OcorrenciasSIAPE.METADADO.Descricao, obj.Descricao)
				.FieldValue(OcorrenciasSIAPE.METADADO.Acao, obj.Acao)
				.FieldValue(OcorrenciasSIAPE.METADADO.Ocorrencia, obj.Ocorrencia)
				.Table(OcorrenciasSIAPE.METADADO.tabelaNAME);

			update.Where
				.Add(OcorrenciasSIAPE.METADADO.Id, Filter.Equal, obj.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, update.ToString());
				update.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

		#region Inserir
		public void Incluir(OcorrenciasSIAPE obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(OcorrenciasSIAPE.METADADO.tabelaNAME)
				.FieldValue(OcorrenciasSIAPE.METADADO.Codigo, obj.Codigo)
				.FieldValue(OcorrenciasSIAPE.METADADO.Descricao, obj.Descricao)
				.FieldValue(OcorrenciasSIAPE.METADADO.Acao, obj.Acao)
				.FieldValue(OcorrenciasSIAPE.METADADO.Ocorrencia, obj.Ocorrencia)
				.SetIdentityField(OcorrenciasSIAPE.METADADO.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, insert.ToString());
				insert.SetParameters(cmd);

				obj.Id = base.ExecuteScalar<int?>(cmd);
			}
		}
		#endregion

		#region Obtem
		public OcorrenciasSIAPE Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(OcorrenciasSIAPE.METADADO.Id)
				.Field(OcorrenciasSIAPE.METADADO.Codigo)
				.Field(OcorrenciasSIAPE.METADADO.Descricao)
				.Field(OcorrenciasSIAPE.METADADO.Acao)
				.Field(OcorrenciasSIAPE.METADADO.Ocorrencia)
				.Table(OcorrenciasSIAPE.METADADO.tabelaNAME);

			query.Where
				.Add(OcorrenciasSIAPE.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				OcorrenciasSIAPE result = base.MapReaderToEntity<OcorrenciasSIAPE>(cmd);
				return result;
			}
		}
		#endregion

		#region Excluir por FKs
		public void ExcluirPor_Acao(int? Acao)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(OcorrenciasSIAPE.METADADO.tabelaNAME);
			delete.Where
				.Add(OcorrenciasSIAPE.METADADO.Acao, Filter.Equal, Acao);

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
				delete.Table(OcorrenciasSIAPE.METADADO.tabelaNAME);
			delete.Where
				.Add(OcorrenciasSIAPE.METADADO.Ocorrencia, Filter.Equal, Ocorrencia);

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
				delete.Table(OcorrenciasSIAPE.METADADO.tabelaNAME);
			delete.Where
				.Add(OcorrenciasSIAPE.METADADO.Id, Filter.Equal, Id);

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
