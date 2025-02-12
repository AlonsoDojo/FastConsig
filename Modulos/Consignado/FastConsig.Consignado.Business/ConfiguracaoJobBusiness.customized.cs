
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
	public partial class ConfiguracaoJobBusiness
	{
      public ConfiguracaoJob ObterConfigJob(int? idJob) => Listar(WhereBuilder.Create().Add(ConfiguracaoJob.METADADO.IdJob, Filter.Equal, idJob)).FirstOrDefault();

      public ConfiguracaoJob ObterConfigJobId(int id)
      {

         return Listar(WhereBuilder.Create().Add(ConfiguracaoJob.METADADO.Id, Filter.Equal, id)).FirstOrDefault();

      }
   }
}
