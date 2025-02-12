using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.Consignado.Model.Serpro
{
   public class CancelarContratoRequest : ContratoBase
   {
      /// <summary>
      /// Data de Operação do contrato(AAAAMMDD)
      /// </summary>
      public string DT_OPERACAO_A { get; set; }
   }
}
