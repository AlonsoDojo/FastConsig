
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
	public partial class CTC922DetalhesBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<CTC922Detalhes> Listar(WhereBuilder filtro)
		{
			CTC922DetalhesData objCTC922DetalhesData = new CTC922DetalhesData();

			#region Regras de negócio
			#endregion

			return objCTC922DetalhesData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(CTC922Detalhes obj)
		{
			CTC922DetalhesData objCTC922DetalhesData = new CTC922DetalhesData();

			#region Regras de negócio
			#endregion

			objCTC922DetalhesData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(CTC922Detalhes obj)
		{
			CTC922DetalhesData objCTC922DetalhesData = new CTC922DetalhesData();

			#region Regras de negócio
			#endregion

			objCTC922DetalhesData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual CTC922Detalhes Obtem(int? Id)
		{
			CTC922DetalhesData objCTC922DetalhesData = new CTC922DetalhesData();

			#region Regras de negócio
			#endregion

			return objCTC922DetalhesData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		public void ExcluirPor_CTC922(int? CTC922)
		{
			CTC922DetalhesData objCTC922DetalhesData = new CTC922DetalhesData();

			#region Regras de negócio
			#endregion

			objCTC922DetalhesData.ExcluirPor_CTC922(CTC922);
		}
		public void ExcluirPor_TipoParte(int? TipoParte)
		{
			CTC922DetalhesData objCTC922DetalhesData = new CTC922DetalhesData();

			#region Regras de negócio
			#endregion

			objCTC922DetalhesData.ExcluirPor_TipoParte(TipoParte);
		}
		public void ExcluirPor_MotivoRetencao(string MotivoRetencao)
		{
			CTC922DetalhesData objCTC922DetalhesData = new CTC922DetalhesData();

			#region Regras de negócio
			#endregion

			objCTC922DetalhesData.ExcluirPor_MotivoRetencao(MotivoRetencao);
		}
		public void ExcluirPor_MotivoDecursoPrazo(string MotivoDecursoPrazo)
		{
			CTC922DetalhesData objCTC922DetalhesData = new CTC922DetalhesData();

			#region Regras de negócio
			#endregion

			objCTC922DetalhesData.ExcluirPor_MotivoDecursoPrazo(MotivoDecursoPrazo);
		}
		public void ExcluirPor_MotivoCancelamento(string MotivoCancelamento)
		{
			CTC922DetalhesData objCTC922DetalhesData = new CTC922DetalhesData();

			#region Regras de negócio
			#endregion

			objCTC922DetalhesData.ExcluirPor_MotivoCancelamento(MotivoCancelamento);
		}
		public void ExcluirPor_MotivoDevolucaoLiquidacao(string MotivoDevolucaoLiquidacao)
		{
			CTC922DetalhesData objCTC922DetalhesData = new CTC922DetalhesData();

			#region Regras de negócio
			#endregion

			objCTC922DetalhesData.ExcluirPor_MotivoDevolucaoLiquidacao(MotivoDevolucaoLiquidacao);
		}
		public void ExcluirPor_TipoContrato(string TipoContrato)
		{
			CTC922DetalhesData objCTC922DetalhesData = new CTC922DetalhesData();

			#region Regras de negócio
			#endregion

			objCTC922DetalhesData.ExcluirPor_TipoContrato(TipoContrato);
		}
		public void ExcluirPor_EnteConsignante(string EnteConsignante)
		{
			CTC922DetalhesData objCTC922DetalhesData = new CTC922DetalhesData();

			#region Regras de negócio
			#endregion

			objCTC922DetalhesData.ExcluirPor_EnteConsignante(EnteConsignante);
		}
		public void ExcluirPor_SituacaoPortabilidade(string SituacaoPortabilidade)
		{
			CTC922DetalhesData objCTC922DetalhesData = new CTC922DetalhesData();

			#region Regras de negócio
			#endregion

			objCTC922DetalhesData.ExcluirPor_SituacaoPortabilidade(SituacaoPortabilidade);
		}
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			CTC922DetalhesData objCTC922DetalhesData = new CTC922DetalhesData();

			#region Regras de negócio
			#endregion

			objCTC922DetalhesData.Excluir(Id);
		}
		#endregion

	}
}
