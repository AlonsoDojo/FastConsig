
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
	public partial class JobFilaJobTentativaData
	{
		
		public JobFilaJobTentativaData() {
			this.CustomizeQuery += new CustomizeQueryDelegate(Handle_CustomizeQuery);
		}

		void Handle_CustomizeQuery(QueryBuilder query) {
			//*************************************************************************
			//*** OBS: Nao esqueca de criar as propriedades na Entity customized!!! ***
			//*************************************************************************

			//JOIN com a tabela JobFilaJob
			//------------------------------------------------------------------
			//query.Join(JobFilaJobTentativa.METADADO.IdFilaJob, Join.Inner, JobFilaJob.METADADO.Id)
			//     .Field(JobFilaJob.METADADO.IdFila, "IdFilaJobFilaJob")
			//     .Field(JobFilaJob.METADADO.IdJob, "IdJobJobFilaJob")
			//     .Field(JobFilaJob.METADADO.IdJobTentativa, "IdJobTentativaJobFilaJob")
			//     .Field(JobFilaJob.METADADO.Status, "StatusJobFilaJob")
			//     .Field(JobFilaJob.METADADO.Content, "ContentJobFilaJob")
			//     .Field(JobFilaJob.METADADO.Predecessor, "PredecessorJobFilaJob");
			//------------------------------------------------------------------

			//JOIN com a tabela JobTentativa
			//------------------------------------------------------------------
			//query.Join(JobFilaJobTentativa.METADADO.IdJobTentativa, Join.Inner, JobTentativa.METADADO.Id)
			//     .Field(JobTentativa.METADADO.IdJob, "IdJobJobTentativa")
			//     .Field(JobTentativa.METADADO.IdJobStatus, "IdJobStatusJobTentativa")
			//     .Field(JobTentativa.METADADO.DtProcessamento, "DtProcessamentoJobTentativa")
			//     .Field(JobTentativa.METADADO.Retorno, "RetornoJobTentativa");
			//------------------------------------------------------------------


		}

	}
}
