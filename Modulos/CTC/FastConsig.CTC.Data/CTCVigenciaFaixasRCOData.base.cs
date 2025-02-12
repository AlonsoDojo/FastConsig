
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
	public partial class CTCVigenciaFaixasRCOData : DataBase
	{
		
		#region Listar
		public List<CTCVigenciaFaixasRCO> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CTCVigenciaFaixasRCO.METADADO.Id)
				.Field(CTCVigenciaFaixasRCO.METADADO.VigenciaInicial)
				.Field(CTCVigenciaFaixasRCO.METADADO.VigenciaFinal)
				.Table(CTCVigenciaFaixasRCO.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				List<CTCVigenciaFaixasRCO> result = base.MapReaderToEntitySet<CTCVigenciaFaixasRCO>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(CTCVigenciaFaixasRCO obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(CTCVigenciaFaixasRCO.METADADO.VigenciaInicial, obj.VigenciaInicial)
				.FieldValue(CTCVigenciaFaixasRCO.METADADO.VigenciaFinal, obj.VigenciaFinal)
				.Table(CTCVigenciaFaixasRCO.METADADO.tabelaNAME);

			update.Where
				.Add(CTCVigenciaFaixasRCO.METADADO.Id, Filter.Equal, obj.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, update.ToString());
				update.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

		#region Inserir
		public void Incluir(CTCVigenciaFaixasRCO obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(CTCVigenciaFaixasRCO.METADADO.tabelaNAME)
				.FieldValue(CTCVigenciaFaixasRCO.METADADO.VigenciaInicial, obj.VigenciaInicial)
				.FieldValue(CTCVigenciaFaixasRCO.METADADO.VigenciaFinal, obj.VigenciaFinal)
				.SetIdentityField(CTCVigenciaFaixasRCO.METADADO.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, insert.ToString());
				insert.SetParameters(cmd);

				obj.Id = base.ExecuteScalar<int?>(cmd);
			}
		}
		#endregion

		#region Obtem
		public CTCVigenciaFaixasRCO Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CTCVigenciaFaixasRCO.METADADO.Id)
				.Field(CTCVigenciaFaixasRCO.METADADO.VigenciaInicial)
				.Field(CTCVigenciaFaixasRCO.METADADO.VigenciaFinal)
				.Table(CTCVigenciaFaixasRCO.METADADO.tabelaNAME);

			query.Where
				.Add(CTCVigenciaFaixasRCO.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				CTCVigenciaFaixasRCO result = base.MapReaderToEntity<CTCVigenciaFaixasRCO>(cmd);
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
				delete.Table(CTCVigenciaFaixasRCO.METADADO.tabelaNAME);
			delete.Where
				.Add(CTCVigenciaFaixasRCO.METADADO.Id, Filter.Equal, Id);

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
