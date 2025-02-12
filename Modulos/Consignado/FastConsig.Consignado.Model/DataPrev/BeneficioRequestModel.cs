using FastConsig.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.Consignado.Model.DataPrev
{
   public class BeneficioRequestModel : PropostaBaseModel
   {
      /// <summary>
      /// Token de autorização
      /// </summary>
      public string TokenAutorizacao { get; set; }

      /// <summary>
      /// CPF do beneficiário 
      /// </summary>
      public long? Cpf { get; set; }

      public long? NumeroBeneficio { get; set; }

      /// <summary>
      /// CBC da IF solicitante
      /// </summary>
      public long? CodigoSolicitante { get; set; }
   }
}
