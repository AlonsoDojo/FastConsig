using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.Consignado.Model
{
   public enum ConsignadoOcorrenciaAcaoEnum
   {
      Aprovar = 1,
      Reprovar = 2,
      Reenviar = 3,
      Pendenciar = 4
   }

   public enum TipoConsignado
   {
      DataPrev = 1,
      SIAPE = 2
   }

   public enum FilaStatusEnum
   {
      EmFilaProcessamento = 1,
      EmProcessamento = 2,
      Processada = 3,
      NaoProcessada = 5
   }
}
