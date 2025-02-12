
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
	public partial class CTCMotivoRecusaPreReservaGarantiaFGOBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<CTCMotivoRecusaPreReservaGarantiaFGO> Listar(WhereBuilder filtro)
		{
			CTCMotivoRecusaPreReservaGarantiaFGOData objCTCMotivoRecusaPreReservaGarantiaFGOData = new CTCMotivoRecusaPreReservaGarantiaFGOData();

			#region Regras de negócio
			#endregion

			return objCTCMotivoRecusaPreReservaGarantiaFGOData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(CTCMotivoRecusaPreReservaGarantiaFGO obj)
		{
			CTCMotivoRecusaPreReservaGarantiaFGOData objCTCMotivoRecusaPreReservaGarantiaFGOData = new CTCMotivoRecusaPreReservaGarantiaFGOData();

			#region Regras de negócio
			#endregion

			objCTCMotivoRecusaPreReservaGarantiaFGOData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(CTCMotivoRecusaPreReservaGarantiaFGO obj)
		{
			CTCMotivoRecusaPreReservaGarantiaFGOData objCTCMotivoRecusaPreReservaGarantiaFGOData = new CTCMotivoRecusaPreReservaGarantiaFGOData();

			#region Regras de negócio
			#endregion

			objCTCMotivoRecusaPreReservaGarantiaFGOData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual CTCMotivoRecusaPreReservaGarantiaFGO Obtem(int? Id)
		{
			CTCMotivoRecusaPreReservaGarantiaFGOData objCTCMotivoRecusaPreReservaGarantiaFGOData = new CTCMotivoRecusaPreReservaGarantiaFGOData();

			#region Regras de negócio
			#endregion

			return objCTCMotivoRecusaPreReservaGarantiaFGOData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			CTCMotivoRecusaPreReservaGarantiaFGOData objCTCMotivoRecusaPreReservaGarantiaFGOData = new CTCMotivoRecusaPreReservaGarantiaFGOData();

			#region Regras de negócio
			#endregion

			objCTCMotivoRecusaPreReservaGarantiaFGOData.Excluir(Id);
		}
		#endregion

	}
}
