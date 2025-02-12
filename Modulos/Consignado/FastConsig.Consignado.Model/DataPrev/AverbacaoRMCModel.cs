using FastConsig.Core.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.Consignado.Model.DataPrev
{
   public class AverbacaoRMCModel : PropostaBaseModel
   {
      [JsonProperty("numeroBeneficio")]
      public long NumeroBeneficio { get; set; }

      [JsonProperty("codigoSolicitante")]
      public long CodigoSolicitante { get; set; }

      [JsonProperty("numeroContrato")]
      public string NumeroContrato { get; set; }

      [JsonProperty("cpfMutuario")]
      public long CpfMutuario { get; set; }

      [JsonProperty("nomeMutuario")]
      public string NomeMutuario { get; set; }

      [JsonProperty("UFAPS")]
      public string Ufaps { get; set; }

      [JsonProperty("dataInicioContrato")]
      public long DataInicioContrato { get; set; }

      [JsonProperty("valorLimiteCartao")]
      public long ValorLimiteCartao { get; set; }

      [JsonProperty("percentualRMC")]
      public long PercentualRmc { get; set; }

      [JsonProperty("CNPJAgenciaBancaria")]
      public string CnpjAgenciaBancaria { get; set; }

      [JsonProperty("CNPJCorrespondente")]
      public long? CnpjCorrespondente { get; set; }

      [JsonProperty("CPFCorrespondente")]
      public long? CpfCorrespondente { get; set; }

      [JsonProperty("cbcIfPagadora")]
      public string CbcIfPagadora { get; set; }

      [JsonProperty("agenciaPagadora")]
      public long AgenciaPagadora { get; set; }

      [JsonProperty("contaCorrente")]
      public long ContaCorrente { get; set; }

      [JsonProperty("DVContaCorrente")]
      public long DvContaCorrente { get; set; }

      [JsonProperty("canalAtendimento")]
      public long CanalAtendimento { get; set; }
   }
}
