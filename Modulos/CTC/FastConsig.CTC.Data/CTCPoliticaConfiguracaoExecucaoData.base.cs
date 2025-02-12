
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
	public partial class CTCPoliticaConfiguracaoExecucaoData : DataBase
	{
		
		#region Listar
		public List<CTCPoliticaConfiguracaoExecucao> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CTCPoliticaConfiguracaoExecucao.METADADO.Id)
				.Field(CTCPoliticaConfiguracaoExecucao.METADADO.TipoArquivo)
				.Field(CTCPoliticaConfiguracaoExecucao.METADADO.TipoPessoa)
				.Field(CTCPoliticaConfiguracaoExecucao.METADADO.Fase)
				.Field(CTCPoliticaConfiguracaoExecucao.METADADO.Politica)
				.Field(CTCPoliticaConfiguracaoExecucao.METADADO.Peso)
				.Field(CTCPoliticaConfiguracaoExecucao.METADADO.Entrada)
				.Field(CTCPoliticaConfiguracaoExecucao.METADADO.Saida)
				.Field(CTCPoliticaConfiguracaoExecucao.METADADO.TipoFluxo)
				.Table(CTCPoliticaConfiguracaoExecucao.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				List<CTCPoliticaConfiguracaoExecucao> result = base.MapReaderToEntitySet<CTCPoliticaConfiguracaoExecucao>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(CTCPoliticaConfiguracaoExecucao obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(CTCPoliticaConfiguracaoExecucao.METADADO.TipoArquivo, obj.TipoArquivo)
				.FieldValue(CTCPoliticaConfiguracaoExecucao.METADADO.TipoPessoa, obj.TipoPessoa)
				.FieldValue(CTCPoliticaConfiguracaoExecucao.METADADO.Fase, obj.Fase)
				.FieldValue(CTCPoliticaConfiguracaoExecucao.METADADO.Politica, obj.Politica)
				.FieldValue(CTCPoliticaConfiguracaoExecucao.METADADO.Peso, obj.Peso)
				.FieldValue(CTCPoliticaConfiguracaoExecucao.METADADO.Entrada, obj.Entrada)
				.FieldValue(CTCPoliticaConfiguracaoExecucao.METADADO.Saida, obj.Saida)
				.FieldValue(CTCPoliticaConfiguracaoExecucao.METADADO.TipoFluxo, obj.TipoFluxo)
				.Table(CTCPoliticaConfiguracaoExecucao.METADADO.tabelaNAME);

			update.Where
				.Add(CTCPoliticaConfiguracaoExecucao.METADADO.Id, Filter.Equal, obj.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, update.ToString());
				update.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

		#region Inserir
		public void Incluir(CTCPoliticaConfiguracaoExecucao obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(CTCPoliticaConfiguracaoExecucao.METADADO.tabelaNAME)
				.FieldValue(CTCPoliticaConfiguracaoExecucao.METADADO.TipoArquivo, obj.TipoArquivo)
				.FieldValue(CTCPoliticaConfiguracaoExecucao.METADADO.TipoPessoa, obj.TipoPessoa)
				.FieldValue(CTCPoliticaConfiguracaoExecucao.METADADO.Fase, obj.Fase)
				.FieldValue(CTCPoliticaConfiguracaoExecucao.METADADO.Politica, obj.Politica)
				.FieldValue(CTCPoliticaConfiguracaoExecucao.METADADO.Peso, obj.Peso)
				.FieldValue(CTCPoliticaConfiguracaoExecucao.METADADO.Entrada, obj.Entrada)
				.FieldValue(CTCPoliticaConfiguracaoExecucao.METADADO.Saida, obj.Saida)
				.FieldValue(CTCPoliticaConfiguracaoExecucao.METADADO.TipoFluxo, obj.TipoFluxo)
				.SetIdentityField(CTCPoliticaConfiguracaoExecucao.METADADO.Id);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, insert.ToString());
				insert.SetParameters(cmd);

				obj.Id = base.ExecuteScalar<int?>(cmd);
			}
		}
		#endregion

		#region Obtem
		public CTCPoliticaConfiguracaoExecucao Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(CTCPoliticaConfiguracaoExecucao.METADADO.Id)
				.Field(CTCPoliticaConfiguracaoExecucao.METADADO.TipoArquivo)
				.Field(CTCPoliticaConfiguracaoExecucao.METADADO.TipoPessoa)
				.Field(CTCPoliticaConfiguracaoExecucao.METADADO.Fase)
				.Field(CTCPoliticaConfiguracaoExecucao.METADADO.Politica)
				.Field(CTCPoliticaConfiguracaoExecucao.METADADO.Peso)
				.Field(CTCPoliticaConfiguracaoExecucao.METADADO.Entrada)
				.Field(CTCPoliticaConfiguracaoExecucao.METADADO.Saida)
				.Field(CTCPoliticaConfiguracaoExecucao.METADADO.TipoFluxo)
				.Table(CTCPoliticaConfiguracaoExecucao.METADADO.tabelaNAME);

			query.Where
				.Add(CTCPoliticaConfiguracaoExecucao.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				query.SetParameters(cmd);

				CTCPoliticaConfiguracaoExecucao result = base.MapReaderToEntity<CTCPoliticaConfiguracaoExecucao>(cmd);
				return result;
			}
		}
		#endregion

		#region Excluir por FKs
		public void ExcluirPor_TipoArquivo(int? TipoArquivo)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(CTCPoliticaConfiguracaoExecucao.METADADO.tabelaNAME);
			delete.Where
				.Add(CTCPoliticaConfiguracaoExecucao.METADADO.TipoArquivo, Filter.Equal, TipoArquivo);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, delete.ToString());
				delete.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		public void ExcluirPor_TipoPessoa(int? TipoPessoa)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(CTCPoliticaConfiguracaoExecucao.METADADO.tabelaNAME);
			delete.Where
				.Add(CTCPoliticaConfiguracaoExecucao.METADADO.TipoPessoa, Filter.Equal, TipoPessoa);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, delete.ToString());
				delete.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		public void ExcluirPor_Fase(int? Fase)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(CTCPoliticaConfiguracaoExecucao.METADADO.tabelaNAME);
			delete.Where
				.Add(CTCPoliticaConfiguracaoExecucao.METADADO.Fase, Filter.Equal, Fase);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, delete.ToString());
				delete.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		public void ExcluirPor_Politica(int? Politica)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(CTCPoliticaConfiguracaoExecucao.METADADO.tabelaNAME);
			delete.Where
				.Add(CTCPoliticaConfiguracaoExecucao.METADADO.Politica, Filter.Equal, Politica);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, delete.ToString());
				delete.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		public void ExcluirPor_TipoFluxo(int? TipoFluxo)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(CTCPoliticaConfiguracaoExecucao.METADADO.tabelaNAME);
			delete.Where
				.Add(CTCPoliticaConfiguracaoExecucao.METADADO.TipoFluxo, Filter.Equal, TipoFluxo);

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
				delete.Table(CTCPoliticaConfiguracaoExecucao.METADADO.tabelaNAME);
			delete.Where
				.Add(CTCPoliticaConfiguracaoExecucao.METADADO.Id, Filter.Equal, Id);

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
