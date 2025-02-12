
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
	public partial class PropostaHierarquiaConsultaData : DataBase
	{
		
		#region Listar
		public List<PropostaHierarquiaConsulta> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(PropostaHierarquiaConsulta.METADADO.Id)
				.Field(PropostaHierarquiaConsulta.METADADO.Proposta)
				.Field(PropostaHierarquiaConsulta.METADADO.Nivel)
				.Field(PropostaHierarquiaConsulta.METADADO.Pessoa)
				.Field(PropostaHierarquiaConsulta.METADADO.PessoaPai)
				.Field(PropostaHierarquiaConsulta.METADADO.Papel)
				.Field(PropostaHierarquiaConsulta.METADADO.Participacao)
				.Table(PropostaHierarquiaConsulta.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				cmd.CommandTimeout = 600;
				query.SetParameters(cmd);

				List<PropostaHierarquiaConsulta> result = base.MapReaderToEntitySet<PropostaHierarquiaConsulta>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(PropostaHierarquiaConsulta obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(PropostaHierarquiaConsulta.METADADO.Proposta, obj.Proposta)
				.FieldValue(PropostaHierarquiaConsulta.METADADO.Nivel, obj.Nivel)
				.FieldValue(PropostaHierarquiaConsulta.METADADO.Pessoa, obj.Pessoa)
				.FieldValue(PropostaHierarquiaConsulta.METADADO.PessoaPai, obj.PessoaPai)
				.FieldValue(PropostaHierarquiaConsulta.METADADO.Papel, obj.Papel)
				.FieldValue(PropostaHierarquiaConsulta.METADADO.Participacao, obj.Participacao)
				.Table(PropostaHierarquiaConsulta.METADADO.tabelaNAME);

			update.Where
				.Add(PropostaHierarquiaConsulta.METADADO.Id, Filter.Equal, obj.Id);

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
		public void Incluir(PropostaHierarquiaConsulta obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(PropostaHierarquiaConsulta.METADADO.tabelaNAME)
				.FieldValue(PropostaHierarquiaConsulta.METADADO.Proposta, obj.Proposta)
				.FieldValue(PropostaHierarquiaConsulta.METADADO.Nivel, obj.Nivel)
				.FieldValue(PropostaHierarquiaConsulta.METADADO.Pessoa, obj.Pessoa)
				.FieldValue(PropostaHierarquiaConsulta.METADADO.PessoaPai, obj.PessoaPai)
				.FieldValue(PropostaHierarquiaConsulta.METADADO.Papel, obj.Papel)
				.FieldValue(PropostaHierarquiaConsulta.METADADO.Participacao, obj.Participacao)
				.SetIdentityField(PropostaHierarquiaConsulta.METADADO.Id);

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
		public PropostaHierarquiaConsulta Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(PropostaHierarquiaConsulta.METADADO.Id)
				.Field(PropostaHierarquiaConsulta.METADADO.Proposta)
				.Field(PropostaHierarquiaConsulta.METADADO.Nivel)
				.Field(PropostaHierarquiaConsulta.METADADO.Pessoa)
				.Field(PropostaHierarquiaConsulta.METADADO.PessoaPai)
				.Field(PropostaHierarquiaConsulta.METADADO.Papel)
				.Field(PropostaHierarquiaConsulta.METADADO.Participacao)
				.Table(PropostaHierarquiaConsulta.METADADO.tabelaNAME);

			query.Where
				.Add(PropostaHierarquiaConsulta.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				cmd.CommandTimeout = 600;
				query.SetParameters(cmd);

				PropostaHierarquiaConsulta result = base.MapReaderToEntity<PropostaHierarquiaConsulta>(cmd);
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
				delete.Table(PropostaHierarquiaConsulta.METADADO.tabelaNAME);
			delete.Where
				.Add(PropostaHierarquiaConsulta.METADADO.Id, Filter.Equal, Id);

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
