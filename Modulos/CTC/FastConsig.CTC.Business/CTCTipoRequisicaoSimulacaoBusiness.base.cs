
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
	public partial class CTCTipoRequisicaoSimulacaoBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<CTCTipoRequisicaoSimulacao> Listar(WhereBuilder filtro)
		{
			CTCTipoRequisicaoSimulacaoData objCTCTipoRequisicaoSimulacaoData = new CTCTipoRequisicaoSimulacaoData();

			#region Regras de negócio
			#endregion

			return objCTCTipoRequisicaoSimulacaoData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(CTCTipoRequisicaoSimulacao obj)
		{
			CTCTipoRequisicaoSimulacaoData objCTCTipoRequisicaoSimulacaoData = new CTCTipoRequisicaoSimulacaoData();

			#region Regras de negócio
			#endregion

			objCTCTipoRequisicaoSimulacaoData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(CTCTipoRequisicaoSimulacao obj)
		{
			CTCTipoRequisicaoSimulacaoData objCTCTipoRequisicaoSimulacaoData = new CTCTipoRequisicaoSimulacaoData();

			#region Regras de negócio
			#endregion

			objCTCTipoRequisicaoSimulacaoData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual CTCTipoRequisicaoSimulacao Obtem(int? Id)
		{
			CTCTipoRequisicaoSimulacaoData objCTCTipoRequisicaoSimulacaoData = new CTCTipoRequisicaoSimulacaoData();

			#region Regras de negócio
			#endregion

			return objCTCTipoRequisicaoSimulacaoData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			CTCTipoRequisicaoSimulacaoData objCTCTipoRequisicaoSimulacaoData = new CTCTipoRequisicaoSimulacaoData();

			#region Regras de negócio
			#endregion

			objCTCTipoRequisicaoSimulacaoData.Excluir(Id);
		}
		#endregion

	}
}
