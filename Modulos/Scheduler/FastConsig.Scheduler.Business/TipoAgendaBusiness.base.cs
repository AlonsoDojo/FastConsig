
#region Usings
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;
using Framework.Data;
using FastConsig.Scheduler.Entity;
using FastConsig.Scheduler.Data;
#endregion

namespace FastConsig.Scheduler.Business
{
	public partial class TipoAgendaBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<TipoAgenda> Listar(WhereBuilder filtro)
		{
			TipoAgendaData objTipoAgendaData = new TipoAgendaData();

			#region Regras de negócio
			#endregion

			return objTipoAgendaData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(TipoAgenda obj)
		{
			TipoAgendaData objTipoAgendaData = new TipoAgendaData();

			#region Regras de negócio
			#endregion

			objTipoAgendaData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(TipoAgenda obj)
		{
			TipoAgendaData objTipoAgendaData = new TipoAgendaData();

			#region Regras de negócio
			#endregion

			objTipoAgendaData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual TipoAgenda Obtem(int? Id)
		{
			TipoAgendaData objTipoAgendaData = new TipoAgendaData();

			#region Regras de negócio
			#endregion

			return objTipoAgendaData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			TipoAgendaData objTipoAgendaData = new TipoAgendaData();

			#region Regras de negócio
			#endregion

			objTipoAgendaData.Excluir(Id);
		}
		#endregion

	}
}
