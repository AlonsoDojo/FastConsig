
#region Usings
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;
using Framework.Data;
using FastConsig.Core.Entity;
using FastConsig.Core.Data;
#endregion

namespace FastConsig.Core.Business
{
	public partial class CepBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<Cep> Listar(WhereBuilder filtro)
		{
			CepData objCepData = new CepData();

			#region Regras de negócio
			#endregion

			return objCepData.Listar(filtro);
		}
		#endregion

		#region Inserir
		public void Incluir(Cep obj)
		{
			CepData objCepData = new CepData();

			#region Regras de negócio
			#endregion

			objCepData.Incluir(obj);
		}
		#endregion

		#region Obtem
		#endregion

	}
}
