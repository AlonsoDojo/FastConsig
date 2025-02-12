
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
	public partial class GerentesBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<Gerentes> Listar(WhereBuilder filtro)
		{
			GerentesData objGerentesData = new GerentesData();

			#region Regras de negócio
			#endregion

			return objGerentesData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(Gerentes obj)
		{
			GerentesData objGerentesData = new GerentesData();

			#region Regras de negócio
			#endregion

			objGerentesData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(Gerentes obj)
		{
			GerentesData objGerentesData = new GerentesData();

			#region Regras de negócio
			#endregion

			objGerentesData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual Gerentes Obtem(int? Id)
		{
			GerentesData objGerentesData = new GerentesData();

			#region Regras de negócio
			#endregion

			return objGerentesData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			GerentesData objGerentesData = new GerentesData();

			#region Regras de negócio
			#endregion

			objGerentesData.Excluir(Id);
		}
		#endregion

	}
}
