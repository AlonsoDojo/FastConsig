using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.Consignado.Model.DataPrev
{
   public class ErroBaseModel
   {
      [JsonProperty("listaErrosContratos", DefaultValueHandling = DefaultValueHandling.Ignore)]
      public List<ListaErrosContrato> ListaErrosContratos { get; set; }

      [JsonProperty("numeroContrato", NullValueHandling = NullValueHandling.Ignore)]
      public string NumeroContrato { get; set; }

      [JsonProperty("erros", NullValueHandling = NullValueHandling.Ignore)]
      public List<Erro> Erros { get; set; }

      [JsonProperty("hashOperacao", NullValueHandling = NullValueHandling.Ignore)]
      public long? HashOperacao { get; set; }
   }
}
