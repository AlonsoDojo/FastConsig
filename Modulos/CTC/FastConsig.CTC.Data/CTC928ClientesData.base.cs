
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
	public partial class CTC928ClientesData : DataBase
	{
		
		#region Listar
		public List<CTC928Clientes> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CTC928Clientes.METADADO.Id)
				.Field(CTC928Clientes.METADADO.Arquivo)
				.Field(CTC928Clientes.METADADO.NomeCliente)
				.Field(CTC928Clientes.METADADO.Cnpj)
				.Field(CTC928Clientes.METADADO.ISPB)
				.Table(CTC928Clientes.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				List<CTC928Clientes> result = base.MapReaderToEntitySet<CTC928Clientes>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(CTC928Clientes obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(CTC928Clientes.METADADO.Arquivo, obj.Arquivo)
				.FieldValue(CTC928Clientes.METADADO.NomeCliente, obj.NomeCliente)
				.FieldValue(CTC928Clientes.METADADO.Cnpj, obj.Cnpj)
				.FieldValue(CTC928Clientes.METADADO.ISPB, obj.ISPB)
				.Table(CTC928Clientes.METADADO.tabelaNAME);

			update.Where
				.Add(CTC928Clientes.METADADO.Id, Filter.Equal, obj.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, update.ToString());
				update.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

		#region Inserir
		public void Incluir(CTC928Clientes obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(CTC928Clientes.METADADO.tabelaNAME)
				.FieldValue(CTC928Clientes.METADADO.Arquivo, obj.Arquivo)
				.FieldValue(CTC928Clientes.METADADO.NomeCliente, obj.NomeCliente)
				.FieldValue(CTC928Clientes.METADADO.Cnpj, obj.Cnpj)
				.FieldValue(CTC928Clientes.METADADO.ISPB, obj.ISPB)
				.SetIdentityField(CTC928Clientes.METADADO.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, insert.ToString());
				insert.SetParameters(cmd);

				obj.Id = base.ExecuteScalar<int?>(cmd);
			}
		}
		#endregion

		#region Obtem
		public CTC928Clientes Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CTC928Clientes.METADADO.Id)
				.Field(CTC928Clientes.METADADO.Arquivo)
				.Field(CTC928Clientes.METADADO.NomeCliente)
				.Field(CTC928Clientes.METADADO.Cnpj)
				.Field(CTC928Clientes.METADADO.ISPB)
				.Table(CTC928Clientes.METADADO.tabelaNAME);

			query.Where
				.Add(CTC928Clientes.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				CTC928Clientes result = base.MapReaderToEntity<CTC928Clientes>(cmd);
				return result;
			}
		}
		#endregion

		#region Excluir por FKs
		public void ExcluirPor_Arquivo(int? Arquivo)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(CTC928Clientes.METADADO.tabelaNAME);
			delete.Where
				.Add(CTC928Clientes.METADADO.Arquivo, Filter.Equal, Arquivo);

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
				delete.Table(CTC928Clientes.METADADO.tabelaNAME);
			delete.Where
				.Add(CTC928Clientes.METADADO.Id, Filter.Equal, Id);

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
