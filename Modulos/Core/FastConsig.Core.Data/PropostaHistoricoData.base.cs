
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
	public partial class PropostaHistoricoData : DataBase
	{
		
		#region Listar
		public List<PropostaHistorico> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(PropostaHistorico.METADADO.Id)
				.Field(PropostaHistorico.METADADO.Proposta)
				.Field(PropostaHistorico.METADADO.Fase)
				.Field(PropostaHistorico.METADADO.DataExecucao)
				.Field(PropostaHistorico.METADADO.Usuario)
				.Field(PropostaHistorico.METADADO.Simulacao)
				.Field(PropostaHistorico.METADADO.Acao)
				.Table(PropostaHistorico.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				cmd.CommandTimeout = 600;
				query.SetParameters(cmd);

				List<PropostaHistorico> result = base.MapReaderToEntitySet<PropostaHistorico>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(PropostaHistorico obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(PropostaHistorico.METADADO.Proposta, obj.Proposta)
				.FieldValue(PropostaHistorico.METADADO.Fase, obj.Fase)
				.FieldValue(PropostaHistorico.METADADO.DataExecucao, obj.DataExecucao)
				.FieldValue(PropostaHistorico.METADADO.Usuario, obj.Usuario)
				.FieldValue(PropostaHistorico.METADADO.Simulacao, obj.Simulacao)
				.FieldValue(PropostaHistorico.METADADO.Acao, obj.Acao)
				.Table(PropostaHistorico.METADADO.tabelaNAME);

			update.Where
				.Add(PropostaHistorico.METADADO.Id, Filter.Equal, obj.Id);

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
		public void Incluir(PropostaHistorico obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(PropostaHistorico.METADADO.tabelaNAME)
				.FieldValue(PropostaHistorico.METADADO.Proposta, obj.Proposta)
				.FieldValue(PropostaHistorico.METADADO.Fase, obj.Fase)
				.FieldValue(PropostaHistorico.METADADO.DataExecucao, obj.DataExecucao)
				.FieldValue(PropostaHistorico.METADADO.Usuario, obj.Usuario)
				.FieldValue(PropostaHistorico.METADADO.Simulacao, obj.Simulacao)
				.FieldValue(PropostaHistorico.METADADO.Acao, obj.Acao)
				.SetIdentityField(PropostaHistorico.METADADO.Id);

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
		public PropostaHistorico Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(PropostaHistorico.METADADO.Id)
				.Field(PropostaHistorico.METADADO.Proposta)
				.Field(PropostaHistorico.METADADO.Fase)
				.Field(PropostaHistorico.METADADO.DataExecucao)
				.Field(PropostaHistorico.METADADO.Usuario)
				.Field(PropostaHistorico.METADADO.Simulacao)
				.Field(PropostaHistorico.METADADO.Acao)
				.Table(PropostaHistorico.METADADO.tabelaNAME);

			query.Where
				.Add(PropostaHistorico.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				cmd.CommandTimeout = 600;
				query.SetParameters(cmd);

				PropostaHistorico result = base.MapReaderToEntity<PropostaHistorico>(cmd);
				return result;
			}
		}
		#endregion

		#region Excluir por FKs
		public void ExcluirPor_Proposta(int? Proposta)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(PropostaHistorico.METADADO.tabelaNAME);
			delete.Where
				.Add(PropostaHistorico.METADADO.Proposta, Filter.Equal, Proposta);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, delete.ToString());
				cmd.CommandTimeout = 600;
				delete.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		public void ExcluirPor_Simulacao(int? Simulacao)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(PropostaHistorico.METADADO.tabelaNAME);
			delete.Where
				.Add(PropostaHistorico.METADADO.Simulacao, Filter.Equal, Simulacao);

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
				delete.Table(PropostaHistorico.METADADO.tabelaNAME);
			delete.Where
				.Add(PropostaHistorico.METADADO.Id, Filter.Equal, Id);

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
