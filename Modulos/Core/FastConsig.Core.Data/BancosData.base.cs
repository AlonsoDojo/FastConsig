
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
	public partial class BancosData : DataBase
	{
		
		#region Listar
		public List<Bancos> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(Bancos.METADADO.Id)
				.Field(Bancos.METADADO.Banco)
				.Field(Bancos.METADADO.Digito)
				.Field(Bancos.METADADO.Nome)
				.Field(Bancos.METADADO.Cnpj)
				.Field(Bancos.METADADO.Ativo)
				.Field(Bancos.METADADO.ISPB)
				.Field(Bancos.METADADO.CBCDataPrev)
				.Table(Bancos.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				List<Bancos> result = base.MapReaderToEntitySet<Bancos>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(Bancos obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(Bancos.METADADO.Digito, obj.Digito)
				.FieldValue(Bancos.METADADO.Nome, obj.Nome)
				.FieldValue(Bancos.METADADO.Cnpj, obj.Cnpj)
				.FieldValue(Bancos.METADADO.Ativo, obj.Ativo)
				.FieldValue(Bancos.METADADO.ISPB, obj.ISPB)
				.FieldValue(Bancos.METADADO.CBCDataPrev, obj.CBCDataPrev)
				.Table(Bancos.METADADO.tabelaNAME);

			update.Where
				.Add(Bancos.METADADO.Id, Filter.Equal, obj.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, update.ToString());
				update.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

		#region Inserir
		public void Incluir(Bancos obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.SetIdentityField(Bancos.METADADO.Id)
				.FieldValue(Bancos.METADADO.Banco, obj.Banco)
				.Table(Bancos.METADADO.tabelaNAME)
				.FieldValue(Bancos.METADADO.Digito, obj.Digito)
				.FieldValue(Bancos.METADADO.Nome, obj.Nome)
				.FieldValue(Bancos.METADADO.Cnpj, obj.Cnpj)
				.FieldValue(Bancos.METADADO.Ativo, obj.Ativo)
				.FieldValue(Bancos.METADADO.ISPB, obj.ISPB)
				.FieldValue(Bancos.METADADO.CBCDataPrev, obj.CBCDataPrev);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, insert.ToString());
				insert.SetParameters(cmd);

				base.ExecuteScalar<int?>(cmd);
			}
		}
		#endregion

		#region Obtem
		public Bancos Obtem(string Banco)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(Bancos.METADADO.Id)
				.Field(Bancos.METADADO.Banco)
				.Field(Bancos.METADADO.Digito)
				.Field(Bancos.METADADO.Nome)
				.Field(Bancos.METADADO.Cnpj)
				.Field(Bancos.METADADO.Ativo)
				.Field(Bancos.METADADO.ISPB)
				.Field(Bancos.METADADO.CBCDataPrev)
				.Table(Bancos.METADADO.tabelaNAME);

			query.Where
				.Add(Bancos.METADADO.Banco, Filter.Equal, Banco);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				Bancos result = base.MapReaderToEntity<Bancos>(cmd);
				return result;
			}
		}
		#endregion

		#region Excluir por FKs
		#endregion

		#region Excluir por PK
		public void Excluir(string Banco)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(Bancos.METADADO.tabelaNAME);
			delete.Where
				.Add(Bancos.METADADO.Banco, Filter.Equal, Banco);

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
