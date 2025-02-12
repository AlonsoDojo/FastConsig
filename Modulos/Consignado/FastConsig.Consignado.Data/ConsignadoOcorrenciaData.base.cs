
#region Usings
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Framework;
using Framework.Data;
using FastConsig.Consignado.Entity;
#endregion

namespace FastConsig.Consignado.Data
{
	public partial class ConsignadoOcorrenciaData : DataBase
	{
		
		#region Listar
		public List<ConsignadoOcorrencia> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(ConsignadoOcorrencia.METADADO.Id)
				.Field(ConsignadoOcorrencia.METADADO.Codigo)
				.Field(ConsignadoOcorrencia.METADADO.Descricao)
				.Field(ConsignadoOcorrencia.METADADO.Acao)
				.Field(ConsignadoOcorrencia.METADADO.Ocorrencia)
				.Field(ConsignadoOcorrencia.METADADO.TipoConsignado)
				.Table(ConsignadoOcorrencia.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				List<ConsignadoOcorrencia> result = base.MapReaderToEntitySet<ConsignadoOcorrencia>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(ConsignadoOcorrencia obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(ConsignadoOcorrencia.METADADO.Codigo, obj.Codigo)
				.FieldValue(ConsignadoOcorrencia.METADADO.Descricao, obj.Descricao)
				.FieldValue(ConsignadoOcorrencia.METADADO.Acao, obj.Acao)
				.FieldValue(ConsignadoOcorrencia.METADADO.Ocorrencia, obj.Ocorrencia)
				.FieldValue(ConsignadoOcorrencia.METADADO.TipoConsignado, obj.TipoConsignado)
				.Table(ConsignadoOcorrencia.METADADO.tabelaNAME);

			update.Where
				.Add(ConsignadoOcorrencia.METADADO.Id, Filter.Equal, obj.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, update.ToString());
				update.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

		#region Inserir
		public void Incluir(ConsignadoOcorrencia obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(ConsignadoOcorrencia.METADADO.tabelaNAME)
				.FieldValue(ConsignadoOcorrencia.METADADO.Codigo, obj.Codigo)
				.FieldValue(ConsignadoOcorrencia.METADADO.Descricao, obj.Descricao)
				.FieldValue(ConsignadoOcorrencia.METADADO.Acao, obj.Acao)
				.FieldValue(ConsignadoOcorrencia.METADADO.Ocorrencia, obj.Ocorrencia)
				.FieldValue(ConsignadoOcorrencia.METADADO.TipoConsignado, obj.TipoConsignado)
				.SetIdentityField(ConsignadoOcorrencia.METADADO.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, insert.ToString());
				insert.SetParameters(cmd);

				obj.Id = base.ExecuteScalar<int?>(cmd);
			}
		}
		#endregion

		#region Obtem
		public ConsignadoOcorrencia Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(ConsignadoOcorrencia.METADADO.Id)
				.Field(ConsignadoOcorrencia.METADADO.Codigo)
				.Field(ConsignadoOcorrencia.METADADO.Descricao)
				.Field(ConsignadoOcorrencia.METADADO.Acao)
				.Field(ConsignadoOcorrencia.METADADO.Ocorrencia)
				.Field(ConsignadoOcorrencia.METADADO.TipoConsignado)
				.Table(ConsignadoOcorrencia.METADADO.tabelaNAME);

			query.Where
				.Add(ConsignadoOcorrencia.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				ConsignadoOcorrencia result = base.MapReaderToEntity<ConsignadoOcorrencia>(cmd);
				return result;
			}
		}
		#endregion

		#region Excluir por FKs
		public void ExcluirPor_Ocorrencia(int? Ocorrencia)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(ConsignadoOcorrencia.METADADO.tabelaNAME);
			delete.Where
				.Add(ConsignadoOcorrencia.METADADO.Ocorrencia, Filter.Equal, Ocorrencia);

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
				delete.Table(ConsignadoOcorrencia.METADADO.tabelaNAME);
			delete.Where
				.Add(ConsignadoOcorrencia.METADADO.Id, Filter.Equal, Id);

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
