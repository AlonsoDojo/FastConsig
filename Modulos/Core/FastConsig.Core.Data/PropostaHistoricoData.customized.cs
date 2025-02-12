
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
	public partial class PropostaHistoricoData
	{
		
		public PropostaHistoricoData() {
			this.CustomizeQuery += new CustomizeQueryDelegate(Handle_CustomizeQuery);
		}

		void Handle_CustomizeQuery(QueryBuilder query) {
			//*************************************************************************
			//*** OBS: Nao esqueca de criar as propriedades na Entity customized!!! ***
			//*************************************************************************

			//JOIN com a tabela SimulacaoProposta
			//------------------------------------------------------------------
			query.Join(PropostaHistorico.METADADO.Fase, Join.Left, Fases.METADADO.Id)
				  .Field(Fases.METADADO.Descricao, "DescricaoFase");
			//     .Field(SimulacaoProposta.METADADO.Usuario, "UsuarioSimulacaoProposta")
			//     .Field(SimulacaoProposta.METADADO.Promotora, "PromotoraSimulacaoProposta")
			//     .Field(SimulacaoProposta.METADADO.Pessoa, "PessoaSimulacaoProposta")
			//     .Field(SimulacaoProposta.METADADO.TipoComunicacao, "TipoComunicacaoSimulacaoProposta")
			//     .Field(SimulacaoProposta.METADADO.Taxa, "TaxaSimulacaoProposta")
			//     .Field(SimulacaoProposta.METADADO.Guid, "GuidSimulacaoProposta")
			//     .Field(SimulacaoProposta.METADADO.Autorizacao, "AutorizacaoSimulacaoProposta")
			//     .Field(SimulacaoProposta.METADADO.TipoFormalizacao, "TipoFormalizacaoSimulacaoProposta")
			//     .Field(SimulacaoProposta.METADADO.Retencao, "RetencaoSimulacaoProposta");
			//------------------------------------------------------------------


		}

	}
}
