
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
	public partial class OcorrenciaProdutoFaseData
	{
		
		public OcorrenciaProdutoFaseData() {
			this.CustomizeQuery += new CustomizeQueryDelegate(Handle_CustomizeQuery);
		}

		void Handle_CustomizeQuery(QueryBuilder query) {
         //*************************************************************************
         //*** OBS: Nao esqueca de criar as propriedades na Entity customized!!! ***
         //*************************************************************************

         //JOIN com a tabela Ocorrencias
         //------------------------------------------------------------------
         //query.Join(OcorrenciaProdutoFase.METADADO.Ocorrencia, Join.Inner, Ocorrencias.METADADO.Id)
         //     .Field(Ocorrencias.METADADO.Descricao, "DescricaoOcorrencias")
         //     .Field(Ocorrencias.METADADO.PermiteLiberacaoComplemento, "PermiteLiberacaoComplementoOcorrencias")
         //     .Field(Ocorrencias.METADADO.Pendencia, "PendenciaOcorrencias")
         //     .Field(Ocorrencias.METADADO.Recusa, "RecusaOcorrencias")
         //     .Field(Ocorrencias.METADADO.Informativa, "InformativaOcorrencias");
         //------------------------------------------------------------------
         query.Join(OcorrenciaProdutoFase.METADADO.Ocorrencia, Join.Left, Ocorrencias.METADADO.Id)
              .Field(Ocorrencias.METADADO.Descricao, "DescricaoOcorrencia")
              .Field(Ocorrencias.METADADO.PermiteLiberacaoComplemento, "PermiteLiberacaoComplemento")
              .Field(Ocorrencias.METADADO.Pendencia, "Pendencia")
              .Field(Ocorrencias.METADADO.Informativa, "Informativa")
              .Field(Ocorrencias.METADADO.Recusa, "Recusa");

         //JOIN com a tabela Produtos
         //------------------------------------------------------------------
         //query.Join(OcorrenciaProdutoFase.METADADO.Produto, Join.Inner, Produtos.METADADO.Id)
         //     .Field(Produtos.METADADO.Nome, "NomeProdutos")
         //     .Field(Produtos.METADADO.Ativo, "AtivoProdutos")
         //     .Field(Produtos.METADADO.PaginaPadrao, "PaginaPadraoProdutos")
         //     .Field(Produtos.METADADO.ExibeBlocoCelularEmail, "ExibeBlocoCelularEmailProdutos")
         //     .Field(Produtos.METADADO.ExibeBlocoDataNascimento, "ExibeBlocoDataNascimentoProdutos")
         //     .Field(Produtos.METADADO.GerentePadrao, "GerentePadraoProdutos")
         //     .Field(Produtos.METADADO.Parametros, "ParametrosProdutos")
         //     .Field(Produtos.METADADO.Observacoes, "ObservacoesProdutos")
         //     .Field(Produtos.METADADO.BuscaDadosCadastrais, "BuscaDadosCadastraisProdutos")
         //     .Field(Produtos.METADADO.PermiteBuscarUltimoCadastro, "PermiteBuscarUltimoCadastroProdutos")
         //     .Field(Produtos.METADADO.ExibeSelecaoTabelas, "ExibeSelecaoTabelasProdutos")
         //     .Field(Produtos.METADADO.ExibeValorSolicitado, "ExibeValorSolicitadoProdutos")
         //     .Field(Produtos.METADADO.ExibePrazo, "ExibePrazoProdutos")
         //     .Field(Produtos.METADADO.AplicavelPF, "AplicavelPFProdutos")
         //     .Field(Produtos.METADADO.AplicavelPJ, "AplicavelPJProdutos")
         //     .Field(Produtos.METADADO.ExibirDatasSimulacao, "ExibirDatasSimulacaoProdutos")
         //     .Field(Produtos.METADADO.ExibeDataEmissao, "ExibeDataEmissaoProdutos")
         //     .Field(Produtos.METADADO.ExibeDataPrimeiroVencimento, "ExibeDataPrimeiroVencimentoProdutos")
         //     .Field(Produtos.METADADO.ExibeCaptcha, "ExibeCaptchaProdutos")
         //     .Field(Produtos.METADADO.ExibeNumeroBeneficio, "ExibeNumeroBeneficioProdutos")
         //     .Field(Produtos.METADADO.ValidaCertificado, "ValidaCertificadoProdutos")
         //     .Field(Produtos.METADADO.TipoCertificado, "TipoCertificadoProdutos")
         //     .Field(Produtos.METADADO.ExpirarProposta, "ExpirarPropostaProdutos")
         //     .Field(Produtos.METADADO.DiasExpiracao, "DiasExpiracaoProdutos")
         //     .Field(Produtos.METADADO.ExibirFormaComunicacao, "ExibirFormaComunicacaoProdutos")
         //     .Field(Produtos.METADADO.ExibeOrgao, "ExibeOrgaoProdutos")
         //     .Field(Produtos.METADADO.ExibeEspecieBeneficio, "ExibeEspecieBeneficioProdutos")
         //     .Field(Produtos.METADADO.FamiliaProduto, "FamiliaProdutoProdutos");
         //------------------------------------------------------------------

         //JOIN com a tabela Fases
         //------------------------------------------------------------------
         //query.Join(OcorrenciaProdutoFase.METADADO.Fase, Join.Inner, Fases.METADADO.Id)
         //     .Field(Fases.METADADO.Descricao, "DescricaoFases");
         //------------------------------------------------------------------

         //JOIN com a tabela Fases
         //------------------------------------------------------------------
         //query.Join(OcorrenciaProdutoFase.METADADO.FaseDestino, Join.Inner, Fases.METADADO.Id)
         //     .Field(Fases.METADADO.Descricao, "DescricaoFases");
         //------------------------------------------------------------------


      }

	}
}
