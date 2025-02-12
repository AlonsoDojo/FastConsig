
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
	public partial class OrgaoEmissorData : DataBase
	{
		
		#region Listar
		public List<OrgaoEmissor> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(OrgaoEmissor.METADADO.Id)
				.Field(OrgaoEmissor.METADADO.Descricao)
				.Field(OrgaoEmissor.METADADO.Abreviatura)
				.Field(OrgaoEmissor.METADADO.CodigoIntegracaoMatera)
				.Field(OrgaoEmissor.METADADO.CodigoIntegracaoSicred)
				.Field(OrgaoEmissor.METADADO.CodigoIntegracaoBMP)
				.Table(OrgaoEmissor.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				cmd.CommandTimeout = 600;
				query.SetParameters(cmd);

				List<OrgaoEmissor> result = base.MapReaderToEntitySet<OrgaoEmissor>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(OrgaoEmissor obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(OrgaoEmissor.METADADO.Descricao, obj.Descricao)
				.FieldValue(OrgaoEmissor.METADADO.Abreviatura, obj.Abreviatura)
				.FieldValue(OrgaoEmissor.METADADO.CodigoIntegracaoMatera, obj.CodigoIntegracaoMatera)
				.FieldValue(OrgaoEmissor.METADADO.CodigoIntegracaoSicred, obj.CodigoIntegracaoSicred)
				.FieldValue(OrgaoEmissor.METADADO.CodigoIntegracaoBMP, obj.CodigoIntegracaoBMP)
				.Table(OrgaoEmissor.METADADO.tabelaNAME);

			update.Where
				.Add(OrgaoEmissor.METADADO.Id, Filter.Equal, obj.Id);

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
		public void Incluir(OrgaoEmissor obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(OrgaoEmissor.METADADO.tabelaNAME)
				.FieldValue(OrgaoEmissor.METADADO.Descricao, obj.Descricao)
				.FieldValue(OrgaoEmissor.METADADO.Abreviatura, obj.Abreviatura)
				.FieldValue(OrgaoEmissor.METADADO.CodigoIntegracaoMatera, obj.CodigoIntegracaoMatera)
				.FieldValue(OrgaoEmissor.METADADO.CodigoIntegracaoSicred, obj.CodigoIntegracaoSicred)
				.FieldValue(OrgaoEmissor.METADADO.CodigoIntegracaoBMP, obj.CodigoIntegracaoBMP)
				.SetIdentityField(OrgaoEmissor.METADADO.Id);

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
		public OrgaoEmissor Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(OrgaoEmissor.METADADO.Id)
				.Field(OrgaoEmissor.METADADO.Descricao)
				.Field(OrgaoEmissor.METADADO.Abreviatura)
				.Field(OrgaoEmissor.METADADO.CodigoIntegracaoMatera)
				.Field(OrgaoEmissor.METADADO.CodigoIntegracaoSicred)
				.Field(OrgaoEmissor.METADADO.CodigoIntegracaoBMP)
				.Table(OrgaoEmissor.METADADO.tabelaNAME);

			query.Where
				.Add(OrgaoEmissor.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				cmd.CommandTimeout = 600;
				query.SetParameters(cmd);

				OrgaoEmissor result = base.MapReaderToEntity<OrgaoEmissor>(cmd);
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
				delete.Table(OrgaoEmissor.METADADO.tabelaNAME);
			delete.Where
				.Add(OrgaoEmissor.METADADO.Id, Filter.Equal, Id);

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
