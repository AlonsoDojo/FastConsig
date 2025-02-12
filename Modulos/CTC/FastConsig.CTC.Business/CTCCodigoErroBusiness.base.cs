
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
	public partial class CTCCodigoErroBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<CTCCodigoErro> Listar(WhereBuilder filtro)
		{
			CTCCodigoErroData objCTCCodigoErroData = new CTCCodigoErroData();

			#region Regras de negócio
			#endregion

			return objCTCCodigoErroData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(CTCCodigoErro obj)
		{
			CTCCodigoErroData objCTCCodigoErroData = new CTCCodigoErroData();

			#region Regras de negócio
			#endregion

			objCTCCodigoErroData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(CTCCodigoErro obj)
		{
			CTCCodigoErroData objCTCCodigoErroData = new CTCCodigoErroData();

			#region Regras de negócio
			#endregion

			objCTCCodigoErroData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual CTCCodigoErro Obtem(int? Id)
		{
			CTCCodigoErroData objCTCCodigoErroData = new CTCCodigoErroData();

			#region Regras de negócio
			#endregion

			return objCTCCodigoErroData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			CTCCodigoErroData objCTCCodigoErroData = new CTCCodigoErroData();

			#region Regras de negócio
			#endregion

			objCTCCodigoErroData.Excluir(Id);
		}
		#endregion

	}
}
