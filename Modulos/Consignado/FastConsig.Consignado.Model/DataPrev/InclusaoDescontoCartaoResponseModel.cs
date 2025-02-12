using FastConsig.Core.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.Consignado.Model.DataPrev
{
   public class InclusaoDescontoCartaoResponseModel : PropostaBaseModel
   {
      public long CompetenciaDesconto { get; set; }

      [JsonProperty("numeroBeneficio")]
      public long NumeroBeneficio { get; set; }

      [JsonProperty("codigoSolicitante")]
      public long CodigoSolicitante { get; set; }

      [JsonProperty("numeroContrato")]
      public string NumeroContrato { get; set; }

      [JsonProperty("codigoSucesso")]
      public string CodigoSucesso { get; set; }

      [JsonProperty("mensagem")]
      public string Mensagem { get; set; }

      [JsonProperty("hashOperacao")]
      public long HashOperacao { get; set; }

      /// <summary>
      /// Somente para tratar resposta de erro
      /// </summary>
      public ErrorResponseModel Error { get; set; }

   }
}
