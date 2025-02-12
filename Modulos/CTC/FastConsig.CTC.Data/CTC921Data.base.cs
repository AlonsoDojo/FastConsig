
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
	public partial class CTC921Data : DataBase
	{
		
		#region Listar
		public List<CTC921> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CTC921.METADADO.Id)
				.Field(CTC921.METADADO.DataReferenciaArquivo)
				.Field(CTC921.METADADO.TipoRelatorio)
				.Field(CTC921.METADADO.MesAno)
				.Field(CTC921.METADADO.DataInicio)
				.Field(CTC921.METADADO.DataFim)
				.Field(CTC921.METADADO.SituacaoProcessamento)
				.Field(CTC921.METADADO.Arquivo)
				.Table(CTC921.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				List<CTC921> result = base.MapReaderToEntitySet<CTC921>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(CTC921 obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(CTC921.METADADO.DataReferenciaArquivo, obj.DataReferenciaArquivo)
				.FieldValue(CTC921.METADADO.TipoRelatorio, obj.TipoRelatorio)
				.FieldValue(CTC921.METADADO.MesAno, obj.MesAno)
				.FieldValue(CTC921.METADADO.DataInicio, obj.DataInicio)
				.FieldValue(CTC921.METADADO.DataFim, obj.DataFim)
				.FieldValue(CTC921.METADADO.SituacaoProcessamento, obj.SituacaoProcessamento)
				.FieldValue(CTC921.METADADO.Arquivo, obj.Arquivo)
				.Table(CTC921.METADADO.tabelaNAME);

			update.Where
				.Add(CTC921.METADADO.Id, Filter.Equal, obj.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, update.ToString());
				update.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

		#region Inserir
		public void Incluir(CTC921 obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(CTC921.METADADO.tabelaNAME)
				.FieldValue(CTC921.METADADO.DataReferenciaArquivo, obj.DataReferenciaArquivo)
				.FieldValue(CTC921.METADADO.TipoRelatorio, obj.TipoRelatorio)
				.FieldValue(CTC921.METADADO.MesAno, obj.MesAno)
				.FieldValue(CTC921.METADADO.DataInicio, obj.DataInicio)
				.FieldValue(CTC921.METADADO.DataFim, obj.DataFim)
				.FieldValue(CTC921.METADADO.SituacaoProcessamento, obj.SituacaoProcessamento)
				.FieldValue(CTC921.METADADO.Arquivo, obj.Arquivo)
				.SetIdentityField(CTC921.METADADO.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, insert.ToString());
				insert.SetParameters(cmd);

				obj.Id = base.ExecuteScalar<int?>(cmd);
			}
		}
		#endregion

		#region Obtem
		public CTC921 Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CTC921.METADADO.Id)
				.Field(CTC921.METADADO.DataReferenciaArquivo)
				.Field(CTC921.METADADO.TipoRelatorio)
				.Field(CTC921.METADADO.MesAno)
				.Field(CTC921.METADADO.DataInicio)
				.Field(CTC921.METADADO.DataFim)
				.Field(CTC921.METADADO.SituacaoProcessamento)
				.Field(CTC921.METADADO.Arquivo)
				.Table(CTC921.METADADO.tabelaNAME);

			query.Where
				.Add(CTC921.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				CTC921 result = base.MapReaderToEntity<CTC921>(cmd);
				return result;
			}
		}
		#endregion

		#region Excluir por FKs
		public void ExcluirPor_TipoRelatorio(string TipoRelatorio)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(CTC921.METADADO.tabelaNAME);
			delete.Where
				.Add(CTC921.METADADO.TipoRelatorio, Filter.Equal, TipoRelatorio);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, delete.ToString());
				delete.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		public void ExcluirPor_SituacaoProcessamento(string SituacaoProcessamento)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(CTC921.METADADO.tabelaNAME);
			delete.Where
				.Add(CTC921.METADADO.SituacaoProcessamento, Filter.Equal, SituacaoProcessamento);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, delete.ToString());
				delete.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		public void ExcluirPor_Arquivo(int? Arquivo)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(CTC921.METADADO.tabelaNAME);
			delete.Where
				.Add(CTC921.METADADO.Arquivo, Filter.Equal, Arquivo);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, delete.ToString());
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
				delete.Table(CTC921.METADADO.tabelaNAME);
			delete.Where
				.Add(CTC921.METADADO.Id, Filter.Equal, Id);

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
