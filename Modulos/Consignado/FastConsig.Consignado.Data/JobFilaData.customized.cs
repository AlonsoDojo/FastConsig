
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
	public partial class JobFilaData
	{
		
		public JobFilaData() {
			this.CustomizeQuery += new CustomizeQueryDelegate(Handle_CustomizeQuery);
		}

		void Handle_CustomizeQuery(QueryBuilder query) {
			//*************************************************************************
			//*** OBS: Nao esqueca de criar as propriedades na Entity customized!!! ***
			//*************************************************************************

			//JOIN com a tabela JobFilaStatus
			//------------------------------------------------------------------
			//query.Join(JobFila.METADADO.IdStatus, Join.Inner, JobFilaStatus.METADADO.Id)
			//     .Field(JobFilaStatus.METADADO.Descricao, "DescricaoJobFilaStatus");
			//------------------------------------------------------------------


		}

	}
}
