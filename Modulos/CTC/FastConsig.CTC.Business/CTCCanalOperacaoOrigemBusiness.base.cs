
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
	public partial class CTCCanalOperacaoOrigemBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<CTCCanalOperacaoOrigem> Listar(WhereBuilder filtro)
		{
			CTCCanalOperacaoOrigemData objCTCCanalOperacaoOrigemData = new CTCCanalOperacaoOrigemData();

			#region Regras de negócio
			#endregion

			return objCTCCanalOperacaoOrigemData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(CTCCanalOperacaoOrigem obj)
		{
			CTCCanalOperacaoOrigemData objCTCCanalOperacaoOrigemData = new CTCCanalOperacaoOrigemData();

			#region Regras de negócio
			#endregion

			objCTCCanalOperacaoOrigemData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(CTCCanalOperacaoOrigem obj)
		{
			CTCCanalOperacaoOrigemData objCTCCanalOperacaoOrigemData = new CTCCanalOperacaoOrigemData();

			#region Regras de negócio
			#endregion

			objCTCCanalOperacaoOrigemData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual CTCCanalOperacaoOrigem Obtem(int? Id)
		{
			CTCCanalOperacaoOrigemData objCTCCanalOperacaoOrigemData = new CTCCanalOperacaoOrigemData();

			#region Regras de negócio
			#endregion

			return objCTCCanalOperacaoOrigemData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			CTCCanalOperacaoOrigemData objCTCCanalOperacaoOrigemData = new CTCCanalOperacaoOrigemData();

			#region Regras de negócio
			#endregion

			objCTCCanalOperacaoOrigemData.Excluir(Id);
		}
		#endregion

	}
}
