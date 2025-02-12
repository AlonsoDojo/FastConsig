
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
	public partial class EstadoCivilBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<EstadoCivil> Listar(WhereBuilder filtro)
		{
			EstadoCivilData objEstadoCivilData = new EstadoCivilData();

			#region Regras de negócio
			#endregion

			return objEstadoCivilData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(EstadoCivil obj)
		{
			EstadoCivilData objEstadoCivilData = new EstadoCivilData();

			#region Regras de negócio
			#endregion

			objEstadoCivilData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(EstadoCivil obj)
		{
			EstadoCivilData objEstadoCivilData = new EstadoCivilData();

			#region Regras de negócio
			#endregion

			objEstadoCivilData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual EstadoCivil Obtem(int? Id)
		{
			EstadoCivilData objEstadoCivilData = new EstadoCivilData();

			#region Regras de negócio
			#endregion

			return objEstadoCivilData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			EstadoCivilData objEstadoCivilData = new EstadoCivilData();

			#region Regras de negócio
			#endregion

			objEstadoCivilData.Excluir(Id);
		}
		#endregion

	}
}
