
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
	public partial class TipoBeneficioINSSData : DataBase
	{
		
		#region Listar
		public List<TipoBeneficioINSS> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(TipoBeneficioINSS.METADADO.Id)
				.Field(TipoBeneficioINSS.METADADO.Descricao)
				.Field(TipoBeneficioINSS.METADADO.Utilizacao)
				.Field(TipoBeneficioINSS.METADADO.Aceito)
				.Table(TipoBeneficioINSS.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				cmd.CommandTimeout = 600;
				query.SetParameters(cmd);

				List<TipoBeneficioINSS> result = base.MapReaderToEntitySet<TipoBeneficioINSS>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(TipoBeneficioINSS obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(TipoBeneficioINSS.METADADO.Descricao, obj.Descricao)
				.FieldValue(TipoBeneficioINSS.METADADO.Utilizacao, obj.Utilizacao)
				.FieldValue(TipoBeneficioINSS.METADADO.Aceito, obj.Aceito)
				.Table(TipoBeneficioINSS.METADADO.tabelaNAME);

			update.Where
				.Add(TipoBeneficioINSS.METADADO.Id, Filter.Equal, obj.Id);

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
		public void Incluir(TipoBeneficioINSS obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(TipoBeneficioINSS.METADADO.tabelaNAME)
				.FieldValue(TipoBeneficioINSS.METADADO.Descricao, obj.Descricao)
				.FieldValue(TipoBeneficioINSS.METADADO.Utilizacao, obj.Utilizacao)
				.FieldValue(TipoBeneficioINSS.METADADO.Aceito, obj.Aceito)
				.SetIdentityField(TipoBeneficioINSS.METADADO.Id);

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
		public TipoBeneficioINSS Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(TipoBeneficioINSS.METADADO.Id)
				.Field(TipoBeneficioINSS.METADADO.Descricao)
				.Field(TipoBeneficioINSS.METADADO.Utilizacao)
				.Field(TipoBeneficioINSS.METADADO.Aceito)
				.Table(TipoBeneficioINSS.METADADO.tabelaNAME);

			query.Where
				.Add(TipoBeneficioINSS.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				cmd.CommandTimeout = 600;
				query.SetParameters(cmd);

				TipoBeneficioINSS result = base.MapReaderToEntity<TipoBeneficioINSS>(cmd);
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
				delete.Table(TipoBeneficioINSS.METADADO.tabelaNAME);
			delete.Where
				.Add(TipoBeneficioINSS.METADADO.Id, Filter.Equal, Id);

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
