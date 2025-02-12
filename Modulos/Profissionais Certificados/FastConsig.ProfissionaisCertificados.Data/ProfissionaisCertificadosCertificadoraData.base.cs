
#region Usings
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Framework;
using Framework.Data;
using FastConsig.ProfissionaisCertificados.Entity;
#endregion

namespace FastConsig.ProfissionaisCertificados.Data
{
	public partial class ProfissionaisCertificadosCertificadoraData : DataBase
	{
		
		#region Listar
		public List<ProfissionaisCertificadosCertificadora> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(ProfissionaisCertificadosCertificadora.METADADO.Id)
				.Field(ProfissionaisCertificadosCertificadora.METADADO.Descricao)
				.Table(ProfissionaisCertificadosCertificadora.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				List<ProfissionaisCertificadosCertificadora> result = base.MapReaderToEntitySet<ProfissionaisCertificadosCertificadora>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(ProfissionaisCertificadosCertificadora obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(ProfissionaisCertificadosCertificadora.METADADO.Descricao, obj.Descricao)
				.Table(ProfissionaisCertificadosCertificadora.METADADO.tabelaNAME);

			update.Where
				.Add(ProfissionaisCertificadosCertificadora.METADADO.Id, Filter.Equal, obj.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, update.ToString());
				update.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

		#region Inserir
		public void Incluir(ProfissionaisCertificadosCertificadora obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.FieldValue(ProfissionaisCertificadosCertificadora.METADADO.Id, obj.Id)
				.Table(ProfissionaisCertificadosCertificadora.METADADO.tabelaNAME)
				.FieldValue(ProfissionaisCertificadosCertificadora.METADADO.Descricao, obj.Descricao);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, insert.ToString());
				insert.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

		#region Obtem
		public ProfissionaisCertificadosCertificadora Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(ProfissionaisCertificadosCertificadora.METADADO.Id)
				.Field(ProfissionaisCertificadosCertificadora.METADADO.Descricao)
				.Table(ProfissionaisCertificadosCertificadora.METADADO.tabelaNAME);

			query.Where
				.Add(ProfissionaisCertificadosCertificadora.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				ProfissionaisCertificadosCertificadora result = base.MapReaderToEntity<ProfissionaisCertificadosCertificadora>(cmd);
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
				delete.Table(ProfissionaisCertificadosCertificadora.METADADO.tabelaNAME);
			delete.Where
				.Add(ProfissionaisCertificadosCertificadora.METADADO.Id, Filter.Equal, Id);

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
