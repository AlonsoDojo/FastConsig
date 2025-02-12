
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
	public partial class CTCPagamentosRecebidosBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<CTCPagamentosRecebidos> Listar(WhereBuilder filtro)
		{
			CTCPagamentosRecebidosData objCTCPagamentosRecebidosData = new CTCPagamentosRecebidosData();

			#region Regras de negócio
			#endregion

			return objCTCPagamentosRecebidosData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(CTCPagamentosRecebidos obj)
		{
			CTCPagamentosRecebidosData objCTCPagamentosRecebidosData = new CTCPagamentosRecebidosData();

			#region Regras de negócio
			#endregion

			objCTCPagamentosRecebidosData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(CTCPagamentosRecebidos obj)
		{
			CTCPagamentosRecebidosData objCTCPagamentosRecebidosData = new CTCPagamentosRecebidosData();

			#region Regras de negócio
			#endregion

			objCTCPagamentosRecebidosData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual CTCPagamentosRecebidos Obtem(int? Id)
		{
			CTCPagamentosRecebidosData objCTCPagamentosRecebidosData = new CTCPagamentosRecebidosData();

			#region Regras de negócio
			#endregion

			return objCTCPagamentosRecebidosData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		public void ExcluirPor_Requisicao(int? Requisicao)
		{
			CTCPagamentosRecebidosData objCTCPagamentosRecebidosData = new CTCPagamentosRecebidosData();

			#region Regras de negócio
			#endregion

			objCTCPagamentosRecebidosData.ExcluirPor_Requisicao(Requisicao);
		}
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			CTCPagamentosRecebidosData objCTCPagamentosRecebidosData = new CTCPagamentosRecebidosData();

			#region Regras de negócio
			#endregion

			objCTCPagamentosRecebidosData.Excluir(Id);
		}
		#endregion

	}
}
