
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
	public partial class CTCEventoTarifaBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<CTCEventoTarifa> Listar(WhereBuilder filtro)
		{
			CTCEventoTarifaData objCTCEventoTarifaData = new CTCEventoTarifaData();

			#region Regras de negócio
			#endregion

			return objCTCEventoTarifaData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(CTCEventoTarifa obj)
		{
			CTCEventoTarifaData objCTCEventoTarifaData = new CTCEventoTarifaData();

			#region Regras de negócio
			#endregion

			objCTCEventoTarifaData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(CTCEventoTarifa obj)
		{
			CTCEventoTarifaData objCTCEventoTarifaData = new CTCEventoTarifaData();

			#region Regras de negócio
			#endregion

			objCTCEventoTarifaData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual CTCEventoTarifa Obtem(int? Id)
		{
			CTCEventoTarifaData objCTCEventoTarifaData = new CTCEventoTarifaData();

			#region Regras de negócio
			#endregion

			return objCTCEventoTarifaData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			CTCEventoTarifaData objCTCEventoTarifaData = new CTCEventoTarifaData();

			#region Regras de negócio
			#endregion

			objCTCEventoTarifaData.Excluir(Id);
		}
		#endregion

	}
}
