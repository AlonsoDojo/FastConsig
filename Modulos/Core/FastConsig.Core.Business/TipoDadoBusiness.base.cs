
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
	public partial class TipoDadoBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<TipoDado> Listar(WhereBuilder filtro)
		{
			TipoDadoData objTipoDadoData = new TipoDadoData();

			#region Regras de negócio
			#endregion

			return objTipoDadoData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(TipoDado obj)
		{
			TipoDadoData objTipoDadoData = new TipoDadoData();

			#region Regras de negócio
			#endregion

			objTipoDadoData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(TipoDado obj)
		{
			TipoDadoData objTipoDadoData = new TipoDadoData();

			#region Regras de negócio
			#endregion

			objTipoDadoData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual TipoDado Obtem(int? Id)
		{
			TipoDadoData objTipoDadoData = new TipoDadoData();

			#region Regras de negócio
			#endregion

			return objTipoDadoData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			TipoDadoData objTipoDadoData = new TipoDadoData();

			#region Regras de negócio
			#endregion

			objTipoDadoData.Excluir(Id);
		}
		#endregion

	}
}
