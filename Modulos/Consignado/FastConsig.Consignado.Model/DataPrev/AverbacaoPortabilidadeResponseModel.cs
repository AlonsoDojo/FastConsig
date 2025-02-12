using FastConsig.Core.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.Consignado.Model.DataPrev
{
   public class AverbacaoPortabilidadeResponseModel : PropostaBaseModel
   {
      [JsonProperty("competenciaInicioDesconto", NullValueHandling = NullValueHandling.Ignore)]
      public long? CompetenciaInicioDesconto { get; set; }

      [JsonProperty("mensagem", NullValueHandling = NullValueHandling.Ignore)]
      public string Mensagem { get; set; }

      [JsonProperty("numeroContrato", NullValueHandling = NullValueHandling.Ignore)]
      public string NumeroContrato { get; set; }

      [JsonProperty("codigoSucesso", NullValueHandling = NullValueHandling.Ignore)]
      public string CodigoSucesso { get; set; }

      [JsonProperty("hashOperacao", NullValueHandling = NullValueHandling.Ignore)]
      public long? HashOperacao { get; set; }

      public AverbacaoPortabilidadeErroModel Error { get; set; }

   }
}
