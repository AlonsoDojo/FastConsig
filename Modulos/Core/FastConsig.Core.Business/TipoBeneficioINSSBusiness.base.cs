
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
	public partial class TipoBeneficioINSSBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<TipoBeneficioINSS> Listar(WhereBuilder filtro)
		{
			TipoBeneficioINSSData objTipoBeneficioINSSData = new TipoBeneficioINSSData();

			#region Regras de negócio
			#endregion

			return objTipoBeneficioINSSData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(TipoBeneficioINSS obj)
		{
			TipoBeneficioINSSData objTipoBeneficioINSSData = new TipoBeneficioINSSData();

			#region Regras de negócio
			#endregion

			objTipoBeneficioINSSData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(TipoBeneficioINSS obj)
		{
			TipoBeneficioINSSData objTipoBeneficioINSSData = new TipoBeneficioINSSData();

			#region Regras de negócio
			#endregion

			objTipoBeneficioINSSData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual TipoBeneficioINSS Obtem(int? Id)
		{
			TipoBeneficioINSSData objTipoBeneficioINSSData = new TipoBeneficioINSSData();

			#region Regras de negócio
			#endregion

			return objTipoBeneficioINSSData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			TipoBeneficioINSSData objTipoBeneficioINSSData = new TipoBeneficioINSSData();

			#region Regras de negócio
			#endregion

			objTipoBeneficioINSSData.Excluir(Id);
		}
		#endregion

	}
}
