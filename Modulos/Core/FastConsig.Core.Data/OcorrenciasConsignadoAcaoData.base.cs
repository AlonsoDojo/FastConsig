
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
	public partial class OcorrenciasConsignadoAcaoData : DataBase
	{
		
		#region Listar
		public List<OcorrenciasConsignadoAcao> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(OcorrenciasConsignadoAcao.METADADO.Id)
				.Field(OcorrenciasConsignadoAcao.METADADO.Descricao)
				.Table(OcorrenciasConsignadoAcao.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				List<OcorrenciasConsignadoAcao> result = base.MapReaderToEntitySet<OcorrenciasConsignadoAcao>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(OcorrenciasConsignadoAcao obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(OcorrenciasConsignadoAcao.METADADO.Descricao, obj.Descricao)
				.Table(OcorrenciasConsignadoAcao.METADADO.tabelaNAME);

			update.Where
				.Add(OcorrenciasConsignadoAcao.METADADO.Id, Filter.Equal, obj.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, update.ToString());
				update.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

		#region Inserir
		public void Incluir(OcorrenciasConsignadoAcao obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(OcorrenciasConsignadoAcao.METADADO.tabelaNAME)
				.FieldValue(OcorrenciasConsignadoAcao.METADADO.Descricao, obj.Descricao)
				.SetIdentityField(OcorrenciasConsignadoAcao.METADADO.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, insert.ToString());
				insert.SetParameters(cmd);

				obj.Id = base.ExecuteScalar<int?>(cmd);
			}
		}
		#endregion

		#region Obtem
		public OcorrenciasConsignadoAcao Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(OcorrenciasConsignadoAcao.METADADO.Id)
				.Field(OcorrenciasConsignadoAcao.METADADO.Descricao)
				.Table(OcorrenciasConsignadoAcao.METADADO.tabelaNAME);

			query.Where
				.Add(OcorrenciasConsignadoAcao.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				OcorrenciasConsignadoAcao result = base.MapReaderToEntity<OcorrenciasConsignadoAcao>(cmd);
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
				delete.Table(OcorrenciasConsignadoAcao.METADADO.tabelaNAME);
			delete.Where
				.Add(OcorrenciasConsignadoAcao.METADADO.Id, Filter.Equal, Id);

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
