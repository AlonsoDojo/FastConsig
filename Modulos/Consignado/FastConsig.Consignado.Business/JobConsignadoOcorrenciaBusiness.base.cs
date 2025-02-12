
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
	public partial class JobConsignadoOcorrenciaBusiness : BusinessBase
	{
      public List<JobConsignadoOcorrencia> ObterConsignadoOcorrencia(int jobId)
      {
         return Listar(WhereBuilder.Create().Add(JobConsignadoOcorrencia.METADADO.JobId, Filter.Equal, jobId));
      }

      #region Listar todos
      public virtual List<JobConsignadoOcorrencia> Listar(WhereBuilder filtro)
		{
			JobConsignadoOcorrenciaData objJobConsignadoOcorrenciaData = new JobConsignadoOcorrenciaData();

			#region Regras de negócio
			#endregion

			return objJobConsignadoOcorrenciaData.Listar(filtro);
		}
		#endregion

		#region Alterar
		public void Alterar(JobConsignadoOcorrencia obj)
		{
			JobConsignadoOcorrenciaData objJobConsignadoOcorrenciaData = new JobConsignadoOcorrenciaData();

			#region Regras de negócio
			#endregion

			objJobConsignadoOcorrenciaData.Alterar(obj);
		}
		#endregion

		#region Inserir
		public void Incluir(JobConsignadoOcorrencia obj)
		{
			JobConsignadoOcorrenciaData objJobConsignadoOcorrenciaData = new JobConsignadoOcorrenciaData();

			#region Regras de negócio
			#endregion

			objJobConsignadoOcorrenciaData.Incluir(obj);
		}
		#endregion

		#region Obtem
		public virtual JobConsignadoOcorrencia Obtem(int? Id)
		{
			JobConsignadoOcorrenciaData objJobConsignadoOcorrenciaData = new JobConsignadoOcorrenciaData();

			#region Regras de negócio
			#endregion

			return objJobConsignadoOcorrenciaData.Obtem(Id);
		}
		#endregion

		#region Excluir por FKs
		public void ExcluirPor_JobId(int? JobId)
		{
			JobConsignadoOcorrenciaData objJobConsignadoOcorrenciaData = new JobConsignadoOcorrenciaData();

			#region Regras de negócio
			#endregion

			objJobConsignadoOcorrenciaData.ExcluirPor_JobId(JobId);
		}
		#endregion

		#region Excluir por PK
		public void Excluir(int? Id)
		{
			JobConsignadoOcorrenciaData objJobConsignadoOcorrenciaData = new JobConsignadoOcorrenciaData();

			#region Regras de negócio
			#endregion

			objJobConsignadoOcorrenciaData.Excluir(Id);
		}
		#endregion

	}
}
