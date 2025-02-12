
#region Usings
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Framework;
using Framework.Data;
using FastConsig.Consignado.Entity;
#endregion

namespace FastConsig.Consignado.Data
{
	public partial class JobFilaJobData
	{
		
		public JobFilaJobData() {
			this.CustomizeQuery += new CustomizeQueryDelegate(Handle_CustomizeQuery);
		}

		void Handle_CustomizeQuery(QueryBuilder query) {
			//*************************************************************************
			//*** OBS: Nao esqueca de criar as propriedades na Entity customized!!! ***
			//*************************************************************************

			//JOIN com a tabela JobFila
			//------------------------------------------------------------------
			//query.Join(JobFilaJob.METADADO.IdFila, Join.Inner, JobFila.METADADO.Id)
			//     .Field(JobFila.METADADO.Mensagem, "MensagemJobFila")
			//     .Field(JobFila.METADADO.IdStatus, "IdStatusJobFila");
			//------------------------------------------------------------------

			//JOIN com a tabela Job
			//------------------------------------------------------------------
			//query.Join(JobFilaJob.METADADO.IdJob, Join.Inner, Job.METADADO.Id)
			//     .Field(Job.METADADO.Name, "NameJob")
			//     .Field(Job.METADADO.Codigo, "CodigoJob")
			//     .Field(Job.METADADO.Descricao, "DescricaoJob")
			//     .Field(Job.METADADO.IdJobStatus, "IdJobStatusJob");
			//------------------------------------------------------------------


		}

	}
}
