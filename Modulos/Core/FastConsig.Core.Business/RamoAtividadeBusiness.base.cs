
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
	public partial class RamoAtividadeBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<RamoAtividade> Listar(WhereBuilder filtro)
		{
			RamoAtividadeData objRamoAtividadeData = new RamoAtividadeData();

			#region Regras de negócio
			#endregion

			return objRamoAtividadeData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(RamoAtividade obj)
		{
			RamoAtividadeData objRamoAtividadeData = new RamoAtividadeData();

			#region Regras de negócio
			#endregion

			objRamoAtividadeData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(RamoAtividade obj)
		{
			RamoAtividadeData objRamoAtividadeData = new RamoAtividadeData();

			#region Regras de negócio
			#endregion

			objRamoAtividadeData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual RamoAtividade Obtem(int? Id)
		{
			RamoAtividadeData objRamoAtividadeData = new RamoAtividadeData();

			#region Regras de negócio
			#endregion

			return objRamoAtividadeData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			RamoAtividadeData objRamoAtividadeData = new RamoAtividadeData();

			#region Regras de negócio
			#endregion

			objRamoAtividadeData.Excluir(Id);
		}
		#endregion

	}
}
