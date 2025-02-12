
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
	public partial class JobData
	{
		
		public JobData() {
			this.CustomizeQuery += new CustomizeQueryDelegate(Handle_CustomizeQuery);
		}

		void Handle_CustomizeQuery(QueryBuilder query) {
         //*************************************************************************
         //*** OBS: Nao esqueca de criar as propriedades na Entity customized!!! ***
         //*************************************************************************

         //JOIN com a tabela JobDetalhe
         //------------------------------------------------------------------
         query.Join(Job.METADADO.Id, Join.Left, JobDetalhe.METADADO.IdJob)
              .Field(JobDetalhe.METADADO.Type, "Type")
              .Field(JobDetalhe.METADADO.Debug, "Debug")
              .Field(JobDetalhe.METADADO.LoggingType, "LoggingType")
              .Field(JobDetalhe.METADADO.LoggingLocation, "LoggingLocation")
              .Field(JobDetalhe.METADADO.LoggingMaximumSize, "LoggingMaximumSize");
         //------------------------------------------------------------------

         query.Join(Job.METADADO.IdJobStatus, Join.Left, JobStatus.METADADO.Id)
             .Field(JobStatus.METADADO.Descricao, "Status");


      }

	}
}
