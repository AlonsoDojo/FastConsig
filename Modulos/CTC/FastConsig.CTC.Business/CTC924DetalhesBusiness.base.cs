
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
	public partial class CTC924DetalhesBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<CTC924Detalhes> Listar(WhereBuilder filtro)
		{
			CTC924DetalhesData objCTC924DetalhesData = new CTC924DetalhesData();

			#region Regras de negócio
			#endregion

			return objCTC924DetalhesData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(CTC924Detalhes obj)
		{
			CTC924DetalhesData objCTC924DetalhesData = new CTC924DetalhesData();

			#region Regras de negócio
			#endregion

			objCTC924DetalhesData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(CTC924Detalhes obj)
		{
			CTC924DetalhesData objCTC924DetalhesData = new CTC924DetalhesData();

			#region Regras de negócio
			#endregion

			objCTC924DetalhesData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual CTC924Detalhes Obtem(int? Id)
		{
			CTC924DetalhesData objCTC924DetalhesData = new CTC924DetalhesData();

			#region Regras de negócio
			#endregion

			return objCTC924DetalhesData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		public void ExcluirPor_CTC924(int? CTC924)
		{
			CTC924DetalhesData objCTC924DetalhesData = new CTC924DetalhesData();

			#region Regras de negócio
			#endregion

			objCTC924DetalhesData.ExcluirPor_CTC924(CTC924);
		}
		public void ExcluirPor_SituacaoPortabilidadeCTC(string SituacaoPortabilidadeCTC)
		{
			CTC924DetalhesData objCTC924DetalhesData = new CTC924DetalhesData();

			#region Regras de negócio
			#endregion

			objCTC924DetalhesData.ExcluirPor_SituacaoPortabilidadeCTC(SituacaoPortabilidadeCTC);
		}
		public void ExcluirPor_TipoContrato(string TipoContrato)
		{
			CTC924DetalhesData objCTC924DetalhesData = new CTC924DetalhesData();

			#region Regras de negócio
			#endregion

			objCTC924DetalhesData.ExcluirPor_TipoContrato(TipoContrato);
		}
		public void ExcluirPor_EnteConsignante(string EnteConsignante)
		{
			CTC924DetalhesData objCTC924DetalhesData = new CTC924DetalhesData();

			#region Regras de negócio
			#endregion

			objCTC924DetalhesData.ExcluirPor_EnteConsignante(EnteConsignante);
		}
		public void ExcluirPor_MotivoDecursoPrazo(string MotivoDecursoPrazo)
		{
			CTC924DetalhesData objCTC924DetalhesData = new CTC924DetalhesData();

			#region Regras de negócio
			#endregion

			objCTC924DetalhesData.ExcluirPor_MotivoDecursoPrazo(MotivoDecursoPrazo);
		}
		public void ExcluirPor_MotivoCancelamento(string MotivoCancelamento)
		{
			CTC924DetalhesData objCTC924DetalhesData = new CTC924DetalhesData();

			#region Regras de negócio
			#endregion

			objCTC924DetalhesData.ExcluirPor_MotivoCancelamento(MotivoCancelamento);
		}
		public void ExcluirPor_MotivoRetencaoContrato(string MotivoRetencaoContrato)
		{
			CTC924DetalhesData objCTC924DetalhesData = new CTC924DetalhesData();

			#region Regras de negócio
			#endregion

			objCTC924DetalhesData.ExcluirPor_MotivoRetencaoContrato(MotivoRetencaoContrato);
		}
		public void ExcluirPor_SituacaoLiquidacao(string SituacaoLiquidacao)
		{
			CTC924DetalhesData objCTC924DetalhesData = new CTC924DetalhesData();

			#region Regras de negócio
			#endregion

			objCTC924DetalhesData.ExcluirPor_SituacaoLiquidacao(SituacaoLiquidacao);
		}
		public void ExcluirPor_SituacaoDevolucaoLiquidacao(string SituacaoDevolucaoLiquidacao)
		{
			CTC924DetalhesData objCTC924DetalhesData = new CTC924DetalhesData();

			#region Regras de negócio
			#endregion

			objCTC924DetalhesData.ExcluirPor_SituacaoDevolucaoLiquidacao(SituacaoDevolucaoLiquidacao);
		}
		public void ExcluirPor_MotivoDevolucaoLiquidacao(string MotivoDevolucaoLiquidacao)
		{
			CTC924DetalhesData objCTC924DetalhesData = new CTC924DetalhesData();

			#region Regras de negócio
			#endregion

			objCTC924DetalhesData.ExcluirPor_MotivoDevolucaoLiquidacao(MotivoDevolucaoLiquidacao);
		}
		public void ExcluirPor_SituacaoEfetivacaoPortabilidade(string SituacaoEfetivacaoPortabilidade)
		{
			CTC924DetalhesData objCTC924DetalhesData = new CTC924DetalhesData();

			#region Regras de negócio
			#endregion

			objCTC924DetalhesData.ExcluirPor_SituacaoEfetivacaoPortabilidade(SituacaoEfetivacaoPortabilidade);
		}
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			CTC924DetalhesData objCTC924DetalhesData = new CTC924DetalhesData();

			#region Regras de negócio
			#endregion

			objCTC924DetalhesData.Excluir(Id);
		}
		#endregion

	}
}
