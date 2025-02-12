
#region Usings
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;
using Framework.Data;
using FastConsig.Core.Entity;
using FastConsig.Core.Data;
#endregion

namespace FastConsig.Core.Business
{
	public partial class ViewPropostaCheckListBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<ViewPropostaCheckList> Listar(WhereBuilder filtro)
		{
			ViewPropostaCheckListData objViewPropostaCheckListData = new ViewPropostaCheckListData();

			#region Regras de negócio
			#endregion

			return objViewPropostaCheckListData.Listar(filtro);
		}
		#endregion

		#region Obtem
		public virtual ViewPropostaCheckList Obtem(int? Id)
		{
			ViewPropostaCheckListData objViewPropostaCheckListData = new ViewPropostaCheckListData();

			#region Regras de negócio
			#endregion

			return objViewPropostaCheckListData.Obtem(Id);
		}
		#endregion

	}
}
