
#region Usings
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Framework;
using Framework.Data;
using FastConsig.Validators.Entity;
#endregion

namespace FastConsig.Validators.Data
{
	public partial class ValidadorData : DataBase
	{
		
		#region Listar
		public List<Validador> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(Validador.METADADO.Id)
				.Field(Validador.METADADO.Nome)
				.Field(Validador.METADADO.Descricao)
				.Field(Validador.METADADO.Modelo)
				.Field(Validador.METADADO.Classe)
				.Table(Validador.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				List<Validador> result = base.MapReaderToEntitySet<Validador>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(Validador obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(Validador.METADADO.Nome, obj.Nome)
				.FieldValue(Validador.METADADO.Descricao, obj.Descricao)
				.FieldValue(Validador.METADADO.Modelo, obj.Modelo)
				.FieldValue(Validador.METADADO.Classe, obj.Classe)
				.Table(Validador.METADADO.tabelaNAME);

			update.Where
				.Add(Validador.METADADO.Id, Filter.Equal, obj.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, update.ToString());
				update.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

		#region Inserir
		public void Incluir(Validador obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(Validador.METADADO.tabelaNAME)
				.FieldValue(Validador.METADADO.Nome, obj.Nome)
				.FieldValue(Validador.METADADO.Descricao, obj.Descricao)
				.FieldValue(Validador.METADADO.Modelo, obj.Modelo)
				.FieldValue(Validador.METADADO.Classe, obj.Classe)
				.SetIdentityField(Validador.METADADO.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, insert.ToString());
				insert.SetParameters(cmd);

				obj.Id = base.ExecuteScalar<int?>(cmd);
			}
		}
		#endregion

		#region Obtem
		public Validador Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(Validador.METADADO.Id)
				.Field(Validador.METADADO.Nome)
				.Field(Validador.METADADO.Descricao)
				.Field(Validador.METADADO.Modelo)
				.Field(Validador.METADADO.Classe)
				.Table(Validador.METADADO.tabelaNAME);

			query.Where
				.Add(Validador.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				Validador result = base.MapReaderToEntity<Validador>(cmd);
				return result;
			}
		}
		#endregion

		#region Excluir por FKs
		public void ExcluirPor_Modelo(int? Modelo)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(Validador.METADADO.tabelaNAME);
			delete.Where
				.Add(Validador.METADADO.Modelo, Filter.Equal, Modelo);

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
				delete.Table(Validador.METADADO.tabelaNAME);
			delete.Where
				.Add(Validador.METADADO.Id, Filter.Equal, Id);

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
