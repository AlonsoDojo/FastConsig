using FastConsig.Core.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.Consignado.Model.DataPrev
{
   public class RefinanciamentoResponseModel : PropostaBaseModel
   {
      [JsonProperty("numeroContrato", NullValueHandling = NullValueHandling.Ignore)]
      public string NumeroContrato { get; set; }

      [JsonProperty("listaContratosQuitados", NullValueHandling = NullValueHandling.Ignore)]
      public List<ListaContratosQuitado> ListaContratosQuitados { get; set; }

      [JsonProperty("competenciaInicioDesconto", NullValueHandling = NullValueHandling.Ignore)]
      public long? CompetenciaInicioDesconto { get; set; }

      [JsonProperty("hashOperacao", NullValueHandling = NullValueHandling.Ignore)]
      public long? HashOperacao { get; set; }

      [JsonProperty("codigoSucesso", NullValueHandling = NullValueHandling.Ignore)]
      public string CodigoSucesso { get; set; }

      [JsonProperty("mensagem", NullValueHandling = NullValueHandling.Ignore)]
      public string Mensagem { get; set; }

      public RefinanciamentoErroModel Error { get; set; }
   }
}
