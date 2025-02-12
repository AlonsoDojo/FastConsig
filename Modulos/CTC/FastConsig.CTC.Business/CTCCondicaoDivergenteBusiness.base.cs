
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
	public partial class CTCCondicaoDivergenteBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<CTCCondicaoDivergente> Listar(WhereBuilder filtro)
		{
			CTCCondicaoDivergenteData objCTCCondicaoDivergenteData = new CTCCondicaoDivergenteData();

			#region Regras de negócio
			#endregion

			return objCTCCondicaoDivergenteData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(CTCCondicaoDivergente obj)
		{
			CTCCondicaoDivergenteData objCTCCondicaoDivergenteData = new CTCCondicaoDivergenteData();

			#region Regras de negócio
			#endregion

			objCTCCondicaoDivergenteData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(CTCCondicaoDivergente obj)
		{
			CTCCondicaoDivergenteData objCTCCondicaoDivergenteData = new CTCCondicaoDivergenteData();

			#region Regras de negócio
			#endregion

			objCTCCondicaoDivergenteData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual CTCCondicaoDivergente Obtem(int? Id)
		{
			CTCCondicaoDivergenteData objCTCCondicaoDivergenteData = new CTCCondicaoDivergenteData();

			#region Regras de negócio
			#endregion

			return objCTCCondicaoDivergenteData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			CTCCondicaoDivergenteData objCTCCondicaoDivergenteData = new CTCCondicaoDivergenteData();

			#region Regras de negócio
			#endregion

			objCTCCondicaoDivergenteData.Excluir(Id);
		}
		#endregion

	}
}
