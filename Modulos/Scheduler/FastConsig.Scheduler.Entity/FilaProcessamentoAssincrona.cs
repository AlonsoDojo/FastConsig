using Framework.Data;
using Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace FastConsig.Scheduler.Entity
{
   [Serializable]
   [DataContract]
   public partial class FilaProcessamentoAssincrona : EntityBase
   {
      #region Propriedades
      [Key, Identity, DataMember, JsonProperty("Id")]
      public int? Id { get; set; }

      [DataLength(2147483647), MaxLength(2147483647), StringLength(2147483647), DataMember, JsonProperty("Descricao")]
      public string Descricao { get; set; }

      [DataMember, JsonProperty("AguardandoProcessamento")]
      public bool AguardandoProcessamento { get; set; }

      [DataMember, JsonProperty("Processando")]
      public bool Processando { get; set; }

      [DataMember, JsonProperty("Finalizado")]
      public bool Finalizado { get; set; }

      [DataMember, JsonProperty("ComErro")]
      public bool ComErro { get; set; }

      [DataMember, JsonProperty("MaximoTentativas")]
      public int? MaximoTentativas { get; set; }

      [DataMember, JsonProperty("TentativasUtilizadas")]
      public int? TentativasUtilizadas { get; set; }

      [DataMember, JsonProperty("DataInicioAgendada")]
      public DateTime? DataInicioAgendada { get; set; }

      [DataMember, JsonProperty("DataInicio")]
      public DateTime? DataInicio { get; set; }

      [DataMember, JsonProperty("DataFinalizacao")]
      public DateTime? DataFinalizacao { get; set; }

      [DataMember, JsonProperty("DataUltimoErro")]
      public DateTime? DataUltimoErro { get; set; }

      [DataMember, JsonProperty("Chave")]
      public long? Chave { get; set; }

      [DataLength(50), MaxLength(50), StringLength(50), DataMember, JsonProperty("Sistema")]
      public string Sistema { get; set; }

      [DataMember, JsonProperty("Notificar")]
      public bool Notificar { get; set; }

      [DataLength(2147483647), MaxLength(2147483647), StringLength(2147483647), DataMember, JsonProperty("NotificarParametros")]
      public string NotificarParametros { get; set; }

      [ForeignKey, DataMember, JsonProperty("Fila")]
      public int? Fila { get; set; }

      #endregion

      #region Metadados
      public static class METADADO
      {
         public static readonly TableReference tabelaNAME = "FilaProcessamentoAssincrona";
         public static readonly FieldReference Id = "FilaProcessamentoAssincrona.Id";
         public static readonly FieldReference Descricao = "FilaProcessamentoAssincrona.Descricao";
         public static readonly FieldReference AguardandoProcessamento = "FilaProcessamentoAssincrona.AguardandoProcessamento";
         public static readonly FieldReference Processando = "FilaProcessamentoAssincrona.Processando";
         public static readonly FieldReference Finalizado = "FilaProcessamentoAssincrona.Finalizado";
         public static readonly FieldReference ComErro = "FilaProcessamentoAssincrona.ComErro";
         public static readonly FieldReference MaximoTentativas = "FilaProcessamentoAssincrona.MaximoTentativas";
         public static readonly FieldReference TentativasUtilizadas = "FilaProcessamentoAssincrona.TentativasUtilizadas";
         public static readonly FieldReference DataInicioAgendada = "FilaProcessamentoAssincrona.DataInicioAgendada";
         public static readonly FieldReference DataInicio = "FilaProcessamentoAssincrona.DataInicio";
         public static readonly FieldReference DataFinalizacao = "FilaProcessamentoAssincrona.DataFinalizacao";
         public static readonly FieldReference DataUltimoErro = "FilaProcessamentoAssincrona.DataUltimoErro";
         public static readonly FieldReference Chave = "FilaProcessamentoAssincrona.Chave";
         public static readonly FieldReference Sistema = "FilaProcessamentoAssincrona.Sistema";
         public static readonly FieldReference Notificar = "FilaProcessamentoAssincrona.Notificar";
         public static readonly FieldReference NotificarParametros = "FilaProcessamentoAssincrona.NotificarParametros";
         public static readonly FieldReference Fila = "FilaProcessamentoAssincrona.Fila";
      }
      #endregion
   }
}
