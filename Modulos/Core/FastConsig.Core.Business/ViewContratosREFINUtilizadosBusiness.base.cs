
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
	public partial class ViewContratosREFINUtilizadosBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<ViewContratosREFINUtilizados> Listar(WhereBuilder filtro)
		{
			ViewContratosREFINUtilizadosData objViewContratosREFINUtilizadosData = new ViewContratosREFINUtilizadosData();

			#region Regras de negócio
			#endregion

			return objViewContratosREFINUtilizadosData.Listar(filtro);
		}
		#endregion

		#region Obtem
		public virtual ViewContratosREFINUtilizados Obtem(string CpfCnpj)
		{
			ViewContratosREFINUtilizadosData objViewContratosREFINUtilizadosData = new ViewContratosREFINUtilizadosData();

			#region Regras de negócio
			#endregion

			return objViewContratosREFINUtilizadosData.Obtem(CpfCnpj);
		}
		#endregion

	}
}
