
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
	public partial class CTCSituacaoProcessamentoBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<CTCSituacaoProcessamento> Listar(WhereBuilder filtro)
		{
			CTCSituacaoProcessamentoData objCTCSituacaoProcessamentoData = new CTCSituacaoProcessamentoData();

			#region Regras de negócio
			#endregion

			return objCTCSituacaoProcessamentoData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(CTCSituacaoProcessamento obj)
		{
			CTCSituacaoProcessamentoData objCTCSituacaoProcessamentoData = new CTCSituacaoProcessamentoData();

			#region Regras de negócio
			#endregion

			objCTCSituacaoProcessamentoData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(CTCSituacaoProcessamento obj)
		{
			CTCSituacaoProcessamentoData objCTCSituacaoProcessamentoData = new CTCSituacaoProcessamentoData();

			#region Regras de negócio
			#endregion

			objCTCSituacaoProcessamentoData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual CTCSituacaoProcessamento Obtem(int? Id)
		{
			CTCSituacaoProcessamentoData objCTCSituacaoProcessamentoData = new CTCSituacaoProcessamentoData();

			#region Regras de negócio
			#endregion

			return objCTCSituacaoProcessamentoData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			CTCSituacaoProcessamentoData objCTCSituacaoProcessamentoData = new CTCSituacaoProcessamentoData();

			#region Regras de negócio
			#endregion

			objCTCSituacaoProcessamentoData.Excluir(Id);
		}
		#endregion

	}
}
