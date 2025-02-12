
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
	public partial class StatusBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<Status> Listar(WhereBuilder filtro)
		{
			StatusData objStatusData = new StatusData();

			#region Regras de negócio
			#endregion

			return objStatusData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(Status obj)
		{
			StatusData objStatusData = new StatusData();

			#region Regras de negócio
			#endregion

			objStatusData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(Status obj)
		{
			StatusData objStatusData = new StatusData();

			#region Regras de negócio
			#endregion

			objStatusData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual Status Obtem(int? Id)
		{
			StatusData objStatusData = new StatusData();

			#region Regras de negócio
			#endregion

			return objStatusData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			StatusData objStatusData = new StatusData();

			#region Regras de negócio
			#endregion

			objStatusData.Excluir(Id);
		}
		#endregion

	}
}
