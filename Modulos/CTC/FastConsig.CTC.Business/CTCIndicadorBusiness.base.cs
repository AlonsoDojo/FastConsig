
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
	public partial class CTCIndicadorBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<CTCIndicador> Listar(WhereBuilder filtro)
		{
			CTCIndicadorData objCTCIndicadorData = new CTCIndicadorData();

			#region Regras de negócio
			#endregion

			return objCTCIndicadorData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(CTCIndicador obj)
		{
			CTCIndicadorData objCTCIndicadorData = new CTCIndicadorData();

			#region Regras de negócio
			#endregion

			objCTCIndicadorData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(CTCIndicador obj)
		{
			CTCIndicadorData objCTCIndicadorData = new CTCIndicadorData();

			#region Regras de negócio
			#endregion

			objCTCIndicadorData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual CTCIndicador Obtem(int? Id)
		{
			CTCIndicadorData objCTCIndicadorData = new CTCIndicadorData();

			#region Regras de negócio
			#endregion

			return objCTCIndicadorData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			CTCIndicadorData objCTCIndicadorData = new CTCIndicadorData();

			#region Regras de negócio
			#endregion

			objCTCIndicadorData.Excluir(Id);
		}
		#endregion

	}
}
