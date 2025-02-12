
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
	public partial class CompromissosBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<Compromissos> Listar(WhereBuilder filtro)
		{
			CompromissosData objCompromissosData = new CompromissosData();

			#region Regras de negócio
			#endregion

			return objCompromissosData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(Compromissos obj)
		{
			CompromissosData objCompromissosData = new CompromissosData();

			#region Regras de negócio
			#endregion

			objCompromissosData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(Compromissos obj)
		{
			CompromissosData objCompromissosData = new CompromissosData();

			#region Regras de negócio
			#endregion

			objCompromissosData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual Compromissos Obtem(int? Id)
		{
			CompromissosData objCompromissosData = new CompromissosData();

			#region Regras de negócio
			#endregion

			return objCompromissosData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			CompromissosData objCompromissosData = new CompromissosData();

			#region Regras de negócio
			#endregion

			objCompromissosData.Excluir(Id);
		}
		#endregion

	}
}
