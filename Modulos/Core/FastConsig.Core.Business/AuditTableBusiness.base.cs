
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
	public partial class AuditTableBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<AuditTable> Listar(WhereBuilder filtro)
		{
			AuditTableData objAuditTableData = new AuditTableData();

			#region Regras de negócio
			#endregion

			return objAuditTableData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(AuditTable obj)
		{
			AuditTableData objAuditTableData = new AuditTableData();

			#region Regras de negócio
			#endregion

			objAuditTableData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(AuditTable obj)
		{
			AuditTableData objAuditTableData = new AuditTableData();

			#region Regras de negócio
			#endregion

			objAuditTableData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual AuditTable Obtem(int? ID)
		{
			AuditTableData objAuditTableData = new AuditTableData();

			#region Regras de negócio
			#endregion

			return objAuditTableData.Obtem(ID);
		}
		#endregion

		#region Excluir por FKs
		#endregion

		#region Excluir por PK
		public void Excluir(int? ID)
		{
			AuditTableData objAuditTableData = new AuditTableData();

			#region Regras de negócio
			#endregion

			objAuditTableData.Excluir(ID);
		}
		#endregion

	}
}
