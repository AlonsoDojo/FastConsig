
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
	public partial class CTCTipoParteDestinoBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<CTCTipoParteDestino> Listar(WhereBuilder filtro)
		{
			CTCTipoParteDestinoData objCTCTipoParteDestinoData = new CTCTipoParteDestinoData();

			#region Regras de negócio
			#endregion

			return objCTCTipoParteDestinoData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(CTCTipoParteDestino obj)
		{
			CTCTipoParteDestinoData objCTCTipoParteDestinoData = new CTCTipoParteDestinoData();

			#region Regras de negócio
			#endregion

			objCTCTipoParteDestinoData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(CTCTipoParteDestino obj)
		{
			CTCTipoParteDestinoData objCTCTipoParteDestinoData = new CTCTipoParteDestinoData();

			#region Regras de negócio
			#endregion

			objCTCTipoParteDestinoData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual CTCTipoParteDestino Obtem(int? Id)
		{
			CTCTipoParteDestinoData objCTCTipoParteDestinoData = new CTCTipoParteDestinoData();

			#region Regras de negócio
			#endregion

			return objCTCTipoParteDestinoData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			CTCTipoParteDestinoData objCTCTipoParteDestinoData = new CTCTipoParteDestinoData();

			#region Regras de negócio
			#endregion

			objCTCTipoParteDestinoData.Excluir(Id);
		}
		#endregion

	}
}
