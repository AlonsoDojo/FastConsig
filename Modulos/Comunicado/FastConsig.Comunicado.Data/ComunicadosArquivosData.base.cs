
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
	public partial class ComunicadosArquivosData : DataBase
	{
		
		#region Listar
		public List<ComunicadosArquivos> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(ComunicadosArquivos.METADADO.Id)
				.Field(ComunicadosArquivos.METADADO.Comunicado)
				.Field(ComunicadosArquivos.METADADO.NomeArquivo)
				.Field(ComunicadosArquivos.METADADO.Conteudo)
				.Table(ComunicadosArquivos.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				List<ComunicadosArquivos> result = base.MapReaderToEntitySet<ComunicadosArquivos>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(ComunicadosArquivos obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(ComunicadosArquivos.METADADO.Comunicado, obj.Comunicado)
				.FieldValue(ComunicadosArquivos.METADADO.NomeArquivo, obj.NomeArquivo)
				.FieldValue(ComunicadosArquivos.METADADO.Conteudo, obj.Conteudo)
				.Table(ComunicadosArquivos.METADADO.tabelaNAME);

			update.Where
				.Add(ComunicadosArquivos.METADADO.Id, Filter.Equal, obj.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, update.ToString());
				update.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

		#region Inserir
		public void Incluir(ComunicadosArquivos obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(ComunicadosArquivos.METADADO.tabelaNAME)
				.FieldValue(ComunicadosArquivos.METADADO.Comunicado, obj.Comunicado)
				.FieldValue(ComunicadosArquivos.METADADO.NomeArquivo, obj.NomeArquivo)
				.FieldValue(ComunicadosArquivos.METADADO.Conteudo, obj.Conteudo)
				.SetIdentityField(ComunicadosArquivos.METADADO.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, insert.ToString());
				insert.SetParameters(cmd);

				obj.Id = base.ExecuteScalar<int?>(cmd);
			}
		}
		#endregion

		#region Obtem
		public ComunicadosArquivos Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(ComunicadosArquivos.METADADO.Id)
				.Field(ComunicadosArquivos.METADADO.Comunicado)
				.Field(ComunicadosArquivos.METADADO.NomeArquivo)
				.Field(ComunicadosArquivos.METADADO.Conteudo)
				.Table(ComunicadosArquivos.METADADO.tabelaNAME);

			query.Where
				.Add(ComunicadosArquivos.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				ComunicadosArquivos result = base.MapReaderToEntity<ComunicadosArquivos>(cmd);
				return result;
			}
		}
		#endregion

		#region Excluir por FKs
		public void ExcluirPor_Comunicado(int? Comunicado)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(ComunicadosArquivos.METADADO.tabelaNAME);
			delete.Where
				.Add(ComunicadosArquivos.METADADO.Comunicado, Filter.Equal, Comunicado);

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
				delete.Table(ComunicadosArquivos.METADADO.tabelaNAME);
			delete.Where
				.Add(ComunicadosArquivos.METADADO.Id, Filter.Equal, Id);

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
