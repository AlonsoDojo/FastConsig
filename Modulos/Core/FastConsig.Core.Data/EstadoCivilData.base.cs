
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
	public partial class EstadoCivilData : DataBase
	{
		
		#region Listar
		public List<EstadoCivil> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(EstadoCivil.METADADO.Id)
				.Field(EstadoCivil.METADADO.Descricao)
				.Field(EstadoCivil.METADADO.CodigoIntegracaoSicred)
				.Field(EstadoCivil.METADADO.CodigoIntegracaoMatera)
				.Field(EstadoCivil.METADADO.CodigoIntegracaoBMP)
				.Table(EstadoCivil.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				cmd.CommandTimeout = 600;
				query.SetParameters(cmd);

				List<EstadoCivil> result = base.MapReaderToEntitySet<EstadoCivil>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(EstadoCivil obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(EstadoCivil.METADADO.Descricao, obj.Descricao)
				.FieldValue(EstadoCivil.METADADO.CodigoIntegracaoSicred, obj.CodigoIntegracaoSicred)
				.FieldValue(EstadoCivil.METADADO.CodigoIntegracaoMatera, obj.CodigoIntegracaoMatera)
				.FieldValue(EstadoCivil.METADADO.CodigoIntegracaoBMP, obj.CodigoIntegracaoBMP)
				.Table(EstadoCivil.METADADO.tabelaNAME);

			update.Where
				.Add(EstadoCivil.METADADO.Id, Filter.Equal, obj.Id);

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
		public void Incluir(EstadoCivil obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(EstadoCivil.METADADO.tabelaNAME)
				.FieldValue(EstadoCivil.METADADO.Descricao, obj.Descricao)
				.FieldValue(EstadoCivil.METADADO.CodigoIntegracaoSicred, obj.CodigoIntegracaoSicred)
				.FieldValue(EstadoCivil.METADADO.CodigoIntegracaoMatera, obj.CodigoIntegracaoMatera)
				.FieldValue(EstadoCivil.METADADO.CodigoIntegracaoBMP, obj.CodigoIntegracaoBMP)
				.SetIdentityField(EstadoCivil.METADADO.Id);

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
		public EstadoCivil Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(EstadoCivil.METADADO.Id)
				.Field(EstadoCivil.METADADO.Descricao)
				.Field(EstadoCivil.METADADO.CodigoIntegracaoSicred)
				.Field(EstadoCivil.METADADO.CodigoIntegracaoMatera)
				.Field(EstadoCivil.METADADO.CodigoIntegracaoBMP)
				.Table(EstadoCivil.METADADO.tabelaNAME);

			query.Where
				.Add(EstadoCivil.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				cmd.CommandTimeout = 600;
				query.SetParameters(cmd);

				EstadoCivil result = base.MapReaderToEntity<EstadoCivil>(cmd);
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
				delete.Table(EstadoCivil.METADADO.tabelaNAME);
			delete.Where
				.Add(EstadoCivil.METADADO.Id, Filter.Equal, Id);

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
