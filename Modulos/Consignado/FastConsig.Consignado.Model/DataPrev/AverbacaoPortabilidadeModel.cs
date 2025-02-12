using FastConsig.Core.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.Consignado.Model.DataPrev
{
   public class AverbacaoPortabilidadeModel : PropostaBaseModel
   {
      [JsonProperty("numeroBeneficio", NullValueHandling = NullValueHandling.Ignore)]
      public long? NumeroBeneficio { get; set; }

      [JsonProperty("numeroUnico", NullValueHandling = NullValueHandling.Ignore)]
      public decimal? NumeroUnico { get; set; }

      [JsonProperty("codigoSolicitante", NullValueHandling = NullValueHandling.Ignore)]
      public long? CodigoSolicitante { get; set; }

      [JsonProperty("competenciaInicioDesconto", NullValueHandling = NullValueHandling.Ignore)]
      public long? CompetenciaInicioDesconto { get; set; }

      [JsonProperty("numeroContrato", NullValueHandling = NullValueHandling.Ignore)]
      public string NumeroContrato { get; set; }

      [JsonProperty("cpfMutuario", NullValueHandling = NullValueHandling.Ignore)]
      public string CpfMutuario { get; set; }

      [JsonProperty("nomeMutuario", NullValueHandling = NullValueHandling.Ignore)]
      public string NomeMutuario { get; set; }

      [JsonProperty("UFAPS", NullValueHandling = NullValueHandling.Ignore)]
      public string Ufaps { get; set; }

      [JsonProperty("dataInicioContrato", NullValueHandling = NullValueHandling.Ignore)]
      public string DataInicioContrato { get; set; }

      [JsonProperty("dataFimContrato", NullValueHandling = NullValueHandling.Ignore)]
      public string DataFimContrato { get; set; }

      [JsonProperty("numeroParcelas", NullValueHandling = NullValueHandling.Ignore)]
      public long? NumeroParcelas { get; set; }

      [JsonProperty("valorEmprestimo", NullValueHandling = NullValueHandling.Ignore)]
      public long? ValorEmprestimo { get; set; }

      [JsonProperty("valorPago", NullValueHandling = NullValueHandling.Ignore)]
      public long? ValorPago { get; set; }

      [JsonProperty("valorParcela", NullValueHandling = NullValueHandling.Ignore)]
      public long? ValorParcela { get; set; }

      [JsonProperty("CNPJAgenciaBancaria", NullValueHandling = NullValueHandling.Ignore)]
      public string CnpjAgenciaBancaria { get; set; }

      [JsonProperty("CNPJCorrespondente")]
      public object CnpjCorrespondente { get; set; }

      [JsonProperty("CPFCorrespondente")]
      public object CpfCorrespondente { get; set; }

      [JsonProperty("valorTaxaAnual", NullValueHandling = NullValueHandling.Ignore)]
      public decimal? ValorTaxaAnual { get; set; }

      [JsonProperty("valorCETAnual", NullValueHandling = NullValueHandling.Ignore)]
      public decimal? ValorCetAnual { get; set; }

      [JsonProperty("canalAtendimento", NullValueHandling = NullValueHandling.Ignore)]
      public long? CanalAtendimento { get; set; }
   }
}
