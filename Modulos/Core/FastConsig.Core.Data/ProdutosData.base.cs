
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
	public partial class ProdutosData : DataBase
	{
		
		#region Listar
		public List<Produtos> Listar(WhereBuilder filtro)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(Produtos.METADADO.Id)
				.Field(Produtos.METADADO.Nome)
				.Field(Produtos.METADADO.Ativo)
				.Field(Produtos.METADADO.PaginaPadrao)
				.Field(Produtos.METADADO.ExibeBlocoCelularEmail)
				.Field(Produtos.METADADO.ExibeBlocoDataNascimento)
				.Field(Produtos.METADADO.GerentePadrao)
				.Field(Produtos.METADADO.Parametros)
				.Field(Produtos.METADADO.Observacoes)
				.Field(Produtos.METADADO.BuscaDadosCadastrais)
				.Field(Produtos.METADADO.PermiteBuscarUltimoCadastro)
				.Field(Produtos.METADADO.ExibeSelecaoTabelas)
				.Field(Produtos.METADADO.ExibeValorSolicitado)
				.Field(Produtos.METADADO.ExibePrazo)
				.Field(Produtos.METADADO.AplicavelPF)
				.Field(Produtos.METADADO.AplicavelPJ)
				.Field(Produtos.METADADO.ExibirDatasSimulacao)
				.Field(Produtos.METADADO.ExibeDataEmissao)
				.Field(Produtos.METADADO.ExibeDataPrimeiroVencimento)
				.Field(Produtos.METADADO.ExibeCaptcha)
				.Field(Produtos.METADADO.ExibeNumeroBeneficio)
				.Field(Produtos.METADADO.ValidaCertificado)
				.Field(Produtos.METADADO.TipoCertificado)
				.Field(Produtos.METADADO.ExpirarProposta)
				.Field(Produtos.METADADO.DiasExpiracao)
				.Field(Produtos.METADADO.ExibirFormaComunicacao)
				.Field(Produtos.METADADO.ExibeOrgao)
				.Field(Produtos.METADADO.ExibeEspecieBeneficio)
				.Field(Produtos.METADADO.FamiliaProduto)
            .Field(Produtos.METADADO.ExibeInstituidor)
            .Field(Produtos.METADADO.BloqueiaProposta)
            .Field(Produtos.METADADO.ProfissionalCertificadoObrigatorio)
            .Table(Produtos.METADADO.tabelaNAME);

			query.Where = filtro;

			#endregion

			HandleCustomizedQuery(query);

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				cmd.CommandTimeout = 600;
				query.SetParameters(cmd);

				List<Produtos> result = base.MapReaderToEntitySet<Produtos>(cmd);
				return result;
			}
		}
		#endregion

		#region Alterar
		public void Alterar(Produtos obj)
		{
			#region UpdateBuilder

			UpdateBuilder update = UpdateBuilder.Create(this)
				.FieldValue(Produtos.METADADO.Nome, obj.Nome)
				.FieldValue(Produtos.METADADO.Ativo, obj.Ativo)
				.FieldValue(Produtos.METADADO.PaginaPadrao, obj.PaginaPadrao)
				.FieldValue(Produtos.METADADO.ExibeBlocoCelularEmail, obj.ExibeBlocoCelularEmail)
				.FieldValue(Produtos.METADADO.ExibeBlocoDataNascimento, obj.ExibeBlocoDataNascimento)
				.FieldValue(Produtos.METADADO.GerentePadrao, obj.GerentePadrao)
				.FieldValue(Produtos.METADADO.Parametros, obj.Parametros)
				.FieldValue(Produtos.METADADO.Observacoes, obj.Observacoes)
				.FieldValue(Produtos.METADADO.BuscaDadosCadastrais, obj.BuscaDadosCadastrais)
				.FieldValue(Produtos.METADADO.PermiteBuscarUltimoCadastro, obj.PermiteBuscarUltimoCadastro)
				.FieldValue(Produtos.METADADO.ExibeSelecaoTabelas, obj.ExibeSelecaoTabelas)
				.FieldValue(Produtos.METADADO.ExibeValorSolicitado, obj.ExibeValorSolicitado)
				.FieldValue(Produtos.METADADO.ExibePrazo, obj.ExibePrazo)
				.FieldValue(Produtos.METADADO.AplicavelPF, obj.AplicavelPF)
				.FieldValue(Produtos.METADADO.AplicavelPJ, obj.AplicavelPJ)
				.FieldValue(Produtos.METADADO.ExibirDatasSimulacao, obj.ExibirDatasSimulacao)
				.FieldValue(Produtos.METADADO.ExibeDataEmissao, obj.ExibeDataEmissao)
				.FieldValue(Produtos.METADADO.ExibeDataPrimeiroVencimento, obj.ExibeDataPrimeiroVencimento)
				.FieldValue(Produtos.METADADO.ExibeCaptcha, obj.ExibeCaptcha)
				.FieldValue(Produtos.METADADO.ExibeNumeroBeneficio, obj.ExibeNumeroBeneficio)
				.FieldValue(Produtos.METADADO.ValidaCertificado, obj.ValidaCertificado)
				.FieldValue(Produtos.METADADO.TipoCertificado, obj.TipoCertificado)
				.FieldValue(Produtos.METADADO.ExpirarProposta, obj.ExpirarProposta)
				.FieldValue(Produtos.METADADO.DiasExpiracao, obj.DiasExpiracao)
				.FieldValue(Produtos.METADADO.ExibirFormaComunicacao, obj.ExibirFormaComunicacao)
				.FieldValue(Produtos.METADADO.ExibeOrgao, obj.ExibeOrgao)
				.FieldValue(Produtos.METADADO.ExibeEspecieBeneficio, obj.ExibeEspecieBeneficio)
				.FieldValue(Produtos.METADADO.FamiliaProduto, obj.FamiliaProduto)
            .FieldValue(Produtos.METADADO.ExibeInstituidor, obj.ExibeInstituidor)
            .FieldValue(Produtos.METADADO.BloqueiaProposta, obj.BloqueiaProposta)
            .FieldValue(Produtos.METADADO.ProfissionalCertificadoObrigatorio, obj.ProfissionalCertificadoObrigatorio)
            .Table(Produtos.METADADO.tabelaNAME);

			update.Where
				.Add(Produtos.METADADO.Id, Filter.Equal, obj.Id);

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
		public void Incluir(Produtos obj)
		{
			#region InsertBuilder

			InsertBuilder insert = InsertBuilder.Create(this)
				.FieldValue(Produtos.METADADO.Id, obj.Id)
				.Table(Produtos.METADADO.tabelaNAME)
				.FieldValue(Produtos.METADADO.Nome, obj.Nome)
				.FieldValue(Produtos.METADADO.Ativo, obj.Ativo)
				.FieldValue(Produtos.METADADO.PaginaPadrao, obj.PaginaPadrao)
				.FieldValue(Produtos.METADADO.ExibeBlocoCelularEmail, obj.ExibeBlocoCelularEmail)
				.FieldValue(Produtos.METADADO.ExibeBlocoDataNascimento, obj.ExibeBlocoDataNascimento)
				.FieldValue(Produtos.METADADO.GerentePadrao, obj.GerentePadrao)
				.FieldValue(Produtos.METADADO.Parametros, obj.Parametros)
				.FieldValue(Produtos.METADADO.Observacoes, obj.Observacoes)
				.FieldValue(Produtos.METADADO.BuscaDadosCadastrais, obj.BuscaDadosCadastrais)
				.FieldValue(Produtos.METADADO.PermiteBuscarUltimoCadastro, obj.PermiteBuscarUltimoCadastro)
				.FieldValue(Produtos.METADADO.ExibeSelecaoTabelas, obj.ExibeSelecaoTabelas)
				.FieldValue(Produtos.METADADO.ExibeValorSolicitado, obj.ExibeValorSolicitado)
				.FieldValue(Produtos.METADADO.ExibePrazo, obj.ExibePrazo)
				.FieldValue(Produtos.METADADO.AplicavelPF, obj.AplicavelPF)
				.FieldValue(Produtos.METADADO.AplicavelPJ, obj.AplicavelPJ)
				.FieldValue(Produtos.METADADO.ExibirDatasSimulacao, obj.ExibirDatasSimulacao)
				.FieldValue(Produtos.METADADO.ExibeDataEmissao, obj.ExibeDataEmissao)
				.FieldValue(Produtos.METADADO.ExibeDataPrimeiroVencimento, obj.ExibeDataPrimeiroVencimento)
				.FieldValue(Produtos.METADADO.ExibeCaptcha, obj.ExibeCaptcha)
				.FieldValue(Produtos.METADADO.ExibeNumeroBeneficio, obj.ExibeNumeroBeneficio)
				.FieldValue(Produtos.METADADO.ValidaCertificado, obj.ValidaCertificado)
				.FieldValue(Produtos.METADADO.TipoCertificado, obj.TipoCertificado)
				.FieldValue(Produtos.METADADO.ExpirarProposta, obj.ExpirarProposta)
				.FieldValue(Produtos.METADADO.DiasExpiracao, obj.DiasExpiracao)
				.FieldValue(Produtos.METADADO.ExibirFormaComunicacao, obj.ExibirFormaComunicacao)
				.FieldValue(Produtos.METADADO.ExibeOrgao, obj.ExibeOrgao)
				.FieldValue(Produtos.METADADO.ExibeEspecieBeneficio, obj.ExibeEspecieBeneficio)
            .FieldValue(Produtos.METADADO.ExibeInstituidor, obj.ExibeInstituidor)
            .FieldValue(Produtos.METADADO.BloqueiaProposta, obj.BloqueiaProposta)
            .FieldValue(Produtos.METADADO.ProfissionalCertificadoObrigatorio, obj.ProfissionalCertificadoObrigatorio)
            .FieldValue(Produtos.METADADO.FamiliaProduto, obj.FamiliaProduto);

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
		public Produtos Obtem(int? Id)
		{
			#region QueryBuilder

			QueryBuilder query = QueryBuilder.Create(this)
				.Field(Produtos.METADADO.Id)
				.Field(Produtos.METADADO.Nome)
				.Field(Produtos.METADADO.Ativo)
				.Field(Produtos.METADADO.PaginaPadrao)
				.Field(Produtos.METADADO.ExibeBlocoCelularEmail)
				.Field(Produtos.METADADO.ExibeBlocoDataNascimento)
				.Field(Produtos.METADADO.GerentePadrao)
				.Field(Produtos.METADADO.Parametros)
				.Field(Produtos.METADADO.Observacoes)
				.Field(Produtos.METADADO.BuscaDadosCadastrais)
				.Field(Produtos.METADADO.PermiteBuscarUltimoCadastro)
				.Field(Produtos.METADADO.ExibeSelecaoTabelas)
				.Field(Produtos.METADADO.ExibeValorSolicitado)
				.Field(Produtos.METADADO.ExibePrazo)
				.Field(Produtos.METADADO.AplicavelPF)
				.Field(Produtos.METADADO.AplicavelPJ)
				.Field(Produtos.METADADO.ExibirDatasSimulacao)
				.Field(Produtos.METADADO.ExibeDataEmissao)
				.Field(Produtos.METADADO.ExibeDataPrimeiroVencimento)
				.Field(Produtos.METADADO.ExibeCaptcha)
				.Field(Produtos.METADADO.ExibeNumeroBeneficio)
				.Field(Produtos.METADADO.ValidaCertificado)
				.Field(Produtos.METADADO.TipoCertificado)
				.Field(Produtos.METADADO.ExpirarProposta)
				.Field(Produtos.METADADO.DiasExpiracao)
				.Field(Produtos.METADADO.ExibirFormaComunicacao)
				.Field(Produtos.METADADO.ExibeOrgao)
				.Field(Produtos.METADADO.ExibeEspecieBeneficio)
				.Field(Produtos.METADADO.FamiliaProduto)
            .Field(Produtos.METADADO.ExibeInstituidor)
            .Field(Produtos.METADADO.BloqueiaProposta)
            .Field(Produtos.METADADO.ProfissionalCertificadoObrigatorio)
            .Table(Produtos.METADADO.tabelaNAME);

			query.Where
				.Add(Produtos.METADADO.Id, Filter.Equal, Id);

			HandleCustomizedQuery(query);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, query.ToString());
				cmd.CommandTimeout = 600;
				query.SetParameters(cmd);

				Produtos result = base.MapReaderToEntity<Produtos>(cmd);
				return result;
			}
		}
		#endregion

		#region Excluir por FKs
		public void ExcluirPor_TipoCertificado(int? TipoCertificado)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(Produtos.METADADO.tabelaNAME);
			delete.Where
				.Add(Produtos.METADADO.TipoCertificado, Filter.Equal, TipoCertificado);

			#endregion

			using (IDbConnection connection = base.CreateConnection()) {
				IDbCommand cmd = base.CreateCommand(connection, delete.ToString());
				cmd.CommandTimeout = 600;
				delete.SetParameters(cmd);

				base.ExecuteNonQuery(cmd);
			}
		}
		public void ExcluirPor_FamiliaProduto(int? FamiliaProduto)
		{
			#region DeleteBuilder

			DeleteBuilder delete = DeleteBuilder.Create(this);
				delete.Table(Produtos.METADADO.tabelaNAME);
			delete.Where
				.Add(Produtos.METADADO.FamiliaProduto, Filter.Equal, FamiliaProduto);

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
				delete.Table(Produtos.METADADO.tabelaNAME);
			delete.Where
				.Add(Produtos.METADADO.Id, Filter.Equal, Id);

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
