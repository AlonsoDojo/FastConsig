using FastConsig.Core.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.Consignado.Model.DataPrev
{
   internal class ReativacaoEmprestimoConsignadoResponseModel : PropostaBaseModel
   {
      [JsonProperty("numeroContrato")]
      public string NumeroContrato { get; set; }

      [JsonProperty("competenciaReativacao")]
      public long CompetenciaReativacao { get; set; }

      [JsonProperty("hashOperacao")]
      public long HashOperacao { get; set; }

      [JsonProperty("codigoSucesso")]
      public string CodigoSucesso { get; set; }

      [JsonProperty("mensagem")]
      public string Mensagem { get; set; }

      /// <summary>
      /// Somente para tratar resposta de erro
      /// </summary>
      public ErrorResponseModel Error { get; set; }
   }
}
