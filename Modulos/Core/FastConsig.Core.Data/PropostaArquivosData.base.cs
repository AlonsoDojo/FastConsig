
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
using static FastConsig.Core.Entity.PropostaArquivos;
#endregion

namespace FastConsig.Core.Data
{
	public partial class PropostaArquivosData : DataBase
	{
		
		#region Listar
		public List<PropostaArquivos> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(PropostaArquivos.METADADO.Id)
				.Field(PropostaArquivos.METADADO.Proposta)
				.Field(PropostaArquivos.METADADO.NomeArquivo)
				.Field(PropostaArquivos.METADADO.ChaveArquivo)
				.Field(PropostaArquivos.METADADO.TipoDocumento)
				.Field(PropostaArquivos.METADADO.Pessoa)
				.Table(PropostaArquivos.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				cmd.CommandTimeout = 600;
				query.SetParameters(cmd);

				List<PropostaArquivos> result = base.MapReaderToEntitySet<PropostaArquivos>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(PropostaArquivos obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(PropostaArquivos.METADADO.Proposta, obj.Proposta)
				.FieldValue(PropostaArquivos.METADADO.NomeArquivo, obj.NomeArquivo)
				.FieldValue(PropostaArquivos.METADADO.ChaveArquivo, obj.ChaveArquivo)
				.FieldValue(PropostaArquivos.METADADO.TipoDocumento, obj.TipoDocumento)
				.FieldValue(PropostaArquivos.METADADO.Pessoa, obj.Pessoa)
				.FieldValue(PropostaArquivos.METADADO.Conteudo, obj.Conteudo)
				.Table(PropostaArquivos.METADADO.tabelaNAME);

			update.Where
				.Add(PropostaArquivos.METADADO.Id, Filter.Equal, obj.Id);

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
		public void Incluir(PropostaArquivos obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(PropostaArquivos.METADADO.tabelaNAME)
				.FieldValue(PropostaArquivos.METADADO.Proposta, obj.Proposta)
				.FieldValue(PropostaArquivos.METADADO.NomeArquivo, obj.NomeArquivo)
				.FieldValue(PropostaArquivos.METADADO.ChaveArquivo, obj.ChaveArquivo)
				.FieldValue(PropostaArquivos.METADADO.TipoDocumento, obj.TipoDocumento)
				.FieldValue(PropostaArquivos.METADADO.Pessoa, obj.Pessoa)
				.FieldValue(PropostaArquivos.METADADO.Conteudo, obj.Conteudo)
				.SetIdentityField(PropostaArquivos.METADADO.Id);

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
		public PropostaArquivos Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(PropostaArquivos.METADADO.Id)
				.Field(PropostaArquivos.METADADO.Proposta)
				.Field(PropostaArquivos.METADADO.NomeArquivo)
				.Field(PropostaArquivos.METADADO.ChaveArquivo)
				.Field(PropostaArquivos.METADADO.TipoDocumento)
				.Field(PropostaArquivos.METADADO.Pessoa)
				.Field(PropostaArquivos.METADADO.Conteudo)
				.Table(PropostaArquivos.METADADO.tabelaNAME);

			query.Where
				.Add(PropostaArquivos.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				cmd.CommandTimeout = 600;
				query.SetParameters(cmd);

				PropostaArquivos result = base.MapReaderToEntity<PropostaArquivos>(cmd);
				return result;
			}
		}
      #endregion

      #region Excluir por FKs
      public void ExcluirPorChave(long? proposta, string chave)
      {
         #region DeleteBuilder

         DeleteBuilder delete = DeleteBuilder.Create(this);
         delete.Table(PropostaArquivos.METADADO.tabelaNAME);
         delete.Where
            .Add(PropostaArquivos.METADADO.Proposta, Filter.Equal, proposta)
            .Add(PropostaArquivos.METADADO.ChaveArquivo, Filter.Equal, chave);

         #endregion

         using (IDbConnection connection = base.CreateConnection())
         {
            IDbCommand cmd = base.CreateCommand(connection, delete.ToString()); cmd.CommandTimeout = 600;
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
				delete.Table(PropostaArquivos.METADADO.tabelaNAME);
			delete.Where
				.Add(PropostaArquivos.METADADO.Id, Filter.Equal, Id);

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
