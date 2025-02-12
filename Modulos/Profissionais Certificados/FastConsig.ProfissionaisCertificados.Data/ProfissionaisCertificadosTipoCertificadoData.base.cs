
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
	public partial class ProfissionaisCertificadosTipoCertificadoData : DataBase
	{
		
		#region Listar
		public List<ProfissionaisCertificadosTipoCertificado> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(ProfissionaisCertificadosTipoCertificado.METADADO.Id)
				.Field(ProfissionaisCertificadosTipoCertificado.METADADO.Descricao)
				.Field(ProfissionaisCertificadosTipoCertificado.METADADO.Codigo)
				.Table(ProfissionaisCertificadosTipoCertificado.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				List<ProfissionaisCertificadosTipoCertificado> result = base.MapReaderToEntitySet<ProfissionaisCertificadosTipoCertificado>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(ProfissionaisCertificadosTipoCertificado obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(ProfissionaisCertificadosTipoCertificado.METADADO.Descricao, obj.Descricao)
				.FieldValue(ProfissionaisCertificadosTipoCertificado.METADADO.Codigo, obj.Codigo)
				.Table(ProfissionaisCertificadosTipoCertificado.METADADO.tabelaNAME);

			update.Where
				.Add(ProfissionaisCertificadosTipoCertificado.METADADO.Id, Filter.Equal, obj.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, update.ToString());
				update.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

		#region Inserir
		public void Incluir(ProfissionaisCertificadosTipoCertificado obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.FieldValue(ProfissionaisCertificadosTipoCertificado.METADADO.Id, obj.Id)
				.Table(ProfissionaisCertificadosTipoCertificado.METADADO.tabelaNAME)
				.FieldValue(ProfissionaisCertificadosTipoCertificado.METADADO.Descricao, obj.Descricao)
				.FieldValue(ProfissionaisCertificadosTipoCertificado.METADADO.Codigo, obj.Codigo);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, insert.ToString());
				insert.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

		#region Obtem
		public ProfissionaisCertificadosTipoCertificado Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(ProfissionaisCertificadosTipoCertificado.METADADO.Id)
				.Field(ProfissionaisCertificadosTipoCertificado.METADADO.Descricao)
				.Field(ProfissionaisCertificadosTipoCertificado.METADADO.Codigo)
				.Table(ProfissionaisCertificadosTipoCertificado.METADADO.tabelaNAME);

			query.Where
				.Add(ProfissionaisCertificadosTipoCertificado.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				ProfissionaisCertificadosTipoCertificado result = base.MapReaderToEntity<ProfissionaisCertificadosTipoCertificado>(cmd);
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
				delete.Table(ProfissionaisCertificadosTipoCertificado.METADADO.tabelaNAME);
			delete.Where
				.Add(ProfissionaisCertificadosTipoCertificado.METADADO.Id, Filter.Equal, Id);

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
