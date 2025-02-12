
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
	public partial class SimulacaoPropostaData
	{
		
		public SimulacaoPropostaData() {
			this.CustomizeQuery += new CustomizeQueryDelegate(Handle_CustomizeQuery);
		}

		void Handle_CustomizeQuery(QueryBuilder query) {
			//*************************************************************************
			//*** OBS: Nao esqueca de criar as propriedades na Entity customized!!! ***
			//*************************************************************************

			//JOIN com a tabela Promotoras
			//------------------------------------------------------------------
			//query.Join(SimulacaoProposta.METADADO.Promotora, Join.Inner, Promotoras.METADADO.Id)
			//     .Field(Promotoras.METADADO.Nome, "NomePromotoras")
			//     .Field(Promotoras.METADADO.Cep, "CepPromotoras")
			//     .Field(Promotoras.METADADO.Endereco, "EnderecoPromotoras")
			//     .Field(Promotoras.METADADO.Numero, "NumeroPromotoras")
			//     .Field(Promotoras.METADADO.Complemento, "ComplementoPromotoras")
			//     .Field(Promotoras.METADADO.Bairro, "BairroPromotoras")
			//     .Field(Promotoras.METADADO.Cidade, "CidadePromotoras")
			//     .Field(Promotoras.METADADO.Estado, "EstadoPromotoras")
			//     .Field(Promotoras.METADADO.DDD, "DDDPromotoras")
			//     .Field(Promotoras.METADADO.Telefone, "TelefonePromotoras")
			//     .Field(Promotoras.METADADO.Email, "EmailPromotoras")
			//     .Field(Promotoras.METADADO.Cnpj, "CnpjPromotoras")
			//     .Field(Promotoras.METADADO.Ativo, "AtivoPromotoras")
			//     .Field(Promotoras.METADADO.Correspondente, "CorrespondentePromotoras")
			//     .Field(Promotoras.METADADO.NomeFantasia, "NomeFantasiaPromotoras")
			//     .Field(Promotoras.METADADO.IndiceReclamacoes, "IndiceReclamacoesPromotoras")
			//     .Field(Promotoras.METADADO.ResultadoReclamacoes, "ResultadoReclamacoesPromotoras")
			//     .Field(Promotoras.METADADO.IndiceAcoesJudiciais, "IndiceAcoesJudiciaisPromotoras")
			//     .Field(Promotoras.METADADO.ResultadoAcoesJudiciais, "ResultadoAcoesJudiciaisPromotoras")
			//     .Field(Promotoras.METADADO.IndicadorNaoConformidade, "IndicadorNaoConformidadePromotoras")
			//     .Field(Promotoras.METADADO.DataBaseConsultaQuadroSocietario, "DataBaseConsultaQuadroSocietarioPromotoras")
			//     .Field(Promotoras.METADADO.Gerente, "GerentePromotoras");
			//------------------------------------------------------------------


		}

	}
}
