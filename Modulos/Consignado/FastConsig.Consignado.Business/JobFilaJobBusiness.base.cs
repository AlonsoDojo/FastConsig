
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
	public partial class JobFilaJobBusiness : BusinessBase
	{
		
		#region Listar todos
		public virtual List<JobFilaJob> Listar(WhereBuilder filtro)
		{
			JobFilaJobData objJobFilaJobData = new JobFilaJobData();

			#region Regras de negócio
			#endregion

			return objJobFilaJobData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(JobFilaJob obj)
		{
			JobFilaJobData objJobFilaJobData = new JobFilaJobData();

			#region Regras de negócio
			#endregion

			objJobFilaJobData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(JobFilaJob obj)
		{
			JobFilaJobData objJobFilaJobData = new JobFilaJobData();

			#region Regras de negócio
			#endregion

			objJobFilaJobData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual JobFilaJob Obtem(long? Id)
		{
			JobFilaJobData objJobFilaJobData = new JobFilaJobData();

			#region Regras de negócio
			#endregion

			return objJobFilaJobData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		public void ExcluirPor_IdFila(long? IdFila)
		{
			JobFilaJobData objJobFilaJobData = new JobFilaJobData();

			#region Regras de negócio
			#endregion

			objJobFilaJobData.ExcluirPor_IdFila(IdFila);
		}
		public void ExcluirPor_IdJob(int? IdJob)
		{
			JobFilaJobData objJobFilaJobData = new JobFilaJobData();

			#region Regras de negócio
			#endregion

			objJobFilaJobData.ExcluirPor_IdJob(IdJob);
		}
		#endregion

		#region Excluir por PK
		public void Excluir(long? Id)
		{
			JobFilaJobData objJobFilaJobData = new JobFilaJobData();

			#region Regras de negócio
			#endregion

			objJobFilaJobData.Excluir(Id);
		}
		#endregion

	}
}
