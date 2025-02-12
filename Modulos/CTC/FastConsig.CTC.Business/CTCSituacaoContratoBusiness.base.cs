
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
	public partial class CTCSituacaoContratoBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<CTCSituacaoContrato> Listar(WhereBuilder filtro)
		{
			CTCSituacaoContratoData objCTCSituacaoContratoData = new CTCSituacaoContratoData();

			#region Regras de negócio
			#endregion

			return objCTCSituacaoContratoData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(CTCSituacaoContrato obj)
		{
			CTCSituacaoContratoData objCTCSituacaoContratoData = new CTCSituacaoContratoData();

			#region Regras de negócio
			#endregion

			objCTCSituacaoContratoData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(CTCSituacaoContrato obj)
		{
			CTCSituacaoContratoData objCTCSituacaoContratoData = new CTCSituacaoContratoData();

			#region Regras de negócio
			#endregion

			objCTCSituacaoContratoData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual CTCSituacaoContrato Obtem(int? Id)
		{
			CTCSituacaoContratoData objCTCSituacaoContratoData = new CTCSituacaoContratoData();

			#region Regras de negócio
			#endregion

			return objCTCSituacaoContratoData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			CTCSituacaoContratoData objCTCSituacaoContratoData = new CTCSituacaoContratoData();

			#region Regras de negócio
			#endregion

			objCTCSituacaoContratoData.Excluir(Id);
		}
		#endregion

	}
}
