
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
	public partial class CTCTipoEnteConsignanteBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<CTCTipoEnteConsignante> Listar(WhereBuilder filtro)
		{
			CTCTipoEnteConsignanteData objCTCTipoEnteConsignanteData = new CTCTipoEnteConsignanteData();

			#region Regras de negócio
			#endregion

			return objCTCTipoEnteConsignanteData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(CTCTipoEnteConsignante obj)
		{
			CTCTipoEnteConsignanteData objCTCTipoEnteConsignanteData = new CTCTipoEnteConsignanteData();

			#region Regras de negócio
			#endregion

			objCTCTipoEnteConsignanteData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(CTCTipoEnteConsignante obj)
		{
			CTCTipoEnteConsignanteData objCTCTipoEnteConsignanteData = new CTCTipoEnteConsignanteData();

			#region Regras de negócio
			#endregion

			objCTCTipoEnteConsignanteData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual CTCTipoEnteConsignante Obtem(int? Id)
		{
			CTCTipoEnteConsignanteData objCTCTipoEnteConsignanteData = new CTCTipoEnteConsignanteData();

			#region Regras de negócio
			#endregion

			return objCTCTipoEnteConsignanteData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			CTCTipoEnteConsignanteData objCTCTipoEnteConsignanteData = new CTCTipoEnteConsignanteData();

			#region Regras de negócio
			#endregion

			objCTCTipoEnteConsignanteData.Excluir(Id);
		}
		#endregion

	}
}
