
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
	public partial class JobBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<Job> Listar(WhereBuilder filtro)
		{
			JobData objJobData = new JobData();

			#region Regras de negócio
			#endregion

			return objJobData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(Job obj)
		{
			JobData objJobData = new JobData();

			#region Regras de negócio
			#endregion

			objJobData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(Job obj)
		{
			JobData objJobData = new JobData();

			#region Regras de negócio
			#endregion

			objJobData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual Job Obtem(int? Id)
		{
			JobData objJobData = new JobData();

			#region Regras de negócio
			#endregion

			return objJobData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		public void ExcluirPor_IdJobStatus(string IdJobStatus)
		{
			JobData objJobData = new JobData();

			#region Regras de negócio
			#endregion

			objJobData.ExcluirPor_IdJobStatus(IdJobStatus);
		}
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			JobData objJobData = new JobData();

			#region Regras de negócio
			#endregion

			objJobData.Excluir(Id);
		}
		#endregion

	}
}
