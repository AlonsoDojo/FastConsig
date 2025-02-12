using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FastConsig.Consignado.Model.Serpro.AutorizacoesMargemConsignavelResponse;

namespace FastConsig.Consignado.Model.Serpro
{
   public class VinculosFuncionaisResponseModel
   {
      /// <summary>
      /// Consignado SIAPE
      /// </summary>
      public responseVinculoFuncional VinculoFuncional { get; set; }

      public IncluirContratoV2Request IncluirContratoV2 { get; set; }

      public RenovarContratoV2Request RenovarContratoV2 { get; set; }
   }
}
