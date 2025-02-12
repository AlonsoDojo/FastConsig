
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
	public partial class TipoDocumentoIdentidadeData : DataBase
	{
		
		#region Listar
		public List<TipoDocumentoIdentidade> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(TipoDocumentoIdentidade.METADADO.Id)
				.Field(TipoDocumentoIdentidade.METADADO.Descricao)
				.Field(TipoDocumentoIdentidade.METADADO.Abreviatura)
				.Field(TipoDocumentoIdentidade.METADADO.CodigoIntegracaoMatera)
				.Field(TipoDocumentoIdentidade.METADADO.CodigoIntegracaoSicred)
				.Field(TipoDocumentoIdentidade.METADADO.CodigoIntegracaoBMP)
				.Field(TipoDocumentoIdentidade.METADADO.Visivel)
				.Table(TipoDocumentoIdentidade.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				cmd.CommandTimeout = 600;
				query.SetParameters(cmd);

				List<TipoDocumentoIdentidade> result = base.MapReaderToEntitySet<TipoDocumentoIdentidade>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(TipoDocumentoIdentidade obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(TipoDocumentoIdentidade.METADADO.Descricao, obj.Descricao)
				.FieldValue(TipoDocumentoIdentidade.METADADO.Abreviatura, obj.Abreviatura)
				.FieldValue(TipoDocumentoIdentidade.METADADO.CodigoIntegracaoMatera, obj.CodigoIntegracaoMatera)
				.FieldValue(TipoDocumentoIdentidade.METADADO.CodigoIntegracaoSicred, obj.CodigoIntegracaoSicred)
				.FieldValue(TipoDocumentoIdentidade.METADADO.CodigoIntegracaoBMP, obj.CodigoIntegracaoBMP)
				.FieldValue(TipoDocumentoIdentidade.METADADO.Visivel, obj.Visivel)
				.Table(TipoDocumentoIdentidade.METADADO.tabelaNAME);

			update.Where
				.Add(TipoDocumentoIdentidade.METADADO.Id, Filter.Equal, obj.Id);

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
		public void Incluir(TipoDocumentoIdentidade obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(TipoDocumentoIdentidade.METADADO.tabelaNAME)
				.FieldValue(TipoDocumentoIdentidade.METADADO.Descricao, obj.Descricao)
				.FieldValue(TipoDocumentoIdentidade.METADADO.Abreviatura, obj.Abreviatura)
				.FieldValue(TipoDocumentoIdentidade.METADADO.CodigoIntegracaoMatera, obj.CodigoIntegracaoMatera)
				.FieldValue(TipoDocumentoIdentidade.METADADO.CodigoIntegracaoSicred, obj.CodigoIntegracaoSicred)
				.FieldValue(TipoDocumentoIdentidade.METADADO.CodigoIntegracaoBMP, obj.CodigoIntegracaoBMP)
				.FieldValue(TipoDocumentoIdentidade.METADADO.Visivel, obj.Visivel)
				.SetIdentityField(TipoDocumentoIdentidade.METADADO.Id);

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
		public TipoDocumentoIdentidade Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(TipoDocumentoIdentidade.METADADO.Id)
				.Field(TipoDocumentoIdentidade.METADADO.Descricao)
				.Field(TipoDocumentoIdentidade.METADADO.Abreviatura)
				.Field(TipoDocumentoIdentidade.METADADO.CodigoIntegracaoMatera)
				.Field(TipoDocumentoIdentidade.METADADO.CodigoIntegracaoSicred)
				.Field(TipoDocumentoIdentidade.METADADO.CodigoIntegracaoBMP)
				.Field(TipoDocumentoIdentidade.METADADO.Visivel)
				.Table(TipoDocumentoIdentidade.METADADO.tabelaNAME);

			query.Where
				.Add(TipoDocumentoIdentidade.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				cmd.CommandTimeout = 600;
				query.SetParameters(cmd);

				TipoDocumentoIdentidade result = base.MapReaderToEntity<TipoDocumentoIdentidade>(cmd);
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
				delete.Table(TipoDocumentoIdentidade.METADADO.tabelaNAME);
			delete.Where
				.Add(TipoDocumentoIdentidade.METADADO.Id, Filter.Equal, Id);

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
