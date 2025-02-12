using FastConsig.Consignado.Model.DataPrev;
using FastConsig.Consignado.Model.Serpro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.Consignado.Model
{
   public class ConsignadoDetalhe
   {
      public ConsignadoDetalhe()
      {
         this.VinculoFuncional = new VinculosFuncionaisResponseModel();
      }

      /// <summary>
      /// Consignado INSS DataPrev
      /// </summary>
      public BeneficioResponseModel Beneficio { get; set; }

      /// <summary>
      /// Consignado SIAPE
      /// </summary>
      public VinculosFuncionaisResponseModel VinculoFuncional { get; set; }
   }
}
