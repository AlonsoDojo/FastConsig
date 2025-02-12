
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
	public partial class PoliticasData : DataBase
	{
		
		#region Listar
		public List<Politicas> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(Politicas.METADADO.Id)
				.Field(Politicas.METADADO.Descricao)
				.Field(Politicas.METADADO.Metodo)
				.Field(Politicas.METADADO.TipoPolitica)
				.Field(Politicas.METADADO.Simulacao)
				.Field(Politicas.METADADO.ParametrosDefault)
				.Table(Politicas.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				cmd.CommandTimeout = 600;
				query.SetParameters(cmd);

				List<Politicas> result = base.MapReaderToEntitySet<Politicas>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(Politicas obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(Politicas.METADADO.Descricao, obj.Descricao)
				.FieldValue(Politicas.METADADO.Metodo, obj.Metodo)
				.FieldValue(Politicas.METADADO.TipoPolitica, obj.TipoPolitica)
				.FieldValue(Politicas.METADADO.Simulacao, obj.Simulacao)
				.FieldValue(Politicas.METADADO.ParametrosDefault, obj.ParametrosDefault)
				.Table(Politicas.METADADO.tabelaNAME);

			update.Where
				.Add(Politicas.METADADO.Id, Filter.Equal, obj.Id);

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
		public void Incluir(Politicas obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(Politicas.METADADO.tabelaNAME)
				.FieldValue(Politicas.METADADO.Descricao, obj.Descricao)
				.FieldValue(Politicas.METADADO.Metodo, obj.Metodo)
				.FieldValue(Politicas.METADADO.TipoPolitica, obj.TipoPolitica)
				.FieldValue(Politicas.METADADO.Simulacao, obj.Simulacao)
				.FieldValue(Politicas.METADADO.ParametrosDefault, obj.ParametrosDefault)
				.SetIdentityField(Politicas.METADADO.Id);

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
		public Politicas Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(Politicas.METADADO.Id)
				.Field(Politicas.METADADO.Descricao)
				.Field(Politicas.METADADO.Metodo)
				.Field(Politicas.METADADO.TipoPolitica)
				.Field(Politicas.METADADO.Simulacao)
				.Field(Politicas.METADADO.ParametrosDefault)
				.Table(Politicas.METADADO.tabelaNAME);

			query.Where
				.Add(Politicas.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				cmd.CommandTimeout = 600;
				query.SetParameters(cmd);

				Politicas result = base.MapReaderToEntity<Politicas>(cmd);
				return result;
			}
		}
		#endregion

		#region Excluir por FKs
		public void ExcluirPor_TipoPolitica(int? TipoPolitica)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(Politicas.METADADO.tabelaNAME);
			delete.Where
				.Add(Politicas.METADADO.TipoPolitica, Filter.Equal, TipoPolitica);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, delete.ToString());
				cmd.CommandTimeout = 600;
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
				delete.Table(Politicas.METADADO.tabelaNAME);
			delete.Where
				.Add(Politicas.METADADO.Id, Filter.Equal, Id);

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
