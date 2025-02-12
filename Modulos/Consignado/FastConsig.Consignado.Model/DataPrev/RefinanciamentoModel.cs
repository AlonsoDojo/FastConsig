using FastConsig.Core.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.Consignado.Model.DataPrev
{
   public partial class RefinanciamentoModel : PropostaBaseModel
   {
      [JsonProperty("numeroBeneficio", NullValueHandling = NullValueHandling.Ignore)]
      public long? NumeroBeneficio { get; set; }

      [JsonProperty("codigoSolicitante", NullValueHandling = NullValueHandling.Ignore)]
      public long? CodigoSolicitante { get; set; }

      [JsonProperty("numeroContrato", NullValueHandling = NullValueHandling.Ignore)]
      public string NumeroContrato { get; set; }

      [JsonProperty("competenciaInicioDesconto", NullValueHandling = NullValueHandling.Ignore)]
      public long? CompetenciaInicioDesconto { get; set; }

      [JsonProperty("listaContratosQuitados", NullValueHandling = NullValueHandling.Ignore)]
      public List<ListaContratosQuitado> ListaContratosQuitados { get; set; }

      [JsonProperty("cpfMutuario", NullValueHandling = NullValueHandling.Ignore)]
      public string CpfMutuario { get; set; }

      [JsonProperty("nomeMutuario", NullValueHandling = NullValueHandling.Ignore)]
      public string NomeMutuario { get; set; }

      [JsonProperty("UFAPS", NullValueHandling = NullValueHandling.Ignore)]
      public string Ufaps { get; set; }

      [JsonProperty("classificadorModalidade", NullValueHandling = NullValueHandling.Ignore)]
      public long? ClassificadorModalidade { get; set; }

      [JsonProperty("dataInicioContrato", NullValueHandling = NullValueHandling.Ignore)]
      public string DataInicioContrato { get; set; }

      [JsonProperty("dataFimContrato", NullValueHandling = NullValueHandling.Ignore)]
      public string DataFimContrato { get; set; }

      [JsonProperty("numeroParcelas", NullValueHandling = NullValueHandling.Ignore)]
      public long? NumeroParcelas { get; set; }

      [JsonProperty("valorTroco", NullValueHandling = NullValueHandling.Ignore)]
      public decimal? ValorTroco { get; set; }

      [JsonProperty("valorEmprestimo", NullValueHandling = NullValueHandling.Ignore)]
      public decimal? ValorEmprestimo { get; set; }

      [JsonProperty("valorParcela", NullValueHandling = NullValueHandling.Ignore)]
      public decimal? ValorParcela { get; set; }

      [JsonProperty("valorIOF", NullValueHandling = NullValueHandling.Ignore)]
      public decimal? ValorIof { get; set; }

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

      [JsonProperty("cbcIfPagadora", NullValueHandling = NullValueHandling.Ignore)]
      public long? CbcIfPagadora { get; set; }

      [JsonProperty("agenciaPagadora", NullValueHandling = NullValueHandling.Ignore)]
      public long? AgenciaPagadora { get; set; }

      [JsonProperty("contaCorrente", NullValueHandling = NullValueHandling.Ignore)]
      public string ContaCorrente { get; set; }

      [JsonProperty("DVContaCorrente", NullValueHandling = NullValueHandling.Ignore)]
      public string DvContaCorrente { get; set; }

      [JsonProperty("canalAtendimento", NullValueHandling = NullValueHandling.Ignore)]
      public long? CanalAtendimento { get; set; }

      /// <summary>
      /// Valor em percentual da taxa de juros anual 
      /// V.7.0.0 - IN 148 - Envio de taxas de juros
      /// Retorno TV,TN
      /// </summary>
      [JsonProperty("valorTaxaMensal", NullValueHandling = NullValueHandling.Ignore)]
      public decimal? ValorTaxaMensal { get; set; }

      /// <summary>
      /// Valor em percentual do CET(Custo Efetivo Total) Mensal
      /// V.7.0.0 - IN 148 - Envio de taxas de juros
      /// Retorno OV
      /// </summary>
      [JsonProperty("valorCETMensal", NullValueHandling = NullValueHandling.Ignore)]
      public decimal? ValorCETMensal { get; set; }

      /// <summary>
      /// Data do primeiro desconto
      /// V.7.0.0 - IN 148 - Envio de taxas de juros
      /// Retorno TP
      /// </summary>
      [JsonProperty("dataPrimeiroDesconto", NullValueHandling = NullValueHandling.Ignore)]
      public string DataPrimeiroDesconto { get; set; }

      /// <summary>
      /// Valor que foi pago à título de dívida do cliente
      /// V.7.0.0 - IN 148 - Envio de taxas de juros
      /// Retorno: PJ
      /// </summary>
      [JsonProperty("valorPago", NullValueHandling = NullValueHandling.Ignore)]
      public decimal? ValorPago { get; set; }
   }
}
