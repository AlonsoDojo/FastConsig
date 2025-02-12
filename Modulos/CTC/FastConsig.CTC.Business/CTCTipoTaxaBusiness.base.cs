
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
	public partial class CTCTipoTaxaBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<CTCTipoTaxa> Listar(WhereBuilder filtro)
		{
			CTCTipoTaxaData objCTCTipoTaxaData = new CTCTipoTaxaData();

			#region Regras de negócio
			#endregion

			return objCTCTipoTaxaData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(CTCTipoTaxa obj)
		{
			CTCTipoTaxaData objCTCTipoTaxaData = new CTCTipoTaxaData();

			#region Regras de negócio
			#endregion

			objCTCTipoTaxaData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(CTCTipoTaxa obj)
		{
			CTCTipoTaxaData objCTCTipoTaxaData = new CTCTipoTaxaData();

			#region Regras de negócio
			#endregion

			objCTCTipoTaxaData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual CTCTipoTaxa Obtem(int? Id)
		{
			CTCTipoTaxaData objCTCTipoTaxaData = new CTCTipoTaxaData();

			#region Regras de negócio
			#endregion

			return objCTCTipoTaxaData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			CTCTipoTaxaData objCTCTipoTaxaData = new CTCTipoTaxaData();

			#region Regras de negócio
			#endregion

			objCTCTipoTaxaData.Excluir(Id);
		}
		#endregion

	}
}
