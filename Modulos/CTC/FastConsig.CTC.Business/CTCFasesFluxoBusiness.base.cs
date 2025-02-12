
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
	public partial class CTCFasesFluxoBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<CTCFasesFluxo> Listar(WhereBuilder filtro)
		{
			CTCFasesFluxoData objCTCFasesFluxoData = new CTCFasesFluxoData();

			#region Regras de negócio
			#endregion

			return objCTCFasesFluxoData.Listar(filtro);
		}
		#endregion

		#region Obtem
		public virtual CTCFasesFluxo Obtem(int? Id)
		{
			CTCFasesFluxoData objCTCFasesFluxoData = new CTCFasesFluxoData();

			#region Regras de negócio
			#endregion

			return objCTCFasesFluxoData.Obtem(Id);
		}
		#endregion

	}
}
