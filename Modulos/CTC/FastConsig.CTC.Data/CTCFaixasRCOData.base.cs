
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
	public partial class CTCFaixasRCOData : DataBase
	{
		
		#region Listar
		public List<CTCFaixasRCO> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CTCFaixasRCO.METADADO.Id)
				.Field(CTCFaixasRCO.METADADO.Vigencia)
				.Field(CTCFaixasRCO.METADADO.TipoContrato)
				.Field(CTCFaixasRCO.METADADO.ValorInicial)
				.Field(CTCFaixasRCO.METADADO.ValorFinal)
				.Field(CTCFaixasRCO.METADADO.Valor)
				.Field(CTCFaixasRCO.METADADO.EnteConsignante)
				.Table(CTCFaixasRCO.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				List<CTCFaixasRCO> result = base.MapReaderToEntitySet<CTCFaixasRCO>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(CTCFaixasRCO obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(CTCFaixasRCO.METADADO.Vigencia, obj.Vigencia)
				.FieldValue(CTCFaixasRCO.METADADO.TipoContrato, obj.TipoContrato)
				.FieldValue(CTCFaixasRCO.METADADO.ValorInicial, obj.ValorInicial)
				.FieldValue(CTCFaixasRCO.METADADO.ValorFinal, obj.ValorFinal)
				.FieldValue(CTCFaixasRCO.METADADO.Valor, obj.Valor)
				.FieldValue(CTCFaixasRCO.METADADO.EnteConsignante, obj.EnteConsignante)
				.Table(CTCFaixasRCO.METADADO.tabelaNAME);

			update.Where
				.Add(CTCFaixasRCO.METADADO.Id, Filter.Equal, obj.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, update.ToString());
				update.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

		#region Inserir
		public void Incluir(CTCFaixasRCO obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(CTCFaixasRCO.METADADO.tabelaNAME)
				.FieldValue(CTCFaixasRCO.METADADO.Vigencia, obj.Vigencia)
				.FieldValue(CTCFaixasRCO.METADADO.TipoContrato, obj.TipoContrato)
				.FieldValue(CTCFaixasRCO.METADADO.ValorInicial, obj.ValorInicial)
				.FieldValue(CTCFaixasRCO.METADADO.ValorFinal, obj.ValorFinal)
				.FieldValue(CTCFaixasRCO.METADADO.Valor, obj.Valor)
				.FieldValue(CTCFaixasRCO.METADADO.EnteConsignante, obj.EnteConsignante)
				.SetIdentityField(CTCFaixasRCO.METADADO.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, insert.ToString());
				insert.SetParameters(cmd);

				obj.Id = base.ExecuteScalar<int?>(cmd);
			}
		}
		#endregion

		#region Obtem
		public CTCFaixasRCO Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CTCFaixasRCO.METADADO.Id)
				.Field(CTCFaixasRCO.METADADO.Vigencia)
				.Field(CTCFaixasRCO.METADADO.TipoContrato)
				.Field(CTCFaixasRCO.METADADO.ValorInicial)
				.Field(CTCFaixasRCO.METADADO.ValorFinal)
				.Field(CTCFaixasRCO.METADADO.Valor)
				.Field(CTCFaixasRCO.METADADO.EnteConsignante)
				.Table(CTCFaixasRCO.METADADO.tabelaNAME);

			query.Where
				.Add(CTCFaixasRCO.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				CTCFaixasRCO result = base.MapReaderToEntity<CTCFaixasRCO>(cmd);
				return result;
			}
		}
		#endregion

		#region Excluir por FKs
		public void ExcluirPor_Vigencia(int? Vigencia)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(CTCFaixasRCO.METADADO.tabelaNAME);
			delete.Where
				.Add(CTCFaixasRCO.METADADO.Vigencia, Filter.Equal, Vigencia);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, delete.ToString());
				delete.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		public void ExcluirPor_TipoContrato(string TipoContrato)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(CTCFaixasRCO.METADADO.tabelaNAME);
			delete.Where
				.Add(CTCFaixasRCO.METADADO.TipoContrato, Filter.Equal, TipoContrato);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, delete.ToString());
				delete.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		public void ExcluirPor_EnteConsignante(string EnteConsignante)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(CTCFaixasRCO.METADADO.tabelaNAME);
			delete.Where
				.Add(CTCFaixasRCO.METADADO.EnteConsignante, Filter.Equal, EnteConsignante);

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
				delete.Table(CTCFaixasRCO.METADADO.tabelaNAME);
			delete.Where
				.Add(CTCFaixasRCO.METADADO.Id, Filter.Equal, Id);

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
