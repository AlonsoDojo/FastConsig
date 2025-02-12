
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
	public partial class CTCTipoContratoBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<CTCTipoContrato> Listar(WhereBuilder filtro)
		{
			CTCTipoContratoData objCTCTipoContratoData = new CTCTipoContratoData();

			#region Regras de negócio
			#endregion

			return objCTCTipoContratoData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(CTCTipoContrato obj)
		{
			CTCTipoContratoData objCTCTipoContratoData = new CTCTipoContratoData();

			#region Regras de negócio
			#endregion

			objCTCTipoContratoData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(CTCTipoContrato obj)
		{
			CTCTipoContratoData objCTCTipoContratoData = new CTCTipoContratoData();

			#region Regras de negócio
			#endregion

			objCTCTipoContratoData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual CTCTipoContrato Obtem(int? Id)
		{
			CTCTipoContratoData objCTCTipoContratoData = new CTCTipoContratoData();

			#region Regras de negócio
			#endregion

			return objCTCTipoContratoData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			CTCTipoContratoData objCTCTipoContratoData = new CTCTipoContratoData();

			#region Regras de negócio
			#endregion

			objCTCTipoContratoData.Excluir(Id);
		}
		#endregion

	}
}
