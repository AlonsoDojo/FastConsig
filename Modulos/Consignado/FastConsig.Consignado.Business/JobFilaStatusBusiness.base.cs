
#region Usings
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;
using Framework.Data;
using FastConsig.Consignado.Entity;
using FastConsig.Consignado.Data;
#endregion

namespace FastConsig.Consignado.Business
{
	public partial class JobFilaStatusBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<JobFilaStatus> Listar(WhereBuilder filtro)
		{
			JobFilaStatusData objJobFilaStatusData = new JobFilaStatusData();

			#region Regras de negócio
			#endregion

			return objJobFilaStatusData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(JobFilaStatus obj)
		{
			JobFilaStatusData objJobFilaStatusData = new JobFilaStatusData();

			#region Regras de negócio
			#endregion

			objJobFilaStatusData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(JobFilaStatus obj)
		{
			JobFilaStatusData objJobFilaStatusData = new JobFilaStatusData();

			#region Regras de negócio
			#endregion

			objJobFilaStatusData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual JobFilaStatus Obtem(int? Id)
		{
			JobFilaStatusData objJobFilaStatusData = new JobFilaStatusData();

			#region Regras de negócio
			#endregion

			return objJobFilaStatusData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			JobFilaStatusData objJobFilaStatusData = new JobFilaStatusData();

			#region Regras de negócio
			#endregion

			objJobFilaStatusData.Excluir(Id);
		}
		#endregion

	}
}
