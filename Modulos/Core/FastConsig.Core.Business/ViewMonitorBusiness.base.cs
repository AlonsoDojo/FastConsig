
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
	public partial class ViewMonitorBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<ViewMonitor> Listar(WhereBuilder filtro)
		{
			ViewMonitorData objViewMonitorData = new ViewMonitorData();

			#region Regras de negócio
			#endregion

			return objViewMonitorData.Listar(filtro);
		}
		#endregion

		#region Obtem
		public virtual ViewMonitor Obtem(int? Proposta)
		{
			ViewMonitorData objViewMonitorData = new ViewMonitorData();

			#region Regras de negócio
			#endregion

			return objViewMonitorData.Obtem(Proposta);
		}
		#endregion

	}
}
