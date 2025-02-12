
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
	public partial class TipoTarefaBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<TipoTarefa> Listar(WhereBuilder filtro)
		{
			TipoTarefaData objTipoTarefaData = new TipoTarefaData();

			#region Regras de negócio
			#endregion

			return objTipoTarefaData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(TipoTarefa obj)
		{
			TipoTarefaData objTipoTarefaData = new TipoTarefaData();

			#region Regras de negócio
			#endregion

			objTipoTarefaData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(TipoTarefa obj)
		{
			TipoTarefaData objTipoTarefaData = new TipoTarefaData();

			#region Regras de negócio
			#endregion

			objTipoTarefaData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual TipoTarefa Obtem(int? Id)
		{
			TipoTarefaData objTipoTarefaData = new TipoTarefaData();

			#region Regras de negócio
			#endregion

			return objTipoTarefaData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			TipoTarefaData objTipoTarefaData = new TipoTarefaData();

			#region Regras de negócio
			#endregion

			objTipoTarefaData.Excluir(Id);
		}
		#endregion

	}
}
