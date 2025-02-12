
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
	public partial class CTCTipoParteBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<CTCTipoParte> Listar(WhereBuilder filtro)
		{
			CTCTipoParteData objCTCTipoParteData = new CTCTipoParteData();

			#region Regras de negócio
			#endregion

			return objCTCTipoParteData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(CTCTipoParte obj)
		{
			CTCTipoParteData objCTCTipoParteData = new CTCTipoParteData();

			#region Regras de negócio
			#endregion

			objCTCTipoParteData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(CTCTipoParte obj)
		{
			CTCTipoParteData objCTCTipoParteData = new CTCTipoParteData();

			#region Regras de negócio
			#endregion

			objCTCTipoParteData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual CTCTipoParte Obtem(int? Id)
		{
			CTCTipoParteData objCTCTipoParteData = new CTCTipoParteData();

			#region Regras de negócio
			#endregion

			return objCTCTipoParteData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			CTCTipoParteData objCTCTipoParteData = new CTCTipoParteData();

			#region Regras de negócio
			#endregion

			objCTCTipoParteData.Excluir(Id);
		}
		#endregion

	}
}
