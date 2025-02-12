
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
	public partial class PromotorasBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<Promotoras> Listar(WhereBuilder filtro)
		{
			PromotorasData objPromotorasData = new PromotorasData();

			#region Regras de negócio
			#endregion

			return objPromotorasData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(Promotoras obj)
		{
			PromotorasData objPromotorasData = new PromotorasData();

			#region Regras de negócio
			#endregion

			objPromotorasData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(Promotoras obj)
		{
			PromotorasData objPromotorasData = new PromotorasData();

			#region Regras de negócio
			#endregion

			objPromotorasData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual Promotoras Obtem(int? Id)
		{
			PromotorasData objPromotorasData = new PromotorasData();

			#region Regras de negócio
			#endregion

			return objPromotorasData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		public void ExcluirPor_Gerente(int? Gerente)
		{
			PromotorasData objPromotorasData = new PromotorasData();

			#region Regras de negócio
			#endregion

			objPromotorasData.ExcluirPor_Gerente(Gerente);
		}
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			PromotorasData objPromotorasData = new PromotorasData();

			#region Regras de negócio
			#endregion

			objPromotorasData.Excluir(Id);
		}
		#endregion

	}
}
