
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
	public partial class CTCTipoFluxoBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<CTCTipoFluxo> Listar(WhereBuilder filtro)
		{
			CTCTipoFluxoData objCTCTipoFluxoData = new CTCTipoFluxoData();

			#region Regras de negócio
			#endregion

			return objCTCTipoFluxoData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(CTCTipoFluxo obj)
		{
			CTCTipoFluxoData objCTCTipoFluxoData = new CTCTipoFluxoData();

			#region Regras de negócio
			#endregion

			objCTCTipoFluxoData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(CTCTipoFluxo obj)
		{
			CTCTipoFluxoData objCTCTipoFluxoData = new CTCTipoFluxoData();

			#region Regras de negócio
			#endregion

			objCTCTipoFluxoData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual CTCTipoFluxo Obtem(int? Id)
		{
			CTCTipoFluxoData objCTCTipoFluxoData = new CTCTipoFluxoData();

			#region Regras de negócio
			#endregion

			return objCTCTipoFluxoData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			CTCTipoFluxoData objCTCTipoFluxoData = new CTCTipoFluxoData();

			#region Regras de negócio
			#endregion

			objCTCTipoFluxoData.Excluir(Id);
		}
		#endregion

	}
}
