using FastConsig.Core.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.Consignado.Model.DataPrev
{
   public partial class ReverterRefinanciamentoResponseModel : PropostaBaseModel
   {
      [JsonProperty("numeroContratoExcluido", NullValueHandling = NullValueHandling.Ignore)]
      public string NumeroContratoExcluido { get; set; }

      [JsonProperty("listaContratosReativados", NullValueHandling = NullValueHandling.Ignore)]
      public List<ListaContratosReativado> ListaContratosReativados { get; set; }

      [JsonProperty("competenciaReversao", NullValueHandling = NullValueHandling.Ignore)]
      public long? CompetenciaReversao { get; set; }

      [JsonProperty("hashOperacao", NullValueHandling = NullValueHandling.Ignore)]
      public long? HashOperacao { get; set; }

      [JsonProperty("codigoSucesso", NullValueHandling = NullValueHandling.Ignore)]
      public string CodigoSucesso { get; set; }

      [JsonProperty("mensagem", NullValueHandling = NullValueHandling.Ignore)]
      public string Mensagem { get; set; }

      public ReverterRefinanciamentoErroModel Error { get; set; }
   }
}
