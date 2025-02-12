
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
	public partial class JobStatusBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<JobStatus> Listar(WhereBuilder filtro)
		{
			JobStatusData objJobStatusData = new JobStatusData();

			#region Regras de negócio
			#endregion

			return objJobStatusData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(JobStatus obj)
		{
			JobStatusData objJobStatusData = new JobStatusData();

			#region Regras de negócio
			#endregion

			objJobStatusData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(JobStatus obj)
		{
			JobStatusData objJobStatusData = new JobStatusData();

			#region Regras de negócio
			#endregion

			objJobStatusData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual JobStatus Obtem(string Id)
		{
			JobStatusData objJobStatusData = new JobStatusData();

			#region Regras de negócio
			#endregion

			return objJobStatusData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		#endregion

		#region Excluir por PK
		public void Excluir(string Id)
		{
			JobStatusData objJobStatusData = new JobStatusData();

			#region Regras de negócio
			#endregion

			objJobStatusData.Excluir(Id);
		}
		#endregion

	}
}
