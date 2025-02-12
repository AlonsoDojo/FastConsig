
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
	public partial class CompromissosData : DataBase
	{
		
		#region Listar
		public List<Compromissos> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(Compromissos.METADADO.Id)
				.Field(Compromissos.METADADO.Proposta)
				.Field(Compromissos.METADADO.Pessoa)
				.Field(Compromissos.METADADO.TipoCompromisso)
				.Table(Compromissos.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				cmd.CommandTimeout = 600;
				query.SetParameters(cmd);

				List<Compromissos> result = base.MapReaderToEntitySet<Compromissos>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(Compromissos obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(Compromissos.METADADO.Proposta, obj.Proposta)
				.FieldValue(Compromissos.METADADO.Pessoa, obj.Pessoa)
				.FieldValue(Compromissos.METADADO.TipoCompromisso, obj.TipoCompromisso)
				.Table(Compromissos.METADADO.tabelaNAME);

			update.Where
				.Add(Compromissos.METADADO.Id, Filter.Equal, obj.Id);

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
		public void Incluir(Compromissos obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(Compromissos.METADADO.tabelaNAME)
				.FieldValue(Compromissos.METADADO.Proposta, obj.Proposta)
				.FieldValue(Compromissos.METADADO.Pessoa, obj.Pessoa)
				.FieldValue(Compromissos.METADADO.TipoCompromisso, obj.TipoCompromisso)
				.SetIdentityField(Compromissos.METADADO.Id);

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
		public Compromissos Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(Compromissos.METADADO.Id)
				.Field(Compromissos.METADADO.Proposta)
				.Field(Compromissos.METADADO.Pessoa)
				.Field(Compromissos.METADADO.TipoCompromisso)
				.Table(Compromissos.METADADO.tabelaNAME);

			query.Where
				.Add(Compromissos.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				cmd.CommandTimeout = 600;
				query.SetParameters(cmd);

				Compromissos result = base.MapReaderToEntity<Compromissos>(cmd);
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
				delete.Table(Compromissos.METADADO.tabelaNAME);
			delete.Where
				.Add(Compromissos.METADADO.Id, Filter.Equal, Id);

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
