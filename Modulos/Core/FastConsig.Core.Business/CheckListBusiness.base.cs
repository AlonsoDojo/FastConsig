
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
	public partial class CheckListBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<CheckList> Listar(WhereBuilder filtro)
		{
			CheckListData objCheckListData = new CheckListData();

			#region Regras de negócio
			#endregion

			return objCheckListData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(CheckList obj)
		{
			CheckListData objCheckListData = new CheckListData();

			#region Regras de negócio
			#endregion

			objCheckListData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(CheckList obj)
		{
			CheckListData objCheckListData = new CheckListData();

			#region Regras de negócio
			#endregion

			objCheckListData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual CheckList Obtem(int? Id)
		{
			CheckListData objCheckListData = new CheckListData();

			#region Regras de negócio
			#endregion

			return objCheckListData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			CheckListData objCheckListData = new CheckListData();

			#region Regras de negócio
			#endregion

			objCheckListData.Excluir(Id);
		}
		#endregion

	}
}
