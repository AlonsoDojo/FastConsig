
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
	public partial class CTCArquivosData : DataBase
	{
		
		#region Listar
		public List<CTCArquivos> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CTCArquivos.METADADO.Id)
				.Field(CTCArquivos.METADADO.NomeArquivo)
				.Field(CTCArquivos.METADADO.ISPBEmissor)
				.Field(CTCArquivos.METADADO.ISPBDestinatario)
				.Field(CTCArquivos.METADADO.DataReferencia)
				.Field(CTCArquivos.METADADO.SituacaoArquivo)
				.Field(CTCArquivos.METADADO.Conteudo)
				.Field(CTCArquivos.METADADO.DominioArquivo)
				.Field(CTCArquivos.METADADO.Status)
				.Field(CTCArquivos.METADADO.DataHoraArquivo)
				.Field(CTCArquivos.METADADO.FluxoArquivo)
				.Field(CTCArquivos.METADADO.Mensagem)
				.Field(CTCArquivos.METADADO.DataEntrada)
				.Field(CTCArquivos.METADADO.NumeroControleEmissor)
				.Field(CTCArquivos.METADADO.NumeroControleDestinatario)
				.Field(CTCArquivos.METADADO.Identificador)
				.Field(CTCArquivos.METADADO.CodigoErro)
				.Table(CTCArquivos.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				List<CTCArquivos> result = base.MapReaderToEntitySet<CTCArquivos>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(CTCArquivos obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(CTCArquivos.METADADO.NomeArquivo, obj.NomeArquivo)
				.FieldValue(CTCArquivos.METADADO.ISPBEmissor, obj.ISPBEmissor)
				.FieldValue(CTCArquivos.METADADO.ISPBDestinatario, obj.ISPBDestinatario)
				.FieldValue(CTCArquivos.METADADO.DataReferencia, obj.DataReferencia)
				.FieldValue(CTCArquivos.METADADO.SituacaoArquivo, obj.SituacaoArquivo)
				.FieldValue(CTCArquivos.METADADO.Conteudo, obj.Conteudo)
				.FieldValue(CTCArquivos.METADADO.DominioArquivo, obj.DominioArquivo)
				.FieldValue(CTCArquivos.METADADO.Status, obj.Status)
				.FieldValue(CTCArquivos.METADADO.DataHoraArquivo, obj.DataHoraArquivo)
				.FieldValue(CTCArquivos.METADADO.FluxoArquivo, obj.FluxoArquivo)
				.FieldValue(CTCArquivos.METADADO.Mensagem, obj.Mensagem)
				.FieldValue(CTCArquivos.METADADO.DataEntrada, obj.DataEntrada)
				.FieldValue(CTCArquivos.METADADO.NumeroControleEmissor, obj.NumeroControleEmissor)
				.FieldValue(CTCArquivos.METADADO.NumeroControleDestinatario, obj.NumeroControleDestinatario)
				.FieldValue(CTCArquivos.METADADO.Identificador, obj.Identificador)
				.FieldValue(CTCArquivos.METADADO.CodigoErro, obj.CodigoErro)
				.Table(CTCArquivos.METADADO.tabelaNAME);

			update.Where
				.Add(CTCArquivos.METADADO.Id, Filter.Equal, obj.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, update.ToString());
				update.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

		#region Inserir
		public void Incluir(CTCArquivos obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(CTCArquivos.METADADO.tabelaNAME)
				.FieldValue(CTCArquivos.METADADO.NomeArquivo, obj.NomeArquivo)
				.FieldValue(CTCArquivos.METADADO.ISPBEmissor, obj.ISPBEmissor)
				.FieldValue(CTCArquivos.METADADO.ISPBDestinatario, obj.ISPBDestinatario)
				.FieldValue(CTCArquivos.METADADO.DataReferencia, obj.DataReferencia)
				.FieldValue(CTCArquivos.METADADO.SituacaoArquivo, obj.SituacaoArquivo)
				.FieldValue(CTCArquivos.METADADO.Conteudo, obj.Conteudo)
				.FieldValue(CTCArquivos.METADADO.DominioArquivo, obj.DominioArquivo)
				.FieldValue(CTCArquivos.METADADO.Status, obj.Status)
				.FieldValue(CTCArquivos.METADADO.DataHoraArquivo, obj.DataHoraArquivo)
				.FieldValue(CTCArquivos.METADADO.FluxoArquivo, obj.FluxoArquivo)
				.FieldValue(CTCArquivos.METADADO.Mensagem, obj.Mensagem)
				.FieldValue(CTCArquivos.METADADO.DataEntrada, obj.DataEntrada)
				.FieldValue(CTCArquivos.METADADO.NumeroControleEmissor, obj.NumeroControleEmissor)
				.FieldValue(CTCArquivos.METADADO.NumeroControleDestinatario, obj.NumeroControleDestinatario)
				.FieldValue(CTCArquivos.METADADO.Identificador, obj.Identificador)
				.FieldValue(CTCArquivos.METADADO.CodigoErro, obj.CodigoErro)
				.SetIdentityField(CTCArquivos.METADADO.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, insert.ToString());
				insert.SetParameters(cmd);

				obj.Id = base.ExecuteScalar<int?>(cmd);
			}
		}
		#endregion

		#region Obtem
		public CTCArquivos Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CTCArquivos.METADADO.Id)
				.Field(CTCArquivos.METADADO.NomeArquivo)
				.Field(CTCArquivos.METADADO.ISPBEmissor)
				.Field(CTCArquivos.METADADO.ISPBDestinatario)
				.Field(CTCArquivos.METADADO.DataReferencia)
				.Field(CTCArquivos.METADADO.SituacaoArquivo)
				.Field(CTCArquivos.METADADO.Conteudo)
				.Field(CTCArquivos.METADADO.DominioArquivo)
				.Field(CTCArquivos.METADADO.Status)
				.Field(CTCArquivos.METADADO.DataHoraArquivo)
				.Field(CTCArquivos.METADADO.FluxoArquivo)
				.Field(CTCArquivos.METADADO.Mensagem)
				.Field(CTCArquivos.METADADO.DataEntrada)
				.Field(CTCArquivos.METADADO.NumeroControleEmissor)
				.Field(CTCArquivos.METADADO.NumeroControleDestinatario)
				.Field(CTCArquivos.METADADO.Identificador)
				.Field(CTCArquivos.METADADO.CodigoErro)
				.Table(CTCArquivos.METADADO.tabelaNAME);

			query.Where
				.Add(CTCArquivos.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				CTCArquivos result = base.MapReaderToEntity<CTCArquivos>(cmd);
				return result;
			}
		}
		#endregion

		#region Excluir por FKs
		public void ExcluirPor_SituacaoArquivo(int? SituacaoArquivo)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(CTCArquivos.METADADO.tabelaNAME);
			delete.Where
				.Add(CTCArquivos.METADADO.SituacaoArquivo, Filter.Equal, SituacaoArquivo);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, delete.ToString());
				delete.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		public void ExcluirPor_DominioArquivo(int? DominioArquivo)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(CTCArquivos.METADADO.tabelaNAME);
			delete.Where
				.Add(CTCArquivos.METADADO.DominioArquivo, Filter.Equal, DominioArquivo);

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
				delete.Table(CTCArquivos.METADADO.tabelaNAME);
			delete.Where
				.Add(CTCArquivos.METADADO.Id, Filter.Equal, Id);

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
