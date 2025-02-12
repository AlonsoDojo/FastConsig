
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
	public partial class PessoasData : DataBase
	{
		
		#region Listar
		public List<Pessoas> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(Pessoas.METADADO.Id)
				.Field(Pessoas.METADADO.CpfCnpj)
				.Field(Pessoas.METADADO.Nome)
				.Field(Pessoas.METADADO.TipoPessoa)
				.Field(Pessoas.METADADO.DataNascimento)
				.Field(Pessoas.METADADO.Nacionalidade)
				.Field(Pessoas.METADADO.Naturalidade)
				.Field(Pessoas.METADADO.Sexo)
				.Field(Pessoas.METADADO.EstadoCivil)
				.Field(Pessoas.METADADO.Pis)
				.Field(Pessoas.METADADO.TipoDocumentoIdentidade)
				.Field(Pessoas.METADADO.NumeroDocumentoIdentidade)
				.Field(Pessoas.METADADO.OrgaoEmissor)
				.Field(Pessoas.METADADO.UFEmissaoDocumentoIdentidade)
				.Field(Pessoas.METADADO.DataEmissaoDocumentoIdentidade)
				.Field(Pessoas.METADADO.Mae)
				.Field(Pessoas.METADADO.Pai)
				.Field(Pessoas.METADADO.Conjuge)
				.Field(Pessoas.METADADO.CBO)
				.Field(Pessoas.METADADO.DDDResidencial)
				.Field(Pessoas.METADADO.TelefoneResidencial)
				.Field(Pessoas.METADADO.DDDCelular)
				.Field(Pessoas.METADADO.Celular)
				.Field(Pessoas.METADADO.DDDRecado)
				.Field(Pessoas.METADADO.TelefoneRecado)
				.Field(Pessoas.METADADO.Email)
				.Field(Pessoas.METADADO.PPE)
				.Field(Pessoas.METADADO.CEPResidencial)
				.Field(Pessoas.METADADO.EnderecoResidencial)
				.Field(Pessoas.METADADO.NumeroResidencial)
				.Field(Pessoas.METADADO.ComplementoResidencial)
				.Field(Pessoas.METADADO.BairroResidencial)
				.Field(Pessoas.METADADO.CidadeResidencial)
				.Field(Pessoas.METADADO.EstadoResidencial)
				.Field(Pessoas.METADADO.TempoResidenciaAnos)
				.Field(Pessoas.METADADO.TempoResidenciaMeses)
				.Field(Pessoas.METADADO.TempoResidenciaAnteriorAnos)
				.Field(Pessoas.METADADO.TempoResidenciaAnteriorMeses)
				.Field(Pessoas.METADADO.CEPComercial)
				.Field(Pessoas.METADADO.EnderecoComercial)
				.Field(Pessoas.METADADO.NumeroComercial)
				.Field(Pessoas.METADADO.ComplementoComercial)
				.Field(Pessoas.METADADO.BairroComercial)
				.Field(Pessoas.METADADO.CidadeComercial)
				.Field(Pessoas.METADADO.UFComercial)
				.Field(Pessoas.METADADO.Empresa)
				.Field(Pessoas.METADADO.Cargo)
				.Field(Pessoas.METADADO.DDDComercial)
				.Field(Pessoas.METADADO.TelefoneComercial)
				.Field(Pessoas.METADADO.CnpjEmpresa)
				.Field(Pessoas.METADADO.NomeEmpresa)
				.Field(Pessoas.METADADO.ValorRenda)
				.Field(Pessoas.METADADO.ValorOutrasRendas)
				.Field(Pessoas.METADADO.NumeroBeneficio)
				.Field(Pessoas.METADADO.NumeroBeneficio2)
				.Field(Pessoas.METADADO.EspecieBeneficio)
				.Field(Pessoas.METADADO.Orgao)
				.Field(Pessoas.METADADO.UFBeneficio)
				.Field(Pessoas.METADADO.IfPagadora)
				.Field(Pessoas.METADADO.AgenciaPagadora)
				.Field(Pessoas.METADADO.ContaCorrente)
				.Field(Pessoas.METADADO.IndicadorAnalfabetismo)
				.Table(Pessoas.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				cmd.CommandTimeout = 600;
				query.SetParameters(cmd);

				List<Pessoas> result = base.MapReaderToEntitySet<Pessoas>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(Pessoas obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(Pessoas.METADADO.CpfCnpj, obj.CpfCnpj)
				.FieldValue(Pessoas.METADADO.Nome, obj.Nome)
				.FieldValue(Pessoas.METADADO.TipoPessoa, obj.TipoPessoa)
				.FieldValue(Pessoas.METADADO.DataNascimento, obj.DataNascimento)
				.FieldValue(Pessoas.METADADO.Nacionalidade, obj.Nacionalidade)
				.FieldValue(Pessoas.METADADO.Naturalidade, obj.Naturalidade)
				.FieldValue(Pessoas.METADADO.Sexo, obj.Sexo)
				.FieldValue(Pessoas.METADADO.EstadoCivil, obj.EstadoCivil)
				.FieldValue(Pessoas.METADADO.Pis, obj.Pis)
				.FieldValue(Pessoas.METADADO.TipoDocumentoIdentidade, obj.TipoDocumentoIdentidade)
				.FieldValue(Pessoas.METADADO.NumeroDocumentoIdentidade, obj.NumeroDocumentoIdentidade)
				.FieldValue(Pessoas.METADADO.OrgaoEmissor, obj.OrgaoEmissor)
				.FieldValue(Pessoas.METADADO.UFEmissaoDocumentoIdentidade, obj.UFEmissaoDocumentoIdentidade)
				.FieldValue(Pessoas.METADADO.DataEmissaoDocumentoIdentidade, obj.DataEmissaoDocumentoIdentidade)
				.FieldValue(Pessoas.METADADO.Mae, obj.Mae)
				.FieldValue(Pessoas.METADADO.Pai, obj.Pai)
				.FieldValue(Pessoas.METADADO.Conjuge, obj.Conjuge)
				.FieldValue(Pessoas.METADADO.CBO, obj.CBO)
				.FieldValue(Pessoas.METADADO.DDDResidencial, obj.DDDResidencial)
				.FieldValue(Pessoas.METADADO.TelefoneResidencial, obj.TelefoneResidencial)
				.FieldValue(Pessoas.METADADO.DDDCelular, obj.DDDCelular)
				.FieldValue(Pessoas.METADADO.Celular, obj.Celular)
				.FieldValue(Pessoas.METADADO.DDDRecado, obj.DDDRecado)
				.FieldValue(Pessoas.METADADO.TelefoneRecado, obj.TelefoneRecado)
				.FieldValue(Pessoas.METADADO.Email, obj.Email)
				.FieldValue(Pessoas.METADADO.PPE, obj.PPE)
				.FieldValue(Pessoas.METADADO.CEPResidencial, obj.CEPResidencial)
				.FieldValue(Pessoas.METADADO.EnderecoResidencial, obj.EnderecoResidencial)
				.FieldValue(Pessoas.METADADO.NumeroResidencial, obj.NumeroResidencial)
				.FieldValue(Pessoas.METADADO.ComplementoResidencial, obj.ComplementoResidencial)
				.FieldValue(Pessoas.METADADO.BairroResidencial, obj.BairroResidencial)
				.FieldValue(Pessoas.METADADO.CidadeResidencial, obj.CidadeResidencial)
				.FieldValue(Pessoas.METADADO.EstadoResidencial, obj.EstadoResidencial)
				.FieldValue(Pessoas.METADADO.TempoResidenciaAnos, obj.TempoResidenciaAnos)
				.FieldValue(Pessoas.METADADO.TempoResidenciaMeses, obj.TempoResidenciaMeses)
				.FieldValue(Pessoas.METADADO.TempoResidenciaAnteriorAnos, obj.TempoResidenciaAnteriorAnos)
				.FieldValue(Pessoas.METADADO.TempoResidenciaAnteriorMeses, obj.TempoResidenciaAnteriorMeses)
				.FieldValue(Pessoas.METADADO.CEPComercial, obj.CEPComercial)
				.FieldValue(Pessoas.METADADO.EnderecoComercial, obj.EnderecoComercial)
				.FieldValue(Pessoas.METADADO.NumeroComercial, obj.NumeroComercial)
				.FieldValue(Pessoas.METADADO.ComplementoComercial, obj.ComplementoComercial)
				.FieldValue(Pessoas.METADADO.BairroComercial, obj.BairroComercial)
				.FieldValue(Pessoas.METADADO.CidadeComercial, obj.CidadeComercial)
				.FieldValue(Pessoas.METADADO.UFComercial, obj.UFComercial)
				.FieldValue(Pessoas.METADADO.Empresa, obj.Empresa)
				.FieldValue(Pessoas.METADADO.Cargo, obj.Cargo)
				.FieldValue(Pessoas.METADADO.DDDComercial, obj.DDDComercial)
				.FieldValue(Pessoas.METADADO.TelefoneComercial, obj.TelefoneComercial)
				.FieldValue(Pessoas.METADADO.CnpjEmpresa, obj.CnpjEmpresa)
				.FieldValue(Pessoas.METADADO.NomeEmpresa, obj.NomeEmpresa)
				.FieldValue(Pessoas.METADADO.ValorRenda, obj.ValorRenda)
				.FieldValue(Pessoas.METADADO.ValorOutrasRendas, obj.ValorOutrasRendas)
				.FieldValue(Pessoas.METADADO.NumeroBeneficio, obj.NumeroBeneficio)
				.FieldValue(Pessoas.METADADO.NumeroBeneficio2, obj.NumeroBeneficio2)
				.FieldValue(Pessoas.METADADO.EspecieBeneficio, obj.EspecieBeneficio)
				.FieldValue(Pessoas.METADADO.Orgao, obj.Orgao)
				.FieldValue(Pessoas.METADADO.UFBeneficio, obj.UFBeneficio)
				.FieldValue(Pessoas.METADADO.IfPagadora, obj.IfPagadora)
				.FieldValue(Pessoas.METADADO.AgenciaPagadora, obj.AgenciaPagadora)
				.FieldValue(Pessoas.METADADO.ContaCorrente, obj.ContaCorrente)
				.FieldValue(Pessoas.METADADO.IndicadorAnalfabetismo, obj.IndicadorAnalfabetismo)
				.Table(Pessoas.METADADO.tabelaNAME);

			update.Where
				.Add(Pessoas.METADADO.Id, Filter.Equal, obj.Id);

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
		public void Incluir(Pessoas obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.Table(Pessoas.METADADO.tabelaNAME)
				.FieldValue(Pessoas.METADADO.Id, obj.Id)
				.FieldValue(Pessoas.METADADO.CpfCnpj, obj.CpfCnpj)
				.FieldValue(Pessoas.METADADO.Nome, obj.Nome)
				.FieldValue(Pessoas.METADADO.TipoPessoa, obj.TipoPessoa)
				.FieldValue(Pessoas.METADADO.DataNascimento, obj.DataNascimento)
				.FieldValue(Pessoas.METADADO.Nacionalidade, obj.Nacionalidade)
				.FieldValue(Pessoas.METADADO.Naturalidade, obj.Naturalidade)
				.FieldValue(Pessoas.METADADO.Sexo, obj.Sexo)
				.FieldValue(Pessoas.METADADO.EstadoCivil, obj.EstadoCivil)
				.FieldValue(Pessoas.METADADO.Pis, obj.Pis)
				.FieldValue(Pessoas.METADADO.TipoDocumentoIdentidade, obj.TipoDocumentoIdentidade)
				.FieldValue(Pessoas.METADADO.NumeroDocumentoIdentidade, obj.NumeroDocumentoIdentidade)
				.FieldValue(Pessoas.METADADO.OrgaoEmissor, obj.OrgaoEmissor)
				.FieldValue(Pessoas.METADADO.UFEmissaoDocumentoIdentidade, obj.UFEmissaoDocumentoIdentidade)
				.FieldValue(Pessoas.METADADO.DataEmissaoDocumentoIdentidade, obj.DataEmissaoDocumentoIdentidade)
				.FieldValue(Pessoas.METADADO.Mae, obj.Mae)
				.FieldValue(Pessoas.METADADO.Pai, obj.Pai)
				.FieldValue(Pessoas.METADADO.Conjuge, obj.Conjuge)
				.FieldValue(Pessoas.METADADO.CBO, obj.CBO)
				.FieldValue(Pessoas.METADADO.DDDResidencial, obj.DDDResidencial)
				.FieldValue(Pessoas.METADADO.TelefoneResidencial, obj.TelefoneResidencial)
				.FieldValue(Pessoas.METADADO.DDDCelular, obj.DDDCelular)
				.FieldValue(Pessoas.METADADO.Celular, obj.Celular)
				.FieldValue(Pessoas.METADADO.DDDRecado, obj.DDDRecado)
				.FieldValue(Pessoas.METADADO.TelefoneRecado, obj.TelefoneRecado)
				.FieldValue(Pessoas.METADADO.Email, obj.Email)
				.FieldValue(Pessoas.METADADO.PPE, obj.PPE)
				.FieldValue(Pessoas.METADADO.CEPResidencial, obj.CEPResidencial)
				.FieldValue(Pessoas.METADADO.EnderecoResidencial, obj.EnderecoResidencial)
				.FieldValue(Pessoas.METADADO.NumeroResidencial, obj.NumeroResidencial)
				.FieldValue(Pessoas.METADADO.ComplementoResidencial, obj.ComplementoResidencial)
				.FieldValue(Pessoas.METADADO.BairroResidencial, obj.BairroResidencial)
				.FieldValue(Pessoas.METADADO.CidadeResidencial, obj.CidadeResidencial)
				.FieldValue(Pessoas.METADADO.EstadoResidencial, obj.EstadoResidencial)
				.FieldValue(Pessoas.METADADO.TempoResidenciaAnos, obj.TempoResidenciaAnos)
				.FieldValue(Pessoas.METADADO.TempoResidenciaMeses, obj.TempoResidenciaMeses)
				.FieldValue(Pessoas.METADADO.TempoResidenciaAnteriorAnos, obj.TempoResidenciaAnteriorAnos)
				.FieldValue(Pessoas.METADADO.TempoResidenciaAnteriorMeses, obj.TempoResidenciaAnteriorMeses)
				.FieldValue(Pessoas.METADADO.CEPComercial, obj.CEPComercial)
				.FieldValue(Pessoas.METADADO.EnderecoComercial, obj.EnderecoComercial)
				.FieldValue(Pessoas.METADADO.NumeroComercial, obj.NumeroComercial)
				.FieldValue(Pessoas.METADADO.ComplementoComercial, obj.ComplementoComercial)
				.FieldValue(Pessoas.METADADO.BairroComercial, obj.BairroComercial)
				.FieldValue(Pessoas.METADADO.CidadeComercial, obj.CidadeComercial)
				.FieldValue(Pessoas.METADADO.UFComercial, obj.UFComercial)
				.FieldValue(Pessoas.METADADO.Empresa, obj.Empresa)
				.FieldValue(Pessoas.METADADO.Cargo, obj.Cargo)
				.FieldValue(Pessoas.METADADO.DDDComercial, obj.DDDComercial)
				.FieldValue(Pessoas.METADADO.TelefoneComercial, obj.TelefoneComercial)
				.FieldValue(Pessoas.METADADO.CnpjEmpresa, obj.CnpjEmpresa)
				.FieldValue(Pessoas.METADADO.NomeEmpresa, obj.NomeEmpresa)
				.FieldValue(Pessoas.METADADO.ValorRenda, obj.ValorRenda)
				.FieldValue(Pessoas.METADADO.ValorOutrasRendas, obj.ValorOutrasRendas)
				.FieldValue(Pessoas.METADADO.NumeroBeneficio, obj.NumeroBeneficio)
				.FieldValue(Pessoas.METADADO.NumeroBeneficio2, obj.NumeroBeneficio2)
				.FieldValue(Pessoas.METADADO.EspecieBeneficio, obj.EspecieBeneficio)
				.FieldValue(Pessoas.METADADO.Orgao, obj.Orgao)
				.FieldValue(Pessoas.METADADO.UFBeneficio, obj.UFBeneficio)
				.FieldValue(Pessoas.METADADO.IfPagadora, obj.IfPagadora)
				.FieldValue(Pessoas.METADADO.AgenciaPagadora, obj.AgenciaPagadora)
				.FieldValue(Pessoas.METADADO.ContaCorrente, obj.ContaCorrente)
				.FieldValue(Pessoas.METADADO.IndicadorAnalfabetismo, obj.IndicadorAnalfabetismo);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, insert.ToString());
				cmd.CommandTimeout = 600;
				insert.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		#endregion

		#region Obtem
		#endregion

		#region Excluir por FKs
		#endregion

		#region Excluir por PK
		#endregion

	}
}
