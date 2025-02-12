
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
	public partial class PropostaConsultasData : DataBase
	{
		
		#region Listar
		public List<PropostaConsultas> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(PropostaConsultas.METADADO.Id)
				.Field(PropostaConsultas.METADADO.Pessoa)
				.Field(PropostaConsultas.METADADO.Proposta)
				.Field(PropostaConsultas.METADADO.Consulta)
				.Field(PropostaConsultas.METADADO.IdConsulta)
				.Field(PropostaConsultas.METADADO.Resultado)
				.Table(PropostaConsultas.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				cmd.CommandTimeout = 600;
				query.SetParameters(cmd);

				List<PropostaConsultas> result = base.MapReaderToEntitySet<PropostaConsultas>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(PropostaConsultas obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(PropostaConsultas.METADADO.Pessoa, obj.Pessoa)
				.FieldValue(PropostaConsultas.METADADO.Proposta, obj.Proposta)
				.FieldValue(PropostaConsultas.METADADO.Consulta, obj.Consulta)
				.FieldValue(PropostaConsultas.METADADO.IdConsulta, obj.IdConsulta)
				.FieldValue(PropostaConsultas.METADADO.Resultado, obj.Resultado)
				.Table(PropostaConsultas.METADADO.tabelaNAME);

			update.Where
				.Add(PropostaConsultas.METADADO.Id, Filter.Equal, obj.Id);

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
		public void Incluir(PropostaConsultas obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(PropostaConsultas.METADADO.tabelaNAME)
				.FieldValue(PropostaConsultas.METADADO.Pessoa, obj.Pessoa)
				.FieldValue(PropostaConsultas.METADADO.Proposta, obj.Proposta)
				.FieldValue(PropostaConsultas.METADADO.Consulta, obj.Consulta)
				.FieldValue(PropostaConsultas.METADADO.IdConsulta, obj.IdConsulta)
				.FieldValue(PropostaConsultas.METADADO.Resultado, obj.Resultado)
				.SetIdentityField(PropostaConsultas.METADADO.Id);

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
		public PropostaConsultas Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(PropostaConsultas.METADADO.Id)
				.Field(PropostaConsultas.METADADO.Pessoa)
				.Field(PropostaConsultas.METADADO.Proposta)
				.Field(PropostaConsultas.METADADO.Consulta)
				.Field(PropostaConsultas.METADADO.IdConsulta)
				.Field(PropostaConsultas.METADADO.Resultado)
				.Table(PropostaConsultas.METADADO.tabelaNAME);

			query.Where
				.Add(PropostaConsultas.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				cmd.CommandTimeout = 600;
				query.SetParameters(cmd);

				PropostaConsultas result = base.MapReaderToEntity<PropostaConsultas>(cmd);
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
				delete.Table(PropostaConsultas.METADADO.tabelaNAME);
			delete.Where
				.Add(PropostaConsultas.METADADO.Id, Filter.Equal, Id);

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
