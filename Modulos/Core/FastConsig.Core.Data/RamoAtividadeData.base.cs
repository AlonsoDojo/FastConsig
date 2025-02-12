
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
	public partial class RamoAtividadeData : DataBase
	{
		
		#region Listar
		public List<RamoAtividade> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(RamoAtividade.METADADO.Id)
				.Field(RamoAtividade.METADADO.Descricao)
				.Field(RamoAtividade.METADADO.TipoPessoa)
				.Table(RamoAtividade.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				List<RamoAtividade> result = base.MapReaderToEntitySet<RamoAtividade>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(RamoAtividade obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(RamoAtividade.METADADO.Descricao, obj.Descricao)
				.FieldValue(RamoAtividade.METADADO.TipoPessoa, obj.TipoPessoa)
				.Table(RamoAtividade.METADADO.tabelaNAME);

			update.Where
				.Add(RamoAtividade.METADADO.Id, Filter.Equal, obj.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, update.ToString());
				update.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

		#region Inserir
		public void Incluir(RamoAtividade obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.FieldValue(RamoAtividade.METADADO.Id, obj.Id)
				.Table(RamoAtividade.METADADO.tabelaNAME)
				.FieldValue(RamoAtividade.METADADO.Descricao, obj.Descricao)
				.FieldValue(RamoAtividade.METADADO.TipoPessoa, obj.TipoPessoa);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, insert.ToString());
				insert.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

		#region Obtem
		public RamoAtividade Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(RamoAtividade.METADADO.Id)
				.Field(RamoAtividade.METADADO.Descricao)
				.Field(RamoAtividade.METADADO.TipoPessoa)
				.Table(RamoAtividade.METADADO.tabelaNAME);

			query.Where
				.Add(RamoAtividade.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				RamoAtividade result = base.MapReaderToEntity<RamoAtividade>(cmd);
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
				delete.Table(RamoAtividade.METADADO.tabelaNAME);
			delete.Where
				.Add(RamoAtividade.METADADO.Id, Filter.Equal, Id);

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
