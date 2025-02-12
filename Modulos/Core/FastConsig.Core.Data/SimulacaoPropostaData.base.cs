
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
	public partial class SimulacaoPropostaData : DataBase
	{
		
		#region Listar
		public List<SimulacaoProposta> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(SimulacaoProposta.METADADO.Id)
				.Field(SimulacaoProposta.METADADO.DataCriacao)
				.Field(SimulacaoProposta.METADADO.Usuario)
				.Field(SimulacaoProposta.METADADO.Promotora)
				.Field(SimulacaoProposta.METADADO.Pessoa)
				.Field(SimulacaoProposta.METADADO.TipoComunicacao)
				.Field(SimulacaoProposta.METADADO.Taxa)
				.Field(SimulacaoProposta.METADADO.Guid)
				.Field(SimulacaoProposta.METADADO.Autorizacao)
				.Field(SimulacaoProposta.METADADO.TipoFormalizacao)
				.Field(SimulacaoProposta.METADADO.Retencao)
				.Table(SimulacaoProposta.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				cmd.CommandTimeout = 600;
				query.SetParameters(cmd);

				List<SimulacaoProposta> result = base.MapReaderToEntitySet<SimulacaoProposta>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(SimulacaoProposta obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(SimulacaoProposta.METADADO.DataCriacao, obj.DataCriacao)
				.FieldValue(SimulacaoProposta.METADADO.Usuario, obj.Usuario)
				.FieldValue(SimulacaoProposta.METADADO.Promotora, obj.Promotora)
				.FieldValue(SimulacaoProposta.METADADO.Pessoa, obj.Pessoa)
				.FieldValue(SimulacaoProposta.METADADO.TipoComunicacao, obj.TipoComunicacao)
				.FieldValue(SimulacaoProposta.METADADO.Taxa, obj.Taxa)
				.FieldValue(SimulacaoProposta.METADADO.Guid, obj.Guid)
				.FieldValue(SimulacaoProposta.METADADO.Autorizacao, obj.Autorizacao)
				.FieldValue(SimulacaoProposta.METADADO.TipoFormalizacao, obj.TipoFormalizacao)
				.FieldValue(SimulacaoProposta.METADADO.Retencao, obj.Retencao)
				.Table(SimulacaoProposta.METADADO.tabelaNAME);

			update.Where
				.Add(SimulacaoProposta.METADADO.Id, Filter.Equal, obj.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, update.ToString());
				cmd.CommandTimeout = 600;
				update.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

		#region Inserir
		public void Incluir(SimulacaoProposta obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(SimulacaoProposta.METADADO.tabelaNAME)
				.FieldValue(SimulacaoProposta.METADADO.DataCriacao, obj.DataCriacao)
				.FieldValue(SimulacaoProposta.METADADO.Usuario, obj.Usuario)
				.FieldValue(SimulacaoProposta.METADADO.Promotora, obj.Promotora)
				.FieldValue(SimulacaoProposta.METADADO.Pessoa, obj.Pessoa)
				.FieldValue(SimulacaoProposta.METADADO.TipoComunicacao, obj.TipoComunicacao)
				.FieldValue(SimulacaoProposta.METADADO.Taxa, obj.Taxa)
				.FieldValue(SimulacaoProposta.METADADO.Guid, obj.Guid)
				.FieldValue(SimulacaoProposta.METADADO.Autorizacao, obj.Autorizacao)
				.FieldValue(SimulacaoProposta.METADADO.TipoFormalizacao, obj.TipoFormalizacao)
				.FieldValue(SimulacaoProposta.METADADO.Retencao, obj.Retencao)
				.SetIdentityField(SimulacaoProposta.METADADO.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, insert.ToString());
				cmd.CommandTimeout = 600;
				insert.SetParameters(cmd);

				obj.Id = base.ExecuteScalar<int?>(cmd);
			}
		}
		#endregion

		#region Obtem
		public SimulacaoProposta Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(SimulacaoProposta.METADADO.Id)
				.Field(SimulacaoProposta.METADADO.DataCriacao)
				.Field(SimulacaoProposta.METADADO.Usuario)
				.Field(SimulacaoProposta.METADADO.Promotora)
				.Field(SimulacaoProposta.METADADO.Pessoa)
				.Field(SimulacaoProposta.METADADO.TipoComunicacao)
				.Field(SimulacaoProposta.METADADO.Taxa)
				.Field(SimulacaoProposta.METADADO.Guid)
				.Field(SimulacaoProposta.METADADO.Autorizacao)
				.Field(SimulacaoProposta.METADADO.TipoFormalizacao)
				.Field(SimulacaoProposta.METADADO.Retencao)
				.Table(SimulacaoProposta.METADADO.tabelaNAME);

			query.Where
				.Add(SimulacaoProposta.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				cmd.CommandTimeout = 600;
				query.SetParameters(cmd);

				SimulacaoProposta result = base.MapReaderToEntity<SimulacaoProposta>(cmd);
				return result;
			}
		}
		#endregion

		#region Excluir por FKs
		public void ExcluirPor_Promotora(int? Promotora)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(SimulacaoProposta.METADADO.tabelaNAME);
			delete.Where
				.Add(SimulacaoProposta.METADADO.Promotora, Filter.Equal, Promotora);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, delete.ToString());
				cmd.CommandTimeout = 600;
				delete.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		public void ExcluirPor_Pessoa(int? Pessoa)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(SimulacaoProposta.METADADO.tabelaNAME);
			delete.Where
				.Add(SimulacaoProposta.METADADO.Pessoa, Filter.Equal, Pessoa);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, delete.ToString());
				cmd.CommandTimeout = 600;
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
				delete.Table(SimulacaoProposta.METADADO.tabelaNAME);
			delete.Where
				.Add(SimulacaoProposta.METADADO.Id, Filter.Equal, Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, delete.ToString());
				cmd.CommandTimeout = 600;
				delete.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

	}
}
