
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
	public partial class AutorizacaoDigitalConsignadoData : DataBase
	{
		
		#region Listar
		public List<AutorizacaoDigitalConsignado> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(AutorizacaoDigitalConsignado.METADADO.Id)
				.Field(AutorizacaoDigitalConsignado.METADADO.Cpf)
				.Field(AutorizacaoDigitalConsignado.METADADO.TipoComunicacao)
				.Field(AutorizacaoDigitalConsignado.METADADO.Finalizado)
				.Field(AutorizacaoDigitalConsignado.METADADO.DDD)
				.Field(AutorizacaoDigitalConsignado.METADADO.Celular)
				.Field(AutorizacaoDigitalConsignado.METADADO.DataHoraInicio)
				.Field(AutorizacaoDigitalConsignado.METADADO.DataHoraFim)
				.Field(AutorizacaoDigitalConsignado.METADADO.NomeMae)
				.Field(AutorizacaoDigitalConsignado.METADADO.DataNascimento)
				.Field(AutorizacaoDigitalConsignado.METADADO.Nome)
				.Field(AutorizacaoDigitalConsignado.METADADO.Consulta)
				.Field(AutorizacaoDigitalConsignado.METADADO.Simulacao)
				.Table(AutorizacaoDigitalConsignado.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				cmd.CommandTimeout = 600;
				query.SetParameters(cmd);

				List<AutorizacaoDigitalConsignado> result = base.MapReaderToEntitySet<AutorizacaoDigitalConsignado>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(AutorizacaoDigitalConsignado obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(AutorizacaoDigitalConsignado.METADADO.Cpf, obj.Cpf)
				.FieldValue(AutorizacaoDigitalConsignado.METADADO.TipoComunicacao, obj.TipoComunicacao)
				.FieldValue(AutorizacaoDigitalConsignado.METADADO.Finalizado, obj.Finalizado)
				.FieldValue(AutorizacaoDigitalConsignado.METADADO.DDD, obj.DDD)
				.FieldValue(AutorizacaoDigitalConsignado.METADADO.Celular, obj.Celular)
				.FieldValue(AutorizacaoDigitalConsignado.METADADO.DataHoraInicio, obj.DataHoraInicio)
				.FieldValue(AutorizacaoDigitalConsignado.METADADO.DataHoraFim, obj.DataHoraFim)
				.FieldValue(AutorizacaoDigitalConsignado.METADADO.NomeMae, obj.NomeMae)
				.FieldValue(AutorizacaoDigitalConsignado.METADADO.DataNascimento, obj.DataNascimento)
				.FieldValue(AutorizacaoDigitalConsignado.METADADO.Nome, obj.Nome)
				.FieldValue(AutorizacaoDigitalConsignado.METADADO.Consulta, obj.Consulta)
				.FieldValue(AutorizacaoDigitalConsignado.METADADO.Simulacao, obj.Simulacao)
				.Table(AutorizacaoDigitalConsignado.METADADO.tabelaNAME);

			update.Where
				.Add(AutorizacaoDigitalConsignado.METADADO.Id, Filter.Equal, obj.Id);

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
		public void Incluir(AutorizacaoDigitalConsignado obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(AutorizacaoDigitalConsignado.METADADO.tabelaNAME)
				.FieldValue(AutorizacaoDigitalConsignado.METADADO.Cpf, obj.Cpf)
				.FieldValue(AutorizacaoDigitalConsignado.METADADO.TipoComunicacao, obj.TipoComunicacao)
				.FieldValue(AutorizacaoDigitalConsignado.METADADO.Finalizado, obj.Finalizado)
				.FieldValue(AutorizacaoDigitalConsignado.METADADO.DDD, obj.DDD)
				.FieldValue(AutorizacaoDigitalConsignado.METADADO.Celular, obj.Celular)
				.FieldValue(AutorizacaoDigitalConsignado.METADADO.DataHoraInicio, obj.DataHoraInicio)
				.FieldValue(AutorizacaoDigitalConsignado.METADADO.DataHoraFim, obj.DataHoraFim)
				.FieldValue(AutorizacaoDigitalConsignado.METADADO.NomeMae, obj.NomeMae)
				.FieldValue(AutorizacaoDigitalConsignado.METADADO.DataNascimento, obj.DataNascimento)
				.FieldValue(AutorizacaoDigitalConsignado.METADADO.Nome, obj.Nome)
				.FieldValue(AutorizacaoDigitalConsignado.METADADO.Consulta, obj.Consulta)
				.FieldValue(AutorizacaoDigitalConsignado.METADADO.Simulacao, obj.Simulacao)
				.SetIdentityField(AutorizacaoDigitalConsignado.METADADO.Id);

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
		public AutorizacaoDigitalConsignado Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(AutorizacaoDigitalConsignado.METADADO.Id)
				.Field(AutorizacaoDigitalConsignado.METADADO.Cpf)
				.Field(AutorizacaoDigitalConsignado.METADADO.TipoComunicacao)
				.Field(AutorizacaoDigitalConsignado.METADADO.Finalizado)
				.Field(AutorizacaoDigitalConsignado.METADADO.DDD)
				.Field(AutorizacaoDigitalConsignado.METADADO.Celular)
				.Field(AutorizacaoDigitalConsignado.METADADO.DataHoraInicio)
				.Field(AutorizacaoDigitalConsignado.METADADO.DataHoraFim)
				.Field(AutorizacaoDigitalConsignado.METADADO.NomeMae)
				.Field(AutorizacaoDigitalConsignado.METADADO.DataNascimento)
				.Field(AutorizacaoDigitalConsignado.METADADO.Nome)
				.Field(AutorizacaoDigitalConsignado.METADADO.Consulta)
				.Field(AutorizacaoDigitalConsignado.METADADO.Simulacao)
				.Table(AutorizacaoDigitalConsignado.METADADO.tabelaNAME);

			query.Where
				.Add(AutorizacaoDigitalConsignado.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				cmd.CommandTimeout = 600;
				query.SetParameters(cmd);

				AutorizacaoDigitalConsignado result = base.MapReaderToEntity<AutorizacaoDigitalConsignado>(cmd);
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
				delete.Table(AutorizacaoDigitalConsignado.METADADO.tabelaNAME);
			delete.Where
				.Add(AutorizacaoDigitalConsignado.METADADO.Id, Filter.Equal, Id);

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
