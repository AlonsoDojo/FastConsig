
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
	public partial class OrgaoSIAPEBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<OrgaoSIAPE> Listar(WhereBuilder filtro)
		{
			OrgaoSIAPEData objOrgaoSIAPEData = new OrgaoSIAPEData();

			#region Regras de negócio
			#endregion

			return objOrgaoSIAPEData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(OrgaoSIAPE obj)
		{
			OrgaoSIAPEData objOrgaoSIAPEData = new OrgaoSIAPEData();

			#region Regras de negócio
			#endregion

			objOrgaoSIAPEData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(OrgaoSIAPE obj)
		{
			OrgaoSIAPEData objOrgaoSIAPEData = new OrgaoSIAPEData();

			#region Regras de negócio
			#endregion

			objOrgaoSIAPEData.Incluir(obj);
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
