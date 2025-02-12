
#region Usings
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Framework;
using Framework.Data;
using FastConsig.CTC.Entity;
#endregion

namespace FastConsig.CTC.Data
{
	public partial class CTCControleSequenciaAquivosData : DataBase
	{
		
		#region Listar
		public List<CTCControleSequenciaAquivos> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CTCControleSequenciaAquivos.METADADO.Id)
				.Field(CTCControleSequenciaAquivos.METADADO.Arquivo)
				.Field(CTCControleSequenciaAquivos.METADADO.DataReferencia)
				.Field(CTCControleSequenciaAquivos.METADADO.Sequencia)
				.Table(CTCControleSequenciaAquivos.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				List<CTCControleSequenciaAquivos> result = base.MapReaderToEntitySet<CTCControleSequenciaAquivos>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(CTCControleSequenciaAquivos obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(CTCControleSequenciaAquivos.METADADO.Arquivo, obj.Arquivo)
				.FieldValue(CTCControleSequenciaAquivos.METADADO.DataReferencia, obj.DataReferencia)
				.FieldValue(CTCControleSequenciaAquivos.METADADO.Sequencia, obj.Sequencia)
				.Table(CTCControleSequenciaAquivos.METADADO.tabelaNAME);

			update.Where
				.Add(CTCControleSequenciaAquivos.METADADO.Id, Filter.Equal, obj.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, update.ToString());
				update.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

		#region Inserir
		public void Incluir(CTCControleSequenciaAquivos obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(CTCControleSequenciaAquivos.METADADO.tabelaNAME)
				.FieldValue(CTCControleSequenciaAquivos.METADADO.Arquivo, obj.Arquivo)
				.FieldValue(CTCControleSequenciaAquivos.METADADO.DataReferencia, obj.DataReferencia)
				.FieldValue(CTCControleSequenciaAquivos.METADADO.Sequencia, obj.Sequencia)
				.SetIdentityField(CTCControleSequenciaAquivos.METADADO.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, insert.ToString());
				insert.SetParameters(cmd);

				obj.Id = base.ExecuteScalar<int?>(cmd);
			}
		}
		#endregion

		#region Obtem
		public CTCControleSequenciaAquivos Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CTCControleSequenciaAquivos.METADADO.Id)
				.Field(CTCControleSequenciaAquivos.METADADO.Arquivo)
				.Field(CTCControleSequenciaAquivos.METADADO.DataReferencia)
				.Field(CTCControleSequenciaAquivos.METADADO.Sequencia)
				.Table(CTCControleSequenciaAquivos.METADADO.tabelaNAME);

			query.Where
				.Add(CTCControleSequenciaAquivos.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				CTCControleSequenciaAquivos result = base.MapReaderToEntity<CTCControleSequenciaAquivos>(cmd);
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
				delete.Table(CTCControleSequenciaAquivos.METADADO.tabelaNAME);
			delete.Where
				.Add(CTCControleSequenciaAquivos.METADADO.Id, Filter.Equal, Id);

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
