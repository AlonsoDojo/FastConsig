using Framework.Data;
using Framework;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace FastConsig.Scheduler.Entity
{
   [Serializable]
   [DataContract]
   public partial class FilaProcessamentoAssincronaItens : EntityBase
   {
      #region Propriedades
      [Key, Identity, DataMember, JsonProperty("Id")]
      public int? Id { get; set; }

      [ForeignKey, DataMember, JsonProperty("FilaProcessamento")]
      public int? FilaProcessamento { get; set; }

      [DataMember, JsonProperty("Ordem")]
      public int? Ordem { get; set; }

      [DataLength(2147483647), MaxLength(2147483647), StringLength(2147483647), DataMember, JsonProperty("Descricao")]
      public string Descricao { get; set; }

      [DataLength(2147483647), MaxLength(2147483647), StringLength(2147483647), DataMember, JsonProperty("Parametros")]
      public string Parametros { get; set; }

      [DataMember, JsonProperty("AguardandoProcessamento")]
      public bool AguardandoProcessamento { get; set; }

      [DataMember, JsonProperty("ComErro")]
      public bool ComErro { get; set; }

      [DataMember, JsonProperty("EmProcessamento")]
      public bool EmProcessamento { get; set; }

      [DataMember, JsonProperty("Finalizado")]
      public bool Finalizado { get; set; }

      [DataMember, JsonProperty("DataInicio")]
      public DateTime? DataInicio { get; set; }

      [DataMember, JsonProperty("DataFim")]
      public DateTime? DataFim { get; set; }

      [DataLength(2147483647), MaxLength(2147483647), StringLength(2147483647), DataMember, JsonProperty("Mensagem")]
      public string Mensagem { get; set; }

      [DataMember, JsonProperty("Notificar")]
      public bool Notificar { get; set; }

      [DataLength(2147483647), MaxLength(2147483647), StringLength(2147483647), DataMember, JsonProperty("NotificarParametros")]
      public string NotificarParametros { get; set; }

      [DataMember, JsonProperty("Chave")]
      public long? Chave { get; set; }

      #endregion

      #region Metadados
      public static class METADADO
      {
         public static readonly TableReference tabelaNAME = "FilaProcessamentoAssincronaItens";
         public static readonly FieldReference Id = "FilaProcessamentoAssincronaItens.Id";
         public static readonly FieldReference FilaProcessamento = "FilaProcessamentoAssincronaItens.FilaProcessamento";
         public static readonly FieldReference Ordem = "FilaProcessamentoAssincronaItens.Ordem";
         public static readonly FieldReference Descricao = "FilaProcessamentoAssincronaItens.Descricao";
         public static readonly FieldReference Parametros = "FilaProcessamentoAssincronaItens.Parametros";
         public static readonly FieldReference AguardandoProcessamento = "FilaProcessamentoAssincronaItens.AguardandoProcessamento";
         public static readonly FieldReference ComErro = "FilaProcessamentoAssincronaItens.ComErro";
         public static readonly FieldReference EmProcessamento = "FilaProcessamentoAssincronaItens.EmProcessamento";
         public static readonly FieldReference Finalizado = "FilaProcessamentoAssincronaItens.Finalizado";
         public static readonly FieldReference DataInicio = "FilaProcessamentoAssincronaItens.DataInicio";
         public static readonly FieldReference DataFim = "FilaProcessamentoAssincronaItens.DataFim";
         public static readonly FieldReference Mensagem = "FilaProcessamentoAssincronaItens.Mensagem";
         public static readonly FieldReference Notificar = "FilaProcessamentoAssincronaItens.Notificar";
         public static readonly FieldReference NotificarParametros = "FilaProcessamentoAssincronaItens.NotificarParametros";
         public static readonly FieldReference Chave = "FilaProcessamentoAssincronaItens.Chave";
      }
      #endregion
   }
}
