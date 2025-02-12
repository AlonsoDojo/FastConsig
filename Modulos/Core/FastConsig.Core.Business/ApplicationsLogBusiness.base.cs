
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
	public partial class ApplicationsLogBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<ApplicationsLog> Listar(WhereBuilder filtro)
		{
			ApplicationsLogData objApplicationsLogData = new ApplicationsLogData();

			#region Regras de negócio
			#endregion

			return objApplicationsLogData.Listar(filtro);
		}
		#endregion

		#region Inserir
		public void Incluir(ApplicationsLog obj)
		{
			ApplicationsLogData objApplicationsLogData = new ApplicationsLogData();

			#region Regras de negócio
			#endregion

			objApplicationsLogData.Incluir(obj);
		}
		#endregion

		#region Obtem
		#endregion

		#region Excluir por FKs
		#endregion

		#region Excluir por PK
		#endregion

	}
}
