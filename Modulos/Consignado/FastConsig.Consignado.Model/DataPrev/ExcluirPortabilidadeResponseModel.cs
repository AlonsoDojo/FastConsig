using FastConsig.Core.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.Consignado.Model.DataPrev
{
   public partial class ExcluirPortabilidadeResponseModel : PropostaBaseModel
   {
      [JsonProperty("listaContratosExcluidos", NullValueHandling = NullValueHandling.Ignore)]
      public List<ListaContratosExcluido> ListaContratosExcluidos { get; set; }

      [JsonProperty("competenciaExclusão", NullValueHandling = NullValueHandling.Ignore)]
      public long? CompetenciaExclusão { get; set; }

      [JsonProperty("hashOperacao", NullValueHandling = NullValueHandling.Ignore)]
      public long? HashOperacao { get; set; }

      [JsonProperty("codigoSucesso", NullValueHandling = NullValueHandling.Ignore)]
      public string CodigoSucesso { get; set; }

      [JsonProperty("mensagem", NullValueHandling = NullValueHandling.Ignore)]
      public string Mensagem { get; set; }

      public ExcluirPortabilidadeErroModel Error { get; set; }
   }
}
