
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
	public partial class PropostaPendenciaData
	{
		
		public PropostaPendenciaData() {
			this.CustomizeQuery += new CustomizeQueryDelegate(Handle_CustomizeQuery);
		}

		void Handle_CustomizeQuery(QueryBuilder query) {
			//*************************************************************************
			//*** OBS: Nao esqueca de criar as propriedades na Entity customized!!! ***
			//*************************************************************************

			//JOIN com a tabela Propostas
			//------------------------------------------------------------------
			//query.Join(PropostaPendencia.METADADO.Proposta, Join.Inner, Propostas.METADADO.Id)
			//     .Field(Propostas.METADADO.DataCriacao, "DataCriacaoPropostas")
			//     .Field(Propostas.METADADO.DataUltimaAlteracao, "DataUltimaAlteracaoPropostas")
			//     .Field(Propostas.METADADO.Fase, "FasePropostas")
			//     .Field(Propostas.METADADO.Status, "StatusPropostas")
			//     .Field(Propostas.METADADO.Usuario, "UsuarioPropostas")
			//     .Field(Propostas.METADADO.Observacoes, "ObservacoesPropostas")
			//     .Field(Propostas.METADADO.Gerente, "GerentePropostas")
			//     .Field(Propostas.METADADO.MotivoRecusa, "MotivoRecusaPropostas")
			//     .Field(Propostas.METADADO.Promotora, "PromotoraPropostas")
			//     .Field(Propostas.METADADO.DataAtualizacao, "DataAtualizacaoPropostas")
			//     .Field(Propostas.METADADO.UsuarioProposta, "UsuarioPropostaPropostas")
			//     .Field(Propostas.METADADO.ProfissionalCertificado, "ProfissionalCertificadoPropostas")
			//     .Field(Propostas.METADADO.Pendente, "PendentePropostas")
			//     .Field(Propostas.METADADO.TipoFormalizacao, "TipoFormalizacaoPropostas")
			//     .Field(Propostas.METADADO.TipoComunicacao, "TipoComunicacaoPropostas")
			//     .Field(Propostas.METADADO.MensagemInterna, "MensagemInternaPropostas")
			//     .Field(Propostas.METADADO.Retencao, "RetencaoPropostas");
			//------------------------------------------------------------------

			//JOIN com a tabela Fases
			//------------------------------------------------------------------
			//query.Join(PropostaPendencia.METADADO.FaseAtual, Join.Inner, Fases.METADADO.Id)
			//     .Field(Fases.METADADO.Descricao, "DescricaoFases");
			//------------------------------------------------------------------

			//JOIN com a tabela Fases
			//------------------------------------------------------------------
			//query.Join(PropostaPendencia.METADADO.FaseDestino, Join.Inner, Fases.METADADO.Id)
			//     .Field(Fases.METADADO.Descricao, "DescricaoFases");
			//------------------------------------------------------------------


		}

	}
}
