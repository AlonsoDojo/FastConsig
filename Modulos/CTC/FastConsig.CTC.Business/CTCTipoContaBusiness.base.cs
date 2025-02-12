
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
	public partial class CTCTipoContaBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<CTCTipoConta> Listar(WhereBuilder filtro)
		{
			CTCTipoContaData objCTCTipoContaData = new CTCTipoContaData();

			#region Regras de negócio
			#endregion

			return objCTCTipoContaData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(CTCTipoConta obj)
		{
			CTCTipoContaData objCTCTipoContaData = new CTCTipoContaData();

			#region Regras de negócio
			#endregion

			objCTCTipoContaData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(CTCTipoConta obj)
		{
			CTCTipoContaData objCTCTipoContaData = new CTCTipoContaData();

			#region Regras de negócio
			#endregion

			objCTCTipoContaData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual CTCTipoConta Obtem(int? Id)
		{
			CTCTipoContaData objCTCTipoContaData = new CTCTipoContaData();

			#region Regras de negócio
			#endregion

			return objCTCTipoContaData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			CTCTipoContaData objCTCTipoContaData = new CTCTipoContaData();

			#region Regras de negócio
			#endregion

			objCTCTipoContaData.Excluir(Id);
		}
		#endregion

	}
}
