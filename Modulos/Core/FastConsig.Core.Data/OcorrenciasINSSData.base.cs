
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
	public partial class OcorrenciasINSSData : DataBase
	{
		
		#region Listar
		public List<OcorrenciasINSS> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(OcorrenciasINSS.METADADO.Id)
				.Field(OcorrenciasINSS.METADADO.Codigo)
				.Field(OcorrenciasINSS.METADADO.Descricao)
				.Field(OcorrenciasINSS.METADADO.Acao)
				.Field(OcorrenciasINSS.METADADO.Ocorrencia)
				.Table(OcorrenciasINSS.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				List<OcorrenciasINSS> result = base.MapReaderToEntitySet<OcorrenciasINSS>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(OcorrenciasINSS obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(OcorrenciasINSS.METADADO.Codigo, obj.Codigo)
				.FieldValue(OcorrenciasINSS.METADADO.Descricao, obj.Descricao)
				.FieldValue(OcorrenciasINSS.METADADO.Acao, obj.Acao)
				.FieldValue(OcorrenciasINSS.METADADO.Ocorrencia, obj.Ocorrencia)
				.Table(OcorrenciasINSS.METADADO.tabelaNAME);

			update.Where
				.Add(OcorrenciasINSS.METADADO.Id, Filter.Equal, obj.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, update.ToString());
				update.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

		#region Inserir
		public void Incluir(OcorrenciasINSS obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(OcorrenciasINSS.METADADO.tabelaNAME)
				.FieldValue(OcorrenciasINSS.METADADO.Codigo, obj.Codigo)
				.FieldValue(OcorrenciasINSS.METADADO.Descricao, obj.Descricao)
				.FieldValue(OcorrenciasINSS.METADADO.Acao, obj.Acao)
				.FieldValue(OcorrenciasINSS.METADADO.Ocorrencia, obj.Ocorrencia)
				.SetIdentityField(OcorrenciasINSS.METADADO.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, insert.ToString());
				insert.SetParameters(cmd);

				obj.Id = base.ExecuteScalar<int?>(cmd);
			}
		}
		#endregion

		#region Obtem
		public OcorrenciasINSS Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(OcorrenciasINSS.METADADO.Id)
				.Field(OcorrenciasINSS.METADADO.Codigo)
				.Field(OcorrenciasINSS.METADADO.Descricao)
				.Field(OcorrenciasINSS.METADADO.Acao)
				.Field(OcorrenciasINSS.METADADO.Ocorrencia)
				.Table(OcorrenciasINSS.METADADO.tabelaNAME);

			query.Where
				.Add(OcorrenciasINSS.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				OcorrenciasINSS result = base.MapReaderToEntity<OcorrenciasINSS>(cmd);
				return result;
			}
		}
		#endregion

		#region Excluir por FKs
		public void ExcluirPor_Acao(int? Acao)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(OcorrenciasINSS.METADADO.tabelaNAME);
			delete.Where
				.Add(OcorrenciasINSS.METADADO.Acao, Filter.Equal, Acao);

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
				delete.Table(OcorrenciasINSS.METADADO.tabelaNAME);
			delete.Where
				.Add(OcorrenciasINSS.METADADO.Ocorrencia, Filter.Equal, Ocorrencia);

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
				delete.Table(OcorrenciasINSS.METADADO.tabelaNAME);
			delete.Where
				.Add(OcorrenciasINSS.METADADO.Id, Filter.Equal, Id);

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
