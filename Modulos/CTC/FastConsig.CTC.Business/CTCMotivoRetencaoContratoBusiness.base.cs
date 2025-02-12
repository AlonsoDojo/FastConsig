
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
	public partial class CTCMotivoRetencaoContratoBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<CTCMotivoRetencaoContrato> Listar(WhereBuilder filtro)
		{
			CTCMotivoRetencaoContratoData objCTCMotivoRetencaoContratoData = new CTCMotivoRetencaoContratoData();

			#region Regras de negócio
			#endregion

			return objCTCMotivoRetencaoContratoData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(CTCMotivoRetencaoContrato obj)
		{
			CTCMotivoRetencaoContratoData objCTCMotivoRetencaoContratoData = new CTCMotivoRetencaoContratoData();

			#region Regras de negócio
			#endregion

			objCTCMotivoRetencaoContratoData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(CTCMotivoRetencaoContrato obj)
		{
			CTCMotivoRetencaoContratoData objCTCMotivoRetencaoContratoData = new CTCMotivoRetencaoContratoData();

			#region Regras de negócio
			#endregion

			objCTCMotivoRetencaoContratoData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual CTCMotivoRetencaoContrato Obtem(int? Id)
		{
			CTCMotivoRetencaoContratoData objCTCMotivoRetencaoContratoData = new CTCMotivoRetencaoContratoData();

			#region Regras de negócio
			#endregion

			return objCTCMotivoRetencaoContratoData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			CTCMotivoRetencaoContratoData objCTCMotivoRetencaoContratoData = new CTCMotivoRetencaoContratoData();

			#region Regras de negócio
			#endregion

			objCTCMotivoRetencaoContratoData.Excluir(Id);
		}
		#endregion

	}
}
