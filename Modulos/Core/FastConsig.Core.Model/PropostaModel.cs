using FastConsig.Common.Helpers;
using FastConsig.Core.Entity;
using FastConsig.Core.Model.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.Core.Model
{
   /// <summary>
   /// Modelo proposta
   /// </summary>
   [Serializable]
   [DataContract]
   public class PropostaModel : IProposta
   {
      /// <summary>
      /// 
      /// </summary>
      [DataMember, JsonProperty("Id")]
      public int? Id { get; set; }

      /// <summary>
      /// Data criação da proposta.
      /// </summary>
      [DataMember, JsonProperty("DataCriacao")]
      public DateTime? DataCriacao { get; set; }

      /// <summary>
      /// Data alteração da proposta.
      /// </summary>
      [DataMember, JsonProperty("DataAlteracao")]
      public DateTime? DataAlteracao { get; set; }

      /// <summary>
      /// Fase atual da proposta.
      /// </summary>
      [DataMember, JsonProperty("Fase")]
      public int? Fase { get; set; }

      /// <summary>
      /// Status da proposta.
      /// </summary>
      [DataMember, JsonProperty("Status")]
      public int? Status { get; set; }

      /// <summary>
      /// Usuário que criou a proposta.
      /// </summary>
      [DataMember, JsonProperty("Usuario")]
      public string Usuario { get; set; }

      /// <summary>
      /// Observacoes
      /// </summary>
      [DataMember, JsonProperty("Observacoes")]
      public string Observacoes { get; set; }

      /// <summary>
      /// Dados do Gerente.
      /// </summary>
      [DataMember, JsonProperty("Gerente")]
      public Gerentes Gerente { get; set; }

      /// <summary>
      /// Dados da promotora.
      /// </summary>
      [DataMember, JsonProperty("Promotora")]
      public Promotoras Promotora { get; set; }

      /// <summary>
      /// Motivo pelo qual a proposta foi recusada.
      /// </summary>
      [DataMember, JsonProperty("MotivoRecusa")]
      public string MotivoRecusa { get; set; }

      /// <summary>
      /// Não implementado
      /// </summary>
      [DataMember, JsonProperty("Retencao")]
      public bool Retencao { get; set; }

      /// <summary>
      /// Dados do proponente.
      /// </summary>
      [DataMember, JsonProperty("Proponente")]
      public Pessoas Proponente { get; set; }

      [DataMember, JsonProperty("Operacoes")]
      public PropostaOperacao Operacoes { get; set; }

      /// <summary>
      /// Lista de ocorrências.
      /// </summary>
      [DataMember, JsonProperty("Ocorrencias")]
      public List<PropostaOcorrencias> Ocorrencias { get; set; }

      /// <summary>
      /// Arquivos da proposta.
      /// </summary>
      [DataMember, JsonProperty("Arquivos")]
      public List<PropostaArquivos> Arquivos { get; set; }

      /// <summary>
      /// Nome Digitador.
      /// </summary>
      [DataMember, JsonProperty("NomeDigitador")]
      public string NomeDigitador { get; set; }

      /// <summary>
      /// Nome Profissional Certificado.
      /// </summary>
      [DataMember, JsonProperty("NomeProfissionalCertificado")]
      public string NomeProfissionalCertificado { get; set; }

      /// <summary>
      /// Profissional Certificado?
      /// </summary>
      [DataMember, JsonProperty("ProfissionalCertificado")]
      public long? ProfissionalCertificado { get; set; }

      /// <summary>
      /// Proposta Pendente?
      /// </summary>
      [DataMember, JsonProperty("Pendente")]
      public bool Pendente { get; set; }

      /// <summary>
      /// 1 - SMS
      /// 2 - Whatsapp
      /// </summary>
      [DataMember, JsonProperty("TipoComunicado")]
      public int? TipoComunicacao { get; set; }

      /// <summary>
      /// 1 - Digital
      /// 2 - Fisica
      /// </summary>
      [DataMember, JsonProperty("TipoFormalizacao")]
      public int? TipoFormalizacao { get; set; }

      /// <summary>
      /// Usuário que bloqueou a proposta
      /// </summary>
      [DataMember, JsonProperty("UsuarioProposta")]
      public string UsuarioProposta { get; set; }

      /// <summary>
      /// Quantidade de Ocorrências Restritivas
      /// </summary>
      [DataMember, JsonProperty("OcorrenciasRestritivas")]
      public int? OcorrenciasRestritivas { get; set; }

      /// <summary>
      /// Mensagem Interna de Erro
      /// </summary>
      [DataMember, JsonProperty("MensagemInterna")]
      public string MensagemInterna { get; set; }

      /// <summary>
      /// Lista de Contratos de Refinanciamento
      /// </summary>
      [DataMember, JsonProperty("ContratosREFIN")]
      public List<PropostaContratosREFIN> ContratosREFIN { get; set; }

      /// <summary>
      /// Lista de Consultas da Proposta
      /// </summary>
      [DataMember, JsonProperty("Consultas")]
      public List<PropostaHierarquiaConsulta> Consultas { get; set; }

      public PropostaModel()
      {
         this.Gerente = new Gerentes();
         this.Proponente = new Pessoas();
         this.Promotora = new Promotoras();
         this.Operacoes = new PropostaOperacao();
         this.Ocorrencias = new List<PropostaOcorrencias>();
         this.Arquivos = new List<PropostaArquivos>();
         this.ContratosREFIN = new List<PropostaContratosREFIN>();
      }

      public List<string> CompareTo(PropostaModel obj)
      {
         List<string> resultado = new List<string>();

         try
         {
            resultado.AddRange(UtilityHelper.GetChangedProperties<PropostaModel>(this, obj));
            resultado.AddRange(UtilityHelper.GetChangedProperties<Gerentes>(this.Gerente, obj.Gerente));
            resultado.AddRange(UtilityHelper.GetChangedProperties<Pessoas>(this.Proponente, obj.Proponente));
            resultado.AddRange(UtilityHelper.GetChangedProperties<Promotoras>(this.Promotora, obj.Promotora));
         }
         catch (Exception ex)
         {
            throw new Exception("Falha na Comparação dos Objetos", ex);
         }

         return resultado;
      }
   }

}
