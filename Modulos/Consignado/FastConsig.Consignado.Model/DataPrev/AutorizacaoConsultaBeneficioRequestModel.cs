using FastConsig.Consignado.Model;
using FastConsig.Core.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.Consignado.Model.DataPrev
{
   public class AutorizacaoConsultaBeneficioRequestModel : PropostaBaseModel
   {
      /// <summary>
      /// CPF do beneficiário
      /// </summary>
      [JsonProperty("cpf", NullValueHandling = NullValueHandling.Ignore)]
      public long? Cpf { get; set; }

      /// <summary>
      /// CPF do representante legal do beneficiário
      /// </summary>
      [JsonProperty("cpfRepresentanteLegal", NullValueHandling = NullValueHandling.Ignore)]
      public long? CpfRepresentanteLegal { get; set; }

      /// <summary>
      /// CBC da IF solicitante
      /// </summary>
      [JsonProperty("codigoSolicitante", NullValueHandling = NullValueHandling.Ignore)]
      public long? CodigoSolicitante { get; set; }

      /// <summary>
      /// Tipo do documento de identificação
      /// </summary>
      [JsonProperty("tipoDocumentoIdentificacao", NullValueHandling = NullValueHandling.Ignore)]
      public long? TipoDocumentoIdentificacao { get; set; }

      /// <summary>
      /// Cópia digitalizada do documento de identificação do beneficiário ou do representante legal 
      /// Obs.: Quando for enviado o CPF do representante legal o documento de identificação deverá ser do representante legal
      /// </summary>
      [JsonProperty("documentoIdentificacao", NullValueHandling = NullValueHandling.Ignore)]
      public string DocumentoIdentificacao { get; set; }

      /// <summary>
      /// Termo de Autorização do beneficiário para disponibilização dos dados do benefício para apoiar a contratação do empréstimo consignado.
      /// </summary>
      [JsonProperty("termoAutorizacaoBeneficiario", NullValueHandling = NullValueHandling.Ignore)]
      public string TermoAutorizacaoBeneficiario { get; set; }

      /// <summary>
      /// Chave identificadora do Termo de Autorização assinado pelo beneficiário.
      /// </summary>
      [JsonProperty("chaveIdentificadora", NullValueHandling = NullValueHandling.Ignore)]
      public long? ChaveIdentificadora { get; set; }

      /// <summary>
      /// Número sequencial único da autorização digital do beneficiário.
      /// </summary>
      [JsonProperty("nsuAutorizacaoDigital", NullValueHandling = NullValueHandling.Ignore)]
      public long? NsuAutorizacaoDigital { get; set; }

      /// <summary>
      /// Data e hora da autorização digital do beneficiário.
      /// </summary>
      [JsonProperty("dataHoraAutorizacaoDigital", NullValueHandling = NullValueHandling.Ignore)]
      public string DataHoraAutorizacaoDigital { get; set; }

      /// <summary>
      /// Canal da autorização digital do beneficiário.
      /// </summary>
      [JsonProperty("canalAutorizacaoDigital", NullValueHandling = NullValueHandling.Ignore)]
      public long? CanalAutorizacaoDigital { get; set; }

      /// <summary>
      /// Possui assinatura a rogo
      /// </summary>
      [JsonProperty("possuiAssinaturaRogo", NullValueHandling = NullValueHandling.Ignore)]
      public bool? PossuiAssinaturaRogo { get; set; }

      /// <summary>
      /// Título do termo de autorização (correspondente ao metadado titulo)
      /// </summary>
      [JsonProperty("tituloTermo", NullValueHandling = NullValueHandling.Ignore)]
      public string TituloTermo { get; set; }

      /// <summary>
      /// Pessoa física ou jurídica ou sistema responsável pela produção do termo de autorização(correspondente ao metadado Autor)
      /// </summary>
      [JsonProperty("autorTermo", NullValueHandling = NullValueHandling.Ignore)]
      public string AutorTermo { get; set; }

      /// <summary>
      /// Cidade da assinatura do termo de autorização(correspondente ao metadado Cidade_da_assinatura)
      /// </summary>
      [JsonProperty("cidadeAssinaturaTermo", NullValueHandling = NullValueHandling.Ignore)]
      public string CidadeAssinaturaTermo { get; set; }

      /// <summary>
      /// Data e hora da produção do termo de autorização (correspondente ao metadado Data_hora_criação)
      /// </summary>
      [JsonProperty("dataHoraCriacaoTermo", NullValueHandling = NullValueHandling.Ignore)]
      public string DataHoraCriacaoTermo { get; set; }

      public static implicit operator AutorizacaoConsultaBeneficioRequestModel(ConsignadoAutorizacaoModel model)
      {
         return new AutorizacaoConsultaBeneficioRequestModel
         {
            Cpf = model.CpfCnpj,
            CpfRepresentanteLegal = model.CpfRepresentante,
            CodigoSolicitante = model.CodigoSolicitante,
            TipoDocumentoIdentificacao = model.TipoDocumentoIdentificacao,
            DocumentoIdentificacao = model.DocumentoIdentificacao == null ? null : System.Text.Encoding.UTF8.GetString(model.DocumentoIdentificacao),
            TermoAutorizacaoBeneficiario = model.TermoAutorizacaoBeneficiario == null ? null : System.Text.Encoding.UTF8.GetString(model.TermoAutorizacaoBeneficiario),
            ChaveIdentificadora = model.ChaveIdentificadora,
            NsuAutorizacaoDigital = model.NsuAutorizacaoDigital,
            DataHoraAutorizacaoDigital = model.DataHoraAutorizacaoDigital?.ToString("ddMMyyyyHHmmss"),
            CanalAutorizacaoDigital = model.CanalAutorizacaoDigital,
            PossuiAssinaturaRogo = model.PossuiAssinaturaRogo,
            TituloTermo = model.TituloTermo,
            AutorTermo = model.AutorTermo,
            CidadeAssinaturaTermo = model.CidadeAssinaturaTermo,
            DataHoraCriacaoTermo = model.DataHoraCriacaoTermo?.ToString("ddMMyyyyHHmmss"),
            Proposta = model.Proposta,
            CpfCnpj = model.CpfCnpj,
            Simulacao = model.Simulacao,
            Fase = model.Fase
         };
      }
   }
}
