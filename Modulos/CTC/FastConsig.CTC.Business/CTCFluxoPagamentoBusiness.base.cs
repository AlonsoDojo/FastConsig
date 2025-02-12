
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
	public partial class CTCFluxoPagamentoBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<CTCFluxoPagamento> Listar(WhereBuilder filtro)
		{
			CTCFluxoPagamentoData objCTCFluxoPagamentoData = new CTCFluxoPagamentoData();

			#region Regras de negócio
			#endregion

			return objCTCFluxoPagamentoData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(CTCFluxoPagamento obj)
		{
			CTCFluxoPagamentoData objCTCFluxoPagamentoData = new CTCFluxoPagamentoData();

			#region Regras de negócio
			#endregion

			objCTCFluxoPagamentoData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(CTCFluxoPagamento obj)
		{
			CTCFluxoPagamentoData objCTCFluxoPagamentoData = new CTCFluxoPagamentoData();

			#region Regras de negócio
			#endregion

			objCTCFluxoPagamentoData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual CTCFluxoPagamento Obtem(int? Id)
		{
			CTCFluxoPagamentoData objCTCFluxoPagamentoData = new CTCFluxoPagamentoData();

			#region Regras de negócio
			#endregion

			return objCTCFluxoPagamentoData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			CTCFluxoPagamentoData objCTCFluxoPagamentoData = new CTCFluxoPagamentoData();

			#region Regras de negócio
			#endregion

			objCTCFluxoPagamentoData.Excluir(Id);
		}
		#endregion

	}
}
