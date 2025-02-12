
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
	public partial class CTCRegimeAmortizacaoBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<CTCRegimeAmortizacao> Listar(WhereBuilder filtro)
		{
			CTCRegimeAmortizacaoData objCTCRegimeAmortizacaoData = new CTCRegimeAmortizacaoData();

			#region Regras de negócio
			#endregion

			return objCTCRegimeAmortizacaoData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(CTCRegimeAmortizacao obj)
		{
			CTCRegimeAmortizacaoData objCTCRegimeAmortizacaoData = new CTCRegimeAmortizacaoData();

			#region Regras de negócio
			#endregion

			objCTCRegimeAmortizacaoData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(CTCRegimeAmortizacao obj)
		{
			CTCRegimeAmortizacaoData objCTCRegimeAmortizacaoData = new CTCRegimeAmortizacaoData();

			#region Regras de negócio
			#endregion

			objCTCRegimeAmortizacaoData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual CTCRegimeAmortizacao Obtem(int? Id)
		{
			CTCRegimeAmortizacaoData objCTCRegimeAmortizacaoData = new CTCRegimeAmortizacaoData();

			#region Regras de negócio
			#endregion

			return objCTCRegimeAmortizacaoData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			CTCRegimeAmortizacaoData objCTCRegimeAmortizacaoData = new CTCRegimeAmortizacaoData();

			#region Regras de negócio
			#endregion

			objCTCRegimeAmortizacaoData.Excluir(Id);
		}
		#endregion

	}
}
