using FastConsig.Core.Entity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.Core.Model
{
   [Serializable]
   [DataContract]
   public class SimulacaoPropostaModel
   {
      [JsonProperty("Id")]
      [DataMember]
      public int? Id { get; set; }

      [JsonProperty("DataCriacao")]
      [DataMember]
      public DateTime? DataCriacao { get; set; }

      [JsonProperty("Usuario")]
      [DataMember]
      public string Usuario { get; set; }

      [JsonProperty("Promotora")]
      [DataMember]
      public int? Promotora { get; set; }

      [JsonProperty("Cedida")]
      [DataMember]
      public bool Cedida { get; set; }

      [JsonProperty("Prospectivo")]
      [DataMember]
      public bool Prospectivo { get; set; }

      [JsonProperty("Proponente")]
      [DataMember]
      public SimulacaoPessoa Proponente { get; set; }

      [JsonProperty("Operacao")]
      [DataMember]
      public SimulacaoOperacao Operacao { get; set; }

      [JsonIgnore]
      [DataMember]
      public string Celular { get; set; }

      [JsonProperty("Parcelas")]
      [DataMember]
      public List<SimulacaoParcelas> Parcelas { get; set; }

      [JsonIgnore]
      [DataMember]
      public int? IdAcionamento { get; set; }

      [JsonProperty("TipoComunicacao")]
      [DataMember]
      public int? TipoComunicacao { get; set; }

      [JsonProperty("TipoFormalizacao")]
      [DataMember]
      public int? TipoFormalizacao { get; set; }

      [JsonProperty("MetodoAmortizacao")]
      [DataMember]
      public int? MetodoAmortizacao { get; set; }

      [JsonProperty("Taxa")]
      [DataMember]
      public decimal? Taxa { get; set; }

      [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
      [DataMember]
      public string Guid { get; set; }

      [JsonIgnore]
      [DataMember]
      public int? Autorizacao { get; set; }

      [JsonIgnore]
      [DataMember]
      public decimal? ValorMargem { get; set; }

      [JsonProperty("ContratosREFIN")]
      [DataMember]
      [JsonIgnore]
      public List<SimulacaoContratosREFIN> ContratosREFIN { get; set; }

      [JsonProperty("ParcelasREFIN")]
      [DataMember]
      [JsonIgnore]
      public List<SimulacaoParcelasREFIN> ParcelasREFIN { get; set; }

      [JsonProperty("Retencao")]
      [JsonIgnore]
      [DataMember]
      public bool Retencao { get; set; }

      public SimulacaoPropostaModel()
      {
         this.Proponente = new SimulacaoPessoa();
         this.Operacao = new SimulacaoOperacao();
         this.Parcelas = new List<SimulacaoParcelas>();
         this.ContratosREFIN = new List<SimulacaoContratosREFIN>();
         this.ParcelasREFIN = new List<SimulacaoParcelasREFIN>();
      }
   }
}
