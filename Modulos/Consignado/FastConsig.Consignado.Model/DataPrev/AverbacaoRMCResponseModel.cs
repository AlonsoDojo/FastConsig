using FastConsig.Core.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.Consignado.Model.DataPrev
{
   public class AverbacaoRMCResponseModel : PropostaBaseModel
   {
      [JsonProperty("numeroContrato")]
      public string NumeroContrato { get; set; }

      [JsonProperty("valorReservado")]
      public long ValorReservado { get; set; }

      [JsonProperty("hashOperacao")]
      public long HashOperacao { get; set; }

      [JsonProperty("codigoSucesso")]
      public string CodigoSucesso { get; set; }

      [JsonProperty("mensagem")]
      public string Mensagem { get; set; }

      /// <summary>
      /// Somente para tratar resposta de erro
      /// </summary>
      public AverbacaoRMCErroModel Erro { get; set; }

   }
}
