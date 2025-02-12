using FastConsig.Core.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.Consignado.Model.DataPrev
{
   public partial class ExclusaoDescontoCartaoResponseModel : PropostaBaseModel
   {
      [JsonProperty("descontosCartaoSucesso", NullValueHandling = NullValueHandling.Ignore)]
      public List<DescontosCartaoSucesso> DescontosCartaoSucesso { get; set; }

      [JsonProperty("descontosCartaoFalha", NullValueHandling = NullValueHandling.Ignore)]
      public List<DescontosCartaoFalha> DescontosCartaoFalha { get; set; }

      [JsonProperty("erros", NullValueHandling = NullValueHandling.Ignore)]
      public List<Erro> Erros { get; set; }
   }
}
