using FastConsig.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.Consignado.Model.DataPrev
{
   public class AutorizarDesbloqueioResponseModel : PropostaBaseModel
   {
      public bool Sucess { get; set; }

      /// <summary>
      /// Somente para tratar resposta de erro
      // </summary>
      public AutorizarDesbloqueioErroModel Error { get; set; }
   }
}
