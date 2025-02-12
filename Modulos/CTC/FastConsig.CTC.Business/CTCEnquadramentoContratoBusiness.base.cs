
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
	public partial class CTCEnquadramentoContratoBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<CTCEnquadramentoContrato> Listar(WhereBuilder filtro)
		{
			CTCEnquadramentoContratoData objCTCEnquadramentoContratoData = new CTCEnquadramentoContratoData();

			#region Regras de negócio
			#endregion

			return objCTCEnquadramentoContratoData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(CTCEnquadramentoContrato obj)
		{
			CTCEnquadramentoContratoData objCTCEnquadramentoContratoData = new CTCEnquadramentoContratoData();

			#region Regras de negócio
			#endregion

			objCTCEnquadramentoContratoData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(CTCEnquadramentoContrato obj)
		{
			CTCEnquadramentoContratoData objCTCEnquadramentoContratoData = new CTCEnquadramentoContratoData();

			#region Regras de negócio
			#endregion

			objCTCEnquadramentoContratoData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual CTCEnquadramentoContrato Obtem(int? Id)
		{
			CTCEnquadramentoContratoData objCTCEnquadramentoContratoData = new CTCEnquadramentoContratoData();

			#region Regras de negócio
			#endregion

			return objCTCEnquadramentoContratoData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			CTCEnquadramentoContratoData objCTCEnquadramentoContratoData = new CTCEnquadramentoContratoData();

			#region Regras de negócio
			#endregion

			objCTCEnquadramentoContratoData.Excluir(Id);
		}
		#endregion

	}
}
