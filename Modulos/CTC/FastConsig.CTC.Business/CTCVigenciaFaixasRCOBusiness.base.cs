
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
	public partial class CTCVigenciaFaixasRCOBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<CTCVigenciaFaixasRCO> Listar(WhereBuilder filtro)
		{
			CTCVigenciaFaixasRCOData objCTCVigenciaFaixasRCOData = new CTCVigenciaFaixasRCOData();

			#region Regras de negócio
			#endregion

			return objCTCVigenciaFaixasRCOData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(CTCVigenciaFaixasRCO obj)
		{
			CTCVigenciaFaixasRCOData objCTCVigenciaFaixasRCOData = new CTCVigenciaFaixasRCOData();

			#region Regras de negócio
			#endregion

			objCTCVigenciaFaixasRCOData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(CTCVigenciaFaixasRCO obj)
		{
			CTCVigenciaFaixasRCOData objCTCVigenciaFaixasRCOData = new CTCVigenciaFaixasRCOData();

			#region Regras de negócio
			#endregion

			objCTCVigenciaFaixasRCOData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual CTCVigenciaFaixasRCO Obtem(int? Id)
		{
			CTCVigenciaFaixasRCOData objCTCVigenciaFaixasRCOData = new CTCVigenciaFaixasRCOData();

			#region Regras de negócio
			#endregion

			return objCTCVigenciaFaixasRCOData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			CTCVigenciaFaixasRCOData objCTCVigenciaFaixasRCOData = new CTCVigenciaFaixasRCOData();

			#region Regras de negócio
			#endregion

			objCTCVigenciaFaixasRCOData.Excluir(Id);
		}
		#endregion

	}
}
