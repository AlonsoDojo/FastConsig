
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
	public partial class CTCMotivoRecusaEfetivacaoGarantiaFGOBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<CTCMotivoRecusaEfetivacaoGarantiaFGO> Listar(WhereBuilder filtro)
		{
			CTCMotivoRecusaEfetivacaoGarantiaFGOData objCTCMotivoRecusaEfetivacaoGarantiaFGOData = new CTCMotivoRecusaEfetivacaoGarantiaFGOData();

			#region Regras de negócio
			#endregion

			return objCTCMotivoRecusaEfetivacaoGarantiaFGOData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(CTCMotivoRecusaEfetivacaoGarantiaFGO obj)
		{
			CTCMotivoRecusaEfetivacaoGarantiaFGOData objCTCMotivoRecusaEfetivacaoGarantiaFGOData = new CTCMotivoRecusaEfetivacaoGarantiaFGOData();

			#region Regras de negócio
			#endregion

			objCTCMotivoRecusaEfetivacaoGarantiaFGOData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(CTCMotivoRecusaEfetivacaoGarantiaFGO obj)
		{
			CTCMotivoRecusaEfetivacaoGarantiaFGOData objCTCMotivoRecusaEfetivacaoGarantiaFGOData = new CTCMotivoRecusaEfetivacaoGarantiaFGOData();

			#region Regras de negócio
			#endregion

			objCTCMotivoRecusaEfetivacaoGarantiaFGOData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual CTCMotivoRecusaEfetivacaoGarantiaFGO Obtem(int? Id)
		{
			CTCMotivoRecusaEfetivacaoGarantiaFGOData objCTCMotivoRecusaEfetivacaoGarantiaFGOData = new CTCMotivoRecusaEfetivacaoGarantiaFGOData();

			#region Regras de negócio
			#endregion

			return objCTCMotivoRecusaEfetivacaoGarantiaFGOData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			CTCMotivoRecusaEfetivacaoGarantiaFGOData objCTCMotivoRecusaEfetivacaoGarantiaFGOData = new CTCMotivoRecusaEfetivacaoGarantiaFGOData();

			#region Regras de negócio
			#endregion

			objCTCMotivoRecusaEfetivacaoGarantiaFGOData.Excluir(Id);
		}
		#endregion

	}
}
