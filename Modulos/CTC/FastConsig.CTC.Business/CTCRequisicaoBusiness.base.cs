
#region Usings
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;
using Framework.Data;
using FastConsig.CTC.Entity;
using FastConsig.CTC.Data;
#endregion

namespace FastConsig.CTC.Business
{
	public partial class CTCRequisicaoBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<CTCRequisicao> Listar(WhereBuilder filtro)
		{
			CTCRequisicaoData objCTCRequisicaoData = new CTCRequisicaoData();

			#region Regras de negócio
			#endregion

			return objCTCRequisicaoData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(CTCRequisicao obj)
		{
			CTCRequisicaoData objCTCRequisicaoData = new CTCRequisicaoData();

			#region Regras de negócio
			#endregion

			objCTCRequisicaoData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(CTCRequisicao obj)
		{
			CTCRequisicaoData objCTCRequisicaoData = new CTCRequisicaoData();

			#region Regras de negócio
			#endregion

			objCTCRequisicaoData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual CTCRequisicao Obtem(int? Id)
		{
			CTCRequisicaoData objCTCRequisicaoData = new CTCRequisicaoData();

			#region Regras de negócio
			#endregion

			return objCTCRequisicaoData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		public void ExcluirPor_TipoContrato(string TipoContrato)
		{
			CTCRequisicaoData objCTCRequisicaoData = new CTCRequisicaoData();

			#region Regras de negócio
			#endregion

			objCTCRequisicaoData.ExcluirPor_TipoContrato(TipoContrato);
		}
		public void ExcluirPor_EnteConsignante(string EnteConsignante)
		{
			CTCRequisicaoData objCTCRequisicaoData = new CTCRequisicaoData();

			#region Regras de negócio
			#endregion

			objCTCRequisicaoData.ExcluirPor_EnteConsignante(EnteConsignante);
		}
		public void ExcluirPor_Moeda(string Moeda)
		{
			CTCRequisicaoData objCTCRequisicaoData = new CTCRequisicaoData();

			#region Regras de negócio
			#endregion

			objCTCRequisicaoData.ExcluirPor_Moeda(Moeda);
		}
		public void ExcluirPor_IndiceRemuneracao(string IndiceRemuneracao)
		{
			CTCRequisicaoData objCTCRequisicaoData = new CTCRequisicaoData();

			#region Regras de negócio
			#endregion

			objCTCRequisicaoData.ExcluirPor_IndiceRemuneracao(IndiceRemuneracao);
		}
		public void ExcluirPor_RegimeAmortizacao(string RegimeAmortizacao)
		{
			CTCRequisicaoData objCTCRequisicaoData = new CTCRequisicaoData();

			#region Regras de negócio
			#endregion

			objCTCRequisicaoData.ExcluirPor_RegimeAmortizacao(RegimeAmortizacao);
		}
		public void ExcluirPor_SituacaoPortabilidade(string SituacaoPortabilidade)
		{
			CTCRequisicaoData objCTCRequisicaoData = new CTCRequisicaoData();

			#region Regras de negócio
			#endregion

			objCTCRequisicaoData.ExcluirPor_SituacaoPortabilidade(SituacaoPortabilidade);
		}
		public void ExcluirPor_Arquivo(int? Arquivo)
		{
			CTCRequisicaoData objCTCRequisicaoData = new CTCRequisicaoData();

			#region Regras de negócio
			#endregion

			objCTCRequisicaoData.ExcluirPor_Arquivo(Arquivo);
		}
		public void ExcluirPor_Fase(int? Fase)
		{
			CTCRequisicaoData objCTCRequisicaoData = new CTCRequisicaoData();

			#region Regras de negócio
			#endregion

			objCTCRequisicaoData.ExcluirPor_Fase(Fase);
		}
		public void ExcluirPor_TipoArquivo(int? TipoArquivo)
		{
			CTCRequisicaoData objCTCRequisicaoData = new CTCRequisicaoData();

			#region Regras de negócio
			#endregion

			objCTCRequisicaoData.ExcluirPor_TipoArquivo(TipoArquivo);
		}
		public void ExcluirPor_TipoFluxo(int? TipoFluxo)
		{
			CTCRequisicaoData objCTCRequisicaoData = new CTCRequisicaoData();

			#region Regras de negócio
			#endregion

			objCTCRequisicaoData.ExcluirPor_TipoFluxo(TipoFluxo);
		}
		public void ExcluirPor_MotivoRetencao(string MotivoRetencao)
		{
			CTCRequisicaoData objCTCRequisicaoData = new CTCRequisicaoData();

			#region Regras de negócio
			#endregion

			objCTCRequisicaoData.ExcluirPor_MotivoRetencao(MotivoRetencao);
		}
		public void ExcluirPor_MotivoCancelamento(string MotivoCancelamento)
		{
			CTCRequisicaoData objCTCRequisicaoData = new CTCRequisicaoData();

			#region Regras de negócio
			#endregion

			objCTCRequisicaoData.ExcluirPor_MotivoCancelamento(MotivoCancelamento);
		}
		public void ExcluirPor_MotivoDecursoPrazo(string MotivoDecursoPrazo)
		{
			CTCRequisicaoData objCTCRequisicaoData = new CTCRequisicaoData();

			#region Regras de negócio
			#endregion

			objCTCRequisicaoData.ExcluirPor_MotivoDecursoPrazo(MotivoDecursoPrazo);
		}
		public void ExcluirPor_MotivoDevolucaoLiquidacao(string MotivoDevolucaoLiquidacao)
		{
			CTCRequisicaoData objCTCRequisicaoData = new CTCRequisicaoData();

			#region Regras de negócio
			#endregion

			objCTCRequisicaoData.ExcluirPor_MotivoDevolucaoLiquidacao(MotivoDevolucaoLiquidacao);
		}
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			CTCRequisicaoData objCTCRequisicaoData = new CTCRequisicaoData();

			#region Regras de negócio
			#endregion

			objCTCRequisicaoData.Excluir(Id);
		}
		#endregion

	}
}
