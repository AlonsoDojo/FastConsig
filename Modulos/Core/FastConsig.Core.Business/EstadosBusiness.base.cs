
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
	public partial class EstadosBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<Estados> Listar(WhereBuilder filtro)
		{
			EstadosData objEstadosData = new EstadosData();

			#region Regras de negócio
			#endregion

			return objEstadosData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(Estados obj)
		{
			EstadosData objEstadosData = new EstadosData();

			#region Regras de negócio
			#endregion

			objEstadosData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(Estados obj)
		{
			EstadosData objEstadosData = new EstadosData();

			#region Regras de negócio
			#endregion

			objEstadosData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual Estados Obtem(string Id)
		{
			EstadosData objEstadosData = new EstadosData();

			#region Regras de negócio
			#endregion

			return objEstadosData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		#endregion

		#region Excluir por PK
		public void Excluir(string Id)
		{
			EstadosData objEstadosData = new EstadosData();

			#region Regras de negócio
			#endregion

			objEstadosData.Excluir(Id);
		}
		#endregion

	}
}
