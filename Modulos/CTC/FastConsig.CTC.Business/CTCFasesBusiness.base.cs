
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
	public partial class CTCFasesBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<CTCFases> Listar(WhereBuilder filtro)
		{
			CTCFasesData objCTCFasesData = new CTCFasesData();

			#region Regras de negócio
			#endregion

			return objCTCFasesData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(CTCFases obj)
		{
			CTCFasesData objCTCFasesData = new CTCFasesData();

			#region Regras de negócio
			#endregion

			objCTCFasesData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(CTCFases obj)
		{
			CTCFasesData objCTCFasesData = new CTCFasesData();

			#region Regras de negócio
			#endregion

			objCTCFasesData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual CTCFases Obtem(int? Id)
		{
			CTCFasesData objCTCFasesData = new CTCFasesData();

			#region Regras de negócio
			#endregion

			return objCTCFasesData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			CTCFasesData objCTCFasesData = new CTCFasesData();

			#region Regras de negócio
			#endregion

			objCTCFasesData.Excluir(Id);
		}
		#endregion

	}
}
