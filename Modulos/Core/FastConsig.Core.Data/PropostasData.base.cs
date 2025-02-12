
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
	public partial class PropostasData : DataBase
	{
		
		#region Listar
		public List<Propostas> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(Propostas.METADADO.Id)
				.Field(Propostas.METADADO.DataCriacao)
				.Field(Propostas.METADADO.DataUltimaAlteracao)
				.Field(Propostas.METADADO.Fase)
				.Field(Propostas.METADADO.Status)
				.Field(Propostas.METADADO.Usuario)
				.Field(Propostas.METADADO.Observacoes)
				.Field(Propostas.METADADO.Gerente)
				.Field(Propostas.METADADO.MotivoRecusa)
				.Field(Propostas.METADADO.Promotora)
				.Field(Propostas.METADADO.DataAtualizacao)
				.Field(Propostas.METADADO.UsuarioProposta)
				.Field(Propostas.METADADO.ProfissionalCertificado)
				.Field(Propostas.METADADO.Pendente)
				.Field(Propostas.METADADO.TipoFormalizacao)
				.Field(Propostas.METADADO.TipoComunicacao)
				.Field(Propostas.METADADO.MensagemInterna)
				.Field(Propostas.METADADO.Retencao)
				.Table(Propostas.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				cmd.CommandTimeout = 600;
				query.SetParameters(cmd);

				List<Propostas> result = base.MapReaderToEntitySet<Propostas>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(Propostas obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(Propostas.METADADO.DataCriacao, obj.DataCriacao)
				.FieldValue(Propostas.METADADO.DataUltimaAlteracao, obj.DataUltimaAlteracao)
				.FieldValue(Propostas.METADADO.Fase, obj.Fase)
				.FieldValue(Propostas.METADADO.Status, obj.Status)
				.FieldValue(Propostas.METADADO.Usuario, obj.Usuario)
				.FieldValue(Propostas.METADADO.Observacoes, obj.Observacoes)
				.FieldValue(Propostas.METADADO.Gerente, obj.Gerente)
				.FieldValue(Propostas.METADADO.MotivoRecusa, obj.MotivoRecusa)
				.FieldValue(Propostas.METADADO.Promotora, obj.Promotora)
				.FieldValue(Propostas.METADADO.DataAtualizacao, obj.DataAtualizacao)
				.FieldValue(Propostas.METADADO.UsuarioProposta, obj.UsuarioProposta)
				.FieldValue(Propostas.METADADO.ProfissionalCertificado, obj.ProfissionalCertificado)
				.FieldValue(Propostas.METADADO.Pendente, obj.Pendente)
				.FieldValue(Propostas.METADADO.TipoFormalizacao, obj.TipoFormalizacao)
				.FieldValue(Propostas.METADADO.TipoComunicacao, obj.TipoComunicacao)
				.FieldValue(Propostas.METADADO.MensagemInterna, obj.MensagemInterna)
				.FieldValue(Propostas.METADADO.Retencao, obj.Retencao)
				.Table(Propostas.METADADO.tabelaNAME);

			update.Where
				.Add(Propostas.METADADO.Id, Filter.Equal, obj.Id);

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
		public void Incluir(Propostas obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(Propostas.METADADO.tabelaNAME)
				.FieldValue(Propostas.METADADO.DataCriacao, obj.DataCriacao)
				.FieldValue(Propostas.METADADO.DataUltimaAlteracao, obj.DataUltimaAlteracao)
				.FieldValue(Propostas.METADADO.Fase, obj.Fase)
				.FieldValue(Propostas.METADADO.Status, obj.Status)
				.FieldValue(Propostas.METADADO.Usuario, obj.Usuario)
				.FieldValue(Propostas.METADADO.Observacoes, obj.Observacoes)
				.FieldValue(Propostas.METADADO.Gerente, obj.Gerente)
				.FieldValue(Propostas.METADADO.MotivoRecusa, obj.MotivoRecusa)
				.FieldValue(Propostas.METADADO.Promotora, obj.Promotora)
				.FieldValue(Propostas.METADADO.DataAtualizacao, obj.DataAtualizacao)
				.FieldValue(Propostas.METADADO.UsuarioProposta, obj.UsuarioProposta)
				.FieldValue(Propostas.METADADO.ProfissionalCertificado, obj.ProfissionalCertificado)
				.FieldValue(Propostas.METADADO.Pendente, obj.Pendente)
				.FieldValue(Propostas.METADADO.TipoFormalizacao, obj.TipoFormalizacao)
				.FieldValue(Propostas.METADADO.TipoComunicacao, obj.TipoComunicacao)
				.FieldValue(Propostas.METADADO.MensagemInterna, obj.MensagemInterna)
				.FieldValue(Propostas.METADADO.Retencao, obj.Retencao)
				.SetIdentityField(Propostas.METADADO.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, insert.ToString());
				cmd.CommandTimeout = 600;
				insert.SetParameters(cmd);

				obj.Id = base.ExecuteScalar<int?>(cmd);
			}
		}
      #endregion

      #region Desbloquear
      public void Desbloquear(Propostas obj)
      {
         #region UpdateBuilder

         UpdateBuilder update = UpdateBuilder.Create(this)
            .FieldValue(Propostas.METADADO.UsuarioProposta, obj.UsuarioProposta)
            .Table(Propostas.METADADO.tabelaNAME);

         update.Where
            .Add(Propostas.METADADO.Id, Filter.Equal, obj.Id);

         #endregion

         using (IDbConnection connection = base.CreateConnection())
         {
            IDbCommand cmd = base.CreateCommand(connection, update.ToString()); cmd.CommandTimeout = 600;
            cmd.CommandTimeout = 600;
            update.SetParameters(cmd);

            base.ExecuteNonQuery(cmd);
         }
      }
      #endregion

      #region Bloquear
      public void Bloquear(Propostas obj)
      {
         #region UpdateBuilder

         UpdateBuilder update = UpdateBuilder.Create(this)
            .FieldValue(Propostas.METADADO.UsuarioProposta, obj.UsuarioProposta)
            .Table(Propostas.METADADO.tabelaNAME);

         update.Where
            .Add(Propostas.METADADO.Id, Filter.Equal, obj.Id);

         #endregion

         using (IDbConnection connection = base.CreateConnection())
         {
            IDbCommand cmd = base.CreateCommand(connection, update.ToString()); cmd.CommandTimeout = 600;
            cmd.CommandTimeout = 600;
            update.SetParameters(cmd);

            base.ExecuteNonQuery(cmd);
         }
      }
      #endregion

      #region Obtem
      public Propostas Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(Propostas.METADADO.Id)
				.Field(Propostas.METADADO.DataCriacao)
				.Field(Propostas.METADADO.DataUltimaAlteracao)
				.Field(Propostas.METADADO.Fase)
				.Field(Propostas.METADADO.Status)
				.Field(Propostas.METADADO.Usuario)
				.Field(Propostas.METADADO.Observacoes)
				.Field(Propostas.METADADO.Gerente)
				.Field(Propostas.METADADO.MotivoRecusa)
				.Field(Propostas.METADADO.Promotora)
				.Field(Propostas.METADADO.DataAtualizacao)
				.Field(Propostas.METADADO.UsuarioProposta)
				.Field(Propostas.METADADO.ProfissionalCertificado)
				.Field(Propostas.METADADO.Pendente)
				.Field(Propostas.METADADO.TipoFormalizacao)
				.Field(Propostas.METADADO.TipoComunicacao)
				.Field(Propostas.METADADO.MensagemInterna)
				.Field(Propostas.METADADO.Retencao)
				.Table(Propostas.METADADO.tabelaNAME);

			query.Where
				.Add(Propostas.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				cmd.CommandTimeout = 600;
				query.SetParameters(cmd);

				Propostas result = base.MapReaderToEntity<Propostas>(cmd);
				return result;
			}
		}
		#endregion

		#region Excluir por FKs
		public void ExcluirPor_TipoFormalizacao(int? TipoFormalizacao)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(Propostas.METADADO.tabelaNAME);
			delete.Where
				.Add(Propostas.METADADO.TipoFormalizacao, Filter.Equal, TipoFormalizacao);

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
				delete.Table(Propostas.METADADO.tabelaNAME);
			delete.Where
				.Add(Propostas.METADADO.Id, Filter.Equal, Id);

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
