using FastConsig.Core.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.Consignado.Model.DataPrev
{
   public class ReativarEmprestimoConsignadoResponseModel : PropostaBaseModel
   {
      [JsonProperty("competenciaReativacao", NullValueHandling = NullValueHandling.Ignore)]
      public long? CompetenciaReativacao { get; set; }

      [JsonProperty("mensagem", NullValueHandling = NullValueHandling.Ignore)]
      public string Mensagem { get; set; }

      [JsonProperty("numeroContrato", NullValueHandling = NullValueHandling.Ignore)]
      public string NumeroContrato { get; set; }

      [JsonProperty("codigoSucesso", NullValueHandling = NullValueHandling.Ignore)]
      public string CodigoSucesso { get; set; }

      [JsonProperty("hashOperacao", NullValueHandling = NullValueHandling.Ignore)]
      public long? HashOperacao { get; set; }

      public DateTime Date { get; set; }

      public ReativarEmprestimoConsignadoErroModel Error { get; set; }
   }
}
