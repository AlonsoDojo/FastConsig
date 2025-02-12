
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
	public partial class CTCRequisicaoSimulacaoBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<CTCRequisicaoSimulacao> Listar(WhereBuilder filtro)
		{
			CTCRequisicaoSimulacaoData objCTCRequisicaoSimulacaoData = new CTCRequisicaoSimulacaoData();

			#region Regras de negócio
			#endregion

			return objCTCRequisicaoSimulacaoData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(CTCRequisicaoSimulacao obj)
		{
			CTCRequisicaoSimulacaoData objCTCRequisicaoSimulacaoData = new CTCRequisicaoSimulacaoData();

			#region Regras de negócio
			#endregion

			objCTCRequisicaoSimulacaoData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(CTCRequisicaoSimulacao obj)
		{
			CTCRequisicaoSimulacaoData objCTCRequisicaoSimulacaoData = new CTCRequisicaoSimulacaoData();

			#region Regras de negócio
			#endregion

			objCTCRequisicaoSimulacaoData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual CTCRequisicaoSimulacao Obtem(int? Id)
		{
			CTCRequisicaoSimulacaoData objCTCRequisicaoSimulacaoData = new CTCRequisicaoSimulacaoData();

			#region Regras de negócio
			#endregion

			return objCTCRequisicaoSimulacaoData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		public void ExcluirPor_Requisicao(int? Requisicao)
		{
			CTCRequisicaoSimulacaoData objCTCRequisicaoSimulacaoData = new CTCRequisicaoSimulacaoData();

			#region Regras de negócio
			#endregion

			objCTCRequisicaoSimulacaoData.ExcluirPor_Requisicao(Requisicao);
		}
		public void ExcluirPor_Tipo(int? Tipo)
		{
			CTCRequisicaoSimulacaoData objCTCRequisicaoSimulacaoData = new CTCRequisicaoSimulacaoData();

			#region Regras de negócio
			#endregion

			objCTCRequisicaoSimulacaoData.ExcluirPor_Tipo(Tipo);
		}
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			CTCRequisicaoSimulacaoData objCTCRequisicaoSimulacaoData = new CTCRequisicaoSimulacaoData();

			#region Regras de negócio
			#endregion

			objCTCRequisicaoSimulacaoData.Excluir(Id);
		}
		#endregion

	}
}
