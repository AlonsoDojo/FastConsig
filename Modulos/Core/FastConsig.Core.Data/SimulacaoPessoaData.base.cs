
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
	public partial class SimulacaoPessoaData : DataBase
	{
		
		#region Listar
		public List<SimulacaoPessoa> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(SimulacaoPessoa.METADADO.Id)
				.Field(SimulacaoPessoa.METADADO.CpfCnpj)
				.Field(SimulacaoPessoa.METADADO.Nome)
				.Field(SimulacaoPessoa.METADADO.TipoPessoa)
				.Field(SimulacaoPessoa.METADADO.DataNascimento)
				.Field(SimulacaoPessoa.METADADO.NumeroBeneficio)
				.Field(SimulacaoPessoa.METADADO.DDDCelular)
				.Field(SimulacaoPessoa.METADADO.Celular)
				.Field(SimulacaoPessoa.METADADO.Email)
				.Field(SimulacaoPessoa.METADADO.NumeroBeneficio2)
				.Field(SimulacaoPessoa.METADADO.EspecieBeneficio)
				.Field(SimulacaoPessoa.METADADO.Orgao)
				.Field(SimulacaoPessoa.METADADO.UFBeneficio)
				.Field(SimulacaoPessoa.METADADO.IfPagadora)
				.Field(SimulacaoPessoa.METADADO.AgenciaPagadora)
				.Field(SimulacaoPessoa.METADADO.ContaCorrente)
				.Field(SimulacaoPessoa.METADADO.Simulacao)
				.Field(SimulacaoPessoa.METADADO.IndicadorAnalfabetismo)
				.Field(SimulacaoPessoa.METADADO.ValorRenda)
				.Table(SimulacaoPessoa.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				cmd.CommandTimeout = 600;
				query.SetParameters(cmd);

				List<SimulacaoPessoa> result = base.MapReaderToEntitySet<SimulacaoPessoa>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(SimulacaoPessoa obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(SimulacaoPessoa.METADADO.CpfCnpj, obj.CpfCnpj)
				.FieldValue(SimulacaoPessoa.METADADO.Nome, obj.Nome)
				.FieldValue(SimulacaoPessoa.METADADO.TipoPessoa, obj.TipoPessoa)
				.FieldValue(SimulacaoPessoa.METADADO.DataNascimento, obj.DataNascimento)
				.FieldValue(SimulacaoPessoa.METADADO.NumeroBeneficio, obj.NumeroBeneficio)
				.FieldValue(SimulacaoPessoa.METADADO.DDDCelular, obj.DDDCelular)
				.FieldValue(SimulacaoPessoa.METADADO.Celular, obj.Celular)
				.FieldValue(SimulacaoPessoa.METADADO.Email, obj.Email)
				.FieldValue(SimulacaoPessoa.METADADO.NumeroBeneficio2, obj.NumeroBeneficio2)
				.FieldValue(SimulacaoPessoa.METADADO.EspecieBeneficio, obj.EspecieBeneficio)
				.FieldValue(SimulacaoPessoa.METADADO.Orgao, obj.Orgao)
				.FieldValue(SimulacaoPessoa.METADADO.UFBeneficio, obj.UFBeneficio)
				.FieldValue(SimulacaoPessoa.METADADO.IfPagadora, obj.IfPagadora)
				.FieldValue(SimulacaoPessoa.METADADO.AgenciaPagadora, obj.AgenciaPagadora)
				.FieldValue(SimulacaoPessoa.METADADO.ContaCorrente, obj.ContaCorrente)
				.FieldValue(SimulacaoPessoa.METADADO.Simulacao, obj.Simulacao)
				.FieldValue(SimulacaoPessoa.METADADO.IndicadorAnalfabetismo, obj.IndicadorAnalfabetismo)
				.FieldValue(SimulacaoPessoa.METADADO.ValorRenda, obj.ValorRenda)
				.Table(SimulacaoPessoa.METADADO.tabelaNAME);

			update.Where
				.Add(SimulacaoPessoa.METADADO.Id, Filter.Equal, obj.Id);

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
		public void Incluir(SimulacaoPessoa obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(SimulacaoPessoa.METADADO.tabelaNAME)
				.FieldValue(SimulacaoPessoa.METADADO.CpfCnpj, obj.CpfCnpj)
				.FieldValue(SimulacaoPessoa.METADADO.Nome, obj.Nome)
				.FieldValue(SimulacaoPessoa.METADADO.TipoPessoa, obj.TipoPessoa)
				.FieldValue(SimulacaoPessoa.METADADO.DataNascimento, obj.DataNascimento)
				.FieldValue(SimulacaoPessoa.METADADO.NumeroBeneficio, obj.NumeroBeneficio)
				.FieldValue(SimulacaoPessoa.METADADO.DDDCelular, obj.DDDCelular)
				.FieldValue(SimulacaoPessoa.METADADO.Celular, obj.Celular)
				.FieldValue(SimulacaoPessoa.METADADO.Email, obj.Email)
				.FieldValue(SimulacaoPessoa.METADADO.NumeroBeneficio2, obj.NumeroBeneficio2)
				.FieldValue(SimulacaoPessoa.METADADO.EspecieBeneficio, obj.EspecieBeneficio)
				.FieldValue(SimulacaoPessoa.METADADO.Orgao, obj.Orgao)
				.FieldValue(SimulacaoPessoa.METADADO.UFBeneficio, obj.UFBeneficio)
				.FieldValue(SimulacaoPessoa.METADADO.IfPagadora, obj.IfPagadora)
				.FieldValue(SimulacaoPessoa.METADADO.AgenciaPagadora, obj.AgenciaPagadora)
				.FieldValue(SimulacaoPessoa.METADADO.ContaCorrente, obj.ContaCorrente)
				.FieldValue(SimulacaoPessoa.METADADO.Simulacao, obj.Simulacao)
				.FieldValue(SimulacaoPessoa.METADADO.IndicadorAnalfabetismo, obj.IndicadorAnalfabetismo)
				.FieldValue(SimulacaoPessoa.METADADO.ValorRenda, obj.ValorRenda)
				.SetIdentityField(SimulacaoPessoa.METADADO.Id);

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
		public SimulacaoPessoa Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(SimulacaoPessoa.METADADO.Id)
				.Field(SimulacaoPessoa.METADADO.CpfCnpj)
				.Field(SimulacaoPessoa.METADADO.Nome)
				.Field(SimulacaoPessoa.METADADO.TipoPessoa)
				.Field(SimulacaoPessoa.METADADO.DataNascimento)
				.Field(SimulacaoPessoa.METADADO.NumeroBeneficio)
				.Field(SimulacaoPessoa.METADADO.DDDCelular)
				.Field(SimulacaoPessoa.METADADO.Celular)
				.Field(SimulacaoPessoa.METADADO.Email)
				.Field(SimulacaoPessoa.METADADO.NumeroBeneficio2)
				.Field(SimulacaoPessoa.METADADO.EspecieBeneficio)
				.Field(SimulacaoPessoa.METADADO.Orgao)
				.Field(SimulacaoPessoa.METADADO.UFBeneficio)
				.Field(SimulacaoPessoa.METADADO.IfPagadora)
				.Field(SimulacaoPessoa.METADADO.AgenciaPagadora)
				.Field(SimulacaoPessoa.METADADO.ContaCorrente)
				.Field(SimulacaoPessoa.METADADO.Simulacao)
				.Field(SimulacaoPessoa.METADADO.IndicadorAnalfabetismo)
				.Field(SimulacaoPessoa.METADADO.ValorRenda)
				.Table(SimulacaoPessoa.METADADO.tabelaNAME);

			query.Where
				.Add(SimulacaoPessoa.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				cmd.CommandTimeout = 600;
				query.SetParameters(cmd);

				SimulacaoPessoa result = base.MapReaderToEntity<SimulacaoPessoa>(cmd);
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
				delete.Table(SimulacaoPessoa.METADADO.tabelaNAME);
			delete.Where
				.Add(SimulacaoPessoa.METADADO.Id, Filter.Equal, Id);

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
