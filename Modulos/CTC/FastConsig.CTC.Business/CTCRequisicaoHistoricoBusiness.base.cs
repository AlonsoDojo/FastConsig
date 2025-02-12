
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
	public partial class CTCRequisicaoHistoricoBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<CTCRequisicaoHistorico> Listar(WhereBuilder filtro)
		{
			CTCRequisicaoHistoricoData objCTCRequisicaoHistoricoData = new CTCRequisicaoHistoricoData();

			#region Regras de negócio
			#endregion

			return objCTCRequisicaoHistoricoData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(CTCRequisicaoHistorico obj)
		{
			CTCRequisicaoHistoricoData objCTCRequisicaoHistoricoData = new CTCRequisicaoHistoricoData();

			#region Regras de negócio
			#endregion

			objCTCRequisicaoHistoricoData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(CTCRequisicaoHistorico obj)
		{
			CTCRequisicaoHistoricoData objCTCRequisicaoHistoricoData = new CTCRequisicaoHistoricoData();

			#region Regras de negócio
			#endregion

			objCTCRequisicaoHistoricoData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual CTCRequisicaoHistorico Obtem(int? Id)
		{
			CTCRequisicaoHistoricoData objCTCRequisicaoHistoricoData = new CTCRequisicaoHistoricoData();

			#region Regras de negócio
			#endregion

			return objCTCRequisicaoHistoricoData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		public void ExcluirPor_Requisicao(int? Requisicao)
		{
			CTCRequisicaoHistoricoData objCTCRequisicaoHistoricoData = new CTCRequisicaoHistoricoData();

			#region Regras de negócio
			#endregion

			objCTCRequisicaoHistoricoData.ExcluirPor_Requisicao(Requisicao);
		}
		public void ExcluirPor_Ocorrencia(int? Ocorrencia)
		{
			CTCRequisicaoHistoricoData objCTCRequisicaoHistoricoData = new CTCRequisicaoHistoricoData();

			#region Regras de negócio
			#endregion

			objCTCRequisicaoHistoricoData.ExcluirPor_Ocorrencia(Ocorrencia);
		}
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			CTCRequisicaoHistoricoData objCTCRequisicaoHistoricoData = new CTCRequisicaoHistoricoData();

			#region Regras de negócio
			#endregion

			objCTCRequisicaoHistoricoData.Excluir(Id);
		}
		#endregion

	}
}
