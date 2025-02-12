
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
	public partial class PropostaOcorrenciasData : DataBase
	{
		
		#region Listar
		public List<PropostaOcorrencias> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(PropostaOcorrencias.METADADO.Proposta)
				.Field(PropostaOcorrencias.METADADO.Ocorrencia)
				.Field(PropostaOcorrencias.METADADO.DataOcorrencia)
				.Field(PropostaOcorrencias.METADADO.Restritiva)
				.Field(PropostaOcorrencias.METADADO.Complemento)
				.Field(PropostaOcorrencias.METADADO.Id)
				.Field(PropostaOcorrencias.METADADO.Liberada)
				.Field(PropostaOcorrencias.METADADO.UsuarioLiberador)
				.Field(PropostaOcorrencias.METADADO.Motivo)
				.Field(PropostaOcorrencias.METADADO.DataHoraLiberacao)
				.Field(PropostaOcorrencias.METADADO.Severidade)
				.Field(PropostaOcorrencias.METADADO.Fase)
				.Field(PropostaOcorrencias.METADADO.Usuario)
				.Field(PropostaOcorrencias.METADADO.Pessoa)
				.Table(PropostaOcorrencias.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				cmd.CommandTimeout = 600;
				query.SetParameters(cmd);

				List<PropostaOcorrencias> result = base.MapReaderToEntitySet<PropostaOcorrencias>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(PropostaOcorrencias obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(PropostaOcorrencias.METADADO.Proposta, obj.Proposta)
				.FieldValue(PropostaOcorrencias.METADADO.Ocorrencia, obj.Ocorrencia)
				.FieldValue(PropostaOcorrencias.METADADO.DataOcorrencia, obj.DataOcorrencia)
				.FieldValue(PropostaOcorrencias.METADADO.Restritiva, obj.Restritiva)
				.FieldValue(PropostaOcorrencias.METADADO.Complemento, obj.Complemento)
				.FieldValue(PropostaOcorrencias.METADADO.Liberada, obj.Liberada)
				.FieldValue(PropostaOcorrencias.METADADO.UsuarioLiberador, obj.UsuarioLiberador)
				.FieldValue(PropostaOcorrencias.METADADO.Motivo, obj.Motivo)
				.FieldValue(PropostaOcorrencias.METADADO.DataHoraLiberacao, obj.DataHoraLiberacao)
				.FieldValue(PropostaOcorrencias.METADADO.Severidade, obj.Severidade)
				.FieldValue(PropostaOcorrencias.METADADO.Fase, obj.Fase)
				.FieldValue(PropostaOcorrencias.METADADO.Usuario, obj.Usuario)
				.FieldValue(PropostaOcorrencias.METADADO.Pessoa, obj.Pessoa)
				.Table(PropostaOcorrencias.METADADO.tabelaNAME);

			update.Where
				.Add(PropostaOcorrencias.METADADO.Id, Filter.Equal, obj.Id);

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
		public void Incluir(PropostaOcorrencias obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(PropostaOcorrencias.METADADO.tabelaNAME)
				.FieldValue(PropostaOcorrencias.METADADO.Proposta, obj.Proposta)
				.FieldValue(PropostaOcorrencias.METADADO.Ocorrencia, obj.Ocorrencia)
				.FieldValue(PropostaOcorrencias.METADADO.DataOcorrencia, obj.DataOcorrencia)
				.FieldValue(PropostaOcorrencias.METADADO.Restritiva, obj.Restritiva)
				.FieldValue(PropostaOcorrencias.METADADO.Complemento, obj.Complemento)
				.FieldValue(PropostaOcorrencias.METADADO.Liberada, obj.Liberada)
				.FieldValue(PropostaOcorrencias.METADADO.UsuarioLiberador, obj.UsuarioLiberador)
				.FieldValue(PropostaOcorrencias.METADADO.Motivo, obj.Motivo)
				.FieldValue(PropostaOcorrencias.METADADO.DataHoraLiberacao, obj.DataHoraLiberacao)
				.FieldValue(PropostaOcorrencias.METADADO.Severidade, obj.Severidade)
				.FieldValue(PropostaOcorrencias.METADADO.Fase, obj.Fase)
				.FieldValue(PropostaOcorrencias.METADADO.Usuario, obj.Usuario)
				.FieldValue(PropostaOcorrencias.METADADO.Pessoa, obj.Pessoa)
				.SetIdentityField(PropostaOcorrencias.METADADO.Id);

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
		public PropostaOcorrencias Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(PropostaOcorrencias.METADADO.Proposta)
				.Field(PropostaOcorrencias.METADADO.Ocorrencia)
				.Field(PropostaOcorrencias.METADADO.DataOcorrencia)
				.Field(PropostaOcorrencias.METADADO.Restritiva)
				.Field(PropostaOcorrencias.METADADO.Complemento)
				.Field(PropostaOcorrencias.METADADO.Id)
				.Field(PropostaOcorrencias.METADADO.Liberada)
				.Field(PropostaOcorrencias.METADADO.UsuarioLiberador)
				.Field(PropostaOcorrencias.METADADO.Motivo)
				.Field(PropostaOcorrencias.METADADO.DataHoraLiberacao)
				.Field(PropostaOcorrencias.METADADO.Severidade)
				.Field(PropostaOcorrencias.METADADO.Fase)
				.Field(PropostaOcorrencias.METADADO.Usuario)
				.Field(PropostaOcorrencias.METADADO.Pessoa)
				.Table(PropostaOcorrencias.METADADO.tabelaNAME);

			query.Where
				.Add(PropostaOcorrencias.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				cmd.CommandTimeout = 600;
				query.SetParameters(cmd);

				PropostaOcorrencias result = base.MapReaderToEntity<PropostaOcorrencias>(cmd);
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
				delete.Table(PropostaOcorrencias.METADADO.tabelaNAME);
			delete.Where
				.Add(PropostaOcorrencias.METADADO.Id, Filter.Equal, Id);

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
