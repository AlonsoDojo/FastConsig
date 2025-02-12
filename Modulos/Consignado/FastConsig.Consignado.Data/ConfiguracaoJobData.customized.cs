
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
	public partial class ConfiguracaoJobData
	{
		
		public ConfiguracaoJobData() {
			this.CustomizeQuery += new CustomizeQueryDelegate(Handle_CustomizeQuery);
		}

      void Handle_CustomizeQuery(QueryBuilder query)
      {
         //*************************************************************************
         //*** OBS: Nao esqueca de criar as propriedades na Entity customized!!! ***
         //*************************************************************************

         //JOIN com a tabela Job
         //------------------------------------------------------------------
         query.Join(ConfiguracaoJob.METADADO.IdJob, Join.Inner, Job.METADADO.Id)
              .Field(Job.METADADO.Name, "NomeJob");
         //     .Field(Job.METADADO.Codigo, "CodigoJob")
         //     .Field(Job.METADADO.Descricao, "DescricaoJob")
         //     .Field(Job.METADADO.IdJobStatus, "IdJobStatusJob");
         //------------------------------------------------------------------


      }

   }
}
