
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
	public partial class TipoComunicacaoData : DataBase
	{
		
		#region Listar
		public List<TipoComunicacao> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(TipoComunicacao.METADADO.Id)
				.Field(TipoComunicacao.METADADO.SMS)
				.Field(TipoComunicacao.METADADO.EMail)
				.Field(TipoComunicacao.METADADO.Whatsapp)
				.Field(TipoComunicacao.METADADO.Fisico)
				.Table(TipoComunicacao.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				cmd.CommandTimeout = 600;
				query.SetParameters(cmd);

				List<TipoComunicacao> result = base.MapReaderToEntitySet<TipoComunicacao>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(TipoComunicacao obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(TipoComunicacao.METADADO.SMS, obj.SMS)
				.FieldValue(TipoComunicacao.METADADO.EMail, obj.EMail)
				.FieldValue(TipoComunicacao.METADADO.Whatsapp, obj.Whatsapp)
				.FieldValue(TipoComunicacao.METADADO.Fisico, obj.Fisico)
				.Table(TipoComunicacao.METADADO.tabelaNAME);

			update.Where
				.Add(TipoComunicacao.METADADO.Id, Filter.Equal, obj.Id);

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
		public void Incluir(TipoComunicacao obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(TipoComunicacao.METADADO.tabelaNAME)
				.FieldValue(TipoComunicacao.METADADO.SMS, obj.SMS)
				.FieldValue(TipoComunicacao.METADADO.EMail, obj.EMail)
				.FieldValue(TipoComunicacao.METADADO.Whatsapp, obj.Whatsapp)
				.FieldValue(TipoComunicacao.METADADO.Fisico, obj.Fisico)
				.SetIdentityField(TipoComunicacao.METADADO.Id);

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
		public TipoComunicacao Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(TipoComunicacao.METADADO.Id)
				.Field(TipoComunicacao.METADADO.SMS)
				.Field(TipoComunicacao.METADADO.EMail)
				.Field(TipoComunicacao.METADADO.Whatsapp)
				.Field(TipoComunicacao.METADADO.Fisico)
				.Table(TipoComunicacao.METADADO.tabelaNAME);

			query.Where
				.Add(TipoComunicacao.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				cmd.CommandTimeout = 600;
				query.SetParameters(cmd);

				TipoComunicacao result = base.MapReaderToEntity<TipoComunicacao>(cmd);
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
				delete.Table(TipoComunicacao.METADADO.tabelaNAME);
			delete.Where
				.Add(TipoComunicacao.METADADO.Id, Filter.Equal, Id);

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
