
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
	public partial class NacionalidadeData : DataBase
	{
		
		#region Listar
		public List<Nacionalidade> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(Nacionalidade.METADADO.Id)
				.Field(Nacionalidade.METADADO.Descricao)
				.Field(Nacionalidade.METADADO.CodigoIntegracaoMatera)
				.Field(Nacionalidade.METADADO.CodigoIntegracaoSicred)
				.Field(Nacionalidade.METADADO.CodigoIntegracaoBMP)
				.Table(Nacionalidade.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				cmd.CommandTimeout = 600;
				query.SetParameters(cmd);

				List<Nacionalidade> result = base.MapReaderToEntitySet<Nacionalidade>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(Nacionalidade obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(Nacionalidade.METADADO.Descricao, obj.Descricao)
				.FieldValue(Nacionalidade.METADADO.CodigoIntegracaoMatera, obj.CodigoIntegracaoMatera)
				.FieldValue(Nacionalidade.METADADO.CodigoIntegracaoSicred, obj.CodigoIntegracaoSicred)
				.FieldValue(Nacionalidade.METADADO.CodigoIntegracaoBMP, obj.CodigoIntegracaoBMP)
				.Table(Nacionalidade.METADADO.tabelaNAME);

			update.Where
				.Add(Nacionalidade.METADADO.Id, Filter.Equal, obj.Id);

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
		public void Incluir(Nacionalidade obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(Nacionalidade.METADADO.tabelaNAME)
				.FieldValue(Nacionalidade.METADADO.Descricao, obj.Descricao)
				.FieldValue(Nacionalidade.METADADO.CodigoIntegracaoMatera, obj.CodigoIntegracaoMatera)
				.FieldValue(Nacionalidade.METADADO.CodigoIntegracaoSicred, obj.CodigoIntegracaoSicred)
				.FieldValue(Nacionalidade.METADADO.CodigoIntegracaoBMP, obj.CodigoIntegracaoBMP)
				.SetIdentityField(Nacionalidade.METADADO.Id);

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
		public Nacionalidade Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(Nacionalidade.METADADO.Id)
				.Field(Nacionalidade.METADADO.Descricao)
				.Field(Nacionalidade.METADADO.CodigoIntegracaoMatera)
				.Field(Nacionalidade.METADADO.CodigoIntegracaoSicred)
				.Field(Nacionalidade.METADADO.CodigoIntegracaoBMP)
				.Table(Nacionalidade.METADADO.tabelaNAME);

			query.Where
				.Add(Nacionalidade.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				cmd.CommandTimeout = 600;
				query.SetParameters(cmd);

				Nacionalidade result = base.MapReaderToEntity<Nacionalidade>(cmd);
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
				delete.Table(Nacionalidade.METADADO.tabelaNAME);
			delete.Where
				.Add(Nacionalidade.METADADO.Id, Filter.Equal, Id);

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
