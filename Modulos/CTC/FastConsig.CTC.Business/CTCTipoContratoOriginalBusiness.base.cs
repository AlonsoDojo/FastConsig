
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
	public partial class CTCTipoContratoOriginalBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<CTCTipoContratoOriginal> Listar(WhereBuilder filtro)
		{
			CTCTipoContratoOriginalData objCTCTipoContratoOriginalData = new CTCTipoContratoOriginalData();

			#region Regras de negócio
			#endregion

			return objCTCTipoContratoOriginalData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(CTCTipoContratoOriginal obj)
		{
			CTCTipoContratoOriginalData objCTCTipoContratoOriginalData = new CTCTipoContratoOriginalData();

			#region Regras de negócio
			#endregion

			objCTCTipoContratoOriginalData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(CTCTipoContratoOriginal obj)
		{
			CTCTipoContratoOriginalData objCTCTipoContratoOriginalData = new CTCTipoContratoOriginalData();

			#region Regras de negócio
			#endregion

			objCTCTipoContratoOriginalData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual CTCTipoContratoOriginal Obtem(int? Id)
		{
			CTCTipoContratoOriginalData objCTCTipoContratoOriginalData = new CTCTipoContratoOriginalData();

			#region Regras de negócio
			#endregion

			return objCTCTipoContratoOriginalData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			CTCTipoContratoOriginalData objCTCTipoContratoOriginalData = new CTCTipoContratoOriginalData();

			#region Regras de negócio
			#endregion

			objCTCTipoContratoOriginalData.Excluir(Id);
		}
		#endregion

	}
}
