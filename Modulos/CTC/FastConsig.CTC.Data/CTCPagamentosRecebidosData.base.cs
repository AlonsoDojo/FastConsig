
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
	public partial class CTCPagamentosRecebidosData : DataBase
	{
		
		#region Listar
		public List<CTCPagamentosRecebidos> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CTCPagamentosRecebidos.METADADO.Id)
				.Field(CTCPagamentosRecebidos.METADADO.Evento)
				.Field(CTCPagamentosRecebidos.METADADO.NumeroControle)
				.Field(CTCPagamentosRecebidos.METADADO.DataBACEN)
				.Field(CTCPagamentosRecebidos.METADADO.ISPBDebitado)
				.Field(CTCPagamentosRecebidos.METADADO.AgenciaDebitada)
				.Field(CTCPagamentosRecebidos.METADADO.ContaDebitada)
				.Field(CTCPagamentosRecebidos.METADADO.CNPJDebitado)
				.Field(CTCPagamentosRecebidos.METADADO.NomeClienteDebitado)
				.Field(CTCPagamentosRecebidos.METADADO.ISPBCreditado)
				.Field(CTCPagamentosRecebidos.METADADO.AgenciaCreditada)
				.Field(CTCPagamentosRecebidos.METADADO.ContaCreditada)
				.Field(CTCPagamentosRecebidos.METADADO.CNPJCreditado)
				.Field(CTCPagamentosRecebidos.METADADO.NomeClienteCreditado)
				.Field(CTCPagamentosRecebidos.METADADO.ValorLancamento)
				.Field(CTCPagamentosRecebidos.METADADO.ISPBPrestador)
				.Field(CTCPagamentosRecebidos.METADADO.DataMovimento)
				.Field(CTCPagamentosRecebidos.METADADO.NUPortabilidade)
				.Field(CTCPagamentosRecebidos.METADADO.Acatado)
				.Field(CTCPagamentosRecebidos.METADADO.Conciliado)
				.Field(CTCPagamentosRecebidos.METADADO.Devolvido)
				.Field(CTCPagamentosRecebidos.METADADO.UsuarioAcatador)
				.Field(CTCPagamentosRecebidos.METADADO.UsuarioDevolucao)
				.Field(CTCPagamentosRecebidos.METADADO.DataAcatamento)
				.Field(CTCPagamentosRecebidos.METADADO.DataDevolucao)
				.Field(CTCPagamentosRecebidos.METADADO.Devolucao)
				.Field(CTCPagamentosRecebidos.METADADO.Requisicao)
				.Table(CTCPagamentosRecebidos.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				List<CTCPagamentosRecebidos> result = base.MapReaderToEntitySet<CTCPagamentosRecebidos>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(CTCPagamentosRecebidos obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(CTCPagamentosRecebidos.METADADO.Evento, obj.Evento)
				.FieldValue(CTCPagamentosRecebidos.METADADO.NumeroControle, obj.NumeroControle)
				.FieldValue(CTCPagamentosRecebidos.METADADO.DataBACEN, obj.DataBACEN)
				.FieldValue(CTCPagamentosRecebidos.METADADO.ISPBDebitado, obj.ISPBDebitado)
				.FieldValue(CTCPagamentosRecebidos.METADADO.AgenciaDebitada, obj.AgenciaDebitada)
				.FieldValue(CTCPagamentosRecebidos.METADADO.ContaDebitada, obj.ContaDebitada)
				.FieldValue(CTCPagamentosRecebidos.METADADO.CNPJDebitado, obj.CNPJDebitado)
				.FieldValue(CTCPagamentosRecebidos.METADADO.NomeClienteDebitado, obj.NomeClienteDebitado)
				.FieldValue(CTCPagamentosRecebidos.METADADO.ISPBCreditado, obj.ISPBCreditado)
				.FieldValue(CTCPagamentosRecebidos.METADADO.AgenciaCreditada, obj.AgenciaCreditada)
				.FieldValue(CTCPagamentosRecebidos.METADADO.ContaCreditada, obj.ContaCreditada)
				.FieldValue(CTCPagamentosRecebidos.METADADO.CNPJCreditado, obj.CNPJCreditado)
				.FieldValue(CTCPagamentosRecebidos.METADADO.NomeClienteCreditado, obj.NomeClienteCreditado)
				.FieldValue(CTCPagamentosRecebidos.METADADO.ValorLancamento, obj.ValorLancamento)
				.FieldValue(CTCPagamentosRecebidos.METADADO.ISPBPrestador, obj.ISPBPrestador)
				.FieldValue(CTCPagamentosRecebidos.METADADO.DataMovimento, obj.DataMovimento)
				.FieldValue(CTCPagamentosRecebidos.METADADO.NUPortabilidade, obj.NUPortabilidade)
				.FieldValue(CTCPagamentosRecebidos.METADADO.Acatado, obj.Acatado)
				.FieldValue(CTCPagamentosRecebidos.METADADO.Conciliado, obj.Conciliado)
				.FieldValue(CTCPagamentosRecebidos.METADADO.Devolvido, obj.Devolvido)
				.FieldValue(CTCPagamentosRecebidos.METADADO.UsuarioAcatador, obj.UsuarioAcatador)
				.FieldValue(CTCPagamentosRecebidos.METADADO.UsuarioDevolucao, obj.UsuarioDevolucao)
				.FieldValue(CTCPagamentosRecebidos.METADADO.DataAcatamento, obj.DataAcatamento)
				.FieldValue(CTCPagamentosRecebidos.METADADO.DataDevolucao, obj.DataDevolucao)
				.FieldValue(CTCPagamentosRecebidos.METADADO.Devolucao, obj.Devolucao)
				.FieldValue(CTCPagamentosRecebidos.METADADO.Requisicao, obj.Requisicao)
				.Table(CTCPagamentosRecebidos.METADADO.tabelaNAME);

			update.Where
				.Add(CTCPagamentosRecebidos.METADADO.Id, Filter.Equal, obj.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, update.ToString());
				update.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

		#region Inserir
		public void Incluir(CTCPagamentosRecebidos obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(CTCPagamentosRecebidos.METADADO.tabelaNAME)
				.FieldValue(CTCPagamentosRecebidos.METADADO.Evento, obj.Evento)
				.FieldValue(CTCPagamentosRecebidos.METADADO.NumeroControle, obj.NumeroControle)
				.FieldValue(CTCPagamentosRecebidos.METADADO.DataBACEN, obj.DataBACEN)
				.FieldValue(CTCPagamentosRecebidos.METADADO.ISPBDebitado, obj.ISPBDebitado)
				.FieldValue(CTCPagamentosRecebidos.METADADO.AgenciaDebitada, obj.AgenciaDebitada)
				.FieldValue(CTCPagamentosRecebidos.METADADO.ContaDebitada, obj.ContaDebitada)
				.FieldValue(CTCPagamentosRecebidos.METADADO.CNPJDebitado, obj.CNPJDebitado)
				.FieldValue(CTCPagamentosRecebidos.METADADO.NomeClienteDebitado, obj.NomeClienteDebitado)
				.FieldValue(CTCPagamentosRecebidos.METADADO.ISPBCreditado, obj.ISPBCreditado)
				.FieldValue(CTCPagamentosRecebidos.METADADO.AgenciaCreditada, obj.AgenciaCreditada)
				.FieldValue(CTCPagamentosRecebidos.METADADO.ContaCreditada, obj.ContaCreditada)
				.FieldValue(CTCPagamentosRecebidos.METADADO.CNPJCreditado, obj.CNPJCreditado)
				.FieldValue(CTCPagamentosRecebidos.METADADO.NomeClienteCreditado, obj.NomeClienteCreditado)
				.FieldValue(CTCPagamentosRecebidos.METADADO.ValorLancamento, obj.ValorLancamento)
				.FieldValue(CTCPagamentosRecebidos.METADADO.ISPBPrestador, obj.ISPBPrestador)
				.FieldValue(CTCPagamentosRecebidos.METADADO.DataMovimento, obj.DataMovimento)
				.FieldValue(CTCPagamentosRecebidos.METADADO.NUPortabilidade, obj.NUPortabilidade)
				.FieldValue(CTCPagamentosRecebidos.METADADO.Acatado, obj.Acatado)
				.FieldValue(CTCPagamentosRecebidos.METADADO.Conciliado, obj.Conciliado)
				.FieldValue(CTCPagamentosRecebidos.METADADO.Devolvido, obj.Devolvido)
				.FieldValue(CTCPagamentosRecebidos.METADADO.UsuarioAcatador, obj.UsuarioAcatador)
				.FieldValue(CTCPagamentosRecebidos.METADADO.UsuarioDevolucao, obj.UsuarioDevolucao)
				.FieldValue(CTCPagamentosRecebidos.METADADO.DataAcatamento, obj.DataAcatamento)
				.FieldValue(CTCPagamentosRecebidos.METADADO.DataDevolucao, obj.DataDevolucao)
				.FieldValue(CTCPagamentosRecebidos.METADADO.Devolucao, obj.Devolucao)
				.FieldValue(CTCPagamentosRecebidos.METADADO.Requisicao, obj.Requisicao)
				.SetIdentityField(CTCPagamentosRecebidos.METADADO.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, insert.ToString());
				insert.SetParameters(cmd);

				obj.Id = base.ExecuteScalar<int?>(cmd);
			}
		}
		#endregion

		#region Obtem
		public CTCPagamentosRecebidos Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CTCPagamentosRecebidos.METADADO.Id)
				.Field(CTCPagamentosRecebidos.METADADO.Evento)
				.Field(CTCPagamentosRecebidos.METADADO.NumeroControle)
				.Field(CTCPagamentosRecebidos.METADADO.DataBACEN)
				.Field(CTCPagamentosRecebidos.METADADO.ISPBDebitado)
				.Field(CTCPagamentosRecebidos.METADADO.AgenciaDebitada)
				.Field(CTCPagamentosRecebidos.METADADO.ContaDebitada)
				.Field(CTCPagamentosRecebidos.METADADO.CNPJDebitado)
				.Field(CTCPagamentosRecebidos.METADADO.NomeClienteDebitado)
				.Field(CTCPagamentosRecebidos.METADADO.ISPBCreditado)
				.Field(CTCPagamentosRecebidos.METADADO.AgenciaCreditada)
				.Field(CTCPagamentosRecebidos.METADADO.ContaCreditada)
				.Field(CTCPagamentosRecebidos.METADADO.CNPJCreditado)
				.Field(CTCPagamentosRecebidos.METADADO.NomeClienteCreditado)
				.Field(CTCPagamentosRecebidos.METADADO.ValorLancamento)
				.Field(CTCPagamentosRecebidos.METADADO.ISPBPrestador)
				.Field(CTCPagamentosRecebidos.METADADO.DataMovimento)
				.Field(CTCPagamentosRecebidos.METADADO.NUPortabilidade)
				.Field(CTCPagamentosRecebidos.METADADO.Acatado)
				.Field(CTCPagamentosRecebidos.METADADO.Conciliado)
				.Field(CTCPagamentosRecebidos.METADADO.Devolvido)
				.Field(CTCPagamentosRecebidos.METADADO.UsuarioAcatador)
				.Field(CTCPagamentosRecebidos.METADADO.UsuarioDevolucao)
				.Field(CTCPagamentosRecebidos.METADADO.DataAcatamento)
				.Field(CTCPagamentosRecebidos.METADADO.DataDevolucao)
				.Field(CTCPagamentosRecebidos.METADADO.Devolucao)
				.Field(CTCPagamentosRecebidos.METADADO.Requisicao)
				.Table(CTCPagamentosRecebidos.METADADO.tabelaNAME);

			query.Where
				.Add(CTCPagamentosRecebidos.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				CTCPagamentosRecebidos result = base.MapReaderToEntity<CTCPagamentosRecebidos>(cmd);
				return result;
			}
		}
		#endregion

		#region Excluir por FKs
		public void ExcluirPor_Requisicao(int? Requisicao)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(CTCPagamentosRecebidos.METADADO.tabelaNAME);
			delete.Where
				.Add(CTCPagamentosRecebidos.METADADO.Requisicao, Filter.Equal, Requisicao);

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
				delete.Table(CTCPagamentosRecebidos.METADADO.tabelaNAME);
			delete.Where
				.Add(CTCPagamentosRecebidos.METADADO.Id, Filter.Equal, Id);

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
