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

namespace FastConsig.Seguranca.Entity
{
   [Serializable]
   [DataContract]
   public partial class UsuarioBloqueio : EntityBase
   {
      #region Propriedades
      [Key, Identity, DataMember, JsonProperty("Id")]
      public int? Id { get; set; }

      [DataLength(14), MaxLength(14), StringLength(14), DataMember, JsonProperty("CpfCnpj")]
      public string CpfCnpj { get; set; }

      [ForeignKey, DataMember, JsonProperty("MotivoBloqueio")]
      public int? MotivoBloqueio { get; set; }

      [DataMember, JsonProperty("DataBloqueio")]
      public DateTime? DataBloqueio { get; set; }

      [DataLength(6), MaxLength(6), StringLength(6), DataMember, JsonProperty("MesAnoReferencia")]
      public string MesAnoReferencia { get; set; }

      [DataMember, JsonProperty("DataInicioBloqueio")]
      public DateTime? DataInicioBloqueio { get; set; }

      [DataMember, JsonProperty("DataFimBloqueio")]
      public DateTime? DataFimBloqueio { get; set; }

      [ForeignKey, DataMember, JsonProperty("OrigemBloqueio")]
      public int? OrigemBloqueio { get; set; }

      #endregion

      #region Metadados
      public static class METADADO
      {
         public static readonly TableReference tabelaNAME = "UsuarioBloqueio";
         public static readonly FieldReference Id = "UsuarioBloqueio.Id";
         public static readonly FieldReference CpfCnpj = "UsuarioBloqueio.CpfCnpj";
         public static readonly FieldReference MotivoBloqueio = "UsuarioBloqueio.MotivoBloqueio";
         public static readonly FieldReference DataBloqueio = "UsuarioBloqueio.DataBloqueio";
         public static readonly FieldReference MesAnoReferencia = "UsuarioBloqueio.MesAnoReferencia";
         public static readonly FieldReference DataInicioBloqueio = "UsuarioBloqueio.DataInicioBloqueio";
         public static readonly FieldReference DataFimBloqueio = "UsuarioBloqueio.DataFimBloqueio";
         public static readonly FieldReference OrigemBloqueio = "UsuarioBloqueio.OrigemBloqueio";
      }
      #endregion
   }
}
