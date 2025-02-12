using FastConsig.Core.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.Consignado.Model.DataPrev
{
   public class ConsultaEmprestimoConsignadoResponseModel : PropostaBaseModel
   {
      [JsonProperty("codigoSolicitante", NullValueHandling = NullValueHandling.Ignore)]
      public long? CodigoSolicitante { get; set; }

      [JsonProperty("numeroBeneficio", NullValueHandling = NullValueHandling.Ignore)]
      public long? NumeroBeneficio { get; set; }

      [JsonProperty("numeroContrato", NullValueHandling = NullValueHandling.Ignore)]
      public string NumeroContrato { get; set; }

      [JsonProperty("situacaoEmprestimo", NullValueHandling = NullValueHandling.Ignore)]
      public long? SituacaoEmprestimo { get; set; }

      [JsonProperty("descricaoSituacaoEmprestimo", NullValueHandling = NullValueHandling.Ignore)]
      public string DescricaoSituacaoEmprestimo { get; set; }

      [JsonProperty("dataInclusaoEmprestimo", NullValueHandling = NullValueHandling.Ignore)]
      public long? DataInclusaoEmprestimo { get; set; }

      [JsonProperty("classificadorModalidade", NullValueHandling = NullValueHandling.Ignore)]
      public long? ClassificadorModalidade { get; set; }

      [JsonProperty("descricaoClassificadorModalidade", NullValueHandling = NullValueHandling.Ignore)]
      public string DescricaoClassificadorModalidade { get; set; }

      [JsonProperty("classificadorOrigemAverbacao", NullValueHandling = NullValueHandling.Ignore)]
      public ClassificadorOrigemAverbacao ClassificadorOrigemAverbacao { get; set; }

      [JsonProperty("dadosComplementares", NullValueHandling = NullValueHandling.Ignore)]
      public DadosComplementares DadosComplementares { get; set; }

      /// <summary>
      /// Somente para tratar resposta de erro
      /// </summary>
      public ConsultaEmprestimoConsignadoErroModel Erro { get; set; }

   }
}
