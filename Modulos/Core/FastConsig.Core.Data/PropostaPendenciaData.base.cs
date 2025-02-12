
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
	public partial class PropostaPendenciaData : DataBase
	{
		
		#region Listar
		public List<PropostaPendencia> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(PropostaPendencia.METADADO.Id)
				.Field(PropostaPendencia.METADADO.Proposta)
				.Field(PropostaPendencia.METADADO.DataHora)
				.Field(PropostaPendencia.METADADO.FaseAtual)
				.Field(PropostaPendencia.METADADO.StatusAtual)
				.Field(PropostaPendencia.METADADO.FaseDestino)
				.Field(PropostaPendencia.METADADO.Concluido)
				.Field(PropostaPendencia.METADADO.Analista)
				.Field(PropostaPendencia.METADADO.Validacoes)
				.Table(PropostaPendencia.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				cmd.CommandTimeout = 600;
				query.SetParameters(cmd);

				List<PropostaPendencia> result = base.MapReaderToEntitySet<PropostaPendencia>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(PropostaPendencia obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(PropostaPendencia.METADADO.Proposta, obj.Proposta)
				.FieldValue(PropostaPendencia.METADADO.DataHora, obj.DataHora)
				.FieldValue(PropostaPendencia.METADADO.FaseAtual, obj.FaseAtual)
				.FieldValue(PropostaPendencia.METADADO.StatusAtual, obj.StatusAtual)
				.FieldValue(PropostaPendencia.METADADO.FaseDestino, obj.FaseDestino)
				.FieldValue(PropostaPendencia.METADADO.Concluido, obj.Concluido)
				.FieldValue(PropostaPendencia.METADADO.Analista, obj.Analista)
				.FieldValue(PropostaPendencia.METADADO.Validacoes, obj.Validacoes)
				.Table(PropostaPendencia.METADADO.tabelaNAME);

			update.Where
				.Add(PropostaPendencia.METADADO.Id, Filter.Equal, obj.Id);

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
		public void Incluir(PropostaPendencia obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(PropostaPendencia.METADADO.tabelaNAME)
				.FieldValue(PropostaPendencia.METADADO.Proposta, obj.Proposta)
				.FieldValue(PropostaPendencia.METADADO.DataHora, obj.DataHora)
				.FieldValue(PropostaPendencia.METADADO.FaseAtual, obj.FaseAtual)
				.FieldValue(PropostaPendencia.METADADO.StatusAtual, obj.StatusAtual)
				.FieldValue(PropostaPendencia.METADADO.FaseDestino, obj.FaseDestino)
				.FieldValue(PropostaPendencia.METADADO.Concluido, obj.Concluido)
				.FieldValue(PropostaPendencia.METADADO.Analista, obj.Analista)
				.FieldValue(PropostaPendencia.METADADO.Validacoes, obj.Validacoes)
				.SetIdentityField(PropostaPendencia.METADADO.Id);

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
		public PropostaPendencia Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(PropostaPendencia.METADADO.Id)
				.Field(PropostaPendencia.METADADO.Proposta)
				.Field(PropostaPendencia.METADADO.DataHora)
				.Field(PropostaPendencia.METADADO.FaseAtual)
				.Field(PropostaPendencia.METADADO.StatusAtual)
				.Field(PropostaPendencia.METADADO.FaseDestino)
				.Field(PropostaPendencia.METADADO.Concluido)
				.Field(PropostaPendencia.METADADO.Analista)
				.Field(PropostaPendencia.METADADO.Validacoes)
				.Table(PropostaPendencia.METADADO.tabelaNAME);

			query.Where
				.Add(PropostaPendencia.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				cmd.CommandTimeout = 600;
				query.SetParameters(cmd);

				PropostaPendencia result = base.MapReaderToEntity<PropostaPendencia>(cmd);
				return result;
			}
		}
		#endregion

		#region Excluir por FKs
		public void ExcluirPor_Proposta(int? Proposta)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(PropostaPendencia.METADADO.tabelaNAME);
			delete.Where
				.Add(PropostaPendencia.METADADO.Proposta, Filter.Equal, Proposta);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, delete.ToString());
				cmd.CommandTimeout = 600;
				delete.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		public void ExcluirPor_FaseAtual(int? FaseAtual)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(PropostaPendencia.METADADO.tabelaNAME);
			delete.Where
				.Add(PropostaPendencia.METADADO.FaseAtual, Filter.Equal, FaseAtual);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, delete.ToString());
				cmd.CommandTimeout = 600;
				delete.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		public void ExcluirPor_FaseDestino(int? FaseDestino)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(PropostaPendencia.METADADO.tabelaNAME);
			delete.Where
				.Add(PropostaPendencia.METADADO.FaseDestino, Filter.Equal, FaseDestino);

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
				delete.Table(PropostaPendencia.METADADO.tabelaNAME);
			delete.Where
				.Add(PropostaPendencia.METADADO.Id, Filter.Equal, Id);

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
