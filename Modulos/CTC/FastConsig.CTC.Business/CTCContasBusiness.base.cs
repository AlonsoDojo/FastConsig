
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
	public partial class CTCContasBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<CTCContas> Listar(WhereBuilder filtro)
		{
			CTCContasData objCTCContasData = new CTCContasData();

			#region Regras de negócio
			#endregion

			return objCTCContasData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(CTCContas obj)
		{
			CTCContasData objCTCContasData = new CTCContasData();

			#region Regras de negócio
			#endregion

			objCTCContasData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(CTCContas obj)
		{
			CTCContasData objCTCContasData = new CTCContasData();

			#region Regras de negócio
			#endregion

			objCTCContasData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual CTCContas Obtem(int? Id)
		{
			CTCContasData objCTCContasData = new CTCContasData();

			#region Regras de negócio
			#endregion

			return objCTCContasData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		public void ExcluirPor_Banco(string Banco)
		{
			CTCContasData objCTCContasData = new CTCContasData();

			#region Regras de negócio
			#endregion

			objCTCContasData.ExcluirPor_Banco(Banco);
		}
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			CTCContasData objCTCContasData = new CTCContasData();

			#region Regras de negócio
			#endregion

			objCTCContasData.Excluir(Id);
		}
		#endregion

	}
}
