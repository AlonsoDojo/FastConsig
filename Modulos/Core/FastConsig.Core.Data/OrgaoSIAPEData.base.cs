
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
	public partial class OrgaoSIAPEData : DataBase
	{
		
		#region Listar
		public List<OrgaoSIAPE> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(OrgaoSIAPE.METADADO.Codigo)
				.Field(OrgaoSIAPE.METADADO.Descricao)
				.Field(OrgaoSIAPE.METADADO.Ativo)
				.Table(OrgaoSIAPE.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				cmd.CommandTimeout = 600;
				query.SetParameters(cmd);

				List<OrgaoSIAPE> result = base.MapReaderToEntitySet<OrgaoSIAPE>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(OrgaoSIAPE obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(OrgaoSIAPE.METADADO.Codigo, obj.Codigo)
				.FieldValue(OrgaoSIAPE.METADADO.Descricao, obj.Descricao)
				.FieldValue(OrgaoSIAPE.METADADO.Ativo, obj.Ativo)
				.Table(OrgaoSIAPE.METADADO.tabelaNAME);

			update.Where
            .Add(OrgaoSIAPE.METADADO.Codigo, Filter.Equal, obj.Codigo);

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
		public void Incluir(OrgaoSIAPE obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(OrgaoSIAPE.METADADO.tabelaNAME)
				.FieldValue(OrgaoSIAPE.METADADO.Codigo, obj.Codigo)
				.FieldValue(OrgaoSIAPE.METADADO.Descricao, obj.Descricao)
				.FieldValue(OrgaoSIAPE.METADADO.Ativo, obj.Ativo);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, insert.ToString());
				cmd.CommandTimeout = 600;
				insert.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

		#region Obtem
		#endregion

		#region Excluir por FKs
		#endregion

		#region Excluir por PK
		#endregion

	}
}
