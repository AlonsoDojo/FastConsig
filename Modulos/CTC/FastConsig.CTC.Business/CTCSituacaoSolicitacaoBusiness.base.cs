
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
	public partial class CTCSituacaoSolicitacaoBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<CTCSituacaoSolicitacao> Listar(WhereBuilder filtro)
		{
			CTCSituacaoSolicitacaoData objCTCSituacaoSolicitacaoData = new CTCSituacaoSolicitacaoData();

			#region Regras de negócio
			#endregion

			return objCTCSituacaoSolicitacaoData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(CTCSituacaoSolicitacao obj)
		{
			CTCSituacaoSolicitacaoData objCTCSituacaoSolicitacaoData = new CTCSituacaoSolicitacaoData();

			#region Regras de negócio
			#endregion

			objCTCSituacaoSolicitacaoData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(CTCSituacaoSolicitacao obj)
		{
			CTCSituacaoSolicitacaoData objCTCSituacaoSolicitacaoData = new CTCSituacaoSolicitacaoData();

			#region Regras de negócio
			#endregion

			objCTCSituacaoSolicitacaoData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual CTCSituacaoSolicitacao Obtem(int? Id)
		{
			CTCSituacaoSolicitacaoData objCTCSituacaoSolicitacaoData = new CTCSituacaoSolicitacaoData();

			#region Regras de negócio
			#endregion

			return objCTCSituacaoSolicitacaoData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			CTCSituacaoSolicitacaoData objCTCSituacaoSolicitacaoData = new CTCSituacaoSolicitacaoData();

			#region Regras de negócio
			#endregion

			objCTCSituacaoSolicitacaoData.Excluir(Id);
		}
		#endregion

	}
}
