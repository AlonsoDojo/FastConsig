
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
	public partial class ComunicadosData : DataBase
	{
		
		#region Listar
		public List<Comunicados> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(Comunicados.METADADO.Id)
				.Field(Comunicados.METADADO.Usuario)
				.Field(Comunicados.METADADO.DataCriacao)
				.Field(Comunicados.METADADO.DataVigenciaInicial)
				.Field(Comunicados.METADADO.DataVigenciaFinal)
				.Field(Comunicados.METADADO.Status)
				.Field(Comunicados.METADADO.Titulo)
				.Field(Comunicados.METADADO.ConfirmacaoLeitura)
				.Field(Comunicados.METADADO.PaginaPrincipal)
				.Field(Comunicados.METADADO.Conteudo)
				.Field(Comunicados.METADADO.Publicado)
				.Field(Comunicados.METADADO.UsuarioAlteracao)
				.Field(Comunicados.METADADO.DataAlteracao)
				.Field(Comunicados.METADADO.DataPublicacao)
				.Field(Comunicados.METADADO.UsuarioPublicador)
				.Field(Comunicados.METADADO.DataDesativacao)
				.Field(Comunicados.METADADO.UsuarioDesativacao)
				.Table(Comunicados.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				List<Comunicados> result = base.MapReaderToEntitySet<Comunicados>(cmd);
				return result;
			}
		}
      #endregion

      #region Listar
      public List<Comunicados> ListarComunicados(WhereBuilder filtro)
      {
         #region QueryBuilder

         QueryBuilder query = QueryBuilder.Create(this)
            .Field(Comunicados.METADADO.Id)
            .Field(Comunicados.METADADO.Usuario)
            .Field(Comunicados.METADADO.DataCriacao)
            .Field(Comunicados.METADADO.DataVigenciaInicial)
            .Field(Comunicados.METADADO.DataVigenciaFinal)
            .Field(Comunicados.METADADO.Status)
            .Field(Comunicados.METADADO.Titulo)
            .Field(Comunicados.METADADO.ConfirmacaoLeitura)
            .Field(Comunicados.METADADO.PaginaPrincipal)
            .Field(Comunicados.METADADO.Publicado)
            .Field(Comunicados.METADADO.UsuarioAlteracao)
            .Field(Comunicados.METADADO.DataAlteracao)
            .Field(Comunicados.METADADO.DataPublicacao)
            .Field(Comunicados.METADADO.UsuarioPublicador)
            .Field(Comunicados.METADADO.DataDesativacao)
            .Field(Comunicados.METADADO.UsuarioDesativacao)
            .Table(Comunicados.METADADO.tabelaNAME);

         query.Where = filtro;

         #endregion

         HandleCustomizedQuery(query);

         using (IDbConnection connection = base.CreateConnection())
         {
            IDbCommand cmd = base.CreateCommand(connection, query.ToString());
            query.SetParameters(cmd);

            List<Comunicados> result = base.MapReaderToEntitySet<Comunicados>(cmd);
            return result;
         }
      }
      #endregion

      #region Alterar
      public void Alterar(Comunicados obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(Comunicados.METADADO.Usuario, obj.Usuario)
				.FieldValue(Comunicados.METADADO.DataCriacao, obj.DataCriacao)
				.FieldValue(Comunicados.METADADO.DataVigenciaInicial, obj.DataVigenciaInicial)
				.FieldValue(Comunicados.METADADO.DataVigenciaFinal, obj.DataVigenciaFinal)
				.FieldValue(Comunicados.METADADO.Status, obj.Status)
				.FieldValue(Comunicados.METADADO.Titulo, obj.Titulo)
				.FieldValue(Comunicados.METADADO.ConfirmacaoLeitura, obj.ConfirmacaoLeitura)
				.FieldValue(Comunicados.METADADO.PaginaPrincipal, obj.PaginaPrincipal)
				.FieldValue(Comunicados.METADADO.Conteudo, obj.Conteudo)
				.FieldValue(Comunicados.METADADO.Publicado, obj.Publicado)
				.FieldValue(Comunicados.METADADO.UsuarioAlteracao, obj.UsuarioAlteracao)
				.FieldValue(Comunicados.METADADO.DataAlteracao, obj.DataAlteracao)
				.FieldValue(Comunicados.METADADO.DataPublicacao, obj.DataPublicacao)
				.FieldValue(Comunicados.METADADO.UsuarioPublicador, obj.UsuarioPublicador)
				.FieldValue(Comunicados.METADADO.DataDesativacao, obj.DataDesativacao)
				.FieldValue(Comunicados.METADADO.UsuarioDesativacao, obj.UsuarioDesativacao)
				.Table(Comunicados.METADADO.tabelaNAME);

			update.Where
				.Add(Comunicados.METADADO.Id, Filter.Equal, obj.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, update.ToString());
				update.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

		#region Inserir
		public void Incluir(Comunicados obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(Comunicados.METADADO.tabelaNAME)
				.FieldValue(Comunicados.METADADO.Usuario, obj.Usuario)
				.FieldValue(Comunicados.METADADO.DataCriacao, obj.DataCriacao)
				.FieldValue(Comunicados.METADADO.DataVigenciaInicial, obj.DataVigenciaInicial)
				.FieldValue(Comunicados.METADADO.DataVigenciaFinal, obj.DataVigenciaFinal)
				.FieldValue(Comunicados.METADADO.Status, obj.Status)
				.FieldValue(Comunicados.METADADO.Titulo, obj.Titulo)
				.FieldValue(Comunicados.METADADO.ConfirmacaoLeitura, obj.ConfirmacaoLeitura)
				.FieldValue(Comunicados.METADADO.PaginaPrincipal, obj.PaginaPrincipal)
				.FieldValue(Comunicados.METADADO.Conteudo, obj.Conteudo)
				.FieldValue(Comunicados.METADADO.Publicado, obj.Publicado)
				.FieldValue(Comunicados.METADADO.UsuarioAlteracao, obj.UsuarioAlteracao)
				.FieldValue(Comunicados.METADADO.DataAlteracao, obj.DataAlteracao)
				.FieldValue(Comunicados.METADADO.DataPublicacao, obj.DataPublicacao)
				.FieldValue(Comunicados.METADADO.UsuarioPublicador, obj.UsuarioPublicador)
				.FieldValue(Comunicados.METADADO.DataDesativacao, obj.DataDesativacao)
				.FieldValue(Comunicados.METADADO.UsuarioDesativacao, obj.UsuarioDesativacao)
				.SetIdentityField(Comunicados.METADADO.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, insert.ToString());
				insert.SetParameters(cmd);

				obj.Id = base.ExecuteScalar<int?>(cmd);
			}
		}
		#endregion

		#region Obtem
		public Comunicados Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(Comunicados.METADADO.Id)
				.Field(Comunicados.METADADO.Usuario)
				.Field(Comunicados.METADADO.DataCriacao)
				.Field(Comunicados.METADADO.DataVigenciaInicial)
				.Field(Comunicados.METADADO.DataVigenciaFinal)
				.Field(Comunicados.METADADO.Status)
				.Field(Comunicados.METADADO.Titulo)
				.Field(Comunicados.METADADO.ConfirmacaoLeitura)
				.Field(Comunicados.METADADO.PaginaPrincipal)
				.Field(Comunicados.METADADO.Conteudo)
				.Field(Comunicados.METADADO.Publicado)
				.Field(Comunicados.METADADO.UsuarioAlteracao)
				.Field(Comunicados.METADADO.DataAlteracao)
				.Field(Comunicados.METADADO.DataPublicacao)
				.Field(Comunicados.METADADO.UsuarioPublicador)
				.Field(Comunicados.METADADO.DataDesativacao)
				.Field(Comunicados.METADADO.UsuarioDesativacao)
				.Table(Comunicados.METADADO.tabelaNAME);

			query.Where
				.Add(Comunicados.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				Comunicados result = base.MapReaderToEntity<Comunicados>(cmd);
				return result;
			}
		}
      #endregion

      #region ObtemConteudo
      public Comunicados ObtemConteudo(int? Id)
      {
         #region QueryBuilder

         QueryBuilder query = QueryBuilder.Create(this)
            .Field(Comunicados.METADADO.Id)
            .Field(Comunicados.METADADO.Conteudo)
            .Table(Comunicados.METADADO.tabelaNAME);

         query.Where
            .Add(Comunicados.METADADO.Id, Filter.Equal, Id);

         HandleCustomizedQuery(query);

         #endregion

         using (IDbConnection connection = base.CreateConnection())
         {
            IDbCommand cmd = base.CreateCommand(connection, query.ToString());
            query.SetParameters(cmd);

            Comunicados result = base.MapReaderToEntity<Comunicados>(cmd);
            return result;
         }
      }
      #endregion

      #region Excluir por FKs
      public void ExcluirPor_Usuario(string Usuario)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(Comunicados.METADADO.tabelaNAME);
			delete.Where
				.Add(Comunicados.METADADO.Usuario, Filter.Equal, Usuario);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, delete.ToString());
				delete.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		public void ExcluirPor_Status(int? Status)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(Comunicados.METADADO.tabelaNAME);
			delete.Where
				.Add(Comunicados.METADADO.Status, Filter.Equal, Status);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, delete.ToString());
				delete.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		public void ExcluirPor_UsuarioAlteracao(string UsuarioAlteracao)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(Comunicados.METADADO.tabelaNAME);
			delete.Where
				.Add(Comunicados.METADADO.UsuarioAlteracao, Filter.Equal, UsuarioAlteracao);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, delete.ToString());
				delete.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		public void ExcluirPor_UsuarioPublicador(string UsuarioPublicador)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(Comunicados.METADADO.tabelaNAME);
			delete.Where
				.Add(Comunicados.METADADO.UsuarioPublicador, Filter.Equal, UsuarioPublicador);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, delete.ToString());
				delete.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		public void ExcluirPor_UsuarioDesativacao(string UsuarioDesativacao)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(Comunicados.METADADO.tabelaNAME);
			delete.Where
				.Add(Comunicados.METADADO.UsuarioDesativacao, Filter.Equal, UsuarioDesativacao);

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
				delete.Table(Comunicados.METADADO.tabelaNAME);
			delete.Where
				.Add(Comunicados.METADADO.Id, Filter.Equal, Id);

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
