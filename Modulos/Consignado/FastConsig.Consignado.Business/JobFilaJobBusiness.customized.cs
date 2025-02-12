
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
	public partial class JobFilaJobBusiness
	{
      public JobFilaJob ObterJob(int? idJob, long? IdFila)
      {
         var filtro = WhereBuilder.Create()
             .Add(JobFilaJob.METADADO.IdJob, Filter.Equal, idJob)
             .Add(JobFilaJob.METADADO.IdFila, Filter.Equal, IdFila);

         return Listar(filtro).FirstOrDefault();
      }

      /// <summary>
      /// Responsavél por obter todos os Jobs associados para a fila
      /// </summary>
      /// <returns></returns>
      public List<JobFilaJob> ObterJobs(long? idFilaIntegracaoLegado) => Listar(WhereBuilder.Create().Add(JobFilaJob.METADADO.IdFila, Filter.Equal, idFilaIntegracaoLegado));
   }
}
