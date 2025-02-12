
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
	public partial class CTC926DetalhesData : DataBase
	{
		
		#region Listar
		public List<CTC926Detalhes> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CTC926Detalhes.METADADO.Id)
				.Field(CTC926Detalhes.METADADO.CTC926)
				.Field(CTC926Detalhes.METADADO.DataReferencia)
				.Field(CTC926Detalhes.METADADO.DataProcessamentoArquivo)
				.Field(CTC926Detalhes.METADADO.NomeArquivo)
				.Field(CTC926Detalhes.METADADO.TipoArquivo)
				.Field(CTC926Detalhes.METADADO.ISPBEmissor)
				.Field(CTC926Detalhes.METADADO.ISPBDestinatario)
				.Table(CTC926Detalhes.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				List<CTC926Detalhes> result = base.MapReaderToEntitySet<CTC926Detalhes>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(CTC926Detalhes obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(CTC926Detalhes.METADADO.CTC926, obj.CTC926)
				.FieldValue(CTC926Detalhes.METADADO.DataReferencia, obj.DataReferencia)
				.FieldValue(CTC926Detalhes.METADADO.DataProcessamentoArquivo, obj.DataProcessamentoArquivo)
				.FieldValue(CTC926Detalhes.METADADO.NomeArquivo, obj.NomeArquivo)
				.FieldValue(CTC926Detalhes.METADADO.TipoArquivo, obj.TipoArquivo)
				.FieldValue(CTC926Detalhes.METADADO.ISPBEmissor, obj.ISPBEmissor)
				.FieldValue(CTC926Detalhes.METADADO.ISPBDestinatario, obj.ISPBDestinatario)
				.Table(CTC926Detalhes.METADADO.tabelaNAME);

			update.Where
				.Add(CTC926Detalhes.METADADO.Id, Filter.Equal, obj.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, update.ToString());
				update.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

		#region Inserir
		public void Incluir(CTC926Detalhes obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(CTC926Detalhes.METADADO.tabelaNAME)
				.FieldValue(CTC926Detalhes.METADADO.CTC926, obj.CTC926)
				.FieldValue(CTC926Detalhes.METADADO.DataReferencia, obj.DataReferencia)
				.FieldValue(CTC926Detalhes.METADADO.DataProcessamentoArquivo, obj.DataProcessamentoArquivo)
				.FieldValue(CTC926Detalhes.METADADO.NomeArquivo, obj.NomeArquivo)
				.FieldValue(CTC926Detalhes.METADADO.TipoArquivo, obj.TipoArquivo)
				.FieldValue(CTC926Detalhes.METADADO.ISPBEmissor, obj.ISPBEmissor)
				.FieldValue(CTC926Detalhes.METADADO.ISPBDestinatario, obj.ISPBDestinatario)
				.SetIdentityField(CTC926Detalhes.METADADO.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, insert.ToString());
				insert.SetParameters(cmd);

				obj.Id = base.ExecuteScalar<int?>(cmd);
			}
		}
		#endregion

		#region Obtem
		public CTC926Detalhes Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CTC926Detalhes.METADADO.Id)
				.Field(CTC926Detalhes.METADADO.CTC926)
				.Field(CTC926Detalhes.METADADO.DataReferencia)
				.Field(CTC926Detalhes.METADADO.DataProcessamentoArquivo)
				.Field(CTC926Detalhes.METADADO.NomeArquivo)
				.Field(CTC926Detalhes.METADADO.TipoArquivo)
				.Field(CTC926Detalhes.METADADO.ISPBEmissor)
				.Field(CTC926Detalhes.METADADO.ISPBDestinatario)
				.Table(CTC926Detalhes.METADADO.tabelaNAME);

			query.Where
				.Add(CTC926Detalhes.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				CTC926Detalhes result = base.MapReaderToEntity<CTC926Detalhes>(cmd);
				return result;
			}
		}
		#endregion

		#region Excluir por FKs
		public void ExcluirPor_CTC926(int? CTC926)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(CTC926Detalhes.METADADO.tabelaNAME);
			delete.Where
				.Add(CTC926Detalhes.METADADO.CTC926, Filter.Equal, CTC926);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, delete.ToString());
				delete.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		public void ExcluirPor_TipoArquivo(string TipoArquivo)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(CTC926Detalhes.METADADO.tabelaNAME);
			delete.Where
				.Add(CTC926Detalhes.METADADO.TipoArquivo, Filter.Equal, TipoArquivo);

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
				delete.Table(CTC926Detalhes.METADADO.tabelaNAME);
			delete.Where
				.Add(CTC926Detalhes.METADADO.Id, Filter.Equal, Id);

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
