
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
	public partial class OcorrenciasData : DataBase
	{
		
		#region Listar
		public List<Ocorrencias> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(Ocorrencias.METADADO.Id)
				.Field(Ocorrencias.METADADO.Descricao)
				.Field(Ocorrencias.METADADO.PermiteLiberacaoComplemento)
				.Field(Ocorrencias.METADADO.Pendencia)
				.Field(Ocorrencias.METADADO.Recusa)
				.Field(Ocorrencias.METADADO.Informativa)
            .Field(Ocorrencias.METADADO.Sistema)
            .Table(Ocorrencias.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				cmd.CommandTimeout = 600;
				query.SetParameters(cmd);

				List<Ocorrencias> result = base.MapReaderToEntitySet<Ocorrencias>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(Ocorrencias obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(Ocorrencias.METADADO.Descricao, obj.Descricao)
				.FieldValue(Ocorrencias.METADADO.PermiteLiberacaoComplemento, obj.PermiteLiberacaoComplemento)
				.FieldValue(Ocorrencias.METADADO.Pendencia, obj.Pendencia)
				.FieldValue(Ocorrencias.METADADO.Recusa, obj.Recusa)
				.FieldValue(Ocorrencias.METADADO.Informativa, obj.Informativa)
            .FieldValue(Ocorrencias.METADADO.Sistema, obj.Sistema)
            .Table(Ocorrencias.METADADO.tabelaNAME);

			update.Where
				.Add(Ocorrencias.METADADO.Id, Filter.Equal, obj.Id);

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
		public void Incluir(Ocorrencias obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(Ocorrencias.METADADO.tabelaNAME)
				.FieldValue(Ocorrencias.METADADO.Descricao, obj.Descricao)
				.FieldValue(Ocorrencias.METADADO.PermiteLiberacaoComplemento, obj.PermiteLiberacaoComplemento)
				.FieldValue(Ocorrencias.METADADO.Pendencia, obj.Pendencia)
				.FieldValue(Ocorrencias.METADADO.Recusa, obj.Recusa)
				.FieldValue(Ocorrencias.METADADO.Informativa, obj.Informativa)
            .FieldValue(Ocorrencias.METADADO.Sistema, obj.Sistema)
            .SetIdentityField(Ocorrencias.METADADO.Id);

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
		public Ocorrencias Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(Ocorrencias.METADADO.Id)
				.Field(Ocorrencias.METADADO.Descricao)
				.Field(Ocorrencias.METADADO.PermiteLiberacaoComplemento)
				.Field(Ocorrencias.METADADO.Pendencia)
				.Field(Ocorrencias.METADADO.Recusa)
				.Field(Ocorrencias.METADADO.Informativa)
            .Field(Ocorrencias.METADADO.Sistema)
            .Table(Ocorrencias.METADADO.tabelaNAME);

			query.Where
				.Add(Ocorrencias.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				cmd.CommandTimeout = 600;
				query.SetParameters(cmd);

				Ocorrencias result = base.MapReaderToEntity<Ocorrencias>(cmd);
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
				delete.Table(Ocorrencias.METADADO.tabelaNAME);
			delete.Where
				.Add(Ocorrencias.METADADO.Id, Filter.Equal, Id);

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
