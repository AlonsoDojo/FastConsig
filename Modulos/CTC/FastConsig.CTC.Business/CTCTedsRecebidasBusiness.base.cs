
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
	public partial class CTCTedsRecebidasBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<CTCTedsRecebidas> Listar(WhereBuilder filtro)
		{
			CTCTedsRecebidasData objCTCTedsRecebidasData = new CTCTedsRecebidasData();

			#region Regras de negócio
			#endregion

			return objCTCTedsRecebidasData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(CTCTedsRecebidas obj)
		{
			CTCTedsRecebidasData objCTCTedsRecebidasData = new CTCTedsRecebidasData();

			#region Regras de negócio
			#endregion

			objCTCTedsRecebidasData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(CTCTedsRecebidas obj)
		{
			CTCTedsRecebidasData objCTCTedsRecebidasData = new CTCTedsRecebidasData();

			#region Regras de negócio
			#endregion

			objCTCTedsRecebidasData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual CTCTedsRecebidas Obtem(int? Id)
		{
			CTCTedsRecebidasData objCTCTedsRecebidasData = new CTCTedsRecebidasData();

			#region Regras de negócio
			#endregion

			return objCTCTedsRecebidasData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			CTCTedsRecebidasData objCTCTedsRecebidasData = new CTCTedsRecebidasData();

			#region Regras de negócio
			#endregion

			objCTCTedsRecebidasData.Excluir(Id);
		}
		#endregion

	}
}
