
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
	public partial class JobFilaJobTentativaBusiness
	{
      public List<JobFilaJobTentativa> Obter(long? IdFilaIntegracaoLegadoJob)
    => Listar(WhereBuilder.Create().Add(JobFilaJobTentativa.METADADO.IdFilaJob, Filter.Equal, IdFilaIntegracaoLegadoJob));
   }
}
