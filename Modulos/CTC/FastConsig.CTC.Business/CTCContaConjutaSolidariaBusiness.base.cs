
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
	public partial class CTCContaConjutaSolidariaBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<CTCContaConjutaSolidaria> Listar(WhereBuilder filtro)
		{
			CTCContaConjutaSolidariaData objCTCContaConjutaSolidariaData = new CTCContaConjutaSolidariaData();

			#region Regras de negócio
			#endregion

			return objCTCContaConjutaSolidariaData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(CTCContaConjutaSolidaria obj)
		{
			CTCContaConjutaSolidariaData objCTCContaConjutaSolidariaData = new CTCContaConjutaSolidariaData();

			#region Regras de negócio
			#endregion

			objCTCContaConjutaSolidariaData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(CTCContaConjutaSolidaria obj)
		{
			CTCContaConjutaSolidariaData objCTCContaConjutaSolidariaData = new CTCContaConjutaSolidariaData();

			#region Regras de negócio
			#endregion

			objCTCContaConjutaSolidariaData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual CTCContaConjutaSolidaria Obtem(int? Id)
		{
			CTCContaConjutaSolidariaData objCTCContaConjutaSolidariaData = new CTCContaConjutaSolidariaData();

			#region Regras de negócio
			#endregion

			return objCTCContaConjutaSolidariaData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			CTCContaConjutaSolidariaData objCTCContaConjutaSolidariaData = new CTCContaConjutaSolidariaData();

			#region Regras de negócio
			#endregion

			objCTCContaConjutaSolidariaData.Excluir(Id);
		}
		#endregion

	}
}
