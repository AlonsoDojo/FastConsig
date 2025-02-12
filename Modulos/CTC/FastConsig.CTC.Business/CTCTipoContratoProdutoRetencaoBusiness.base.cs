
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
	public partial class CTCTipoContratoProdutoRetencaoBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<CTCTipoContratoProdutoRetencao> Listar(WhereBuilder filtro)
		{
			CTCTipoContratoProdutoRetencaoData objCTCTipoContratoProdutoRetencaoData = new CTCTipoContratoProdutoRetencaoData();

			#region Regras de negócio
			#endregion

			return objCTCTipoContratoProdutoRetencaoData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(CTCTipoContratoProdutoRetencao obj)
		{
			CTCTipoContratoProdutoRetencaoData objCTCTipoContratoProdutoRetencaoData = new CTCTipoContratoProdutoRetencaoData();

			#region Regras de negócio
			#endregion

			objCTCTipoContratoProdutoRetencaoData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(CTCTipoContratoProdutoRetencao obj)
		{
			CTCTipoContratoProdutoRetencaoData objCTCTipoContratoProdutoRetencaoData = new CTCTipoContratoProdutoRetencaoData();

			#region Regras de negócio
			#endregion

			objCTCTipoContratoProdutoRetencaoData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual CTCTipoContratoProdutoRetencao Obtem(int? Id)
		{
			CTCTipoContratoProdutoRetencaoData objCTCTipoContratoProdutoRetencaoData = new CTCTipoContratoProdutoRetencaoData();

			#region Regras de negócio
			#endregion

			return objCTCTipoContratoProdutoRetencaoData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		public void ExcluirPor_TipoContrato(string TipoContrato)
		{
			CTCTipoContratoProdutoRetencaoData objCTCTipoContratoProdutoRetencaoData = new CTCTipoContratoProdutoRetencaoData();

			#region Regras de negócio
			#endregion

			objCTCTipoContratoProdutoRetencaoData.ExcluirPor_TipoContrato(TipoContrato);
		}
		public void ExcluirPor_EnteConsignante(string EnteConsignante)
		{
			CTCTipoContratoProdutoRetencaoData objCTCTipoContratoProdutoRetencaoData = new CTCTipoContratoProdutoRetencaoData();

			#region Regras de negócio
			#endregion

			objCTCTipoContratoProdutoRetencaoData.ExcluirPor_EnteConsignante(EnteConsignante);
		}
		public void ExcluirPor_ProdutoRetencao(int? ProdutoRetencao)
		{
			CTCTipoContratoProdutoRetencaoData objCTCTipoContratoProdutoRetencaoData = new CTCTipoContratoProdutoRetencaoData();

			#region Regras de negócio
			#endregion

			objCTCTipoContratoProdutoRetencaoData.ExcluirPor_ProdutoRetencao(ProdutoRetencao);
		}
		public void ExcluirPor_ContaPagamento(int? ContaPagamento)
		{
			CTCTipoContratoProdutoRetencaoData objCTCTipoContratoProdutoRetencaoData = new CTCTipoContratoProdutoRetencaoData();

			#region Regras de negócio
			#endregion

			objCTCTipoContratoProdutoRetencaoData.ExcluirPor_ContaPagamento(ContaPagamento);
		}
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			CTCTipoContratoProdutoRetencaoData objCTCTipoContratoProdutoRetencaoData = new CTCTipoContratoProdutoRetencaoData();

			#region Regras de negócio
			#endregion

			objCTCTipoContratoProdutoRetencaoData.Excluir(Id);
		}
		#endregion

	}
}
