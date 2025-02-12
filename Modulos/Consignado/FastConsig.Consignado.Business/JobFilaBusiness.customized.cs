
#region Usings
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;
using Framework.Data;
using FastConsig.Consignado.Entity;
using FastConsig.Consignado.Data;
using FastConsig.Consignado.Model;
#endregion

namespace FastConsig.Consignado.Business
{
	public partial class JobFilaBusiness
	{
      /// <summary>
      /// Resposanvl por obter mensagens que ainda no foram processadas, ou seja mensagens com o status "Em Fila de Processamento" e "Em Processamento"...
      /// </summary>        
      /// <returns></returns>
      public List<JobFila> ObterMensagensNaoProcessadas()
      {
         var filtro = WhereBuilder.Create()
                        .Add(Block.Begin)
                        .Add(JobFila.METADADO.IdStatus, Filter.LessOrEqual, (int)FilaStatusEnum.EmProcessamento, Link.Or)
                        .Add(JobFila.METADADO.IdStatus, Filter.Equal, (int)FilaStatusEnum.NaoProcessada, Link.Or)
                        .Add(Block.End);

         return Listar(filtro);
      }

      /// <summary>
      /// Resposanvl por obter mensagens com o filtro informado.
      /// </summary>
      /// <returns></returns>
      public List<JobFila> ObterMensagens(FilaStatusEnum status)
          => new JobFilaBusiness().Listar(WhereBuilder.Create().Add(JobFila.METADADO.IdStatus, Filter.Equal, (int)status));
   }
}
