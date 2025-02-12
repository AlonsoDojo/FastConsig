
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
	public partial class OrgaoEmissorBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<OrgaoEmissor> Listar(WhereBuilder filtro)
		{
			OrgaoEmissorData objOrgaoEmissorData = new OrgaoEmissorData();

			#region Regras de negócio
			#endregion

			return objOrgaoEmissorData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(OrgaoEmissor obj)
		{
			OrgaoEmissorData objOrgaoEmissorData = new OrgaoEmissorData();

			#region Regras de negócio
			#endregion

			objOrgaoEmissorData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(OrgaoEmissor obj)
		{
			OrgaoEmissorData objOrgaoEmissorData = new OrgaoEmissorData();

			#region Regras de negócio
			#endregion

			objOrgaoEmissorData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual OrgaoEmissor Obtem(int? Id)
		{
			OrgaoEmissorData objOrgaoEmissorData = new OrgaoEmissorData();

			#region Regras de negócio
			#endregion

			return objOrgaoEmissorData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			OrgaoEmissorData objOrgaoEmissorData = new OrgaoEmissorData();

			#region Regras de negócio
			#endregion

			objOrgaoEmissorData.Excluir(Id);
		}
		#endregion

	}
}
