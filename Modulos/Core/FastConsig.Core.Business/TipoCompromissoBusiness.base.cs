
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
	public partial class TipoCompromissoBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<TipoCompromisso> Listar(WhereBuilder filtro)
		{
			TipoCompromissoData objTipoCompromissoData = new TipoCompromissoData();

			#region Regras de negócio
			#endregion

			return objTipoCompromissoData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(TipoCompromisso obj)
		{
			TipoCompromissoData objTipoCompromissoData = new TipoCompromissoData();

			#region Regras de negócio
			#endregion

			objTipoCompromissoData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(TipoCompromisso obj)
		{
			TipoCompromissoData objTipoCompromissoData = new TipoCompromissoData();

			#region Regras de negócio
			#endregion

			objTipoCompromissoData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual TipoCompromisso Obtem(int? Id)
		{
			TipoCompromissoData objTipoCompromissoData = new TipoCompromissoData();

			#region Regras de negócio
			#endregion

			return objTipoCompromissoData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			TipoCompromissoData objTipoCompromissoData = new TipoCompromissoData();

			#region Regras de negócio
			#endregion

			objTipoCompromissoData.Excluir(Id);
		}
		#endregion

	}
}
