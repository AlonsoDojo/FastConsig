
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
	public partial class JobConsignadoOcorrenciaData
	{
		
		public JobConsignadoOcorrenciaData() {
			this.CustomizeQuery += new CustomizeQueryDelegate(Handle_CustomizeQuery);
		}

		void Handle_CustomizeQuery(QueryBuilder query) {
         //*************************************************************************
         //*** OBS: Nao esqueca de criar as propriedades na Entity customized!!! ***
         //*************************************************************************

         //JOIN com a tabela Job
         //------------------------------------------------------------------
         //query.Join(JobConsignadoOcorrencia.METADADO.JobId, Join.Inner, Job.METADADO.Id)
         //     .Field(Job.METADADO.Name, "NameJob")
         //     .Field(Job.METADADO.Codigo, "CodigoJob")
         //     .Field(Job.METADADO.Descricao, "DescricaoJob")
         //     .Field(Job.METADADO.IdJobStatus, "IdJobStatusJob");
         //------------------------------------------------------------------

         //JOIN com a tabela ConsignadoOcorrencia
         //------------------------------------------------------------------
         query.Join(JobConsignadoOcorrencia.METADADO.ConsignadoOcorrenciaId, Join.Inner, ConsignadoOcorrencia.METADADO.Id)
              .Field(ConsignadoOcorrencia.METADADO.Codigo, "CodigoConsignadoOcorrencia");
         //     .Field(ConsignadoOcorrencia.METADADO.Descricao, "DescricaoConsignadoOcorrencia")
         //     //.Field(ConsignadoOcorrencia.METADADO.Acao, "AcaoConsignadoOcorrencia")
         //     .Field(ConsignadoOcorrencia.METADADO.Ocorrencia, "OcorrenciaConsignadoOcorrencia");
         //------------------------------------------------------------------


      }

   }
}
