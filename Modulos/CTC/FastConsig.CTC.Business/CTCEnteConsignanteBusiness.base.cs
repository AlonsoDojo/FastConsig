
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
	public partial class CTCEnteConsignanteBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<CTCEnteConsignante> Listar(WhereBuilder filtro)
		{
			CTCEnteConsignanteData objCTCEnteConsignanteData = new CTCEnteConsignanteData();

			#region Regras de negócio
			#endregion

			return objCTCEnteConsignanteData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(CTCEnteConsignante obj)
		{
			CTCEnteConsignanteData objCTCEnteConsignanteData = new CTCEnteConsignanteData();

			#region Regras de negócio
			#endregion

			objCTCEnteConsignanteData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(CTCEnteConsignante obj)
		{
			CTCEnteConsignanteData objCTCEnteConsignanteData = new CTCEnteConsignanteData();

			#region Regras de negócio
			#endregion

			objCTCEnteConsignanteData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual CTCEnteConsignante Obtem(int? Id)
		{
			CTCEnteConsignanteData objCTCEnteConsignanteData = new CTCEnteConsignanteData();

			#region Regras de negócio
			#endregion

			return objCTCEnteConsignanteData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			CTCEnteConsignanteData objCTCEnteConsignanteData = new CTCEnteConsignanteData();

			#region Regras de negócio
			#endregion

			objCTCEnteConsignanteData.Excluir(Id);
		}
		#endregion

	}
}
