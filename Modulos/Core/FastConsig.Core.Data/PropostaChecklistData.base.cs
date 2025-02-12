
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
	public partial class PropostaChecklistData : DataBase
	{
		
		#region Listar
		public List<PropostaChecklist> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(PropostaChecklist.METADADO.Id)
				.Field(PropostaChecklist.METADADO.Proposta)
				.Field(PropostaChecklist.METADADO.Checklist)
				.Field(PropostaChecklist.METADADO.Item)
				.Field(PropostaChecklist.METADADO.Obrigatorio)
				.Field(PropostaChecklist.METADADO.TipoDocumento)
				.Field(PropostaChecklist.METADADO.Pessoa)
				.Table(PropostaChecklist.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				List<PropostaChecklist> result = base.MapReaderToEntitySet<PropostaChecklist>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(PropostaChecklist obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(PropostaChecklist.METADADO.Proposta, obj.Proposta)
				.FieldValue(PropostaChecklist.METADADO.Checklist, obj.Checklist)
				.FieldValue(PropostaChecklist.METADADO.Item, obj.Item)
				.FieldValue(PropostaChecklist.METADADO.Obrigatorio, obj.Obrigatorio)
				.FieldValue(PropostaChecklist.METADADO.TipoDocumento, obj.TipoDocumento)
				.FieldValue(PropostaChecklist.METADADO.Pessoa, obj.Pessoa)
				.Table(PropostaChecklist.METADADO.tabelaNAME);

			update.Where
				.Add(PropostaChecklist.METADADO.Id, Filter.Equal, obj.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, update.ToString());
				update.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

		#region Inserir
		public void Incluir(PropostaChecklist obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(PropostaChecklist.METADADO.tabelaNAME)
				.FieldValue(PropostaChecklist.METADADO.Proposta, obj.Proposta)
				.FieldValue(PropostaChecklist.METADADO.Checklist, obj.Checklist)
				.FieldValue(PropostaChecklist.METADADO.Item, obj.Item)
				.FieldValue(PropostaChecklist.METADADO.Obrigatorio, obj.Obrigatorio)
				.FieldValue(PropostaChecklist.METADADO.TipoDocumento, obj.TipoDocumento)
				.FieldValue(PropostaChecklist.METADADO.Pessoa, obj.Pessoa)
				.SetIdentityField(PropostaChecklist.METADADO.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, insert.ToString());
				insert.SetParameters(cmd);

				obj.Id = base.ExecuteScalar<int?>(cmd);
			}
		}
		#endregion

		#region Obtem
		public PropostaChecklist Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(PropostaChecklist.METADADO.Id)
				.Field(PropostaChecklist.METADADO.Proposta)
				.Field(PropostaChecklist.METADADO.Checklist)
				.Field(PropostaChecklist.METADADO.Item)
				.Field(PropostaChecklist.METADADO.Obrigatorio)
				.Field(PropostaChecklist.METADADO.TipoDocumento)
				.Field(PropostaChecklist.METADADO.Pessoa)
				.Table(PropostaChecklist.METADADO.tabelaNAME);

			query.Where
				.Add(PropostaChecklist.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				PropostaChecklist result = base.MapReaderToEntity<PropostaChecklist>(cmd);
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
				delete.Table(PropostaChecklist.METADADO.tabelaNAME);
			delete.Where
				.Add(PropostaChecklist.METADADO.Id, Filter.Equal, Id);

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
