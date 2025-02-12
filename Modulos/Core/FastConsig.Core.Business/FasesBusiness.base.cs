
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
	public partial class FasesBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<Fases> Listar(WhereBuilder filtro)
		{
			FasesData objFasesData = new FasesData();

			#region Regras de negócio
			#endregion

			return objFasesData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(Fases obj)
		{
			FasesData objFasesData = new FasesData();

			#region Regras de negócio
			#endregion

			objFasesData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(Fases obj)
		{
			FasesData objFasesData = new FasesData();

			#region Regras de negócio
			#endregion

			objFasesData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual Fases Obtem(int? Id)
		{
			FasesData objFasesData = new FasesData();

			#region Regras de negócio
			#endregion

			return objFasesData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			FasesData objFasesData = new FasesData();

			#region Regras de negócio
			#endregion

			objFasesData.Excluir(Id);
		}
		#endregion

	}
}
