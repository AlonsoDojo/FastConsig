
#region Usings
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Framework;
using Framework.Data;
using FastConsig.Comunicado.Entity;
#endregion

namespace FastConsig.Comunicado.Data
{
	public partial class ComunicadosConfirmacaoLeituraData : DataBase
	{
		
		#region Listar
		public List<ComunicadosConfirmacaoLeitura> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(ComunicadosConfirmacaoLeitura.METADADO.Id)
				.Field(ComunicadosConfirmacaoLeitura.METADADO.Comunicado)
				.Field(ComunicadosConfirmacaoLeitura.METADADO.Usuario)
				.Field(ComunicadosConfirmacaoLeitura.METADADO.DataLeitura)
				.Table(ComunicadosConfirmacaoLeitura.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				List<ComunicadosConfirmacaoLeitura> result = base.MapReaderToEntitySet<ComunicadosConfirmacaoLeitura>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(ComunicadosConfirmacaoLeitura obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(ComunicadosConfirmacaoLeitura.METADADO.Comunicado, obj.Comunicado)
				.FieldValue(ComunicadosConfirmacaoLeitura.METADADO.Usuario, obj.Usuario)
				.FieldValue(ComunicadosConfirmacaoLeitura.METADADO.DataLeitura, obj.DataLeitura)
				.Table(ComunicadosConfirmacaoLeitura.METADADO.tabelaNAME);

			update.Where
				.Add(ComunicadosConfirmacaoLeitura.METADADO.Id, Filter.Equal, obj.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, update.ToString());
				update.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

		#region Inserir
		public void Incluir(ComunicadosConfirmacaoLeitura obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(ComunicadosConfirmacaoLeitura.METADADO.tabelaNAME)
				.FieldValue(ComunicadosConfirmacaoLeitura.METADADO.Comunicado, obj.Comunicado)
				.FieldValue(ComunicadosConfirmacaoLeitura.METADADO.Usuario, obj.Usuario)
				.FieldValue(ComunicadosConfirmacaoLeitura.METADADO.DataLeitura, obj.DataLeitura)
				.SetIdentityField(ComunicadosConfirmacaoLeitura.METADADO.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, insert.ToString());
				insert.SetParameters(cmd);

				obj.Id = base.ExecuteScalar<int?>(cmd);
			}
		}
		#endregion

		#region Obtem
		public ComunicadosConfirmacaoLeitura Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(ComunicadosConfirmacaoLeitura.METADADO.Id)
				.Field(ComunicadosConfirmacaoLeitura.METADADO.Comunicado)
				.Field(ComunicadosConfirmacaoLeitura.METADADO.Usuario)
				.Field(ComunicadosConfirmacaoLeitura.METADADO.DataLeitura)
				.Table(ComunicadosConfirmacaoLeitura.METADADO.tabelaNAME);

			query.Where
				.Add(ComunicadosConfirmacaoLeitura.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				ComunicadosConfirmacaoLeitura result = base.MapReaderToEntity<ComunicadosConfirmacaoLeitura>(cmd);
				return result;
			}
		}
		#endregion

		#region Excluir por FKs
		public void ExcluirPor_Comunicado(int? Comunicado)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(ComunicadosConfirmacaoLeitura.METADADO.tabelaNAME);
			delete.Where
				.Add(ComunicadosConfirmacaoLeitura.METADADO.Comunicado, Filter.Equal, Comunicado);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, delete.ToString());
				delete.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		public void ExcluirPor_Usuario(string Usuario)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(ComunicadosConfirmacaoLeitura.METADADO.tabelaNAME);
			delete.Where
				.Add(ComunicadosConfirmacaoLeitura.METADADO.Usuario, Filter.Equal, Usuario);

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
				delete.Table(ComunicadosConfirmacaoLeitura.METADADO.tabelaNAME);
			delete.Where
				.Add(ComunicadosConfirmacaoLeitura.METADADO.Id, Filter.Equal, Id);

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
