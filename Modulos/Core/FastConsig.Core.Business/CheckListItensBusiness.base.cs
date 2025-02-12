
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
	public partial class CheckListItensBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<CheckListItens> Listar(WhereBuilder filtro)
		{
			CheckListItensData objCheckListItensData = new CheckListItensData();

			#region Regras de negócio
			#endregion

			return objCheckListItensData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(CheckListItens obj)
		{
			CheckListItensData objCheckListItensData = new CheckListItensData();

			#region Regras de negócio
			#endregion

			objCheckListItensData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(CheckListItens obj)
		{
			CheckListItensData objCheckListItensData = new CheckListItensData();

			#region Regras de negócio
			#endregion

			objCheckListItensData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual CheckListItens Obtem(int? Id)
		{
			CheckListItensData objCheckListItensData = new CheckListItensData();

			#region Regras de negócio
			#endregion

			return objCheckListItensData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		public void ExcluirPor_CheckList(int? CheckList)
		{
			CheckListItensData objCheckListItensData = new CheckListItensData();

			#region Regras de negócio
			#endregion

			objCheckListItensData.ExcluirPor_CheckList(CheckList);
		}
		public void ExcluirPor_TipoDocumento(int? TipoDocumento)
		{
			CheckListItensData objCheckListItensData = new CheckListItensData();

			#region Regras de negócio
			#endregion

			objCheckListItensData.ExcluirPor_TipoDocumento(TipoDocumento);
		}
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			CheckListItensData objCheckListItensData = new CheckListItensData();

			#region Regras de negócio
			#endregion

			objCheckListItensData.Excluir(Id);
		}
		#endregion

	}
}
