using FastConsig.Core.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.Consignado.Model.DataPrev
{
   public class AutorizarDesbloqueioRequestModel : PropostaBaseModel
   {
      [JsonProperty("cpf", NullValueHandling = NullValueHandling.Ignore)]
      public long? Cpf { get; set; }

      [JsonProperty("numeroBeneficio", NullValueHandling = NullValueHandling.Ignore)]
      public long? NumeroBeneficio { get; set; }

      [JsonProperty("cpfRepresentanteLegal")]
      public object CpfRepresentanteLegal { get; set; }

      [JsonProperty("codigoSolicitante", NullValueHandling = NullValueHandling.Ignore)]
      public long? CodigoSolicitante { get; set; }

      [JsonProperty("tipoDocumentoIdentificacao", NullValueHandling = NullValueHandling.Ignore)]
      public long? TipoDocumentoIdentificacao { get; set; }

      [JsonProperty("documentoIdentificacao")]
      public object DocumentoIdentificacao { get; set; }

      [JsonProperty("termoAutorizacaoBeneficiario")]
      public object TermoAutorizacaoBeneficiario { get; set; }

      [JsonProperty("chaveIdentificadora", NullValueHandling = NullValueHandling.Ignore)]
      public long? ChaveIdentificadora { get; set; }

      [JsonProperty("nsuAutorizacaoDigital", NullValueHandling = NullValueHandling.Ignore)]
      public long? NsuAutorizacaoDigital { get; set; }

      [JsonProperty("dataHoraAutorizacaoDigital", NullValueHandling = NullValueHandling.Ignore)]
      public long? DataHoraAutorizacaoDigital { get; set; }

      [JsonProperty("canalAutorizacaoDigital", NullValueHandling = NullValueHandling.Ignore)]
      public long? CanalAutorizacaoDigital { get; set; }

      [JsonProperty("possuiAssinaturaRogo", NullValueHandling = NullValueHandling.Ignore)]
      public bool? PossuiAssinaturaRogo { get; set; }

      [JsonProperty("tituloTermo", NullValueHandling = NullValueHandling.Ignore)]
      public string TituloTermo { get; set; }

      [JsonProperty("autorTermo", NullValueHandling = NullValueHandling.Ignore)]
      public string AutorTermo { get; set; }

      [JsonProperty("cidadeAssinaturaTermo", NullValueHandling = NullValueHandling.Ignore)]
      public string CidadeAssinaturaTermo { get; set; }

      [JsonProperty("dataHoraCriacaoTermo", NullValueHandling = NullValueHandling.Ignore)]
      public long? DataHoraCriacaoTermo { get; set; }
   }
}
